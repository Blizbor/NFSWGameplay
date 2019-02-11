using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x02000057 RID: 87
	[ExportOnlyCreate(true)]
	public class BlackBoardFlags : ExposedCommonBase
	{
		// Token: 0x060003F0 RID: 1008 RVA: 0x00005F4C File Offset: 0x00004F4C
		public unsafe static BlackBoardFlags CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new BlackBoardFlags(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00005F6F File Offset: 0x00004F6F
		public unsafe BlackBoardFlags(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00005F79 File Offset: 0x00004F79
		protected internal BlackBoardFlags(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00005F82 File Offset: 0x00004F82
		protected internal unsafe BlackBoardFlags(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060003F4 RID: 1012
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_397(void* self);

		// Token: 0x060003F5 RID: 1013 RVA: 0x00005F8C File Offset: 0x00004F8C
		[DisableExceptionHandling]
		~BlackBoardFlags()
		{
			BlackBoardFlags._EASharpBinding_397(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060003F6 RID: 1014
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_398(void* self, uint val);

		// Token: 0x060003F7 RID: 1015
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_399(void* self);

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x00005FC8 File Offset: 0x00004FC8
		// (set) Token: 0x060003F9 RID: 1017 RVA: 0x00005FD5 File Offset: 0x00004FD5
		public uint mBits
		{
			get
			{
				return BlackBoardFlags._EASharpBinding_399(this.mSelf);
			}
			set
			{
				BlackBoardFlags._EASharpBinding_398(this.mSelf, value);
			}
		}
	}
}
