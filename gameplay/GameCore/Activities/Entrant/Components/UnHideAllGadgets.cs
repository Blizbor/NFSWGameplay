using System;
using System.Collections.Generic;
using GameCore.Opponents;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x0200019C RID: 412
	public class UnHideAllGadgets : Component
	{
		// Token: 0x060013C8 RID: 5064 RVA: 0x0001CE15 File Offset: 0x0001BE15
		public UnHideAllGadgets(InstancedEvent evnt, EntrantInfo entrant) : base(evnt, entrant)
		{
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x0001CE20 File Offset: 0x0001BE20
		protected internal override void Execute(ActivityExecutionContext context)
		{
			LocalHumanOpponent localHumanOpponent = base.Entrant.Opponent as LocalHumanOpponent;
			if (localHumanOpponent != null)
			{
				localHumanOpponent.Hud.UnHideAllGadgets();
			}
			base.Close();
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x0001CE52 File Offset: 0x0001BE52
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
