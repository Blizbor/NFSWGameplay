using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x0200012F RID: 303
	public class CheckTutorialComplete : BookmarkedActivity
	{
		// Token: 0x0600121C RID: 4636 RVA: 0x0001A2DC File Offset: 0x000192DC
		public CheckTutorialComplete(TutorialSource source, bool complete)
		{
			this.source = source;
			this.complete = complete;
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x0001A2F2 File Offset: 0x000192F2
		protected internal override void Execute(ActivityExecutionContext context)
		{
			base.Execute(context);
			if (Marshal.Get().IsTutorialComplete(this.source) == this.complete)
			{
				base.Close();
			}
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x0001A319 File Offset: 0x00019319
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x0001A31B File Offset: 0x0001931B
		public override string ToString()
		{
			return (this.complete ? "CheckTutorialComplete(" : "CheckTutorialIncomplete(") + this.source.ToString() + ")";
		}

		// Token: 0x04000420 RID: 1056
		private TutorialSource source;

		// Token: 0x04000421 RID: 1057
		private bool complete;
	}
}
