using System;

namespace GameCore.Messages
{
	// Token: 0x02000264 RID: 612
	public class OnHuntCompleted : Message
	{
		// Token: 0x1700022E RID: 558
		// (get) Token: 0x0600185B RID: 6235 RVA: 0x0002B4FD File Offset: 0x0002A4FD
		public override uint Kind
		{
			get
			{
				return OnHuntCompleted.KindHash;
			}
		}

		// Token: 0x04000608 RID: 1544
		private static uint KindHash = Hash.Hash32("GameCore.Messages.OnHuntCompleted");
	}
}
