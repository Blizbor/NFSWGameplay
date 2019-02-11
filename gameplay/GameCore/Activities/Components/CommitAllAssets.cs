using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x02000134 RID: 308
	public class CommitAllAssets : WorkflowElement
	{
		// Token: 0x06001232 RID: 4658 RVA: 0x0001A46F File Offset: 0x0001946F
		protected internal override void Execute(ActivityExecutionContext context)
		{
			Vehicle.CommitRenderingAssets();
			Audio.CommitAssets();
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x0001A47B File Offset: 0x0001947B
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x0001A47D File Offset: 0x0001947D
		public override string ToString()
		{
			return "CommitAllAssets";
		}
	}
}
