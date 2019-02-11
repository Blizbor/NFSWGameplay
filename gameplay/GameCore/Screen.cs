using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace GameCore
{
	// Token: 0x0200005E RID: 94
	[ExportOnlyCreate(false)]
	public class Screen : ExposedCommonBase
	{
		// Token: 0x06000440 RID: 1088 RVA: 0x00006438 File Offset: 0x00005438
		public unsafe static Screen CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new Screen(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0000645B File Offset: 0x0000545B
		public unsafe Screen(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00006465 File Offset: 0x00005465
		protected internal Screen(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x0000646E File Offset: 0x0000546E
		protected internal unsafe Screen(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000444 RID: 1092
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_423(void* self);

		// Token: 0x06000445 RID: 1093 RVA: 0x00006478 File Offset: 0x00005478
		[DisableExceptionHandling]
		~Screen()
		{
			Screen._EASharpBinding_423(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000446 RID: 1094
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_424(int x, int y, sbyte* message);

		// Token: 0x06000447 RID: 1095 RVA: 0x000064B4 File Offset: 0x000054B4
		public unsafe static void Print(int x, int y, string message)
		{
			int byteCount = Encoding.ASCII.GetByteCount(message);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(message, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				Screen._EASharpBinding_424(x, y, (sbyte*)ptr);
			}
		}
	}
}
