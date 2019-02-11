using System;
using EASharp;

namespace GameCore.Messages
{
	// Token: 0x0200025A RID: 602
	[Export]
	public class OnEnterFreeroam : Message
	{
		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06001836 RID: 6198 RVA: 0x0002B320 File Offset: 0x0002A320
		public override uint Kind
		{
			get
			{
				return OnEnterFreeroam.KindHash;
			}
		}

		// Token: 0x040005F9 RID: 1529
		private static uint KindHash = Hash.Hash32("GameCore.Messages.OnEnterFreeroam");
	}
}
