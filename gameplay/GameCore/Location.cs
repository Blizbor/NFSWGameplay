using System;
using System.Runtime.InteropServices;
using EASharp;
using UMath;

namespace GameCore
{
	// Token: 0x02000030 RID: 48
	[ExportOnlyCreate(false)]
	public class Location : ExposedCommonBase
	{
		// Token: 0x06000124 RID: 292 RVA: 0x000033B4 File Offset: 0x000023B4
		public unsafe static Location CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new Location(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000033D7 File Offset: 0x000023D7
		public unsafe Location(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000033E1 File Offset: 0x000023E1
		protected internal Location(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000033EA File Offset: 0x000023EA
		protected internal unsafe Location(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000128 RID: 296
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_79(void* self);

		// Token: 0x06000129 RID: 297 RVA: 0x000033F4 File Offset: 0x000023F4
		[DisableExceptionHandling]
		~Location()
		{
			Location._EASharpBinding_79(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x0600012A RID: 298
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_80();

		// Token: 0x0600012B RID: 299 RVA: 0x00003430 File Offset: 0x00002430
		public Location() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = Location._EASharpBinding_80();
		}

		// Token: 0x0600012C RID: 300
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_81(void* _ThisPtr);

		// Token: 0x0600012D RID: 301 RVA: 0x00003458 File Offset: 0x00002458
		public Vector3 GetPosition()
		{
			return new Vector3(default(ExposeTag_InitOwned), Location._EASharpBinding_81(this.mSelf));
		}

		// Token: 0x0600012E RID: 302
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_82(void* _ThisPtr);

		// Token: 0x0600012F RID: 303 RVA: 0x00003480 File Offset: 0x00002480
		public Vector3 GetDirection()
		{
			return new Vector3(default(ExposeTag_InitOwned), Location._EASharpBinding_82(this.mSelf));
		}
	}
}
