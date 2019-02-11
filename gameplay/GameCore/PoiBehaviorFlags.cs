using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x02000059 RID: 89
	[ExportOnlyCreate(true)]
	public class PoiBehaviorFlags : ExposedCommonBase
	{
		// Token: 0x0600040C RID: 1036 RVA: 0x0000610C File Offset: 0x0000510C
		public unsafe static PoiBehaviorFlags CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new PoiBehaviorFlags(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0000612F File Offset: 0x0000512F
		public unsafe PoiBehaviorFlags(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00006139 File Offset: 0x00005139
		protected internal PoiBehaviorFlags(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00006142 File Offset: 0x00005142
		protected internal unsafe PoiBehaviorFlags(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000410 RID: 1040
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_407(void* self);

		// Token: 0x06000411 RID: 1041 RVA: 0x0000614C File Offset: 0x0000514C
		[DisableExceptionHandling]
		~PoiBehaviorFlags()
		{
			PoiBehaviorFlags._EASharpBinding_407(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000412 RID: 1042
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_408(void* self, uint val);

		// Token: 0x06000413 RID: 1043
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_409(void* self);

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x00006188 File Offset: 0x00005188
		// (set) Token: 0x06000415 RID: 1045 RVA: 0x00006195 File Offset: 0x00005195
		public uint mBits
		{
			get
			{
				return PoiBehaviorFlags._EASharpBinding_409(this.mSelf);
			}
			set
			{
				PoiBehaviorFlags._EASharpBinding_408(this.mSelf, value);
			}
		}
	}
}
