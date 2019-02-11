using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x02000152 RID: 338
	public class RefreshEvents : WorkflowElement
	{
		// Token: 0x0600129F RID: 4767 RVA: 0x0001AC23 File Offset: 0x00019C23
		protected internal override void Execute(ActivityExecutionContext context)
		{
			Engine.Get().EventRepository().RefreshEvents();
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x0001AC34 File Offset: 0x00019C34
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
