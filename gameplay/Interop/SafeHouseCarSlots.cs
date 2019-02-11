using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace Interop
{
	// Token: 0x020000A2 RID: 162
	[ExportOnlyCreate(true)]
	public class SafeHouseCarSlots : ISerializable
	{
		// Token: 0x06000892 RID: 2194 RVA: 0x0000B5F8 File Offset: 0x0000A5F8
		public new unsafe static SafeHouseCarSlots CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new SafeHouseCarSlots(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x0000B61B File Offset: 0x0000A61B
		public unsafe SafeHouseCarSlots(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x0000B625 File Offset: 0x0000A625
		protected internal SafeHouseCarSlots(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x0000B62E File Offset: 0x0000A62E
		protected internal unsafe SafeHouseCarSlots(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000896 RID: 2198
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_855();

		// Token: 0x06000897 RID: 2199 RVA: 0x0000B638 File Offset: 0x0000A638
		public SafeHouseCarSlots() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = SafeHouseCarSlots._EASharpBinding_855();
		}

		// Token: 0x06000898 RID: 2200
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_856(void* _ThisPtr);

		// Token: 0x06000899 RID: 2201 RVA: 0x0000B660 File Offset: 0x0000A660
		~SafeHouseCarSlots()
		{
			SafeHouseCarSlots._EASharpBinding_856(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x0600089A RID: 2202
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_857(void* _ThisPtr, sbyte* value);

		// Token: 0x0600089B RID: 2203 RVA: 0x0000B69C File Offset: 0x0000A69C
		public unsafe void SetPurchaseMessage(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				SafeHouseCarSlots._EASharpBinding_857(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x0600089C RID: 2204
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_858(void* _ThisPtr, void* value);

		// Token: 0x0600089D RID: 2205 RVA: 0x0000B6F9 File Offset: 0x0000A6F9
		public void AddCarSlotList(SafeHouseCarSlot value)
		{
			SafeHouseCarSlots._EASharpBinding_858(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
		}

		// Token: 0x0600089E RID: 2206
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_859(void* self, int val);

		// Token: 0x0600089F RID: 2207
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_860(void* self);

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060008A0 RID: 2208 RVA: 0x0000B719 File Offset: 0x0000A719
		// (set) Token: 0x060008A1 RID: 2209 RVA: 0x0000B726 File Offset: 0x0000A726
		public int DefaultIndex
		{
			get
			{
				return SafeHouseCarSlots._EASharpBinding_860(this.mSelf);
			}
			set
			{
				SafeHouseCarSlots._EASharpBinding_859(this.mSelf, value);
			}
		}

		// Token: 0x060008A2 RID: 2210
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_861(void* self, int val);

		// Token: 0x060008A3 RID: 2211
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_862(void* self);

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060008A4 RID: 2212 RVA: 0x0000B734 File Offset: 0x0000A734
		// (set) Token: 0x060008A5 RID: 2213 RVA: 0x0000B741 File Offset: 0x0000A741
		public int NumAvailable
		{
			get
			{
				return SafeHouseCarSlots._EASharpBinding_862(this.mSelf);
			}
			set
			{
				SafeHouseCarSlots._EASharpBinding_861(this.mSelf, value);
			}
		}

		// Token: 0x060008A6 RID: 2214
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_863(void* self, bool val);

		// Token: 0x060008A7 RID: 2215
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_864(void* self);

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060008A8 RID: 2216 RVA: 0x0000B74F File Offset: 0x0000A74F
		// (set) Token: 0x060008A9 RID: 2217 RVA: 0x0000B75C File Offset: 0x0000A75C
		public bool EnablePurchase
		{
			get
			{
				return SafeHouseCarSlots._EASharpBinding_864(this.mSelf);
			}
			set
			{
				SafeHouseCarSlots._EASharpBinding_863(this.mSelf, value);
			}
		}

		// Token: 0x060008AA RID: 2218
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_865(void* self, int val);

		// Token: 0x060008AB RID: 2219
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_866(void* self);

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060008AC RID: 2220 RVA: 0x0000B76A File Offset: 0x0000A76A
		// (set) Token: 0x060008AD RID: 2221 RVA: 0x0000B777 File Offset: 0x0000A777
		public int NextSlotCost
		{
			get
			{
				return SafeHouseCarSlots._EASharpBinding_866(this.mSelf);
			}
			set
			{
				SafeHouseCarSlots._EASharpBinding_865(this.mSelf, value);
			}
		}
	}
}
