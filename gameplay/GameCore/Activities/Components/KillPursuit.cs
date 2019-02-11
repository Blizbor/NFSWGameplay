using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x02000148 RID: 328
	public class KillPursuit : WorkflowElement
	{
		// Token: 0x0600127F RID: 4735 RVA: 0x0001AA42 File Offset: 0x00019A42
		protected internal override void Execute(ActivityExecutionContext context)
		{
			Cops.KillPursuit();
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x0001AA49 File Offset: 0x00019A49
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
