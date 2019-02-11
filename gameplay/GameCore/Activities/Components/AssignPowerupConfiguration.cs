using System;
using System.Collections.Generic;
using GameCore.Powerups;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x02000127 RID: 295
	public class AssignPowerupConfiguration : WorkflowElement
	{
		// Token: 0x060011FE RID: 4606 RVA: 0x0001A0CD File Offset: 0x000190CD
		public AssignPowerupConfiguration(PowerupConfiguration config)
		{
			this.config = config;
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x0001A0DC File Offset: 0x000190DC
		protected internal override void Execute(ActivityExecutionContext context)
		{
			Powerups.AssignPowerupConfiguration(this.config);
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x0001A0E9 File Offset: 0x000190E9
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x04000416 RID: 1046
		private readonly PowerupConfiguration config;
	}
}
