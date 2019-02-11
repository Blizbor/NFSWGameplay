using System;
using System.Collections.Generic;
using Attrib.Gen;
using GameCore.Messages;
using GameCore.Opponents;
using GameCore.Scoring;
using GameCore.Workflow;
using Skills;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x0200019B RID: 411
	public class TryPerfectLaunch : Component
	{
		// Token: 0x060013C5 RID: 5061 RVA: 0x0001CD1E File Offset: 0x0001BD1E
		public TryPerfectLaunch(InstancedEvent evnt, EntrantInfo entrant) : base(evnt, entrant)
		{
		}

		// Token: 0x060013C6 RID: 5062 RVA: 0x0001CD28 File Offset: 0x0001BD28
		protected internal unsafe override void Execute(ActivityExecutionContext context)
		{
			IPerfectStart perfectStart = base.Entrant.ScoringState as IPerfectStart;
			if (perfectStart == null)
			{
				return;
			}
			LocalHumanOpponent localHumanOpponent = base.Entrant.Opponent as LocalHumanOpponent;
			if (localHumanOpponent == null)
			{
				return;
			}
			bool flag = false;
			float duration = 0f;
			bool flag2 = localHumanOpponent.Vehicle.TryPerfectLaunch(&duration, &flag);
			if (!flag)
			{
				perfectStart.PerfectStart = PerfectStart.kPerfectStart_Unlearned;
				return;
			}
			if (!flag2)
			{
				perfectStart.PerfectStart = PerfectStart.kPerfectStart_Fail;
				return;
			}
			perfectStart.PerfectStart = PerfectStart.kPerfectStart_Success;
			float torque = 0f;
			powerup_gamegroup powerup_gamegroup = new powerup_gamegroup(3423076689u);
			if (powerup_gamegroup.Num_magnitude() > 0u)
			{
				float num = powerup_gamegroup.magnitude(0u);
				if (num > 1f)
				{
					torque = num - 1f;
				}
			}
			FlasherManager.Get().EnqueueFlasher(new FlasherBase(1547819931u));
			new OnPerfectLaunchAchieved(localHumanOpponent.PersonaId, duration, torque).Post(Ports.Gameplay);
			localHumanOpponent.Hud.OnPerfectLaunchAchieved((int)localHumanOpponent.PersonaId);
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x0001CE13 File Offset: 0x0001BE13
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
