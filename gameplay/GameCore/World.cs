using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace GameCore
{
	// Token: 0x0200006C RID: 108
	[ExportOnlyCreate(false)]
	public class World : ExposedCommonBase
	{
		// Token: 0x0600055C RID: 1372 RVA: 0x000077B4 File Offset: 0x000067B4
		public unsafe static World CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new World(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x000077D7 File Offset: 0x000067D7
		public unsafe World(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x000077E1 File Offset: 0x000067E1
		protected internal World(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x000077EA File Offset: 0x000067EA
		protected internal unsafe World(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000560 RID: 1376
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_542(void* self);

		// Token: 0x06000561 RID: 1377 RVA: 0x000077F4 File Offset: 0x000067F4
		[DisableExceptionHandling]
		~World()
		{
			World._EASharpBinding_542(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000562 RID: 1378
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_543();

		// Token: 0x06000563 RID: 1379 RVA: 0x00007830 File Offset: 0x00006830
		public static void DisableBarriers()
		{
			World._EASharpBinding_543();
		}

		// Token: 0x06000564 RID: 1380
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_544(sbyte* barrier, bool isFlipped);

		// Token: 0x06000565 RID: 1381 RVA: 0x00007838 File Offset: 0x00006838
		public unsafe static void EnableBarrier(string barrier, bool isFlipped)
		{
			int byteCount = Encoding.ASCII.GetByteCount(barrier);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(barrier, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				World._EASharpBinding_544((sbyte*)ptr, isFlipped);
			}
		}

		// Token: 0x06000566 RID: 1382
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_545(sbyte* barrier);

		// Token: 0x06000567 RID: 1383 RVA: 0x00007890 File Offset: 0x00006890
		public unsafe static void DisableBarrier(string barrier)
		{
			int byteCount = Encoding.ASCII.GetByteCount(barrier);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(barrier, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				World._EASharpBinding_545((sbyte*)ptr);
			}
		}

		// Token: 0x06000568 RID: 1384
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_546();

		// Token: 0x06000569 RID: 1385 RVA: 0x000078E7 File Offset: 0x000068E7
		public static void ResetProps()
		{
			World._EASharpBinding_546();
		}
	}
}
