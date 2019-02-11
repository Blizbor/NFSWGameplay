using System;
using System.Collections.Generic;
using GameCore.Workflow;
using UMath;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x020001A1 RID: 417
	public class WarpTo : Component
	{
		// Token: 0x060013DC RID: 5084 RVA: 0x0001D020 File Offset: 0x0001C020
		public WarpTo(InstancedEvent @event, EntrantInfo entrant) : base(@event, entrant)
		{
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x0001D02A File Offset: 0x0001C02A
		protected internal override void Execute(ActivityExecutionContext context)
		{
			base.Entrant.Opponent.Vehicle.WarpTo(this.Position.Value, this.Direction.Value, this.Mps.Value);
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x0001D062 File Offset: 0x0001C062
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x0001D064 File Offset: 0x0001C064
		public override string ToString()
		{
			return string.Format("WarpTo: {0} - {1} {2} {3}", new object[]
			{
				base.Entrant,
				this.position.Value,
				this.direction.Value,
				this.mps.Value
			});
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060013E0 RID: 5088 RVA: 0x0001D0BB File Offset: 0x0001C0BB
		// (set) Token: 0x060013E1 RID: 5089 RVA: 0x0001D0C3 File Offset: 0x0001C0C3
		public InArgument<Vector3> Position
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

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060013E2 RID: 5090 RVA: 0x0001D0CC File Offset: 0x0001C0CC
		// (set) Token: 0x060013E3 RID: 5091 RVA: 0x0001D0D4 File Offset: 0x0001C0D4
		public InArgument<Vector3> Direction
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

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060013E4 RID: 5092 RVA: 0x0001D0DD File Offset: 0x0001C0DD
		// (set) Token: 0x060013E5 RID: 5093 RVA: 0x0001D0E5 File Offset: 0x0001C0E5
		public InArgument<float> Mps
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

		// Token: 0x040004A3 RID: 1187
		private InArgument<Vector3> position;

		// Token: 0x040004A4 RID: 1188
		private InArgument<Vector3> direction;

		// Token: 0x040004A5 RID: 1189
		private InArgument<float> mps;
	}
}
