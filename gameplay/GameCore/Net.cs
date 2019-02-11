using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x0200004D RID: 77
	[ExportOnlyCreate(false)]
	public class Net : ExposedCommonBase
	{
		// Token: 0x06000368 RID: 872 RVA: 0x00005620 File Offset: 0x00004620
		public unsafe static Net CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new Net(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00005643 File Offset: 0x00004643
		public unsafe Net(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0000564D File Offset: 0x0000464D
		protected internal Net(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00005656 File Offset: 0x00004656
		protected internal unsafe Net(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600036C RID: 876
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_349(void* self);

		// Token: 0x0600036D RID: 877 RVA: 0x00005660 File Offset: 0x00004660
		[DisableExceptionHandling]
		~Net()
		{
			Net._EASharpBinding_349(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x0600036E RID: 878
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_350();

		// Token: 0x0600036F RID: 879 RVA: 0x0000569C File Offset: 0x0000469C
		public Net() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = Net._EASharpBinding_350();
		}

		// Token: 0x06000370 RID: 880
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_351();

		// Token: 0x06000371 RID: 881 RVA: 0x000056C3 File Offset: 0x000046C3
		public static void ConnectToRoaming()
		{
			Net._EASharpBinding_351();
		}

		// Token: 0x06000372 RID: 882
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_352();

		// Token: 0x06000373 RID: 883 RVA: 0x000056CA File Offset: 0x000046CA
		public static void DisconnectFromRoaming()
		{
			Net._EASharpBinding_352();
		}

		// Token: 0x06000374 RID: 884
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_353();

		// Token: 0x06000375 RID: 885 RVA: 0x000056D1 File Offset: 0x000046D1
		public static void EntrantCrossedFinish()
		{
			Net._EASharpBinding_353();
		}

		// Token: 0x06000376 RID: 886
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_354(void* buffer, uint length);

		// Token: 0x06000377 RID: 887 RVA: 0x000056D8 File Offset: 0x000046D8
		public unsafe static void SendGameplayMessage(void* buffer, uint length)
		{
			Net._EASharpBinding_354(buffer, length);
		}

		// Token: 0x06000378 RID: 888
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_355(void* fixedBuffer, uint length);

		// Token: 0x06000379 RID: 889 RVA: 0x000056E4 File Offset: 0x000046E4
		public unsafe static uint RecvGameplayMessage(void* fixedBuffer, uint length)
		{
			return Net._EASharpBinding_355(fixedBuffer, length);
		}
	}
}
