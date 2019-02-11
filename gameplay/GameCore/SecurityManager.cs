using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x0200005F RID: 95
	[ExportOnlyCreate(false)]
	public class SecurityManager : ExposedCommonBase
	{
		// Token: 0x06000448 RID: 1096 RVA: 0x00006510 File Offset: 0x00005510
		public unsafe static SecurityManager CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new SecurityManager(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00006533 File Offset: 0x00005533
		public unsafe SecurityManager(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0000653D File Offset: 0x0000553D
		protected internal SecurityManager(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00006546 File Offset: 0x00005546
		protected internal unsafe SecurityManager(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600044C RID: 1100
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_425(void* self);

		// Token: 0x0600044D RID: 1101 RVA: 0x00006550 File Offset: 0x00005550
		[DisableExceptionHandling]
		~SecurityManager()
		{
			SecurityManager._EASharpBinding_425(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x0600044E RID: 1102
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_426();

		// Token: 0x0600044F RID: 1103 RVA: 0x0000658C File Offset: 0x0000558C
		public SecurityManager() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = SecurityManager._EASharpBinding_426();
		}

		// Token: 0x06000450 RID: 1104
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_427();

		// Token: 0x06000451 RID: 1105 RVA: 0x000065B3 File Offset: 0x000055B3
		public static void CheckLoadedLibraries()
		{
			SecurityManager._EASharpBinding_427();
		}

		// Token: 0x06000452 RID: 1106
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_428();

		// Token: 0x06000453 RID: 1107 RVA: 0x000065BA File Offset: 0x000055BA
		public static void EventReset()
		{
			SecurityManager._EASharpBinding_428();
		}

		// Token: 0x06000454 RID: 1108
		[DllImport("<internal>")]
		private static extern uint _EASharpBinding_429();

		// Token: 0x06000455 RID: 1109 RVA: 0x000065C4 File Offset: 0x000055C4
		public static uint GetHacks()
		{
			return SecurityManager._EASharpBinding_429();
		}
	}
}
