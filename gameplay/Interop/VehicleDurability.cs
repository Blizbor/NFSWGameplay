using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace Interop
{
	// Token: 0x0200008F RID: 143
	[ExportOnlyCreate(true)]
	public class VehicleDurability : ISerializable
	{
		// Token: 0x060006D6 RID: 1750 RVA: 0x000092E4 File Offset: 0x000082E4
		public new unsafe static VehicleDurability CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new VehicleDurability(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x00009307 File Offset: 0x00008307
		public unsafe VehicleDurability(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00009311 File Offset: 0x00008311
		protected internal VehicleDurability(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x0000931A File Offset: 0x0000831A
		protected internal unsafe VehicleDurability(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060006DA RID: 1754
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_671();

		// Token: 0x060006DB RID: 1755 RVA: 0x00009324 File Offset: 0x00008324
		public VehicleDurability() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = VehicleDurability._EASharpBinding_671();
		}

		// Token: 0x060006DC RID: 1756
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_672(void* _ThisPtr);

		// Token: 0x060006DD RID: 1757 RVA: 0x0000934C File Offset: 0x0000834C
		~VehicleDurability()
		{
			VehicleDurability._EASharpBinding_672(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060006DE RID: 1758
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_673(void* _ThisPtr);

		// Token: 0x060006DF RID: 1759 RVA: 0x00009388 File Offset: 0x00008388
		public void Reset()
		{
			VehicleDurability._EASharpBinding_673(this.mSelf);
		}

		// Token: 0x060006E0 RID: 1760
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_674(void* _ThisPtr, sbyte* value);

		// Token: 0x060006E1 RID: 1761 RVA: 0x00009398 File Offset: 0x00008398
		public unsafe void SetInfoMsg(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				VehicleDurability._EASharpBinding_674(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x060006E2 RID: 1762
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_675(void* self, float val);

		// Token: 0x060006E3 RID: 1763
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_676(void* self);

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x000093F5 File Offset: 0x000083F5
		// (set) Token: 0x060006E5 RID: 1765 RVA: 0x00009402 File Offset: 0x00008402
		public float Durability
		{
			get
			{
				return VehicleDurability._EASharpBinding_676(this.mSelf);
			}
			set
			{
				VehicleDurability._EASharpBinding_675(this.mSelf, value);
			}
		}

		// Token: 0x060006E6 RID: 1766
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_677(void* self, int val);

		// Token: 0x060006E7 RID: 1767
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_678(void* self);

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x00009410 File Offset: 0x00008410
		// (set) Token: 0x060006E9 RID: 1769 RVA: 0x0000941D File Offset: 0x0000841D
		public CarsDurabilityState State
		{
			get
			{
				return (CarsDurabilityState)VehicleDurability._EASharpBinding_678(this.mSelf);
			}
			set
			{
				VehicleDurability._EASharpBinding_677(this.mSelf, (int)value);
			}
		}
	}
}
