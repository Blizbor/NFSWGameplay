using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x02000180 RID: 384
	public class HardwareBlinkingEffectEntrant : Component
	{
		// Token: 0x06001361 RID: 4961 RVA: 0x0001C07A File Offset: 0x0001B07A
		public HardwareBlinkingEffectEntrant(InstancedEvent evnt, EntrantInfo entrant, uint color, float duration, float period) : base(evnt, entrant)
		{
			this.color = color;
			this.duration = duration;
			this.period = period;
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x0001C09B File Offset: 0x0001B09B
		protected internal override void Execute(ActivityExecutionContext context)
		{
			Hardware.BlinkEffect(this.color, this.duration, this.period);
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x0001C0B4 File Offset: 0x0001B0B4
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x04000488 RID: 1160
		private readonly uint color;

		// Token: 0x04000489 RID: 1161
		private readonly float duration;

		// Token: 0x0400048A RID: 1162
		private readonly float period;
	}
}
