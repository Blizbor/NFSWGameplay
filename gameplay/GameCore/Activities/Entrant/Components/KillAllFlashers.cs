using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x02000183 RID: 387
	public class KillAllFlashers : Component
	{
		// Token: 0x0600136B RID: 4971 RVA: 0x0001C154 File Offset: 0x0001B154
		public KillAllFlashers(Event evnt, EntrantInfo entrant) : base(evnt, entrant)
		{
		}

		// Token: 0x0600136C RID: 4972 RVA: 0x0001C15E File Offset: 0x0001B15E
		protected internal override void Execute(ActivityExecutionContext context)
		{
			FlasherManager.Get().KillAllFlashers();
		}

		// Token: 0x0600136D RID: 4973 RVA: 0x0001C16A File Offset: 0x0001B16A
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
