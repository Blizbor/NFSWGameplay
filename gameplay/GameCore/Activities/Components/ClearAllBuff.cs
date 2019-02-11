using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x02000130 RID: 304
	public class ClearAllBuff : WorkflowElement
	{
		// Token: 0x06001220 RID: 4640 RVA: 0x0001A34B File Offset: 0x0001934B
		protected internal override void Execute(ActivityExecutionContext context)
		{
			Hud.ClearAllBuff();
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x0001A352 File Offset: 0x00019352
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
