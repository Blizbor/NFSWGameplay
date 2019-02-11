using System;
using System.Collections.Generic;

namespace GameCore.Workflow
{
	// Token: 0x02000125 RID: 293
	public abstract class WorkflowElement : IDependency
	{
		// Token: 0x060011F6 RID: 4598
		protected internal abstract void Execute(ActivityExecutionContext context);

		// Token: 0x060011F7 RID: 4599
		protected internal abstract void OnGetChildren(IList<WorkflowElement> children);

		// Token: 0x060011F8 RID: 4600 RVA: 0x0001A08F File Offset: 0x0001908F
		protected internal virtual void Close()
		{
			Console.WriteLine("CS: Closing activity {0}", this.ToString());
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x0001A0A1 File Offset: 0x000190A1
		public override string ToString()
		{
			return base.GetType().ToString();
		}
	}
}
