using System;
using System.Collections.Generic;
using GameCore.Opponents;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x02000198 RID: 408
	public class SetCamera : Component
	{
		// Token: 0x060013BB RID: 5051 RVA: 0x0001CBEA File Offset: 0x0001BBEA
		public SetCamera(InstancedEvent evnt, EntrantInfo entrant, string cameraName) : base(evnt, entrant)
		{
			this.cameraName = cameraName;
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x0001CBFC File Offset: 0x0001BBFC
		protected internal override void Execute(ActivityExecutionContext context)
		{
			LocalHumanOpponent localHumanOpponent = base.Entrant.Opponent as LocalHumanOpponent;
			if (localHumanOpponent != null)
			{
				if (base.InstancedEvent.SpectateMethod != null)
				{
					base.InstancedEvent.SpectateMethod.ClearTarget();
				}
				Cameras.Set(this.cameraName);
			}
		}

		// Token: 0x060013BD RID: 5053 RVA: 0x0001CC45 File Offset: 0x0001BC45
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x0400049C RID: 1180
		private readonly string cameraName;
	}
}
