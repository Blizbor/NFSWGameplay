using System;
using System.Collections.Generic;

namespace GameCore.Workflow
{
	// Token: 0x020001A3 RID: 419
	public abstract class Activity : WorkflowElement
	{
		// Token: 0x060013EA RID: 5098 RVA: 0x0001D210 File Offset: 0x0001C210
		public Activity()
		{
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x0001D218 File Offset: 0x0001C218
		protected internal override void Execute(ActivityExecutionContext context)
		{
			context.ScheduleActivity(this.body, new CompletionCallback(this.OnCompletion));
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x0001D232 File Offset: 0x0001C232
		private void OnCompletion(ActivityExecutionContext context, object sender)
		{
			this.body = null;
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x0001D23B File Offset: 0x0001C23B
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
			this.body = this.CreateBody();
			children.Add(this.body);
		}

		// Token: 0x060013EE RID: 5102
		protected abstract WorkflowElement CreateBody();

		// Token: 0x040004A8 RID: 1192
		private WorkflowElement body;
	}
}
