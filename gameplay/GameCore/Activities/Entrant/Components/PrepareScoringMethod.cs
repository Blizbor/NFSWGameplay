using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x0200018C RID: 396
	public class PrepareScoringMethod : Component
	{
		// Token: 0x0600138A RID: 5002 RVA: 0x0001C50F File Offset: 0x0001B50F
		public PrepareScoringMethod(Event @event, EntrantInfo entrant) : base(@event, entrant)
		{
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x0001C519 File Offset: 0x0001B519
		protected internal override void Execute(ActivityExecutionContext context)
		{
			base.Entrant.Prepare(base.Event);
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x0001C52C File Offset: 0x0001B52C
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
