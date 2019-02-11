using System;

namespace GameCore.Messages
{
	// Token: 0x02000267 RID: 615
	public class OnLobbyExited : Message
	{
		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06001864 RID: 6244 RVA: 0x0002B55D File Offset: 0x0002A55D
		public override uint Kind
		{
			get
			{
				return OnLobbyExited.KindHash;
			}
		}

		// Token: 0x0400060B RID: 1547
		private static uint KindHash = Hash.Hash32("GameCore.Messages.OnLobbyExited");
	}
}
