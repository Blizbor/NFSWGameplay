using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x02000171 RID: 369
	public class DisplayFlasher : Component
	{
		// Token: 0x0600132A RID: 4906 RVA: 0x0001BA78 File Offset: 0x0001AA78
		public DisplayFlasher(Event evnt, EntrantInfo entrant, FlasherBase flasher, bool waitForIntroComplete) : base(evnt, entrant)
		{
			this.flasher = flasher;
			this.waitForIntroComplete = waitForIntroComplete;
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x0001BA91 File Offset: 0x0001AA91
		public DisplayFlasher(Event evnt, EntrantInfo entrant, FlasherBase flasher) : this(evnt, entrant, flasher, false)
		{
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x0001BA9D File Offset: 0x0001AA9D
		protected internal override void Execute(ActivityExecutionContext context)
		{
			if (this.waitForIntroComplete)
			{
				this.bookmark = context.CreateNamedBookmark(null, null);
				this.flasher.FlasherIntroComplete += this.OnFlasherIntroCompleted;
			}
			FlasherManager.Get().EnqueueFlasher(this.flasher);
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x0001BADD File Offset: 0x0001AADD
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x0600132E RID: 4910 RVA: 0x0001BADF File Offset: 0x0001AADF
		private void OnFlasherIntroCompleted(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x0001BAE7 File Offset: 0x0001AAE7
		protected internal override void Close()
		{
			if (this.bookmark != null)
			{
				this.bookmark.Close();
			}
			base.Close();
		}

		// Token: 0x04000472 RID: 1138
		private readonly FlasherBase flasher;

		// Token: 0x04000473 RID: 1139
		private readonly bool waitForIntroComplete;

		// Token: 0x04000474 RID: 1140
		private Bookmark bookmark;
	}
}
