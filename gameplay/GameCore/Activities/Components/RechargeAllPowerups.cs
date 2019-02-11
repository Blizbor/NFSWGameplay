using System;
using System.Collections.Generic;
using GameCore.Powerups;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x02000151 RID: 337
	public class RechargeAllPowerups : WorkflowElement
	{
		// Token: 0x0600129C RID: 4764 RVA: 0x0001AC12 File Offset: 0x00019C12
		protected internal override void Execute(ActivityExecutionContext context)
		{
			Powerups.RechargeAllPowerups();
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x0001AC19 File Offset: 0x00019C19
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
