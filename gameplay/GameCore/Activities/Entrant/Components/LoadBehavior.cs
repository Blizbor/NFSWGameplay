using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x02000186 RID: 390
	public class LoadBehavior : Component
	{
		// Token: 0x06001374 RID: 4980 RVA: 0x0001C1F0 File Offset: 0x0001B1F0
		public LoadBehavior(InstancedEvent evnt, EntrantInfo entrant, string channel, string type) : base(evnt, entrant)
		{
			this.channel = channel;
			this.type = type;
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x0001C209 File Offset: 0x0001B209
		protected internal override void Execute(ActivityExecutionContext context)
		{
			base.Entrant.Opponent.LoadBehavior(this.channel, this.type);
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x0001C227 File Offset: 0x0001B227
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x0400048D RID: 1165
		private readonly string channel;

		// Token: 0x0400048E RID: 1166
		private readonly string type;
	}
}
