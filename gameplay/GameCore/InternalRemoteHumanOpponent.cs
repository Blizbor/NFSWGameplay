using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x02000074 RID: 116
	[ExportOnlyCreate(false)]
	public class InternalRemoteHumanOpponent : InternalOpponent
	{
		// Token: 0x060005DA RID: 1498 RVA: 0x0000837C File Offset: 0x0000737C
		public new unsafe static InternalRemoteHumanOpponent CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new InternalRemoteHumanOpponent(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x0000839F File Offset: 0x0000739F
		public unsafe InternalRemoteHumanOpponent(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x000083A9 File Offset: 0x000073A9
		protected internal InternalRemoteHumanOpponent(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x000083B2 File Offset: 0x000073B2
		protected internal unsafe InternalRemoteHumanOpponent(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060005DE RID: 1502
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_591(void* self);

		// Token: 0x060005DF RID: 1503 RVA: 0x000083BC File Offset: 0x000073BC
		[DisableExceptionHandling]
		~InternalRemoteHumanOpponent()
		{
			InternalRemoteHumanOpponent._EASharpBinding_591(this.mSelf);
			this.mSelf = null;
		}
	}
}
