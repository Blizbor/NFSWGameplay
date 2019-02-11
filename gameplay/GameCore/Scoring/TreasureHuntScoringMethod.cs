using System;
using System.Collections.Generic;
using System.IO;
using Attrib.Gen;
using GameCore.Opponents;
using Interop;
using PowerUps;
using Victory.DataLayer.Serialization.Event;
using Victory.Service.Objects;

namespace GameCore.Scoring
{
	// Token: 0x02000285 RID: 645
	public class TreasureHuntScoringMethod : IScoringMethod
	{
		// Token: 0x060019AE RID: 6574 RVA: 0x0002EE98 File Offset: 0x0002DE98
		public static object Construct(BinaryReader source)
		{
			return new TreasureHuntScoringMethod();
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x0002EE9F File Offset: 0x0002DE9F
		public void Fill(PursuitInfo pursuitPacket, EntrantInfo entrant)
		{
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x0002EEA1 File Offset: 0x0002DEA1
		public LivePacket CreateLivePacket()
		{
			return new TreasureHuntLivePacket();
		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x0002EEA8 File Offset: 0x0002DEA8
		public void Fill(LivePacket livePacket, Event evnt)
		{
			TreasureHuntLivePacket treasureHuntLivePacket = livePacket as TreasureHuntLivePacket;
			if (null != treasureHuntLivePacket)
			{
				treasureHuntLivePacket.NumCoinsToCollect = (int)((evnt.EventDef.Num_Coins() != 100u) ? evnt.EventDef.Num_Coins() : 0u);
			}
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x0002EEE8 File Offset: 0x0002DEE8
		public void Fill(LivePacket livePacket, EntrantInfo entrant)
		{
			TreasureHuntLivePacket treasureHuntLivePacket = livePacket as TreasureHuntLivePacket;
			TreasureHuntScoringState treasureHuntScoringState = entrant.ScoringState as TreasureHuntScoringState;
			if (null != treasureHuntLivePacket && treasureHuntScoringState != null)
			{
				TreasureHuntEntrantLivePacket treasureHuntEntrantLivePacket = treasureHuntLivePacket.CreateEntrantLivePacket();
				treasureHuntEntrantLivePacket.PersonaId = entrant.PersonaId;
				treasureHuntEntrantLivePacket.SetPersonaName(entrant.Opponent.OpponentName);
				treasureHuntEntrantLivePacket.FinishReason = treasureHuntScoringState.FinishReason;
				treasureHuntEntrantLivePacket.Rank = treasureHuntScoringState.Rank;
				treasureHuntEntrantLivePacket.IsLocal = (entrant.Opponent is LocalHumanOpponent);
				treasureHuntEntrantLivePacket.NumCoinsCollected = (int)treasureHuntScoringState.GetNumberOfCollectedCoins();
			}
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x0002EF70 File Offset: 0x0002DF70
		public ArbitratedPacket CreateArbitratedPacket()
		{
			return new TreasureHuntArbitratedPacket();
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x0002EF77 File Offset: 0x0002DF77
		public void Fill(ArbitratedPacket arbitratedPacket, Event evnt)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060019B5 RID: 6581 RVA: 0x0002EF7E File Offset: 0x0002DF7E
		public void Fill(ArbitratedPacket arbitratedPacket, EntrantInfo entrant)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x0002EF88 File Offset: 0x0002DF88
		public virtual ScoringState Prepare(EntrantInfo entrant, Event evnt)
		{
			TreasureHuntScoringState treasureHuntScoringState = new TreasureHuntScoringState();
			treasureHuntScoringState.CoinsCollected = 0u;
			for (uint num = 0u; num < evnt.EventDef.Num_Coins(); num += 1u)
			{
				if (evnt.EventDef.Coins(num).GetCollectionKey() == 0u)
				{
					treasureHuntScoringState.CoinsCollected |= 1u << (int)num;
				}
			}
			return treasureHuntScoringState;
		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x0002EFDF File Offset: 0x0002DFDF
		public virtual void Launch(ScoringState state)
		{
			state.EventTimer.Start();
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x0002EFEC File Offset: 0x0002DFEC
		public virtual void Conclude(ScoringState state)
		{
			state.EventTimer.Stop();
		}

		// Token: 0x060019B9 RID: 6585 RVA: 0x0002EFF9 File Offset: 0x0002DFF9
		public virtual void OnUpdate(EntrantInfo entrant, Event evnt, float dt)
		{
		}

		// Token: 0x060019BA RID: 6586 RVA: 0x0002EFFB File Offset: 0x0002DFFB
		public virtual void OnLapCompleted(EntrantInfo entrant, InstancedEvent evnt, int lap)
		{
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x0002EFFD File Offset: 0x0002DFFD
		public virtual void Sort(List<EntrantInfo> entrants)
		{
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x0002EFFF File Offset: 0x0002DFFF
		private int Sort(EntrantInfo le, EntrantInfo re)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x0002F006 File Offset: 0x0002E006
		public void EntrantResultReceived(Event evnt, XmlString xmlString)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060019BE RID: 6590 RVA: 0x0002F00D File Offset: 0x0002E00D
		public virtual void OnRoutingFinished(EntrantInfo entrant)
		{
		}

		// Token: 0x060019BF RID: 6591 RVA: 0x0002F00F File Offset: 0x0002E00F
		public void DoEffect(EntrantInfo entrant, powerup_gamegroup effect, uint indexMagnitude, uint indexRange)
		{
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x0002F011 File Offset: 0x0002E011
		public ArbitrationPacket FillArbitrationRecord(EntrantInfo entrant)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x0002F018 File Offset: 0x0002E018
		public EventResult Arbitrated(Event evnt, XmlString xmlString)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x0002F01F File Offset: 0x0002E01F
		public bool IsPowerupRestricted(Restriction restriction, EntrantInfo entrantInfo, Event evnt)
		{
			return false;
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x0002F024 File Offset: 0x0002E024
		public void AccoladesFetched(Interop.Accolades accolades)
		{
			if (null == accolades)
			{
				return;
			}
			LuckyDraw luckyDraw = accolades.GetLuckyDraw();
			if (null == luckyDraw)
			{
				return;
			}
			Hud.ShowTreasureStreakBuff(luckyDraw.CurrentStreak, luckyDraw.IsStreakBroken);
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x060019C4 RID: 6596 RVA: 0x0002F05D File Offset: 0x0002E05D
		public string ArbitratedPacketName
		{
			get
			{
				return null;
			}
		}
	}
}
