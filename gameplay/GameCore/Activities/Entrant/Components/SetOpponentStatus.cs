using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x02000199 RID: 409
	public class SetOpponentStatus : Component
	{
		// Token: 0x060013BE RID: 5054 RVA: 0x0001CC47 File Offset: 0x0001BC47
		public SetOpponentStatus(InstancedEvent evnt, EntrantInfo entrant, OpponentStatus status, bool enable) : base(evnt, entrant)
		{
			this.status = status;
			this.enable = enable;
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x0001CC60 File Offset: 0x0001BC60
		protected internal override void Execute(ActivityExecutionContext context)
		{
			if (this.enable)
			{
				base.Entrant.Opponent.SetStatus(this.status);
				return;
			}
			base.Entrant.Opponent.ClearStatus(this.status);
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x0001CC97 File Offset: 0x0001BC97
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x0001CC99 File Offset: 0x0001BC99
		public override string ToString()
		{
			return string.Format("SetStatus: {0} - {1} {2}", base.Entrant, this.status, this.enable);
		}

		// Token: 0x0400049D RID: 1181
		private readonly OpponentStatus status;

		// Token: 0x0400049E RID: 1182
		private readonly bool enable;
	}
}
