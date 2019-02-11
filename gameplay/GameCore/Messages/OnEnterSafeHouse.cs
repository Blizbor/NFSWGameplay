using System;
using EASharp;

namespace GameCore.Messages
{
	// Token: 0x0200025C RID: 604
	[Export]
	public class OnEnterSafeHouse : Message
	{
		// Token: 0x17000222 RID: 546
		// (get) Token: 0x0600183D RID: 6205 RVA: 0x0002B36F File Offset: 0x0002A36F
		public override uint Kind
		{
			get
			{
				return OnEnterSafeHouse.KindHash;
			}
		}

		// Token: 0x040005FC RID: 1532
		private static uint KindHash = Hash.Hash32("GameCore.Messages.OnEnterSafeHouse");
	}
}
