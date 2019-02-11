using System;
using System.Collections.Generic;
using GameCore.Workflow;
using Victory.DataLayer.Serialization.Event;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x02000193 RID: 403
	public class ReportEntrantFinished : Component
	{
		// Token: 0x060013A0 RID: 5024 RVA: 0x0001C7DA File Offset: 0x0001B7DA
		public ReportEntrantFinished(InstancedEvent evnt, EntrantInfo entrant) : base(evnt, entrant)
		{
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x0001C7E4 File Offset: 0x0001B7E4
		protected internal override void Execute(ActivityExecutionContext context)
		{
			if (base.Entrant.ScoringState.IsFinishReason(FinishReason.CrossedFinish))
			{
				Net.EntrantCrossedFinish();
			}
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x0001C7FF File Offset: 0x0001B7FF
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
