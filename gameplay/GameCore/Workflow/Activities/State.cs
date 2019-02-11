using System;
using System.Collections.Generic;

namespace GameCore.Workflow.Activities
{
	// Token: 0x02000219 RID: 537
	public class State : WorkflowElement
	{
		// Token: 0x0600162B RID: 5675 RVA: 0x00026C6A File Offset: 0x00025C6A
		public State(string name)
		{
			this.name = name;
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x00026C9A File Offset: 0x00025C9A
		protected internal override void Execute(ActivityExecutionContext context)
		{
			this.transitionTo = null;
			if (this.EnterActivity != null)
			{
				context.ScheduleActivity(this.EnterActivity, new CompletionCallback(this.ExecuteActivities));
				return;
			}
			this.ExecuteActivities(context, null);
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x00026CF4 File Offset: 0x00025CF4
		protected void ExecuteActivities(ActivityExecutionContext context, WorkflowElement sender)
		{
			if (this.transitions.Count != 0)
			{
				this.transitions.ForEach(delegate(Transition transition)
				{
					context.ScheduleActivity(transition, new CompletionCallback(this.OnTransition));
				});
				return;
			}
			context.CancelChildren();
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x00026D4C File Offset: 0x00025D4C
		protected void OnTransition(ActivityExecutionContext context, WorkflowElement sender)
		{
			Transition transition = sender as Transition;
			if (transition != null)
			{
				string text = transition.TransitionTo;
				if (transition is ReturnTransition)
				{
					text = this.transitionedFrom;
				}
				if (!string.IsNullOrEmpty(text) && string.IsNullOrEmpty(this.TransitionTo) && this.Name != text)
				{
					this.transitionTo = text;
					context.CancelChildren();
					if (this.ExitActivity != null)
					{
						context.ScheduleActivity(this.ExitActivity);
						return;
					}
				}
				else
				{
					Console.WriteLine("Trying to transition to {0}", transition.TransitionTo);
				}
			}
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x00026DE4 File Offset: 0x00025DE4
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
			if (this.EnterActivity != null)
			{
				children.Add(this.EnterActivity);
			}
			this.transitions.ForEach(delegate(Transition transition)
			{
				children.Add(transition);
			});
			if (this.ExitActivity != null)
			{
				children.Add(this.ExitActivity);
			}
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x00026E47 File Offset: 0x00025E47
		public override string ToString()
		{
			return string.Format("{0} : {1}", base.ToString(), this.Name);
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06001631 RID: 5681 RVA: 0x00026E5F File Offset: 0x00025E5F
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06001632 RID: 5682 RVA: 0x00026E67 File Offset: 0x00025E67
		public string TransitionTo
		{
			get
			{
				return this.transitionTo;
			}
		}

		// Token: 0x170001BE RID: 446
		// (set) Token: 0x06001633 RID: 5683 RVA: 0x00026E6F File Offset: 0x00025E6F
		public string TransitionedFrom
		{
			set
			{
				this.transitionedFrom = value;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06001634 RID: 5684 RVA: 0x00026E78 File Offset: 0x00025E78
		// (set) Token: 0x06001635 RID: 5685 RVA: 0x00026E80 File Offset: 0x00025E80
		public Sequence EnterActivity
		{
			get
			{
				return this.enterActivity;
			}
			set
			{
				this.enterActivity = value;
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06001636 RID: 5686 RVA: 0x00026E89 File Offset: 0x00025E89
		// (set) Token: 0x06001637 RID: 5687 RVA: 0x00026E91 File Offset: 0x00025E91
		public Sequence ExitActivity
		{
			get
			{
				return this.exitActivity;
			}
			set
			{
				this.exitActivity = value;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06001638 RID: 5688 RVA: 0x00026E9A File Offset: 0x00025E9A
		// (set) Token: 0x06001639 RID: 5689 RVA: 0x00026EA2 File Offset: 0x00025EA2
		public List<Transition> Transitions
		{
			get
			{
				return this.transitions;
			}
			set
			{
				this.transitions = value;
			}
		}

		// Token: 0x04000548 RID: 1352
		private List<Transition> transitions = new List<Transition>();

		// Token: 0x04000549 RID: 1353
		private Sequence enterActivity = new Sequence();

		// Token: 0x0400054A RID: 1354
		private Sequence exitActivity = new Sequence();

		// Token: 0x0400054B RID: 1355
		private readonly string name;

		// Token: 0x0400054C RID: 1356
		private string transitionTo;

		// Token: 0x0400054D RID: 1357
		private string transitionedFrom;
	}
}
