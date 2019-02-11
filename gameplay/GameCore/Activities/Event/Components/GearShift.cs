using System;
using GameCore.Messages;
using GameCore.Opponents;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001C1 RID: 449
	public class GearShift : MessageHandler<OnGearShift>
	{
		// Token: 0x06001445 RID: 5189 RVA: 0x00021404 File Offset: 0x00020404
		public GearShift(InstancedEvent evnt, uint port) : base(evnt, port)
		{
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x0002140E File Offset: 0x0002040E
		protected override void OnExecute(ActivityExecutionContext context)
		{
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x00021410 File Offset: 0x00020410
		protected override void OnMessage(OnGearShift message)
		{
			EntrantInfo entrantInfo = base.Event.FindEntrant(message.PersonaId);
			if (entrantInfo != null)
			{
				if (entrantInfo.Opponent is LocalHumanOpponent)
				{
					switch (message.ShiftStatus)
					{
					case ShiftPotential.SHIFT_POTENTIAL_GOOD:
						FlasherManager.Get().EnqueueFlasher(new FlasherBase(2103729003u));
						break;
					case ShiftPotential.SHIFT_POTENTIAL_PERFECT:
						FlasherManager.Get().EnqueueFlasher(new FlasherBase(2156820684u));
						break;
					case ShiftPotential.SHIFT_POTENTIAL_OVERREV:
						FlasherManager.Get().EnqueueFlasher(new FlasherBase(3187619114u));
						Audio.PlaySound("DRAGRACE_OVERREV");
						Audio.SendMixTrigger("DRAGMODE_OVERREV", -1);
						break;
					}
				}
				if (message.ShiftStatus == ShiftPotential.SHIFT_POTENTIAL_PERFECT)
				{
					entrantInfo.Opponent.Vehicle.PerfectShift(0.4f, 1f);
				}
			}
		}

		// Token: 0x040004C1 RID: 1217
		private const float kDragPerfectShiftNOSTime = 0.4f;

		// Token: 0x040004C2 RID: 1218
		private const float kDragPerfectShiftNOSTorque = 1f;

		// Token: 0x040004C3 RID: 1219
		private const string OverRevSound = "DRAGRACE_OVERREV";

		// Token: 0x040004C4 RID: 1220
		private const string OverRevMixTrigger = "DRAGMODE_OVERREV";
	}
}
