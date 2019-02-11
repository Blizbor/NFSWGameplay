using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x02000069 RID: 105
	[ExportOnlyCreate(false)]
	public class TrackLayoutDefinition : InternalInstance
	{
		// Token: 0x060004E2 RID: 1250 RVA: 0x000070CC File Offset: 0x000060CC
		public new unsafe static TrackLayoutDefinition CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new TrackLayoutDefinition(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x000070EF File Offset: 0x000060EF
		public unsafe TrackLayoutDefinition(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x000070F9 File Offset: 0x000060F9
		protected internal TrackLayoutDefinition(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00007102 File Offset: 0x00006102
		protected internal unsafe TrackLayoutDefinition(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060004E6 RID: 1254
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_486(void* eventKey, void* vault);

		// Token: 0x060004E7 RID: 1255 RVA: 0x0000710C File Offset: 0x0000610C
		public unsafe TrackLayoutDefinition(void* eventKey, void* vault) : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = TrackLayoutDefinition._EASharpBinding_486(eventKey, vault);
		}

		// Token: 0x060004E8 RID: 1256
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_487(void* _ThisPtr);

		// Token: 0x060004E9 RID: 1257 RVA: 0x00007138 File Offset: 0x00006138
		~TrackLayoutDefinition()
		{
			TrackLayoutDefinition._EASharpBinding_487(this.mSelf);
			this.mSelf = null;
		}
	}
}
