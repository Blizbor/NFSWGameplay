using System;
using EASharp;

namespace GameCore.Messages
{
	// Token: 0x02000270 RID: 624
	[Export]
	public class OnReturnToPreviousState : Message
	{
		// Token: 0x17000240 RID: 576
		// (get) Token: 0x0600188E RID: 6286 RVA: 0x0002B770 File Offset: 0x0002A770
		public override uint Kind
		{
			get
			{
				return OnReturnToPreviousState.KindHash;
			}
		}

		// Token: 0x0400061A RID: 1562
		private static uint KindHash = Hash.Hash32("GameCore.Messages.OnReturnToPreviousState");
	}
}
