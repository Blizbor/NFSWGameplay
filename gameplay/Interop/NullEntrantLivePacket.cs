using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x020000BE RID: 190
	[ExportOnlyCreate(true)]
	public class NullEntrantLivePacket : EntrantLivePacket
	{
		// Token: 0x06000B3A RID: 2874 RVA: 0x0000E250 File Offset: 0x0000D250
		public new unsafe static NullEntrantLivePacket CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new NullEntrantLivePacket(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x0000E273 File Offset: 0x0000D273
		public unsafe NullEntrantLivePacket(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x0000E27D File Offset: 0x0000D27D
		protected internal NullEntrantLivePacket(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x0000E286 File Offset: 0x0000D286
		protected internal unsafe NullEntrantLivePacket(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000B3E RID: 2878
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1140();

		// Token: 0x06000B3F RID: 2879 RVA: 0x0000E290 File Offset: 0x0000D290
		public NullEntrantLivePacket() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = NullEntrantLivePacket._EASharpBinding_1140();
		}

		// Token: 0x06000B40 RID: 2880
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1141(void* _ThisPtr);

		// Token: 0x06000B41 RID: 2881 RVA: 0x0000E2B8 File Offset: 0x0000D2B8
		~NullEntrantLivePacket()
		{
			NullEntrantLivePacket._EASharpBinding_1141(this.mSelf);
			this.mSelf = null;
		}
	}
}
