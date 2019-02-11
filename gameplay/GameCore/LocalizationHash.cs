using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x0200005A RID: 90
	[ExportOnlyCreate(true)]
	public class LocalizationHash : ExposedCommonBase
	{
		// Token: 0x06000416 RID: 1046 RVA: 0x000061A4 File Offset: 0x000051A4
		public unsafe static LocalizationHash CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new LocalizationHash(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x000061C7 File Offset: 0x000051C7
		public unsafe LocalizationHash(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x000061D1 File Offset: 0x000051D1
		protected internal LocalizationHash(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x000061DA File Offset: 0x000051DA
		protected internal unsafe LocalizationHash(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600041A RID: 1050
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_410(void* self);

		// Token: 0x0600041B RID: 1051 RVA: 0x000061E4 File Offset: 0x000051E4
		[DisableExceptionHandling]
		~LocalizationHash()
		{
			LocalizationHash._EASharpBinding_410(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x0600041C RID: 1052
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_411(void* self, uint val);

		// Token: 0x0600041D RID: 1053
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_412(void* self);

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x00006220 File Offset: 0x00005220
		// (set) Token: 0x0600041F RID: 1055 RVA: 0x0000622D File Offset: 0x0000522D
		public uint Hash
		{
			get
			{
				return LocalizationHash._EASharpBinding_412(this.mSelf);
			}
			set
			{
				LocalizationHash._EASharpBinding_411(this.mSelf, value);
			}
		}
	}
}
