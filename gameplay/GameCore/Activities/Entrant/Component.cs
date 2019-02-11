using System;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant
{
	// Token: 0x02000165 RID: 357
	public abstract class Component : WorkflowElement
	{
		// Token: 0x060012FE RID: 4862 RVA: 0x0001B386 File Offset: 0x0001A386
		public Component(Event @event, EntrantInfo entrant)
		{
			this.@event = @event;
			this.entrant = entrant;
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060012FF RID: 4863 RVA: 0x0001B39C File Offset: 0x0001A39C
		public Event Event
		{
			get
			{
				return this.@event;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06001300 RID: 4864 RVA: 0x0001B3A4 File Offset: 0x0001A3A4
		public InstancedEvent InstancedEvent
		{
			get
			{
				return this.@event as InstancedEvent;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06001301 RID: 4865 RVA: 0x0001B3B1 File Offset: 0x0001A3B1
		public EntrantInfo Entrant
		{
			get
			{
				return this.entrant;
			}
		}

		// Token: 0x04000465 RID: 1125
		private readonly Event @event;

		// Token: 0x04000466 RID: 1126
		private readonly EntrantInfo entrant;
	}
}
