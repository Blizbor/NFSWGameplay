using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x02000061 RID: 97
	[ExportOnlyCreate(false)]
	public class Simulation : ExposedCommonBase
	{
		// Token: 0x06000468 RID: 1128 RVA: 0x000068F0 File Offset: 0x000058F0
		public unsafe static Simulation CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new Simulation(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00006913 File Offset: 0x00005913
		public unsafe Simulation(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x0000691D File Offset: 0x0000591D
		protected internal Simulation(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00006926 File Offset: 0x00005926
		protected internal unsafe Simulation(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600046C RID: 1132
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_437(void* self);

		// Token: 0x0600046D RID: 1133 RVA: 0x00006930 File Offset: 0x00005930
		[DisableExceptionHandling]
		~Simulation()
		{
			Simulation._EASharpBinding_437(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x0600046E RID: 1134
		[DllImport("<internal>")]
		private static extern long _EASharpBinding_438();

		// Token: 0x0600046F RID: 1135 RVA: 0x0000696C File Offset: 0x0000596C
		public static long GetTick()
		{
			return Simulation._EASharpBinding_438();
		}

		// Token: 0x06000470 RID: 1136
		[DllImport("<internal>")]
		private static extern uint _EASharpBinding_439(long start);

		// Token: 0x06000471 RID: 1137 RVA: 0x00006980 File Offset: 0x00005980
		public static uint GetTickDifference(long start)
		{
			return Simulation._EASharpBinding_439(start);
		}

		// Token: 0x06000472 RID: 1138
		[DllImport("<internal>")]
		private static extern long _EASharpBinding_440();

		// Token: 0x06000473 RID: 1139 RVA: 0x00006998 File Offset: 0x00005998
		public static long GetSecureTick()
		{
			return Simulation._EASharpBinding_440();
		}

		// Token: 0x06000474 RID: 1140
		[DllImport("<internal>")]
		private static extern uint _EASharpBinding_441(long start);

		// Token: 0x06000475 RID: 1141 RVA: 0x000069AC File Offset: 0x000059AC
		public static uint GetSecureTickDifference(long start)
		{
			return Simulation._EASharpBinding_441(start);
		}

		// Token: 0x06000476 RID: 1142
		[DllImport("<internal>")]
		private static extern long _EASharpBinding_442();

		// Token: 0x06000477 RID: 1143 RVA: 0x000069C4 File Offset: 0x000059C4
		public static long GetRDTSCTick()
		{
			return Simulation._EASharpBinding_442();
		}

		// Token: 0x06000478 RID: 1144
		[DllImport("<internal>")]
		private static extern uint _EASharpBinding_443(long start);

		// Token: 0x06000479 RID: 1145 RVA: 0x000069D8 File Offset: 0x000059D8
		public static uint GetRDTSCTickDifference(long start)
		{
			return Simulation._EASharpBinding_443(start);
		}
	}
}
