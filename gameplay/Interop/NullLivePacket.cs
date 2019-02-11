using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x020000BF RID: 191
	[ExportOnlyCreate(true)]
	public class NullLivePacket : LivePacket
	{
		// Token: 0x06000B42 RID: 2882 RVA: 0x0000E2F4 File Offset: 0x0000D2F4
		public new unsafe static NullLivePacket CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new NullLivePacket(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x0000E317 File Offset: 0x0000D317
		public unsafe NullLivePacket(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x0000E321 File Offset: 0x0000D321
		protected internal NullLivePacket(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x0000E32A File Offset: 0x0000D32A
		protected internal unsafe NullLivePacket(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000B46 RID: 2886
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1142();

		// Token: 0x06000B47 RID: 2887 RVA: 0x0000E334 File Offset: 0x0000D334
		public NullLivePacket() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = NullLivePacket._EASharpBinding_1142();
		}

		// Token: 0x06000B48 RID: 2888
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1143(void* _ThisPtr);

		// Token: 0x06000B49 RID: 2889 RVA: 0x0000E35C File Offset: 0x0000D35C
		~NullLivePacket()
		{
			NullLivePacket._EASharpBinding_1143(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000B4A RID: 2890
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1144(void* _ThisPtr);

		// Token: 0x06000B4B RID: 2891 RVA: 0x0000E398 File Offset: 0x0000D398
		public override void Reset()
		{
			NullLivePacket._EASharpBinding_1144(this.mSelf);
		}

		// Token: 0x06000B4C RID: 2892
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1145(void* _ThisPtr);

		// Token: 0x06000B4D RID: 2893 RVA: 0x0000E3A8 File Offset: 0x0000D3A8
		public NullEntrantLivePacket CreateEntrantLivePacket()
		{
			return NullEntrantLivePacket.CreateInitUnowned(NullLivePacket._EASharpBinding_1145(this.mSelf));
		}
	}
}
