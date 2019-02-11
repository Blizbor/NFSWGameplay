using System;

namespace GameCore.Opponents
{
	// Token: 0x02000201 RID: 513
	public class LocalArtificalOpponent : LocalOpponent
	{
		// Token: 0x06001598 RID: 5528 RVA: 0x0002613D File Offset: 0x0002513D
		public LocalArtificalOpponent(uint characterKey, InternalLocalArtificalOpponent internalOpponent) : base(internalOpponent)
		{
			this.characterKey = characterKey;
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06001599 RID: 5529 RVA: 0x0002614D File Offset: 0x0002514D
		protected InternalLocalArtificalOpponent InternalLocalArtificalOpponent
		{
			get
			{
				return base.InternalOpponent as InternalLocalArtificalOpponent;
			}
		}

		// Token: 0x04000517 RID: 1303
		private readonly uint characterKey;
	}
}
