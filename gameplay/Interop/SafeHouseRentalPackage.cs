using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace Interop
{
	// Token: 0x0200009D RID: 157
	[ExportOnlyCreate(true)]
	public class SafeHouseRentalPackage : ExposedCommonBase
	{
		// Token: 0x06000838 RID: 2104 RVA: 0x0000AECC File Offset: 0x00009ECC
		public unsafe static SafeHouseRentalPackage CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new SafeHouseRentalPackage(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x0000AEEF File Offset: 0x00009EEF
		public unsafe SafeHouseRentalPackage(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x0000AEF9 File Offset: 0x00009EF9
		protected internal SafeHouseRentalPackage(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x0000AF02 File Offset: 0x00009F02
		protected internal unsafe SafeHouseRentalPackage(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600083C RID: 2108
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_820();

		// Token: 0x0600083D RID: 2109 RVA: 0x0000AF0C File Offset: 0x00009F0C
		public SafeHouseRentalPackage() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = SafeHouseRentalPackage._EASharpBinding_820();
		}

		// Token: 0x0600083E RID: 2110
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_821(void* _ThisPtr);

		// Token: 0x0600083F RID: 2111 RVA: 0x0000AF34 File Offset: 0x00009F34
		~SafeHouseRentalPackage()
		{
			SafeHouseRentalPackage._EASharpBinding_821(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000840 RID: 2112
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_822(void* _ThisPtr, sbyte* value);

		// Token: 0x06000841 RID: 2113 RVA: 0x0000AF70 File Offset: 0x00009F70
		public unsafe void SetName(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				SafeHouseRentalPackage._EASharpBinding_822(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000842 RID: 2114
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_823(void* _ThisPtr, sbyte* value);

		// Token: 0x06000843 RID: 2115 RVA: 0x0000AFD0 File Offset: 0x00009FD0
		public unsafe void SetDescription(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				SafeHouseRentalPackage._EASharpBinding_823(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000844 RID: 2116
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_824(void* _ThisPtr, sbyte* value);

		// Token: 0x06000845 RID: 2117 RVA: 0x0000B030 File Offset: 0x0000A030
		public unsafe void SetImagePath(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				SafeHouseRentalPackage._EASharpBinding_824(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000846 RID: 2118
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_825(void* _ThisPtr, uint* value);

		// Token: 0x06000847 RID: 2119 RVA: 0x0000B08D File Offset: 0x0000A08D
		public unsafe void AddDurations(uint* value)
		{
			SafeHouseRentalPackage._EASharpBinding_825(this.mSelf, value);
		}

		// Token: 0x06000848 RID: 2120
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_826(void* _ThisPtr, float* value);

		// Token: 0x06000849 RID: 2121 RVA: 0x0000B09B File Offset: 0x0000A09B
		public unsafe void AddCosts(float* value)
		{
			SafeHouseRentalPackage._EASharpBinding_826(this.mSelf, value);
		}

		// Token: 0x0600084A RID: 2122
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_827(void* _ThisPtr, void* value);

		// Token: 0x0600084B RID: 2123 RVA: 0x0000B0A9 File Offset: 0x0000A0A9
		public void AddItemList(SafeHouseRentalItem value)
		{
			SafeHouseRentalPackage._EASharpBinding_827(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
		}

		// Token: 0x0600084C RID: 2124
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_828(void* self, uint val);

		// Token: 0x0600084D RID: 2125
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_829(void* self);

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600084E RID: 2126 RVA: 0x0000B0C9 File Offset: 0x0000A0C9
		// (set) Token: 0x0600084F RID: 2127 RVA: 0x0000B0D6 File Offset: 0x0000A0D6
		public uint Id
		{
			get
			{
				return SafeHouseRentalPackage._EASharpBinding_829(this.mSelf);
			}
			set
			{
				SafeHouseRentalPackage._EASharpBinding_828(this.mSelf, value);
			}
		}

		// Token: 0x06000850 RID: 2128
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_830(void* self, void* val);

		// Token: 0x06000851 RID: 2129
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_831(void* self);

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000852 RID: 2130 RVA: 0x0000B0E4 File Offset: 0x0000A0E4
		// (set) Token: 0x06000853 RID: 2131 RVA: 0x0000B10A File Offset: 0x0000A10A
		public FECarData car
		{
			get
			{
				return new FECarData(default(ExposeTag_InitOwned), SafeHouseRentalPackage._EASharpBinding_831(this.mSelf));
			}
			set
			{
				SafeHouseRentalPackage._EASharpBinding_830(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
			}
		}
	}
}
