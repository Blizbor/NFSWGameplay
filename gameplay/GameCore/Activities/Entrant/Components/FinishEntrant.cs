using System;
using System.Collections.Generic;
using GameCore.Workflow;
using Victory.DataLayer.Serialization.Event;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x0200017E RID: 382
	public class FinishEntrant : Component
	{
		// Token: 0x0600135B RID: 4955 RVA: 0x0001BFDC File Offset: 0x0001AFDC
		public FinishEntrant(InstancedEvent evnt, EntrantInfo entrant, FinishReason finishReason) : base(evnt, entrant)
		{
			this.finishReason = finishReason;
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x0001BFED File Offset: 0x0001AFED
		protected internal override void Execute(ActivityExecutionContext context)
		{
			base.Entrant.ScoringState.FinishReason = this.finishReason;
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x0001C005 File Offset: 0x0001B005
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x04000486 RID: 1158
		private readonly FinishReason finishReason;
	}
}
