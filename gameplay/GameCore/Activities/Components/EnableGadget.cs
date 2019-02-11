using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x02000137 RID: 311
	public class EnableGadget : WorkflowElement
	{
		// Token: 0x0600123B RID: 4667 RVA: 0x0001A4A6 File Offset: 0x000194A6
		public EnableGadget(string gadgetName, EnableGadget.HudToggle flags)
		{
			this.gadgetName = gadgetName;
			this.flags = flags;
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x0001A4BC File Offset: 0x000194BC
		protected internal override void Execute(ActivityExecutionContext context)
		{
			bool enable = (this.flags & EnableGadget.HudToggle.Enable) != (EnableGadget.HudToggle)0;
			Hud.EnableGadget(this.gadgetName, enable);
			if ((this.flags & EnableGadget.HudToggle.Dispose) != (EnableGadget.HudToggle)0)
			{
				Hud.DisposeGadget(this.gadgetName);
			}
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x0001A4F9 File Offset: 0x000194F9
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x04000426 RID: 1062
		private readonly string gadgetName;

		// Token: 0x04000427 RID: 1063
		private readonly EnableGadget.HudToggle flags;

		// Token: 0x02000138 RID: 312
		[Flags]
		public enum HudToggle
		{
			// Token: 0x04000429 RID: 1065
			Enable = 1,
			// Token: 0x0400042A RID: 1066
			Disable = 2,
			// Token: 0x0400042B RID: 1067
			Dispose = 6
		}
	}
}
