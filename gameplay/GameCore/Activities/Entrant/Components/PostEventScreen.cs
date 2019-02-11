using System;
using System.Collections.Generic;
using GameCore.Messages;
using GameCore.Opponents;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x0200018B RID: 395
	public class PostEventScreen : MessageHandler<OnResumePostrace>
	{
		// Token: 0x06001385 RID: 4997 RVA: 0x0001C47C File Offset: 0x0001B47C
		public PostEventScreen(Event evnt, EntrantInfo entrant, uint port) : base(evnt, entrant, port)
		{
			LocalHumanOpponent localHumanOpponent = base.Entrant.Opponent as LocalHumanOpponent;
			if (localHumanOpponent != null)
			{
				base.Event.CreateArbitratedPacket();
			}
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x0001C4B4 File Offset: 0x0001B4B4
		protected override void OnExecute(ActivityExecutionContext context)
		{
			LocalHumanOpponent localHumanOpponent = base.Entrant.Opponent as LocalHumanOpponent;
			if (localHumanOpponent != null)
			{
				Hud.EnableGadget("PostRace", true);
			}
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x0001C4E0 File Offset: 0x0001B4E0
		protected override void OnMessage(OnResumePostrace message)
		{
			if (base.Entrant.Opponent is LocalHumanOpponent)
			{
				base.Event.CleanupArbitratedPacket();
			}
			this.Close();
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x0001C505 File Offset: 0x0001B505
		protected internal override void Close()
		{
			base.Close();
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x0001C50D File Offset: 0x0001B50D
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x04000493 RID: 1171
		private const string PostEventScreenName = "PostRace";
	}
}
