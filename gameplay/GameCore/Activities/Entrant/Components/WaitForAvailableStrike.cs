using System;
using GameCore.Messages;
using GameCore.Scoring;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x0200019E RID: 414
	public class WaitForAvailableStrike : MessageHandler<OnFinalStrike>
	{
		// Token: 0x060013CC RID: 5068 RVA: 0x0001CE5C File Offset: 0x0001BE5C
		public WaitForAvailableStrike(InstancedEvent evnt, EntrantInfo entrant, uint port) : base(evnt, entrant, port)
		{
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x0001CE68 File Offset: 0x0001BE68
		protected override void OnExecute(ActivityExecutionContext context)
		{
			int num = 0;
			foreach (EntrantInfo entrantInfo in base.InstancedEvent.Entrants)
			{
				num += (entrantInfo.ScoringState as TeamEscapeScoringState).Busts;
			}
			TeamEscapeScoringState teamEscapeScoringState = base.Entrant.ScoringState as TeamEscapeScoringState;
			if (teamEscapeScoringState != null && num < base.InstancedEvent.NumStrikes)
			{
				teamEscapeScoringState.Busts++;
				this.Close();
			}
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x0001CF04 File Offset: 0x0001BF04
		protected override void OnMessage(OnFinalStrike message)
		{
		}
	}
}
