using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x02000054 RID: 84
	[ExportOnlyCreate(false)]
	public class StringKey : ExposedCommonBase
	{
		// Token: 0x060003CC RID: 972 RVA: 0x00005CC8 File Offset: 0x00004CC8
		public unsafe static StringKey CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new StringKey(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00005CEB File Offset: 0x00004CEB
		public unsafe StringKey(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00005CF5 File Offset: 0x00004CF5
		protected internal StringKey(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00005CFE File Offset: 0x00004CFE
		protected internal unsafe StringKey(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060003D0 RID: 976
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_385(void* self);

		// Token: 0x060003D1 RID: 977 RVA: 0x00005D08 File Offset: 0x00004D08
		[DisableExceptionHandling]
		~StringKey()
		{
			StringKey._EASharpBinding_385(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060003D2 RID: 978
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_386(void* _ThisPtr);

		// Token: 0x060003D3 RID: 979 RVA: 0x00005D44 File Offset: 0x00004D44
		public uint GetKey()
		{
			return StringKey._EASharpBinding_386(this.mSelf);
		}
	}
}
