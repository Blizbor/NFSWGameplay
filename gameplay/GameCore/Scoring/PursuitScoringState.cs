using System;
using Skills;

namespace GameCore.Scoring
{
	// Token: 0x0200027E RID: 638
	public class PursuitScoringState : ScoringState, IPerfectStart
	{
		// Token: 0x060018F2 RID: 6386 RVA: 0x0002C969 File Offset: 0x0002B969
		public PursuitScoringState()
		{
			this.Reset();
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x0002C978 File Offset: 0x0002B978
		public override void Reset()
		{
			base.Reset();
			this.TopSpeed = (this.Heat = 0f);
			this.LongestAirTimeInMilliseconds = (this.SumAirTimeInMilliseconds = 0u);
			this.CopsDisabled = (this.CopsRammed = (this.CopsDeployed = (this.CostToState = (this.SpikeStripsDodged = (this.RoadBlocksDodged = (this.Infractions = 0))))));
			this.PerfectStart = PerfectStart.kPerfectStart_Unlearned;
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x060018F4 RID: 6388 RVA: 0x0002C9FB File Offset: 0x0002B9FB
		// (set) Token: 0x060018F5 RID: 6389 RVA: 0x0002CA03 File Offset: 0x0002BA03
		public float TopSpeed { get; set; }

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x060018F6 RID: 6390 RVA: 0x0002CA0C File Offset: 0x0002BA0C
		// (set) Token: 0x060018F7 RID: 6391 RVA: 0x0002CA14 File Offset: 0x0002BA14
		public uint LongestAirTimeInMilliseconds { get; set; }

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060018F8 RID: 6392 RVA: 0x0002CA1D File Offset: 0x0002BA1D
		// (set) Token: 0x060018F9 RID: 6393 RVA: 0x0002CA2D File Offset: 0x0002BA2D
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

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x060018FA RID: 6394 RVA: 0x0002CA3D File Offset: 0x0002BA3D
		// (set) Token: 0x060018FB RID: 6395 RVA: 0x0002CA45 File Offset: 0x0002BA45
		public uint SumAirTimeInMilliseconds { get; set; }

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x060018FC RID: 6396 RVA: 0x0002CA4E File Offset: 0x0002BA4E
		// (set) Token: 0x060018FD RID: 6397 RVA: 0x0002CA5E File Offset: 0x0002BA5E
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

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x060018FE RID: 6398 RVA: 0x0002CA6E File Offset: 0x0002BA6E
		// (set) Token: 0x060018FF RID: 6399 RVA: 0x0002CA76 File Offset: 0x0002BA76
		public float Heat { get; set; }

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06001900 RID: 6400 RVA: 0x0002CA7F File Offset: 0x0002BA7F
		// (set) Token: 0x06001901 RID: 6401 RVA: 0x0002CA87 File Offset: 0x0002BA87
		public int CopsDisabled { get; set; }

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06001902 RID: 6402 RVA: 0x0002CA90 File Offset: 0x0002BA90
		// (set) Token: 0x06001903 RID: 6403 RVA: 0x0002CA98 File Offset: 0x0002BA98
		public int CopsRammed { get; set; }

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06001904 RID: 6404 RVA: 0x0002CAA1 File Offset: 0x0002BAA1
		// (set) Token: 0x06001905 RID: 6405 RVA: 0x0002CAA9 File Offset: 0x0002BAA9
		public int CopsDeployed { get; set; }

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06001906 RID: 6406 RVA: 0x0002CAB2 File Offset: 0x0002BAB2
		// (set) Token: 0x06001907 RID: 6407 RVA: 0x0002CABA File Offset: 0x0002BABA
		public int CostToState { get; set; }

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06001908 RID: 6408 RVA: 0x0002CAC3 File Offset: 0x0002BAC3
		// (set) Token: 0x06001909 RID: 6409 RVA: 0x0002CACB File Offset: 0x0002BACB
		public int SpikeStripsDodged { get; set; }

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x0600190A RID: 6410 RVA: 0x0002CAD4 File Offset: 0x0002BAD4
		// (set) Token: 0x0600190B RID: 6411 RVA: 0x0002CADC File Offset: 0x0002BADC
		public int RoadBlocksDodged { get; set; }

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x0600190C RID: 6412 RVA: 0x0002CAE5 File Offset: 0x0002BAE5
		// (set) Token: 0x0600190D RID: 6413 RVA: 0x0002CAED File Offset: 0x0002BAED
		public int Infractions { get; set; }

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x0600190E RID: 6414 RVA: 0x0002CAF6 File Offset: 0x0002BAF6
		// (set) Token: 0x0600190F RID: 6415 RVA: 0x0002CAFE File Offset: 0x0002BAFE
		public PerfectStart PerfectStart { get; set; }
	}
}
