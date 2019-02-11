using System;
using System.Collections.Generic;

namespace GameCore.Workflow.Activities
{
	// Token: 0x02000215 RID: 533
	public class Parallel : WorkflowElement
	{
		// Token: 0x06001619 RID: 5657 RVA: 0x00026B12 File Offset: 0x00025B12
		public Parallel()
		{
			this.activities = new List<WorkflowElement>();
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x00026B3C File Offset: 0x00025B3C
		protected internal override void Execute(ActivityExecutionContext context)
		{
			this.activities.ForEach(delegate(WorkflowElement element)
			{
				context.ScheduleActivity(element);
			});
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x00026B84 File Offset: 0x00025B84
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
			this.activities.ForEach(delegate(WorkflowElement element)
			{
				children.Add(element);
			});
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600161C RID: 5660 RVA: 0x00026BB5 File Offset: 0x00025BB5
		// (set) Token: 0x0600161D RID: 5661 RVA: 0x00026BBD File Offset: 0x00025BBD
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

		// Token: 0x04000544 RID: 1348
		private List<WorkflowElement> activities;
	}
}
