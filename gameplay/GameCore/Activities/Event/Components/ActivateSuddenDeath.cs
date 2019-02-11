using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001B0 RID: 432
	public class ActivateSuddenDeath : Component<InstancedEvent>
	{
		// Token: 0x06001413 RID: 5139 RVA: 0x00020CCB File Offset: 0x0001FCCB
		public ActivateSuddenDeath(InstancedEvent @event) : base(@event)
		{
		}

		// Token: 0x06001414 RID: 5140 RVA: 0x00020CD4 File Offset: 0x0001FCD4
		protected internal override void Execute(ActivityExecutionContext context)
		{
			if (!base.Event.IsSuddenDeath)
			{
				base.Event.IsSuddenDeath = true;
				base.Event.ClearStrikes();
				FlasherManager.Get().EnqueueFlasher(new FlasherBase(4291578633u));
			}
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x00020D0F File Offset: 0x0001FD0F
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
