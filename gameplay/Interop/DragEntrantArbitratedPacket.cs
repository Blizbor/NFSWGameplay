using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x020000D4 RID: 212
	[ExportOnlyCreate(true)]
	public class DragEntrantArbitratedPacket : EntrantArbitratedPacket
	{
		// Token: 0x06000D08 RID: 3336 RVA: 0x0000FE14 File Offset: 0x0000EE14
		public new unsafe static DragEntrantArbitratedPacket CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new DragEntrantArbitratedPacket(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x0000FE37 File Offset: 0x0000EE37
		public unsafe DragEntrantArbitratedPacket(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x0000FE41 File Offset: 0x0000EE41
		protected internal DragEntrantArbitratedPacket(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x0000FE4A File Offset: 0x0000EE4A
		protected internal unsafe DragEntrantArbitratedPacket(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000D0C RID: 3340
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1327();

		// Token: 0x06000D0D RID: 3341 RVA: 0x0000FE54 File Offset: 0x0000EE54
		public DragEntrantArbitratedPacket() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = DragEntrantArbitratedPacket._EASharpBinding_1327();
		}

		// Token: 0x06000D0E RID: 3342
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1328(void* _ThisPtr);

		// Token: 0x06000D0F RID: 3343 RVA: 0x0000FE7C File Offset: 0x0000EE7C
		~DragEntrantArbitratedPacket()
		{
			DragEntrantArbitratedPacket._EASharpBinding_1328(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000D10 RID: 3344
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1329(void* self, float val);

		// Token: 0x06000D11 RID: 3345
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_1330(void* self);

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000D12 RID: 3346 RVA: 0x0000FEB8 File Offset: 0x0000EEB8
		// (set) Token: 0x06000D13 RID: 3347 RVA: 0x0000FEC5 File Offset: 0x0000EEC5
		public float TopSpeed
		{
			get
			{
				return DragEntrantArbitratedPacket._EASharpBinding_1330(this.mSelf);
			}
			set
			{
				DragEntrantArbitratedPacket._EASharpBinding_1329(this.mSelf, value);
			}
		}
	}
}
