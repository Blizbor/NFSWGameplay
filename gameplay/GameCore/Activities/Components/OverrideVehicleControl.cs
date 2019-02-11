using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x0200014E RID: 334
	public class OverrideVehicleControl : WorkflowElement
	{
		// Token: 0x06001295 RID: 4757 RVA: 0x0001AB8B File Offset: 0x00019B8B
		public OverrideVehicleControl(Vehicle vehicle, OverrideVehicleControl.Control control)
		{
			this.vehicle = vehicle;
			this.control = control;
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x0001ABA4 File Offset: 0x00019BA4
		protected internal override void Execute(ActivityExecutionContext context)
		{
			switch (this.control)
			{
			case OverrideVehicleControl.Control.Coast:
				this.vehicle.ForceCoast();
				return;
			case OverrideVehicleControl.Control.Stop:
				this.vehicle.ForceStop();
				return;
			case OverrideVehicleControl.Control.Release:
				this.vehicle.ReleaseControlOverride();
				return;
			default:
				return;
			}
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x0001ABEE File Offset: 0x00019BEE
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x04000442 RID: 1090
		private readonly Vehicle vehicle;

		// Token: 0x04000443 RID: 1091
		private readonly OverrideVehicleControl.Control control;

		// Token: 0x0200014F RID: 335
		public enum Control
		{
			// Token: 0x04000445 RID: 1093
			Coast,
			// Token: 0x04000446 RID: 1094
			Stop,
			// Token: 0x04000447 RID: 1095
			Release
		}
	}
}
