using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant
{
	// Token: 0x020001AC RID: 428
	public abstract class Bookmarked : Component
	{
		// Token: 0x06001407 RID: 5127 RVA: 0x00020C45 File Offset: 0x0001FC45
		public Bookmarked(InstancedEvent evnt, EntrantInfo entrant) : base(evnt, entrant)
		{
		}

		// Token: 0x06001408 RID: 5128 RVA: 0x00020C4F File Offset: 0x0001FC4F
		protected internal override void Execute(ActivityExecutionContext context)
		{
			this.bookmark = context.CreateNamedBookmark(null, null);
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x00020C5F File Offset: 0x0001FC5F
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x00020C61 File Offset: 0x0001FC61
		protected internal override void Close()
		{
			if (this.bookmark != null)
			{
				this.bookmark.Close();
				this.bookmark = null;
			}
			base.Close();
		}

		// Token: 0x040004B4 RID: 1204
		private Bookmark bookmark;
	}
}
