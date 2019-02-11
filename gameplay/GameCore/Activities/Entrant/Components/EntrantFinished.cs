using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x02000179 RID: 377
	public class EntrantFinished : Component
	{
		// Token: 0x06001344 RID: 4932 RVA: 0x0001BCF2 File Offset: 0x0001ACF2
		public EntrantFinished(Event evnt, EntrantInfo entrant, int finishReason) : base(evnt, entrant)
		{
			this.finishReason = finishReason;
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x0001BD04 File Offset: 0x0001AD04
		protected internal override void Execute(ActivityExecutionContext context)
		{
			base.Entrant.ScoringState.FinishReasonChanged += this.ScoringState_FinishReasonChanged;
			if (!this.IsFinishReason((int)base.Entrant.ScoringState.FinishReason))
			{
				this.bookmark = context.CreateNamedBookmark(null, null);
			}
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x0001BD53 File Offset: 0x0001AD53
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x0001BD55 File Offset: 0x0001AD55
		private void ScoringState_FinishReasonChanged(object sender, EventArgs e)
		{
			if (this.IsFinishReason((int)base.Entrant.ScoringState.FinishReason))
			{
				this.Close();
			}
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x0001BD75 File Offset: 0x0001AD75
		private bool IsFinishReason(int reason)
		{
			return reason != 0 && (this.finishReason & reason) == reason;
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x0001BD87 File Offset: 0x0001AD87
		protected internal override void Close()
		{
			base.Entrant.ScoringState.FinishReasonChanged -= this.ScoringState_FinishReasonChanged;
			if (this.bookmark != null)
			{
				this.bookmark.Close();
			}
			base.Close();
		}

		// Token: 0x0400047F RID: 1151
		private Bookmark bookmark;

		// Token: 0x04000480 RID: 1152
		private readonly int finishReason;
	}
}
