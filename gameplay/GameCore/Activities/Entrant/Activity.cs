using System;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant
{
	// Token: 0x020001A4 RID: 420
	public abstract class Activity : Activity
	{
		// Token: 0x060013EF RID: 5103 RVA: 0x0001D255 File Offset: 0x0001C255
		public Activity()
		{
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x0001D25D File Offset: 0x0001C25D
		public Activity(Event evnt, EntrantInfo entrant)
		{
			this.evnt = evnt;
			this.entrant = entrant;
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060013F1 RID: 5105 RVA: 0x0001D273 File Offset: 0x0001C273
		// (set) Token: 0x060013F2 RID: 5106 RVA: 0x0001D27B File Offset: 0x0001C27B
		public Event Event
		{
			get
			{
				return this.evnt;
			}
			set
			{
				this.evnt = value;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060013F3 RID: 5107 RVA: 0x0001D284 File Offset: 0x0001C284
		// (set) Token: 0x060013F4 RID: 5108 RVA: 0x0001D291 File Offset: 0x0001C291
		public InstancedEvent InstancedEvent
		{
			get
			{
				return this.evnt as InstancedEvent;
			}
			set
			{
				this.evnt = value;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060013F5 RID: 5109 RVA: 0x0001D29A File Offset: 0x0001C29A
		// (set) Token: 0x060013F6 RID: 5110 RVA: 0x0001D2A2 File Offset: 0x0001C2A2
		public EntrantInfo Entrant
		{
			get
			{
				return this.entrant;
			}
			set
			{
				this.entrant = value;
			}
		}

		// Token: 0x040004A9 RID: 1193
		private Event evnt;

		// Token: 0x040004AA RID: 1194
		private EntrantInfo entrant;
	}
}
