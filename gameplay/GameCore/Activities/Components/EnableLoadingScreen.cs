using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x0200013A RID: 314
	public class EnableLoadingScreen : WorkflowElement
	{
		// Token: 0x06001242 RID: 4674 RVA: 0x0001A545 File Offset: 0x00019545
		public EnableLoadingScreen(bool enable)
		{
			this.enable = enable;
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x0001A554 File Offset: 0x00019554
		protected internal override void Execute(ActivityExecutionContext context)
		{
			LoadingMonitor.EnableLoadingScreen(this.enable);
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x0001A561 File Offset: 0x00019561
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x0400042D RID: 1069
		private readonly bool enable;
	}
}
