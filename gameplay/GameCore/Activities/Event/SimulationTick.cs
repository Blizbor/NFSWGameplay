using System;
using GameCore.Workflow.Activities;

namespace GameCore.Activities.Event
{
	// Token: 0x020001D9 RID: 473
	public abstract class SimulationTick : SimulationTick
	{
		// Token: 0x060014A3 RID: 5283 RVA: 0x000227B2 File Offset: 0x000217B2
		public SimulationTick(InstancedEvent evnt, float period) : base(period)
		{
			this.evnt = evnt;
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060014A4 RID: 5284 RVA: 0x000227C2 File Offset: 0x000217C2
		public InstancedEvent Event
		{
			get
			{
				return this.evnt;
			}
		}

		// Token: 0x040004D9 RID: 1241
		private InstancedEvent evnt;
	}
}
