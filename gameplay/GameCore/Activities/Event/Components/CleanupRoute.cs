using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001B7 RID: 439
	public class CleanupRoute : Component<InstancedEvent>
	{
		// Token: 0x0600142A RID: 5162 RVA: 0x00020EBE File Offset: 0x0001FEBE
		public CleanupRoute(InstancedEvent @event) : base(@event)
		{
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x00020EC7 File Offset: 0x0001FEC7
		protected internal override void Execute(ActivityExecutionContext context)
		{
			base.Event.Route.Clear();
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x00020ED9 File Offset: 0x0001FED9
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
