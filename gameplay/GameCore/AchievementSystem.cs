using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x02000023 RID: 35
	[ExportOnlyCreate(false)]
	public class AchievementSystem : ExposedCommonBase
	{
		// Token: 0x0600000C RID: 12 RVA: 0x0000212C File Offset: 0x0000112C
		public unsafe static AchievementSystem CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new AchievementSystem(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000214F File Offset: 0x0000114F
		public unsafe AchievementSystem(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002159 File Offset: 0x00001159
		protected internal AchievementSystem(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002162 File Offset: 0x00001162
		protected internal unsafe AchievementSystem(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000010 RID: 16
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_0(void* self);

		// Token: 0x06000011 RID: 17 RVA: 0x0000216C File Offset: 0x0000116C
		[DisableExceptionHandling]
		~AchievementSystem()
		{
			AchievementSystem._EASharpBinding_0(this.mSelf);
			this.mSelf = null;
		}
	}
}
