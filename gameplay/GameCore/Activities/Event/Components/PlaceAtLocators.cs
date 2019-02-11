using System;
using System.Collections.Generic;
using GameCore.Activities.Components;
using GameCore.Data;
using GameCore.Math;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001CB RID: 459
	public class PlaceAtLocators : Component<InstancedEvent>
	{
		// Token: 0x06001472 RID: 5234 RVA: 0x00021D56 File Offset: 0x00020D56
		public PlaceAtLocators(InstancedEvent evnt) : base(evnt)
		{
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x00021D6C File Offset: 0x00020D6C
		private void BuildWarpList()
		{
			foreach (EntrantInfo entrantInfo in base.Event.Entrants)
			{
				WarpTo warpTo = new WarpTo();
				uint num = base.Event.TrackLayoutDef.Num_SpawnLocation();
				if (num > 0u)
				{
					uint index = (uint)(entrantInfo.Opponent.GridIndex % (int)num);
					Collection collection = new Collection(base.Event.TrackLayoutDef.SpawnLocation(index));
					warpTo.Position = CoordSys.RenderToSim(collection.Position());
					warpTo.Direction = CoordSys.Vector3Make(collection.Rotation());
					warpTo.Vehicle = entrantInfo.Opponent.Vehicle;
					this.warpList.Add(warpTo);
				}
			}
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x00021E60 File Offset: 0x00020E60
		protected internal override void Execute(ActivityExecutionContext context)
		{
			this.warpList.ForEach(delegate(WarpTo warpTo)
			{
				context.ScheduleActivity(warpTo);
			});
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x00021EA8 File Offset: 0x00020EA8
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
			this.BuildWarpList();
			this.warpList.ForEach(delegate(WarpTo warpTo)
			{
				children.Add(warpTo);
			});
		}

		// Token: 0x040004CD RID: 1229
		private List<WarpTo> warpList = new List<WarpTo>();
	}
}
