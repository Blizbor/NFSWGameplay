using System;
using System.Collections.Generic;

namespace GameCore.Workflow.Activities
{
	// Token: 0x020001E2 RID: 482
	public class StateGraph : WorkflowElement
	{
		// Token: 0x060014C2 RID: 5314 RVA: 0x000242EE File Offset: 0x000232EE
		public StateGraph(string name)
		{
			this.name = name;
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x00024308 File Offset: 0x00023308
		protected internal virtual void BuildGraph()
		{
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x0002430C File Offset: 0x0002330C
		protected internal override void Execute(ActivityExecutionContext context)
		{
			State state = this.FindState(this.initialState);
			if (state == null)
			{
				return;
			}
			context.ScheduleActivity(state, new CompletionCallback(this.OnStateCompleted));
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x00024340 File Offset: 0x00023340
		protected void OnStateCompleted(ActivityExecutionContext context, WorkflowElement sender)
		{
			State state = sender as State;
			if (state != null && !string.IsNullOrEmpty(state.TransitionTo))
			{
				State state2 = this.FindState(state.TransitionTo);
				if (state2 != null)
				{
					state2.TransitionedFrom = state.Name;
					Console.WriteLine("CS: Stategraph {0} is transitioning from {1} to {2}", this.name, state.Name, state.TransitionTo);
					if (this.DoneState != state.TransitionTo)
					{
						context.ScheduleActivity(state2, new CompletionCallback(this.OnStateCompleted));
						return;
					}
					context.ScheduleActivity(state2.EnterActivity, new CompletionCallback(this.OnDoneCompleted));
				}
			}
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x000243DE File Offset: 0x000233DE
		protected void OnDoneCompleted(ActivityExecutionContext context, WorkflowElement sender)
		{
			Console.WriteLine("CS: Stategraph {0} is complete", this.name);
			context.CancelChildren();
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x0002440C File Offset: 0x0002340C
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
			this.BuildGraph();
			this.states.ForEach(delegate(State state)
			{
				children.Add(state);
			});
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x00024460 File Offset: 0x00023460
		private State FindState(string name)
		{
			return this.states.Find((State s) => s.Name == name);
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060014C9 RID: 5321 RVA: 0x00024491 File Offset: 0x00023491
		// (set) Token: 0x060014CA RID: 5322 RVA: 0x00024499 File Offset: 0x00023499
		public string InitialState
		{
			get
			{
				return this.initialState;
			}
			set
			{
				this.initialState = value;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060014CB RID: 5323 RVA: 0x000244A2 File Offset: 0x000234A2
		// (set) Token: 0x060014CC RID: 5324 RVA: 0x000244AA File Offset: 0x000234AA
		public string DoneState
		{
			get
			{
				return this.doneState;
			}
			set
			{
				this.doneState = value;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060014CD RID: 5325 RVA: 0x000244B3 File Offset: 0x000234B3
		public List<State> States
		{
			get
			{
				return this.states;
			}
		}

		// Token: 0x040004DC RID: 1244
		private List<State> states = new List<State>();

		// Token: 0x040004DD RID: 1245
		private string initialState;

		// Token: 0x040004DE RID: 1246
		private string doneState;

		// Token: 0x040004DF RID: 1247
		private readonly string name;
	}
}
