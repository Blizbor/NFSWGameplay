using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x02000032 RID: 50
	[ExportOnlyCreate(false)]
	public class Hardware : ExposedCommonBase
	{
		// Token: 0x0600013A RID: 314 RVA: 0x00003570 File Offset: 0x00002570
		public unsafe static Hardware CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new Hardware(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00003593 File Offset: 0x00002593
		public unsafe Hardware(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0000359D File Offset: 0x0000259D
		protected internal Hardware(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000035A6 File Offset: 0x000025A6
		protected internal unsafe Hardware(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600013E RID: 318
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_86(void* self);

		// Token: 0x0600013F RID: 319 RVA: 0x000035B0 File Offset: 0x000025B0
		[DisableExceptionHandling]
		~Hardware()
		{
			Hardware._EASharpBinding_86(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000140 RID: 320
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_87();

		// Token: 0x06000141 RID: 321 RVA: 0x000035EC File Offset: 0x000025EC
		public Hardware() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = Hardware._EASharpBinding_87();
		}

		// Token: 0x06000142 RID: 322
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_88(uint color);

		// Token: 0x06000143 RID: 323 RVA: 0x00003613 File Offset: 0x00002613
		public static void PulseEffect(uint color)
		{
			Hardware._EASharpBinding_88(color);
		}

		// Token: 0x06000144 RID: 324
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_89(uint color, float duration, float period);

		// Token: 0x06000145 RID: 325 RVA: 0x0000361B File Offset: 0x0000261B
		public static void BlinkEffect(uint color, float duration, float period)
		{
			Hardware._EASharpBinding_89(color, duration, period);
		}
	}
}
