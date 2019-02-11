using System;
using System.Collections.Generic;
using Attrib.Gen;
using EASharp;
using GameCore.Data;
using GameCore.Math;
using GameCore.Messages;
using GameCore.Opponents;
using GameCore.Security;
using Interop;
using server_packet;
using Victory.DataLayer.Serialization.Event;
using Victory.Service.Objects;
using xsd2cpp;

namespace GameCore
{
	// Token: 0x0200023C RID: 572
	[Export]
	public class InstancedEvent : Event, IDisposable
	{
		// Token: 0x0600173D RID: 5949 RVA: 0x00029530 File Offset: 0x00028530
		[NoExport]
		internal InstancedEvent(InternalInstancedEvent internalInstancedEvent, InternalEvent internalEvent, long eventSessionId, Manager manager, Collection eventDef, ConnectionSupport connectionSupport) : base(internalEvent, manager, eventDef)
		{
			this.internalInstancedEvent = internalInstancedEvent;
			this.internalInstancedEvent.Ready(this);
			this.eventSessionId = eventSessionId;
			this.trackLayoutDef = new Collection(eventDef.TrackLayout());
			this.carClassDef = new Collection(eventDef.CarClass());
			this.connectionSupport = connectionSupport;
			this.trackLayout = new TrackLayout();
			string arbitratedPacketName = base.ScoringMethod.ArbitratedPacketName;
			if (!string.IsNullOrEmpty(arbitratedPacketName))
			{
				this.internalInstancedEvent.RegisterArbitrationListener(arbitratedPacketName);
			}
			if (this.eventDef.SpectateMethod() != null)
			{
				this.spectateMethod = Activator.CreateInstance<ISpectateMethod>(this.eventDef.SpectateMethod().GetKey());
			}
			this.routingMethod = Activator.CreateInstance<IRoutingMethod>(this.eventDef.RoutingMethod().GetKey());
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x00029620 File Offset: 0x00028620
		~InstancedEvent()
		{
			this.Dispose(false);
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x00029650 File Offset: 0x00028650
		public override void Dispose(bool disposing)
		{
			if (!this.isDisposed)
			{
				string arbitratedPacketName = base.ScoringMethod.ArbitratedPacketName;
				if (!string.IsNullOrEmpty(arbitratedPacketName))
				{
					this.internalInstancedEvent.UnRegisterArbitrationListener(arbitratedPacketName);
				}
				base.Dispose(disposing);
				this.internalInstancedEvent.Dispose();
				if (disposing)
				{
					this.spectateMethod = null;
					this.routingMethod = null;
				}
			}
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x000296A8 File Offset: 0x000286A8
		public void AddLaps(int laps)
		{
			this.eventDef.NumLaps(this.eventDef.NumLaps() + laps);
		}

		// Token: 0x06001741 RID: 5953 RVA: 0x000296C3 File Offset: 0x000286C3
		public void ClearStrikes()
		{
			this.extra_strikes = -this.eventDef.StrikeCount();
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x000296D7 File Offset: 0x000286D7
		[NoExport]
		public void AddRoutePoint(RoutePoint routePoint)
		{
			this.routePoints.Add(routePoint);
		}

		// Token: 0x06001743 RID: 5955 RVA: 0x000296E8 File Offset: 0x000286E8
		internal float GetDistanceToStartLine(Vehicle vehicle)
		{
			Collection collection = new Collection(this.TrackLayoutDef.StartGrid());
			return GameCore.Math.Math.DistanceXZ2(CoordSys.RenderToSim(collection.Position()), vehicle.GetPosition());
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x0002971C File Offset: 0x0002871C
		internal void Launched()
		{
			this.internalInstancedEvent.Launched(this.EventSessionId);
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x0002972F File Offset: 0x0002872F
		internal void Cleanup()
		{
			this.internalInstancedEvent.Cleanup();
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x0002973C File Offset: 0x0002873C
		internal bool Arbitrate(ArbitrationPacket packet)
		{
			this.FillSecurityInfo(packet);
			return MyBinding.Event_Arbitration(new ResponseHandler(new ResponseHandler.SuccessHandler(this.ArbitrationSucceeded), new ResponseHandler.FailHandler(this.ArbitrationFailed)), this.EventSessionId, packet) == 0;
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x00029771 File Offset: 0x00028771
		internal bool Abort(ArbitrationPacket packet)
		{
			this.FillSecurityInfo(packet);
			return MyBinding.Event_Abort(new ResponseHandler(new ResponseHandler.SuccessHandler(this.ArbitrationSucceeded), new ResponseHandler.FailHandler(this.ArbitrationFailed)), this.EventSessionId, packet) == 0;
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x000297A6 File Offset: 0x000287A6
		internal bool Bust(ArbitrationPacket packet)
		{
			this.FillSecurityInfo(packet);
			return MyBinding.Event_Busted(new ResponseHandler(new ResponseHandler.SuccessHandler(this.ArbitrationSucceeded), new ResponseHandler.FailHandler(this.ArbitrationFailed)), this.EventSessionId, packet) == 0;
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x000297DC File Offset: 0x000287DC
		private void FillSecurityInfo(ArbitrationPacket packet)
		{
			SecurityInfo securityInfo = new SecurityInfo();
			this.internalInstancedEvent.FillSecurityInfo((long)((ulong)packet.EventDurationInMilliseconds), securityInfo);
			packet.CarId = securityInfo.CustomizationDataId;
			packet.FraudDetectionInfo = new Victory.Service.Objects.FraudDetection();
			packet.FraudDetectionInfo.Checksum = securityInfo.FraudDetection.Checksum;
			packet.FraudDetectionInfo.IntValue1 = securityInfo.FraudDetection.IntValue1;
			packet.FraudDetectionInfo.IntValue2 = securityInfo.FraudDetection.IntValue2;
			packet.FraudDetectionInfo.IntValue3 = securityInfo.FraudDetection.IntValue3;
			packet.FraudDetectionInfo.IntValue4 = securityInfo.FraudDetection.IntValue4;
			packet.FraudDetectionInfo.IsEncrypted = securityInfo.FraudDetection.IsEncrypted;
			packet.FraudDetectionInfo.ModuleName = securityInfo.FraudDetection.ModuleName;
			packet.FraudDetectionInfo.ModulePath = securityInfo.FraudDetection.ModulePath;
			packet.FraudDetectionInfo.ModuleValue = securityInfo.FraudDetection.ModuleValue;
			packet.FraudDetectionInfo.StringValue1 = securityInfo.FraudDetection.StringValue1;
			packet.FraudDetectionInfo.StringValue2 = securityInfo.FraudDetection.StringValue2;
			packet.Response = new Victory.Service.Objects.SecurityResponse();
			packet.Response.ChallengeId = securityInfo.SecurityResponse.ChallengeId;
			packet.Response.Result = securityInfo.SecurityResponse.Result;
			packet.PhysicsMetrics = new ClientPhysicsMetrics();
			packet.PhysicsMetrics.AccelerationAverage = securityInfo.PhysicsMetrics.AccelerationAverage;
			packet.PhysicsMetrics.AccelerationMaximum = securityInfo.PhysicsMetrics.AccelerationMaximum;
			packet.PhysicsMetrics.AccelerationMedian = securityInfo.PhysicsMetrics.AccelerationMedian;
			packet.PhysicsMetrics.SpeedAverage = securityInfo.PhysicsMetrics.SpeedAverage;
			packet.PhysicsMetrics.SpeedMaximum = securityInfo.PhysicsMetrics.SpeedMaximum;
			packet.PhysicsMetrics.SpeedMedian = securityInfo.PhysicsMetrics.SpeedMedian;
		}

		// Token: 0x0600174A RID: 5962 RVA: 0x000299D4 File Offset: 0x000289D4
		private void ArbitrationSucceeded(XmlString xmlString)
		{
			if (this.isDisposed)
			{
				return;
			}
			this.arbitratedPacket.HasArbitrated = true;
			EventResult eventResult = base.ScoringMethod.Arbitrated(this, xmlString);
			if (eventResult != null)
			{
				InternalLobby.Get().SetExitPath(eventResult.ExitPath);
				InternalLobby.Get().CacheEventId((uint)eventResult.EventId);
				InternalLobby.Get().SetLobbyInviteId(eventResult.LobbyInviteId);
				InternalLobby.Get().SetEventTimeoutInSeconds((float)eventResult.InviteLifetimeInMilliseconds / 1000f);
				if (eventResult.Accolades != null)
				{
					this.StoreAccolades(eventResult.Accolades);
				}
			}
			this.internalInstancedEvent.ArbitrationSucceeded();
		}

		// Token: 0x0600174B RID: 5963 RVA: 0x00029A70 File Offset: 0x00028A70
		private void ArbitrationFailed(int status)
		{
			if (this.isDisposed)
			{
				return;
			}
			this.arbitratedPacket.HasArbitrated = true;
			foreach (EntrantInfo entrantInfo in base.Entrants)
			{
				if (!entrantInfo.ScoringState.HasArbitrated)
				{
					entrantInfo.ScoringState.HasArbitrated = true;
				}
			}
			this.internalInstancedEvent.ArbitrationFailed();
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x00029AF8 File Offset: 0x00028AF8
		public override void FetchAccolades()
		{
			this.internalInstancedEvent.FetchAccolades(this.EventSessionId);
		}

		// Token: 0x0600174D RID: 5965 RVA: 0x00029B0B File Offset: 0x00028B0B
		public void EntrantResultReceived(XmlString xmlString)
		{
			base.ScoringMethod.EntrantResultReceived(this, xmlString);
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x00029B1C File Offset: 0x00028B1C
		public void FillTimingOutPacket(ICallback callback)
		{
			if (this.IsTimingOut)
			{
				TimingOutPacket timingOutPacket = new TimingOutPacket();
				this.TimingOutRemaining.Fill(timingOutPacket.GetTimeLeft());
				callback.Respond(timingOutPacket);
				callback.Destroy();
				callback = null;
			}
		}

		// Token: 0x0600174F RID: 5967 RVA: 0x00029B68 File Offset: 0x00028B68
		public void FillPursuitPacket(ICallback callback)
		{
			EntrantInfo entrantInfo = base.Entrants.Find((EntrantInfo e) => e.Opponent is LocalHumanOpponent);
			if (entrantInfo != null)
			{
				base.ScoringMethod.Fill(this.pursuitInfo, entrantInfo);
			}
			callback.Respond(this.pursuitInfo);
			callback.Destroy();
			callback = null;
		}

		// Token: 0x06001750 RID: 5968 RVA: 0x00029BC8 File Offset: 0x00028BC8
		public void TimingOut(XmlString xmlString)
		{
			EventTimingOut eventTimingOut;
			if (XSD2CPP.ReadEventTimingOut(xmlString, out eventTimingOut) && this.EventSessionId == eventTimingOut.EventSessionId)
			{
				this.timingOutBeginning = Simulation.GetTick();
				this.timingOutInMilliseconds = eventTimingOut.TimeInMilliseconds;
				LocalHumanOpponent localHumanOpponent = base.Manager.OpponentManager.FindLocalOpponent();
				if (localHumanOpponent != null)
				{
					EntrantInfo entrantInfo = base.FindEntrant(localHumanOpponent.PersonaId);
					if (entrantInfo != null && !entrantInfo.ScoringState.HasFinishReason)
					{
						Hud.EnableGadget("RaceCountdownTimer", true);
					}
				}
			}
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x00029C40 File Offset: 0x00028C40
		public void Interupt(XmlString xmlString)
		{
			EventTimedOut eventTimedOut;
			if (XSD2CPP.ReadEventTimedOut(xmlString, out eventTimedOut) && this.EventSessionId == eventTimedOut.EventSessionId)
			{
				new OnInterupt().Post(Ports.Gameplay);
			}
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x00029C74 File Offset: 0x00028C74
		public void OnPauseDetected()
		{
			if (this.PauseDetected != null)
			{
				this.PauseDetected(this, EventArgs.Empty);
			}
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x00029C8F File Offset: 0x00028C8F
		public void DoEffect(EntrantInfo entrant, powerup_gamegroup effect, uint indexMagnitude, uint indexRange)
		{
			base.ScoringMethod.DoEffect(entrant, effect, indexMagnitude, indexRange);
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x00029CA1 File Offset: 0x00028CA1
		public long GetEventSessionId()
		{
			return this.EventSessionId;
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x00029CA9 File Offset: 0x00028CA9
		public uint GetEventKey()
		{
			return base.EventKey;
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x00029CB1 File Offset: 0x00028CB1
		public uint GetEventId()
		{
			return base.EventId;
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x00029CB9 File Offset: 0x00028CB9
		public uint GetEventMode()
		{
			return base.EventMode;
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06001758 RID: 5976 RVA: 0x00029CC1 File Offset: 0x00028CC1
		// (remove) Token: 0x06001759 RID: 5977 RVA: 0x00029CDA File Offset: 0x00028CDA
		internal event EventHandler PauseDetected;

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x0600175A RID: 5978 RVA: 0x00029CF3 File Offset: 0x00028CF3
		internal long EventSessionId
		{
			get
			{
				return this.eventSessionId;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x0600175B RID: 5979 RVA: 0x00029CFB File Offset: 0x00028CFB
		internal Collection TrackLayoutDef
		{
			get
			{
				return this.trackLayoutDef;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x0600175C RID: 5980 RVA: 0x00029D03 File Offset: 0x00028D03
		public ConnectionSupport ConnectionSupport
		{
			get
			{
				return this.connectionSupport;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x0600175D RID: 5981 RVA: 0x00029D0B File Offset: 0x00028D0B
		internal List<RoutePoint> Route
		{
			get
			{
				return this.routePoints;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x0600175E RID: 5982 RVA: 0x00029D13 File Offset: 0x00028D13
		internal TrackLayout TrackLayout
		{
			get
			{
				return this.trackLayout;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x0600175F RID: 5983 RVA: 0x00029D1B File Offset: 0x00028D1B
		internal IRoutingMethod RoutingMethod
		{
			get
			{
				return this.routingMethod;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06001760 RID: 5984 RVA: 0x00029D23 File Offset: 0x00028D23
		public ISpectateMethod SpectateMethod
		{
			get
			{
				return this.spectateMethod;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06001761 RID: 5985 RVA: 0x00029D2B File Offset: 0x00028D2B
		internal int NumLaps
		{
			get
			{
				return this.eventDef.NumLaps();
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06001762 RID: 5986 RVA: 0x00029D38 File Offset: 0x00028D38
		internal short MinRating
		{
			get
			{
				return this.carClassDef.CarClassMinRating();
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06001763 RID: 5987 RVA: 0x00029D45 File Offset: 0x00028D45
		internal short MaxRating
		{
			get
			{
				return this.carClassDef.CarClassMaxRating();
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06001764 RID: 5988 RVA: 0x00029D52 File Offset: 0x00028D52
		// (set) Token: 0x06001765 RID: 5989 RVA: 0x00029D5A File Offset: 0x00028D5A
		internal bool IsSuddenDeath
		{
			get
			{
				return this.isSuddenDeath;
			}
			set
			{
				this.isSuddenDeath = value;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06001766 RID: 5990 RVA: 0x00029D63 File Offset: 0x00028D63
		internal int NumStrikes
		{
			get
			{
				return this.eventDef.StrikeCount() + this.extra_strikes;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06001767 RID: 5991 RVA: 0x00029D77 File Offset: 0x00028D77
		internal int DesiredOpponentCount
		{
			get
			{
				return this.desiredOpponentCount;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06001768 RID: 5992 RVA: 0x00029D80 File Offset: 0x00028D80
		internal System.TimeSpan TimingOutRemaining
		{
			get
			{
				uint tickDifference = Simulation.GetTickDifference(this.timingOutBeginning);
				long num = (long)((ulong)tickDifference);
				long num2 = System.Math.Max(0L, this.timingOutInMilliseconds - num);
				return System.TimeSpan.FromMilliseconds((double)num2);
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06001769 RID: 5993 RVA: 0x00029DB3 File Offset: 0x00028DB3
		internal bool IsTimingOut
		{
			get
			{
				return this.timingOutInMilliseconds > 0L;
			}
		}

		// Token: 0x040005A6 RID: 1446
		private readonly long eventSessionId;

		// Token: 0x040005A7 RID: 1447
		private readonly Collection trackLayoutDef;

		// Token: 0x040005A8 RID: 1448
		private readonly Collection carClassDef;

		// Token: 0x040005A9 RID: 1449
		private readonly ConnectionSupport connectionSupport;

		// Token: 0x040005AA RID: 1450
		private TrackLayout trackLayout;

		// Token: 0x040005AB RID: 1451
		private IRoutingMethod routingMethod;

		// Token: 0x040005AC RID: 1452
		private ISpectateMethod spectateMethod;

		// Token: 0x040005AD RID: 1453
		private List<RoutePoint> routePoints = new List<RoutePoint>();

		// Token: 0x040005AE RID: 1454
		private int desiredOpponentCount = 8;

		// Token: 0x040005AF RID: 1455
		private int extra_strikes;

		// Token: 0x040005B0 RID: 1456
		private bool isSuddenDeath;

		// Token: 0x040005B1 RID: 1457
		private long timingOutInMilliseconds;

		// Token: 0x040005B2 RID: 1458
		private long timingOutBeginning;

		// Token: 0x040005B3 RID: 1459
		private PursuitInfo pursuitInfo = new PursuitInfo();

		// Token: 0x040005B4 RID: 1460
		private readonly InternalInstancedEvent internalInstancedEvent;
	}
}
