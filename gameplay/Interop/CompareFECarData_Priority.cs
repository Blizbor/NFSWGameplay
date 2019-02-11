using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x02000098 RID: 152
	[ExportOnlyCreate(true)]
	public class CompareFECarData_Priority : ExposedCommonBase
	{
		// Token: 0x060007F6 RID: 2038 RVA: 0x0000A9C8 File Offset: 0x000099C8
		public unsafe static CompareFECarData_Priority CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new CompareFECarData_Priority(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x0000A9EB File Offset: 0x000099EB
		public unsafe CompareFECarData_Priority(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x0000A9F5 File Offset: 0x000099F5
		protected internal CompareFECarData_Priority(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x0000A9FE File Offset: 0x000099FE
		protected internal unsafe CompareFECarData_Priority(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060007FA RID: 2042
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_797(void* self);

		// Token: 0x060007FB RID: 2043 RVA: 0x0000AA08 File Offset: 0x00009A08
		[DisableExceptionHandling]
		~CompareFECarData_Priority()
		{
			CompareFECarData_Priority._EASharpBinding_797(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060007FC RID: 2044
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_798();

		// Token: 0x060007FD RID: 2045 RVA: 0x0000AA44 File Offset: 0x00009A44
		public CompareFECarData_Priority() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = CompareFECarData_Priority._EASharpBinding_798();
		}
	}
}
