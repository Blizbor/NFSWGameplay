using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace Interop
{
	// Token: 0x020000A1 RID: 161
	[ExportOnlyCreate(true)]
	public class SafeHouseCarSlot : ExposedCommonBase
	{
		// Token: 0x06000874 RID: 2164 RVA: 0x0000B3A0 File Offset: 0x0000A3A0
		public unsafe static SafeHouseCarSlot CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new SafeHouseCarSlot(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x0000B3C3 File Offset: 0x0000A3C3
		public unsafe SafeHouseCarSlot(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x0000B3CD File Offset: 0x0000A3CD
		protected internal SafeHouseCarSlot(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x0000B3D6 File Offset: 0x0000A3D6
		protected internal unsafe SafeHouseCarSlot(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000878 RID: 2168
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_842();

		// Token: 0x06000879 RID: 2169 RVA: 0x0000B3E0 File Offset: 0x0000A3E0
		public SafeHouseCarSlot() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = SafeHouseCarSlot._EASharpBinding_842();
		}

		// Token: 0x0600087A RID: 2170
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_843(void* _ThisPtr);

		// Token: 0x0600087B RID: 2171 RVA: 0x0000B408 File Offset: 0x0000A408
		~SafeHouseCarSlot()
		{
			SafeHouseCarSlot._EASharpBinding_843(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x0600087C RID: 2172
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_844(void* _ThisPtr, sbyte* value);

		// Token: 0x0600087D RID: 2173 RVA: 0x0000B444 File Offset: 0x0000A444
		public unsafe void SetName(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				SafeHouseCarSlot._EASharpBinding_844(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x0600087E RID: 2174
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_845(void* _ThisPtr, sbyte* value);

		// Token: 0x0600087F RID: 2175 RVA: 0x0000B4A4 File Offset: 0x0000A4A4
		public unsafe void SetDescription(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				SafeHouseCarSlot._EASharpBinding_845(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000880 RID: 2176
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_846(void* _ThisPtr, sbyte* value);

		// Token: 0x06000881 RID: 2177 RVA: 0x0000B504 File Offset: 0x0000A504
		public unsafe void SetImagePath(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				SafeHouseCarSlot._EASharpBinding_846(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000882 RID: 2178
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_847(void* self, long val);

		// Token: 0x06000883 RID: 2179
		[DllImport("<internal>")]
		private unsafe static extern long _EASharpBinding_848(void* self);

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000884 RID: 2180 RVA: 0x0000B561 File Offset: 0x0000A561
		// (set) Token: 0x06000885 RID: 2181 RVA: 0x0000B56E File Offset: 0x0000A56E
		public long Id
		{
			get
			{
				return SafeHouseCarSlot._EASharpBinding_848(this.mSelf);
			}
			set
			{
				SafeHouseCarSlot._EASharpBinding_847(this.mSelf, value);
			}
		}

		// Token: 0x06000886 RID: 2182
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_849(void* self, void* val);

		// Token: 0x06000887 RID: 2183
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_850(void* self);

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000888 RID: 2184 RVA: 0x0000B57C File Offset: 0x0000A57C
		// (set) Token: 0x06000889 RID: 2185 RVA: 0x0000B5A2 File Offset: 0x0000A5A2
		public FECarData Car
		{
			get
			{
				return new FECarData(default(ExposeTag_InitOwned), SafeHouseCarSlot._EASharpBinding_850(this.mSelf));
			}
			set
			{
				SafeHouseCarSlot._EASharpBinding_849(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
			}
		}

		// Token: 0x0600088A RID: 2186
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_851(void* self, bool val);

		// Token: 0x0600088B RID: 2187
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_852(void* self);

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600088C RID: 2188 RVA: 0x0000B5C2 File Offset: 0x0000A5C2
		// (set) Token: 0x0600088D RID: 2189 RVA: 0x0000B5CF File Offset: 0x0000A5CF
		public bool IsRented
		{
			get
			{
				return SafeHouseCarSlot._EASharpBinding_852(this.mSelf);
			}
			set
			{
				SafeHouseCarSlot._EASharpBinding_851(this.mSelf, value);
			}
		}

		// Token: 0x0600088E RID: 2190
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_853(void* self, bool val);

		// Token: 0x0600088F RID: 2191
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_854(void* self);

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000890 RID: 2192 RVA: 0x0000B5DD File Offset: 0x0000A5DD
		// (set) Token: 0x06000891 RID: 2193 RVA: 0x0000B5EA File Offset: 0x0000A5EA
		public bool IsLocked
		{
			get
			{
				return SafeHouseCarSlot._EASharpBinding_854(this.mSelf);
			}
			set
			{
				SafeHouseCarSlot._EASharpBinding_853(this.mSelf, value);
			}
		}
	}
}
