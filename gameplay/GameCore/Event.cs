using System;
using System.Collections.Generic;
using EASharp;
using GameCore.Data;
using GameCore.Messages;
using GameCore.Workflow;
using Interop;
using PowerUps;
using Victory.DataLayer.Serialization.Event;
using xsd2cpp;

namespace GameCore
{
	// Token: 0x02000234 RID: 564
	[Export]
	public class Event : IDisposable
	{
		// Token: 0x060016EF RID: 5871 RVA: 0x00028094 File Offset: 0x00027094
		[NoExport]
		internal Event(InternalEvent internalEvent, Manager manager, Collection eventDef)
		{
			this.internalEvent = internalEvent;
			this.internalEvent.Ready(this);
			this.manager = manager;
			this.eventDef = eventDef;
			this.eventDef.Modify(this.eventDef.GenerateUniqueKey("DynamicEvent"));
			this.radarMethodList = new List<IRadarMethod>(2);
			IRadarMethod item = Activator.CreateInstance<IRadarMethod>("GameCore.Radar.CopRadarMethod");
			IRadarMethod item2 = Activator.CreateInstance<IRadarMethod>("GameCore.Radar.CoinRadarMethod");
			this.radarMethodList.Add(item);
			this.radarMethodList.Add(item2);
			Mode mode = Activator.CreateInstance<Mode>(this.eventDef.EventFlow().GetKey());
			mode.Event = this;
			this.scoringMethod = Activator.CreateInstance<IScoringMethod>(this.eventDef.ScoringMethod().GetKey());
			this.livePacket = this.scoringMethod.CreateLivePacket();
			this.workflowInstance = WorkflowInstance.Create(mode);
			this.workflowInstance.Completed += this.WorkflowInstance_Completed;
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x000281A0 File Offset: 0x000271A0
		~Event()
		{
			this.Dispose(false);
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x000281D0 File Offset: 0x000271D0
		public virtual void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x000281E0 File Offset: 0x000271E0
		public virtual void Dispose(bool disposing)
		{
			if (!this.isDisposed)
			{
				this.workflowInstance.Completed -= this.WorkflowInstance_Completed;
				this.workflowInstance.Dispose();
				this.workflowInstance = null;
				this.eventDef.Unmodify();
				this.internalEvent.Dispose();
				if (disposing)
				{
					this.DeactivateReferencedTriggers();
					this.entrants.Clear();
					this.livePacket = null;
					this.arbitratedPacket = null;
					this.scoringMethod = null;
				}
				this.isDisposed = true;
			}
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x00028264 File Offset: 0x00027264
		public virtual void Abort(AbortReason reason)
		{
			foreach (EntrantInfo entrantInfo in this.Entrants)
			{
				if (!entrantInfo.ScoringState.HasFinishReason)
				{
					entrantInfo.ScoringState.FinishReason = FinishReason.Aborted;
				}
			}
		}

		// Token: 0x060016F4 RID: 5876 RVA: 0x000282D0 File Offset: 0x000272D0
		public virtual void FinishEntrant(long personaId, FinishReason reason)
		{
			this.FindEntrant(personaId).ScoringState.FinishReason = reason;
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x000282E4 File Offset: 0x000272E4
		public virtual void Run()
		{
			this.manager.Effects.Event = this;
			this.workflowInstance.Start();
		}

		// Token: 0x060016F6 RID: 5878 RVA: 0x00028302 File Offset: 0x00027302
		public virtual void Exit()
		{
			new OnResumePostrace().Post(Ports.Gameplay);
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x00028313 File Offset: 0x00027313
		[NoExport]
		protected void OnEventCompleted()
		{
			this.manager.Effects.Event = null;
			if (this.EventCompleted != null)
			{
				this.EventCompleted(this, new EventCompletedArgs(null));
			}
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x00028340 File Offset: 0x00027340
		public virtual void ActivateReferencedTriggers()
		{
			InternalInstance referrer = InstanceCatalog.Get().Find(this.EventKey);
			this.ActivateReferenced(referrer);
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x00028390 File Offset: 0x00027390
		public virtual void ActivateReferenced(InternalInstance referrer)
		{
			if (null != referrer)
			{
				uint flag = 128u;
				uint connectionCount = referrer.GetConnectionCount();
				uint num = 0u;
				while (num < connectionCount)
				{
					InternalInstance connectionAt = referrer.GetConnectionAt(num);
					if ((!connectionAt.IsTypeOf(ObjType.kObjType_Trigger) && !connectionAt.IsTypeOf(ObjType.kObjType_Marker)) || !connectionAt.IsFlagSet(flag))
					{
						goto IL_E3;
					}
					Collection r = new Collection(connectionAt);
					if (!this.PointsOfInterest.Exists((PointOfInterest t) => t.Equals(r.GetCollection(), r.PointOfInterest().GetCollectionKey())))
					{
						PointOfInterest pointOfInterest = this.Manager.PointsOfInterest.Create(r.GetCollection(), r.PointOfInterest().GetCollectionKey(), r.Position(), r.Rotation());
						if (pointOfInterest != null)
						{
							pointOfInterest.LoadBehaviors(connectionAt.BehaviorOwner());
							this.PointsOfInterest.Add(pointOfInterest);
							pointOfInterest.Enable();
							goto IL_E3;
						}
						goto IL_E3;
					}
					IL_EA:
					num += 1u;
					continue;
					IL_E3:
					this.ActivateReferenced(connectionAt);
					goto IL_EA;
				}
			}
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x00028494 File Offset: 0x00027494
		public virtual void DeactivateReferencedTriggers()
		{
			foreach (PointOfInterest poi in this.PointsOfInterest)
			{
				this.Manager.PointsOfInterest.Dispose(poi);
			}
			this.PointsOfInterest.Clear();
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x000284FC File Offset: 0x000274FC
		[NoExport]
		public void AddOpponent(Opponent opponent)
		{
			this.entrants.Add(new EntrantInfo(opponent));
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x00028528 File Offset: 0x00027528
		internal EntrantInfo FindEntrant(long personId)
		{
			return this.Entrants.Find((EntrantInfo entrant) => entrant.PersonaId == personId);
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x00028559 File Offset: 0x00027559
		internal void CreateArbitratedPacket()
		{
			this.arbitratedPacket = this.ScoringMethod.CreateArbitratedPacket();
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x0002856C File Offset: 0x0002756C
		internal void CleanupArbitratedPacket()
		{
			this.arbitratedPacket = null;
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x00028578 File Offset: 0x00027578
		public virtual void FillRadarPacket(ICallback callback)
		{
			RadarTrackerCollection radarTrackerCollection = new RadarTrackerCollection();
			for (int i = 0; i < this.radarMethodList.Count; i++)
			{
				RadarTracker tracker = radarTrackerCollection.CreateRadarTracker();
				this.radarMethodList[i].Fill(tracker, this);
			}
			callback.Respond(radarTrackerCollection);
			callback.Destroy();
			callback = null;
		}

		// Token: 0x06001700 RID: 5888 RVA: 0x000285CC File Offset: 0x000275CC
		public virtual void FillLivePacket(ICallback callback)
		{
			LivePacket livePacket = this.livePacket;
			livePacket.Reset();
			this.ScoringMethod.Fill(livePacket, this);
			this.ScoringMethod.Sort(this.Entrants);
			int count = this.Entrants.Count;
			for (int i = 0; i < count; i++)
			{
				EntrantInfo entrantInfo = this.Entrants[i];
				if (entrantInfo.ScoringState == null)
				{
					break;
				}
				entrantInfo.ScoringState.Rank = i + 1;
				this.ScoringMethod.Fill(livePacket, entrantInfo);
			}
			callback.Respond(livePacket);
			callback.Destroy();
			callback = null;
		}

		// Token: 0x06001701 RID: 5889 RVA: 0x0002865C File Offset: 0x0002765C
		public virtual void FillArbitratedPacket(ICallback callback)
		{
			ArbitratedPacket arbitratedPacket = this.arbitratedPacket;
			arbitratedPacket.Reset();
			this.ScoringMethod.Fill(arbitratedPacket, this);
			this.ScoringMethod.Sort(this.Entrants);
			int count = this.Entrants.Count;
			for (int i = 0; i < count; i++)
			{
				EntrantInfo entrantInfo = this.Entrants[i];
				if (entrantInfo.ScoringState == null)
				{
					break;
				}
				entrantInfo.ScoringState.Rank = i + 1;
				this.ScoringMethod.Fill(arbitratedPacket, entrantInfo);
			}
			callback.Respond(arbitratedPacket);
			callback.Destroy();
			callback = null;
		}

		// Token: 0x06001702 RID: 5890 RVA: 0x000286EC File Offset: 0x000276EC
		internal virtual void StoreAccolades(Victory.DataLayer.Serialization.Event.Accolades accolades)
		{
			this.accolades = new Interop.Accolades();
			if (accolades.FinalRewards != null)
			{
				this.accolades.Reputation = accolades.FinalRewards.Rep;
				this.accolades.Tokens = accolades.FinalRewards.Tokens;
			}
			if (accolades.OriginalRewards != null)
			{
				this.accolades.OriginalReputation = accolades.OriginalRewards.Rep;
				this.accolades.OriginalTokens = accolades.OriginalRewards.Tokens;
			}
			this.accolades.HasLeveledUp = accolades.HasLeveledUp;
			if (accolades.LuckyDrawInfo != null)
			{
				LuckyDraw luckyDraw = this.accolades.GetLuckyDraw();
				luckyDraw.HasLuckyDraw = (accolades.LuckyDrawInfo.Items != null && accolades.LuckyDrawInfo.Items.Count > 0);
				luckyDraw.SetCardDeck(accolades.LuckyDrawInfo.CardDeck);
				luckyDraw.NumCards = accolades.LuckyDrawInfo.NumCards;
				luckyDraw.NumBoxAnimations = accolades.LuckyDrawInfo.NumBoxAnimations;
				luckyDraw.CurrentStreak = accolades.LuckyDrawInfo.CurrentStreak;
				luckyDraw.IsStreakBroken = accolades.LuckyDrawInfo.IsStreakBroken;
				if (accolades.LuckyDrawInfo.Items != null)
				{
					foreach (LuckyDrawItem luckyDrawItem in accolades.LuckyDrawInfo.Items)
					{
						LuckyItem luckyItem = new LuckyItem();
						luckyItem.SetVirtualItem(luckyDrawItem.VirtualItem);
						luckyItem.SetCategory(luckyDrawItem.VirtualItemType);
						luckyItem.SetDescription(luckyDrawItem.Description);
						luckyItem.SetIcon(luckyDrawItem.Icon);
						luckyItem.Value = luckyDrawItem.RemainingUseCount;
						luckyItem.Price = luckyDrawItem.ResellPrice;
						luckyItem.ItemType = Inventory.GetProductTypeFromString(luckyDrawItem.VirtualItemType);
						luckyItem.WasSold = luckyDrawItem.WasSold;
						luckyItem.PartID = luckyDrawItem.Hash;
						luckyDraw.AddItems(luckyItem);
					}
				}
				if (accolades.LuckyDrawInfo.Boxes != null)
				{
					foreach (LuckyDrawBox luckyDrawBox in accolades.LuckyDrawInfo.Boxes)
					{
						LuckyBox luckyBox = new LuckyBox();
						luckyBox.IsValid = luckyDrawBox.IsValid;
						luckyBox.CategoryId = (LuckyBoxCategory)luckyDrawBox.LuckyDrawSetCategoryId;
						luckyBox.SetCategoryName(luckyDrawBox.LocalizationString);
						luckyDraw.AddBoxes(luckyBox);
					}
				}
			}
			if (accolades.RewardInfo != null)
			{
				foreach (Victory.DataLayer.Serialization.Event.RewardPart rewardPart in accolades.RewardInfo)
				{
					Interop.RewardPart rewardPart2 = new Interop.RewardPart();
					rewardPart2.SetCategory(rewardPart.RewardCategory.ToString());
					if (rewardPart.RepPart != 0)
					{
						rewardPart2.SetName(string.Format("REWARD_TYPE_{0}_REP", rewardPart.RewardType.ToString()));
						rewardPart2.SetType("rep");
						rewardPart2.Value = rewardPart.RepPart;
						this.accolades.AddRewardParts(rewardPart2);
					}
					if (rewardPart.TokenPart != 0)
					{
						rewardPart2.SetName(string.Format("REWARD_TYPE_{0}_TOKEN", rewardPart.RewardType.ToString()));
						rewardPart2.SetType("tokens");
						rewardPart2.Value = rewardPart.TokenPart;
						this.accolades.AddRewardParts(rewardPart2);
					}
				}
			}
			this.ScoringMethod.AccoladesFetched(this.accolades);
		}

		// Token: 0x06001703 RID: 5891 RVA: 0x00028A94 File Offset: 0x00027A94
		public virtual void FillAccoladesPacket(ICallback callback, bool forceFetch)
		{
			if (forceFetch || null == this.accolades)
			{
				if (this.mAccoladesCallback == null)
				{
					this.mAccoladesCallback = callback;
					this.FetchAccolades();
					return;
				}
			}
			else
			{
				callback.Respond(this.accolades);
				callback.Destroy();
				callback = null;
			}
		}

		// Token: 0x06001704 RID: 5892 RVA: 0x00028AE3 File Offset: 0x00027AE3
		public virtual void FetchAccolades()
		{
			this.internalEvent.FetchAccolades();
		}

		// Token: 0x06001705 RID: 5893 RVA: 0x00028AF0 File Offset: 0x00027AF0
		public virtual bool HasAccolades()
		{
			return this.accolades != null;
		}

		// Token: 0x06001706 RID: 5894 RVA: 0x00028B00 File Offset: 0x00027B00
		public virtual void AccoladesFetched(XmlString xmlString)
		{
			Victory.DataLayer.Serialization.Event.Accolades accolades;
			if (!XSD2CPP.ReadAccolades(xmlString, out accolades))
			{
				accolades = new Victory.DataLayer.Serialization.Event.Accolades();
			}
			this.StoreAccolades(accolades);
			if (this.mAccoladesCallback != null)
			{
				this.mAccoladesCallback.Respond(this.accolades);
				this.mAccoladesCallback.Destroy();
				this.mAccoladesCallback = null;
			}
		}

		// Token: 0x06001707 RID: 5895 RVA: 0x00028B55 File Offset: 0x00027B55
		public virtual void AccoladesFailed()
		{
			if (this.mAccoladesCallback != null)
			{
				this.mAccoladesCallback.Abort();
				this.mAccoladesCallback.Destroy();
				this.mAccoladesCallback = null;
			}
		}

		// Token: 0x06001708 RID: 5896 RVA: 0x00028B84 File Offset: 0x00027B84
		public virtual bool IsPowerupRestricted(Restriction restriction, long personaId)
		{
			EntrantInfo entrantInfo = this.FindEntrant(personaId);
			return entrantInfo == null || this.ScoringMethod.IsPowerupRestricted(restriction, entrantInfo, this);
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x00028BAC File Offset: 0x00027BAC
		public virtual void OnCollectCoinSucceeded(XmlString xmlString)
		{
			Victory.DataLayer.Serialization.Event.Accolades accolades;
			if (XSD2CPP.ReadAccolades(xmlString, out accolades))
			{
				this.StoreAccolades(accolades);
				new OnHuntCompleted().Post(Ports.Gameplay);
				return;
			}
			new OnHuntContinued().Post(Ports.Gameplay);
		}

		// Token: 0x0600170A RID: 5898 RVA: 0x00028BE9 File Offset: 0x00027BE9
		public void OnCollectCoinFailed()
		{
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x0600170B RID: 5899 RVA: 0x00028BEB File Offset: 0x00027BEB
		// (remove) Token: 0x0600170C RID: 5900 RVA: 0x00028C04 File Offset: 0x00027C04
		internal event EventHandler<EventCompletedArgs> EventCompleted;

		// Token: 0x0600170D RID: 5901 RVA: 0x00028C1D File Offset: 0x00027C1D
		private void WorkflowInstance_Completed(object sender, EventArgs e)
		{
			this.OnEventCompleted();
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x0600170E RID: 5902 RVA: 0x00028C25 File Offset: 0x00027C25
		internal uint EventKey
		{
			get
			{
				return this.eventDef.GetCollection();
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x0600170F RID: 5903 RVA: 0x00028C32 File Offset: 0x00027C32
		internal uint EventId
		{
			get
			{
				return this.eventDef.EventId();
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06001710 RID: 5904 RVA: 0x00028C3F File Offset: 0x00027C3F
		internal uint EventMode
		{
			get
			{
				return (uint)this.EventDef.EventModeId();
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06001711 RID: 5905 RVA: 0x00028C4C File Offset: 0x00027C4C
		internal Collection EventDef
		{
			get
			{
				return this.eventDef;
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06001712 RID: 5906 RVA: 0x00028C54 File Offset: 0x00027C54
		internal List<EntrantInfo> Entrants
		{
			get
			{
				return this.entrants;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06001713 RID: 5907 RVA: 0x00028C5C File Offset: 0x00027C5C
		internal IScoringMethod ScoringMethod
		{
			get
			{
				return this.scoringMethod;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06001714 RID: 5908 RVA: 0x00028C64 File Offset: 0x00027C64
		internal List<PointOfInterest> PointsOfInterest
		{
			get
			{
				return this.pointsOfInterest;
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06001715 RID: 5909 RVA: 0x00028C6C File Offset: 0x00027C6C
		internal Manager Manager
		{
			get
			{
				return this.manager;
			}
		}

		// Token: 0x04000588 RID: 1416
		protected readonly Manager manager;

		// Token: 0x04000589 RID: 1417
		protected readonly Collection eventDef;

		// Token: 0x0400058A RID: 1418
		private List<IRadarMethod> radarMethodList;

		// Token: 0x0400058B RID: 1419
		private IScoringMethod scoringMethod;

		// Token: 0x0400058C RID: 1420
		private LivePacket livePacket;

		// Token: 0x0400058D RID: 1421
		protected ArbitratedPacket arbitratedPacket;

		// Token: 0x0400058E RID: 1422
		protected Interop.Accolades accolades;

		// Token: 0x0400058F RID: 1423
		private List<EntrantInfo> entrants = new List<EntrantInfo>();

		// Token: 0x04000590 RID: 1424
		protected WorkflowInstance workflowInstance;

		// Token: 0x04000591 RID: 1425
		private List<PointOfInterest> pointsOfInterest = new List<PointOfInterest>();

		// Token: 0x04000592 RID: 1426
		protected bool isDisposed;

		// Token: 0x04000593 RID: 1427
		private readonly InternalEvent internalEvent;

		// Token: 0x04000594 RID: 1428
		private ICallback mAccoladesCallback;
	}
}
