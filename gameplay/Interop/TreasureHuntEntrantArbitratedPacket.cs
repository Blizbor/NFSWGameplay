using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x020000D6 RID: 214
	[ExportOnlyCreate(true)]
	public class TreasureHuntEntrantArbitratedPacket : EntrantArbitratedPacket
	{
		// Token: 0x06000D20 RID: 3360 RVA: 0x0000FFA8 File Offset: 0x0000EFA8
		public new unsafe static TreasureHuntEntrantArbitratedPacket CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new TreasureHuntEntrantArbitratedPacket(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x0000FFCB File Offset: 0x0000EFCB
		public unsafe TreasureHuntEntrantArbitratedPacket(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x0000FFD5 File Offset: 0x0000EFD5
		protected internal TreasureHuntEntrantArbitratedPacket(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x0000FFDE File Offset: 0x0000EFDE
		protected internal unsafe TreasureHuntEntrantArbitratedPacket(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000D24 RID: 3364
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1335();

		// Token: 0x06000D25 RID: 3365 RVA: 0x0000FFE8 File Offset: 0x0000EFE8
		public TreasureHuntEntrantArbitratedPacket() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = TreasureHuntEntrantArbitratedPacket._EASharpBinding_1335();
		}

		// Token: 0x06000D26 RID: 3366
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1336(void* _ThisPtr);

		// Token: 0x06000D27 RID: 3367 RVA: 0x00010010 File Offset: 0x0000F010
		~TreasureHuntEntrantArbitratedPacket()
		{
			TreasureHuntEntrantArbitratedPacket._EASharpBinding_1336(this.mSelf);
			this.mSelf = null;
		}
	}
}
