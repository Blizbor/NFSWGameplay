using System;
using Skills;

namespace GameCore.Scoring
{
	// Token: 0x02000282 RID: 642
	public class TeamEscapeScoringState : ScoringState, IPerfectStart, IPursuit
	{
		// Token: 0x0600195B RID: 6491 RVA: 0x0002DDDD File Offset: 0x0002CDDD
		public TeamEscapeScoringState()
		{
			this.Reset();
		}

		// Token: 0x0600195C RID: 6492 RVA: 0x0002DDEC File Offset: 0x0002CDEC
		public override void Reset()
		{
			base.Reset();
			this.TopSpeed = (this.FractionCompleted = (this.DistanceToStartLine = 0f));
			this.PerfectStart = PerfectStart.kPerfectStart_Unlearned;
			this.Highlight = EntrantHighlight.kHighlight_None;
			this.DistanceToFinish = 0f;
			this.Busts = 0;
			this.IsTimerUrgent = false;
		}

		// Token: 0x0600195D RID: 6493 RVA: 0x0002DE43 File Offset: 0x0002CE43
		protected override void Dispose(bool disposing)
		{
			if (!base.IsDisposed && disposing && this.TrackerEntity != null)
			{
				TrackerManager.Get().RemoveEntity(this.TrackerEntity);
				this.TrackerEntity = null;
			}
			base.Dispose(disposing);
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x0600195E RID: 6494 RVA: 0x0002DE76 File Offset: 0x0002CE76
		// (set) Token: 0x0600195F RID: 6495 RVA: 0x0002DE7E File Offset: 0x0002CE7E
		public float FractionCompleted { get; set; }

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06001960 RID: 6496 RVA: 0x0002DE87 File Offset: 0x0002CE87
		// (set) Token: 0x06001961 RID: 6497 RVA: 0x0002DE8F File Offset: 0x0002CE8F
		public float TopSpeed { get; set; }

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06001962 RID: 6498 RVA: 0x0002DE98 File Offset: 0x0002CE98
		// (set) Token: 0x06001963 RID: 6499 RVA: 0x0002DEA0 File Offset: 0x0002CEA0
		public float DistanceToStartLine { get; set; }

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06001964 RID: 6500 RVA: 0x0002DEA9 File Offset: 0x0002CEA9
		// (set) Token: 0x06001965 RID: 6501 RVA: 0x0002DEB1 File Offset: 0x0002CEB1
		public uint LongestAirTimeInMilliseconds { get; set; }

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06001966 RID: 6502 RVA: 0x0002DEBA File Offset: 0x0002CEBA
		// (set) Token: 0x06001967 RID: 6503 RVA: 0x0002DECA File Offset: 0x0002CECA
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

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06001968 RID: 6504 RVA: 0x0002DEDA File Offset: 0x0002CEDA
		// (set) Token: 0x06001969 RID: 6505 RVA: 0x0002DEE2 File Offset: 0x0002CEE2
		public uint SumAirTimeInMilliseconds { get; set; }

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x0600196A RID: 6506 RVA: 0x0002DEEB File Offset: 0x0002CEEB
		// (set) Token: 0x0600196B RID: 6507 RVA: 0x0002DEFB File Offset: 0x0002CEFB
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

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x0600196C RID: 6508 RVA: 0x0002DF0B File Offset: 0x0002CF0B
		// (set) Token: 0x0600196D RID: 6509 RVA: 0x0002DF13 File Offset: 0x0002CF13
		public PerfectStart PerfectStart { get; set; }

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x0600196E RID: 6510 RVA: 0x0002DF1C File Offset: 0x0002CF1C
		// (set) Token: 0x0600196F RID: 6511 RVA: 0x0002DF24 File Offset: 0x0002CF24
		public int NumOpponentsTagged { get; set; }

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06001970 RID: 6512 RVA: 0x0002DF2D File Offset: 0x0002CF2D
		// (set) Token: 0x06001971 RID: 6513 RVA: 0x0002DF35 File Offset: 0x0002CF35
		public EntrantHighlight Highlight { get; set; }

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06001972 RID: 6514 RVA: 0x0002DF3E File Offset: 0x0002CF3E
		// (set) Token: 0x06001973 RID: 6515 RVA: 0x0002DF46 File Offset: 0x0002CF46
		public float DistanceToFinish { get; set; }

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06001974 RID: 6516 RVA: 0x0002DF4F File Offset: 0x0002CF4F
		// (set) Token: 0x06001975 RID: 6517 RVA: 0x0002DF57 File Offset: 0x0002CF57
		public int Busts { get; set; }

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06001976 RID: 6518 RVA: 0x0002DF60 File Offset: 0x0002CF60
		// (set) Token: 0x06001977 RID: 6519 RVA: 0x0002DF68 File Offset: 0x0002CF68
		public int CopsDisabled { get; set; }

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06001978 RID: 6520 RVA: 0x0002DF71 File Offset: 0x0002CF71
		// (set) Token: 0x06001979 RID: 6521 RVA: 0x0002DF79 File Offset: 0x0002CF79
		public int CopsRammed { get; set; }

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x0600197A RID: 6522 RVA: 0x0002DF82 File Offset: 0x0002CF82
		// (set) Token: 0x0600197B RID: 6523 RVA: 0x0002DF8A File Offset: 0x0002CF8A
		public int CopsDeployed { get; set; }

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x0600197C RID: 6524 RVA: 0x0002DF93 File Offset: 0x0002CF93
		// (set) Token: 0x0600197D RID: 6525 RVA: 0x0002DF9B File Offset: 0x0002CF9B
		public int CostToState { get; set; }

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x0600197E RID: 6526 RVA: 0x0002DFA4 File Offset: 0x0002CFA4
		// (set) Token: 0x0600197F RID: 6527 RVA: 0x0002DFAC File Offset: 0x0002CFAC
		public int SpikeStripsDodged { get; set; }

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06001980 RID: 6528 RVA: 0x0002DFB5 File Offset: 0x0002CFB5
		// (set) Token: 0x06001981 RID: 6529 RVA: 0x0002DFBD File Offset: 0x0002CFBD
		public int RoadBlocksDodged { get; set; }

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06001982 RID: 6530 RVA: 0x0002DFC6 File Offset: 0x0002CFC6
		// (set) Token: 0x06001983 RID: 6531 RVA: 0x0002DFCE File Offset: 0x0002CFCE
		public int Infractions { get; set; }

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06001984 RID: 6532 RVA: 0x0002DFD7 File Offset: 0x0002CFD7
		// (set) Token: 0x06001985 RID: 6533 RVA: 0x0002DFDF File Offset: 0x0002CFDF
		public float TimeRemaining { get; set; }

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06001986 RID: 6534 RVA: 0x0002DFE8 File Offset: 0x0002CFE8
		// (set) Token: 0x06001987 RID: 6535 RVA: 0x0002DFF0 File Offset: 0x0002CFF0
		public bool IsTimerUrgent { get; set; }

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06001988 RID: 6536 RVA: 0x0002DFF9 File Offset: 0x0002CFF9
		// (set) Token: 0x06001989 RID: 6537 RVA: 0x0002E001 File Offset: 0x0002D001
		public TrackerEntity TrackerEntity { get; set; }

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x0600198A RID: 6538 RVA: 0x0002E00A File Offset: 0x0002D00A
		// (set) Token: 0x0600198B RID: 6539 RVA: 0x0002E012 File Offset: 0x0002D012
		public float PursuitBar { get; set; }
	}
}
