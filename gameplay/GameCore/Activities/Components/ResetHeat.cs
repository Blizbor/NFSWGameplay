using System;
using System.Collections.Generic;
using GameCore.Opponents;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x02000156 RID: 342
	public class ResetHeat : WorkflowElement
	{
		// Token: 0x060012AA RID: 4778 RVA: 0x0001AC74 File Offset: 0x00019C74
		protected internal override void Execute(ActivityExecutionContext context)
		{
			LocalHumanOpponent localHumanOpponent = Engine.Get().OpponentManager().FindLocalOpponent();
			if (localHumanOpponent != null)
			{
				Cops.SetPursuitHeat(localHumanOpponent.Heat);
			}
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x0001AC9F File Offset: 0x00019C9F
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
