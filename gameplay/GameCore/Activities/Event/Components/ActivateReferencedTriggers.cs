using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001AF RID: 431
	public class ActivateReferencedTriggers : Component<Event>
	{
		// Token: 0x06001410 RID: 5136 RVA: 0x00020CB3 File Offset: 0x0001FCB3
		public ActivateReferencedTriggers(Event @event) : base(@event)
		{
		}

		// Token: 0x06001411 RID: 5137 RVA: 0x00020CBC File Offset: 0x0001FCBC
		protected internal override void Execute(ActivityExecutionContext context)
		{
			base.Event.ActivateReferencedTriggers();
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x00020CC9 File Offset: 0x0001FCC9
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
