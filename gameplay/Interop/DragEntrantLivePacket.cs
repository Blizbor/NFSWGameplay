using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x020000B2 RID: 178
	[ExportOnlyCreate(true)]
	public class DragEntrantLivePacket : EntrantLivePacket
	{
		// Token: 0x06000A2C RID: 2604 RVA: 0x0000D0B4 File Offset: 0x0000C0B4
		public new unsafe static DragEntrantLivePacket CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new DragEntrantLivePacket(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x0000D0D7 File Offset: 0x0000C0D7
		public unsafe DragEntrantLivePacket(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x0000D0E1 File Offset: 0x0000C0E1
		protected internal DragEntrantLivePacket(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x0000D0EA File Offset: 0x0000C0EA
		protected internal unsafe DragEntrantLivePacket(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000A30 RID: 2608
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1029();

		// Token: 0x06000A31 RID: 2609 RVA: 0x0000D0F4 File Offset: 0x0000C0F4
		public DragEntrantLivePacket() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = DragEntrantLivePacket._EASharpBinding_1029();
		}

		// Token: 0x06000A32 RID: 2610
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1030(void* _ThisPtr);

		// Token: 0x06000A33 RID: 2611 RVA: 0x0000D11C File Offset: 0x0000C11C
		~DragEntrantLivePacket()
		{
			DragEntrantLivePacket._EASharpBinding_1030(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000A34 RID: 2612
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1031(void* _ThisPtr);

		// Token: 0x06000A35 RID: 2613 RVA: 0x0000D158 File Offset: 0x0000C158
		public TimeSpan GetElapsedTime()
		{
			return TimeSpan.CreateInitUnowned(DragEntrantLivePacket._EASharpBinding_1031(this.mSelf));
		}

		// Token: 0x06000A36 RID: 2614
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1032(void* self, float val);

		// Token: 0x06000A37 RID: 2615
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_1033(void* self);

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000A38 RID: 2616 RVA: 0x0000D177 File Offset: 0x0000C177
		// (set) Token: 0x06000A39 RID: 2617 RVA: 0x0000D184 File Offset: 0x0000C184
		public float Percentage
		{
			get
			{
				return DragEntrantLivePacket._EASharpBinding_1033(this.mSelf);
			}
			set
			{
				DragEntrantLivePacket._EASharpBinding_1032(this.mSelf, value);
			}
		}
	}
}
