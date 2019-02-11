using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x02000072 RID: 114
	[ExportOnlyCreate(false)]
	public class InternalLocalArtificalOpponent : InternalOpponent
	{
		// Token: 0x060005C0 RID: 1472 RVA: 0x000081F8 File Offset: 0x000071F8
		public new unsafe static InternalLocalArtificalOpponent CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new InternalLocalArtificalOpponent(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x0000821B File Offset: 0x0000721B
		public unsafe InternalLocalArtificalOpponent(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00008225 File Offset: 0x00007225
		protected internal InternalLocalArtificalOpponent(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x0000822E File Offset: 0x0000722E
		protected internal unsafe InternalLocalArtificalOpponent(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060005C4 RID: 1476
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_582(void* self);

		// Token: 0x060005C5 RID: 1477 RVA: 0x00008238 File Offset: 0x00007238
		[DisableExceptionHandling]
		~InternalLocalArtificalOpponent()
		{
			InternalLocalArtificalOpponent._EASharpBinding_582(this.mSelf);
			this.mSelf = null;
		}
	}
}
