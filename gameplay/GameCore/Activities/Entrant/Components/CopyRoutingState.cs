using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x0200016D RID: 365
	public class CopyRoutingState : Component
	{
		// Token: 0x06001318 RID: 4888 RVA: 0x0001B5B6 File Offset: 0x0001A5B6
		public CopyRoutingState(InstancedEvent evnt, EntrantInfo entrant, InArgument<long> personaId) : base(evnt, entrant)
		{
			this.personaId = personaId;
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x0001B5DC File Offset: 0x0001A5DC
		protected internal override void Execute(ActivityExecutionContext context)
		{
			EntrantInfo entrantInfo = base.Event.Entrants.Find((EntrantInfo t) => t.PersonaId == this.personaId.Value);
			if (entrantInfo == null)
			{
				return;
			}
			entrantInfo.RoutingState.CopyTo(base.Entrant.RoutingState);
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x0001B621 File Offset: 0x0001A621
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x0400046B RID: 1131
		private readonly InArgument<long> personaId;
	}
}
