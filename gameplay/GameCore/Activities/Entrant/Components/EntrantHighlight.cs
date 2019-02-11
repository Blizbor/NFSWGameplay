using System;
using System.Collections.Generic;
using GameCore.Scoring;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x0200017B RID: 379
	public class EntrantHighlight : Component
	{
		// Token: 0x0600134F RID: 4943 RVA: 0x0001BE5E File Offset: 0x0001AE5E
		public EntrantHighlight(InstancedEvent evnt, EntrantInfo entrant, EntrantHighlight highlight) : base(evnt, entrant)
		{
			this.highlight = highlight;
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x0001BE70 File Offset: 0x0001AE70
		protected internal override void Execute(ActivityExecutionContext context)
		{
			TeamEscapeScoringState teamEscapeScoringState = base.Entrant.ScoringState as TeamEscapeScoringState;
			teamEscapeScoringState.Highlight = this.highlight;
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x0001BE9A File Offset: 0x0001AE9A
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x0001BE9C File Offset: 0x0001AE9C
		protected internal override void Close()
		{
			base.Close();
		}

		// Token: 0x04000482 RID: 1154
		private EntrantHighlight highlight;
	}
}
