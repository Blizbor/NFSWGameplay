using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Commerce
{
	// Token: 0x0200010C RID: 268
	[ExportOnlyCreate(true)]
	public class LocalizedString : ExposedCommonBase
	{
		// Token: 0x06000E5A RID: 3674 RVA: 0x0001109C File Offset: 0x0001009C
		public unsafe static LocalizedString CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new LocalizedString(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x000110BF File Offset: 0x000100BF
		public unsafe LocalizedString(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x000110C9 File Offset: 0x000100C9
		protected internal LocalizedString(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x000110D2 File Offset: 0x000100D2
		protected internal unsafe LocalizedString(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000E5E RID: 3678
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1461(void* self);

		// Token: 0x06000E5F RID: 3679 RVA: 0x000110DC File Offset: 0x000100DC
		[DisableExceptionHandling]
		~LocalizedString()
		{
			LocalizedString._EASharpBinding_1461(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000E60 RID: 3680
		[DllImport("<internal>")]
		private unsafe static extern sbyte* _EASharpBinding_1463(void* self);

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000E61 RID: 3681 RVA: 0x00011118 File Offset: 0x00010118
		public string HalId
		{
			get
			{
				return InternalUtil.ConvertFromCString(LocalizedString._EASharpBinding_1463(this.mSelf));
			}
		}
	}
}
