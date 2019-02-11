using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001D6 RID: 470
	public class SortEntrants : Component<InstancedEvent>
	{
		// Token: 0x0600149A RID: 5274 RVA: 0x00022664 File Offset: 0x00021664
		public SortEntrants(InstancedEvent evnt) : base(evnt)
		{
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x00022670 File Offset: 0x00021670
		protected internal override void Execute(ActivityExecutionContext context)
		{
			base.Event.ScoringMethod.Sort(base.Event.Entrants);
			int count = base.Event.Entrants.Count;
			for (int i = 0; i < count; i++)
			{
				EntrantInfo entrantInfo = base.Event.Entrants[i];
				if (entrantInfo.ScoringState == null)
				{
					return;
				}
				entrantInfo.ScoringState.Rank = i + 1;
			}
		}

		// Token: 0x0600149C RID: 5276 RVA: 0x000226DE File Offset: 0x000216DE
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
