using System;
using System.Collections.Generic;
using System.IO;
using Attrib.Gen;
using GameCore.Opponents;
using GameCore.Powerups;
using Interop;
using PowerUps;
using Victory.DataLayer.Serialization.Event;
using Victory.Service.Objects;
using xsd2cpp;

namespace GameCore.Scoring
{
	// Token: 0x0200027F RID: 639
	public class PursuitScoringMethod : IScoringMethod
	{
		// Token: 0x06001910 RID: 6416 RVA: 0x0002CB07 File Offset: 0x0002BB07
		public static object Construct(BinaryReader source)
		{
			return new PursuitScoringMethod();
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x0002CB0E File Offset: 0x0002BB0E
		public void Fill(PursuitInfo pursuitPacket, EntrantInfo entrant)
		{
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x0002CB10 File Offset: 0x0002BB10
		public LivePacket CreateLivePacket()
		{
			return null;
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x0002CB13 File Offset: 0x0002BB13
		public void Fill(LivePacket livePacket, Event evnt)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x0002CB1A File Offset: 0x0002BB1A
		public void Fill(LivePacket livePacket, EntrantInfo entrant)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x0002CB21 File Offset: 0x0002BB21
		public ArbitratedPacket CreateArbitratedPacket()
		{
			return new PursuitArbitratedPacket();
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x0002CB28 File Offset: 0x0002BB28
		public void Fill(ArbitratedPacket arbitratedPacket, Event evnt)
		{
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x0002CB2C File Offset: 0x0002BB2C
		public void Fill(ArbitratedPacket arbitratedPacket, EntrantInfo entrant)
		{
			PursuitArbitratedPacket pursuitArbitratedPacket = arbitratedPacket as PursuitArbitratedPacket;
			PursuitScoringState pursuitScoringState = entrant.ScoringState as PursuitScoringState;
			if (pursuitScoringState != null && null != pursuitArbitratedPacket)
			{
				PursuitEntrantArbitratedPacket pursuitEntrantArbitratedPacket = pursuitArbitratedPacket.CreateEntrantArbitratedPacket();
				Marshal.Get().FillFEPlayerPersona(entrant.PersonaId, pursuitEntrantArbitratedPacket);
				pursuitEntrantArbitratedPacket.PersonaId = entrant.PersonaId;
				pursuitEntrantArbitratedPacket.SetPersonaName(entrant.Opponent.OpponentName);
				pursuitEntrantArbitratedPacket.SetMotto(entrant.Opponent.Motto);
				pursuitEntrantArbitratedPacket.HasArbitrated = pursuitScoringState.HasArbitrated;
				pursuitEntrantArbitratedPacket.FinishReason = pursuitScoringState.FinishReason;
				pursuitEntrantArbitratedPacket.Rank = pursuitScoringState.Rank;
				pursuitEntrantArbitratedPacket.Level = pursuitScoringState.Level;
				pursuitEntrantArbitratedPacket.IconIndex = (long)((ulong)entrant.Opponent.IconIndex);
				pursuitEntrantArbitratedPacket.IsLocal = (entrant.Opponent is LocalHumanOpponent);
				pursuitEntrantArbitratedPacket.EventDuration = pursuitScoringState.EventDurationInSeconds;
				Powerups.FillEntrantArbitratedPacket(pursuitEntrantArbitratedPacket);
				entrant.Opponent.FillCarData(pursuitEntrantArbitratedPacket.GetCarData());
				pursuitEntrantArbitratedPacket.LongestJumpDuration = pursuitScoringState.LongestAirTimeInSeconds;
				pursuitEntrantArbitratedPacket.TopSpeed = pursuitScoringState.TopSpeed;
				pursuitEntrantArbitratedPacket.CopsDeployed = pursuitScoringState.CopsDeployed;
				pursuitEntrantArbitratedPacket.CopsDisabled = pursuitScoringState.CopsDisabled;
				pursuitEntrantArbitratedPacket.CopsRammed = pursuitScoringState.CopsRammed;
				pursuitEntrantArbitratedPacket.CostToState = pursuitScoringState.CostToState;
				pursuitEntrantArbitratedPacket.Heat = pursuitScoringState.Heat;
				pursuitEntrantArbitratedPacket.Infractions = pursuitScoringState.Infractions;
				pursuitEntrantArbitratedPacket.RoadBlocksDodged = pursuitScoringState.RoadBlocksDodged;
				pursuitEntrantArbitratedPacket.SpikeStripsDodged = pursuitScoringState.SpikeStripsDodged;
			}
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x0002CC96 File Offset: 0x0002BC96
		public ScoringState Prepare(EntrantInfo entrant, Event evnt)
		{
			Cops.ResetPursuitStats();
			return new PursuitScoringState();
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x0002CCA2 File Offset: 0x0002BCA2
		public void Launch(ScoringState state)
		{
			state.EventTimer.Start();
			state.SecureEventTimer.Start();
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x0002CCBA File Offset: 0x0002BCBA
		public void Conclude(ScoringState state)
		{
			state.EventTimer.Stop();
			state.SecureEventTimer.Stop();
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x0002CCD4 File Offset: 0x0002BCD4
		public void OnUpdate(EntrantInfo entrant, Event evnt, float dt)
		{
			PursuitScoringState pursuitScoringState = entrant.ScoringState as PursuitScoringState;
			if (pursuitScoringState != null)
			{
				float speed = entrant.Opponent.Vehicle.GetSpeed();
				if (speed > pursuitScoringState.TopSpeed)
				{
					pursuitScoringState.TopSpeed = speed;
				}
				if (entrant.Opponent.Vehicle.GetCurrentAirborneTime() > pursuitScoringState.LongestAirTimeInSeconds)
				{
					pursuitScoringState.LongestAirTimeInSeconds = entrant.Opponent.Vehicle.GetCurrentAirborneTime();
				}
				if (entrant.Opponent.Vehicle.GetNumWheelsOnGround() == 0)
				{
					pursuitScoringState.SumAirTimeInSeconds += dt;
				}
				LocalHumanOpponent localHumanOpponent = entrant.Opponent as LocalHumanOpponent;
				if (localHumanOpponent != null)
				{
					PursuitInfo pursuitData = localHumanOpponent.PursuitData;
					pursuitScoringState.Heat = Cops.GetPursuitHeat();
					pursuitScoringState.CopsDisabled = pursuitData.GetNumCopsDisabled();
					pursuitScoringState.CopsRammed = pursuitData.GetNumCopsRammed();
					pursuitScoringState.CopsDeployed = pursuitData.GetNumCopsDeployed();
					pursuitScoringState.CostToState = pursuitData.GetCostToState();
					pursuitScoringState.SpikeStripsDodged = pursuitData.GetSpikeStripsDodged();
					pursuitScoringState.RoadBlocksDodged = pursuitData.GetRoadBlocksDodged();
					pursuitScoringState.Infractions = pursuitData.GetInfractions();
					pursuitScoringState.EventDurationInMilliseconds = pursuitData.GetPursuitDuration();
				}
			}
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x0002CDE3 File Offset: 0x0002BDE3
		public void OnRoutingFinished(EntrantInfo entrant)
		{
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x0002CDE5 File Offset: 0x0002BDE5
		public void Sort(List<EntrantInfo> entrants)
		{
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x0002CDE8 File Offset: 0x0002BDE8
		public ArbitrationPacket FillArbitrationRecord(EntrantInfo entrant)
		{
			PursuitScoringState pursuitScoringState = entrant.ScoringState as PursuitScoringState;
			if (pursuitScoringState != null)
			{
				return new PursuitArbitrationPacket
				{
					Rank = pursuitScoringState.Rank,
					EventDurationInMilliseconds = pursuitScoringState.EventDurationInMilliseconds,
					AlternateEventDurationInMilliseconds = pursuitScoringState.SecureEventDurationInMilliseconds,
					HacksDetected = SecurityManager.GetHacks(),
					FinishReason = (int)pursuitScoringState.FinishReason,
					TopSpeed = pursuitScoringState.TopSpeed,
					LongestJumpDurationInMilliseconds = pursuitScoringState.LongestAirTimeInMilliseconds,
					SumOfJumpsDurationInMilliseconds = pursuitScoringState.SumAirTimeInMilliseconds,
					CopsDeployed = pursuitScoringState.CopsDeployed,
					CopsDisabled = pursuitScoringState.CopsDisabled,
					CopsRammed = pursuitScoringState.CopsRammed,
					CostToState = pursuitScoringState.CostToState,
					Heat = pursuitScoringState.Heat,
					Infractions = pursuitScoringState.Infractions,
					RoadBlocksDodged = pursuitScoringState.RoadBlocksDodged,
					SpikeStripsDodged = pursuitScoringState.SpikeStripsDodged
				};
			}
			return null;
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x0002CECF File Offset: 0x0002BECF
		public void EntrantResultReceived(Event evnt, XmlString xmlString)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x0002CED8 File Offset: 0x0002BED8
		public EventResult Arbitrated(Event evnt, XmlString xmlString)
		{
			InstancedEvent instancedEvent = evnt as InstancedEvent;
			PursuitEventResult pursuitEventResult;
			if (!XSD2CPP.ReadPursuitEventResult(xmlString, out pursuitEventResult) || pursuitEventResult.EventSessionId != instancedEvent.EventSessionId)
			{
				return null;
			}
			EntrantInfo entrantInfo = evnt.FindEntrant(pursuitEventResult.PersonaId);
			if (entrantInfo == null)
			{
				return null;
			}
			LocalHumanOpponent localHumanOpponent = entrantInfo.Opponent as LocalHumanOpponent;
			if (localHumanOpponent != null)
			{
				localHumanOpponent.Heat = pursuitEventResult.Heat;
			}
			PursuitScoringState pursuitScoringState = entrantInfo.ScoringState as PursuitScoringState;
			if (pursuitScoringState != null)
			{
				pursuitScoringState.HasArbitrated = true;
			}
			Marshal.Get().SetLocalPlayersDurability(pursuitEventResult.Durability);
			return pursuitEventResult;
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x0002CF60 File Offset: 0x0002BF60
		public bool IsPowerupRestricted(Restriction restriction, EntrantInfo entrantInfo, Event evnt)
		{
			if (restriction == Restriction.kPowerupRestriction_IAmNotInFirstPlace)
			{
				return true;
			}
			PursuitScoringState pursuitScoringState = entrantInfo.ScoringState as PursuitScoringState;
			int num = 999;
			foreach (EntrantInfo entrantInfo2 in evnt.Entrants)
			{
				bool flag = entrantInfo2.Opponent.IsStatus(OpponentStatus.kOpponent_Disconnected);
				RouteScoringState routeScoringState = entrantInfo2.ScoringState as RouteScoringState;
				if (routeScoringState != null && routeScoringState.FinishReason == FinishReason.Unknown && !flag && routeScoringState.Rank < num)
				{
					num = routeScoringState.Rank;
				}
			}
			return pursuitScoringState != null && num == pursuitScoringState.Rank;
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x0002D014 File Offset: 0x0002C014
		public void DoEffect(EntrantInfo entrant, powerup_gamegroup effect, uint indexMagnitude, uint indexRange)
		{
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x0002D016 File Offset: 0x0002C016
		public void AccoladesFetched(Interop.Accolades accolades)
		{
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06001924 RID: 6436 RVA: 0x0002D018 File Offset: 0x0002C018
		public string ArbitratedPacketName
		{
			get
			{
				return typeof(PursuitEventResult).Name;
			}
		}
	}
}
