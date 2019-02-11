using System;

namespace GameCore.Workflow
{
	// Token: 0x0200021D RID: 541
	public class Bookmark : IDependency
	{
		// Token: 0x06001664 RID: 5732 RVA: 0x0002762B File Offset: 0x0002662B
		public Bookmark(string name, BookmarkCallback bookmarkCallback, BookmarkOptions options, ActivityExecutionContext context)
		{
			this.name = name;
			this.bookmarkCallback = bookmarkCallback;
			this.options = options;
			this.context = context;
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x00027650 File Offset: 0x00026650
		public void Resume(object target)
		{
			if (this.bookmarkCallback != null)
			{
				this.bookmarkCallback(this.context, this, target);
			}
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x0002766D File Offset: 0x0002666D
		public void Close()
		{
			this.context = null;
			this.bookmarkCallback = null;
			this.OnClosed();
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x00027683 File Offset: 0x00026683
		protected virtual void OnClosed()
		{
			if (this.Closed != null)
			{
				this.Closed(this);
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06001668 RID: 5736 RVA: 0x00027699 File Offset: 0x00026699
		// (remove) Token: 0x06001669 RID: 5737 RVA: 0x000276B2 File Offset: 0x000266B2
		public event BookmarkClosedHandler Closed;

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x0600166A RID: 5738 RVA: 0x000276CB File Offset: 0x000266CB
		public bool IsMultiResume
		{
			get
			{
				return this.options == BookmarkOptions.MultiResume;
			}
		}

		// Token: 0x0400055C RID: 1372
		private readonly string name;

		// Token: 0x0400055D RID: 1373
		private readonly BookmarkOptions options;

		// Token: 0x0400055E RID: 1374
		private BookmarkCallback bookmarkCallback;

		// Token: 0x0400055F RID: 1375
		private ActivityExecutionContext context;
	}
}
