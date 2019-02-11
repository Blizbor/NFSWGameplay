using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x0200012C RID: 300
	public class ChangeBlackBoard : WorkflowElement
	{
		// Token: 0x06001211 RID: 4625 RVA: 0x0001A1DD File Offset: 0x000191DD
		public ChangeBlackBoard(BlackBoardChannel channel, string blackboardName) : this(channel, Hash.Hash32(blackboardName))
		{
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x0001A1EC File Offset: 0x000191EC
		public ChangeBlackBoard(BlackBoardChannel channel, uint blackboardKey)
		{
			this.channel = channel;
			this.blackboardKey = blackboardKey;
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x0001A202 File Offset: 0x00019202
		protected internal override void Execute(ActivityExecutionContext context)
		{
			BlackBoard.Get().Change(this.channel, this.blackboardKey);
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x0001A21A File Offset: 0x0001921A
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x0001A21C File Offset: 0x0001921C
		public override string ToString()
		{
			return string.Format("ChangeBlackBoard: {0} -> {1}", this.channel.ToString(), this.blackboardKey);
		}

		// Token: 0x0400041B RID: 1051
		private readonly BlackBoardChannel channel;

		// Token: 0x0400041C RID: 1052
		private readonly uint blackboardKey;
	}
}
