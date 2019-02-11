using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001B6 RID: 438
	public class CleanupGrid : Component<InstancedEvent>
	{
		// Token: 0x06001426 RID: 5158 RVA: 0x00020E77 File Offset: 0x0001FE77
		public CleanupGrid(InstancedEvent evnt) : base(evnt)
		{
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x00020E8D File Offset: 0x0001FE8D
		protected internal override void Execute(ActivityExecutionContext context)
		{
			base.Event.Entrants.ForEach(delegate(EntrantInfo entrant)
			{
				entrant.Opponent.Cleanup();
			});
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x00020EBC File Offset: 0x0001FEBC
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
