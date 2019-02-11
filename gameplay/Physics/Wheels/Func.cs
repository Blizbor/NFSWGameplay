using System;
using System.Runtime.InteropServices;

namespace Physics.Wheels
{
	// Token: 0x02000109 RID: 265
	public class Func
	{
		// Token: 0x06000E50 RID: 3664
		[DllImport("<internal>")]
		private static extern bool _EASharpBinding_1453(uint i);

		// Token: 0x06000E51 RID: 3665 RVA: 0x0001102C File Offset: 0x0001002C
		public static bool IsLeft(uint i)
		{
			return Func._EASharpBinding_1453(i);
		}

		// Token: 0x06000E52 RID: 3666
		[DllImport("<internal>")]
		private static extern bool _EASharpBinding_1454(uint i);

		// Token: 0x06000E53 RID: 3667 RVA: 0x00011044 File Offset: 0x00010044
		public static bool IsRight(uint i)
		{
			return Func._EASharpBinding_1454(i);
		}

		// Token: 0x06000E54 RID: 3668
		[DllImport("<internal>")]
		private static extern bool _EASharpBinding_1455(uint i);

		// Token: 0x06000E55 RID: 3669 RVA: 0x0001105C File Offset: 0x0001005C
		public static bool IsFront(uint i)
		{
			return Func._EASharpBinding_1455(i);
		}

		// Token: 0x06000E56 RID: 3670
		[DllImport("<internal>")]
		private static extern bool _EASharpBinding_1456(uint i);

		// Token: 0x06000E57 RID: 3671 RVA: 0x00011074 File Offset: 0x00010074
		public static bool IsRear(uint i)
		{
			return Func._EASharpBinding_1456(i);
		}
	}
}
