using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace Interop
{
	// Token: 0x02000094 RID: 148
	[ExportOnlyCreate(true)]
	public class CarData : ISerializable
	{
		// Token: 0x06000752 RID: 1874 RVA: 0x00009D08 File Offset: 0x00008D08
		public new unsafe static CarData CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new CarData(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00009D2B File Offset: 0x00008D2B
		public unsafe CarData(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x00009D35 File Offset: 0x00008D35
		protected internal CarData(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00009D3E File Offset: 0x00008D3E
		protected internal unsafe CarData(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000756 RID: 1878
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_723();

		// Token: 0x06000757 RID: 1879 RVA: 0x00009D48 File Offset: 0x00008D48
		public CarData() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = CarData._EASharpBinding_723();
		}

		// Token: 0x06000758 RID: 1880
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_724(void* _ThisPtr);

		// Token: 0x06000759 RID: 1881 RVA: 0x00009D70 File Offset: 0x00008D70
		~CarData()
		{
			CarData._EASharpBinding_724(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x0600075A RID: 1882
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_725(void* _ThisPtr);

		// Token: 0x0600075B RID: 1883 RVA: 0x00009DAC File Offset: 0x00008DAC
		public virtual void Reset()
		{
			CarData._EASharpBinding_725(this.mSelf);
		}

		// Token: 0x0600075C RID: 1884
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_726(void* _ThisPtr, sbyte* value);

		// Token: 0x0600075D RID: 1885 RVA: 0x00009DBC File Offset: 0x00008DBC
		public unsafe void SetMake(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				CarData._EASharpBinding_726(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x0600075E RID: 1886
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_727(void* _ThisPtr, sbyte* value);

		// Token: 0x0600075F RID: 1887 RVA: 0x00009E1C File Offset: 0x00008E1C
		public unsafe void SetModel(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				CarData._EASharpBinding_727(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000760 RID: 1888
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_728(void* _ThisPtr, sbyte* value);

		// Token: 0x06000761 RID: 1889 RVA: 0x00009E7C File Offset: 0x00008E7C
		public unsafe void SetDisplayName(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				CarData._EASharpBinding_728(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000762 RID: 1890
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_729(void* _ThisPtr, sbyte* value);

		// Token: 0x06000763 RID: 1891 RVA: 0x00009EDC File Offset: 0x00008EDC
		public unsafe void SetFullName(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				CarData._EASharpBinding_729(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000764 RID: 1892
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_730(void* _ThisPtr, sbyte* value);

		// Token: 0x06000765 RID: 1893 RVA: 0x00009F3C File Offset: 0x00008F3C
		public unsafe void SetCarClassIcon(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				CarData._EASharpBinding_730(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000766 RID: 1894
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_731(void* self, long val);

		// Token: 0x06000767 RID: 1895
		[DllImport("<internal>")]
		private unsafe static extern long _EASharpBinding_732(void* self);

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000768 RID: 1896 RVA: 0x00009F99 File Offset: 0x00008F99
		// (set) Token: 0x06000769 RID: 1897 RVA: 0x00009FA6 File Offset: 0x00008FA6
		public long CustomCarId
		{
			get
			{
				return CarData._EASharpBinding_732(this.mSelf);
			}
			set
			{
				CarData._EASharpBinding_731(this.mSelf, value);
			}
		}

		// Token: 0x0600076A RID: 1898
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_733(void* self, int val);

		// Token: 0x0600076B RID: 1899
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_734(void* self);

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600076C RID: 1900 RVA: 0x00009FB4 File Offset: 0x00008FB4
		// (set) Token: 0x0600076D RID: 1901 RVA: 0x00009FC1 File Offset: 0x00008FC1
		public int ProductIdHash
		{
			get
			{
				return CarData._EASharpBinding_734(this.mSelf);
			}
			set
			{
				CarData._EASharpBinding_733(this.mSelf, value);
			}
		}

		// Token: 0x0600076E RID: 1902
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_735(void* self, uint val);

		// Token: 0x0600076F RID: 1903
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_736(void* self);

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x00009FCF File Offset: 0x00008FCF
		// (set) Token: 0x06000771 RID: 1905 RVA: 0x00009FDC File Offset: 0x00008FDC
		public uint VehicleId
		{
			get
			{
				return CarData._EASharpBinding_736(this.mSelf);
			}
			set
			{
				CarData._EASharpBinding_735(this.mSelf, value);
			}
		}

		// Token: 0x06000772 RID: 1906
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_737(void* self, float val);

		// Token: 0x06000773 RID: 1907
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_738(void* self);

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000774 RID: 1908 RVA: 0x00009FEA File Offset: 0x00008FEA
		// (set) Token: 0x06000775 RID: 1909 RVA: 0x00009FF7 File Offset: 0x00008FF7
		public float Heat
		{
			get
			{
				return CarData._EASharpBinding_738(this.mSelf);
			}
			set
			{
				CarData._EASharpBinding_737(this.mSelf, value);
			}
		}

		// Token: 0x06000776 RID: 1910
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_739(void* self, bool val);

		// Token: 0x06000777 RID: 1911
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_740(void* self);

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x0000A005 File Offset: 0x00009005
		// (set) Token: 0x06000779 RID: 1913 RVA: 0x0000A012 File Offset: 0x00009012
		public bool Owned
		{
			get
			{
				return CarData._EASharpBinding_740(this.mSelf);
			}
			set
			{
				CarData._EASharpBinding_739(this.mSelf, value);
			}
		}

		// Token: 0x0600077A RID: 1914
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_741(void* self, void* val);

		// Token: 0x0600077B RID: 1915
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_742(void* self);

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600077C RID: 1916 RVA: 0x0000A020 File Offset: 0x00009020
		// (set) Token: 0x0600077D RID: 1917 RVA: 0x0000A046 File Offset: 0x00009046
		public PersonaCarPackage PartsPackage
		{
			get
			{
				return new PersonaCarPackage(default(ExposeTag_InitOwned), CarData._EASharpBinding_742(this.mSelf));
			}
			set
			{
				CarData._EASharpBinding_741(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
			}
		}

		// Token: 0x0600077E RID: 1918
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_743(void* self, void* val);

		// Token: 0x0600077F RID: 1919
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_744(void* self);

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x0000A068 File Offset: 0x00009068
		// (set) Token: 0x06000781 RID: 1921 RVA: 0x0000A08E File Offset: 0x0000908E
		public VehicleDurability DurabilityData
		{
			get
			{
				return new VehicleDurability(default(ExposeTag_InitOwned), CarData._EASharpBinding_744(this.mSelf));
			}
			set
			{
				CarData._EASharpBinding_743(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
			}
		}

		// Token: 0x06000782 RID: 1922
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_745(void* self, void* val);

		// Token: 0x06000783 RID: 1923
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_746(void* self);

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x0000A0B0 File Offset: 0x000090B0
		// (set) Token: 0x06000785 RID: 1925 RVA: 0x0000A0D6 File Offset: 0x000090D6
		public PerformanceHAT HAT
		{
			get
			{
				return new PerformanceHAT(default(ExposeTag_InitOwned), CarData._EASharpBinding_746(this.mSelf));
			}
			set
			{
				CarData._EASharpBinding_745(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
			}
		}
	}
}
