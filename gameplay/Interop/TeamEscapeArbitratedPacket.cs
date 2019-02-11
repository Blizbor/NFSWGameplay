using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x020000D3 RID: 211
	[ExportOnlyCreate(true)]
	public class TeamEscapeArbitratedPacket : ArbitratedPacket
	{
		// Token: 0x06000CE0 RID: 3296 RVA: 0x0000FC84 File Offset: 0x0000EC84
		public new unsafe static TeamEscapeArbitratedPacket CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new TeamEscapeArbitratedPacket(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x0000FCA7 File Offset: 0x0000ECA7
		public unsafe TeamEscapeArbitratedPacket(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x0000FCB1 File Offset: 0x0000ECB1
		protected internal TeamEscapeArbitratedPacket(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x0000FCBA File Offset: 0x0000ECBA
		protected internal unsafe TeamEscapeArbitratedPacket(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000CE4 RID: 3300
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1309();

		// Token: 0x06000CE5 RID: 3301 RVA: 0x0000FCC4 File Offset: 0x0000ECC4
		public TeamEscapeArbitratedPacket() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = TeamEscapeArbitratedPacket._EASharpBinding_1309();
		}

		// Token: 0x06000CE6 RID: 3302
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1310(void* _ThisPtr);

		// Token: 0x06000CE7 RID: 3303 RVA: 0x0000FCEC File Offset: 0x0000ECEC
		~TeamEscapeArbitratedPacket()
		{
			TeamEscapeArbitratedPacket._EASharpBinding_1310(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000CE8 RID: 3304
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1311(void* _ThisPtr);

		// Token: 0x06000CE9 RID: 3305 RVA: 0x0000FD28 File Offset: 0x0000ED28
		public override void Reset()
		{
			TeamEscapeArbitratedPacket._EASharpBinding_1311(this.mSelf);
		}

		// Token: 0x06000CEA RID: 3306
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1312(void* _ThisPtr);

		// Token: 0x06000CEB RID: 3307 RVA: 0x0000FD38 File Offset: 0x0000ED38
		public TeamEscapeEntrantArbitratedPacket CreateEntrantArbitratedPacket()
		{
			return TeamEscapeEntrantArbitratedPacket.CreateInitUnowned(TeamEscapeArbitratedPacket._EASharpBinding_1312(this.mSelf));
		}

		// Token: 0x06000CEC RID: 3308
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1313(void* self, int val);

		// Token: 0x06000CED RID: 3309
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1314(void* self);

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000CEE RID: 3310 RVA: 0x0000FD57 File Offset: 0x0000ED57
		// (set) Token: 0x06000CEF RID: 3311 RVA: 0x0000FD64 File Offset: 0x0000ED64
		public int Strikes
		{
			get
			{
				return TeamEscapeArbitratedPacket._EASharpBinding_1314(this.mSelf);
			}
			set
			{
				TeamEscapeArbitratedPacket._EASharpBinding_1313(this.mSelf, value);
			}
		}

		// Token: 0x06000CF0 RID: 3312
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1315(void* self, int val);

		// Token: 0x06000CF1 RID: 3313
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1316(void* self);

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000CF2 RID: 3314 RVA: 0x0000FD72 File Offset: 0x0000ED72
		// (set) Token: 0x06000CF3 RID: 3315 RVA: 0x0000FD7F File Offset: 0x0000ED7F
		public int MaxStrikes
		{
			get
			{
				return TeamEscapeArbitratedPacket._EASharpBinding_1316(this.mSelf);
			}
			set
			{
				TeamEscapeArbitratedPacket._EASharpBinding_1315(this.mSelf, value);
			}
		}

		// Token: 0x06000CF4 RID: 3316
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1317(void* self, int val);

		// Token: 0x06000CF5 RID: 3317
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1318(void* self);

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000CF6 RID: 3318 RVA: 0x0000FD8D File Offset: 0x0000ED8D
		// (set) Token: 0x06000CF7 RID: 3319 RVA: 0x0000FD9A File Offset: 0x0000ED9A
		public int CostToState
		{
			get
			{
				return TeamEscapeArbitratedPacket._EASharpBinding_1318(this.mSelf);
			}
			set
			{
				TeamEscapeArbitratedPacket._EASharpBinding_1317(this.mSelf, value);
			}
		}

		// Token: 0x06000CF8 RID: 3320
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1319(void* self, int val);

		// Token: 0x06000CF9 RID: 3321
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1320(void* self);

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000CFA RID: 3322 RVA: 0x0000FDA8 File Offset: 0x0000EDA8
		// (set) Token: 0x06000CFB RID: 3323 RVA: 0x0000FDB5 File Offset: 0x0000EDB5
		public int CopsTagged
		{
			get
			{
				return TeamEscapeArbitratedPacket._EASharpBinding_1320(this.mSelf);
			}
			set
			{
				TeamEscapeArbitratedPacket._EASharpBinding_1319(this.mSelf, value);
			}
		}

		// Token: 0x06000CFC RID: 3324
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1321(void* self, int val);

		// Token: 0x06000CFD RID: 3325
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1322(void* self);

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000CFE RID: 3326 RVA: 0x0000FDC3 File Offset: 0x0000EDC3
		// (set) Token: 0x06000CFF RID: 3327 RVA: 0x0000FDD0 File Offset: 0x0000EDD0
		public int CopsDeployed
		{
			get
			{
				return TeamEscapeArbitratedPacket._EASharpBinding_1322(this.mSelf);
			}
			set
			{
				TeamEscapeArbitratedPacket._EASharpBinding_1321(this.mSelf, value);
			}
		}

		// Token: 0x06000D00 RID: 3328
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1323(void* self, int val);

		// Token: 0x06000D01 RID: 3329
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1324(void* self);

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000D02 RID: 3330 RVA: 0x0000FDDE File Offset: 0x0000EDDE
		// (set) Token: 0x06000D03 RID: 3331 RVA: 0x0000FDEB File Offset: 0x0000EDEB
		public int RoadBlocksDodged
		{
			get
			{
				return TeamEscapeArbitratedPacket._EASharpBinding_1324(this.mSelf);
			}
			set
			{
				TeamEscapeArbitratedPacket._EASharpBinding_1323(this.mSelf, value);
			}
		}

		// Token: 0x06000D04 RID: 3332
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1325(void* self, float val);

		// Token: 0x06000D05 RID: 3333
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_1326(void* self);

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000D06 RID: 3334 RVA: 0x0000FDF9 File Offset: 0x0000EDF9
		// (set) Token: 0x06000D07 RID: 3335 RVA: 0x0000FE06 File Offset: 0x0000EE06
		public float EventDuration
		{
			get
			{
				return TeamEscapeArbitratedPacket._EASharpBinding_1326(this.mSelf);
			}
			set
			{
				TeamEscapeArbitratedPacket._EASharpBinding_1325(this.mSelf, value);
			}
		}
	}
}
