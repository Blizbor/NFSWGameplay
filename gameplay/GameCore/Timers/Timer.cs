using System;
using System.Collections.Generic;

namespace GameCore.Timers
{
	// Token: 0x0200020F RID: 527
	public class Timer : Listable<Timer>
	{
		// Token: 0x060015F1 RID: 5617 RVA: 0x00026658 File Offset: 0x00025658
		public static void Update()
		{
			Timer.TimerInfo[] array = new Timer.TimerInfo[Timer.ScheduledTimers.Count];
			Timer.ScheduledTimers.CopyTo(array);
			foreach (Timer.TimerInfo timerInfo in array)
			{
				float num = (float)TimeSpan.FromMilliseconds(Simulation.GetTickDifference(timerInfo.StartTick)).TotalSeconds;
				if (timerInfo.Timer == null)
				{
					Timer.ScheduledTimers.Remove(timerInfo);
				}
				if (num >= timerInfo.Timer.Interval)
				{
					timerInfo.Timer.OnElapsed();
				}
			}
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x000266E4 File Offset: 0x000256E4
		private static void Insert(float timeFromNow, Timer timer)
		{
			Timer.TimerInfo item = new Timer.TimerInfo
			{
				StartTick = Simulation.GetTick(),
				Timer = timer
			};
			Timer.ScheduledTimers.Add(item);
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x00026730 File Offset: 0x00025730
		private static void Remove(Timer timer)
		{
			Timer.TimerInfo timerInfo = Timer.ScheduledTimers.Find((Timer.TimerInfo pair) => pair.Timer == timer);
			if (timerInfo != null)
			{
				timerInfo.Timer = null;
				Timer.ScheduledTimers.Remove(timerInfo);
			}
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x00026777 File Offset: 0x00025777
		public Timer(float interval)
		{
			this.interval = interval;
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x00026786 File Offset: 0x00025786
		public void Start()
		{
			this.Enabled = true;
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x0002678F File Offset: 0x0002578F
		public void Stop()
		{
			this.Enabled = false;
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x00026798 File Offset: 0x00025798
		public void Reset()
		{
			Timer.Remove(this);
			if (this.Enabled)
			{
				Timer.Insert(this.interval, this);
			}
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x000267B4 File Offset: 0x000257B4
		private void OnElapsed()
		{
			if (this.Elapsed != null)
			{
				this.Elapsed(this, EventArgs.Empty);
			}
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x000267CF File Offset: 0x000257CF
		protected override void Dispose(bool disposing)
		{
			Timer.Remove(this);
			this.Elapsed = null;
			base.Dispose(disposing);
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060015FA RID: 5626 RVA: 0x000267E5 File Offset: 0x000257E5
		// (remove) Token: 0x060015FB RID: 5627 RVA: 0x000267FE File Offset: 0x000257FE
		public event EventHandler Elapsed;

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060015FC RID: 5628 RVA: 0x00026817 File Offset: 0x00025817
		// (set) Token: 0x060015FD RID: 5629 RVA: 0x0002681F File Offset: 0x0002581F
		public bool Enabled
		{
			get
			{
				return this.enabled;
			}
			set
			{
				if (this.enabled != value)
				{
					this.enabled = value;
					this.Reset();
				}
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060015FE RID: 5630 RVA: 0x00026837 File Offset: 0x00025837
		// (set) Token: 0x060015FF RID: 5631 RVA: 0x0002683F File Offset: 0x0002583F
		public float Interval
		{
			get
			{
				return this.interval;
			}
			set
			{
				this.interval = value;
				this.Reset();
			}
		}

		// Token: 0x04000538 RID: 1336
		private static List<Timer.TimerInfo> ScheduledTimers = new List<Timer.TimerInfo>();

		// Token: 0x04000539 RID: 1337
		private bool enabled;

		// Token: 0x0400053A RID: 1338
		private float interval;

		// Token: 0x02000210 RID: 528
		private class TimerInfo
		{
			// Token: 0x170001B2 RID: 434
			// (get) Token: 0x06001601 RID: 5633 RVA: 0x0002685A File Offset: 0x0002585A
			// (set) Token: 0x06001602 RID: 5634 RVA: 0x00026862 File Offset: 0x00025862
			public long StartTick { get; set; }

			// Token: 0x170001B3 RID: 435
			// (get) Token: 0x06001603 RID: 5635 RVA: 0x0002686B File Offset: 0x0002586B
			// (set) Token: 0x06001604 RID: 5636 RVA: 0x00026873 File Offset: 0x00025873
			public Timer Timer { get; set; }
		}
	}
}
