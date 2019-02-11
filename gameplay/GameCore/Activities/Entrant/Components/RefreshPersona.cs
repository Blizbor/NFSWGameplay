using System;
using System.Collections.Generic;
using GameCore.Opponents;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x0200018E RID: 398
	public class RefreshPersona : Component
	{
		// Token: 0x06001391 RID: 5009 RVA: 0x0001C70B File Offset: 0x0001B70B
		public RefreshPersona(Event @event, EntrantInfo entrant) : base(@event, entrant)
		{
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x0001C718 File Offset: 0x0001B718
		protected internal override void Execute(ActivityExecutionContext context)
		{
			LocalHumanOpponent localHumanOpponent = base.Entrant.Opponent as LocalHumanOpponent;
			if (localHumanOpponent != null)
			{
				localHumanOpponent.RefreshPersona();
			}
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x0001C73F File Offset: 0x0001B73F
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
