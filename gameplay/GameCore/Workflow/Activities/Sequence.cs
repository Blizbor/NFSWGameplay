using System;
using System.Collections.Generic;

namespace GameCore.Workflow.Activities
{
	// Token: 0x0200016E RID: 366
	public class Sequence : WorkflowElement
	{
		// Token: 0x0600131C RID: 4892 RVA: 0x0001B623 File Offset: 0x0001A623
		public Sequence()
		{
			this.activities = new List<WorkflowElement>();
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x0001B636 File Offset: 0x0001A636
		protected internal override void Execute(ActivityExecutionContext context)
		{
			this.index = 0;
			this.ExecuteSequence(context, null);
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x0001B648 File Offset: 0x0001A648
		private void ExecuteSequence(ActivityExecutionContext context, object sender)
		{
			if (this.index == this.activities.Count)
			{
				return;
			}
			context.ScheduleActivity(this.activities[this.index], new CompletionCallback(this.ExecuteSequence));
			this.index++;
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x0001B6B0 File Offset: 0x0001A6B0
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
			this.activities.ForEach(delegate(WorkflowElement element)
			{
				children.Add(element);
			});
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06001320 RID: 4896 RVA: 0x0001B6E1 File Offset: 0x0001A6E1
		// (set) Token: 0x06001321 RID: 4897 RVA: 0x0001B6E9 File Offset: 0x0001A6E9
		public List<WorkflowElement> Activities
		{
			get
			{
				return this.activities;
			}
			set
			{
				this.activities = value;
			}
		}

		// Token: 0x0400046C RID: 1132
		private List<WorkflowElement> activities;

		// Token: 0x0400046D RID: 1133
		private int index;
	}
}
