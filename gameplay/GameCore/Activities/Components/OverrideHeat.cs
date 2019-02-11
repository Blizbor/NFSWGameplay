using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x0200014D RID: 333
	public class OverrideHeat : WorkflowElement
	{
		// Token: 0x06001292 RID: 4754 RVA: 0x0001AB6D File Offset: 0x00019B6D
		public OverrideHeat(float heat)
		{
			this.heat = heat;
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x0001AB7C File Offset: 0x00019B7C
		protected internal override void Execute(ActivityExecutionContext context)
		{
			Cops.SetPursuitHeat(this.heat);
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x0001AB89 File Offset: 0x00019B89
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x04000441 RID: 1089
		private readonly float heat;
	}
}
