using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x02000049 RID: 73
	[ExportOnlyCreate(false)]
	public class LoadingMonitor : ExposedCommonBase
	{
		// Token: 0x06000324 RID: 804 RVA: 0x0000526C File Offset: 0x0000426C
		public unsafe static LoadingMonitor CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new LoadingMonitor(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0000528F File Offset: 0x0000428F
		public unsafe LoadingMonitor(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00005299 File Offset: 0x00004299
		protected internal LoadingMonitor(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000327 RID: 807 RVA: 0x000052A2 File Offset: 0x000042A2
		protected internal unsafe LoadingMonitor(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000328 RID: 808
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_323(void* self);

		// Token: 0x06000329 RID: 809 RVA: 0x000052AC File Offset: 0x000042AC
		[DisableExceptionHandling]
		~LoadingMonitor()
		{
			LoadingMonitor._EASharpBinding_323(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x0600032A RID: 810
		[DllImport("<internal>")]
		private static extern bool _EASharpBinding_324();

		// Token: 0x0600032B RID: 811 RVA: 0x000052E8 File Offset: 0x000042E8
		public static bool IsLoading()
		{
			return LoadingMonitor._EASharpBinding_324();
		}

		// Token: 0x0600032C RID: 812
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_325();

		// Token: 0x0600032D RID: 813 RVA: 0x000052FC File Offset: 0x000042FC
		public static void RefreshTrackLoading()
		{
			LoadingMonitor._EASharpBinding_325();
		}

		// Token: 0x0600032E RID: 814
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_326();

		// Token: 0x0600032F RID: 815 RVA: 0x00005303 File Offset: 0x00004303
		public static void HitBlock()
		{
			LoadingMonitor._EASharpBinding_326();
		}

		// Token: 0x06000330 RID: 816
		[DllImport("<internal>")]
		private static extern bool _EASharpBinding_327();

		// Token: 0x06000331 RID: 817 RVA: 0x0000530C File Offset: 0x0000430C
		public static bool IsBlocking()
		{
			return LoadingMonitor._EASharpBinding_327();
		}

		// Token: 0x06000332 RID: 818
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_328();

		// Token: 0x06000333 RID: 819 RVA: 0x00005320 File Offset: 0x00004320
		public static void ResetBlock()
		{
			LoadingMonitor._EASharpBinding_328();
		}

		// Token: 0x06000334 RID: 820
		[DllImport("<internal>")]
		private static extern bool _EASharpBinding_329();

		// Token: 0x06000335 RID: 821 RVA: 0x00005328 File Offset: 0x00004328
		public static bool ReachedCountdownTime()
		{
			return LoadingMonitor._EASharpBinding_329();
		}

		// Token: 0x06000336 RID: 822
		[DllImport("<internal>")]
		private static extern bool _EASharpBinding_330();

		// Token: 0x06000337 RID: 823 RVA: 0x0000533C File Offset: 0x0000433C
		public static bool RelayReady()
		{
			return LoadingMonitor._EASharpBinding_330();
		}

		// Token: 0x06000338 RID: 824
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_331(bool enable);

		// Token: 0x06000339 RID: 825 RVA: 0x00005350 File Offset: 0x00004350
		public static void EnableLoadingScreen(bool enable)
		{
			LoadingMonitor._EASharpBinding_331(enable);
		}
	}
}
