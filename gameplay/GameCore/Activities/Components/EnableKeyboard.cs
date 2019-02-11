using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x02000139 RID: 313
	public class EnableKeyboard : WorkflowElement
	{
		// Token: 0x0600123E RID: 4670 RVA: 0x0001A4FB File Offset: 0x000194FB
		public EnableKeyboard(bool enable)
		{
			this.enable = enable;
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x0001A50A File Offset: 0x0001950A
		protected internal override void Execute(ActivityExecutionContext context)
		{
			Marshal.Get().EnableKeyboard(this.enable);
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x0001A51C File Offset: 0x0001951C
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x0001A520 File Offset: 0x00019520
		public override string ToString()
		{
			return "EnableKeyboard: " + this.enable.ToString();
		}

		// Token: 0x0400042C RID: 1068
		private readonly bool enable;
	}
}
