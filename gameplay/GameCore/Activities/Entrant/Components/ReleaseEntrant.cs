using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x02000190 RID: 400
	public class ReleaseEntrant : Component
	{
		// Token: 0x06001397 RID: 5015 RVA: 0x0001C76C File Offset: 0x0001B76C
		public ReleaseEntrant(InstancedEvent @event, EntrantInfo entrant) : base(@event, entrant)
		{
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x0001C776 File Offset: 0x0001B776
		protected internal override void Execute(ActivityExecutionContext context)
		{
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x0001C778 File Offset: 0x0001B778
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
