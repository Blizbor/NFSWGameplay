using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x02000071 RID: 113
	[ExportOnlyCreate(false)]
	public class IInternalBehaviorOwner : ExposedCommonBase
	{
		// Token: 0x060005BA RID: 1466 RVA: 0x0000817C File Offset: 0x0000717C
		public unsafe static IInternalBehaviorOwner CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new IInternalBehaviorOwner(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x0000819F File Offset: 0x0000719F
		public unsafe IInternalBehaviorOwner(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x000081A9 File Offset: 0x000071A9
		protected internal IInternalBehaviorOwner(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x000081B2 File Offset: 0x000071B2
		protected internal unsafe IInternalBehaviorOwner(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060005BE RID: 1470
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_581(void* self);

		// Token: 0x060005BF RID: 1471 RVA: 0x000081BC File Offset: 0x000071BC
		[DisableExceptionHandling]
		~IInternalBehaviorOwner()
		{
			IInternalBehaviorOwner._EASharpBinding_581(this.mSelf);
			this.mSelf = null;
		}
	}
}
