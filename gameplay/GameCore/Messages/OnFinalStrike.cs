using System;

namespace GameCore.Messages
{
	// Token: 0x02000262 RID: 610
	public class OnFinalStrike : Message
	{
		// Token: 0x17000228 RID: 552
		// (get) Token: 0x0600184F RID: 6223 RVA: 0x0002B42F File Offset: 0x0002A42F
		public override uint Kind
		{
			get
			{
				return OnFinalStrike.KindHash;
			}
		}

		// Token: 0x04000602 RID: 1538
		private static uint KindHash = Hash.Hash32("GameCore.Messages.OnFinalStrike");
	}
}
