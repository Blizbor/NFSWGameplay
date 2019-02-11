using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001AE RID: 430
	public class AbortEvent : Component<InstancedEvent>
	{
		// Token: 0x0600140D RID: 5133 RVA: 0x00020C9A File Offset: 0x0001FC9A
		public AbortEvent(InstancedEvent evnt) : base(evnt)
		{
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x00020CA3 File Offset: 0x0001FCA3
		protected internal override void Execute(ActivityExecutionContext context)
		{
			base.Event.Abort(AbortReason.kAbort_Exit);
		}

		// Token: 0x0600140F RID: 5135 RVA: 0x00020CB1 File Offset: 0x0001FCB1
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
