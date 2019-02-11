using System;
using GameCore.Workflow.Activities;

namespace GameCore.Activities.Event
{
	// Token: 0x020001B9 RID: 441
	public abstract class MessageHandler<M> : MessageHandler<M> where M : Message
	{
		// Token: 0x06001430 RID: 5168 RVA: 0x00020EF8 File Offset: 0x0001FEF8
		public MessageHandler(Event @event, uint port) : base(port)
		{
			this.@event = @event;
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06001431 RID: 5169 RVA: 0x00020F08 File Offset: 0x0001FF08
		public Event Event
		{
			get
			{
				return this.@event;
			}
		}

		// Token: 0x040004B9 RID: 1209
		private readonly Event @event;
	}
}
