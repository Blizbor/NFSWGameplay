using System;
using System.IO;

namespace GameCore.Routing
{
	// Token: 0x02000277 RID: 631
	public class P2PRoutingMethod : IRoutingMethod
	{
		// Token: 0x060018A4 RID: 6308 RVA: 0x0002BCB5 File Offset: 0x0002ACB5
		public static object Construct(BinaryReader source)
		{
			return new P2PRoutingMethod();
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x0002BCBC File Offset: 0x0002ACBC
		public RoutingState Prepare(InstancedEvent evnt, EntrantInfo entrant)
		{
			P2PRoutingState s = new P2PRoutingState();
			return this.HitTrigger(evnt, entrant, s);
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x0002BCD8 File Offset: 0x0002ACD8
		public RoutingState HitTrigger(InstancedEvent evnt, EntrantInfo entrant, RoutingState s)
		{
			P2PRoutingState p2PRoutingState = s as P2PRoutingState;
			if (p2PRoutingState != null && p2PRoutingState.NextIndex < evnt.Route.Count)
			{
				p2PRoutingState.CurrentTarget = evnt.Route[p2PRoutingState.NextIndex++];
				return p2PRoutingState;
			}
			s.CurrentTarget = null;
			s.IsRoutingFinished = true;
			return s;
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x0002BD35 File Offset: 0x0002AD35
		public RoutePoint GetExpectedPreviousTarget(InstancedEvent evnt, RoutingState s)
		{
			return null;
		}
	}
}
