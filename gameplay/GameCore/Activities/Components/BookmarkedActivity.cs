using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x0200012A RID: 298
	public abstract class BookmarkedActivity : WorkflowElement
	{
		// Token: 0x06001207 RID: 4615 RVA: 0x0001A140 File Offset: 0x00019140
		public BookmarkedActivity()
		{
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x0001A148 File Offset: 0x00019148
		protected internal override void Execute(ActivityExecutionContext context)
		{
			this.bookmark = context.CreateNamedBookmark(null, null);
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x0001A158 File Offset: 0x00019158
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x0001A15A File Offset: 0x0001915A
		protected internal override void Close()
		{
			if (this.bookmark != null)
			{
				this.bookmark.Close();
				this.bookmark = null;
			}
			base.Close();
		}

		// Token: 0x04000418 RID: 1048
		private Bookmark bookmark;
	}
}
