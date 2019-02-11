using System;
using GameCore.Messages;
using GameCore.Opponents;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x0200017F RID: 383
	public class HandleTutorial : MessageHandler<OnExitTutorial>
	{
		// Token: 0x0600135E RID: 4958 RVA: 0x0001C007 File Offset: 0x0001B007
		public HandleTutorial(InstancedEvent evnt, EntrantInfo entrant, TutorialSource source) : base(evnt, entrant, Ports.Gameplay)
		{
			this.source = source;
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x0001C020 File Offset: 0x0001B020
		protected override void OnExecute(ActivityExecutionContext context)
		{
			LocalHumanOpponent localHumanOpponent = base.Entrant.Opponent as LocalHumanOpponent;
			if (localHumanOpponent != null)
			{
				if (Marshal.Get().IsTutorialComplete(this.source))
				{
					this.Close();
					return;
				}
				if (!Marshal.Get().HandleTutorial(this.source))
				{
					this.Close();
				}
			}
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x0001C072 File Offset: 0x0001B072
		protected override void OnMessage(OnExitTutorial message)
		{
			this.Close();
		}

		// Token: 0x04000487 RID: 1159
		private TutorialSource source;
	}
}
