using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x020000B4 RID: 180
	[ExportOnlyCreate(true)]
	public class TreasureHuntEntrantLivePacket : EntrantLivePacket
	{
		// Token: 0x06000A46 RID: 2630 RVA: 0x0000D268 File Offset: 0x0000C268
		public new unsafe static TreasureHuntEntrantLivePacket CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new TreasureHuntEntrantLivePacket(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x0000D28B File Offset: 0x0000C28B
		public unsafe TreasureHuntEntrantLivePacket(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x0000D295 File Offset: 0x0000C295
		protected internal TreasureHuntEntrantLivePacket(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x0000D29E File Offset: 0x0000C29E
		protected internal unsafe TreasureHuntEntrantLivePacket(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000A4A RID: 2634
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1038();

		// Token: 0x06000A4B RID: 2635 RVA: 0x0000D2A8 File Offset: 0x0000C2A8
		public TreasureHuntEntrantLivePacket() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = TreasureHuntEntrantLivePacket._EASharpBinding_1038();
		}

		// Token: 0x06000A4C RID: 2636
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1039(void* _ThisPtr);

		// Token: 0x06000A4D RID: 2637 RVA: 0x0000D2D0 File Offset: 0x0000C2D0
		~TreasureHuntEntrantLivePacket()
		{
			TreasureHuntEntrantLivePacket._EASharpBinding_1039(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000A4E RID: 2638
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1040(void* self, int val);

		// Token: 0x06000A4F RID: 2639
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1041(void* self);

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000A50 RID: 2640 RVA: 0x0000D30C File Offset: 0x0000C30C
		// (set) Token: 0x06000A51 RID: 2641 RVA: 0x0000D319 File Offset: 0x0000C319
		public int NumCoinsCollected
		{
			get
			{
				return TreasureHuntEntrantLivePacket._EASharpBinding_1041(this.mSelf);
			}
			set
			{
				TreasureHuntEntrantLivePacket._EASharpBinding_1040(this.mSelf, value);
			}
		}
	}
}
