using System;
using System.Collections.Generic;
using GameCore.Powerups;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001B3 RID: 435
	public class AssignPowerupConfiguration : Component<Event>
	{
		// Token: 0x0600141D RID: 5149 RVA: 0x00020D98 File Offset: 0x0001FD98
		public AssignPowerupConfiguration(InstancedEvent evnt) : base(evnt)
		{
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x00020DA1 File Offset: 0x0001FDA1
		protected internal override void Execute(ActivityExecutionContext context)
		{
			Powerups.AssignPowerupConfiguration(base.Event.EventDef.PowerupConfiguration());
		}

		// Token: 0x0600141F RID: 5151 RVA: 0x00020DB8 File Offset: 0x0001FDB8
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
