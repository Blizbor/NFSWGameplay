using System;
using EASharp;

namespace GameCore.Messages
{
	// Token: 0x0200026E RID: 622
	[Export]
	public class OnResumeCountdown : Message
	{
		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06001888 RID: 6280 RVA: 0x0002B728 File Offset: 0x0002A728
		public override uint Kind
		{
			get
			{
				return this.KindHash;
			}
		}

		// Token: 0x04000618 RID: 1560
		private readonly uint KindHash = Hash.Hash32("GameCore.Messages.OnResumeCountdown");
	}
}
