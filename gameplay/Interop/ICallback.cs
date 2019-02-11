using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x020000DB RID: 219
	[ExportOnlyCreate(false)]
	public class ICallback : ExposedCommonBase
	{
		// Token: 0x06000D7C RID: 3452 RVA: 0x0001048C File Offset: 0x0000F48C
		public unsafe static ICallback CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new ICallback(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x000104AF File Offset: 0x0000F4AF
		public unsafe ICallback(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x000104B9 File Offset: 0x0000F4B9
		protected internal ICallback(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x000104C2 File Offset: 0x0000F4C2
		protected internal unsafe ICallback(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000D80 RID: 3456
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1371(void* _ThisPtr);

		// Token: 0x06000D81 RID: 3457 RVA: 0x000104CC File Offset: 0x0000F4CC
		~ICallback()
		{
			ICallback._EASharpBinding_1371(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000D82 RID: 3458
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1372(void* _ThisPtr, void* iserializable);

		// Token: 0x06000D83 RID: 3459 RVA: 0x00010508 File Offset: 0x0000F508
		public void Respond(ISerializable iserializable)
		{
			ICallback._EASharpBinding_1372(this.mSelf, object.ReferenceEquals(iserializable, null) ? null : iserializable._GetRaw());
		}

		// Token: 0x06000D84 RID: 3460
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1373(void* _ThisPtr);

		// Token: 0x06000D85 RID: 3461 RVA: 0x00010528 File Offset: 0x0000F528
		public void Respond()
		{
			ICallback._EASharpBinding_1373(this.mSelf);
		}

		// Token: 0x06000D86 RID: 3462
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1374(void* _ThisPtr);

		// Token: 0x06000D87 RID: 3463 RVA: 0x00010535 File Offset: 0x0000F535
		public void Abort()
		{
			ICallback._EASharpBinding_1374(this.mSelf);
		}

		// Token: 0x06000D88 RID: 3464
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1375(void* _ThisPtr);

		// Token: 0x06000D89 RID: 3465 RVA: 0x00010542 File Offset: 0x0000F542
		public void Destroy()
		{
			ICallback._EASharpBinding_1375(this.mSelf);
		}
	}
}
