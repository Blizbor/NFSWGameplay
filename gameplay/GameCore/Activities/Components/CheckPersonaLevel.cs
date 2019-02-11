using System;
using System.Collections.Generic;
using GameCore.Opponents;
using GameCore.Workflow;
using GameCore.Workflow.Activities;

namespace GameCore.Activities.Components
{
	// Token: 0x0200012E RID: 302
	public class CheckPersonaLevel : Bookmarked
	{
		// Token: 0x06001219 RID: 4633 RVA: 0x0001A27D File Offset: 0x0001927D
		public CheckPersonaLevel(uint minLevel, uint maxLevel)
		{
			this.minLevel = minLevel;
			this.maxLevel = maxLevel;
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x0001A294 File Offset: 0x00019294
		protected internal override void Execute(ActivityExecutionContext context)
		{
			base.Execute(context);
			LocalHumanOpponent localHumanOpponent = Engine.Get().OpponentManager().FindLocalOpponent();
			if (localHumanOpponent != null)
			{
				uint driverLevel = localHumanOpponent.DriverLevel;
				if (this.minLevel <= driverLevel && this.maxLevel >= driverLevel)
				{
					this.Close();
				}
			}
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x0001A2DA File Offset: 0x000192DA
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x0400041E RID: 1054
		private readonly uint minLevel;

		// Token: 0x0400041F RID: 1055
		private readonly uint maxLevel;
	}
}
