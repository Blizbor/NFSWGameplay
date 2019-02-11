using System;

namespace GameCore.Messages
{
	// Token: 0x02000265 RID: 613
	public class OnHuntContinued : Message
	{
		// Token: 0x1700022F RID: 559
		// (get) Token: 0x0600185E RID: 6238 RVA: 0x0002B51D File Offset: 0x0002A51D
		public override uint Kind
		{
			get
			{
				return OnHuntContinued.KindHash;
			}
		}

		// Token: 0x04000609 RID: 1545
		private static uint KindHash = Hash.Hash32("GameCore.Messages.OnHuntContinued");
	}
}
