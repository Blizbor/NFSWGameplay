using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x0200018F RID: 399
	public class ReleaseBehavior : Component
	{
		// Token: 0x06001394 RID: 5012 RVA: 0x0001C741 File Offset: 0x0001B741
		public ReleaseBehavior(InstancedEvent evnt, EntrantInfo entrant, string channel) : base(evnt, entrant)
		{
			this.channel = channel;
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x0001C752 File Offset: 0x0001B752
		protected internal override void Execute(ActivityExecutionContext context)
		{
			base.Entrant.Opponent.ReleaseBehavior(this.channel);
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x0001C76A File Offset: 0x0001B76A
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x04000494 RID: 1172
		private readonly string channel;
	}
}
