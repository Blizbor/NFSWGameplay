using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x020000D2 RID: 210
	[ExportOnlyCreate(true)]
	public class TeamEscapeEntrantArbitratedPacket : EntrantArbitratedPacket
	{
		// Token: 0x06000CD0 RID: 3280 RVA: 0x0000FBA8 File Offset: 0x0000EBA8
		public new unsafe static TeamEscapeEntrantArbitratedPacket CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new TeamEscapeEntrantArbitratedPacket(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x0000FBCB File Offset: 0x0000EBCB
		public unsafe TeamEscapeEntrantArbitratedPacket(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x0000FBD5 File Offset: 0x0000EBD5
		protected internal TeamEscapeEntrantArbitratedPacket(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x0000FBDE File Offset: 0x0000EBDE
		protected internal unsafe TeamEscapeEntrantArbitratedPacket(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000CD4 RID: 3284
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1303();

		// Token: 0x06000CD5 RID: 3285 RVA: 0x0000FBE8 File Offset: 0x0000EBE8
		public TeamEscapeEntrantArbitratedPacket() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = TeamEscapeEntrantArbitratedPacket._EASharpBinding_1303();
		}

		// Token: 0x06000CD6 RID: 3286
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1304(void* _ThisPtr);

		// Token: 0x06000CD7 RID: 3287 RVA: 0x0000FC10 File Offset: 0x0000EC10
		~TeamEscapeEntrantArbitratedPacket()
		{
			TeamEscapeEntrantArbitratedPacket._EASharpBinding_1304(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000CD8 RID: 3288
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1305(void* self, float val);

		// Token: 0x06000CD9 RID: 3289
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_1306(void* self);

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000CDA RID: 3290 RVA: 0x0000FC4C File Offset: 0x0000EC4C
		// (set) Token: 0x06000CDB RID: 3291 RVA: 0x0000FC59 File Offset: 0x0000EC59
		public float DistanceToFinish
		{
			get
			{
				return TeamEscapeEntrantArbitratedPacket._EASharpBinding_1306(this.mSelf);
			}
			set
			{
				TeamEscapeEntrantArbitratedPacket._EASharpBinding_1305(this.mSelf, value);
			}
		}

		// Token: 0x06000CDC RID: 3292
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1307(void* self, int val);

		// Token: 0x06000CDD RID: 3293
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1308(void* self);

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000CDE RID: 3294 RVA: 0x0000FC67 File Offset: 0x0000EC67
		// (set) Token: 0x06000CDF RID: 3295 RVA: 0x0000FC74 File Offset: 0x0000EC74
		public int Strikes
		{
			get
			{
				return TeamEscapeEntrantArbitratedPacket._EASharpBinding_1308(this.mSelf);
			}
			set
			{
				TeamEscapeEntrantArbitratedPacket._EASharpBinding_1307(this.mSelf, value);
			}
		}
	}
}
