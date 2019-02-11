using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x02000047 RID: 71
	[ExportOnlyCreate(false)]
	public class InternalTrigger : InternalInstance
	{
		// Token: 0x06000316 RID: 790 RVA: 0x00005114 File Offset: 0x00004114
		public new unsafe static InternalTrigger CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new InternalTrigger(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00005137 File Offset: 0x00004137
		public unsafe InternalTrigger(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00005141 File Offset: 0x00004141
		protected internal InternalTrigger(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0000514A File Offset: 0x0000414A
		protected internal unsafe InternalTrigger(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600031A RID: 794
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_320(void* self);

		// Token: 0x0600031B RID: 795 RVA: 0x00005154 File Offset: 0x00004154
		[DisableExceptionHandling]
		~InternalTrigger()
		{
			InternalTrigger._EASharpBinding_320(this.mSelf);
			this.mSelf = null;
		}
	}
}
