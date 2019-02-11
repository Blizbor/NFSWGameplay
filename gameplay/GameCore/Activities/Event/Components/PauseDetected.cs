using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001C9 RID: 457
	public class PauseDetected : Component<InstancedEvent>
	{
		// Token: 0x0600146A RID: 5226 RVA: 0x00021C9F File Offset: 0x00020C9F
		public PauseDetected(InstancedEvent evnt) : base(evnt)
		{
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x00021CA8 File Offset: 0x00020CA8
		protected internal override void Execute(ActivityExecutionContext context)
		{
			base.Event.PauseDetected += this.Event_PauseDetected;
			this.bookmark = context.CreateNamedBookmark(null, null);
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x00021CCF File Offset: 0x00020CCF
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x00021CD1 File Offset: 0x00020CD1
		protected internal override void Close()
		{
			base.Event.PauseDetected -= this.Event_PauseDetected;
			if (this.bookmark != null)
			{
				this.bookmark.Close();
			}
			base.Close();
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x00021D03 File Offset: 0x00020D03
		private void Event_PauseDetected(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x040004CC RID: 1228
		private Bookmark bookmark;
	}
}
