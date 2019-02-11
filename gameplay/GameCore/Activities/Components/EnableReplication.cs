using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x0200013D RID: 317
	public class EnableReplication : WorkflowElement
	{
		// Token: 0x0600124B RID: 4683 RVA: 0x0001A5CE File Offset: 0x000195CE
		public EnableReplication(Vehicle vehicle, bool enable)
		{
			this.vehicle = vehicle;
			this.enable = enable;
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x0001A5E4 File Offset: 0x000195E4
		protected internal override void Execute(ActivityExecutionContext context)
		{
			this.vehicle.SetReplicationEnable(this.enable);
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x0001A5F7 File Offset: 0x000195F7
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x04000431 RID: 1073
		private readonly Vehicle vehicle;

		// Token: 0x04000432 RID: 1074
		private readonly bool enable;
	}
}
