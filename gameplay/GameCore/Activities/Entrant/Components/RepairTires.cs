using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x02000192 RID: 402
	public class RepairTires : Component
	{
		// Token: 0x0600139D RID: 5021 RVA: 0x0001C7AA File Offset: 0x0001B7AA
		public RepairTires(InstancedEvent evnt, EntrantInfo entrant, float time) : base(evnt, entrant)
		{
			this.time = time;
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x0001C7BB File Offset: 0x0001B7BB
		protected internal override void Execute(ActivityExecutionContext context)
		{
			base.Entrant.Opponent.Vehicle.RepairTires(this.time);
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x0001C7D8 File Offset: 0x0001B7D8
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x04000496 RID: 1174
		private readonly float time;
	}
}
