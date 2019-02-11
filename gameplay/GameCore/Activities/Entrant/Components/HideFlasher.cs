using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x02000182 RID: 386
	public class HideFlasher : Component
	{
		// Token: 0x06001367 RID: 4967 RVA: 0x0001C122 File Offset: 0x0001B122
		public HideFlasher(Event evnt, EntrantInfo entrant, FlasherBase flasher) : base(evnt, entrant)
		{
			this.flasher = flasher;
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x0001C133 File Offset: 0x0001B133
		protected internal override void Execute(ActivityExecutionContext context)
		{
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x0001C135 File Offset: 0x0001B135
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x0001C137 File Offset: 0x0001B137
		protected internal override void Close()
		{
			FlasherManager.Get().DequeueFlasher(this.flasher.Id);
			base.Close();
		}

		// Token: 0x0400048C RID: 1164
		private readonly FlasherBase flasher;
	}
}
