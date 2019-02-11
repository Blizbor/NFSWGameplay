using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x02000144 RID: 324
	public class FlushTraffic : WorkflowElement
	{
		// Token: 0x06001269 RID: 4713 RVA: 0x0001A885 File Offset: 0x00019885
		protected internal override void Execute(ActivityExecutionContext context)
		{
			Traffic.FlushAllTraffic();
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x0001A88C File Offset: 0x0001988C
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
