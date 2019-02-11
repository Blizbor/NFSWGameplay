using System;
using System.Runtime.InteropServices;
using EASharp;
using UMath;

namespace GameCore
{
	// Token: 0x0200004C RID: 76
	[ExportOnlyCreate(false)]
	public class NavigateTo : ExposedCommonBase
	{
		// Token: 0x0600035E RID: 862 RVA: 0x00005568 File Offset: 0x00004568
		public unsafe static NavigateTo CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new NavigateTo(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0000558B File Offset: 0x0000458B
		public unsafe NavigateTo(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00005595 File Offset: 0x00004595
		protected internal NavigateTo(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0000559E File Offset: 0x0000459E
		protected internal unsafe NavigateTo(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000362 RID: 866
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_346(void* self);

		// Token: 0x06000363 RID: 867 RVA: 0x000055A8 File Offset: 0x000045A8
		[DisableExceptionHandling]
		~NavigateTo()
		{
			NavigateTo._EASharpBinding_346(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000364 RID: 868
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_347(void* gpsDest, void* realTarget, float maxDeviation, bool showArrow, bool asCrowFlies, bool ignoreDistance);

		// Token: 0x06000365 RID: 869 RVA: 0x000055E4 File Offset: 0x000045E4
		public static void NavigatePlayerTo(Vector3 gpsDest, Vector3 realTarget, float maxDeviation, bool showArrow, bool asCrowFlies, bool ignoreDistance)
		{
			NavigateTo._EASharpBinding_347(object.ReferenceEquals(gpsDest, null) ? null : gpsDest._GetRaw(), object.ReferenceEquals(realTarget, null) ? null : realTarget._GetRaw(), maxDeviation, showArrow, asCrowFlies, ignoreDistance);
		}

		// Token: 0x06000366 RID: 870
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_348();

		// Token: 0x06000367 RID: 871 RVA: 0x00005617 File Offset: 0x00004617
		public static void StopNavigatePlayerTo()
		{
			NavigateTo._EASharpBinding_348();
		}
	}
}
