using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x02000126 RID: 294
	public class AcceptInvite : WorkflowElement
	{
		// Token: 0x060011FB RID: 4603 RVA: 0x0001A0B6 File Offset: 0x000190B6
		protected internal override void Execute(ActivityExecutionContext context)
		{
			InternalLobby.Get().AcceptInvite();
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x0001A0C3 File Offset: 0x000190C3
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
