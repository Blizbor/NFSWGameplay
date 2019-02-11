using System;
using System.Collections.Generic;
using GameCore.Messages;
using GameCore.Opponents;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x02000197 RID: 407
	public class SendRespawnMessage : Component
	{
		// Token: 0x060013B7 RID: 5047 RVA: 0x0001CB85 File Offset: 0x0001BB85
		public SendRespawnMessage(InstancedEvent evnt, EntrantInfo entrant, InArgument<long> respawnTargetPersonaId) : base(evnt, entrant)
		{
			this.respawnTargetPersonaId = respawnTargetPersonaId;
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x0001CB98 File Offset: 0x0001BB98
		protected internal override void Execute(ActivityExecutionContext context)
		{
			OnRespawn onRespawn = new OnRespawn(base.Entrant.PersonaId, this.respawnTargetPersonaId.Value);
			LocalHumanOpponent localHumanOpponent = base.Entrant.Opponent as LocalHumanOpponent;
			if (localHumanOpponent != null)
			{
				onRespawn.Synchronize(Ports.Gameplay);
			}
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x0001CBE0 File Offset: 0x0001BBE0
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x0001CBE2 File Offset: 0x0001BBE2
		protected internal override void Close()
		{
			base.Close();
		}

		// Token: 0x0400049B RID: 1179
		private readonly InArgument<long> respawnTargetPersonaId;
	}
}
