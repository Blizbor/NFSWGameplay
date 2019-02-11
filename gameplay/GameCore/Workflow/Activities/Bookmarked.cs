using System;

namespace GameCore.Workflow.Activities
{
	// Token: 0x0200012D RID: 301
	public abstract class Bookmarked : WorkflowElement
	{
		// Token: 0x06001216 RID: 4630 RVA: 0x0001A243 File Offset: 0x00019243
		public Bookmarked()
		{
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x0001A24B File Offset: 0x0001924B
		protected internal override void Execute(ActivityExecutionContext context)
		{
			this.bookmark = context.CreateNamedBookmark(null, null);
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x0001A25B File Offset: 0x0001925B
		protected internal override void Close()
		{
			if (this.bookmark != null)
			{
				this.bookmark.Close();
				this.bookmark = null;
			}
			base.Close();
		}

		// Token: 0x0400041D RID: 1053
		private Bookmark bookmark;
	}
}
