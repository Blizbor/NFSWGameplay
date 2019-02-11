using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x02000097 RID: 151
	[ExportOnlyCreate(true)]
	public class CompareFECarData_ModelAlphabetical : ExposedCommonBase
	{
		// Token: 0x060007EE RID: 2030 RVA: 0x0000A924 File Offset: 0x00009924
		public unsafe static CompareFECarData_ModelAlphabetical CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new CompareFECarData_ModelAlphabetical(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x0000A947 File Offset: 0x00009947
		public unsafe CompareFECarData_ModelAlphabetical(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x0000A951 File Offset: 0x00009951
		protected internal CompareFECarData_ModelAlphabetical(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x0000A95A File Offset: 0x0000995A
		protected internal unsafe CompareFECarData_ModelAlphabetical(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060007F2 RID: 2034
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_795(void* self);

		// Token: 0x060007F3 RID: 2035 RVA: 0x0000A964 File Offset: 0x00009964
		[DisableExceptionHandling]
		~CompareFECarData_ModelAlphabetical()
		{
			CompareFECarData_ModelAlphabetical._EASharpBinding_795(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060007F4 RID: 2036
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_796();

		// Token: 0x060007F5 RID: 2037 RVA: 0x0000A9A0 File Offset: 0x000099A0
		public CompareFECarData_ModelAlphabetical() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = CompareFECarData_ModelAlphabetical._EASharpBinding_796();
		}
	}
}
