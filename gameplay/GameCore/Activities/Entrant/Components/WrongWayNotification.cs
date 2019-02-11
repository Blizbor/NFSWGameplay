using System;
using GameCore.Opponents;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x020001A2 RID: 418
	public class WrongWayNotification : SimulationTick
	{
		// Token: 0x060013E6 RID: 5094 RVA: 0x0001D0EE File Offset: 0x0001C0EE
		public WrongWayNotification(InstancedEvent @event, EntrantInfo entrant) : base(@event, entrant, 1f)
		{
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x0001D10F File Offset: 0x0001C10F
		protected override void OnExecute(ActivityExecutionContext context)
		{
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x0001D114 File Offset: 0x0001C114
		protected internal override void Close()
		{
			LocalHumanOpponent localHumanOpponent = base.Entrant.Opponent as LocalHumanOpponent;
			if (localHumanOpponent != null)
			{
				FlasherManager.Get().DequeueFlasher(this.flasher_handle);
			}
			this.duration = -1f;
			base.Close();
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x0001D158 File Offset: 0x0001C158
		protected override void Tick(float dT)
		{
			LocalHumanOpponent localHumanOpponent = base.Entrant.Opponent as LocalHumanOpponent;
			if (localHumanOpponent != null)
			{
				if (localHumanOpponent.Vehicle.IsFacingWrongWay() && Math.Abs(localHumanOpponent.Vehicle.GetSpeed()) > 3f)
				{
					if (this.duration < 0f)
					{
						this.flasher_handle = FlasherManager.Get().EnqueueFlasher(new FlasherBase(133813668u));
						this.duration = 0f;
					}
					this.duration += dT;
					return;
				}
				if (this.duration > 0f)
				{
					FlasherManager.Get().DequeueFlasher(this.flasher_handle);
					this.flasher_handle = -1;
					this.duration = -1f;
				}
			}
		}

		// Token: 0x040004A6 RID: 1190
		private float duration = -1f;

		// Token: 0x040004A7 RID: 1191
		private int flasher_handle = -1;
	}
}
