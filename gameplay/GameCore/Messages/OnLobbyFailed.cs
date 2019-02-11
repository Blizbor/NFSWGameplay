using System;

namespace GameCore.Messages
{
	// Token: 0x02000268 RID: 616
	public class OnLobbyFailed : Message
	{
		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06001867 RID: 6247 RVA: 0x0002B57D File Offset: 0x0002A57D
		public override uint Kind
		{
			get
			{
				return OnLobbyFailed.KindHash;
			}
		}

		// Token: 0x0400060C RID: 1548
		private static uint KindHash = Hash.Hash32("GameCore.Messages.OnLobbyFailed");
	}
}
