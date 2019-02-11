using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x020000C6 RID: 198
	[ExportOnlyCreate(true)]
	public class CompareFilter_Alphabetical : ExposedCommonBase
	{
		// Token: 0x06000BCC RID: 3020 RVA: 0x0000EB74 File Offset: 0x0000DB74
		public unsafe static CompareFilter_Alphabetical CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new CompareFilter_Alphabetical(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x0000EB97 File Offset: 0x0000DB97
		public unsafe CompareFilter_Alphabetical(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x0000EBA1 File Offset: 0x0000DBA1
		protected internal CompareFilter_Alphabetical(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x0000EBAA File Offset: 0x0000DBAA
		protected internal unsafe CompareFilter_Alphabetical(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000BD0 RID: 3024
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1197(void* self);

		// Token: 0x06000BD1 RID: 3025 RVA: 0x0000EBB4 File Offset: 0x0000DBB4
		[DisableExceptionHandling]
		~CompareFilter_Alphabetical()
		{
			CompareFilter_Alphabetical._EASharpBinding_1197(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000BD2 RID: 3026
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1198();

		// Token: 0x06000BD3 RID: 3027 RVA: 0x0000EBF0 File Offset: 0x0000DBF0
		public CompareFilter_Alphabetical() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = CompareFilter_Alphabetical._EASharpBinding_1198();
		}
	}
}
