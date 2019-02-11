using System;
using System.Collections.Generic;
using GameCore.Messages;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x02000142 RID: 322
	public class ExtrapolateAll : WorkflowElement
	{
		// Token: 0x06001263 RID: 4707 RVA: 0x0001A84C File Offset: 0x0001984C
		protected internal override void Execute(ActivityExecutionContext context)
		{
			OnExtrapolate onExtrapolate = new OnExtrapolate();
			onExtrapolate.Post(Ports.Gameplay);
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x0001A86A File Offset: 0x0001986A
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
