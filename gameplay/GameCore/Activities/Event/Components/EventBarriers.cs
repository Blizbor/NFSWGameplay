using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001BF RID: 447
	public class EventBarriers : Component<InstancedEvent>
	{
		// Token: 0x0600143F RID: 5183 RVA: 0x0002122B File Offset: 0x0002022B
		public EventBarriers(InstancedEvent evnt, bool enable) : base(evnt)
		{
			this.enable = enable;
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x0002123C File Offset: 0x0002023C
		protected internal override void Execute(ActivityExecutionContext context)
		{
			for (uint num = 0u; num < base.Event.TrackLayoutDef.Num_Barriers(); num += 1u)
			{
				IndexedBarrierName indexedBarrierName = base.Event.TrackLayoutDef.Barriers(num);
				string barrier = string.Format("BARRIER_SPLINE_{0}", (indexedBarrierName.mIndex < 0) ? (-indexedBarrierName.mIndex) : indexedBarrierName.mIndex);
				if (this.enable)
				{
					bool isFlipped = indexedBarrierName.mIndex < 0;
					World.EnableBarrier(barrier, isFlipped);
				}
				else
				{
					World.DisableBarrier(barrier);
				}
			}
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x000212BF File Offset: 0x000202BF
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x040004C0 RID: 1216
		private readonly bool enable;
	}
}
