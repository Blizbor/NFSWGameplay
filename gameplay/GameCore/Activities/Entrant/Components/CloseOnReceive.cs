using System;
using GameCore.Interfaces;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x0200016A RID: 362
	public class CloseOnReceive<M> : MessageHandler<M> where M : Message, IPersonaMessage
	{
		// Token: 0x0600130F RID: 4879 RVA: 0x0001B4EF File Offset: 0x0001A4EF
		public CloseOnReceive(InstancedEvent evnt, EntrantInfo entrant, uint port) : base(evnt, entrant, port)
		{
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x0001B4FA File Offset: 0x0001A4FA
		protected override void OnExecute(ActivityExecutionContext context)
		{
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x0001B4FC File Offset: 0x0001A4FC
		protected override void OnMessage(M message)
		{
			if (message.PersonaId == base.Entrant.PersonaId)
			{
				this.Close();
			}
		}
	}
}
