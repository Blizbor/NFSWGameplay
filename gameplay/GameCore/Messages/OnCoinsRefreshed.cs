using System;
using EASharp;

namespace GameCore.Messages
{
	// Token: 0x02000258 RID: 600
	[Export]
	public class OnCoinsRefreshed : Message
	{
		// Token: 0x06001828 RID: 6184 RVA: 0x0002B265 File Offset: 0x0002A265
		public OnCoinsRefreshed(int Seed, uint NumCoins, int CoinsCollected, int ForceBucket)
		{
			this.seed = Seed;
			this.coinsCollected = (uint)CoinsCollected;
			this.forceBucket = ForceBucket;
			this.numCoins = ((ForceBucket >= 0) ? 99u : NumCoins);
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06001829 RID: 6185 RVA: 0x0002B293 File Offset: 0x0002A293
		public override uint Kind
		{
			get
			{
				return OnCoinsRefreshed.KindHash;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x0600182A RID: 6186 RVA: 0x0002B29A File Offset: 0x0002A29A
		public int Seed
		{
			get
			{
				return this.seed;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x0600182B RID: 6187 RVA: 0x0002B2A2 File Offset: 0x0002A2A2
		public uint CoinsCollected
		{
			get
			{
				return this.coinsCollected;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x0600182C RID: 6188 RVA: 0x0002B2AA File Offset: 0x0002A2AA
		public uint NumCoins
		{
			get
			{
				return this.numCoins;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x0600182D RID: 6189 RVA: 0x0002B2B2 File Offset: 0x0002A2B2
		public int ForcedBucket
		{
			get
			{
				return this.forceBucket;
			}
		}

		// Token: 0x040005F0 RID: 1520
		private static uint KindHash = Hash.Hash32("GameCore.Messages.OnCoinsRefreshed");

		// Token: 0x040005F1 RID: 1521
		private readonly int seed;

		// Token: 0x040005F2 RID: 1522
		private readonly int forceBucket;

		// Token: 0x040005F3 RID: 1523
		private readonly uint numCoins;

		// Token: 0x040005F4 RID: 1524
		private readonly uint coinsCollected;
	}
}
