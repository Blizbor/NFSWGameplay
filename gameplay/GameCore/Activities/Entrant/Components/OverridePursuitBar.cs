using System;
using System.Collections.Generic;
using GameCore.Scoring;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x0200018A RID: 394
	public class OverridePursuitBar : Component
	{
		// Token: 0x06001382 RID: 4994 RVA: 0x0001C43A File Offset: 0x0001B43A
		public OverridePursuitBar(InstancedEvent evnt, EntrantInfo entrant, float overrideValue) : base(evnt, entrant)
		{
			this.overrideValue = overrideValue;
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x0001C44C File Offset: 0x0001B44C
		protected internal override void Execute(ActivityExecutionContext context)
		{
			IPursuit pursuit = base.Entrant.ScoringState as IPursuit;
			if (pursuit != null)
			{
				pursuit.PursuitBar = this.overrideValue;
			}
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x0001C479 File Offset: 0x0001B479
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x04000492 RID: 1170
		private readonly float overrideValue;
	}
}
