using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x02000044 RID: 68
	[ExportOnlyCreate(false)]
	public class InternalMilestone : InternalInstance
	{
		// Token: 0x060002A6 RID: 678 RVA: 0x00004B18 File Offset: 0x00003B18
		public new unsafe static InternalMilestone CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new InternalMilestone(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00004B3B File Offset: 0x00003B3B
		public unsafe InternalMilestone(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00004B45 File Offset: 0x00003B45
		protected internal InternalMilestone(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00004B4E File Offset: 0x00003B4E
		protected internal unsafe InternalMilestone(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060002AA RID: 682
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_269(void* self);

		// Token: 0x060002AB RID: 683 RVA: 0x00004B58 File Offset: 0x00003B58
		[DisableExceptionHandling]
		~InternalMilestone()
		{
			InternalMilestone._EASharpBinding_269(this.mSelf);
			this.mSelf = null;
		}
	}
}
