using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x02000168 RID: 360
	public class CleanupScoringMethod : Component
	{
		// Token: 0x06001308 RID: 4872 RVA: 0x0001B4A2 File Offset: 0x0001A4A2
		public CleanupScoringMethod(Event evnt, EntrantInfo entrant) : base(evnt, entrant)
		{
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x0001B4AC File Offset: 0x0001A4AC
		protected internal override void Execute(ActivityExecutionContext context)
		{
			base.Entrant.Cleanup();
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x0001B4B9 File Offset: 0x0001A4B9
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
