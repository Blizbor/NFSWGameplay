using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x0200014C RID: 332
	public class LockVehicle : WorkflowElement
	{
		// Token: 0x0600128E RID: 4750 RVA: 0x0001AB1D File Offset: 0x00019B1D
		public LockVehicle(Vehicle vehicle, bool locked)
		{
			this.vehicle = vehicle;
			this.locked = locked;
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x0001AB33 File Offset: 0x00019B33
		protected internal override void Execute(ActivityExecutionContext context)
		{
			this.vehicle.PinInPlace(this.locked);
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x0001AB46 File Offset: 0x00019B46
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x0001AB48 File Offset: 0x00019B48
		public override string ToString()
		{
			return "LockVehicle: " + this.locked.ToString();
		}

		// Token: 0x0400043F RID: 1087
		private readonly Vehicle vehicle;

		// Token: 0x04000440 RID: 1088
		private readonly bool locked;
	}
}
