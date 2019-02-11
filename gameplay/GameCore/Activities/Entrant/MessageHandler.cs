using System;
using GameCore.Workflow.Activities;

namespace GameCore.Activities.Entrant
{
	// Token: 0x02000169 RID: 361
	public abstract class MessageHandler<M> : MessageHandler<M> where M : Message
	{
		// Token: 0x0600130B RID: 4875 RVA: 0x0001B4BB File Offset: 0x0001A4BB
		public MessageHandler(Event evnt, EntrantInfo entrant, uint port) : base(port)
		{
			this.evnt = evnt;
			this.entrant = entrant;
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600130C RID: 4876 RVA: 0x0001B4D2 File Offset: 0x0001A4D2
		public Event Event
		{
			get
			{
				return this.evnt;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600130D RID: 4877 RVA: 0x0001B4DA File Offset: 0x0001A4DA
		public InstancedEvent InstancedEvent
		{
			get
			{
				return this.evnt as InstancedEvent;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600130E RID: 4878 RVA: 0x0001B4E7 File Offset: 0x0001A4E7
		public EntrantInfo Entrant
		{
			get
			{
				return this.entrant;
			}
		}

		// Token: 0x04000467 RID: 1127
		private readonly Event evnt;

		// Token: 0x04000468 RID: 1128
		private readonly EntrantInfo entrant;
	}
}
