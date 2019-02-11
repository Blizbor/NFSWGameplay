using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x02000153 RID: 339
	public class ReinitiatePursuit : WorkflowElement
	{
		// Token: 0x060012A1 RID: 4769 RVA: 0x0001AC36 File Offset: 0x00019C36
		protected internal override void Execute(ActivityExecutionContext context)
		{
			Cops.ReinitiatePursuit(false);
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x0001AC3E File Offset: 0x00019C3E
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
