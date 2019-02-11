using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x02000191 RID: 401
	public class RemoveFlasher : Component
	{
		// Token: 0x0600139A RID: 5018 RVA: 0x0001C77A File Offset: 0x0001B77A
		public RemoveFlasher(Event evnt, EntrantInfo entrant, FlasherBase flasher) : base(evnt, entrant)
		{
			this.flasher = flasher;
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x0001C78B File Offset: 0x0001B78B
		protected internal override void Execute(ActivityExecutionContext context)
		{
			FlasherManager.Get().KillFlasher(this.flasher.Id);
			this.Close();
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x0001C7A8 File Offset: 0x0001B7A8
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x04000495 RID: 1173
		private readonly FlasherBase flasher;
	}
}
