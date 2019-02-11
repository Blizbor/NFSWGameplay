using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x0200004E RID: 78
	[ExportOnlyCreate(false)]
	public class PointOfInterestDefinition : InternalInstance
	{
		// Token: 0x0600037A RID: 890 RVA: 0x000056FC File Offset: 0x000046FC
		public new unsafe static PointOfInterestDefinition CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new PointOfInterestDefinition(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0000571F File Offset: 0x0000471F
		public unsafe PointOfInterestDefinition(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00005729 File Offset: 0x00004729
		protected internal PointOfInterestDefinition(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00005732 File Offset: 0x00004732
		protected internal unsafe PointOfInterestDefinition(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600037E RID: 894
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_356(void* self);

		// Token: 0x0600037F RID: 895 RVA: 0x0000573C File Offset: 0x0000473C
		[DisableExceptionHandling]
		~PointOfInterestDefinition()
		{
			PointOfInterestDefinition._EASharpBinding_356(this.mSelf);
			this.mSelf = null;
		}
	}
}
