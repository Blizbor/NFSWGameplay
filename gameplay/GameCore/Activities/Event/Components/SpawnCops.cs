using System;
using System.Collections.Generic;
using GameCore.Data;
using GameCore.Math;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001D7 RID: 471
	public class SpawnCops : Component<InstancedEvent>
	{
		// Token: 0x0600149D RID: 5277 RVA: 0x000226E0 File Offset: 0x000216E0
		public SpawnCops(InstancedEvent instancedEvent) : base(instancedEvent)
		{
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x000226EC File Offset: 0x000216EC
		protected internal override void Execute(ActivityExecutionContext context)
		{
			for (uint num = 0u; num < base.Event.EventDef.Num_SpawnLocation(); num += 1u)
			{
				Collection collection = new Collection(base.Event.EventDef.SpawnLocation(num));
				Vector3 position = CoordSys.RenderToSim(collection.Position());
				Vector3 direction = CoordSys.Vector3Make(collection.Rotation());
				Cops.SpawnCop(collection.VehicleKey().GetKey(), position, direction);
			}
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x00022755 File Offset: 0x00021755
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
