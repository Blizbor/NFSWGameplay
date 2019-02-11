using System;
using System.Collections.Generic;
using System.IO;
using Attrib.Gen;
using GameCore.Opponents;
using GameCore.Powerups;
using Interop;
using PowerUps;
using Victory.Data.Objects.Customization;
using Victory.DataLayer.Serialization.Event;
using Victory.Service.Objects;
using xsd2cpp;

namespace GameCore.Scoring
{
	// Token: 0x0200027A RID: 634
	public class DragScoringMethod : IScoringMethod
	{
		// Token: 0x060018BF RID: 6335 RVA: 0x0002BE4D File Offset: 0x0002AE4D
		public static object Construct(BinaryReader source)
		{
			return new DragScoringMethod();
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x0002BE54 File Offset: 0x0002AE54
		public void Fill(PursuitInfo pursuitPacket, EntrantInfo entrant)
		{
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x0002BE56 File Offset: 0x0002AE56
		public LivePacket CreateLivePacket()
		{
			return new DragLivePacket();
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x0002BE60 File Offset: 0x0002AE60
		public void Fill(LivePacket livePacket, Event evnt)
		{
			DragLivePacket b = livePacket as DragLivePacket;
			null != b;
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x0002BE7C File Offset: 0x0002AE7C
		public void Fill(LivePacket livePacket, EntrantInfo entrant)
		{
			DragLivePacket dragLivePacket = livePacket as DragLivePacket;
			DragScoringState dragScoringState = entrant.ScoringState as DragScoringState;
			if (dragScoringState != null && null != dragLivePacket)
			{
				DragEntrantLivePacket dragEntrantLivePacket = dragLivePacket.CreateEntrantLivePacket();
				dragEntrantLivePacket.SetPersonaName(entrant.Opponent.OpponentName);
				dragEntrantLivePacket.PersonaId = entrant.PersonaId;
				dragEntrantLivePacket.FinishReason = dragScoringState.FinishReason;
				dragEntrantLivePacket.Rank = dragScoringState.Rank;
				dragEntrantLivePacket.IsLocal = (entrant.Opponent is LocalHumanOpponent);
				dragEntrantLivePacket.Percentage = (float)((int)(dragScoringState.FractionCompleted * 100f)) / 100f;
				System.TimeSpan span = System.TimeSpan.FromMilliseconds(dragScoringState.EventTimer.ElapsedInMilliseconds);
				span.Fill(dragEntrantLivePacket.GetElapsedTime());
			}
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x0002BF37 File Offset: 0x0002AF37
		public ArbitratedPacket CreateArbitratedPacket()
		{
			return new DragArbitratedPacket();
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x0002BF40 File Offset: 0x0002AF40
		public void Fill(ArbitratedPacket arbitratedPacket, Event evnt)
		{
			DragArbitratedPacket dragArbitratedPacket = arbitratedPacket as DragArbitratedPacket;
			InstancedEvent instancedEvent = evnt as InstancedEvent;
			if (null != dragArbitratedPacket)
			{
				instancedEvent.TimingOutRemaining.Fill(dragArbitratedPacket.GetEventTimeout());
			}
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x0002BF78 File Offset: 0x0002AF78
		public void Fill(ArbitratedPacket arbitratedPacket, EntrantInfo entrant)
		{
			DragArbitratedPacket dragArbitratedPacket = arbitratedPacket as DragArbitratedPacket;
			DragScoringState dragScoringState = entrant.ScoringState as DragScoringState;
			if (dragScoringState != null && null != dragArbitratedPacket)
			{
				DragEntrantArbitratedPacket dragEntrantArbitratedPacket = dragArbitratedPacket.CreateEntrantArbitratedPacket();
				Marshal.Get().FillFEPlayerPersona(entrant.PersonaId, dragEntrantArbitratedPacket);
				dragEntrantArbitratedPacket.PersonaId = entrant.PersonaId;
				dragEntrantArbitratedPacket.SetPersonaName(entrant.Opponent.OpponentName);
				dragEntrantArbitratedPacket.SetMotto(entrant.Opponent.Motto);
				dragEntrantArbitratedPacket.HasArbitrated = dragScoringState.HasArbitrated;
				dragEntrantArbitratedPacket.FinishReason = dragScoringState.FinishReason;
				dragEntrantArbitratedPacket.Rank = dragScoringState.Rank;
				dragEntrantArbitratedPacket.Level = dragScoringState.Level;
				dragEntrantArbitratedPacket.IconIndex = (long)((ulong)entrant.Opponent.IconIndex);
				dragEntrantArbitratedPacket.IsLocal = (entrant.Opponent is LocalHumanOpponent);
				dragEntrantArbitratedPacket.EventDuration = dragScoringState.EventDurationInSeconds;
				Powerups.FillEntrantArbitratedPacket(dragEntrantArbitratedPacket);
				entrant.Opponent.FillCarData(dragEntrantArbitratedPacket.GetCarData());
				dragEntrantArbitratedPacket.TopSpeed = dragScoringState.TopSpeed;
			}
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x0002C076 File Offset: 0x0002B076
		public virtual ScoringState Prepare(EntrantInfo entrant, Event evnt)
		{
			return new DragScoringState();
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x0002C07D File Offset: 0x0002B07D
		public virtual void Launch(ScoringState state)
		{
			state.EventTimer.Start();
			state.SecureEventTimer.Start();
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x0002C098 File Offset: 0x0002B098
		public virtual void Conclude(ScoringState state)
		{
			state.EventTimer.Stop();
			state.SecureEventTimer.Stop();
			DragScoringState dragScoringState = state as DragScoringState;
			if (dragScoringState != null && dragScoringState.FinishReason == FinishReason.CrossedFinish)
			{
				dragScoringState.FractionCompleted = 1f;
			}
		}

		// Token: 0x060018CA RID: 6346 RVA: 0x0002C0DC File Offset: 0x0002B0DC
		public virtual void OnUpdate(EntrantInfo entrant, Event evnt, float dt)
		{
			InstancedEvent instancedEvent = evnt as InstancedEvent;
			DragScoringState dragScoringState = entrant.ScoringState as DragScoringState;
			if (dragScoringState != null)
			{
				dragScoringState.FractionCompleted = this.GetFractionCompleted(dragScoringState, entrant, instancedEvent);
				dragScoringState.DistanceToStartLine = instancedEvent.GetDistanceToStartLine(entrant.Opponent.Vehicle);
				float speed = entrant.Opponent.Vehicle.GetSpeed();
				if (speed > dragScoringState.TopSpeed)
				{
					dragScoringState.TopSpeed = speed;
				}
				if (entrant.Opponent.Vehicle.GetCurrentAirborneTime() > dragScoringState.LongestAirTimeInSeconds)
				{
					dragScoringState.LongestAirTimeInSeconds = entrant.Opponent.Vehicle.GetCurrentAirborneTime();
				}
				if (entrant.Opponent.Vehicle.GetNumWheelsOnGround() == 0)
				{
					dragScoringState.SumAirTimeInSeconds += dt;
				}
				if (entrant.Opponent.InternalOpponent.GetNumOpponentsCollidedWith() > dragScoringState.NumOpponentsTagged)
				{
					dragScoringState.NumOpponentsTagged = entrant.Opponent.InternalOpponent.GetNumOpponentsCollidedWith();
				}
				entrant.Opponent.InternalOpponent.SetFractionEventComplete(dragScoringState.FractionCompleted);
			}
		}

		// Token: 0x060018CB RID: 6347 RVA: 0x0002C1DB File Offset: 0x0002B1DB
		public virtual void OnLapCompleted(EntrantInfo entrant, Event evnt, int lap)
		{
		}

		// Token: 0x060018CC RID: 6348 RVA: 0x0002C1E0 File Offset: 0x0002B1E0
		protected virtual float GetFractionCompleted(DragScoringState state, EntrantInfo entrant, InstancedEvent evnt)
		{
			float num = evnt.TrackLayout.GetLapStartToVehicleDistance(entrant.Opponent.Vehicle);
			float lapStartToCheckpointDistance = evnt.TrackLayout.GetLapStartToCheckpointDistance(entrant.RoutingState.NextIndex);
			if (num > lapStartToCheckpointDistance)
			{
				num -= evnt.TrackLayout.GetLapLength(0);
			}
			num = Math.Max(num, 0f);
			return Math.Min(num / evnt.TrackLayout.GetLength(evnt.NumLaps), 0.99999f);
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x0002C257 File Offset: 0x0002B257
		public virtual void OnRoutingFinished(EntrantInfo entrant)
		{
			if (entrant.Opponent is LocalOpponent)
			{
				entrant.ScoringState.FinishReason = FinishReason.CrossedFinish;
			}
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x0002C273 File Offset: 0x0002B273
		public virtual void Sort(List<EntrantInfo> entrants)
		{
			entrants.Sort(new Comparison<EntrantInfo>(this.Sort));
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x0002C288 File Offset: 0x0002B288
		private int Sort(EntrantInfo le, EntrantInfo re)
		{
			DragScoringState dragScoringState = le.ScoringState as DragScoringState;
			DragScoringState dragScoringState2 = re.ScoringState as DragScoringState;
			if (dragScoringState == null || dragScoringState2 == null)
			{
				return 0;
			}
			if (!dragScoringState.IsFinishReason(FinishReason.Disconnected) && dragScoringState2.IsFinishReason(FinishReason.Disconnected))
			{
				return -1;
			}
			if (dragScoringState.IsFinishReason(FinishReason.Disconnected) && !dragScoringState2.IsFinishReason(FinishReason.Disconnected))
			{
				return 1;
			}
			if (dragScoringState.IsFinishReason(FinishReason.Disconnected) && dragScoringState2.IsFinishReason(FinishReason.Disconnected))
			{
				if (dragScoringState.FractionCompleted <= dragScoringState2.FractionCompleted)
				{
					return 1;
				}
				return -1;
			}
			else
			{
				if (!dragScoringState.IsFinishReason(FinishReason.DidNotFinish) && dragScoringState2.IsFinishReason(FinishReason.DidNotFinish))
				{
					return -1;
				}
				if (dragScoringState.IsFinishReason(FinishReason.DidNotFinish) && !dragScoringState2.IsFinishReason(FinishReason.DidNotFinish))
				{
					return 1;
				}
				if (dragScoringState.IsFinishReason(FinishReason.DidNotFinish) && dragScoringState2.IsFinishReason(FinishReason.DidNotFinish))
				{
					if (dragScoringState.FinishReason == dragScoringState2.FinishReason && dragScoringState2.FractionCompleted != dragScoringState.FractionCompleted)
					{
						if (dragScoringState.FractionCompleted <= dragScoringState2.FractionCompleted)
						{
							return 1;
						}
						return -1;
					}
				}
				else
				{
					if (dragScoringState.IsFinishReason(FinishReason.Completed) && !dragScoringState2.IsFinishReason(FinishReason.Completed))
					{
						return -1;
					}
					if (!dragScoringState.IsFinishReason(FinishReason.Completed) && dragScoringState2.IsFinishReason(FinishReason.Completed))
					{
						return 1;
					}
					if (dragScoringState.IsFinishReason(FinishReason.CrossedFinish) && dragScoringState2.IsFinishReason(FinishReason.CrossedFinish))
					{
						if (dragScoringState.EventDurationInMilliseconds != dragScoringState2.EventDurationInMilliseconds)
						{
							if (dragScoringState.EventDurationInMilliseconds >= dragScoringState2.EventDurationInMilliseconds)
							{
								return 1;
							}
							return -1;
						}
					}
					else if (dragScoringState.FractionCompleted == 0f && dragScoringState2.FractionCompleted == 0f)
					{
						if (dragScoringState.DistanceToStartLine != dragScoringState2.DistanceToStartLine)
						{
							if (dragScoringState.DistanceToStartLine >= dragScoringState2.DistanceToStartLine)
							{
								return 1;
							}
							return -1;
						}
					}
					else if (dragScoringState.FractionCompleted != dragScoringState2.FractionCompleted)
					{
						if (dragScoringState.FractionCompleted <= dragScoringState2.FractionCompleted)
						{
							return 1;
						}
						return -1;
					}
				}
				return le.Opponent.GridIndex - re.Opponent.GridIndex;
			}
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x0002C45C File Offset: 0x0002B45C
		public ArbitrationPacket FillArbitrationRecord(EntrantInfo entrant)
		{
			DragScoringState dragScoringState = entrant.ScoringState as DragScoringState;
			if (dragScoringState != null)
			{
				return new DragArbitrationPacket
				{
					Rank = dragScoringState.Rank,
					EventDurationInMilliseconds = dragScoringState.EventDurationInMilliseconds,
					AlternateEventDurationInMilliseconds = dragScoringState.SecureEventDurationInMilliseconds,
					HacksDetected = SecurityManager.GetHacks(),
					FinishReason = (int)dragScoringState.FinishReason,
					FractionCompleted = dragScoringState.FractionCompleted,
					TopSpeed = dragScoringState.TopSpeed,
					LongestJumpDurationInMilliseconds = dragScoringState.LongestAirTimeInMilliseconds,
					SumOfJumpsDurationInMilliseconds = dragScoringState.SumAirTimeInMilliseconds,
					PerfectStart = (int)dragScoringState.PerfectStart,
					NumberOfCollisions = dragScoringState.NumOpponentsTagged
				};
			}
			return null;
		}

		// Token: 0x060018D1 RID: 6353 RVA: 0x0002C508 File Offset: 0x0002B508
		public void EntrantResultReceived(Event evnt, XmlString xmlString)
		{
			InstancedEvent instancedEvent = evnt as InstancedEvent;
			DragEntrantResult dragEntrantResult;
			if (XSD2CPP.ReadDragEntrantResult(xmlString, out dragEntrantResult) && dragEntrantResult.EventSessionId == instancedEvent.EventSessionId)
			{
				EntrantInfo entrantInfo = evnt.FindEntrant(dragEntrantResult.PersonaId);
				if (entrantInfo == null)
				{
					return;
				}
				DragScoringState dragScoringState = entrantInfo.ScoringState as DragScoringState;
				if (dragScoringState != null)
				{
					dragScoringState.HasArbitrated = true;
					dragScoringState.FinishReason = (FinishReason)dragEntrantResult.FinishReason;
					dragScoringState.EventDurationInMilliseconds = dragEntrantResult.EventDurationInMilliseconds;
					dragScoringState.Rank = dragEntrantResult.Ranking;
					dragScoringState.TopSpeed = dragEntrantResult.TopSpeed;
				}
			}
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x0002C58C File Offset: 0x0002B58C
		public EventResult Arbitrated(Event evnt, XmlString xmlString)
		{
			InstancedEvent instancedEvent = evnt as InstancedEvent;
			DragEventResult dragEventResult;
			if (XSD2CPP.ReadDragEventResult(xmlString, out dragEventResult) && dragEventResult.EventSessionId == instancedEvent.EventSessionId)
			{
				foreach (DragEntrantResult dragEntrantResult in dragEventResult.Entrants)
				{
					if (dragEntrantResult.FinishReason != 0)
					{
						EntrantInfo entrantInfo = evnt.FindEntrant(dragEntrantResult.PersonaId);
						if (entrantInfo != null)
						{
							DragScoringState dragScoringState = entrantInfo.ScoringState as DragScoringState;
							if (dragScoringState != null && !dragScoringState.HasArbitrated)
							{
								dragScoringState.HasArbitrated = true;
								dragScoringState.FinishReason = (FinishReason)dragEntrantResult.FinishReason;
								dragScoringState.EventDurationInMilliseconds = dragEntrantResult.EventDurationInMilliseconds;
								dragScoringState.Rank = dragEntrantResult.Ranking;
								dragScoringState.TopSpeed = dragEntrantResult.TopSpeed;
							}
						}
					}
				}
				Marshal.Get().SetLocalPlayersDurability(dragEventResult.Durability);
				return dragEventResult;
			}
			return null;
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x0002C680 File Offset: 0x0002B680
		private unsafe bool IsJumpStartActive(EntrantInfo entrantInfo, Event evnt)
		{
			LocalHumanOpponent localHumanOpponent = entrantInfo.Opponent as LocalHumanOpponent;
			DragScoringState dragScoringState = entrantInfo.ScoringState as DragScoringState;
			if (dragScoringState == null || localHumanOpponent == null)
			{
				return false;
			}
			if (localHumanOpponent.Vehicle.IsStaging())
			{
				return false;
			}
			float num;
			if (!localHumanOpponent.Vehicle.GetSkillModEffectAmount(SkillModEffectType.JumpStart, &num))
			{
				return false;
			}
			float num2 = evnt.EventDef.PowerupBlackoutAtEventStart();
			float num3 = num2 - num;
			return dragScoringState.EventDurationInSeconds <= num2 && dragScoringState.EventDurationInSeconds > num3;
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x0002C6FC File Offset: 0x0002B6FC
		public bool IsPowerupRestricted(Restriction restriction, EntrantInfo entrantInfo, Event evnt)
		{
			if (entrantInfo == null)
			{
				return true;
			}
			LocalHumanOpponent localHumanOpponent = entrantInfo.Opponent as LocalHumanOpponent;
			DragScoringState dragScoringState = entrantInfo.ScoringState as DragScoringState;
			if (dragScoringState == null)
			{
				return true;
			}
			if (dragScoringState.EventDurationInSeconds < evnt.EventDef.PowerupBlackoutAtEventStart() && localHumanOpponent != null && !this.IsJumpStartActive(entrantInfo, evnt))
			{
				return true;
			}
			switch (restriction)
			{
			case Restriction.kPowerupRestriction_NobodyHasFinishedEvent:
				foreach (EntrantInfo entrantInfo2 in evnt.Entrants)
				{
					DragScoringState dragScoringState2 = entrantInfo2.ScoringState as DragScoringState;
					if (dragScoringState2 != null && dragScoringState2.FractionCompleted > 0.95f)
					{
						return true;
					}
				}
				break;
			case Restriction.kPowerupRestriction_IAmNotInFirstPlace:
			{
				if (dragScoringState.Rank == 1)
				{
					return true;
				}
				int num = 999;
				foreach (EntrantInfo entrantInfo3 in evnt.Entrants)
				{
					bool flag = entrantInfo3.Opponent.IsStatus(OpponentStatus.kOpponent_Disconnected);
					RouteScoringState routeScoringState = entrantInfo3.ScoringState as RouteScoringState;
					if (routeScoringState != null && routeScoringState.FinishReason == FinishReason.Unknown && !flag && routeScoringState.Rank < num)
					{
						num = routeScoringState.Rank;
					}
				}
				if (num == dragScoringState.Rank)
				{
					return true;
				}
				break;
			}
			}
			return false;
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x0002C86C File Offset: 0x0002B86C
		public void DoEffect(EntrantInfo entrant, powerup_gamegroup effect, uint indexMagnitude, uint indexRange)
		{
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x0002C86E File Offset: 0x0002B86E
		public void AccoladesFetched(Interop.Accolades accolades)
		{
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x060018D7 RID: 6359 RVA: 0x0002C870 File Offset: 0x0002B870
		public string ArbitratedPacketName
		{
			get
			{
				return typeof(DragEntrantResult).Name;
			}
		}
	}
}
