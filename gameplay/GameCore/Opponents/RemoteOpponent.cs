using System;

namespace GameCore.Opponents
{
	// Token: 0x02000203 RID: 515
	public abstract class RemoteOpponent : Opponent
	{
		// Token: 0x060015A4 RID: 5540 RVA: 0x00026228 File Offset: 0x00025228
		public RemoteOpponent(InternalOpponent internalOpponent) : base(internalOpponent)
		{
		}
	}
}
