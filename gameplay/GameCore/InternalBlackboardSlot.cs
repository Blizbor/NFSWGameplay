using System;

namespace GameCore
{
	// Token: 0x0200023D RID: 573
	public struct InternalBlackboardSlot
	{
		// Token: 0x0600176B RID: 5995 RVA: 0x00029DBF File Offset: 0x00028DBF
		public InternalBlackboardSlot(BlackBoardChannel channel, uint blackboardKey)
		{
			this.channel = channel;
			this.blackboardKey = blackboardKey;
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x0600176C RID: 5996 RVA: 0x00029DCF File Offset: 0x00028DCF
		public BlackBoardChannel Channel
		{
			get
			{
				return this.channel;
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x0600176D RID: 5997 RVA: 0x00029DD7 File Offset: 0x00028DD7
		public uint BlackboardKey
		{
			get
			{
				return this.blackboardKey;
			}
		}

		// Token: 0x040005B7 RID: 1463
		private readonly BlackBoardChannel channel;

		// Token: 0x040005B8 RID: 1464
		private readonly uint blackboardKey;
	}
}
