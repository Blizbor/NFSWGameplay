using System;
using GameCore.Messages;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001CA RID: 458
	public class PerfectLaunchAchieved : MessageHandler<OnPerfectLaunchAchieved>
	{
		// Token: 0x0600146F RID: 5231 RVA: 0x00021D0B File Offset: 0x00020D0B
		public PerfectLaunchAchieved(InstancedEvent evnt, uint port) : base(evnt, port)
		{
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x00021D15 File Offset: 0x00020D15
		protected override void OnExecute(ActivityExecutionContext context)
		{
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x00021D18 File Offset: 0x00020D18
		protected override void OnMessage(OnPerfectLaunchAchieved message)
		{
			EntrantInfo entrantInfo = base.Event.FindEntrant(message.PersonaId);
			if (entrantInfo != null)
			{
				entrantInfo.Opponent.Vehicle.PerfectLaunch(message.Duration, message.Torque);
			}
		}
	}
}
