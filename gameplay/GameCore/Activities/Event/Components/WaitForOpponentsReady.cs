using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001DA RID: 474
	public class WaitForOpponentsReady : SimulationTick
	{
		// Token: 0x060014A5 RID: 5285 RVA: 0x000227CA File Offset: 0x000217CA
		public WaitForOpponentsReady(InstancedEvent evnt, float period) : base(evnt, period)
		{
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x000227D4 File Offset: 0x000217D4
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x000227D6 File Offset: 0x000217D6
		protected override void OnExecute(ActivityExecutionContext context)
		{
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x000227D8 File Offset: 0x000217D8
		protected override void Tick(float dT)
		{
			foreach (EntrantInfo entrantInfo in base.Event.Entrants)
			{
				if (!entrantInfo.Opponent.IsStatus(OpponentStatus.kOpponent_Ready))
				{
					return;
				}
			}
			this.Close();
		}
	}
}
