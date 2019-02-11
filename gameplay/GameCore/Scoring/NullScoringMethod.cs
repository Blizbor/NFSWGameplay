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
	// Token: 0x0200027D RID: 637
	public class NullScoringMethod : IScoringMethod
	{
		// Token: 0x060018DC RID: 6364 RVA: 0x0002C891 File Offset: 0x0002B891
		public static object Construct(BinaryReader source)
		{
			return new NullScoringMethod();
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x0002C898 File Offset: 0x0002B898
		public void Fill(PursuitInfo pursuitPacket, EntrantInfo entrant)
		{
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x0002C89A File Offset: 0x0002B89A
		public LivePacket CreateLivePacket()
		{
			return new NullLivePacket();
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x0002C8A1 File Offset: 0x0002B8A1
		public void Fill(LivePacket livePacket, Event evnt)
		{
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x0002C8A4 File Offset: 0x0002B8A4
		public void Fill(LivePacket livePacket, EntrantInfo entrant)
		{
			NullLivePacket nullLivePacket = livePacket as NullLivePacket;
			NullScoringState nullScoringState = entrant.ScoringState as NullScoringState;
			if (null != nullLivePacket && nullScoringState != null)
			{
				NullEntrantLivePacket nullEntrantLivePacket = nullLivePacket.CreateEntrantLivePacket();
				nullEntrantLivePacket.SetPersonaName(entrant.Opponent.OpponentName);
				nullEntrantLivePacket.PersonaId = entrant.PersonaId;
				nullEntrantLivePacket.FinishReason = nullScoringState.FinishReason;
				nullEntrantLivePacket.Rank = nullScoringState.Rank;
				nullEntrantLivePacket.IsLocal = (entrant.Opponent is LocalHumanOpponent);
			}
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x0002C920 File Offset: 0x0002B920
		public ArbitratedPacket CreateArbitratedPacket()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x0002C927 File Offset: 0x0002B927
		public void Fill(ArbitratedPacket arbitratedPacket, Event evnt)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x0002C92E File Offset: 0x0002B92E
		public void Fill(ArbitratedPacket arbitratedPacket, EntrantInfo entrant)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x0002C935 File Offset: 0x0002B935
		public ScoringState Prepare(EntrantInfo entrant, Event evnt)
		{
			return new NullScoringState();
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x0002C93C File Offset: 0x0002B93C
		public void Launch(ScoringState state)
		{
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x0002C93E File Offset: 0x0002B93E
		public void Conclude(ScoringState state)
		{
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x0002C940 File Offset: 0x0002B940
		public void OnUpdate(EntrantInfo entrant, Event evnt, float dt)
		{
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x0002C942 File Offset: 0x0002B942
		public void OnRoutingFinished(EntrantInfo entrant)
		{
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x0002C944 File Offset: 0x0002B944
		public void Sort(List<EntrantInfo> entrants)
		{
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x0002C946 File Offset: 0x0002B946
		public ArbitrationPacket FillArbitrationRecord(EntrantInfo entrant)
		{
			return null;
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x0002C949 File Offset: 0x0002B949
		public void EntrantResultReceived(Event evnt, XmlString xmlString)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060018EC RID: 6380 RVA: 0x0002C950 File Offset: 0x0002B950
		public EventResult Arbitrated(Event evnt, XmlString xmlString)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060018ED RID: 6381 RVA: 0x0002C957 File Offset: 0x0002B957
		public bool IsPowerupRestricted(Restriction restriction, EntrantInfo entrantInfo, Event evnt)
		{
			return true;
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x0002C95A File Offset: 0x0002B95A
		public void DoEffect(EntrantInfo entrant, powerup_gamegroup effect, uint indexMagnitude, uint indexRange)
		{
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x0002C95C File Offset: 0x0002B95C
		public void AccoladesFetched(Interop.Accolades accolades)
		{
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x060018F0 RID: 6384 RVA: 0x0002C95E File Offset: 0x0002B95E
		public string ArbitratedPacketName
		{
			get
			{
				return null;
			}
		}
	}
}
