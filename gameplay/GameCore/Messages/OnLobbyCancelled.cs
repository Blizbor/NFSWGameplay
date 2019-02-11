using System;

namespace GameCore.Messages
{
	// Token: 0x02000266 RID: 614
	public class OnLobbyCancelled : Message
	{
		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06001861 RID: 6241 RVA: 0x0002B53D File Offset: 0x0002A53D
		public override uint Kind
		{
			get
			{
				return OnLobbyCancelled.KindHash;
			}
		}

		// Token: 0x0400060A RID: 1546
		private static uint KindHash = Hash.Hash32("GameCore.Messages.OnLobbyCancelled");
	}
}
