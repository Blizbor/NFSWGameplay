using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x02000155 RID: 341
	public class ResetBarriers : WorkflowElement
	{
		// Token: 0x060012A7 RID: 4775 RVA: 0x0001AC62 File Offset: 0x00019C62
		protected internal override void Execute(ActivityExecutionContext context)
		{
			TrackLayout.ResetBarriers();
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x0001AC69 File Offset: 0x00019C69
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
