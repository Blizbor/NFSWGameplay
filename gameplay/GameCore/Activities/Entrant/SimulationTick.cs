using System;
using GameCore.Workflow.Activities;

namespace GameCore.Activities.Entrant
{
	// Token: 0x02000176 RID: 374
	public abstract class SimulationTick : SimulationTick
	{
		// Token: 0x0600133A RID: 4922 RVA: 0x0001BC1B File Offset: 0x0001AC1B
		public SimulationTick(Event evnt, EntrantInfo entrant, float period) : base(period)
		{
			this.evnt = evnt;
			this.entrant = entrant;
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600133B RID: 4923 RVA: 0x0001BC32 File Offset: 0x0001AC32
		public Event Event
		{
			get
			{
				return this.evnt;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600133C RID: 4924 RVA: 0x0001BC3A File Offset: 0x0001AC3A
		public InstancedEvent InstancedEvent
		{
			get
			{
				return this.evnt as InstancedEvent;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600133D RID: 4925 RVA: 0x0001BC47 File Offset: 0x0001AC47
		public EntrantInfo Entrant
		{
			get
			{
				return this.entrant;
			}
		}

		// Token: 0x0400047D RID: 1149
		private Event evnt;

		// Token: 0x0400047E RID: 1150
		private EntrantInfo entrant;
	}
}
