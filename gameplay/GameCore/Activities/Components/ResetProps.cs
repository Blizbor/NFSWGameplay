using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x02000158 RID: 344
	public class ResetProps : WorkflowElement
	{
		// Token: 0x060012B0 RID: 4784 RVA: 0x0001ACBF File Offset: 0x00019CBF
		protected internal override void Execute(ActivityExecutionContext context)
		{
			World.ResetProps();
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x0001ACC6 File Offset: 0x00019CC6
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
