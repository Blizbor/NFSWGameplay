using System;
using GameCore.Interfaces;
using GameCore.Opponents;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001D8 RID: 472
	public class SynchronizeOnReceive<M> : MessageHandler<M> where M : Message, IPersonaMessage
	{
		// Token: 0x060014A0 RID: 5280 RVA: 0x00022757 File Offset: 0x00021757
		public SynchronizeOnReceive(InstancedEvent evnt, uint port) : base(evnt, port)
		{
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x00022761 File Offset: 0x00021761
		protected override void OnExecute(ActivityExecutionContext context)
		{
		}

		// Token: 0x060014A2 RID: 5282 RVA: 0x00022764 File Offset: 0x00021764
		protected override void OnMessage(M message)
		{
			Opponent opponent = base.Event.Manager.OpponentManager.FindByPersonaId(message.PersonaId);
			if (opponent != null && opponent is LocalHumanOpponent)
			{
				message.Synchronize(base.Port);
			}
		}
	}
}
