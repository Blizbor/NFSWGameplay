using System;
using System.Runtime.InteropServices;
using EASharp;
using GameCore.Math;

namespace GameCore
{
	// Token: 0x02000037 RID: 55
	[ExportOnlyCreate(false)]
	public class IconManager : ExposedCommonBase
	{
		// Token: 0x06000184 RID: 388 RVA: 0x00003A84 File Offset: 0x00002A84
		public unsafe static IconManager CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new IconManager(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00003AA7 File Offset: 0x00002AA7
		public unsafe IconManager(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00003AB1 File Offset: 0x00002AB1
		protected internal IconManager(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00003ABA File Offset: 0x00002ABA
		protected internal unsafe IconManager(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000188 RID: 392
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_113(void* self);

		// Token: 0x06000189 RID: 393 RVA: 0x00003AC4 File Offset: 0x00002AC4
		[DisableExceptionHandling]
		~IconManager()
		{
			IconManager._EASharpBinding_113(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x0600018A RID: 394
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_114(void* _ThisPtr, void* position, uint type, float rotation);

		// Token: 0x0600018B RID: 395 RVA: 0x00003B00 File Offset: 0x00002B00
		public Icon Create(Vector3 position, uint type, float rotation)
		{
			return Icon.CreateInitUnowned(IconManager._EASharpBinding_114(this.mSelf, object.ReferenceEquals(position, null) ? null : position._GetRaw(), type, rotation));
		}

		// Token: 0x0600018C RID: 396
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_115(void* _ThisPtr, void* icon);

		// Token: 0x0600018D RID: 397 RVA: 0x00003B34 File Offset: 0x00002B34
		public void Destroy(Icon icon)
		{
			IconManager._EASharpBinding_115(this.mSelf, object.ReferenceEquals(icon, null) ? null : icon._GetRaw());
		}
	}
}
