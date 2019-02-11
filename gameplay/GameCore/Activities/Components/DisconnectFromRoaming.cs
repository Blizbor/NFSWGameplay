using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x02000136 RID: 310
	public class DisconnectFromRoaming : WorkflowElement
	{
		// Token: 0x06001239 RID: 4665 RVA: 0x0001A49D File Offset: 0x0001949D
		protected internal override void Execute(ActivityExecutionContext context)
		{
			Net.DisconnectFromRoaming();
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x0001A4A4 File Offset: 0x000194A4
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
