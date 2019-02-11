using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace Interop
{
	// Token: 0x020000C8 RID: 200
	[ExportOnlyCreate(true)]
	public class LuckyItem : ISerializable
	{
		// Token: 0x06000BE6 RID: 3046 RVA: 0x0000EDF4 File Offset: 0x0000DDF4
		public new unsafe static LuckyItem CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new LuckyItem(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x0000EE17 File Offset: 0x0000DE17
		public unsafe LuckyItem(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x0000EE21 File Offset: 0x0000DE21
		protected internal LuckyItem(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x0000EE2A File Offset: 0x0000DE2A
		protected internal unsafe LuckyItem(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000BEA RID: 3050
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1206();

		// Token: 0x06000BEB RID: 3051 RVA: 0x0000EE34 File Offset: 0x0000DE34
		public LuckyItem() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = LuckyItem._EASharpBinding_1206();
		}

		// Token: 0x06000BEC RID: 3052
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1207(void* _ThisPtr);

		// Token: 0x06000BED RID: 3053 RVA: 0x0000EE5C File Offset: 0x0000DE5C
		~LuckyItem()
		{
			LuckyItem._EASharpBinding_1207(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000BEE RID: 3054
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1208(void* _ThisPtr, sbyte* value);

		// Token: 0x06000BEF RID: 3055 RVA: 0x0000EE98 File Offset: 0x0000DE98
		public unsafe void SetIcon(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				LuckyItem._EASharpBinding_1208(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000BF0 RID: 3056
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1209(void* _ThisPtr, sbyte* value);

		// Token: 0x06000BF1 RID: 3057 RVA: 0x0000EEF8 File Offset: 0x0000DEF8
		public unsafe void SetDescription(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				LuckyItem._EASharpBinding_1209(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000BF2 RID: 3058
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1210(void* _ThisPtr, sbyte* value);

		// Token: 0x06000BF3 RID: 3059 RVA: 0x0000EF58 File Offset: 0x0000DF58
		public unsafe void SetCategory(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				LuckyItem._EASharpBinding_1210(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000BF4 RID: 3060
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1211(void* _ThisPtr, sbyte* value);

		// Token: 0x06000BF5 RID: 3061 RVA: 0x0000EFB8 File Offset: 0x0000DFB8
		public unsafe void SetVirtualItem(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				LuckyItem._EASharpBinding_1211(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000BF6 RID: 3062
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1212(void* self, int val);

		// Token: 0x06000BF7 RID: 3063
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1213(void* self);

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000BF8 RID: 3064 RVA: 0x0000F015 File Offset: 0x0000E015
		// (set) Token: 0x06000BF9 RID: 3065 RVA: 0x0000F022 File Offset: 0x0000E022
		public int Value
		{
			get
			{
				return LuckyItem._EASharpBinding_1213(this.mSelf);
			}
			set
			{
				LuckyItem._EASharpBinding_1212(this.mSelf, value);
			}
		}

		// Token: 0x06000BFA RID: 3066
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1214(void* self, int val);

		// Token: 0x06000BFB RID: 3067
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1215(void* self);

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000BFC RID: 3068 RVA: 0x0000F030 File Offset: 0x0000E030
		// (set) Token: 0x06000BFD RID: 3069 RVA: 0x0000F03D File Offset: 0x0000E03D
		public int ItemType
		{
			get
			{
				return LuckyItem._EASharpBinding_1215(this.mSelf);
			}
			set
			{
				LuckyItem._EASharpBinding_1214(this.mSelf, value);
			}
		}

		// Token: 0x06000BFE RID: 3070
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1216(void* self, bool val);

		// Token: 0x06000BFF RID: 3071
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_1217(void* self);

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000C00 RID: 3072 RVA: 0x0000F04B File Offset: 0x0000E04B
		// (set) Token: 0x06000C01 RID: 3073 RVA: 0x0000F058 File Offset: 0x0000E058
		public bool WasSold
		{
			get
			{
				return LuckyItem._EASharpBinding_1217(this.mSelf);
			}
			set
			{
				LuckyItem._EASharpBinding_1216(this.mSelf, value);
			}
		}

		// Token: 0x06000C02 RID: 3074
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1218(void* self, float val);

		// Token: 0x06000C03 RID: 3075
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_1219(void* self);

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000C04 RID: 3076 RVA: 0x0000F066 File Offset: 0x0000E066
		// (set) Token: 0x06000C05 RID: 3077 RVA: 0x0000F073 File Offset: 0x0000E073
		public float Price
		{
			get
			{
				return LuckyItem._EASharpBinding_1219(this.mSelf);
			}
			set
			{
				LuckyItem._EASharpBinding_1218(this.mSelf, value);
			}
		}

		// Token: 0x06000C06 RID: 3078
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1220(void* self, int val);

		// Token: 0x06000C07 RID: 3079
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1221(void* self);

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000C08 RID: 3080 RVA: 0x0000F081 File Offset: 0x0000E081
		// (set) Token: 0x06000C09 RID: 3081 RVA: 0x0000F08E File Offset: 0x0000E08E
		public int PartID
		{
			get
			{
				return LuckyItem._EASharpBinding_1221(this.mSelf);
			}
			set
			{
				LuckyItem._EASharpBinding_1220(this.mSelf, value);
			}
		}
	}
}
