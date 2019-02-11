using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x020000D5 RID: 213
	[ExportOnlyCreate(true)]
	public class DragArbitratedPacket : ArbitratedPacket
	{
		// Token: 0x06000D14 RID: 3348 RVA: 0x0000FED4 File Offset: 0x0000EED4
		public new unsafe static DragArbitratedPacket CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new DragArbitratedPacket(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x0000FEF7 File Offset: 0x0000EEF7
		public unsafe DragArbitratedPacket(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x0000FF01 File Offset: 0x0000EF01
		protected internal DragArbitratedPacket(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x0000FF0A File Offset: 0x0000EF0A
		protected internal unsafe DragArbitratedPacket(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000D18 RID: 3352
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1331();

		// Token: 0x06000D19 RID: 3353 RVA: 0x0000FF14 File Offset: 0x0000EF14
		public DragArbitratedPacket() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = DragArbitratedPacket._EASharpBinding_1331();
		}

		// Token: 0x06000D1A RID: 3354
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1332(void* _ThisPtr);

		// Token: 0x06000D1B RID: 3355 RVA: 0x0000FF3C File Offset: 0x0000EF3C
		~DragArbitratedPacket()
		{
			DragArbitratedPacket._EASharpBinding_1332(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000D1C RID: 3356
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1333(void* _ThisPtr);

		// Token: 0x06000D1D RID: 3357 RVA: 0x0000FF78 File Offset: 0x0000EF78
		public override void Reset()
		{
			DragArbitratedPacket._EASharpBinding_1333(this.mSelf);
		}

		// Token: 0x06000D1E RID: 3358
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1334(void* _ThisPtr);

		// Token: 0x06000D1F RID: 3359 RVA: 0x0000FF88 File Offset: 0x0000EF88
		public DragEntrantArbitratedPacket CreateEntrantArbitratedPacket()
		{
			return DragEntrantArbitratedPacket.CreateInitUnowned(DragArbitratedPacket._EASharpBinding_1334(this.mSelf));
		}
	}
}
