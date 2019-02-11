using System;
using EASharp;

namespace GameCore.Security
{
	// Token: 0x02000207 RID: 519
	[Export]
	public class PhysicsMetrics
	{
		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060015C0 RID: 5568 RVA: 0x00026337 File Offset: 0x00025337
		// (set) Token: 0x060015C1 RID: 5569 RVA: 0x0002633F File Offset: 0x0002533F
		public float AccelerationAverage { get; set; }

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060015C2 RID: 5570 RVA: 0x00026348 File Offset: 0x00025348
		// (set) Token: 0x060015C3 RID: 5571 RVA: 0x00026350 File Offset: 0x00025350
		public float AccelerationMaximum { get; set; }

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060015C4 RID: 5572 RVA: 0x00026359 File Offset: 0x00025359
		// (set) Token: 0x060015C5 RID: 5573 RVA: 0x00026361 File Offset: 0x00025361
		public float AccelerationMedian { get; set; }

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060015C6 RID: 5574 RVA: 0x0002636A File Offset: 0x0002536A
		// (set) Token: 0x060015C7 RID: 5575 RVA: 0x00026372 File Offset: 0x00025372
		public float SpeedAverage { get; set; }

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060015C8 RID: 5576 RVA: 0x0002637B File Offset: 0x0002537B
		// (set) Token: 0x060015C9 RID: 5577 RVA: 0x00026383 File Offset: 0x00025383
		public float SpeedMaximum { get; set; }

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060015CA RID: 5578 RVA: 0x0002638C File Offset: 0x0002538C
		// (set) Token: 0x060015CB RID: 5579 RVA: 0x00026394 File Offset: 0x00025394
		public float SpeedMedian { get; set; }
	}
}
