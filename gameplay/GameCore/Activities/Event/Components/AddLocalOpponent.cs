using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001B1 RID: 433
	public class AddLocalOpponent : Component<Event>
	{
		// Token: 0x06001416 RID: 5142 RVA: 0x00020D11 File Offset: 0x0001FD11
		public AddLocalOpponent(Event @event) : base(@event)
		{
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x00020D1A File Offset: 0x0001FD1A
		protected internal override void Execute(ActivityExecutionContext context)
		{
			base.Event.AddOpponent(base.Event.Manager.OpponentManager.FindLocalOpponent());
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x00020D3C File Offset: 0x0001FD3C
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
