using System;
using System.Collections.Generic;
using GameCore.Activities.Components;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001CC RID: 460
	public class PlaceGrid : Component<InstancedEvent>
	{
		// Token: 0x06001476 RID: 5238 RVA: 0x00021EDF File Offset: 0x00020EDF
		public PlaceGrid(InstancedEvent @event) : base(@event)
		{
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x00021EF4 File Offset: 0x00020EF4
		private void BuildWarpList()
		{
			uint collectionKey = base.Event.TrackLayoutDef.StartGrid().GetCollectionKey();
			Grid grid = new Grid(collectionKey);
			foreach (EntrantInfo entrantInfo in base.Event.Entrants)
			{
				Location location = new Location();
				WarpTo warpTo = new WarpTo();
				grid.GetLocation(entrantInfo.Opponent.GridIndex, location);
				warpTo.Position = location.GetPosition();
				warpTo.Direction = location.GetDirection();
				warpTo.Vehicle = entrantInfo.Opponent.Vehicle;
				Console.WriteLine("Placing {0} in grid index {1}", entrantInfo.Opponent.OpponentName, entrantInfo.Opponent.GridIndex);
				this.warpList.Add(warpTo);
			}
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x00022000 File Offset: 0x00021000
		protected internal override void Execute(ActivityExecutionContext context)
		{
			this.warpList.ForEach(delegate(WarpTo warpTo)
			{
				context.ScheduleActivity(warpTo);
			});
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x00022048 File Offset: 0x00021048
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
			this.BuildWarpList();
			this.warpList.ForEach(delegate(WarpTo warpTo)
			{
				children.Add(warpTo);
			});
		}

		// Token: 0x040004CE RID: 1230
		private List<WarpTo> warpList = new List<WarpTo>();
	}
}
