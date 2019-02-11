using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace GameCore
{
	// Token: 0x0200006F RID: 111
	[ExportOnlyCreate(false)]
	public class JuiceGC : ExposedCommonBase
	{
		// Token: 0x060005A4 RID: 1444 RVA: 0x00007FF4 File Offset: 0x00006FF4
		public unsafe static JuiceGC CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new JuiceGC(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00008017 File Offset: 0x00007017
		public unsafe JuiceGC(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00008021 File Offset: 0x00007021
		protected internal JuiceGC(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x0000802A File Offset: 0x0000702A
		protected internal unsafe JuiceGC(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060005A8 RID: 1448
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_572(void* self);

		// Token: 0x060005A9 RID: 1449 RVA: 0x00008034 File Offset: 0x00007034
		[DisableExceptionHandling]
		~JuiceGC()
		{
			JuiceGC._EASharpBinding_572(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060005AA RID: 1450
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_573(int performanceType);

		// Token: 0x060005AB RID: 1451 RVA: 0x00008070 File Offset: 0x00007070
		public static void SetNextRaceForceOpponentLevel(JuiceGC.eOpponentPerformance performanceType)
		{
			JuiceGC._EASharpBinding_573((int)performanceType);
		}

		// Token: 0x060005AC RID: 1452
		[DllImport("<internal>")]
		private static extern int _EASharpBinding_574();

		// Token: 0x060005AD RID: 1453 RVA: 0x00008078 File Offset: 0x00007078
		public static JuiceGC.eOpponentPerformance GetNextRaceForceOpponentLevel()
		{
			return (JuiceGC.eOpponentPerformance)JuiceGC._EASharpBinding_574();
		}

		// Token: 0x060005AE RID: 1454
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_575(bool isInPostRace);

		// Token: 0x060005AF RID: 1455 RVA: 0x0000808C File Offset: 0x0000708C
		public static void SetIsPostRace(bool isInPostRace)
		{
			JuiceGC._EASharpBinding_575(isInPostRace);
		}

		// Token: 0x060005B0 RID: 1456
		[DllImport("<internal>")]
		private static extern bool _EASharpBinding_576();

		// Token: 0x060005B1 RID: 1457 RVA: 0x00008094 File Offset: 0x00007094
		public static bool GetIsPostRace()
		{
			return JuiceGC._EASharpBinding_576();
		}

		// Token: 0x060005B2 RID: 1458
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_577(sbyte* name);

		// Token: 0x060005B3 RID: 1459 RVA: 0x000080A8 File Offset: 0x000070A8
		public unsafe static void LogTimedStatePush(string name)
		{
			int byteCount = Encoding.ASCII.GetByteCount(name);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(name, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				JuiceGC._EASharpBinding_577((sbyte*)ptr);
			}
		}

		// Token: 0x060005B4 RID: 1460
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_578(sbyte* name);

		// Token: 0x060005B5 RID: 1461 RVA: 0x00008100 File Offset: 0x00007100
		public unsafe static void LogTimedStatePop(string name)
		{
			int byteCount = Encoding.ASCII.GetByteCount(name);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(name, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				JuiceGC._EASharpBinding_578((sbyte*)ptr);
			}
		}

		// Token: 0x060005B6 RID: 1462
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_579(uint eventId, bool isPvp);

		// Token: 0x060005B7 RID: 1463 RVA: 0x00008157 File Offset: 0x00007157
		public static void LogEventEntered(uint eventId, bool isPvp)
		{
			JuiceGC._EASharpBinding_579(eventId, isPvp);
		}

		// Token: 0x060005B8 RID: 1464
		[DllImport("<internal>")]
		private unsafe static extern sbyte* _EASharpBinding_580();

		// Token: 0x060005B9 RID: 1465 RVA: 0x00008160 File Offset: 0x00007160
		public static string GetCurrentEventName()
		{
			return InternalUtil.ConvertFromCString(JuiceGC._EASharpBinding_580());
		}

		// Token: 0x02000070 RID: 112
		public enum eOpponentPerformance
		{
			// Token: 0x040000E6 RID: 230
			eOpponentPerformance_MIN,
			// Token: 0x040000E7 RID: 231
			DISABLED,
			// Token: 0x040000E8 RID: 232
			MIN_PERFORMANCE,
			// Token: 0x040000E9 RID: 233
			MAX_PERFORMANCE,
			// Token: 0x040000EA RID: 234
			eOpponentPerformance_MAX
		}
	}
}
