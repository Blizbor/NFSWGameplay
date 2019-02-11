using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001D2 RID: 466
	public class RemoveAllOpponentsExceptLocalPlayer : Component<InstancedEvent>
	{
		// Token: 0x0600148C RID: 5260 RVA: 0x000222E8 File Offset: 0x000212E8
		public RemoveAllOpponentsExceptLocalPlayer(InstancedEvent @event) : base(@event)
		{
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x000222F1 File Offset: 0x000212F1
		protected internal override void Execute(ActivityExecutionContext context)
		{
			base.Event.Manager.OpponentManager.RemoveAllOpponentsExceptLocalPlayer();
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x00022308 File Offset: 0x00021308
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
