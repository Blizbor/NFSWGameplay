using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001B2 RID: 434
	public class AddOpponents : Component<InstancedEvent>
	{
		// Token: 0x06001419 RID: 5145 RVA: 0x00020D3E File Offset: 0x0001FD3E
		public AddOpponents(InstancedEvent @event) : base(@event)
		{
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x00020D6E File Offset: 0x0001FD6E
		protected internal override void Execute(ActivityExecutionContext context)
		{
			base.Event.Manager.OpponentManager.Opponents.ForEach(delegate(Opponent opponent)
			{
				if (opponent.IsStatus(OpponentStatus.kOpponent_Queued))
				{
					Console.WriteLine("CS: Adding opponent {0} to event", opponent.OpponentName);
					base.Event.AddOpponent(opponent);
				}
			});
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x00020D96 File Offset: 0x0001FD96
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
