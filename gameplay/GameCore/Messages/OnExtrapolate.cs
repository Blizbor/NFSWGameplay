using System;

namespace GameCore.Messages
{
	// Token: 0x02000261 RID: 609
	public class OnExtrapolate : Message
	{
		// Token: 0x17000227 RID: 551
		// (get) Token: 0x0600184C RID: 6220 RVA: 0x0002B40F File Offset: 0x0002A40F
		public override uint Kind
		{
			get
			{
				return OnExtrapolate.KindHash;
			}
		}

		// Token: 0x04000601 RID: 1537
		private static uint KindHash = Hash.Hash32("GameCore.Messages.OnExtrapolate");
	}
}
