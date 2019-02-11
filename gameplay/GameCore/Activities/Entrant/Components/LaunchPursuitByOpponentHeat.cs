using System;
using System.Collections.Generic;
using GameCore.Opponents;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x02000185 RID: 389
	public class LaunchPursuitByOpponentHeat : Component
	{
		// Token: 0x06001371 RID: 4977 RVA: 0x0001C1AD File Offset: 0x0001B1AD
		public LaunchPursuitByOpponentHeat(InstancedEvent evnt, EntrantInfo entrant) : base(evnt, entrant)
		{
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x0001C1B8 File Offset: 0x0001B1B8
		protected internal override void Execute(ActivityExecutionContext context)
		{
			if (Cops.IsPursuitActive())
			{
				return;
			}
			LocalHumanOpponent localHumanOpponent = base.Entrant.Opponent as LocalHumanOpponent;
			if (localHumanOpponent != null)
			{
				Cops.LaunchPursuit((int)localHumanOpponent.Heat, true);
			}
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x0001C1EE File Offset: 0x0001B1EE
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
