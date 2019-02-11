using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x02000159 RID: 345
	public class ResolveBarriers : WorkflowElement
	{
		// Token: 0x060012B3 RID: 4787 RVA: 0x0001ACD0 File Offset: 0x00019CD0
		protected internal override void Execute(ActivityExecutionContext context)
		{
			TrackLayout.ResolveBarriers();
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x0001ACD7 File Offset: 0x00019CD7
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
