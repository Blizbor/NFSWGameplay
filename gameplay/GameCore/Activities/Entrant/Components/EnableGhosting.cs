using System;
using System.Collections.Generic;
using GameCore.Opponents;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x02000174 RID: 372
	public class EnableGhosting : Component
	{
		// Token: 0x06001333 RID: 4915 RVA: 0x0001BB6F File Offset: 0x0001AB6F
		public EnableGhosting(InstancedEvent evnt, EntrantInfo entrant, bool enabled) : this(evnt, entrant, enabled, 0f)
		{
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x0001BB7F File Offset: 0x0001AB7F
		public EnableGhosting(InstancedEvent evnt, EntrantInfo entrant, bool enabled, float durationInSeconds) : base(evnt, entrant)
		{
			this.enabled = enabled;
			this.durationInSeconds = durationInSeconds;
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x0001BB98 File Offset: 0x0001AB98
		protected internal override void Execute(ActivityExecutionContext context)
		{
			LocalHumanOpponent localHumanOpponent = base.Entrant.Opponent as LocalHumanOpponent;
			if (localHumanOpponent != null)
			{
				Marshal.Get().EnableGhosting(this.enabled, this.durationInSeconds * 1000f);
			}
			base.Entrant.Opponent.Vehicle.EnableInvulnerability(this.enabled, this.durationInSeconds);
		}

		// Token: 0x06001336 RID: 4918 RVA: 0x0001BBF6 File Offset: 0x0001ABF6
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x0400047B RID: 1147
		private readonly bool enabled;

		// Token: 0x0400047C RID: 1148
		private readonly float durationInSeconds;
	}
}
