using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x020000D7 RID: 215
	[ExportOnlyCreate(true)]
	public class TreasureHuntArbitratedPacket : ArbitratedPacket
	{
		// Token: 0x06000D28 RID: 3368 RVA: 0x0001004C File Offset: 0x0000F04C
		public new unsafe static TreasureHuntArbitratedPacket CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new TreasureHuntArbitratedPacket(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x0001006F File Offset: 0x0000F06F
		public unsafe TreasureHuntArbitratedPacket(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x00010079 File Offset: 0x0000F079
		protected internal TreasureHuntArbitratedPacket(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x00010082 File Offset: 0x0000F082
		protected internal unsafe TreasureHuntArbitratedPacket(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000D2C RID: 3372
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1337();

		// Token: 0x06000D2D RID: 3373 RVA: 0x0001008C File Offset: 0x0000F08C
		public TreasureHuntArbitratedPacket() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = TreasureHuntArbitratedPacket._EASharpBinding_1337();
		}

		// Token: 0x06000D2E RID: 3374
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1338(void* _ThisPtr);

		// Token: 0x06000D2F RID: 3375 RVA: 0x000100B4 File Offset: 0x0000F0B4
		~TreasureHuntArbitratedPacket()
		{
			TreasureHuntArbitratedPacket._EASharpBinding_1338(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000D30 RID: 3376
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1339(void* _ThisPtr);

		// Token: 0x06000D31 RID: 3377 RVA: 0x000100F0 File Offset: 0x0000F0F0
		public override void Reset()
		{
			TreasureHuntArbitratedPacket._EASharpBinding_1339(this.mSelf);
		}

		// Token: 0x06000D32 RID: 3378
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1340(void* _ThisPtr);

		// Token: 0x06000D33 RID: 3379 RVA: 0x00010100 File Offset: 0x0000F100
		public TreasureHuntEntrantArbitratedPacket CreateEntrantArbitratedPacket()
		{
			return TreasureHuntEntrantArbitratedPacket.CreateInitUnowned(TreasureHuntArbitratedPacket._EASharpBinding_1340(this.mSelf));
		}
	}
}
