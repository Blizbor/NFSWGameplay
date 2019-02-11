using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x02000175 RID: 373
	public class EntrantBustedAudio : Component
	{
		// Token: 0x06001337 RID: 4919 RVA: 0x0001BBF8 File Offset: 0x0001ABF8
		public EntrantBustedAudio(InstancedEvent evnt, EntrantInfo entrant) : base(evnt, entrant)
		{
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x0001BC02 File Offset: 0x0001AC02
		protected internal override void Execute(ActivityExecutionContext context)
		{
			Audio.EntrantBusted(base.Entrant.Opponent.InternalOpponent);
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x0001BC19 File Offset: 0x0001AC19
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
