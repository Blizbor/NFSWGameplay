using System;
using GameCore.Timers;
using Skills;

namespace GameCore.Scoring
{
	// Token: 0x02000280 RID: 640
	public class RouteScoringState : ScoringState, IPerfectStart
	{
		// Token: 0x06001926 RID: 6438 RVA: 0x0002D031 File Offset: 0x0002C031
		public RouteScoringState()
		{
			this.Reset();
		}

		// Token: 0x06001927 RID: 6439 RVA: 0x0002D054 File Offset: 0x0002C054
		public override void Reset()
		{
			base.Reset();
			this.lapTimer.Reset();
			this.currentLap = (this.numOpponentsTagged = 0);
			this.topSpeed = (this.fractionCompleted = (this.distanceToStartLine = 0f));
			this.LongestAirTimeInMilliseconds = 0u;
			this.bestLapDurationInMilliseconds = uint.MaxValue;
			this.perfectStart = PerfectStart.kPerfectStart_Unlearned;
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06001928 RID: 6440 RVA: 0x0002D0B4 File Offset: 0x0002C0B4
		public StopWatch LapTimer
		{
			get
			{
				return this.lapTimer;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06001929 RID: 6441 RVA: 0x0002D0BC File Offset: 0x0002C0BC
		// (set) Token: 0x0600192A RID: 6442 RVA: 0x0002D0C4 File Offset: 0x0002C0C4
		public int CurrentLap
		{
			get
			{
				return this.currentLap;
			}
			set
			{
				this.currentLap = value;
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x0600192B RID: 6443 RVA: 0x0002D0CD File Offset: 0x0002C0CD
		// (set) Token: 0x0600192C RID: 6444 RVA: 0x0002D0D5 File Offset: 0x0002C0D5
		public float FractionCompleted
		{
			get
			{
				return this.fractionCompleted;
			}
			set
			{
				this.fractionCompleted = value;
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x0600192D RID: 6445 RVA: 0x0002D0DE File Offset: 0x0002C0DE
		// (set) Token: 0x0600192E RID: 6446 RVA: 0x0002D0E6 File Offset: 0x0002C0E6
		public float TopSpeed
		{
			get
			{
				return this.topSpeed;
			}
			set
			{
				this.topSpeed = value;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x0600192F RID: 6447 RVA: 0x0002D0EF File Offset: 0x0002C0EF
		// (set) Token: 0x06001930 RID: 6448 RVA: 0x0002D0F7 File Offset: 0x0002C0F7
		public uint BestLapDurationInMilliseconds
		{
			get
			{
				return this.bestLapDurationInMilliseconds;
			}
			set
			{
				this.bestLapDurationInMilliseconds = value;
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06001931 RID: 6449 RVA: 0x0002D100 File Offset: 0x0002C100
		public float BestLapDurationInSeconds
		{
			get
			{
				return this.BestLapDurationInMilliseconds / 1000f;
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06001932 RID: 6450 RVA: 0x0002D110 File Offset: 0x0002C110
		// (set) Token: 0x06001933 RID: 6451 RVA: 0x0002D118 File Offset: 0x0002C118
		public float DistanceToStartLine
		{
			get
			{
				return this.distanceToStartLine;
			}
			set
			{
				this.distanceToStartLine = value;
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06001934 RID: 6452 RVA: 0x0002D121 File Offset: 0x0002C121
		// (set) Token: 0x06001935 RID: 6453 RVA: 0x0002D129 File Offset: 0x0002C129
		public uint LongestAirTimeInMilliseconds { get; set; }

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06001936 RID: 6454 RVA: 0x0002D132 File Offset: 0x0002C132
		// (set) Token: 0x06001937 RID: 6455 RVA: 0x0002D142 File Offset: 0x0002C142
		public float LongestAirTimeInSeconds
		{
			get
			{
				return this.LongestAirTimeInMilliseconds / 1000f;
			}
			set
			{
				this.LongestAirTimeInMilliseconds = (uint)(value * 1000f);
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06001938 RID: 6456 RVA: 0x0002D152 File Offset: 0x0002C152
		// (set) Token: 0x06001939 RID: 6457 RVA: 0x0002D15A File Offset: 0x0002C15A
		public uint SumAirTimeInMilliseconds { get; set; }

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x0600193A RID: 6458 RVA: 0x0002D163 File Offset: 0x0002C163
		// (set) Token: 0x0600193B RID: 6459 RVA: 0x0002D173 File Offset: 0x0002C173
		public float SumAirTimeInSeconds
		{
			get
			{
				return this.SumAirTimeInMilliseconds / 1000f;
			}
			set
			{
				this.SumAirTimeInMilliseconds = (uint)(value * 1000f);
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x0600193C RID: 6460 RVA: 0x0002D183 File Offset: 0x0002C183
		// (set) Token: 0x0600193D RID: 6461 RVA: 0x0002D18B File Offset: 0x0002C18B
		public PerfectStart PerfectStart
		{
			get
			{
				return this.perfectStart;
			}
			set
			{
				this.perfectStart = value;
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x0600193E RID: 6462 RVA: 0x0002D194 File Offset: 0x0002C194
		// (set) Token: 0x0600193F RID: 6463 RVA: 0x0002D19C File Offset: 0x0002C19C
		public int NumOpponentsTagged
		{
			get
			{
				return this.numOpponentsTagged;
			}
			set
			{
				this.numOpponentsTagged = value;
			}
		}

		// Token: 0x04000639 RID: 1593
		private readonly StopWatch lapTimer = new StopWatch();

		// Token: 0x0400063A RID: 1594
		private int currentLap;

		// Token: 0x0400063B RID: 1595
		private int numOpponentsTagged;

		// Token: 0x0400063C RID: 1596
		private float fractionCompleted;

		// Token: 0x0400063D RID: 1597
		private float topSpeed;

		// Token: 0x0400063E RID: 1598
		private float distanceToStartLine;

		// Token: 0x0400063F RID: 1599
		private uint bestLapDurationInMilliseconds;

		// Token: 0x04000640 RID: 1600
		private PerfectStart perfectStart = PerfectStart.kPerfectStart_Unlearned;
	}
}
