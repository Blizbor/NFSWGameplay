using System;

namespace GameCore
{
	// Token: 0x02000235 RID: 565
	public class EventCompletedArgs : EventArgs
	{
		// Token: 0x06001716 RID: 5910 RVA: 0x00028C74 File Offset: 0x00027C74
		public EventCompletedArgs(InstancedEvent evnt)
		{
			this.evnt = evnt;
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06001717 RID: 5911 RVA: 0x00028C83 File Offset: 0x00027C83
		public InstancedEvent Event
		{
			get
			{
				return this.evnt;
			}
		}

		// Token: 0x04000596 RID: 1430
		private readonly InstancedEvent evnt;
	}
}
