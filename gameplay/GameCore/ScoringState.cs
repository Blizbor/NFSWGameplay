using System;
using GameCore.Timers;
using Victory.DataLayer.Serialization.Event;

namespace GameCore
{
	// Token: 0x02000254 RID: 596
	public abstract class ScoringState : IDisposable
	{
		// Token: 0x060017FC RID: 6140 RVA: 0x0002AD73 File Offset: 0x00029D73
		public ScoringState()
		{
			this.Reset();
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x0002AD98 File Offset: 0x00029D98
		~ScoringState()
		{
			this.Dispose(false);
		}

		// Token: 0x060017FE RID: 6142 RVA: 0x0002ADC8 File Offset: 0x00029DC8
		public virtual void Reset()
		{
			this.eventTimer.Reset();
			this.secureEventTimer.Reset();
			this.finishReason = FinishReason.Unknown;
		}

		// Token: 0x060017FF RID: 6143 RVA: 0x0002ADE7 File Offset: 0x00029DE7
		public virtual bool IsFinishReason(FinishReason reason)
		{
			return (this.finishReason & reason) == reason;
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x0002ADF4 File Offset: 0x00029DF4
		protected virtual void OnFinishReasonChanged()
		{
			if (this.FinishReasonChanged != null)
			{
				this.FinishReasonChanged(this, EventArgs.Empty);
			}
		}

		// Token: 0x06001801 RID: 6145 RVA: 0x0002AE0F File Offset: 0x00029E0F
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x0002AE1E File Offset: 0x00029E1E
		protected virtual void Dispose(bool disposing)
		{
			if (!this.isDisposed)
			{
				this.isDisposed = true;
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06001803 RID: 6147 RVA: 0x0002AE31 File Offset: 0x00029E31
		// (remove) Token: 0x06001804 RID: 6148 RVA: 0x0002AE4A File Offset: 0x00029E4A
		public event EventHandler FinishReasonChanged;

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06001805 RID: 6149 RVA: 0x0002AE63 File Offset: 0x00029E63
		protected bool IsDisposed
		{
			get
			{
				return this.isDisposed;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06001806 RID: 6150 RVA: 0x0002AE6B File Offset: 0x00029E6B
		// (set) Token: 0x06001807 RID: 6151 RVA: 0x0002AE73 File Offset: 0x00029E73
		public FinishReason FinishReason
		{
			get
			{
				return this.finishReason;
			}
			set
			{
				this.finishReason = value;
				this.OnFinishReasonChanged();
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06001808 RID: 6152 RVA: 0x0002AE82 File Offset: 0x00029E82
		// (set) Token: 0x06001809 RID: 6153 RVA: 0x0002AE8A File Offset: 0x00029E8A
		public uint Level
		{
			get
			{
				return this.level;
			}
			set
			{
				this.level = value;
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x0600180A RID: 6154 RVA: 0x0002AE93 File Offset: 0x00029E93
		// (set) Token: 0x0600180B RID: 6155 RVA: 0x0002AE9B File Offset: 0x00029E9B
		public int Rank { get; set; }

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x0600180C RID: 6156 RVA: 0x0002AEA4 File Offset: 0x00029EA4
		public bool HasFinishReason
		{
			get
			{
				return (this.finishReason & FinishReason.Completed) != FinishReason.Unknown;
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x0600180D RID: 6157 RVA: 0x0002AEB4 File Offset: 0x00029EB4
		public StopWatch EventTimer
		{
			get
			{
				return this.eventTimer;
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x0600180E RID: 6158 RVA: 0x0002AEBC File Offset: 0x00029EBC
		public SecureStopWatch SecureEventTimer
		{
			get
			{
				return this.secureEventTimer;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x0600180F RID: 6159 RVA: 0x0002AEC4 File Offset: 0x00029EC4
		// (set) Token: 0x06001810 RID: 6160 RVA: 0x0002AEE0 File Offset: 0x00029EE0
		public uint EventDurationInMilliseconds
		{
			get
			{
				if (this.eventDurationInMilliseconds == 0u)
				{
					return this.eventTimer.ElapsedInMilliseconds;
				}
				return this.eventDurationInMilliseconds;
			}
			set
			{
				this.eventDurationInMilliseconds = value;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06001811 RID: 6161 RVA: 0x0002AEE9 File Offset: 0x00029EE9
		// (set) Token: 0x06001812 RID: 6162 RVA: 0x0002AF05 File Offset: 0x00029F05
		public uint SecureEventDurationInMilliseconds
		{
			get
			{
				if (this.secureEventDurationInMilliseconds == 0u)
				{
					return this.secureEventTimer.ElapsedInMilliseconds;
				}
				return this.secureEventDurationInMilliseconds;
			}
			set
			{
				this.secureEventDurationInMilliseconds = value;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06001813 RID: 6163 RVA: 0x0002AF0E File Offset: 0x00029F0E
		public float EventDurationInSeconds
		{
			get
			{
				return this.EventDurationInMilliseconds / 1000f;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06001814 RID: 6164 RVA: 0x0002AF1E File Offset: 0x00029F1E
		public float SecureEventDurationInSeconds
		{
			get
			{
				return this.SecureEventDurationInMilliseconds / 1000f;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06001815 RID: 6165 RVA: 0x0002AF2E File Offset: 0x00029F2E
		// (set) Token: 0x06001816 RID: 6166 RVA: 0x0002AF36 File Offset: 0x00029F36
		public bool HasArbitrated
		{
			get
			{
				return this.hasArbitrated;
			}
			set
			{
				this.hasArbitrated = value;
			}
		}

		// Token: 0x040005E0 RID: 1504
		private bool isDisposed;

		// Token: 0x040005E1 RID: 1505
		private readonly StopWatch eventTimer = new StopWatch();

		// Token: 0x040005E2 RID: 1506
		private readonly SecureStopWatch secureEventTimer = new SecureStopWatch();

		// Token: 0x040005E3 RID: 1507
		private FinishReason finishReason;

		// Token: 0x040005E4 RID: 1508
		private uint level;

		// Token: 0x040005E5 RID: 1509
		private uint eventDurationInMilliseconds;

		// Token: 0x040005E6 RID: 1510
		private uint secureEventDurationInMilliseconds;

		// Token: 0x040005E7 RID: 1511
		private bool hasArbitrated;
	}
}
