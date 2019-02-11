using System;
using EASharp;

namespace GameCore.Messages
{
	// Token: 0x0200026F RID: 623
	[Export]
	public class OnResumePostrace : Message
	{
		// Token: 0x1700023F RID: 575
		// (get) Token: 0x0600188B RID: 6283 RVA: 0x0002B750 File Offset: 0x0002A750
		public override uint Kind
		{
			get
			{
				return OnResumePostrace.KindHash;
			}
		}

		// Token: 0x04000619 RID: 1561
		private static uint KindHash = Hash.Hash32("GameCore.Messages.OnResumePostrace");
	}
}
