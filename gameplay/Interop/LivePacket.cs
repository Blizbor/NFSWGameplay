using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x020000AB RID: 171
	[ExportOnlyCreate(true)]
	public class LivePacket : ISerializable
	{
		// Token: 0x060009B6 RID: 2486 RVA: 0x0000C9C8 File Offset: 0x0000B9C8
		public new unsafe static LivePacket CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new LivePacket(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x0000C9EB File Offset: 0x0000B9EB
		public unsafe LivePacket(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x0000C9F5 File Offset: 0x0000B9F5
		protected internal LivePacket(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x0000C9FE File Offset: 0x0000B9FE
		protected internal unsafe LivePacket(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060009BA RID: 2490
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_984();

		// Token: 0x060009BB RID: 2491 RVA: 0x0000CA08 File Offset: 0x0000BA08
		public LivePacket() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = LivePacket._EASharpBinding_984();
		}

		// Token: 0x060009BC RID: 2492
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_985(void* _ThisPtr);

		// Token: 0x060009BD RID: 2493 RVA: 0x0000CA30 File Offset: 0x0000BA30
		~LivePacket()
		{
			LivePacket._EASharpBinding_985(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060009BE RID: 2494
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_986(void* _ThisPtr);

		// Token: 0x060009BF RID: 2495 RVA: 0x0000CA6C File Offset: 0x0000BA6C
		public virtual void Reset()
		{
			LivePacket._EASharpBinding_986(this.mSelf);
		}
	}
}
