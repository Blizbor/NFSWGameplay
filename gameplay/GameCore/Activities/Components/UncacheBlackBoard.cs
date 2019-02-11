using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x02000160 RID: 352
	public class UncacheBlackBoard : WorkflowElement
	{
		// Token: 0x060012E3 RID: 4835 RVA: 0x0001B17A File Offset: 0x0001A17A
		public UncacheBlackBoard(BlackBoardChannel channel)
		{
			this.channel = channel;
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x0001B189 File Offset: 0x0001A189
		protected internal override void Execute(ActivityExecutionContext context)
		{
			BlackBoard.Get().Change(this.channel, this.BlackboardKey.Value);
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x0001B1A6 File Offset: 0x0001A1A6
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x0001B1A8 File Offset: 0x0001A1A8
		public override string ToString()
		{
			return string.Format("ChangeBlackBoard: {0} -> {1}", this.channel.ToString(), this.BlackboardKey);
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060012E7 RID: 4839 RVA: 0x0001B1CA File Offset: 0x0001A1CA
		// (set) Token: 0x060012E8 RID: 4840 RVA: 0x0001B1D2 File Offset: 0x0001A1D2
		public InArgument<uint> BlackboardKey { get; set; }

		// Token: 0x0400045A RID: 1114
		private readonly BlackBoardChannel channel;
	}
}
