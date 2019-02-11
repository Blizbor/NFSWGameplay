using System;

namespace GameCore.Scoring
{
	// Token: 0x02000284 RID: 644
	public class TreasureHuntScoringState : ScoringState
	{
		// Token: 0x060019A8 RID: 6568 RVA: 0x0002EE2C File Offset: 0x0002DE2C
		public TreasureHuntScoringState()
		{
			this.Reset();
		}

		// Token: 0x060019A9 RID: 6569 RVA: 0x0002EE3A File Offset: 0x0002DE3A
		public override void Reset()
		{
			base.Reset();
		}

		// Token: 0x060019AA RID: 6570 RVA: 0x0002EE44 File Offset: 0x0002DE44
		public uint GetNumberOfCollectedCoins()
		{
			uint num = 0u;
			for (int i = 0; i < 32; i++)
			{
				if ((this.CoinsCollected & 1u << i) != 0u)
				{
					num += 1u;
				}
			}
			return num;
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x0002EE74 File Offset: 0x0002DE74
		protected override void Dispose(bool disposing)
		{
			if (!base.IsDisposed)
			{
			}
			base.Dispose(disposing);
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x060019AC RID: 6572 RVA: 0x0002EE87 File Offset: 0x0002DE87
		// (set) Token: 0x060019AD RID: 6573 RVA: 0x0002EE8F File Offset: 0x0002DE8F
		public uint CoinsCollected { get; set; }
	}
}
