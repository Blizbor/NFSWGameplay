using System;
using System.Collections.Generic;
using GameCore.Data;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001D0 RID: 464
	public class PrimeTrafficVehicleCache : Component<InstancedEvent>
	{
		// Token: 0x06001484 RID: 5252 RVA: 0x00022232 File Offset: 0x00021232
		public PrimeTrafficVehicleCache(InstancedEvent evnt, uint vehiclekey, int count) : base(evnt)
		{
			this.vehicleKey = vehiclekey;
			this.numVehicles = count;
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x00022249 File Offset: 0x00021249
		protected internal override void Execute(ActivityExecutionContext context)
		{
			this.ActivateReferencedVehicles();
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x00022251 File Offset: 0x00021251
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x00022254 File Offset: 0x00021254
		public virtual void ActivateReferencedVehicles()
		{
			InternalInstance referrer = InstanceCatalog.Get().Find(base.Event.EventKey);
			this.ActivateReferenced(referrer);
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x00022280 File Offset: 0x00021280
		public virtual void ActivateReferenced(InternalInstance referrer)
		{
			if (null != referrer)
			{
				uint connectionCount = referrer.GetConnectionCount();
				for (uint num = 0u; num < connectionCount; num += 1u)
				{
					InternalInstance connectionAt = referrer.GetConnectionAt(num);
					Collection collection = new Collection(connectionAt);
					if (collection.IsDerivedFrom(289837591u))
					{
						Traffic.PrimeTrafficVehicleCache(collection.VehicleKey().GetKey(), 1);
					}
				}
			}
		}

		// Token: 0x040004D1 RID: 1233
		private readonly uint vehicleKey;

		// Token: 0x040004D2 RID: 1234
		private readonly int numVehicles;
	}
}
