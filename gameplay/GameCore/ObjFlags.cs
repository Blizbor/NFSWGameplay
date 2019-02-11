using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x02000053 RID: 83
	[ExportOnlyCreate(true)]
	public class ObjFlags : ExposedCommonBase
	{
		// Token: 0x060003C2 RID: 962 RVA: 0x00005C30 File Offset: 0x00004C30
		public unsafe static ObjFlags CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new ObjFlags(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00005C53 File Offset: 0x00004C53
		public unsafe ObjFlags(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00005C5D File Offset: 0x00004C5D
		protected internal ObjFlags(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00005C66 File Offset: 0x00004C66
		protected internal unsafe ObjFlags(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060003C6 RID: 966
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_382(void* self);

		// Token: 0x060003C7 RID: 967 RVA: 0x00005C70 File Offset: 0x00004C70
		[DisableExceptionHandling]
		~ObjFlags()
		{
			ObjFlags._EASharpBinding_382(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060003C8 RID: 968
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_383(void* self, uint val);

		// Token: 0x060003C9 RID: 969
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_384(void* self);

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060003CA RID: 970 RVA: 0x00005CAC File Offset: 0x00004CAC
		// (set) Token: 0x060003CB RID: 971 RVA: 0x00005CB9 File Offset: 0x00004CB9
		public uint mBits
		{
			get
			{
				return ObjFlags._EASharpBinding_384(this.mSelf);
			}
			set
			{
				ObjFlags._EASharpBinding_383(this.mSelf, value);
			}
		}
	}
}
