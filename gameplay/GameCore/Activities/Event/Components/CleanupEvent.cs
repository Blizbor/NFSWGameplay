using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001B5 RID: 437
	public class CleanupEvent : Component<InstancedEvent>
	{
		// Token: 0x06001423 RID: 5155 RVA: 0x00020E5F File Offset: 0x0001FE5F
		public CleanupEvent(InstancedEvent evnt) : base(evnt)
		{
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x00020E68 File Offset: 0x0001FE68
		protected internal override void Execute(ActivityExecutionContext context)
		{
			base.Event.Cleanup();
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x00020E75 File Offset: 0x0001FE75
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
