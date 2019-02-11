using System;

namespace GameCore
{
	// Token: 0x0200023F RID: 575
	public interface IRoutingMethod
	{
		// Token: 0x0600176F RID: 5999
		RoutingState Prepare(InstancedEvent evnt, EntrantInfo entrant);

		// Token: 0x06001770 RID: 6000
		RoutingState HitTrigger(InstancedEvent evnt, EntrantInfo entrant, RoutingState state);

		// Token: 0x06001771 RID: 6001
		RoutePoint GetExpectedPreviousTarget(InstancedEvent evnt, RoutingState state);
	}
}
