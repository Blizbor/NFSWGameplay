using System;
using System.Collections.Generic;

namespace GameCore.Workflow.Activities
{
	// Token: 0x02000214 RID: 532
	public class Loop : WorkflowElement
	{
		// Token: 0x06001613 RID: 5651 RVA: 0x00026A3A File Offset: 0x00025A3A
		public Loop()
		{
			this.activities = new List<WorkflowElement>();
		}

		// Token: 0x06001614 RID: 5652 RVA: 0x00026A4D File Offset: 0x00025A4D
		protected internal override void Execute(ActivityExecutionContext context)
		{
			this.index = 0;
			this.ExecuteSequence(context, null);
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x00026A60 File Offset: 0x00025A60
		private void ExecuteSequence(ActivityExecutionContext context, object sender)
		{
			if (this.index == this.activities.Count)
			{
				this.index = 0;
			}
			context.ScheduleActivity(this.activities[this.index], new CompletionCallback(this.ExecuteSequence));
			this.index++;
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x00026AD0 File Offset: 0x00025AD0
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
			this.activities.ForEach(delegate(WorkflowElement element)
			{
				children.Add(element);
			});
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06001617 RID: 5655 RVA: 0x00026B01 File Offset: 0x00025B01
		// (set) Token: 0x06001618 RID: 5656 RVA: 0x00026B09 File Offset: 0x00025B09
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

		// Token: 0x04000542 RID: 1346
		private List<WorkflowElement> activities;

		// Token: 0x04000543 RID: 1347
		private int index;
	}
}
