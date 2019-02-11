using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x02000043 RID: 67
	[ExportOnlyCreate(false)]
	public class InternalMarker : InternalInstance
	{
		// Token: 0x060002A0 RID: 672 RVA: 0x00004A9C File Offset: 0x00003A9C
		public new unsafe static InternalMarker CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new InternalMarker(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00004ABF File Offset: 0x00003ABF
		public unsafe InternalMarker(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00004AC9 File Offset: 0x00003AC9
		protected internal InternalMarker(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00004AD2 File Offset: 0x00003AD2
		protected internal unsafe InternalMarker(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060002A4 RID: 676
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_268(void* self);

		// Token: 0x060002A5 RID: 677 RVA: 0x00004ADC File Offset: 0x00003ADC
		[DisableExceptionHandling]
		~InternalMarker()
		{
			InternalMarker._EASharpBinding_268(this.mSelf);
			this.mSelf = null;
		}
	}
}
