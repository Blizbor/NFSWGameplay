using System;
using System.Collections.Generic;
using System.IO;
using Attrib.Gen;
using GameCore.Messages;
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
	// Token: 0x02000283 RID: 643
	public class TeamEscapeScoringMethod : IScoringMethod
	{
		// Token: 0x0600198C RID: 6540 RVA: 0x0002E01B File Offset: 0x0002D01B
		public static object Construct(BinaryReader source)
		{
			return new TeamEscapeScoringMethod();
		}

		// Token: 0x0600198D RID: 6541 RVA: 0x0002E024 File Offset: 0x0002D024
		public void Fill(PursuitInfo pursuitPacket, EntrantInfo entrant)
		{
			TeamEscapeScoringState teamEscapeScoringState = entrant.ScoringState as TeamEscapeScoringState;
			if (teamEscapeScoringState != null)
			{
				pursuitPacket.PursuitStatus = teamEscapeScoringState.PursuitBar;
				pursuitPacket.NumCopsEngaged = (uint)teamEscapeScoringState.CopsDeployed;
			}
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x0002E058 File Offset: 0x0002D058
		public LivePacket CreateLivePacket()
		{
			return new TeamEscapeLivePacket();
		}

		// Token: 0x0600198F RID: 6543 RVA: 0x0002E060 File Offset: 0x0002D060
		public void Fill(LivePacket livePacket, Event evnt)
		{
			TeamEscapeLivePacket teamEscapeLivePacket = livePacket as TeamEscapeLivePacket;
			InstancedEvent instancedEvent = evnt as InstancedEvent;
			if (null != teamEscapeLivePacket)
			{
				teamEscapeLivePacket.MaxStrikes = instancedEvent.NumStrikes;
			}
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x0002E090 File Offset: 0x0002D090
		public void Fill(LivePacket livePacket, EntrantInfo entrant)
		{
			TeamEscapeLivePacket teamEscapeLivePacket = livePacket as TeamEscapeLivePacket;
			TeamEscapeScoringState teamEscapeScoringState = entrant.ScoringState as TeamEscapeScoringState;
			if (null != teamEscapeLivePacket && teamEscapeScoringState != null)
			{
				TeamEscapeEntrantLivePacket teamEscapeEntrantLivePacket = teamEscapeLivePacket.CreateEntrantLivePacket();
				teamEscapeEntrantLivePacket.PersonaId = entrant.PersonaId;
				teamEscapeEntrantLivePacket.SetPersonaName(entrant.Opponent.OpponentName);
				teamEscapeEntrantLivePacket.FinishReason = teamEscapeScoringState.FinishReason;
				teamEscapeEntrantLivePacket.Rank = teamEscapeScoringState.Rank;
				teamEscapeEntrantLivePacket.IsLocal = (entrant.Opponent is LocalHumanOpponent);
				teamEscapeEntrantLivePacket.Highlight = teamEscapeScoringState.Highlight;
				teamEscapeEntrantLivePacket.DistanceToFinish = teamEscapeScoringState.DistanceToFinish;
				teamEscapeEntrantLivePacket.SetDistanceToFinishString(FormatUtils.FormatDistance(teamEscapeScoringState.DistanceToFinish));
				teamEscapeLivePacket.NumBusts += teamEscapeScoringState.Busts;
				if (teamEscapeEntrantLivePacket.IsLocal)
				{
					System.TimeSpan span = System.TimeSpan.FromSeconds((double)teamEscapeScoringState.TimeRemaining);
					span.Fill(teamEscapeLivePacket.GetEventTimer());
					teamEscapeLivePacket.IsTimerUrgent = teamEscapeScoringState.IsTimerUrgent;
				}
			}
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x0002E17B File Offset: 0x0002D17B
		public ArbitratedPacket CreateArbitratedPacket()
		{
			return new TeamEscapeArbitratedPacket();
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x0002E184 File Offset: 0x0002D184
		public void Fill(ArbitratedPacket arbitratedPacket, Event evnt)
		{
			TeamEscapeArbitratedPacket teamEscapeArbitratedPacket = arbitratedPacket as TeamEscapeArbitratedPacket;
			InstancedEvent instancedEvent = evnt as InstancedEvent;
			if (null != teamEscapeArbitratedPacket)
			{
				teamEscapeArbitratedPacket.MaxStrikes = instancedEvent.NumStrikes;
			}
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x0002E1B4 File Offset: 0x0002D1B4
		public void Fill(ArbitratedPacket arbitratedPacket, EntrantInfo entrant)
		{
			TeamEscapeArbitratedPacket teamEscapeArbitratedPacket = arbitratedPacket as TeamEscapeArbitratedPacket;
			TeamEscapeScoringState teamEscapeScoringState = entrant.ScoringState as TeamEscapeScoringState;
			if (null != teamEscapeArbitratedPacket && teamEscapeScoringState != null)
			{
				TeamEscapeEntrantArbitratedPacket teamEscapeEntrantArbitratedPacket = teamEscapeArbitratedPacket.CreateEntrantArbitratedPacket();
				Marshal.Get().FillFEPlayerPersona(entrant.PersonaId, teamEscapeEntrantArbitratedPacket);
				teamEscapeEntrantArbitratedPacket.PersonaId = entrant.PersonaId;
				teamEscapeEntrantArbitratedPacket.SetPersonaName(entrant.Opponent.OpponentName);
				teamEscapeEntrantArbitratedPacket.SetMotto(entrant.Opponent.Motto);
				teamEscapeEntrantArbitratedPacket.HasArbitrated = teamEscapeScoringState.HasArbitrated;
				teamEscapeEntrantArbitratedPacket.FinishReason = teamEscapeScoringState.FinishReason;
				teamEscapeEntrantArbitratedPacket.Rank = teamEscapeScoringState.Rank;
				teamEscapeEntrantArbitratedPacket.Level = teamEscapeScoringState.Level;
				teamEscapeEntrantArbitratedPacket.IconIndex = (long)((ulong)entrant.Opponent.IconIndex);
				teamEscapeEntrantArbitratedPacket.IsLocal = (entrant.Opponent is LocalHumanOpponent);
				teamEscapeEntrantArbitratedPacket.EventDuration = teamEscapeScoringState.EventDurationInSeconds;
				Powerups.FillEntrantArbitratedPacket(teamEscapeEntrantArbitratedPacket);
				entrant.Opponent.FillCarData(teamEscapeEntrantArbitratedPacket.GetCarData());
				teamEscapeEntrantArbitratedPacket.DistanceToFinish = teamEscapeScoringState.DistanceToFinish;
				teamEscapeEntrantArbitratedPacket.Strikes = teamEscapeScoringState.Busts;
				teamEscapeArbitratedPacket.Strikes += teamEscapeScoringState.Busts;
				teamEscapeArbitratedPacket.EventDuration = ((teamEscapeScoringState.EventDurationInSeconds > teamEscapeArbitratedPacket.EventDuration) ? teamEscapeScoringState.EventDurationInSeconds : teamEscapeArbitratedPacket.EventDuration);
			}
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x0002E2F4 File Offset: 0x0002D2F4
		public virtual ScoringState Prepare(EntrantInfo entrant, Event evnt)
		{
			TeamEscapeScoringState teamEscapeScoringState = new TeamEscapeScoringState();
			if (!(entrant.Opponent is LocalHumanOpponent))
			{
				teamEscapeScoringState.TrackerEntity = TrackerManager.Get().CreateEntity(entrant.Opponent);
				TrackerManager.Get().AddEntity(teamEscapeScoringState.TrackerEntity);
			}
			return teamEscapeScoringState;
		}

		// Token: 0x06001995 RID: 6549 RVA: 0x0002E33B File Offset: 0x0002D33B
		public virtual void Launch(ScoringState state)
		{
			state.EventTimer.Start();
			state.SecureEventTimer.Start();
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x0002E354 File Offset: 0x0002D354
		public virtual void Conclude(ScoringState state)
		{
			state.EventTimer.Stop();
			state.SecureEventTimer.Stop();
			TeamEscapeScoringState teamEscapeScoringState = state as TeamEscapeScoringState;
			if (teamEscapeScoringState != null && teamEscapeScoringState.FinishReason == FinishReason.CrossedFinish)
			{
				teamEscapeScoringState.DistanceToFinish = 0f;
			}
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x0002E398 File Offset: 0x0002D398
		public virtual void OnUpdate(EntrantInfo entrant, Event evnt, float dt)
		{
			TeamEscapeScoringState teamEscapeScoringState = entrant.ScoringState as TeamEscapeScoringState;
			InstancedEvent instancedEvent = evnt as InstancedEvent;
			if (teamEscapeScoringState != null)
			{
				teamEscapeScoringState.FractionCompleted = this.GetFractionCompleted(teamEscapeScoringState, entrant, instancedEvent);
				teamEscapeScoringState.DistanceToStartLine = instancedEvent.GetDistanceToStartLine(entrant.Opponent.Vehicle);
				teamEscapeScoringState.DistanceToFinish = this.GetDistanceToFinish(teamEscapeScoringState, entrant, instancedEvent);
				if (!instancedEvent.IsTimingOut)
				{
					teamEscapeScoringState.TimeRemaining = evnt.EventDef.TimeLimit() - entrant.ScoringState.EventDurationInSeconds;
				}
				else
				{
					teamEscapeScoringState.TimeRemaining = (float)instancedEvent.TimingOutRemaining.TotalSeconds;
				}
				if (!teamEscapeScoringState.IsTimerUrgent && teamEscapeScoringState.TimeRemaining < evnt.EventDef.TimeLimitWarning())
				{
					teamEscapeScoringState.IsTimerUrgent = true;
					new OnTimingOut(entrant.PersonaId).Post(Ports.Gameplay);
				}
				float speed = entrant.Opponent.Vehicle.GetSpeed();
				if (speed > teamEscapeScoringState.TopSpeed)
				{
					teamEscapeScoringState.TopSpeed = speed;
				}
				if (entrant.Opponent.Vehicle.GetCurrentAirborneTime() > teamEscapeScoringState.LongestAirTimeInSeconds)
				{
					teamEscapeScoringState.LongestAirTimeInSeconds = entrant.Opponent.Vehicle.GetCurrentAirborneTime();
				}
				if (entrant.Opponent.InternalOpponent.GetNumOpponentsCollidedWith() > teamEscapeScoringState.NumOpponentsTagged)
				{
					teamEscapeScoringState.NumOpponentsTagged = entrant.Opponent.InternalOpponent.GetNumOpponentsCollidedWith();
				}
				if (entrant.Opponent is LocalHumanOpponent)
				{
					Screen.Print(-300, 120, string.Format("{0} : {1}", entrant.Opponent.OpponentName, teamEscapeScoringState.FractionCompleted));
				}
				entrant.Opponent.InternalOpponent.SetFractionEventComplete(teamEscapeScoringState.FractionCompleted);
				LocalHumanOpponent localHumanOpponent = entrant.Opponent as LocalHumanOpponent;
				if (localHumanOpponent != null)
				{
					PursuitInfo pursuitData = localHumanOpponent.PursuitData;
					teamEscapeScoringState.CopsDisabled = pursuitData.GetNumCopsDisabled();
					teamEscapeScoringState.CopsRammed = pursuitData.GetNumCopsRammed();
					teamEscapeScoringState.CopsDeployed = pursuitData.GetNumCopsDeployed();
					teamEscapeScoringState.CostToState = pursuitData.GetCostToState();
					teamEscapeScoringState.SpikeStripsDodged = pursuitData.GetSpikeStripsDodged();
					teamEscapeScoringState.RoadBlocksDodged = pursuitData.GetRoadBlocksDodged();
					teamEscapeScoringState.Infractions = pursuitData.GetInfractions();
					pursuitData.HACK_SetPursuitMeter(teamEscapeScoringState.PursuitBar);
				}
			}
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x0002E5B2 File Offset: 0x0002D5B2
		public virtual void OnLapCompleted(EntrantInfo entrant, Event evnt, int lap)
		{
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x0002E5B4 File Offset: 0x0002D5B4
		protected virtual float GetDistanceToFinish(TeamEscapeScoringState state, EntrantInfo entrant, InstancedEvent evnt)
		{
			float num = evnt.TrackLayout.GetLapStartToVehicleDistance(entrant.Opponent.Vehicle);
			float lapStartToCheckpointDistance = evnt.TrackLayout.GetLapStartToCheckpointDistance(entrant.RoutingState.NextIndex);
			if (num > lapStartToCheckpointDistance)
			{
				num -= evnt.TrackLayout.GetLapLength(0);
			}
			if (num <= 0f)
			{
				num = -evnt.GetDistanceToStartLine(entrant.Opponent.Vehicle);
			}
			return evnt.TrackLayout.GetLength(evnt.NumLaps) - num;
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x0002E630 File Offset: 0x0002D630
		protected virtual float GetFractionCompleted(TeamEscapeScoringState state, EntrantInfo entrant, InstancedEvent evnt)
		{
			float num = evnt.TrackLayout.GetLapStartToVehicleDistance(entrant.Opponent.Vehicle);
			float lapStartToCheckpointDistance = evnt.TrackLayout.GetLapStartToCheckpointDistance(entrant.RoutingState.NextIndex);
			if (num > lapStartToCheckpointDistance)
			{
				num -= evnt.TrackLayout.GetLapLength(0);
			}
			num = Math.Max(num, 0f);
			return Math.Min(num / evnt.TrackLayout.GetLength(evnt.NumLaps), 1f);
		}

		// Token: 0x0600199B RID: 6555 RVA: 0x0002E6A7 File Offset: 0x0002D6A7
		protected virtual float GetFractionLapCompleted(TeamEscapeScoringState state, EntrantInfo entrant, InstancedEvent evnt)
		{
			return this.GetFractionCompleted(state, entrant, evnt);
		}

		// Token: 0x0600199C RID: 6556 RVA: 0x0002E6B2 File Offset: 0x0002D6B2
		public virtual void OnRoutingFinished(EntrantInfo entrant)
		{
			Console.WriteLine("CS: {0} has finished routing.", entrant.Opponent.OpponentName);
			if (entrant.Opponent is LocalOpponent)
			{
				entrant.ScoringState.FinishReason = FinishReason.CrossedFinish;
			}
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x0002E6E3 File Offset: 0x0002D6E3
		public virtual void Sort(List<EntrantInfo> entrants)
		{
			entrants.Sort(new Comparison<EntrantInfo>(this.Sort));
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x0002E6F8 File Offset: 0x0002D6F8
		private int Sort(EntrantInfo le, EntrantInfo re)
		{
			TeamEscapeScoringState teamEscapeScoringState = le.ScoringState as TeamEscapeScoringState;
			TeamEscapeScoringState teamEscapeScoringState2 = re.ScoringState as TeamEscapeScoringState;
			if (teamEscapeScoringState == null || teamEscapeScoringState2 == null)
			{
				return 0;
			}
			if (!teamEscapeScoringState.IsFinishReason(FinishReason.Disconnected) && teamEscapeScoringState2.IsFinishReason(FinishReason.Disconnected))
			{
				return -1;
			}
			if (teamEscapeScoringState.IsFinishReason(FinishReason.Disconnected) && !teamEscapeScoringState2.IsFinishReason(FinishReason.Disconnected))
			{
				return 1;
			}
			if (teamEscapeScoringState.IsFinishReason(FinishReason.Disconnected) && teamEscapeScoringState2.IsFinishReason(FinishReason.Disconnected))
			{
				if (teamEscapeScoringState2.FractionCompleted != teamEscapeScoringState.FractionCompleted)
				{
					if (teamEscapeScoringState.FractionCompleted <= teamEscapeScoringState2.FractionCompleted)
					{
						return 1;
					}
					return -1;
				}
				else
				{
					if (le.Opponent.GridIndex <= re.Opponent.GridIndex)
					{
						return 1;
					}
					return -1;
				}
			}
			else
			{
				if (!teamEscapeScoringState.IsFinishReason(FinishReason.DidNotFinish) && teamEscapeScoringState2.IsFinishReason(FinishReason.DidNotFinish))
				{
					return -1;
				}
				if (teamEscapeScoringState.IsFinishReason(FinishReason.DidNotFinish) && !teamEscapeScoringState2.IsFinishReason(FinishReason.DidNotFinish))
				{
					return 1;
				}
				if (teamEscapeScoringState.IsFinishReason(FinishReason.DidNotFinish) && teamEscapeScoringState2.IsFinishReason(FinishReason.DidNotFinish))
				{
					if (teamEscapeScoringState2.FractionCompleted != teamEscapeScoringState.FractionCompleted)
					{
						if (teamEscapeScoringState.FractionCompleted <= teamEscapeScoringState2.FractionCompleted)
						{
							return 1;
						}
						return -1;
					}
					else
					{
						if (le.Opponent.GridIndex <= re.Opponent.GridIndex)
						{
							return 1;
						}
						return -1;
					}
				}
				else
				{
					if (!teamEscapeScoringState.IsFinishReason(FinishReason.CrossedFinish) && teamEscapeScoringState2.IsFinishReason(FinishReason.CrossedFinish))
					{
						return 1;
					}
					if (teamEscapeScoringState.IsFinishReason(FinishReason.CrossedFinish) && !teamEscapeScoringState2.IsFinishReason(FinishReason.CrossedFinish))
					{
						return -1;
					}
					if (teamEscapeScoringState.IsFinishReason(FinishReason.CrossedFinish) && teamEscapeScoringState2.IsFinishReason(FinishReason.CrossedFinish))
					{
						if (teamEscapeScoringState.EventDurationInMilliseconds != teamEscapeScoringState2.EventDurationInMilliseconds)
						{
							if (teamEscapeScoringState.EventDurationInMilliseconds >= teamEscapeScoringState2.EventDurationInMilliseconds)
							{
								return 1;
							}
							return -1;
						}
						else
						{
							if (le.Opponent.GridIndex <= re.Opponent.GridIndex)
							{
								return 1;
							}
							return -1;
						}
					}
					else if (teamEscapeScoringState.FractionCompleted == 0f && teamEscapeScoringState2.FractionCompleted == 0f)
					{
						if (teamEscapeScoringState.DistanceToStartLine != teamEscapeScoringState2.DistanceToStartLine)
						{
							if (teamEscapeScoringState.DistanceToStartLine >= teamEscapeScoringState2.DistanceToStartLine)
							{
								return 1;
							}
							return -1;
						}
						else
						{
							if (le.Opponent.GridIndex <= re.Opponent.GridIndex)
							{
								return 1;
							}
							return -1;
						}
					}
					else if (teamEscapeScoringState.FractionCompleted != teamEscapeScoringState2.FractionCompleted)
					{
						if (teamEscapeScoringState.FractionCompleted <= teamEscapeScoringState2.FractionCompleted)
						{
							return 1;
						}
						return -1;
					}
					else
					{
						if (le.Opponent.GridIndex <= re.Opponent.GridIndex)
						{
							return 1;
						}
						return -1;
					}
				}
			}
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x0002E93C File Offset: 0x0002D93C
		public ArbitrationPacket FillArbitrationRecord(EntrantInfo entrant)
		{
			TeamEscapeScoringState teamEscapeScoringState = entrant.ScoringState as TeamEscapeScoringState;
			if (teamEscapeScoringState != null)
			{
				return new TeamEscapeArbitrationPacket
				{
					Rank = teamEscapeScoringState.Rank,
					EventDurationInMilliseconds = teamEscapeScoringState.EventDurationInMilliseconds,
					AlternateEventDurationInMilliseconds = teamEscapeScoringState.SecureEventDurationInMilliseconds,
					HacksDetected = SecurityManager.GetHacks(),
					FinishReason = (int)teamEscapeScoringState.FinishReason,
					FractionCompleted = teamEscapeScoringState.FractionCompleted,
					TopSpeed = teamEscapeScoringState.TopSpeed,
					LongestJumpDurationInMilliseconds = teamEscapeScoringState.LongestAirTimeInMilliseconds,
					SumOfJumpsDurationInMilliseconds = teamEscapeScoringState.SumAirTimeInMilliseconds,
					PerfectStart = (int)teamEscapeScoringState.PerfectStart,
					NumberOfCollisions = teamEscapeScoringState.NumOpponentsTagged,
					BustedCount = teamEscapeScoringState.Busts,
					DistanceToFinish = teamEscapeScoringState.DistanceToFinish,
					CopsDeployed = teamEscapeScoringState.CopsDeployed,
					CopsDisabled = teamEscapeScoringState.CopsDisabled,
					CopsRammed = teamEscapeScoringState.CopsRammed,
					CostToState = teamEscapeScoringState.CostToState,
					Infractions = teamEscapeScoringState.Infractions,
					RoadBlocksDodged = teamEscapeScoringState.RoadBlocksDodged,
					SpikeStripsDodged = teamEscapeScoringState.SpikeStripsDodged
				};
			}
			return null;
		}

		// Token: 0x060019A0 RID: 6560 RVA: 0x0002EA54 File Offset: 0x0002DA54
		public EventResult Arbitrated(Event evnt, XmlString xmlString)
		{
			InstancedEvent instancedEvent = evnt as InstancedEvent;
			TeamEscapeEventResult teamEscapeEventResult;
			if (XSD2CPP.ReadTeamEscapeEventResult(xmlString, out teamEscapeEventResult) && teamEscapeEventResult.EventSessionId == instancedEvent.EventSessionId)
			{
				foreach (TeamEscapeEntrantResult teamEscapeEntrantResult in teamEscapeEventResult.Entrants)
				{
					EntrantInfo entrantInfo = evnt.FindEntrant(teamEscapeEntrantResult.PersonaId);
					if (entrantInfo != null)
					{
						TeamEscapeScoringState teamEscapeScoringState = entrantInfo.ScoringState as TeamEscapeScoringState;
						if (teamEscapeScoringState != null && !teamEscapeScoringState.HasArbitrated && teamEscapeEntrantResult.FinishReason != 0)
						{
							teamEscapeScoringState.HasArbitrated = true;
							teamEscapeScoringState.FinishReason = (FinishReason)teamEscapeEntrantResult.FinishReason;
							teamEscapeScoringState.EventDurationInMilliseconds = teamEscapeEntrantResult.EventDurationInMilliseconds;
							teamEscapeScoringState.FractionCompleted = teamEscapeEntrantResult.FractionCompleted;
							teamEscapeScoringState.DistanceToFinish = teamEscapeEntrantResult.DistanceToFinish;
							teamEscapeScoringState.Rank = teamEscapeEntrantResult.Ranking;
						}
					}
				}
				Marshal.Get().SetLocalPlayersDurability(teamEscapeEventResult.Durability);
				return teamEscapeEventResult;
			}
			return null;
		}

		// Token: 0x060019A1 RID: 6561 RVA: 0x0002EB5C File Offset: 0x0002DB5C
		public void EntrantResultReceived(Event evnt, XmlString xmlString)
		{
			InstancedEvent instancedEvent = evnt as InstancedEvent;
			TeamEscapeEntrantResult teamEscapeEntrantResult;
			if (XSD2CPP.ReadTeamEscapeEntrantResult(xmlString, out teamEscapeEntrantResult) && teamEscapeEntrantResult.EventSessionId == instancedEvent.EventSessionId)
			{
				EntrantInfo entrantInfo = evnt.FindEntrant(teamEscapeEntrantResult.PersonaId);
				if (entrantInfo == null)
				{
					return;
				}
				TeamEscapeScoringState teamEscapeScoringState = entrantInfo.ScoringState as TeamEscapeScoringState;
				if (teamEscapeScoringState != null)
				{
					teamEscapeScoringState.HasArbitrated = true;
					teamEscapeScoringState.FinishReason = (FinishReason)teamEscapeEntrantResult.FinishReason;
					teamEscapeScoringState.EventDurationInMilliseconds = teamEscapeEntrantResult.EventDurationInMilliseconds;
					teamEscapeScoringState.FractionCompleted = teamEscapeEntrantResult.FractionCompleted;
					teamEscapeScoringState.DistanceToFinish = teamEscapeEntrantResult.DistanceToFinish;
					teamEscapeScoringState.Rank = teamEscapeEntrantResult.Ranking;
				}
			}
		}

		// Token: 0x060019A2 RID: 6562 RVA: 0x0002EBEC File Offset: 0x0002DBEC
		private unsafe bool IsJumpStartActive(EntrantInfo entrantInfo, Event evnt)
		{
			LocalHumanOpponent localHumanOpponent = entrantInfo.Opponent as LocalHumanOpponent;
			TeamEscapeScoringState teamEscapeScoringState = entrantInfo.ScoringState as TeamEscapeScoringState;
			if (teamEscapeScoringState == null || localHumanOpponent == null)
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
			return teamEscapeScoringState.EventDurationInSeconds <= num2 && teamEscapeScoringState.EventDurationInSeconds > num3;
		}

		// Token: 0x060019A3 RID: 6563 RVA: 0x0002EC68 File Offset: 0x0002DC68
		public bool IsPowerupRestricted(Restriction restriction, EntrantInfo entrantInfo, Event evnt)
		{
			LocalHumanOpponent localHumanOpponent = entrantInfo.Opponent as LocalHumanOpponent;
			TeamEscapeScoringState teamEscapeScoringState = entrantInfo.ScoringState as TeamEscapeScoringState;
			if (teamEscapeScoringState == null)
			{
				return true;
			}
			if (teamEscapeScoringState.EventDurationInSeconds < evnt.EventDef.PowerupBlackoutAtEventStart() && localHumanOpponent != null && !this.IsJumpStartActive(entrantInfo, evnt))
			{
				return true;
			}
			switch (restriction)
			{
			case Restriction.kPowerupRestriction_NobodyHasFinishedEvent:
				foreach (EntrantInfo entrantInfo2 in evnt.Entrants)
				{
					TeamEscapeScoringState teamEscapeScoringState2 = entrantInfo2.ScoringState as TeamEscapeScoringState;
					if (teamEscapeScoringState2 != null && teamEscapeScoringState2.FractionCompleted > 0.95f)
					{
						return true;
					}
				}
				break;
			case Restriction.kPowerupRestriction_IAmNotInFirstPlace:
			{
				if (teamEscapeScoringState.Rank == 1)
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
				if (num == teamEscapeScoringState.Rank)
				{
					return true;
				}
				break;
			}
			}
			return false;
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x0002EDD4 File Offset: 0x0002DDD4
		public void DoEffect(EntrantInfo entrant, powerup_gamegroup effect, uint indexMagnitude, uint indexRange)
		{
			GameplayEffect gameplayEffect = effect.effect();
			if (gameplayEffect != GameplayEffect.kGameplayEffect_DecrementBustMeter)
			{
				return;
			}
			TeamEscapeScoringState teamEscapeScoringState = entrant.ScoringState as TeamEscapeScoringState;
			if (teamEscapeScoringState != null)
			{
				teamEscapeScoringState.PursuitBar -= effect.magnitude(0u);
			}
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x0002EE11 File Offset: 0x0002DE11
		public void AccoladesFetched(Interop.Accolades accolades)
		{
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x060019A6 RID: 6566 RVA: 0x0002EE13 File Offset: 0x0002DE13
		public string ArbitratedPacketName
		{
			get
			{
				return typeof(TeamEscapeEntrantResult).Name;
			}
		}

		// Token: 0x04000658 RID: 1624
		private const float DefaultBustRadius = 35f;

		// Token: 0x04000659 RID: 1625
		private const float DefaultEvadeRadius = 50f;

		// Token: 0x0400065A RID: 1626
		private const float MaxPursuitRadius = 100f;

		// Token: 0x0400065B RID: 1627
		private const float MinSpeedThresholdInMPH = 25f;
	}
}
