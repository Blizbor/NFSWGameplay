using System;

namespace GameCore.Messages
{
	// Token: 0x0200025B RID: 603
	public class OnEnterLobby : Message
	{
		// Token: 0x06001838 RID: 6200 RVA: 0x0002B338 File Offset: 0x0002A338
		public OnEnterLobby(uint eventKey)
		{
			this.eventKey = eventKey;
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06001839 RID: 6201 RVA: 0x0002B347 File Offset: 0x0002A347
		public override uint Kind
		{
			get
			{
				return OnEnterLobby.KindHash;
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x0600183A RID: 6202 RVA: 0x0002B34E File Offset: 0x0002A34E
		internal uint EventKey
		{
			get
			{
				return this.eventKey;
			}
		}

		// Token: 0x040005FA RID: 1530
		private readonly uint eventKey;

		// Token: 0x040005FB RID: 1531
		private static uint KindHash = Hash.Hash32("GameCore.Messages.OnEnterLobby");
	}
}
