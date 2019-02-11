using System;
using System.Collections.Generic;
using GameCore.Timers;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x0200015F RID: 351
	public class Timer : WorkflowElement
	{
		// Token: 0x060012DD RID: 4829 RVA: 0x0001B074 File Offset: 0x0001A074
		public Timer(InArgument<float> interval)
		{
			this.interval = interval;
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x0001B084 File Offset: 0x0001A084
		protected internal override void Execute(ActivityExecutionContext context)
		{
			this.bookmark = context.CreateNamedBookmark(null, new BookmarkCallback(this.OnResume), BookmarkOptions.MultiResume);
			this.timer = new Timer(this.interval.Value);
			this.timer.Elapsed += this.OnElapsed;
			this.timer.Reset();
			this.timer.Interval = this.interval.Value;
			this.timer.Start();
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x0001B104 File Offset: 0x0001A104
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x0001B106 File Offset: 0x0001A106
		private void OnResume(ActivityExecutionContext context, Bookmark bookmark, object target)
		{
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x0001B108 File Offset: 0x0001A108
		private void OnElapsed(object sender, EventArgs args)
		{
			this.timer.Stop();
			this.Close();
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x0001B11C File Offset: 0x0001A11C
		protected internal override void Close()
		{
			if (this.bookmark != null)
			{
				this.bookmark.Close();
			}
			this.bookmark = null;
			if (this.timer != null)
			{
				this.timer.Elapsed -= this.OnElapsed;
				this.timer.Dispose();
			}
			this.timer = null;
			base.Close();
		}

		// Token: 0x04000457 RID: 1111
		private Bookmark bookmark;

		// Token: 0x04000458 RID: 1112
		private Timer timer;

		// Token: 0x04000459 RID: 1113
		private InArgument<float> interval;
	}
}
