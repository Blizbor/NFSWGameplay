using System;
using Skills;

namespace GameCore.Scoring
{
	// Token: 0x02000279 RID: 633
	public class DragScoringState : ScoringState, IPerfectStart
	{
		// Token: 0x060018AB RID: 6315 RVA: 0x0002BD40 File Offset: 0x0002AD40
		public DragScoringState()
		{
			this.Reset();
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x0002BD58 File Offset: 0x0002AD58
		public override void Reset()
		{
			base.Reset();
			this.topSpeed = (this.fractionCompleted = (this.distanceToStartLine = 0f));
			this.LongestAirTimeInMilliseconds = 0u;
			this.perfectStart = PerfectStart.kPerfectStart_Unlearned;
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060018AD RID: 6317 RVA: 0x0002BD96 File Offset: 0x0002AD96
		// (set) Token: 0x060018AE RID: 6318 RVA: 0x0002BD9E File Offset: 0x0002AD9E
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

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x060018AF RID: 6319 RVA: 0x0002BDA7 File Offset: 0x0002ADA7
		// (set) Token: 0x060018B0 RID: 6320 RVA: 0x0002BDAF File Offset: 0x0002ADAF
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

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x060018B1 RID: 6321 RVA: 0x0002BDB8 File Offset: 0x0002ADB8
		// (set) Token: 0x060018B2 RID: 6322 RVA: 0x0002BDC0 File Offset: 0x0002ADC0
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

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x060018B3 RID: 6323 RVA: 0x0002BDC9 File Offset: 0x0002ADC9
		// (set) Token: 0x060018B4 RID: 6324 RVA: 0x0002BDD1 File Offset: 0x0002ADD1
		public uint LongestAirTimeInMilliseconds { get; set; }

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x060018B5 RID: 6325 RVA: 0x0002BDDA File Offset: 0x0002ADDA
		// (set) Token: 0x060018B6 RID: 6326 RVA: 0x0002BDEA File Offset: 0x0002ADEA
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

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060018B7 RID: 6327 RVA: 0x0002BDFA File Offset: 0x0002ADFA
		// (set) Token: 0x060018B8 RID: 6328 RVA: 0x0002BE02 File Offset: 0x0002AE02
		public uint SumAirTimeInMilliseconds { get; set; }

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060018B9 RID: 6329 RVA: 0x0002BE0B File Offset: 0x0002AE0B
		// (set) Token: 0x060018BA RID: 6330 RVA: 0x0002BE1B File Offset: 0x0002AE1B
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

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x060018BB RID: 6331 RVA: 0x0002BE2B File Offset: 0x0002AE2B
		// (set) Token: 0x060018BC RID: 6332 RVA: 0x0002BE33 File Offset: 0x0002AE33
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

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x060018BD RID: 6333 RVA: 0x0002BE3C File Offset: 0x0002AE3C
		// (set) Token: 0x060018BE RID: 6334 RVA: 0x0002BE44 File Offset: 0x0002AE44
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

		// Token: 0x04000626 RID: 1574
		private int numOpponentsTagged;

		// Token: 0x04000627 RID: 1575
		private float fractionCompleted;

		// Token: 0x04000628 RID: 1576
		private float topSpeed;

		// Token: 0x04000629 RID: 1577
		private float distanceToStartLine;

		// Token: 0x0400062A RID: 1578
		private PerfectStart perfectStart = PerfectStart.kPerfectStart_Unlearned;
	}
}
