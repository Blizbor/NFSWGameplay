using System;
using System.Collections.Generic;
using GameCore.Opponents;
using GameCore.Workflow;
using Victory.Service.Objects;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x0200016C RID: 364
	public class Conclude : Component
	{
		// Token: 0x06001315 RID: 4885 RVA: 0x0001B54E File Offset: 0x0001A54E
		public Conclude(InstancedEvent @event, EntrantInfo entrant) : base(@event, entrant)
		{
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x0001B558 File Offset: 0x0001A558
		protected internal override void Execute(ActivityExecutionContext context)
		{
			base.Entrant.Conclude(base.Event.ScoringMethod);
			if (base.Entrant.Opponent is LocalHumanOpponent)
			{
				ArbitrationPacket arbitrationPacket = base.Event.ScoringMethod.FillArbitrationRecord(base.Entrant);
				if (arbitrationPacket != null)
				{
					base.InstancedEvent.Arbitrate(arbitrationPacket);
				}
			}
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x0001B5B4 File Offset: 0x0001A5B4
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
