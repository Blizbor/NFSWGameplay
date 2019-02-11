using System;
using System.Collections.Generic;

namespace GameCore.Workflow.Activities
{
	// Token: 0x02000218 RID: 536
	public class SetSignal : WorkflowElement
	{
		// Token: 0x06001627 RID: 5671 RVA: 0x00026C3F File Offset: 0x00025C3F
		public SetSignal(string name)
		{
			this.signal = Signal.OpenExistingSignal(name);
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x00026C53 File Offset: 0x00025C53
		protected internal override void Execute(ActivityExecutionContext context)
		{
			this.signal.Set();
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x00026C60 File Offset: 0x00025C60
		protected internal override void Close()
		{
			base.Close();
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x00026C68 File Offset: 0x00025C68
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x04000547 RID: 1351
		private readonly Signal signal;
	}
}
