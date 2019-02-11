using System;
using EASharp;

namespace GameCore.Messages
{
	// Token: 0x0200025E RID: 606
	[Export]
	public class OnEventReady : Message
	{
		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06001843 RID: 6211 RVA: 0x0002B3AF File Offset: 0x0002A3AF
		public override uint Kind
		{
			get
			{
				return OnEventReady.KindHash;
			}
		}

		// Token: 0x040005FE RID: 1534
		private static uint KindHash = Hash.Hash32("GameCore.Messages.OnEventReady");
	}
}
