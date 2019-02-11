using System;
using System.Collections.Generic;
using GameCore.Data;
using GameCore.Math;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001C0 RID: 448
	public class FinalizeTrackLayout : Component<InstancedEvent>
	{
		// Token: 0x06001442 RID: 5186 RVA: 0x000212C1 File Offset: 0x000202C1
		public FinalizeTrackLayout(InstancedEvent @event) : base(@event)
		{
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x000212CC File Offset: 0x000202CC
		protected internal override void Execute(ActivityExecutionContext context)
		{
			Collection trackLayoutDef = base.Event.TrackLayoutDef;
			uint num = trackLayoutDef.Num_Checkpoints();
			uint num2 = trackLayoutDef.Num_Shortcuts();
			int laps = base.Event.EventDef.NumLaps();
			TrackLayoutData trackLayoutData = new TrackLayoutData(num, num2, laps);
			Collection collection = new Collection(trackLayoutDef.StartGrid());
			trackLayoutData.AddPathPoint(0u, CoordSys.RenderToSim(collection.Position()), CoordSys.Vector3Make(collection.Rotation()));
			for (uint num3 = 0u; num3 < num; num3 += 1u)
			{
				Collection collection2 = new Collection(trackLayoutDef.Checkpoints(num3));
				trackLayoutData.AddPathPoint(num3 + 1u, CoordSys.RenderToSim(collection2.Position()), CoordSys.Vector3Make(collection2.Rotation()));
			}
			Collection collection3 = new Collection(trackLayoutDef.FinishLine());
			trackLayoutData.AddPathPoint(num + 1u, CoordSys.RenderToSim(collection3.Position()), CoordSys.Vector3Make(collection3.Rotation()));
			for (uint num4 = 0u; num4 < num2; num4 += 1u)
			{
				Collection collection4 = new Collection(trackLayoutDef.Shortcuts(num4));
				trackLayoutData.AddAlternatePoint(num4, CoordSys.RenderToSim(collection4.Position()), CoordSys.Vector3Make(collection4.Rotation()));
			}
			base.Event.TrackLayout.Resolve(trackLayoutData, false, -1, false);
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x00021402 File Offset: 0x00020402
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
