using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x020000D9 RID: 217
	[ExportOnlyCreate(true)]
	public class PursuitArbitratedPacket : ArbitratedPacket
	{
		// Token: 0x06000D64 RID: 3428 RVA: 0x000102D4 File Offset: 0x0000F2D4
		public new unsafe static PursuitArbitratedPacket CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new PursuitArbitratedPacket(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x000102F7 File Offset: 0x0000F2F7
		public unsafe PursuitArbitratedPacket(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x00010301 File Offset: 0x0000F301
		protected internal PursuitArbitratedPacket(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x0001030A File Offset: 0x0000F30A
		protected internal unsafe PursuitArbitratedPacket(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000D68 RID: 3432
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1363();

		// Token: 0x06000D69 RID: 3433 RVA: 0x00010314 File Offset: 0x0000F314
		public PursuitArbitratedPacket() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = PursuitArbitratedPacket._EASharpBinding_1363();
		}

		// Token: 0x06000D6A RID: 3434
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1364(void* _ThisPtr);

		// Token: 0x06000D6B RID: 3435 RVA: 0x0001033C File Offset: 0x0000F33C
		~PursuitArbitratedPacket()
		{
			PursuitArbitratedPacket._EASharpBinding_1364(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000D6C RID: 3436
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1365(void* _ThisPtr);

		// Token: 0x06000D6D RID: 3437 RVA: 0x00010378 File Offset: 0x0000F378
		public override void Reset()
		{
			PursuitArbitratedPacket._EASharpBinding_1365(this.mSelf);
		}

		// Token: 0x06000D6E RID: 3438
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1366(void* _ThisPtr);

		// Token: 0x06000D6F RID: 3439 RVA: 0x00010388 File Offset: 0x0000F388
		public PursuitEntrantArbitratedPacket CreateEntrantArbitratedPacket()
		{
			return PursuitEntrantArbitratedPacket.CreateInitUnowned(PursuitArbitratedPacket._EASharpBinding_1366(this.mSelf));
		}

		// Token: 0x06000D70 RID: 3440
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1367(void* self, void* val);

		// Token: 0x06000D71 RID: 3441
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1368(void* self);

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000D72 RID: 3442 RVA: 0x000103A8 File Offset: 0x0000F3A8
		// (set) Token: 0x06000D73 RID: 3443 RVA: 0x000103CE File Offset: 0x0000F3CE
		public PursuitEntrantArbitratedPacket Entrant
		{
			get
			{
				return new PursuitEntrantArbitratedPacket(default(ExposeTag_InitOwned), PursuitArbitratedPacket._EASharpBinding_1368(this.mSelf));
			}
			set
			{
				PursuitArbitratedPacket._EASharpBinding_1367(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
			}
		}
	}
}
