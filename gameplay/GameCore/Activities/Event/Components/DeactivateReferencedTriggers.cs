using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001BB RID: 443
	public class DeactivateReferencedTriggers : Component<Event>
	{
		// Token: 0x06001435 RID: 5173 RVA: 0x00021169 File Offset: 0x00020169
		public DeactivateReferencedTriggers(Event @event) : base(@event)
		{
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x00021172 File Offset: 0x00020172
		protected internal override void Execute(ActivityExecutionContext context)
		{
			base.Event.DeactivateReferencedTriggers();
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x0002117F File Offset: 0x0002017F
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
