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
	// Token: 0x02000281 RID: 641
	public class RouteScoringMethod : IScoringMethod
	{
		// Token: 0x06001940 RID: 6464 RVA: 0x0002D1A5 File Offset: 0x0002C1A5
		public static object Construct(BinaryReader source)
		{
			return new RouteScoringMethod();
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x0002D1AC File Offset: 0x0002C1AC
		public void Fill(PursuitInfo pursuitPacket, EntrantInfo entrant)
		{
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x0002D1AE File Offset: 0x0002C1AE
		public LivePacket CreateLivePacket()
		{
			return new RouteLivePacket();
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x0002D1B8 File Offset: 0x0002C1B8
		public void Fill(LivePacket livePacket, Event evnt)
		{
			RouteLivePacket routeLivePacket = livePacket as RouteLivePacket;
			InstancedEvent instancedEvent = evnt as InstancedEvent;
			if (null != routeLivePacket)
			{
				routeLivePacket.NumLaps = (uint)instancedEvent.NumLaps;
			}
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x0002D1E8 File Offset: 0x0002C1E8
		public void Fill(LivePacket livePacket, EntrantInfo entrant)
		{
			RouteLivePacket routeLivePacket = livePacket as RouteLivePacket;
			RouteScoringState routeScoringState = entrant.ScoringState as RouteScoringState;
			if (routeScoringState != null && null != routeLivePacket)
			{
				RouteEntrantLivePacket routeEntrantLivePacket = routeLivePacket.CreateEntrantLivePacket();
				routeEntrantLivePacket.SetPersonaName(entrant.Opponent.OpponentName);
				routeEntrantLivePacket.PersonaId = entrant.PersonaId;
				routeEntrantLivePacket.FinishReason = routeScoringState.FinishReason;
				routeEntrantLivePacket.Rank = routeScoringState.Rank;
				routeEntrantLivePacket.IsLocal = (entrant.Opponent is LocalHumanOpponent);
				routeEntrantLivePacket.Percentage = (float)((int)(routeScoringState.FractionCompleted * 100f)) / 100f;
				routeEntrantLivePacket.Lap = routeScoringState.CurrentLap + 1;
				System.TimeSpan span = System.TimeSpan.FromMilliseconds(routeScoringState.LapTimer.ElapsedInMilliseconds);
				span.Fill(routeEntrantLivePacket.GetLapTime());
				uint num = (routeScoringState.BestLapDurationInMilliseconds == uint.MaxValue) ? 0u : routeScoringState.BestLapDurationInMilliseconds;
				System.TimeSpan span2 = System.TimeSpan.FromMilliseconds(num);
				span2.Fill(routeEntrantLivePacket.GetBestLapTime());
			}
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x0002D2DD File Offset: 0x0002C2DD
		public ArbitratedPacket CreateArbitratedPacket()
		{
			return new RouteArbitratedPacket();
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x0002D2E4 File Offset: 0x0002C2E4
		public void Fill(ArbitratedPacket arbitratedPacket, Event evnt)
		{
			RouteArbitratedPacket routeArbitratedPacket = arbitratedPacket as RouteArbitratedPacket;
			InstancedEvent instancedEvent = evnt as InstancedEvent;
			if (null != routeArbitratedPacket)
			{
				routeArbitratedPacket.NumLaps = (uint)instancedEvent.NumLaps;
				instancedEvent.TimingOutRemaining.Fill(routeArbitratedPacket.GetEventTimeout());
			}
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x0002D328 File Offset: 0x0002C328
		public void Fill(ArbitratedPacket arbitratedPacket, EntrantInfo entrant)
		{
			RouteArbitratedPacket routeArbitratedPacket = arbitratedPacket as RouteArbitratedPacket;
			RouteScoringState routeScoringState = entrant.ScoringState as RouteScoringState;
			if (routeScoringState != null && null != routeArbitratedPacket)
			{
				RouteEntrantArbitratedPacket routeEntrantArbitratedPacket = routeArbitratedPacket.CreateEntrantArbitratedPacket();
				Marshal.Get().FillFEPlayerPersona(entrant.PersonaId, routeEntrantArbitratedPacket);
				routeEntrantArbitratedPacket.PersonaId = entrant.PersonaId;
				routeEntrantArbitratedPacket.SetPersonaName(entrant.Opponent.OpponentName);
				routeEntrantArbitratedPacket.SetMotto(entrant.Opponent.Motto);
				routeEntrantArbitratedPacket.HasArbitrated = routeScoringState.HasArbitrated;
				routeEntrantArbitratedPacket.FinishReason = routeScoringState.FinishReason;
				routeEntrantArbitratedPacket.Rank = routeScoringState.Rank;
				routeEntrantArbitratedPacket.Level = routeScoringState.Level;
				routeEntrantArbitratedPacket.IconIndex = (long)((ulong)entrant.Opponent.IconIndex);
				routeEntrantArbitratedPacket.IsLocal = (entrant.Opponent is LocalHumanOpponent);
				routeEntrantArbitratedPacket.EventDuration = routeScoringState.EventDurationInSeconds;
				Powerups.FillEntrantArbitratedPacket(routeEntrantArbitratedPacket);
				entrant.Opponent.FillCarData(routeEntrantArbitratedPacket.GetCarData());
				routeEntrantArbitratedPacket.BestLapDuration = routeScoringState.BestLapDurationInSeconds;
				routeEntrantArbitratedPacket.TopSpeed = routeScoringState.TopSpeed;
			}
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x0002D432 File Offset: 0x0002C432
		public virtual ScoringState Prepare(EntrantInfo entrant, Event evnt)
		{
			return new RouteScoringState();
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x0002D43C File Offset: 0x0002C43C
		public virtual void Launch(ScoringState state)
		{
			state.EventTimer.Start();
			state.SecureEventTimer.Start();
			RouteScoringState routeScoringState = state as RouteScoringState;
			if (routeScoringState != null)
			{
				routeScoringState.LapTimer.Start();
			}
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x0002D474 File Offset: 0x0002C474
		public virtual void Conclude(ScoringState state)
		{
			state.EventTimer.Stop();
			state.SecureEventTimer.Stop();
			RouteScoringState routeScoringState = state as RouteScoringState;
			if (routeScoringState != null)
			{
				routeScoringState.LapTimer.Stop();
				if (routeScoringState.FinishReason == FinishReason.CrossedFinish)
				{
					routeScoringState.FractionCompleted = 1f;
				}
			}
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x0002D4C4 File Offset: 0x0002C4C4
		public virtual void OnUpdate(EntrantInfo entrant, Event evnt, float dt)
		{
			InstancedEvent instancedEvent = evnt as InstancedEvent;
			RouteScoringState routeScoringState = entrant.ScoringState as RouteScoringState;
			if (routeScoringState != null)
			{
				routeScoringState.FractionCompleted = this.GetFractionCompleted(routeScoringState, entrant, instancedEvent);
				routeScoringState.DistanceToStartLine = instancedEvent.GetDistanceToStartLine(entrant.Opponent.Vehicle);
				float speed = entrant.Opponent.Vehicle.GetSpeed();
				if (speed > routeScoringState.TopSpeed)
				{
					routeScoringState.TopSpeed = speed;
				}
				if (entrant.Opponent.Vehicle.GetCurrentAirborneTime() > routeScoringState.LongestAirTimeInSeconds)
				{
					routeScoringState.LongestAirTimeInSeconds = entrant.Opponent.Vehicle.GetCurrentAirborneTime();
				}
				if (entrant.Opponent.Vehicle.GetNumWheelsOnGround() == 0)
				{
					routeScoringState.SumAirTimeInSeconds += dt;
				}
				if (entrant.Opponent.InternalOpponent.GetNumOpponentsCollidedWith() > routeScoringState.NumOpponentsTagged)
				{
					routeScoringState.NumOpponentsTagged = entrant.Opponent.InternalOpponent.GetNumOpponentsCollidedWith();
				}
				entrant.Opponent.InternalOpponent.SetFractionEventComplete(routeScoringState.FractionCompleted);
			}
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x0002D5C4 File Offset: 0x0002C5C4
		public virtual void OnLapCompleted(EntrantInfo entrant, Event evnt, int lap)
		{
			RouteScoringState routeScoringState = entrant.ScoringState as RouteScoringState;
			if (routeScoringState != null)
			{
				routeScoringState.LapTimer.Stop();
				routeScoringState.BestLapDurationInMilliseconds = Math.Min(routeScoringState.BestLapDurationInMilliseconds, routeScoringState.LapTimer.ElapsedInMilliseconds);
				routeScoringState.CurrentLap = lap;
				LocalHumanOpponent localHumanOpponent = entrant.Opponent as LocalHumanOpponent;
				if (localHumanOpponent != null)
				{
					FlasherManager.Get().EnqueueFlasher(new TimeFlasher(3020512949u, routeScoringState.LapTimer.ElapsedInSeconds));
				}
				routeScoringState.LapTimer.Reset();
				routeScoringState.LapTimer.Start();
			}
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x0002D654 File Offset: 0x0002C654
		protected virtual float GetFractionCompleted(RouteScoringState state, EntrantInfo entrant, InstancedEvent evnt)
		{
			float num = evnt.TrackLayout.GetLapStartToVehicleDistance(entrant.Opponent.Vehicle);
			float lapStartToCheckpointDistance = evnt.TrackLayout.GetLapStartToCheckpointDistance(entrant.RoutingState.NextIndex);
			if (num > lapStartToCheckpointDistance)
			{
				num -= evnt.TrackLayout.GetLapLength(state.CurrentLap);
			}
			for (int i = 0; i < state.CurrentLap; i++)
			{
				num += evnt.TrackLayout.GetLapLength(i);
			}
			num = Math.Max(num, 0f);
			return Math.Min(num / evnt.TrackLayout.GetLength(evnt.NumLaps), 0.99999f);
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x0002D6F0 File Offset: 0x0002C6F0
		protected virtual float GetFractionLapCompleted(RouteScoringState state, EntrantInfo entrant, InstancedEvent evnt)
		{
			float num = evnt.TrackLayout.GetLapStartToVehicleDistance(entrant.Opponent.Vehicle);
			float lapLength = evnt.TrackLayout.GetLapLength(state.CurrentLap);
			num = Math.Max(num, 0f);
			return Math.Min(num / lapLength, 1f);
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x0002D73F File Offset: 0x0002C73F
		public virtual void OnRoutingFinished(EntrantInfo entrant)
		{
			Console.WriteLine("CS: {0} has finished routing.", entrant.Opponent.OpponentName);
			if (entrant.Opponent is LocalOpponent)
			{
				entrant.ScoringState.FinishReason = FinishReason.CrossedFinish;
			}
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x0002D770 File Offset: 0x0002C770
		public virtual void Sort(List<EntrantInfo> entrants)
		{
			entrants.Sort(new Comparison<EntrantInfo>(this.Sort));
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x0002D784 File Offset: 0x0002C784
		private int Sort(EntrantInfo le, EntrantInfo re)
		{
			RouteScoringState routeScoringState = le.ScoringState as RouteScoringState;
			RouteScoringState routeScoringState2 = re.ScoringState as RouteScoringState;
			if (routeScoringState == null || routeScoringState2 == null)
			{
				return 0;
			}
			if (!routeScoringState.IsFinishReason(FinishReason.Disconnected) && routeScoringState2.IsFinishReason(FinishReason.Disconnected))
			{
				return -1;
			}
			if (routeScoringState.IsFinishReason(FinishReason.Disconnected) && !routeScoringState2.IsFinishReason(FinishReason.Disconnected))
			{
				return 1;
			}
			if (routeScoringState.IsFinishReason(FinishReason.Disconnected) && routeScoringState2.IsFinishReason(FinishReason.Disconnected))
			{
				if (routeScoringState.FractionCompleted <= routeScoringState2.FractionCompleted)
				{
					return 1;
				}
				return -1;
			}
			else
			{
				if (!routeScoringState.IsFinishReason(FinishReason.DidNotFinish) && routeScoringState2.IsFinishReason(FinishReason.DidNotFinish))
				{
					return -1;
				}
				if (routeScoringState.IsFinishReason(FinishReason.DidNotFinish) && !routeScoringState2.IsFinishReason(FinishReason.DidNotFinish))
				{
					return 1;
				}
				if (routeScoringState.IsFinishReason(FinishReason.DidNotFinish) && routeScoringState2.IsFinishReason(FinishReason.DidNotFinish))
				{
					if (routeScoringState.FinishReason == routeScoringState2.FinishReason && routeScoringState2.FractionCompleted != routeScoringState.FractionCompleted)
					{
						if (routeScoringState.FractionCompleted <= routeScoringState2.FractionCompleted)
						{
							return 1;
						}
						return -1;
					}
				}
				else
				{
					if (routeScoringState.IsFinishReason(FinishReason.Completed) && !routeScoringState2.IsFinishReason(FinishReason.Completed))
					{
						return -1;
					}
					if (!routeScoringState.IsFinishReason(FinishReason.Completed) && routeScoringState2.IsFinishReason(FinishReason.Completed))
					{
						return 1;
					}
					if (routeScoringState.IsFinishReason(FinishReason.CrossedFinish) && routeScoringState2.IsFinishReason(FinishReason.CrossedFinish))
					{
						if (routeScoringState.EventDurationInMilliseconds != routeScoringState2.EventDurationInMilliseconds)
						{
							if (routeScoringState.EventDurationInMilliseconds >= routeScoringState2.EventDurationInMilliseconds)
							{
								return 1;
							}
							return -1;
						}
					}
					else if (routeScoringState.FractionCompleted == 0f && routeScoringState2.FractionCompleted == 0f)
					{
						if (routeScoringState.DistanceToStartLine != routeScoringState2.DistanceToStartLine)
						{
							if (routeScoringState.DistanceToStartLine >= routeScoringState2.DistanceToStartLine)
							{
								return 1;
							}
							return -1;
						}
					}
					else if (routeScoringState.FractionCompleted != routeScoringState2.FractionCompleted)
					{
						if (routeScoringState.FractionCompleted <= routeScoringState2.FractionCompleted)
						{
							return 1;
						}
						return -1;
					}
				}
				return le.Opponent.GridIndex - re.Opponent.GridIndex;
			}
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x0002D958 File Offset: 0x0002C958
		public ArbitrationPacket FillArbitrationRecord(EntrantInfo entrant)
		{
			RouteScoringState routeScoringState = entrant.ScoringState as RouteScoringState;
			if (routeScoringState != null)
			{
				return new RouteArbitrationPacket
				{
					Rank = routeScoringState.Rank,
					EventDurationInMilliseconds = routeScoringState.EventDurationInMilliseconds,
					AlternateEventDurationInMilliseconds = routeScoringState.SecureEventDurationInMilliseconds,
					HacksDetected = SecurityManager.GetHacks(),
					FinishReason = (int)routeScoringState.FinishReason,
					FractionCompleted = routeScoringState.FractionCompleted,
					BestLapDurationInMilliseconds = ((routeScoringState.BestLapDurationInMilliseconds == uint.MaxValue) ? routeScoringState.LapTimer.ElapsedInMilliseconds : routeScoringState.BestLapDurationInMilliseconds),
					TopSpeed = routeScoringState.TopSpeed,
					LongestJumpDurationInMilliseconds = routeScoringState.LongestAirTimeInMilliseconds,
					SumOfJumpsDurationInMilliseconds = routeScoringState.SumAirTimeInMilliseconds,
					PerfectStart = (int)routeScoringState.PerfectStart,
					NumberOfCollisions = routeScoringState.NumOpponentsTagged
				};
			}
			return null;
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x0002DA28 File Offset: 0x0002CA28
		public void EntrantResultReceived(Event evnt, XmlString xmlString)
		{
			InstancedEvent instancedEvent = evnt as InstancedEvent;
			RouteEntrantResult routeEntrantResult;
			if (XSD2CPP.ReadRouteEntrantResult(xmlString, out routeEntrantResult) && routeEntrantResult.EventSessionId == instancedEvent.EventSessionId)
			{
				EntrantInfo entrantInfo = evnt.FindEntrant(routeEntrantResult.PersonaId);
				if (entrantInfo == null)
				{
					return;
				}
				RouteScoringState routeScoringState = entrantInfo.ScoringState as RouteScoringState;
				if (routeScoringState != null)
				{
					routeScoringState.HasArbitrated = true;
					routeScoringState.FinishReason = (FinishReason)routeEntrantResult.FinishReason;
					routeScoringState.EventDurationInMilliseconds = routeEntrantResult.EventDurationInMilliseconds;
					routeScoringState.Rank = routeEntrantResult.Ranking;
					routeScoringState.TopSpeed = routeEntrantResult.TopSpeed;
					routeScoringState.BestLapDurationInMilliseconds = routeEntrantResult.BestLapDurationInMilliseconds;
				}
			}
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x0002DAB8 File Offset: 0x0002CAB8
		public EventResult Arbitrated(Event evnt, XmlString xmlString)
		{
			InstancedEvent instancedEvent = evnt as InstancedEvent;
			RouteEventResult routeEventResult;
			if (XSD2CPP.ReadRouteEventResult(xmlString, out routeEventResult) && routeEventResult.EventSessionId == instancedEvent.EventSessionId)
			{
				foreach (RouteEntrantResult routeEntrantResult in routeEventResult.Entrants)
				{
					EntrantInfo entrantInfo = evnt.FindEntrant(routeEntrantResult.PersonaId);
					if (entrantInfo != null)
					{
						RouteScoringState routeScoringState = entrantInfo.ScoringState as RouteScoringState;
						if (routeScoringState != null && !routeScoringState.HasArbitrated)
						{
							routeScoringState.HasArbitrated = true;
							routeScoringState.FinishReason = (FinishReason)routeEntrantResult.FinishReason;
							routeScoringState.EventDurationInMilliseconds = routeEntrantResult.EventDurationInMilliseconds;
							routeScoringState.Rank = routeEntrantResult.Ranking;
							routeScoringState.TopSpeed = routeEntrantResult.TopSpeed;
							routeScoringState.BestLapDurationInMilliseconds = routeEntrantResult.BestLapDurationInMilliseconds;
						}
					}
				}
				Marshal.Get().SetLocalPlayersDurability(routeEventResult.Durability);
				return routeEventResult;
			}
			return null;
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x0002DBB4 File Offset: 0x0002CBB4
		private unsafe bool IsJumpStartActive(EntrantInfo entrantInfo, Event evnt)
		{
			LocalHumanOpponent localHumanOpponent = entrantInfo.Opponent as LocalHumanOpponent;
			RouteScoringState routeScoringState = entrantInfo.ScoringState as RouteScoringState;
			if (routeScoringState == null || localHumanOpponent == null)
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
			return routeScoringState.EventDurationInSeconds <= num2 && routeScoringState.EventDurationInSeconds > num3;
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x0002DC30 File Offset: 0x0002CC30
		public bool IsPowerupRestricted(Restriction restriction, EntrantInfo entrantInfo, Event evnt)
		{
			if (entrantInfo == null)
			{
				return true;
			}
			LocalHumanOpponent localHumanOpponent = entrantInfo.Opponent as LocalHumanOpponent;
			RouteScoringState routeScoringState = entrantInfo.ScoringState as RouteScoringState;
			InstancedEvent instancedEvent = evnt as InstancedEvent;
			if (routeScoringState == null)
			{
				return true;
			}
			if (routeScoringState.EventDurationInSeconds < evnt.EventDef.PowerupBlackoutAtEventStart() && localHumanOpponent != null && !this.IsJumpStartActive(entrantInfo, evnt))
			{
				return true;
			}
			switch (restriction)
			{
			case Restriction.kPowerupRestriction_NobodyHasFinishedEvent:
				foreach (EntrantInfo entrantInfo2 in evnt.Entrants)
				{
					RouteScoringState routeScoringState2 = entrantInfo2.ScoringState as RouteScoringState;
					if (routeScoringState2 != null && routeScoringState2.FractionCompleted > 0.95f)
					{
						return true;
					}
				}
				break;
			case Restriction.kPowerupRestriction_IAmNotInFirstPlace:
			{
				if (routeScoringState.Rank == 1)
				{
					return true;
				}
				int num = 999;
				foreach (EntrantInfo entrantInfo3 in evnt.Entrants)
				{
					bool flag = entrantInfo3.Opponent.IsStatus(OpponentStatus.kOpponent_Disconnected);
					RouteScoringState routeScoringState3 = entrantInfo3.ScoringState as RouteScoringState;
					if (routeScoringState3 != null && routeScoringState3.FinishReason == FinishReason.Unknown && !flag && routeScoringState3.Rank < num)
					{
						num = routeScoringState3.Rank;
					}
				}
				if (num == routeScoringState.Rank)
				{
					return true;
				}
				break;
			}
			case Restriction.kPowerupRestriction_IAmOnTheLastLap:
				if (instancedEvent.NumLaps != routeScoringState.CurrentLap + 1)
				{
					return true;
				}
				break;
			}
			return false;
		}

		// Token: 0x06001957 RID: 6487 RVA: 0x0002DDC0 File Offset: 0x0002CDC0
		public void DoEffect(EntrantInfo entrant, powerup_gamegroup effect, uint indexMagnitude, uint indexRange)
		{
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x0002DDC2 File Offset: 0x0002CDC2
		public void AccoladesFetched(Interop.Accolades accolades)
		{
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06001959 RID: 6489 RVA: 0x0002DDC4 File Offset: 0x0002CDC4
		public string ArbitratedPacketName
		{
			get
			{
				return typeof(RouteEntrantResult).Name;
			}
		}
	}
}
