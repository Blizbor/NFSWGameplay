using System;
using System.Collections.Generic;

namespace GameCore.Workflow.Activities
{
	// Token: 0x02000132 RID: 306
	public abstract class MessageHandler<M> : WorkflowElement where M : Message
	{
		// Token: 0x06001226 RID: 4646 RVA: 0x0001A3C4 File Offset: 0x000193C4
		public MessageHandler(uint port)
		{
			this.port = port;
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x0001A3D3 File Offset: 0x000193D3
		protected internal override void Execute(ActivityExecutionContext context)
		{
			this.bookmark = context.CreateNamedBookmark(null, new BookmarkCallback(this.OnResume), BookmarkOptions.MultiResume);
			Messenger.Subscribe<M>(new MessageHandler<M>(this.OnMessage), this.Port);
			this.OnExecute(context);
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x0001A40E File Offset: 0x0001940E
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x0001A410 File Offset: 0x00019410
		private void OnResume(ActivityExecutionContext context, Bookmark bookmark, object target)
		{
		}

		// Token: 0x0600122A RID: 4650
		protected abstract void OnExecute(ActivityExecutionContext context);

		// Token: 0x0600122B RID: 4651
		protected abstract void OnMessage(M message);

		// Token: 0x0600122C RID: 4652 RVA: 0x0001A412 File Offset: 0x00019412
		protected internal override void Close()
		{
			Messenger.Unsubscribe<M>(new MessageHandler<M>(this.OnMessage), this.Port);
			if (this.bookmark != null)
			{
				this.bookmark.Close();
			}
			this.bookmark = null;
			base.Close();
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600122D RID: 4653 RVA: 0x0001A44C File Offset: 0x0001944C
		public uint Port
		{
			get
			{
				return this.port;
			}
		}

		// Token: 0x04000424 RID: 1060
		private readonly uint port;

		// Token: 0x04000425 RID: 1061
		private Bookmark bookmark;
	}
}
