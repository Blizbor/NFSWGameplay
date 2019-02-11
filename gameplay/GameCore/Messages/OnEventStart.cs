using System;
using EASharp;

namespace GameCore.Messages
{
	// Token: 0x0200025F RID: 607
	[Export]
	public class OnEventStart : Message
	{
		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06001846 RID: 6214 RVA: 0x0002B3CF File Offset: 0x0002A3CF
		public override uint Kind
		{
			get
			{
				return OnEventStart.KindHash;
			}
		}

		// Token: 0x040005FF RID: 1535
		private static uint KindHash = Hash.Hash32("GameCore.Messages.OnEventStart");
	}
}
