using System;
using System.Collections.Generic;
using GameCore.Opponents;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x02000172 RID: 370
	public class EnableGadget : Component
	{
		// Token: 0x06001330 RID: 4912 RVA: 0x0001BB02 File Offset: 0x0001AB02
		public EnableGadget(InstancedEvent @event, EntrantInfo entrant, string name, EnableGadget.GadgetToggle flags) : base(@event, entrant)
		{
			this.name = name;
			this.flags = flags;
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x0001BB1C File Offset: 0x0001AB1C
		protected internal override void Execute(ActivityExecutionContext context)
		{
			LocalHumanOpponent localHumanOpponent = base.Entrant.Opponent as LocalHumanOpponent;
			if (localHumanOpponent != null)
			{
				bool enable = (this.flags & EnableGadget.GadgetToggle.Enable) != (EnableGadget.GadgetToggle)0;
				Hud.EnableGadget(this.name, enable);
				if ((this.flags & EnableGadget.GadgetToggle.Dispose) != (EnableGadget.GadgetToggle)0)
				{
					Hud.DisposeGadget(this.name);
				}
			}
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x0001BB6D File Offset: 0x0001AB6D
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x04000475 RID: 1141
		private readonly string name;

		// Token: 0x04000476 RID: 1142
		private readonly EnableGadget.GadgetToggle flags;

		// Token: 0x02000173 RID: 371
		[Flags]
		public enum GadgetToggle
		{
			// Token: 0x04000478 RID: 1144
			Enable = 1,
			// Token: 0x04000479 RID: 1145
			Disable = 2,
			// Token: 0x0400047A RID: 1146
			Dispose = 6
		}
	}
}
