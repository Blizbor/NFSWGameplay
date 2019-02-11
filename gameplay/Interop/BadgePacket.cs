using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace Interop
{
	// Token: 0x020000A3 RID: 163
	[ExportOnlyCreate(true)]
	public class BadgePacket : ISerializable
	{
		// Token: 0x060008AE RID: 2222 RVA: 0x0000B788 File Offset: 0x0000A788
		public new unsafe static BadgePacket CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new BadgePacket(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x0000B7AB File Offset: 0x0000A7AB
		public unsafe BadgePacket(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x0000B7B5 File Offset: 0x0000A7B5
		protected internal BadgePacket(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x0000B7BE File Offset: 0x0000A7BE
		protected internal unsafe BadgePacket(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060008B2 RID: 2226
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_867();

		// Token: 0x060008B3 RID: 2227 RVA: 0x0000B7C8 File Offset: 0x0000A7C8
		public BadgePacket() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = BadgePacket._EASharpBinding_867();
		}

		// Token: 0x060008B4 RID: 2228
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_868(void* _ThisPtr);

		// Token: 0x060008B5 RID: 2229 RVA: 0x0000B7F0 File Offset: 0x0000A7F0
		~BadgePacket()
		{
			BadgePacket._EASharpBinding_868(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060008B6 RID: 2230
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_869(void* _ThisPtr, sbyte* value);

		// Token: 0x060008B7 RID: 2231 RVA: 0x0000B82C File Offset: 0x0000A82C
		public unsafe void SetName(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				BadgePacket._EASharpBinding_869(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x060008B8 RID: 2232
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_870(void* _ThisPtr, sbyte* value);

		// Token: 0x060008B9 RID: 2233 RVA: 0x0000B88C File Offset: 0x0000A88C
		public unsafe void SetDescription(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				BadgePacket._EASharpBinding_870(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x060008BA RID: 2234
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_871(void* _ThisPtr, sbyte* value);

		// Token: 0x060008BB RID: 2235 RVA: 0x0000B8EC File Offset: 0x0000A8EC
		public unsafe void SetIcon(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				BadgePacket._EASharpBinding_871(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x060008BC RID: 2236
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_872(void* _ThisPtr, sbyte* value);

		// Token: 0x060008BD RID: 2237 RVA: 0x0000B94C File Offset: 0x0000A94C
		public unsafe void SetBorder(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				BadgePacket._EASharpBinding_872(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x060008BE RID: 2238
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_873(void* _ThisPtr, sbyte* value);

		// Token: 0x060008BF RID: 2239 RVA: 0x0000B9AC File Offset: 0x0000A9AC
		public unsafe void SetBackground(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				BadgePacket._EASharpBinding_873(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x060008C0 RID: 2240
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_874(void* _ThisPtr, sbyte* value);

		// Token: 0x060008C1 RID: 2241 RVA: 0x0000BA0C File Offset: 0x0000AA0C
		public unsafe void SetRarity(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				BadgePacket._EASharpBinding_874(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x060008C2 RID: 2242
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_875(void* _ThisPtr, sbyte* value);

		// Token: 0x060008C3 RID: 2243 RVA: 0x0000BA6C File Offset: 0x0000AA6C
		public unsafe void SetRank(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				BadgePacket._EASharpBinding_875(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x060008C4 RID: 2244
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_876(void* self, int val);

		// Token: 0x060008C5 RID: 2245
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_877(void* self);

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x0000BAC9 File Offset: 0x0000AAC9
		// (set) Token: 0x060008C7 RID: 2247 RVA: 0x0000BAD6 File Offset: 0x0000AAD6
		public int BadgeDefinitionId
		{
			get
			{
				return BadgePacket._EASharpBinding_877(this.mSelf);
			}
			set
			{
				BadgePacket._EASharpBinding_876(this.mSelf, value);
			}
		}

		// Token: 0x060008C8 RID: 2248
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_878(void* self, int val);

		// Token: 0x060008C9 RID: 2249
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_879(void* self);

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x0000BAE4 File Offset: 0x0000AAE4
		// (set) Token: 0x060008CB RID: 2251 RVA: 0x0000BAF1 File Offset: 0x0000AAF1
		public int SlotID
		{
			get
			{
				return BadgePacket._EASharpBinding_879(this.mSelf);
			}
			set
			{
				BadgePacket._EASharpBinding_878(this.mSelf, value);
			}
		}

		// Token: 0x060008CC RID: 2252
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_880(void* self, int val);

		// Token: 0x060008CD RID: 2253
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_881(void* self);

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060008CE RID: 2254 RVA: 0x0000BAFF File Offset: 0x0000AAFF
		// (set) Token: 0x060008CF RID: 2255 RVA: 0x0000BB0C File Offset: 0x0000AB0C
		public int RankID
		{
			get
			{
				return BadgePacket._EASharpBinding_881(this.mSelf);
			}
			set
			{
				BadgePacket._EASharpBinding_880(this.mSelf, value);
			}
		}
	}
}
