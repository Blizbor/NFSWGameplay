using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x020000B3 RID: 179
	[ExportOnlyCreate(true)]
	public class DragLivePacket : LivePacket
	{
		// Token: 0x06000A3A RID: 2618 RVA: 0x0000D194 File Offset: 0x0000C194
		public new unsafe static DragLivePacket CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new DragLivePacket(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x0000D1B7 File Offset: 0x0000C1B7
		public unsafe DragLivePacket(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x0000D1C1 File Offset: 0x0000C1C1
		protected internal DragLivePacket(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x0000D1CA File Offset: 0x0000C1CA
		protected internal unsafe DragLivePacket(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000A3E RID: 2622
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1034();

		// Token: 0x06000A3F RID: 2623 RVA: 0x0000D1D4 File Offset: 0x0000C1D4
		public DragLivePacket() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = DragLivePacket._EASharpBinding_1034();
		}

		// Token: 0x06000A40 RID: 2624
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1035(void* _ThisPtr);

		// Token: 0x06000A41 RID: 2625 RVA: 0x0000D1FC File Offset: 0x0000C1FC
		~DragLivePacket()
		{
			DragLivePacket._EASharpBinding_1035(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000A42 RID: 2626
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1036(void* _ThisPtr);

		// Token: 0x06000A43 RID: 2627 RVA: 0x0000D238 File Offset: 0x0000C238
		public override void Reset()
		{
			DragLivePacket._EASharpBinding_1036(this.mSelf);
		}

		// Token: 0x06000A44 RID: 2628
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1037(void* _ThisPtr);

		// Token: 0x06000A45 RID: 2629 RVA: 0x0000D248 File Offset: 0x0000C248
		public DragEntrantLivePacket CreateEntrantLivePacket()
		{
			return DragEntrantLivePacket.CreateInitUnowned(DragLivePacket._EASharpBinding_1037(this.mSelf));
		}
	}
}
