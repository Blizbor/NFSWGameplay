using System;
using System.Collections.Generic;
using GameCore.Workflow;
using GameCore.Workflow.Activities;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001B4 RID: 436
	public class CheckOpponentDisconnected : Bookmarked
	{
		// Token: 0x06001420 RID: 5152 RVA: 0x00020DBA File Offset: 0x0001FDBA
		public CheckOpponentDisconnected(Manager manager, bool matches)
		{
			this.manager = manager;
			this.matches = matches;
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x00020DD0 File Offset: 0x0001FDD0
		protected internal override void Execute(ActivityExecutionContext context)
		{
			base.Execute(context);
			Opponent opponent = this.manager.OpponentManager.FindLocalOpponent();
			if (opponent != null)
			{
				Console.WriteLine(">>>>>>>>>>>>>CheckOpponentDisconnected BGSTATUS. looking for: {%0} to be: {%1}   Is it?: {%2}", OpponentStatus.kOpponent_Disconnected, this.matches, opponent.IsStatus(OpponentStatus.kOpponent_Disconnected) == this.matches);
				if (opponent.IsStatus(OpponentStatus.kOpponent_Disconnected) == this.matches)
				{
					Console.WriteLine(">>>>>>>>>>>>>CheckOpponentDisconnected BGSTATUS. MATCH");
					this.Close();
					return;
				}
			}
			else
			{
				Console.WriteLine(">>>>>>>>>>>>>CheckOpponentDisconnected BGSTATUS. NULL localOpponent!");
			}
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x00020E5D File Offset: 0x0001FE5D
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x040004B6 RID: 1206
		private readonly Manager manager;

		// Token: 0x040004B7 RID: 1207
		private readonly bool matches;
	}
}
