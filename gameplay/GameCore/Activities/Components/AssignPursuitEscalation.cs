using System;
using System.Collections.Generic;
using GameCore.Opponents;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x02000128 RID: 296
	public class AssignPursuitEscalation : WorkflowElement
	{
		// Token: 0x06001201 RID: 4609 RVA: 0x0001A0EB File Offset: 0x000190EB
		public AssignPursuitEscalation(uint key)
		{
			this.key = key;
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x0001A0FC File Offset: 0x000190FC
		protected internal override void Execute(ActivityExecutionContext context)
		{
			LocalHumanOpponent localHumanOpponent = Engine.Get().OpponentManager().FindLocalOpponent();
			if (localHumanOpponent != null)
			{
				localHumanOpponent.AssignPursuitEscalation(this.key);
			}
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x0001A128 File Offset: 0x00019128
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x04000417 RID: 1047
		private readonly uint key;
	}
}
