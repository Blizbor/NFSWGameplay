using System;
using System.Collections.Generic;

namespace GameCore.Workflow.Activities
{
	// Token: 0x0200021B RID: 539
	public class WaitAll : WorkflowElement
	{
		// Token: 0x0600163E RID: 5694 RVA: 0x00026ED6 File Offset: 0x00025ED6
		public WaitAll(string name)
		{
			this.signal = Signal.OpenExistingSignal(name);
			this.signal.WaitAll += this.OnSignal;
			this.signalFired = false;
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x00026F08 File Offset: 0x00025F08
		~WaitAll()
		{
			this.signal.WaitAll -= this.OnSignal;
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x00026F48 File Offset: 0x00025F48
		protected internal override void Execute(ActivityExecutionContext context)
		{
			if (!this.signalFired)
			{
				this.bookmark = context.CreateNamedBookmark(null, new BookmarkCallback(this.OnResume), BookmarkOptions.MultiResume);
			}
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x00026F6C File Offset: 0x00025F6C
		protected internal override void Close()
		{
			this.signalFired = false;
			base.Close();
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x00026F7B File Offset: 0x00025F7B
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x00026F7D File Offset: 0x00025F7D
		private void OnResume(ActivityExecutionContext context, Bookmark bookmark, object target)
		{
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x00026F7F File Offset: 0x00025F7F
		private void OnSignal(Signal signal)
		{
			this.signalFired = true;
			if (this.bookmark != null)
			{
				this.bookmark.Close();
			}
		}

		// Token: 0x0400054F RID: 1359
		private readonly Signal signal;

		// Token: 0x04000550 RID: 1360
		private Bookmark bookmark;

		// Token: 0x04000551 RID: 1361
		private bool signalFired;
	}
}
