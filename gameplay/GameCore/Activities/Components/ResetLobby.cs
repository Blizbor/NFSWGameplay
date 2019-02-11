using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x02000157 RID: 343
	public class ResetLobby : WorkflowElement
	{
		// Token: 0x060012AD RID: 4781 RVA: 0x0001ACA9 File Offset: 0x00019CA9
		protected internal override void Execute(ActivityExecutionContext context)
		{
			InternalLobby.Get().Reset();
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x0001ACB5 File Offset: 0x00019CB5
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
