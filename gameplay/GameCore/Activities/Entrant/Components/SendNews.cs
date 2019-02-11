using System;
using System.Collections.Generic;
using GameCore.Scoring;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x02000196 RID: 406
	public class SendNews : Component
	{
		// Token: 0x060013B3 RID: 5043 RVA: 0x0001CB1C File Offset: 0x0001BB1C
		public SendNews(Event evnt, EntrantInfo entrant) : base(evnt, entrant)
		{
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x0001CB28 File Offset: 0x0001BB28
		protected internal override void Execute(ActivityExecutionContext context)
		{
			TreasureHuntScoringState treasureHuntScoringState = base.Entrant.ScoringState as TreasureHuntScoringState;
			if (treasureHuntScoringState.GetNumberOfCollectedCoins() != base.Event.EventDef.Num_Coins())
			{
				Marshal.Get().SendNews(9223372036854775807UL, "TXT_NEWS_TREASURE_HUNT_SHORT", "TXT_NEWS_TREASURE_HUNT");
			}
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x0001CB7B File Offset: 0x0001BB7B
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x0001CB7D File Offset: 0x0001BB7D
		protected internal override void Close()
		{
			base.Close();
		}
	}
}
