using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x02000129 RID: 297
	public class BeginEventSecurity : WorkflowElement
	{
		// Token: 0x06001204 RID: 4612 RVA: 0x0001A12A File Offset: 0x0001912A
		protected internal override void Execute(ActivityExecutionContext context)
		{
			SecurityManager.EventReset();
			SecurityManager.CheckLoadedLibraries();
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x0001A136 File Offset: 0x00019136
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
