using System;
using System.IO;
using GameCore.Scoring;

namespace GameCore.Routing
{
	// Token: 0x02000275 RID: 629
	public class CircuitRoutingMethod : IRoutingMethod
	{
		// Token: 0x0600189E RID: 6302 RVA: 0x0002BB7D File Offset: 0x0002AB7D
		public static object Construct(BinaryReader source)
		{
			return new CircuitRoutingMethod();
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x0002BB84 File Offset: 0x0002AB84
		public RoutingState Prepare(InstancedEvent evnt, EntrantInfo entrant)
		{
			CircuitRoutingState s = new CircuitRoutingState();
			return this.HitTrigger(evnt, entrant, s);
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x0002BBA0 File Offset: 0x0002ABA0
		public RoutingState HitTrigger(InstancedEvent evnt, EntrantInfo entrant, RoutingState s)
		{
			CircuitRoutingState circuitRoutingState = s as CircuitRoutingState;
			if (circuitRoutingState != null)
			{
				if (circuitRoutingState.NextIndex >= evnt.Route.Count)
				{
					circuitRoutingState.Lap++;
					RouteScoringMethod routeScoringMethod = evnt.ScoringMethod as RouteScoringMethod;
					if (routeScoringMethod != null)
					{
						routeScoringMethod.OnLapCompleted(entrant, evnt, circuitRoutingState.Lap);
					}
					if (circuitRoutingState.Lap >= evnt.NumLaps)
					{
						circuitRoutingState.CurrentTarget = null;
						circuitRoutingState.IsRoutingFinished = true;
						return circuitRoutingState;
					}
					circuitRoutingState.NextIndex = 0;
				}
				circuitRoutingState.CurrentTarget = evnt.Route[circuitRoutingState.NextIndex++];
				return circuitRoutingState;
			}
			s.CurrentTarget = null;
			s.IsRoutingFinished = true;
			return s;
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x0002BC54 File Offset: 0x0002AC54
		public RoutePoint GetExpectedPreviousTarget(InstancedEvent evnt, RoutingState s)
		{
			CircuitRoutingState circuitRoutingState = s as CircuitRoutingState;
			if (circuitRoutingState != null)
			{
				int num = circuitRoutingState.NextIndex + circuitRoutingState.Lap * evnt.Route.Count - 2;
				if (num >= 0)
				{
					return evnt.Route[num % evnt.Route.Count];
				}
			}
			return null;
		}
	}
}
