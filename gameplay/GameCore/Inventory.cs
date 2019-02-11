using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace GameCore
{
	// Token: 0x02000048 RID: 72
	[ExportOnlyCreate(false)]
	public class Inventory : ExposedCommonBase
	{
		// Token: 0x0600031C RID: 796 RVA: 0x00005190 File Offset: 0x00004190
		public unsafe static Inventory CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new Inventory(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x000051B3 File Offset: 0x000041B3
		public unsafe Inventory(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600031E RID: 798 RVA: 0x000051BD File Offset: 0x000041BD
		protected internal Inventory(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x0600031F RID: 799 RVA: 0x000051C6 File Offset: 0x000041C6
		protected internal unsafe Inventory(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000320 RID: 800
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_321(void* self);

		// Token: 0x06000321 RID: 801 RVA: 0x000051D0 File Offset: 0x000041D0
		[DisableExceptionHandling]
		~Inventory()
		{
			Inventory._EASharpBinding_321(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000322 RID: 802
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_322(sbyte* productType);

		// Token: 0x06000323 RID: 803 RVA: 0x0000520C File Offset: 0x0000420C
		public unsafe static int GetProductTypeFromString(string productType)
		{
			int byteCount = Encoding.ASCII.GetByteCount(productType);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(productType, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return Inventory._EASharpBinding_322((sbyte*)ptr);
			}
		}
	}
}
