using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x0200009F RID: 159
	[ExportOnlyCreate(true)]
	public class SafeHousePurchasableVariations : ISerializable
	{
		// Token: 0x0600085E RID: 2142 RVA: 0x0000B1F0 File Offset: 0x0000A1F0
		public new unsafe static SafeHousePurchasableVariations CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new SafeHousePurchasableVariations(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x0000B213 File Offset: 0x0000A213
		public unsafe SafeHousePurchasableVariations(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x0000B21D File Offset: 0x0000A21D
		protected internal SafeHousePurchasableVariations(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x0000B226 File Offset: 0x0000A226
		protected internal unsafe SafeHousePurchasableVariations(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000862 RID: 2146
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_835();

		// Token: 0x06000863 RID: 2147 RVA: 0x0000B230 File Offset: 0x0000A230
		public SafeHousePurchasableVariations() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = SafeHousePurchasableVariations._EASharpBinding_835();
		}

		// Token: 0x06000864 RID: 2148
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_836(void* _ThisPtr);

		// Token: 0x06000865 RID: 2149 RVA: 0x0000B258 File Offset: 0x0000A258
		~SafeHousePurchasableVariations()
		{
			SafeHousePurchasableVariations._EASharpBinding_836(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000866 RID: 2150
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_837(void* _ThisPtr, void* value);

		// Token: 0x06000867 RID: 2151 RVA: 0x0000B294 File Offset: 0x0000A294
		public void AddCarList(FECarData value)
		{
			SafeHousePurchasableVariations._EASharpBinding_837(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
		}
	}
}
