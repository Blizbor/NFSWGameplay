using System;
using System.Collections.Generic;
using GameCore.Data;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001CD RID: 461
	public class PlaceRoute : Component<InstancedEvent>
	{
		// Token: 0x0600147A RID: 5242 RVA: 0x0002207F File Offset: 0x0002107F
		public PlaceRoute(InstancedEvent @event) : base(@event)
		{
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x00022088 File Offset: 0x00021088
		protected internal override void Execute(ActivityExecutionContext context)
		{
			uint num = base.Event.TrackLayoutDef.Num_Checkpoints();
			GCollectionKey collectionKey;
			for (uint num2 = 0u; num2 < num; num2 += 1u)
			{
				collectionKey = base.Event.TrackLayoutDef.Checkpoints(num2);
				base.Event.AddRoutePoint(new RoutePoint(new Collection(collectionKey)));
			}
			collectionKey = base.Event.TrackLayoutDef.FinishLine();
			base.Event.AddRoutePoint(new RoutePoint(new Collection(collectionKey)));
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x00022101 File Offset: 0x00021101
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
