using System;
using System.Collections.Generic;
using GameCore.Opponents;
using GameCore.Workflow;
using Victory.Service.Objects;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x02000166 RID: 358
	public class Abort : Component
	{
		// Token: 0x06001302 RID: 4866 RVA: 0x0001B3B9 File Offset: 0x0001A3B9
		public Abort(InstancedEvent evnt, EntrantInfo entrant) : base(evnt, entrant)
		{
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x0001B3C4 File Offset: 0x0001A3C4
		protected internal override void Execute(ActivityExecutionContext context)
		{
			if (base.Entrant.Opponent is LocalHumanOpponent)
			{
				base.Entrant.Conclude(base.Event.ScoringMethod);
				ArbitrationPacket arbitrationPacket = base.Event.ScoringMethod.FillArbitrationRecord(base.Entrant);
				if (arbitrationPacket != null)
				{
					base.InstancedEvent.Abort(arbitrationPacket);
					return;
				}
			}
			else
			{
				base.Entrant.Opponent.Vehicle.Deactivate();
			}
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x0001B436 File Offset: 0x0001A436
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
