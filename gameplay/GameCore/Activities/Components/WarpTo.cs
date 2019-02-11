using System;
using System.Collections.Generic;
using GameCore.Math;
using GameCore.Workflow;
using UMath;

namespace GameCore.Activities.Components
{
	// Token: 0x02000164 RID: 356
	public class WarpTo : WorkflowElement
	{
		// Token: 0x060012F3 RID: 4851 RVA: 0x0001B313 File Offset: 0x0001A313
		protected internal override void Execute(ActivityExecutionContext context)
		{
			this.vehicle.WarpTo(this.Position, this.Direction, this.Mps);
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x0001B332 File Offset: 0x0001A332
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060012F5 RID: 4853 RVA: 0x0001B334 File Offset: 0x0001A334
		// (set) Token: 0x060012F6 RID: 4854 RVA: 0x0001B33C File Offset: 0x0001A33C
		public Vehicle Vehicle
		{
			get
			{
				return this.vehicle;
			}
			set
			{
				this.vehicle = value;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060012F7 RID: 4855 RVA: 0x0001B345 File Offset: 0x0001A345
		// (set) Token: 0x060012F8 RID: 4856 RVA: 0x0001B34D File Offset: 0x0001A34D
		public UMath.Vector3 Position
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

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060012F9 RID: 4857 RVA: 0x0001B356 File Offset: 0x0001A356
		// (set) Token: 0x060012FA RID: 4858 RVA: 0x0001B35E File Offset: 0x0001A35E
		public UMath.Vector3 Direction
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

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060012FB RID: 4859 RVA: 0x0001B367 File Offset: 0x0001A367
		// (set) Token: 0x060012FC RID: 4860 RVA: 0x0001B36F File Offset: 0x0001A36F
		public float Mps
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

		// Token: 0x1700013C RID: 316
		// (set) Token: 0x060012FD RID: 4861 RVA: 0x0001B378 File Offset: 0x0001A378
		public float Rotation
		{
			set
			{
				this.direction = CoordSys.Vector3Make(value);
			}
		}

		// Token: 0x04000461 RID: 1121
		private UMath.Vector3 position = UMath.Vector3.kZero;

		// Token: 0x04000462 RID: 1122
		private UMath.Vector3 direction = UMath.Vector3.kZero;

		// Token: 0x04000463 RID: 1123
		private float mps;

		// Token: 0x04000464 RID: 1124
		private Vehicle vehicle;
	}
}
