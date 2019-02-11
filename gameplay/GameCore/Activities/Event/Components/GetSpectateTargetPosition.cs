using System;
using System.Collections.Generic;
using GameCore.Math;
using GameCore.Opponents;
using GameCore.Workflow;
using UMath;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001C2 RID: 450
	public class GetSpectateTargetPosition : Component<InstancedEvent>
	{
		// Token: 0x06001448 RID: 5192 RVA: 0x000214DA File Offset: 0x000204DA
		public GetSpectateTargetPosition(InstancedEvent evnt) : base(evnt)
		{
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x000214E4 File Offset: 0x000204E4
		protected internal override void Execute(ActivityExecutionContext context)
		{
			if (base.Event.SpectateMethod != null && base.Event.SpectateMethod.Target != null && !(base.Event.SpectateMethod.Target.Opponent is LocalHumanOpponent))
			{
				this.spectateTargetPersonaId.Value = base.Event.SpectateMethod.Target.PersonaId;
				this.position.Value = base.Event.SpectateMethod.Target.Opponent.InternalOpponent.GetWrappedVehicle().GetPosition();
				this.direction.Value = base.Event.SpectateMethod.Target.Opponent.InternalOpponent.GetWrappedVehicle().GetDirection();
				this.mps.Value = base.Event.SpectateMethod.Target.Opponent.InternalOpponent.GetWrappedVehicle().GetSpeed() * base.Event.EventDef.RespawnSpeedMultiplier();
			}
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x000215F3 File Offset: 0x000205F3
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600144B RID: 5195 RVA: 0x000215F5 File Offset: 0x000205F5
		// (set) Token: 0x0600144C RID: 5196 RVA: 0x000215FD File Offset: 0x000205FD
		public OutArgument<UMath.Vector3> Position
		{
			get
			{
				return this.position;
			}
			set
			{
				this.position = value;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600144D RID: 5197 RVA: 0x00021606 File Offset: 0x00020606
		// (set) Token: 0x0600144E RID: 5198 RVA: 0x0002160E File Offset: 0x0002060E
		public OutArgument<UMath.Vector3> Direction
		{
			get
			{
				return this.direction;
			}
			set
			{
				this.direction = value;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600144F RID: 5199 RVA: 0x00021617 File Offset: 0x00020617
		// (set) Token: 0x06001450 RID: 5200 RVA: 0x0002161F File Offset: 0x0002061F
		public OutArgument<long> SpectateTargetPersonaId
		{
			get
			{
				return this.spectateTargetPersonaId;
			}
			set
			{
				this.spectateTargetPersonaId = value;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06001451 RID: 5201 RVA: 0x00021628 File Offset: 0x00020628
		// (set) Token: 0x06001452 RID: 5202 RVA: 0x00021630 File Offset: 0x00020630
		public OutArgument<float> Mps
		{
			get
			{
				return this.mps;
			}
			set
			{
				this.mps = value;
			}
		}

		// Token: 0x1700015D RID: 349
		// (set) Token: 0x06001453 RID: 5203 RVA: 0x00021639 File Offset: 0x00020639
		public float Rotation
		{
			set
			{
				this.direction.Value = CoordSys.Vector3Make(value);
			}
		}

		// Token: 0x040004C5 RID: 1221
		private OutArgument<UMath.Vector3> position;

		// Token: 0x040004C6 RID: 1222
		private OutArgument<UMath.Vector3> direction;

		// Token: 0x040004C7 RID: 1223
		private OutArgument<long> spectateTargetPersonaId;

		// Token: 0x040004C8 RID: 1224
		private OutArgument<float> mps;
	}
}
