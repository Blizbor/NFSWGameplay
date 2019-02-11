using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001D1 RID: 465
	public class RefreshCoins : Component<Event>
	{
		// Token: 0x06001489 RID: 5257 RVA: 0x000222D6 File Offset: 0x000212D6
		public RefreshCoins(Event @event) : base(@event)
		{
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x000222DF File Offset: 0x000212DF
		protected internal override void Execute(ActivityExecutionContext context)
		{
			InternalEvent.RefreshCoins();
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x000222E6 File Offset: 0x000212E6
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
