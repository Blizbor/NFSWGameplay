using System;
using EASharp;

namespace GameCore.Messages
{
	// Token: 0x02000260 RID: 608
	[Export]
	public class OnExitTutorial : Message
	{
		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06001849 RID: 6217 RVA: 0x0002B3EF File Offset: 0x0002A3EF
		public override uint Kind
		{
			get
			{
				return OnExitTutorial.KindHash;
			}
		}

		// Token: 0x04000600 RID: 1536
		private static uint KindHash = Hash.Hash32("GameCore.Messages.OnExitTutorial");
	}
}
