using System;
using GameCore.Math;
using GameCore.Opponents;
using GameCore.Workflow;
using GameCore.Workflow.Activities;

namespace GameCore.Activities.Components
{
	// Token: 0x02000161 RID: 353
	public class VehicleSpeedBasedReset : SimulationTick
	{
		// Token: 0x060012E9 RID: 4841 RVA: 0x0001B1DB File Offset: 0x0001A1DB
		public VehicleSpeedBasedReset(EntrantInfo entrant, float period) : base(period)
		{
			this.mEntrant = entrant;
			this.mHighestSpeedSeen = 0f;
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x0001B216 File Offset: 0x0001A216
		protected override void OnExecute(ActivityExecutionContext context)
		{
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x0001B218 File Offset: 0x0001A218
		protected override void Tick(float dT)
		{
			LocalHumanOpponent localHumanOpponent = Engine.Get().OpponentManager().FindLocalOpponent();
			if (this.mEntrant.Opponent is LocalHumanOpponent)
			{
				float speed = localHumanOpponent.Vehicle.GetSpeed();
				this.mHighestSpeedSeen = System.Math.Max(this.mHighestSpeedSeen, speed);
				bool flag = speed < this.Tweak_DragSpeedResetThreshold_Low && this.mHighestSpeedSeen >= this.Tweak_DragSpeedResetThreshold_High;
				bool flag2 = localHumanOpponent.Vehicle.IsFacingWrongWay();
				if (flag || (flag2 && speed > Conversions.MPH2MPS(3f)))
				{
					localHumanOpponent.Vehicle.ResetVehicle();
					this.mHighestSpeedSeen = 0f;
				}
			}
		}

		// Token: 0x0400045C RID: 1116
		private float Tweak_DragSpeedResetThreshold_Low = Conversions.MPH2MPS(5f);

		// Token: 0x0400045D RID: 1117
		private float Tweak_DragSpeedResetThreshold_High = Conversions.MPH2MPS(50f);

		// Token: 0x0400045E RID: 1118
		private EntrantInfo mEntrant;

		// Token: 0x0400045F RID: 1119
		private float mHighestSpeedSeen;
	}
}
