using System;
using GameCore.Messages;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x0200019F RID: 415
	public class WaitForRespawnMessage : MessageHandler<OnRespawn>
	{
		// Token: 0x060013CF RID: 5071 RVA: 0x0001CF06 File Offset: 0x0001BF06
		public WaitForRespawnMessage(InstancedEvent evnt, EntrantInfo entrant, uint port, OutArgument<long> respawnTargetPersonaId) : base(evnt, entrant, port)
		{
			this.respawnTargetPersonaId = respawnTargetPersonaId;
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x0001CF19 File Offset: 0x0001BF19
		protected override void OnExecute(ActivityExecutionContext context)
		{
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x0001CF1B File Offset: 0x0001BF1B
		protected override void OnMessage(OnRespawn message)
		{
			if (message.PersonaId == base.Entrant.PersonaId)
			{
				this.respawnTargetPersonaId.Value = message.RespawnTargetPersonaId;
				this.Close();
			}
		}

		// Token: 0x0400049F RID: 1183
		private readonly OutArgument<long> respawnTargetPersonaId;
	}
}
