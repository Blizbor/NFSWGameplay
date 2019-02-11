using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x0200003B RID: 59
	[ExportOnlyCreate(false)]
	public class InternalEffects : ExposedCommonBase
	{
		// Token: 0x060001BA RID: 442 RVA: 0x00003E30 File Offset: 0x00002E30
		public unsafe static InternalEffects CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new InternalEffects(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00003E53 File Offset: 0x00002E53
		public unsafe InternalEffects(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00003E5D File Offset: 0x00002E5D
		protected internal InternalEffects(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00003E66 File Offset: 0x00002E66
		protected internal unsafe InternalEffects(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060001BE RID: 446
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_157();

		// Token: 0x060001BF RID: 447 RVA: 0x00003E70 File Offset: 0x00002E70
		public static InternalEffects Get()
		{
			return InternalEffects.CreateInitUnowned(InternalEffects._EASharpBinding_157());
		}

		// Token: 0x060001C0 RID: 448
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_158(void* _ThisPtr, object effects);

		// Token: 0x060001C1 RID: 449 RVA: 0x00003E89 File Offset: 0x00002E89
		public void Ready(Effects effects)
		{
			InternalEffects._EASharpBinding_158(this.mSelf, effects);
		}

		// Token: 0x060001C2 RID: 450
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_159(void* _ThisPtr);

		// Token: 0x060001C3 RID: 451 RVA: 0x00003E97 File Offset: 0x00002E97
		public void Cleanup()
		{
			InternalEffects._EASharpBinding_159(this.mSelf);
		}
	}
}
