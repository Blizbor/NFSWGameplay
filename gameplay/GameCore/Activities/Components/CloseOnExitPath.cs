using System;
using System.Collections.Generic;
using GameCore.Workflow;
using GameCore.Workflow.Activities;
using Victory.DataLayer.Serialization.Event;

namespace GameCore.Activities.Components
{
	// Token: 0x02000131 RID: 305
	public class CloseOnExitPath : Bookmarked
	{
		// Token: 0x06001223 RID: 4643 RVA: 0x0001A35C File Offset: 0x0001935C
		public CloseOnExitPath(ExitPath exitPath, bool closeOnTimedOut)
		{
			this.exitPath = exitPath;
			this.closeOnTimedOut = closeOnTimedOut;
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x0001A374 File Offset: 0x00019374
		protected internal override void Execute(ActivityExecutionContext context)
		{
			base.Execute(context);
			float eventTimeoutInSeconds = InternalLobby.Get().GetEventTimeoutInSeconds();
			if (eventTimeoutInSeconds <= 0f)
			{
				if (this.closeOnTimedOut)
				{
					this.Close();
				}
				return;
			}
			if (InternalLobby.Get().GetExitPath() == this.exitPath)
			{
				this.Close();
			}
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x0001A3C2 File Offset: 0x000193C2
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x04000422 RID: 1058
		private readonly ExitPath exitPath;

		// Token: 0x04000423 RID: 1059
		private readonly bool closeOnTimedOut;
	}
}
