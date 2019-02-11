using System;
using System.Collections.Generic;
using GameCore.Opponents;
using GameCore.Workflow;
using Victory.Service.Objects;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x02000167 RID: 359
	public class Bust : Component
	{
		// Token: 0x06001305 RID: 4869 RVA: 0x0001B438 File Offset: 0x0001A438
		public Bust(InstancedEvent evnt, EntrantInfo entrant) : base(evnt, entrant)
		{
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x0001B444 File Offset: 0x0001A444
		protected internal override void Execute(ActivityExecutionContext context)
		{
			base.Entrant.Conclude(base.Event.ScoringMethod);
			if (base.Entrant.Opponent is LocalHumanOpponent)
			{
				ArbitrationPacket arbitrationPacket = base.Event.ScoringMethod.FillArbitrationRecord(base.Entrant);
				if (arbitrationPacket != null)
				{
					base.InstancedEvent.Bust(arbitrationPacket);
				}
			}
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x0001B4A0 File Offset: 0x0001A4A0
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
