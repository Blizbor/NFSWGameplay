using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x0200002B RID: 43
	[ExportOnlyCreate(false)]
	public class Character : InternalInstance
	{
		// Token: 0x060000B8 RID: 184 RVA: 0x00002C74 File Offset: 0x00001C74
		public new unsafe static Character CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new Character(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002C97 File Offset: 0x00001C97
		public unsafe Character(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002CA1 File Offset: 0x00001CA1
		protected internal Character(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002CAA File Offset: 0x00001CAA
		protected internal unsafe Character(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060000BC RID: 188
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_34(void* characterKey, void* vault);

		// Token: 0x060000BD RID: 189 RVA: 0x00002CB4 File Offset: 0x00001CB4
		public unsafe Character(void* characterKey, void* vault) : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = Character._EASharpBinding_34(characterKey, vault);
		}

		// Token: 0x060000BE RID: 190
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_35(void* _ThisPtr);

		// Token: 0x060000BF RID: 191 RVA: 0x00002CE0 File Offset: 0x00001CE0
		~Character()
		{
			Character._EASharpBinding_35(this.mSelf);
			this.mSelf = null;
		}
	}
}
