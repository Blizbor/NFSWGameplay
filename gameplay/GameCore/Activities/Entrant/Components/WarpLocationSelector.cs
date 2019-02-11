using System;
using System.Collections.Generic;
using GameCore.Data;
using GameCore.Math;
using GameCore.Workflow;
using UMath;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x020001A0 RID: 416
	public class WarpLocationSelector : Component
	{
		// Token: 0x060013D2 RID: 5074 RVA: 0x0001CF47 File Offset: 0x0001BF47
		public WarpLocationSelector(InstancedEvent @event, EntrantInfo entrant) : base(@event, entrant)
		{
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x0001CF54 File Offset: 0x0001BF54
		protected internal override void Execute(ActivityExecutionContext context)
		{
			uint num = base.Event.EventDef.Num_RespawnLocation();
			if (num > 0u)
			{
				uint index = (uint)(base.Entrant.Opponent.GridIndex % (int)num);
				Collection collection = new Collection(base.Event.EventDef.RespawnLocation(index));
				this.Position.Value = CoordSys.RenderToSim(collection.Position());
				this.Rotation = collection.Rotation();
				this.Mps.Value = 0f;
			}
			this.Close();
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x0001CFD8 File Offset: 0x0001BFD8
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060013D5 RID: 5077 RVA: 0x0001CFDA File Offset: 0x0001BFDA
		// (set) Token: 0x060013D6 RID: 5078 RVA: 0x0001CFE2 File Offset: 0x0001BFE2
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

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060013D7 RID: 5079 RVA: 0x0001CFEB File Offset: 0x0001BFEB
		// (set) Token: 0x060013D8 RID: 5080 RVA: 0x0001CFF3 File Offset: 0x0001BFF3
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

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060013D9 RID: 5081 RVA: 0x0001CFFC File Offset: 0x0001BFFC
		// (set) Token: 0x060013DA RID: 5082 RVA: 0x0001D004 File Offset: 0x0001C004
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

		// Token: 0x1700014F RID: 335
		// (set) Token: 0x060013DB RID: 5083 RVA: 0x0001D00D File Offset: 0x0001C00D
		public float Rotation
		{
			set
			{
				this.direction.Value = CoordSys.Vector3Make(value);
			}
		}

		// Token: 0x040004A0 RID: 1184
		private OutArgument<UMath.Vector3> position;

		// Token: 0x040004A1 RID: 1185
		private OutArgument<UMath.Vector3> direction;

		// Token: 0x040004A2 RID: 1186
		private OutArgument<float> mps;
	}
}
