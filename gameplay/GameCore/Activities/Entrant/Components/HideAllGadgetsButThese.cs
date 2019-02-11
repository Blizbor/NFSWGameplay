using System;
using System.Collections.Generic;
using GameCore.Opponents;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x02000181 RID: 385
	public class HideAllGadgetsButThese : Component
	{
		// Token: 0x06001364 RID: 4964 RVA: 0x0001C0B6 File Offset: 0x0001B0B6
		public HideAllGadgetsButThese(InstancedEvent evnt, EntrantInfo entrant, params string[] args) : base(evnt, entrant)
		{
			this.gadgets = args;
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x0001C0C8 File Offset: 0x0001B0C8
		protected internal override void Execute(ActivityExecutionContext context)
		{
			LocalHumanOpponent localHumanOpponent = base.Entrant.Opponent as LocalHumanOpponent;
			if (localHumanOpponent != null)
			{
				localHumanOpponent.Hud.HideAllGadgets();
				foreach (string name in this.gadgets)
				{
					localHumanOpponent.Hud.HideGadget(name, false);
				}
			}
			base.Close();
		}

		// Token: 0x06001366 RID: 4966 RVA: 0x0001C120 File Offset: 0x0001B120
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x0400048B RID: 1163
		private readonly string[] gadgets;
	}
}
