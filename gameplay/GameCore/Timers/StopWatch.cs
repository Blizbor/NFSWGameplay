using System;

namespace GameCore.Timers
{
	// Token: 0x0200020C RID: 524
	public class StopWatch
	{
		// Token: 0x060015E4 RID: 5604 RVA: 0x000264DD File Offset: 0x000254DD
		public StopWatch()
		{
			this.Reset();
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x000264EB File Offset: 0x000254EB
		public void Start()
		{
			if (this.running)
			{
				return;
			}
			this.running = true;
			this.start = Simulation.GetTick();
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x00026508 File Offset: 0x00025508
		public void Stop()
		{
			if (!this.running)
			{
				return;
			}
			this.elapsedInMilliseconds = this.ElapsedInMilliseconds;
			this.running = false;
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x00026526 File Offset: 0x00025526
		public void Reset()
		{
			if (this.running)
			{
				return;
			}
			this.start = Simulation.GetTick();
			this.elapsedInMilliseconds = 0u;
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060015E8 RID: 5608 RVA: 0x00026543 File Offset: 0x00025543
		public uint ElapsedInMilliseconds
		{
			get
			{
				if (this.IsRunning)
				{
					return this.elapsedInMilliseconds + Simulation.GetTickDifference(this.start);
				}
				return this.elapsedInMilliseconds;
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060015E9 RID: 5609 RVA: 0x00026566 File Offset: 0x00025566
		public float ElapsedInSeconds
		{
			get
			{
				return this.ElapsedInMilliseconds / 1000f;
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060015EA RID: 5610 RVA: 0x00026576 File Offset: 0x00025576
		public bool IsRunning
		{
			get
			{
				return this.running;
			}
		}

		// Token: 0x04000533 RID: 1331
		private uint elapsedInMilliseconds;

		// Token: 0x04000534 RID: 1332
		private long start;

		// Token: 0x04000535 RID: 1333
		private bool running;
	}
}
