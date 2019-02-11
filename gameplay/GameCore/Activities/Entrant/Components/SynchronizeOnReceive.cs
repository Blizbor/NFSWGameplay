using System;
using GameCore.Interfaces;
using GameCore.Opponents;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x0200019A RID: 410
	public class SynchronizeOnReceive<M> : MessageHandler<M> where M : Message, IPersonaMessage
	{
		// Token: 0x060013C2 RID: 5058 RVA: 0x0001CCC1 File Offset: 0x0001BCC1
		public SynchronizeOnReceive(InstancedEvent evnt, EntrantInfo entrant, uint port) : base(evnt, entrant, port)
		{
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x0001CCCC File Offset: 0x0001BCCC
		protected override void OnExecute(ActivityExecutionContext context)
		{
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x0001CCD0 File Offset: 0x0001BCD0
		protected override void OnMessage(M message)
		{
			if (message.PersonaId == base.Entrant.PersonaId)
			{
				LocalHumanOpponent localHumanOpponent = base.Entrant.Opponent as LocalHumanOpponent;
				if (localHumanOpponent != null)
				{
					message.Synchronize(base.Port);
				}
			}
		}
	}
}
