using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x02000033 RID: 51
	[ExportOnlyCreate(false)]
	public class Ports : ExposedCommonBase
	{
		// Token: 0x06000146 RID: 326 RVA: 0x00003628 File Offset: 0x00002628
		public unsafe static Ports CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new Ports(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0000364B File Offset: 0x0000264B
		public unsafe Ports(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00003655 File Offset: 0x00002655
		protected internal Ports(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000365E File Offset: 0x0000265E
		protected internal unsafe Ports(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600014A RID: 330
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_90(void* self);

		// Token: 0x0600014B RID: 331 RVA: 0x00003668 File Offset: 0x00002668
		[DisableExceptionHandling]
		~Ports()
		{
			Ports._EASharpBinding_90(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x0600014C RID: 332
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_91(uint val);

		// Token: 0x0600014D RID: 333
		[DllImport("<internal>")]
		private static extern uint _EASharpBinding_92();

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600014E RID: 334 RVA: 0x000036A4 File Offset: 0x000026A4
		// (set) Token: 0x0600014F RID: 335 RVA: 0x000036AB File Offset: 0x000026AB
		public static uint Gameplay
		{
			get
			{
				return Ports._EASharpBinding_92();
			}
			set
			{
				Ports._EASharpBinding_91(value);
			}
		}
	}
}
