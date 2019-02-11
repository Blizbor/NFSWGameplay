using System;
using System.Collections.Generic;
using Attrib.Gen;
using GameCore.Math;
using GameCore.Messages;
using GameCore.Opponents;
using GameCore.Scoring;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x0200018D RID: 397
	public class RadialBustMeterLogic : SimulationTick
	{
		// Token: 0x0600138D RID: 5005 RVA: 0x0001C52E File Offset: 0x0001B52E
		public RadialBustMeterLogic(InstancedEvent evnt, EntrantInfo entrant) : base(evnt, entrant, 0.1f)
		{
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x0001C540 File Offset: 0x0001B540
		protected override void OnExecute(ActivityExecutionContext context)
		{
			IPursuit pursuit = base.Entrant.ScoringState as IPursuit;
			if (pursuit != null)
			{
				pursuit.PursuitBar = 0f;
			}
		}

		// Token: 0x0600138F RID: 5007 RVA: 0x0001C56C File Offset: 0x0001B56C
		protected override void Tick(float dT)
		{
			IPursuit pursuit = base.Entrant.ScoringState as IPursuit;
			LocalHumanOpponent localHumanOpponent = base.Entrant.Opponent as LocalHumanOpponent;
			if (pursuit != null && localHumanOpponent != null)
			{
				float speed = base.Entrant.Opponent.Vehicle.GetSpeed();
				pursuitlevels pursuitlevels = new pursuitlevels(localHumanOpponent.PursuitData.GetPursuitLevelKey());
				float val = pursuitlevels.MeterMinBustRadius();
				float num = pursuitlevels.MeterMaxBustRadius();
				float mph_ = pursuitlevels.MeterBustRadiusSpeedThreshold();
				float num2 = pursuitlevels.MeterMinEvadeRadius();
				float num3 = pursuitlevels.MeterBustIncrement();
				float num4 = pursuitlevels.MeterBustDecrement();
				int val2 = (int)pursuitlevels.MeterMaxNumCopsBustMultiplier();
				float num5 = System.Math.Min(1f - speed / Conversions.MPH2MPS(mph_), 1f);
				float num6 = System.Math.Max(val, num * num5);
				float radius = num6 + num2;
				int numCopsInRadius = Cops.GetNumCopsInRadius((eCopCountIncludeFlags)455, base.Entrant.Opponent.Vehicle.GetPosition(), num6);
				int numCopsInRadius2 = Cops.GetNumCopsInRadius((eCopCountIncludeFlags)455, base.Entrant.Opponent.Vehicle.GetPosition(), radius);
				if (numCopsInRadius > 0)
				{
					pursuit.PursuitBar += num3 * (float)System.Math.Min(numCopsInRadius, val2);
				}
				else if (numCopsInRadius2 == 0)
				{
					pursuit.PursuitBar -= num4;
				}
				pursuit.PursuitBar = System.Math.Max(pursuit.PursuitBar, 0f);
				if (pursuit.PursuitBar >= 1f)
				{
					pursuit.PursuitBar = System.Math.Min(pursuit.PursuitBar, 1f);
					new OnPursuitBusted(base.Entrant.PersonaId).Post(Ports.Gameplay);
				}
			}
		}

		// Token: 0x06001390 RID: 5008 RVA: 0x0001C709 File Offset: 0x0001B709
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}
