using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001BC RID: 444
	public class EnableHud : Component<Event>
	{
		// Token: 0x06001438 RID: 5176 RVA: 0x00021181 File Offset: 0x00020181
		public EnableHud(Event evnt, EnableHud.HudToggle flags) : base(evnt)
		{
			this.flags = flags;
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x00021194 File Offset: 0x00020194
		protected internal override void Execute(ActivityExecutionContext context)
		{
			for (uint num = 0u; num < base.Event.EventDef.Num_Hud(); num += 1u)
			{
				bool enable = (this.flags & EnableHud.HudToggle.Enable) != (EnableHud.HudToggle)0;
				Hud.EnableGadget(base.Event.EventDef.Hud(num), enable);
				if ((this.flags & EnableHud.HudToggle.Dispose) != (EnableHud.HudToggle)0)
				{
					Hud.DisposeGadget(base.Event.EventDef.Hud(num));
				}
			}
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x00021202 File Offset: 0x00020202
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x040004BA RID: 1210
		private readonly EnableHud.HudToggle flags;

		// Token: 0x020001BD RID: 445
		[Flags]
		public enum HudToggle
		{
			// Token: 0x040004BC RID: 1212
			Enable = 1,
			// Token: 0x040004BD RID: 1213
			Disable = 2,
			// Token: 0x040004BE RID: 1214
			Dispose = 6
		}
	}
}
