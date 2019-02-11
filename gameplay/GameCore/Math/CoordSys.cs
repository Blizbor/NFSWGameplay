using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore.Math
{
	// Token: 0x0200007C RID: 124
	[ExportOnlyCreate(false)]
	public class CoordSys : ExposedCommonBase
	{
		// Token: 0x06000632 RID: 1586 RVA: 0x00008904 File Offset: 0x00007904
		public unsafe static CoordSys CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new CoordSys(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00008927 File Offset: 0x00007927
		public unsafe CoordSys(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00008931 File Offset: 0x00007931
		protected internal CoordSys(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x0000893A File Offset: 0x0000793A
		protected internal unsafe CoordSys(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000636 RID: 1590
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_623(void* self);

		// Token: 0x06000637 RID: 1591 RVA: 0x00008944 File Offset: 0x00007944
		[DisableExceptionHandling]
		~CoordSys()
		{
			CoordSys._EASharpBinding_623(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000638 RID: 1592
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_624(void* render);

		// Token: 0x06000639 RID: 1593 RVA: 0x00008980 File Offset: 0x00007980
		public static Vector3 RenderToSim(Vector3 render)
		{
			return new Vector3(default(ExposeTag_InitOwned), CoordSys._EASharpBinding_624(object.ReferenceEquals(render, null) ? null : render._GetRaw()));
		}

		// Token: 0x0600063A RID: 1594
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_625(float rotation);

		// Token: 0x0600063B RID: 1595 RVA: 0x000089B8 File Offset: 0x000079B8
		public static Vector3 Vector3Make(float rotation)
		{
			return new Vector3(default(ExposeTag_InitOwned), CoordSys._EASharpBinding_625(rotation));
		}
	}
}
