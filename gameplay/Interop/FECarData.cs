using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;
using Interop.ProductTag;

namespace Interop
{
	// Token: 0x02000096 RID: 150
	[ExportOnlyCreate(true)]
	public class FECarData : CarData
	{
		// Token: 0x06000796 RID: 1942 RVA: 0x0000A220 File Offset: 0x00009220
		public new unsafe static FECarData CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new FECarData(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x0000A243 File Offset: 0x00009243
		public unsafe FECarData(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x0000A24D File Offset: 0x0000924D
		protected internal FECarData(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x0000A256 File Offset: 0x00009256
		protected internal unsafe FECarData(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600079A RID: 1946
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_753();

		// Token: 0x0600079B RID: 1947 RVA: 0x0000A260 File Offset: 0x00009260
		public FECarData() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = FECarData._EASharpBinding_753();
		}

		// Token: 0x0600079C RID: 1948
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_754(void* _ThisPtr);

		// Token: 0x0600079D RID: 1949 RVA: 0x0000A288 File Offset: 0x00009288
		~FECarData()
		{
			FECarData._EASharpBinding_754(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x0600079E RID: 1950
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_755(void* _ThisPtr);

		// Token: 0x0600079F RID: 1951 RVA: 0x0000A2C4 File Offset: 0x000092C4
		public override void Reset()
		{
			FECarData._EASharpBinding_755(this.mSelf);
		}

		// Token: 0x060007A0 RID: 1952
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_756(void* _ThisPtr, sbyte* value);

		// Token: 0x060007A1 RID: 1953 RVA: 0x0000A2D4 File Offset: 0x000092D4
		public unsafe void SetColour(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				FECarData._EASharpBinding_756(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x060007A2 RID: 1954
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_757(void* _ThisPtr, sbyte* value);

		// Token: 0x060007A3 RID: 1955 RVA: 0x0000A334 File Offset: 0x00009334
		public unsafe void SetLockedReasonMsg(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				FECarData._EASharpBinding_757(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x060007A4 RID: 1956
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_758(void* _ThisPtr, sbyte* value);

		// Token: 0x060007A5 RID: 1957 RVA: 0x0000A394 File Offset: 0x00009394
		public unsafe void SetMakeLogoPath(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				FECarData._EASharpBinding_758(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x060007A6 RID: 1958
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_759(void* _ThisPtr, sbyte* value);

		// Token: 0x060007A7 RID: 1959 RVA: 0x0000A3F4 File Offset: 0x000093F4
		public unsafe void SetModelLogoPath(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				FECarData._EASharpBinding_759(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x060007A8 RID: 1960
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_760(void* _ThisPtr, sbyte* value);

		// Token: 0x060007A9 RID: 1961 RVA: 0x0000A454 File Offset: 0x00009454
		public unsafe void SetCurrency(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				FECarData._EASharpBinding_760(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x060007AA RID: 1962
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_761(void* _ThisPtr, sbyte* value);

		// Token: 0x060007AB RID: 1963 RVA: 0x0000A4B4 File Offset: 0x000094B4
		public unsafe void SetMakeLogoPathSquare(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				FECarData._EASharpBinding_761(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x060007AC RID: 1964
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_762(void* _ThisPtr, sbyte* value);

		// Token: 0x060007AD RID: 1965 RVA: 0x0000A514 File Offset: 0x00009514
		public unsafe void SetNameHalId(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				FECarData._EASharpBinding_762(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x060007AE RID: 1966
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_763(void* _ThisPtr, sbyte* value);

		// Token: 0x060007AF RID: 1967 RVA: 0x0000A574 File Offset: 0x00009574
		public unsafe void SetModelHalId(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				FECarData._EASharpBinding_763(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x060007B0 RID: 1968
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_764(void* _ThisPtr, sbyte* value);

		// Token: 0x060007B1 RID: 1969 RVA: 0x0000A5D4 File Offset: 0x000095D4
		public unsafe void SetDaysLeftString(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				FECarData._EASharpBinding_764(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x060007B2 RID: 1970
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_765(void* _ThisPtr, sbyte* value);

		// Token: 0x060007B3 RID: 1971 RVA: 0x0000A634 File Offset: 0x00009634
		public unsafe void SetLongDescription(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				FECarData._EASharpBinding_765(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x060007B4 RID: 1972
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_766(void* _ThisPtr, sbyte* value);

		// Token: 0x060007B5 RID: 1973 RVA: 0x0000A694 File Offset: 0x00009694
		public unsafe void SetTitleString(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				FECarData._EASharpBinding_766(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x060007B6 RID: 1974
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_767(void* _ThisPtr, sbyte* value);

		// Token: 0x060007B7 RID: 1975 RVA: 0x0000A6F4 File Offset: 0x000096F4
		public unsafe void SetVarientIcon(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				FECarData._EASharpBinding_767(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x060007B8 RID: 1976
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_768(void* _ThisPtr, void* value);

		// Token: 0x060007B9 RID: 1977 RVA: 0x0000A751 File Offset: 0x00009751
		public void AddAftermarketParts(CarPartData value)
		{
			FECarData._EASharpBinding_768(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
		}

		// Token: 0x060007BA RID: 1978
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_769(void* _ThisPtr, void* value);

		// Token: 0x060007BB RID: 1979 RVA: 0x0000A771 File Offset: 0x00009771
		public void AddPerformanceParts(CarPartData value)
		{
			FECarData._EASharpBinding_769(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
		}

		// Token: 0x060007BC RID: 1980
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_770(void* _ThisPtr, void* value);

		// Token: 0x060007BD RID: 1981 RVA: 0x0000A791 File Offset: 0x00009791
		public void AddSkillModParts(CarPartData value)
		{
			FECarData._EASharpBinding_770(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
		}

		// Token: 0x060007BE RID: 1982
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_771(void* self, int val);

		// Token: 0x060007BF RID: 1983
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_772(void* self);

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x0000A7B1 File Offset: 0x000097B1
		// (set) Token: 0x060007C1 RID: 1985 RVA: 0x0000A7BE File Offset: 0x000097BE
		public int NumStrikes
		{
			get
			{
				return FECarData._EASharpBinding_772(this.mSelf);
			}
			set
			{
				FECarData._EASharpBinding_771(this.mSelf, value);
			}
		}

		// Token: 0x060007C2 RID: 1986
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_773(void* self, bool val);

		// Token: 0x060007C3 RID: 1987
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_774(void* self);

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060007C4 RID: 1988 RVA: 0x0000A7CC File Offset: 0x000097CC
		// (set) Token: 0x060007C5 RID: 1989 RVA: 0x0000A7D9 File Offset: 0x000097D9
		public bool IsLocked
		{
			get
			{
				return FECarData._EASharpBinding_774(this.mSelf);
			}
			set
			{
				FECarData._EASharpBinding_773(this.mSelf, value);
			}
		}

		// Token: 0x060007C6 RID: 1990
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_775(void* self, bool val);

		// Token: 0x060007C7 RID: 1991
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_776(void* self);

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060007C8 RID: 1992 RVA: 0x0000A7E7 File Offset: 0x000097E7
		// (set) Token: 0x060007C9 RID: 1993 RVA: 0x0000A7F4 File Offset: 0x000097F4
		public bool IsActive
		{
			get
			{
				return FECarData._EASharpBinding_776(this.mSelf);
			}
			set
			{
				FECarData._EASharpBinding_775(this.mSelf, value);
			}
		}

		// Token: 0x060007CA RID: 1994
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_777(void* self, int val);

		// Token: 0x060007CB RID: 1995
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_778(void* self);

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060007CC RID: 1996 RVA: 0x0000A802 File Offset: 0x00009802
		// (set) Token: 0x060007CD RID: 1997 RVA: 0x0000A80F File Offset: 0x0000980F
		public int LockedReason
		{
			get
			{
				return FECarData._EASharpBinding_778(this.mSelf);
			}
			set
			{
				FECarData._EASharpBinding_777(this.mSelf, value);
			}
		}

		// Token: 0x060007CE RID: 1998
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_779(void* self, int val);

		// Token: 0x060007CF RID: 1999
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_780(void* self);

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060007D0 RID: 2000 RVA: 0x0000A81D File Offset: 0x0000981D
		// (set) Token: 0x060007D1 RID: 2001 RVA: 0x0000A82A File Offset: 0x0000982A
		public int Status
		{
			get
			{
				return FECarData._EASharpBinding_780(this.mSelf);
			}
			set
			{
				FECarData._EASharpBinding_779(this.mSelf, value);
			}
		}

		// Token: 0x060007D2 RID: 2002
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_781(void* self, long val);

		// Token: 0x060007D3 RID: 2003
		[DllImport("<internal>")]
		private unsafe static extern long _EASharpBinding_782(void* self);

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060007D4 RID: 2004 RVA: 0x0000A838 File Offset: 0x00009838
		// (set) Token: 0x060007D5 RID: 2005 RVA: 0x0000A845 File Offset: 0x00009845
		public long PersonaId
		{
			get
			{
				return FECarData._EASharpBinding_782(this.mSelf);
			}
			set
			{
				FECarData._EASharpBinding_781(this.mSelf, value);
			}
		}

		// Token: 0x060007D6 RID: 2006
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_783(void* self, int val);

		// Token: 0x060007D7 RID: 2007
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_784(void* self);

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060007D8 RID: 2008 RVA: 0x0000A853 File Offset: 0x00009853
		// (set) Token: 0x060007D9 RID: 2009 RVA: 0x0000A860 File Offset: 0x00009860
		public ProductTag ProductState
		{
			get
			{
				return (ProductTag)FECarData._EASharpBinding_784(this.mSelf);
			}
			set
			{
				FECarData._EASharpBinding_783(this.mSelf, (int)value);
			}
		}

		// Token: 0x060007DA RID: 2010
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_785(void* self, void* val);

		// Token: 0x060007DB RID: 2011
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_786(void* self);

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060007DC RID: 2012 RVA: 0x0000A870 File Offset: 0x00009870
		// (set) Token: 0x060007DD RID: 2013 RVA: 0x0000A896 File Offset: 0x00009896
		public GameplayEnhancer mGameplayEnhancer
		{
			get
			{
				return new GameplayEnhancer(default(ExposeTag_InitOwned), FECarData._EASharpBinding_786(this.mSelf));
			}
			set
			{
				FECarData._EASharpBinding_785(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
			}
		}

		// Token: 0x060007DE RID: 2014
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_787(void* self, float val);

		// Token: 0x060007DF RID: 2015
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_788(void* self);

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060007E0 RID: 2016 RVA: 0x0000A8B6 File Offset: 0x000098B6
		// (set) Token: 0x060007E1 RID: 2017 RVA: 0x0000A8C3 File Offset: 0x000098C3
		public float BoostCost
		{
			get
			{
				return FECarData._EASharpBinding_788(this.mSelf);
			}
			set
			{
				FECarData._EASharpBinding_787(this.mSelf, value);
			}
		}

		// Token: 0x060007E2 RID: 2018
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_789(void* self, float val);

		// Token: 0x060007E3 RID: 2019
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_790(void* self);

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060007E4 RID: 2020 RVA: 0x0000A8D1 File Offset: 0x000098D1
		// (set) Token: 0x060007E5 RID: 2021 RVA: 0x0000A8DE File Offset: 0x000098DE
		public float CashCost
		{
			get
			{
				return FECarData._EASharpBinding_790(this.mSelf);
			}
			set
			{
				FECarData._EASharpBinding_789(this.mSelf, value);
			}
		}

		// Token: 0x060007E6 RID: 2022
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_791(void* self, float val);

		// Token: 0x060007E7 RID: 2023
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_792(void* self);

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x0000A8EC File Offset: 0x000098EC
		// (set) Token: 0x060007E9 RID: 2025 RVA: 0x0000A8F9 File Offset: 0x000098F9
		public float DaysLeft
		{
			get
			{
				return FECarData._EASharpBinding_792(this.mSelf);
			}
			set
			{
				FECarData._EASharpBinding_791(this.mSelf, value);
			}
		}

		// Token: 0x060007EA RID: 2026
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_793(void* self, int val);

		// Token: 0x060007EB RID: 2027
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_794(void* self);

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060007EC RID: 2028 RVA: 0x0000A907 File Offset: 0x00009907
		// (set) Token: 0x060007ED RID: 2029 RVA: 0x0000A914 File Offset: 0x00009914
		public int Priority
		{
			get
			{
				return FECarData._EASharpBinding_794(this.mSelf);
			}
			set
			{
				FECarData._EASharpBinding_793(this.mSelf, value);
			}
		}
	}
}
