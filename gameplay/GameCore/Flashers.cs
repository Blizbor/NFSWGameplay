using System;
using System.Runtime.InteropServices;
using EASharp;
using Interop;

namespace GameCore
{
	// Token: 0x0200002E RID: 46
	[ExportOnlyCreate(false)]
	public class Flashers : ExposedCommonBase
	{
		// Token: 0x060000F8 RID: 248 RVA: 0x0000305C File Offset: 0x0000205C
		public unsafe static Flashers CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new Flashers(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000307F File Offset: 0x0000207F
		public unsafe Flashers(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00003089 File Offset: 0x00002089
		protected internal Flashers(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00003092 File Offset: 0x00002092
		protected internal unsafe Flashers(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060000FC RID: 252
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_61(void* self);

		// Token: 0x060000FD RID: 253 RVA: 0x0000309C File Offset: 0x0000209C
		[DisableExceptionHandling]
		~Flashers()
		{
			Flashers._EASharpBinding_61(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060000FE RID: 254
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_62(void* flasher);

		// Token: 0x060000FF RID: 255 RVA: 0x000030D8 File Offset: 0x000020D8
		public static void AddFlasher(FrontendFlasher flasher)
		{
			Flashers._EASharpBinding_62(object.ReferenceEquals(flasher, null) ? null : flasher._GetRaw());
		}

		// Token: 0x06000100 RID: 256
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_63(int flasher_handle);

		// Token: 0x06000101 RID: 257 RVA: 0x000030F2 File Offset: 0x000020F2
		public static void CancelFlasher(int flasher_handle)
		{
			Flashers._EASharpBinding_63(flasher_handle);
		}

		// Token: 0x06000102 RID: 258
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_64(int flasher_handle);

		// Token: 0x06000103 RID: 259 RVA: 0x000030FA File Offset: 0x000020FA
		public static void KillFlasher(int flasher_handle)
		{
			Flashers._EASharpBinding_64(flasher_handle);
		}
	}
}
