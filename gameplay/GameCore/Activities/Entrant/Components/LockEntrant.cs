using System;
using System.Collections.Generic;
using GameCore.Activities.Components;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x02000187 RID: 391
	public class LockEntrant : Component
	{
		// Token: 0x06001377 RID: 4983 RVA: 0x0001C229 File Offset: 0x0001B229
		public LockEntrant(InstancedEvent @event, EntrantInfo entrant, bool locked) : base(@event, entrant)
		{
			this.locked = locked;
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x0001C23A File Offset: 0x0001B23A
		protected internal override void Execute(ActivityExecutionContext context)
		{
			context.ScheduleActivity(new LockVehicle(base.Entrant.Opponent.Vehicle, this.locked));
		}

		// Token: 0x06001379 RID: 4985 RVA: 0x0001C25D File Offset: 0x0001B25D
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x0001C25F File Offset: 0x0001B25F
		public override string ToString()
		{
			return string.Format("LockOpponent: {0} - {1}", base.Entrant, this.locked);
		}

		// Token: 0x0400048F RID: 1167
		private readonly bool locked;
	}
}
