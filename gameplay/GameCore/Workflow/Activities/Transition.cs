using System;
using System.Collections.Generic;

namespace GameCore.Workflow.Activities
{
	// Token: 0x02000216 RID: 534
	public class Transition : WorkflowElement
	{
		// Token: 0x0600161E RID: 5662 RVA: 0x00026BC6 File Offset: 0x00025BC6
		public Transition(string transitionTo, WorkflowElement activity)
		{
			this.transitionTo = transitionTo;
			this.activity = activity;
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x00026BDC File Offset: 0x00025BDC
		public Transition(WorkflowElement activity) : this(null, activity)
		{
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x00026BE6 File Offset: 0x00025BE6
		public Transition(string transitionTo) : this(transitionTo, null)
		{
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x00026BF0 File Offset: 0x00025BF0
		protected internal override void Execute(ActivityExecutionContext context)
		{
			if (this.Activity != null)
			{
				context.ScheduleActivity(this.Activity);
			}
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x00026C06 File Offset: 0x00025C06
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
			if (this.Activity != null)
			{
				children.Add(this.Activity);
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06001623 RID: 5667 RVA: 0x00026C1C File Offset: 0x00025C1C
		// (set) Token: 0x06001624 RID: 5668 RVA: 0x00026C24 File Offset: 0x00025C24
		public WorkflowElement Activity
		{
			get
			{
				return this.activity;
			}
			set
			{
				this.activity = value;
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06001625 RID: 5669 RVA: 0x00026C2D File Offset: 0x00025C2D
		public string TransitionTo
		{
			get
			{
				return this.transitionTo;
			}
		}

		// Token: 0x04000545 RID: 1349
		private readonly string transitionTo;

		// Token: 0x04000546 RID: 1350
		private WorkflowElement activity;
	}
}
