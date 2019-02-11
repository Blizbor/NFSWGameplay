using System;

namespace GameCore.Workflow
{
	// Token: 0x020001DB RID: 475
	public abstract class Mode : Activity
	{
		// Token: 0x060014A9 RID: 5289 RVA: 0x00022840 File Offset: 0x00021840
		protected internal override void Close()
		{
			this.evnt = null;
			base.Close();
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060014AA RID: 5290 RVA: 0x0002284F File Offset: 0x0002184F
		// (set) Token: 0x060014AB RID: 5291 RVA: 0x00022857 File Offset: 0x00021857
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

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060014AC RID: 5292 RVA: 0x00022860 File Offset: 0x00021860
		public InstancedEvent InstancedEvent
		{
			get
			{
				return this.evnt as InstancedEvent;
			}
		}

		// Token: 0x040004DA RID: 1242
		private Event evnt;
	}
}
