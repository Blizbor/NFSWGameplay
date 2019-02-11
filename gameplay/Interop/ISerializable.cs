using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x0200008D RID: 141
	[ExportOnlyCreate(true)]
	public class ISerializable : ExposedCommonBase
	{
		// Token: 0x060006B0 RID: 1712 RVA: 0x000090D0 File Offset: 0x000080D0
		public unsafe static ISerializable CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new ISerializable(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x000090F3 File Offset: 0x000080F3
		public unsafe ISerializable(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x000090FD File Offset: 0x000080FD
		protected internal ISerializable(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00009106 File Offset: 0x00008106
		protected internal unsafe ISerializable(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060006B4 RID: 1716
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_656(void* _ThisPtr);

		// Token: 0x060006B5 RID: 1717 RVA: 0x00009110 File Offset: 0x00008110
		~ISerializable()
		{
			ISerializable._EASharpBinding_656(this.mSelf);
			this.mSelf = null;
		}
	}
}
