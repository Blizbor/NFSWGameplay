using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001CF RID: 463
	public class PrimeCopVehicleCache : Component<InstancedEvent>
	{
		// Token: 0x06001481 RID: 5249 RVA: 0x00022206 File Offset: 0x00021206
		public PrimeCopVehicleCache(InstancedEvent evnt, uint vehiclekey, int count) : base(evnt)
		{
			this.vehicleKey = vehiclekey;
			this.numVehicles = count;
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x0002221D File Offset: 0x0002121D
		protected internal override void Execute(ActivityExecutionContext context)
		{
			Cops.PrimeCopVehicleCache(this.vehicleKey, this.numVehicles);
		}

		// Token: 0x06001483 RID: 5251 RVA: 0x00022230 File Offset: 0x00021230
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x040004CF RID: 1231
		private readonly uint vehicleKey;

		// Token: 0x040004D0 RID: 1232
		private readonly int numVehicles;
	}
}
