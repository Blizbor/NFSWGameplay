using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x0200016B RID: 363
	public class CoinCollected : Component
	{
		// Token: 0x06001312 RID: 4882 RVA: 0x0001B51E File Offset: 0x0001A51E
		public CoinCollected(Event evnt, EntrantInfo entrant) : base(evnt, entrant)
		{
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x0001B528 File Offset: 0x0001A528
		protected internal override void Execute(ActivityExecutionContext context)
		{
			if (base.Event.HasAccolades())
			{
				Audio.PlaySound("TREASURE_HUNT_CONGRATS");
				return;
			}
			Audio.PlaySound("TREASURE_HUNT_COLLECT_COIN");
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x0001B54C File Offset: 0x0001A54C
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x04000469 RID: 1129
		public const string CoinCollectedSound = "TREASURE_HUNT_COLLECT_COIN";

		// Token: 0x0400046A RID: 1130
		public const string AllCoinsCollectedSound = "TREASURE_HUNT_CONGRATS";
	}
}
