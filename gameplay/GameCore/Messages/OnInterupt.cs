using System;
using EASharp;

namespace GameCore.Messages
{
	// Token: 0x020001F8 RID: 504
	[Export]
	public class OnInterupt : Message
	{
		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06001563 RID: 5475 RVA: 0x00025DFA File Offset: 0x00024DFA
		public override uint Kind
		{
			get
			{
				return OnInterupt.KindHash;
			}
		}

		// Token: 0x04000507 RID: 1287
		private static uint KindHash = Hash.Hash32("GameCore.Messages.OnInterupt");
	}
}
