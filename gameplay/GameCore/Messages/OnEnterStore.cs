using System;
using EASharp;

namespace GameCore.Messages
{
	// Token: 0x0200025D RID: 605
	[Export]
	public class OnEnterStore : Message
	{
		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06001840 RID: 6208 RVA: 0x0002B38F File Offset: 0x0002A38F
		public override uint Kind
		{
			get
			{
				return OnEnterStore.KindHash;
			}
		}

		// Token: 0x040005FD RID: 1533
		private static uint KindHash = Hash.Hash32("GameCore.Messages.OnEnterStore");
	}
}
