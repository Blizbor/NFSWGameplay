using System;
using System.Runtime.InteropServices;
using EASharp;
using Interop;

namespace GameCore.Powerups
{
	// Token: 0x02000081 RID: 129
	[ExportOnlyCreate(false)]
	public class Powerups : ExposedCommonBase
	{
		// Token: 0x0600067C RID: 1660 RVA: 0x00008E18 File Offset: 0x00007E18
		public unsafe static Powerups CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new Powerups(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00008E3B File Offset: 0x00007E3B
		public unsafe Powerups(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00008E45 File Offset: 0x00007E45
		protected internal Powerups(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x00008E4E File Offset: 0x00007E4E
		protected internal unsafe Powerups(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000680 RID: 1664
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_636(void* self);

		// Token: 0x06000681 RID: 1665 RVA: 0x00008E58 File Offset: 0x00007E58
		[DisableExceptionHandling]
		~Powerups()
		{
			Powerups._EASharpBinding_636(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000682 RID: 1666
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_637(int config);

		// Token: 0x06000683 RID: 1667 RVA: 0x00008E94 File Offset: 0x00007E94
		public static void AssignPowerupConfiguration(PowerupConfiguration config)
		{
			Powerups._EASharpBinding_637((int)config);
		}

		// Token: 0x06000684 RID: 1668
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_638();

		// Token: 0x06000685 RID: 1669 RVA: 0x00008E9C File Offset: 0x00007E9C
		public static void RechargeAllPowerups()
		{
			Powerups._EASharpBinding_638();
		}

		// Token: 0x06000686 RID: 1670
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_639(void* arbitratedPacket);

		// Token: 0x06000687 RID: 1671 RVA: 0x00008EA3 File Offset: 0x00007EA3
		public static void FillEntrantArbitratedPacket(EntrantArbitratedPacket arbitratedPacket)
		{
			Powerups._EASharpBinding_639(object.ReferenceEquals(arbitratedPacket, null) ? null : arbitratedPacket._GetRaw());
		}
	}
}
