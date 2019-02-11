using System;
using System.Collections.Generic;
using GameCore.Activities.Entrant;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001D3 RID: 467
	public class Running<T> : Component<Event> where T : GameCore.Activities.Entrant.Activity, new()
	{
		// Token: 0x0600148F RID: 5263 RVA: 0x0002230A File Offset: 0x0002130A
		public Running(Event evnt, params string[] signalNames) : base(evnt)
		{
			this.signalNames = signalNames;
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x00022330 File Offset: 0x00021330
		private void BuildEntrantList()
		{
			foreach (EntrantInfo entrant in base.Event.Entrants)
			{
				T item = Activator.CreateInstance<T>();
				item.Event = base.Event;
				item.Entrant = entrant;
				this.entrants.Add(item);
			}
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x000223D0 File Offset: 0x000213D0
		protected internal override void Execute(ActivityExecutionContext context)
		{
			if (this.signalNames != null)
			{
				foreach (string name in this.signalNames)
				{
					this.signals.Add(Signal.CreateNamedSignal(name));
				}
			}
			this.entrants.ForEach(delegate(T entrant)
			{
				context.ScheduleActivity(entrant);
			});
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x00022450 File Offset: 0x00021450
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
			this.BuildEntrantList();
			this.entrants.ForEach(delegate(T entrant)
			{
				children.Add(entrant);
			});
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x00022488 File Offset: 0x00021488
		protected internal override void Close()
		{
			foreach (Signal signal in this.signals)
			{
				signal.Release();
			}
			base.Close();
		}

		// Token: 0x040004D3 RID: 1235
		private List<T> entrants = new List<T>();

		// Token: 0x040004D4 RID: 1236
		private List<Signal> signals = new List<Signal>();

		// Token: 0x040004D5 RID: 1237
		private string[] signalNames;
	}
}
