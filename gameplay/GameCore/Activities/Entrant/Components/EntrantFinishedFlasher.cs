using System;
using System.Collections.Generic;
using GameCore.Workflow;
using Victory.DataLayer.Serialization.Event;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x0200017A RID: 378
	public class EntrantFinishedFlasher : Component
	{
		// Token: 0x0600134A RID: 4938 RVA: 0x0001BDBE File Offset: 0x0001ADBE
		public EntrantFinishedFlasher(InstancedEvent evnt, EntrantInfo entrant) : base(evnt, entrant)
		{
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x0001BDC8 File Offset: 0x0001ADC8
		protected internal override void Execute(ActivityExecutionContext context)
		{
			this.bookmark = context.CreateNamedBookmark(null, null);
			base.Entrant.ScoringState.FinishReasonChanged += this.ScoringState_FinishReasonChanged;
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x0001BDF4 File Offset: 0x0001ADF4
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x0001BDF6 File Offset: 0x0001ADF6
		private void ScoringState_FinishReasonChanged(object sender, EventArgs e)
		{
			if ((base.Entrant.ScoringState.FinishReason & FinishReason.CrossedFinish) == FinishReason.CrossedFinish)
			{
				FlasherManager.Get().EnqueueFlasher(new FormattedFlasher(754518868u, base.Entrant.ToString()));
			}
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x0001BE2F File Offset: 0x0001AE2F
		protected internal override void Close()
		{
			base.Entrant.ScoringState.FinishReasonChanged -= this.ScoringState_FinishReasonChanged;
			this.bookmark.Close();
			base.Close();
		}

		// Token: 0x04000481 RID: 1153
		private Bookmark bookmark;
	}
}
