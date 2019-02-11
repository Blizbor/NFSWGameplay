using System;
using System.Collections.Generic;
using GameCore.Opponents;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x02000184 RID: 388
	public class Launch : Component
	{
		// Token: 0x0600136E RID: 4974 RVA: 0x0001C16C File Offset: 0x0001B16C
		public Launch(InstancedEvent @event, EntrantInfo entrant) : base(@event, entrant)
		{
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x0001C176 File Offset: 0x0001B176
		protected internal override void Execute(ActivityExecutionContext context)
		{
			base.Entrant.Launch(base.Event.ScoringMethod);
			if (base.Entrant.Opponent is LocalHumanOpponent)
			{
				base.InstancedEvent.Launched();
			}
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x0001C1AB File Offset: 0x0001B1AB
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
