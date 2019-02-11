using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001B8 RID: 440
	public class CleanupTrackLayout : Component<InstancedEvent>
	{
		// Token: 0x0600142D RID: 5165 RVA: 0x00020EDB File Offset: 0x0001FEDB
		public CleanupTrackLayout(InstancedEvent @event) : base(@event)
		{
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x00020EE4 File Offset: 0x0001FEE4
		protected internal override void Execute(ActivityExecutionContext context)
		{
			base.Event.TrackLayout.Reset();
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x00020EF6 File Offset: 0x0001FEF6
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
