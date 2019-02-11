using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x0200015A RID: 346
	public class RunAsyncEvent : WorkflowElement
	{
		// Token: 0x060012B6 RID: 4790 RVA: 0x0001ACE1 File Offset: 0x00019CE1
		public RunAsyncEvent(Manager manager)
		{
			this.manager = manager;
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x0001ACF0 File Offset: 0x00019CF0
		protected internal override void Execute(ActivityExecutionContext context)
		{
			if (this.EventKey != null)
			{
				this.bookmark = context.CreateNamedBookmark(null, new BookmarkCallback(this.OnResume), BookmarkOptions.MultiResume);
				this.evnt = this.manager.CreateAsyncEvent(this.eventKey.Value);
				Console.WriteLine("CS: Running Event Id : {0}", this.evnt.EventId);
				this.evnt.EventCompleted += this.Event_EventCompleted;
				this.evnt.Run();
			}
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x0001AD77 File Offset: 0x00019D77
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x0001AD79 File Offset: 0x00019D79
		private void OnResume(ActivityExecutionContext context, Bookmark bookmark, object target)
		{
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x0001AD7B File Offset: 0x00019D7B
		protected internal override void Close()
		{
			this.evnt.Dispose();
			this.bookmark.Close();
			this.bookmark = null;
			base.Close();
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x0001ADA0 File Offset: 0x00019DA0
		private void Event_EventCompleted(object sender, EventCompletedArgs e)
		{
			this.Close();
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060012BC RID: 4796 RVA: 0x0001ADA8 File Offset: 0x00019DA8
		// (set) Token: 0x060012BD RID: 4797 RVA: 0x0001ADB0 File Offset: 0x00019DB0
		public InArgument<uint> EventKey
		{
			get
			{
				return this.eventKey;
			}
			set
			{
				this.eventKey = value;
			}
		}

		// Token: 0x04000448 RID: 1096
		private Bookmark bookmark;

		// Token: 0x04000449 RID: 1097
		private readonly Manager manager;

		// Token: 0x0400044A RID: 1098
		private InArgument<uint> eventKey;

		// Token: 0x0400044B RID: 1099
		private Event evnt;
	}
}
