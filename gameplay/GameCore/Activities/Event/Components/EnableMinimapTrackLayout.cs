using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001BE RID: 446
	public class EnableMinimapTrackLayout : Component<InstancedEvent>
	{
		// Token: 0x0600143B RID: 5179 RVA: 0x00021204 File Offset: 0x00020204
		public EnableMinimapTrackLayout(InstancedEvent @event, bool enable) : base(@event)
		{
			this.enable = enable;
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x00021214 File Offset: 0x00020214
		protected internal override void Execute(ActivityExecutionContext context)
		{
			Hud.EnableMinimapTrackLayout(this.enable);
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x00021221 File Offset: 0x00020221
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600143E RID: 5182 RVA: 0x00021223 File Offset: 0x00020223
		public bool Enable
		{
			get
			{
				return this.enable;
			}
		}

		// Token: 0x040004BF RID: 1215
		private readonly bool enable;
	}
}
