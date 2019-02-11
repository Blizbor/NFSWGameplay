using System;
using System.Collections.Generic;
using Attrib.Gen;
using Interop;
using PowerUps;
using Victory.DataLayer.Serialization.Event;
using Victory.Service.Objects;

namespace GameCore
{
	// Token: 0x02000240 RID: 576
	public interface IScoringMethod
	{
		// Token: 0x06001772 RID: 6002
		void Fill(PursuitInfo pursuitPacket, EntrantInfo entrant);

		// Token: 0x06001773 RID: 6003
		LivePacket CreateLivePacket();

		// Token: 0x06001774 RID: 6004
		void Fill(LivePacket livePacket, Event evnt);

		// Token: 0x06001775 RID: 6005
		void Fill(LivePacket livePacket, EntrantInfo entrant);

		// Token: 0x06001776 RID: 6006
		ArbitratedPacket CreateArbitratedPacket();

		// Token: 0x06001777 RID: 6007
		void Fill(ArbitratedPacket arbitratedPacket, Event evnt);

		// Token: 0x06001778 RID: 6008
		void Fill(ArbitratedPacket arbitratedPacket, EntrantInfo entrant);

		// Token: 0x06001779 RID: 6009
		ScoringState Prepare(EntrantInfo entrant, Event evnt);

		// Token: 0x0600177A RID: 6010
		void Launch(ScoringState state);

		// Token: 0x0600177B RID: 6011
		void Conclude(ScoringState state);

		// Token: 0x0600177C RID: 6012
		void OnUpdate(EntrantInfo entrant, Event evnt, float dt);

		// Token: 0x0600177D RID: 6013
		void OnRoutingFinished(EntrantInfo entrant);

		// Token: 0x0600177E RID: 6014
		void Sort(List<EntrantInfo> entrants);

		// Token: 0x0600177F RID: 6015
		ArbitrationPacket FillArbitrationRecord(EntrantInfo entrant);

		// Token: 0x06001780 RID: 6016
		EventResult Arbitrated(Event evnt, XmlString xmlString);

		// Token: 0x06001781 RID: 6017
		void EntrantResultReceived(Event evnt, XmlString xmlString);

		// Token: 0x06001782 RID: 6018
		bool IsPowerupRestricted(Restriction restriction, EntrantInfo entrantInfo, Event evnt);

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06001783 RID: 6019
		string ArbitratedPacketName { get; }

		// Token: 0x06001784 RID: 6020
		void DoEffect(EntrantInfo entrant, powerup_gamegroup effect, uint indexMagnitude, uint indexRange);

		// Token: 0x06001785 RID: 6021
		void AccoladesFetched(Interop.Accolades accolades);
	}
}
