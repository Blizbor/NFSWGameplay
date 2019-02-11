using System;

namespace GameCore.Timers
{
	// Token: 0x0200020B RID: 523
	public class SecureStopWatch
	{
		// Token: 0x060015DD RID: 5597 RVA: 0x0002643C File Offset: 0x0002543C
		public SecureStopWatch()
		{
			this.Reset();
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x0002644A File Offset: 0x0002544A
		public void Start()
		{
			if (this.running)
			{
				return;
			}
			this.running = true;
			this.start = Simulation.GetSecureTick();
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x00026467 File Offset: 0x00025467
		public void Stop()
		{
			if (!this.running)
			{
				return;
			}
			this.elapsedInMilliseconds = this.ElapsedInMilliseconds;
			this.running = false;
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x00026485 File Offset: 0x00025485
		public void Reset()
		{
			if (this.running)
			{
				return;
			}
			this.start = Simulation.GetSecureTick();
			this.elapsedInMilliseconds = 0u;
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060015E1 RID: 5601 RVA: 0x000264A2 File Offset: 0x000254A2
		public uint ElapsedInMilliseconds
		{
			get
			{
				if (this.IsRunning)
				{
					return this.elapsedInMilliseconds + Simulation.GetSecureTickDifference(this.start);
				}
				return this.elapsedInMilliseconds;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060015E2 RID: 5602 RVA: 0x000264C5 File Offset: 0x000254C5
		public float ElapsedInSeconds
		{
			get
			{
				return this.ElapsedInMilliseconds / 1000f;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060015E3 RID: 5603 RVA: 0x000264D5 File Offset: 0x000254D5
		public bool IsRunning
		{
			get
			{
				return this.running;
			}
		}

		// Token: 0x04000530 RID: 1328
		private uint elapsedInMilliseconds;

		// Token: 0x04000531 RID: 1329
		private long start;

		// Token: 0x04000532 RID: 1330
		private bool running;
	}
}
