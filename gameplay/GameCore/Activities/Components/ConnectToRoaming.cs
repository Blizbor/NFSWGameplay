using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x02000135 RID: 309
	public class ConnectToRoaming : WorkflowElement
	{
		// Token: 0x06001236 RID: 4662 RVA: 0x0001A48C File Offset: 0x0001948C
		protected internal override void Execute(ActivityExecutionContext context)
		{
			Net.ConnectToRoaming();
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x0001A493 File Offset: 0x00019493
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
