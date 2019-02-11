using System;
using System.Collections.Generic;

namespace GameCore.Workflow.Activities
{
	// Token: 0x0200021A RID: 538
	public class UnSetSignal : WorkflowElement
	{
		// Token: 0x0600163A RID: 5690 RVA: 0x00026EAB File Offset: 0x00025EAB
		public UnSetSignal(string name)
		{
			this.signal = Signal.OpenExistingSignal(name);
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x00026EBF File Offset: 0x00025EBF
		protected internal override void Execute(ActivityExecutionContext context)
		{
			this.signal.UnSet();
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x00026ECC File Offset: 0x00025ECC
		protected internal override void Close()
		{
			base.Close();
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x00026ED4 File Offset: 0x00025ED4
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x0400054E RID: 1358
		private readonly Signal signal;
	}
}
