using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x020000D8 RID: 216
	[ExportOnlyCreate(true)]
	public class PursuitEntrantArbitratedPacket : EntrantArbitratedPacket
	{
		// Token: 0x06000D34 RID: 3380 RVA: 0x00010120 File Offset: 0x0000F120
		public new unsafe static PursuitEntrantArbitratedPacket CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new PursuitEntrantArbitratedPacket(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x00010143 File Offset: 0x0000F143
		public unsafe PursuitEntrantArbitratedPacket(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x0001014D File Offset: 0x0000F14D
		protected internal PursuitEntrantArbitratedPacket(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x00010156 File Offset: 0x0000F156
		protected internal unsafe PursuitEntrantArbitratedPacket(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000D38 RID: 3384
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1341();

		// Token: 0x06000D39 RID: 3385 RVA: 0x00010160 File Offset: 0x0000F160
		public PursuitEntrantArbitratedPacket() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = PursuitEntrantArbitratedPacket._EASharpBinding_1341();
		}

		// Token: 0x06000D3A RID: 3386
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1342(void* _ThisPtr);

		// Token: 0x06000D3B RID: 3387 RVA: 0x00010188 File Offset: 0x0000F188
		~PursuitEntrantArbitratedPacket()
		{
			PursuitEntrantArbitratedPacket._EASharpBinding_1342(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000D3C RID: 3388
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1343(void* self, int val);

		// Token: 0x06000D3D RID: 3389
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1344(void* self);

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000D3E RID: 3390 RVA: 0x000101C4 File Offset: 0x0000F1C4
		// (set) Token: 0x06000D3F RID: 3391 RVA: 0x000101D1 File Offset: 0x0000F1D1
		public int CopsDeployed
		{
			get
			{
				return PursuitEntrantArbitratedPacket._EASharpBinding_1344(this.mSelf);
			}
			set
			{
				PursuitEntrantArbitratedPacket._EASharpBinding_1343(this.mSelf, value);
			}
		}

		// Token: 0x06000D40 RID: 3392
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1345(void* self, int val);

		// Token: 0x06000D41 RID: 3393
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1346(void* self);

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000D42 RID: 3394 RVA: 0x000101DF File Offset: 0x0000F1DF
		// (set) Token: 0x06000D43 RID: 3395 RVA: 0x000101EC File Offset: 0x0000F1EC
		public int CopsDisabled
		{
			get
			{
				return PursuitEntrantArbitratedPacket._EASharpBinding_1346(this.mSelf);
			}
			set
			{
				PursuitEntrantArbitratedPacket._EASharpBinding_1345(this.mSelf, value);
			}
		}

		// Token: 0x06000D44 RID: 3396
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1347(void* self, int val);

		// Token: 0x06000D45 RID: 3397
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1348(void* self);

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000D46 RID: 3398 RVA: 0x000101FA File Offset: 0x0000F1FA
		// (set) Token: 0x06000D47 RID: 3399 RVA: 0x00010207 File Offset: 0x0000F207
		public int CopsRammed
		{
			get
			{
				return PursuitEntrantArbitratedPacket._EASharpBinding_1348(this.mSelf);
			}
			set
			{
				PursuitEntrantArbitratedPacket._EASharpBinding_1347(this.mSelf, value);
			}
		}

		// Token: 0x06000D48 RID: 3400
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1349(void* self, int val);

		// Token: 0x06000D49 RID: 3401
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1350(void* self);

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000D4A RID: 3402 RVA: 0x00010215 File Offset: 0x0000F215
		// (set) Token: 0x06000D4B RID: 3403 RVA: 0x00010222 File Offset: 0x0000F222
		public int CostToState
		{
			get
			{
				return PursuitEntrantArbitratedPacket._EASharpBinding_1350(this.mSelf);
			}
			set
			{
				PursuitEntrantArbitratedPacket._EASharpBinding_1349(this.mSelf, value);
			}
		}

		// Token: 0x06000D4C RID: 3404
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1351(void* self, float val);

		// Token: 0x06000D4D RID: 3405
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_1352(void* self);

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000D4E RID: 3406 RVA: 0x00010230 File Offset: 0x0000F230
		// (set) Token: 0x06000D4F RID: 3407 RVA: 0x0001023D File Offset: 0x0000F23D
		public float Heat
		{
			get
			{
				return PursuitEntrantArbitratedPacket._EASharpBinding_1352(this.mSelf);
			}
			set
			{
				PursuitEntrantArbitratedPacket._EASharpBinding_1351(this.mSelf, value);
			}
		}

		// Token: 0x06000D50 RID: 3408
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1353(void* self, int val);

		// Token: 0x06000D51 RID: 3409
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1354(void* self);

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000D52 RID: 3410 RVA: 0x0001024B File Offset: 0x0000F24B
		// (set) Token: 0x06000D53 RID: 3411 RVA: 0x00010258 File Offset: 0x0000F258
		public int Infractions
		{
			get
			{
				return PursuitEntrantArbitratedPacket._EASharpBinding_1354(this.mSelf);
			}
			set
			{
				PursuitEntrantArbitratedPacket._EASharpBinding_1353(this.mSelf, value);
			}
		}

		// Token: 0x06000D54 RID: 3412
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1355(void* self, float val);

		// Token: 0x06000D55 RID: 3413
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_1356(void* self);

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000D56 RID: 3414 RVA: 0x00010266 File Offset: 0x0000F266
		// (set) Token: 0x06000D57 RID: 3415 RVA: 0x00010273 File Offset: 0x0000F273
		public float LongestJumpDuration
		{
			get
			{
				return PursuitEntrantArbitratedPacket._EASharpBinding_1356(this.mSelf);
			}
			set
			{
				PursuitEntrantArbitratedPacket._EASharpBinding_1355(this.mSelf, value);
			}
		}

		// Token: 0x06000D58 RID: 3416
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1357(void* self, int val);

		// Token: 0x06000D59 RID: 3417
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1358(void* self);

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000D5A RID: 3418 RVA: 0x00010281 File Offset: 0x0000F281
		// (set) Token: 0x06000D5B RID: 3419 RVA: 0x0001028E File Offset: 0x0000F28E
		public int RoadBlocksDodged
		{
			get
			{
				return PursuitEntrantArbitratedPacket._EASharpBinding_1358(this.mSelf);
			}
			set
			{
				PursuitEntrantArbitratedPacket._EASharpBinding_1357(this.mSelf, value);
			}
		}

		// Token: 0x06000D5C RID: 3420
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1359(void* self, int val);

		// Token: 0x06000D5D RID: 3421
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1360(void* self);

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000D5E RID: 3422 RVA: 0x0001029C File Offset: 0x0000F29C
		// (set) Token: 0x06000D5F RID: 3423 RVA: 0x000102A9 File Offset: 0x0000F2A9
		public int SpikeStripsDodged
		{
			get
			{
				return PursuitEntrantArbitratedPacket._EASharpBinding_1360(this.mSelf);
			}
			set
			{
				PursuitEntrantArbitratedPacket._EASharpBinding_1359(this.mSelf, value);
			}
		}

		// Token: 0x06000D60 RID: 3424
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1361(void* self, float val);

		// Token: 0x06000D61 RID: 3425
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_1362(void* self);

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000D62 RID: 3426 RVA: 0x000102B7 File Offset: 0x0000F2B7
		// (set) Token: 0x06000D63 RID: 3427 RVA: 0x000102C4 File Offset: 0x0000F2C4
		public float TopSpeed
		{
			get
			{
				return PursuitEntrantArbitratedPacket._EASharpBinding_1362(this.mSelf);
			}
			set
			{
				PursuitEntrantArbitratedPacket._EASharpBinding_1361(this.mSelf, value);
			}
		}
	}
}
