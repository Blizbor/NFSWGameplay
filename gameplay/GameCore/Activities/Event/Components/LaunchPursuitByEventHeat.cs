using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001C3 RID: 451
	public class LaunchPursuitByEventHeat : Component<Event>
	{
		// Token: 0x06001454 RID: 5204 RVA: 0x0002164C File Offset: 0x0002064C
		public LaunchPursuitByEventHeat(Event evnt) : base(evnt)
		{
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x00021655 File Offset: 0x00020655
		protected internal override void Execute(ActivityExecutionContext context)
		{
			Cops.LaunchPursuit(base.Event.EventDef.InitialHeat(), false);
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x0002166D File Offset: 0x0002066D
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
