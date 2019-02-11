using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x0200005D RID: 93
	[ExportOnlyCreate(false)]
	public class Render : ExposedCommonBase
	{
		// Token: 0x06000438 RID: 1080 RVA: 0x000063B4 File Offset: 0x000053B4
		public unsafe static Render CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new Render(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x000063D7 File Offset: 0x000053D7
		public unsafe Render(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x000063E1 File Offset: 0x000053E1
		protected internal Render(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x000063EA File Offset: 0x000053EA
		protected internal unsafe Render(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600043C RID: 1084
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_421(void* self);

		// Token: 0x0600043D RID: 1085 RVA: 0x000063F4 File Offset: 0x000053F4
		[DisableExceptionHandling]
		~Render()
		{
			Render._EASharpBinding_421(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x0600043E RID: 1086
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_422(int type);

		// Token: 0x0600043F RID: 1087 RVA: 0x00006430 File Offset: 0x00005430
		public static void TriggerEffect(EffectType type)
		{
			Render._EASharpBinding_422((int)type);
		}
	}
}
