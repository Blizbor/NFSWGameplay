using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x0200012B RID: 299
	public class CacheBlackBoard : WorkflowElement
	{
		// Token: 0x0600120B RID: 4619 RVA: 0x0001A17C File Offset: 0x0001917C
		public CacheBlackBoard(BlackBoardChannel channel)
		{
			this.channel = channel;
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x0001A18B File Offset: 0x0001918B
		protected internal override void Execute(ActivityExecutionContext context)
		{
			this.BlackboardKey.Value = BlackBoard.Get().GetCurrentKey(this.channel);
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x0001A1A8 File Offset: 0x000191A8
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x0001A1AA File Offset: 0x000191AA
		public override string ToString()
		{
			return string.Format("CacheBlackBoard: {0} -> {1}", this.channel.ToString(), this.BlackboardKey);
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600120F RID: 4623 RVA: 0x0001A1CC File Offset: 0x000191CC
		// (set) Token: 0x06001210 RID: 4624 RVA: 0x0001A1D4 File Offset: 0x000191D4
		public OutArgument<uint> BlackboardKey { get; set; }

		// Token: 0x04000419 RID: 1049
		private readonly BlackBoardChannel channel;
	}
}
