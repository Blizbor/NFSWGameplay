using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace Interop
{
	// Token: 0x0200009C RID: 156
	[ExportOnlyCreate(true)]
	public class SafeHouseRentalItem : ExposedCommonBase
	{
		// Token: 0x0600082A RID: 2090 RVA: 0x0000AD08 File Offset: 0x00009D08
		public unsafe static SafeHouseRentalItem CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new SafeHouseRentalItem(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x0000AD2B File Offset: 0x00009D2B
		public unsafe SafeHouseRentalItem(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x0000AD35 File Offset: 0x00009D35
		protected internal SafeHouseRentalItem(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x0000AD3E File Offset: 0x00009D3E
		protected internal unsafe SafeHouseRentalItem(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600082E RID: 2094
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_815();

		// Token: 0x0600082F RID: 2095 RVA: 0x0000AD48 File Offset: 0x00009D48
		public SafeHouseRentalItem() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = SafeHouseRentalItem._EASharpBinding_815();
		}

		// Token: 0x06000830 RID: 2096
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_816(void* _ThisPtr);

		// Token: 0x06000831 RID: 2097 RVA: 0x0000AD70 File Offset: 0x00009D70
		~SafeHouseRentalItem()
		{
			SafeHouseRentalItem._EASharpBinding_816(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000832 RID: 2098
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_817(void* _ThisPtr, sbyte* value);

		// Token: 0x06000833 RID: 2099 RVA: 0x0000ADAC File Offset: 0x00009DAC
		public unsafe void SetName(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				SafeHouseRentalItem._EASharpBinding_817(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000834 RID: 2100
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_818(void* _ThisPtr, sbyte* value);

		// Token: 0x06000835 RID: 2101 RVA: 0x0000AE0C File Offset: 0x00009E0C
		public unsafe void SetDescription(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				SafeHouseRentalItem._EASharpBinding_818(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000836 RID: 2102
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_819(void* _ThisPtr, sbyte* value);

		// Token: 0x06000837 RID: 2103 RVA: 0x0000AE6C File Offset: 0x00009E6C
		public unsafe void SetImagePath(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				SafeHouseRentalItem._EASharpBinding_819(this.mSelf, (sbyte*)ptr);
			}
		}
	}
}
