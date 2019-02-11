using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x020000A0 RID: 160
	[ExportOnlyCreate(true)]
	public class SafeHouseActiveCar : ISerializable
	{
		// Token: 0x06000868 RID: 2152 RVA: 0x0000B2B4 File Offset: 0x0000A2B4
		public new unsafe static SafeHouseActiveCar CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new SafeHouseActiveCar(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x0000B2D7 File Offset: 0x0000A2D7
		public unsafe SafeHouseActiveCar(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x0000B2E1 File Offset: 0x0000A2E1
		protected internal SafeHouseActiveCar(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x0000B2EA File Offset: 0x0000A2EA
		protected internal unsafe SafeHouseActiveCar(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600086C RID: 2156
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_838();

		// Token: 0x0600086D RID: 2157 RVA: 0x0000B2F4 File Offset: 0x0000A2F4
		public SafeHouseActiveCar() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = SafeHouseActiveCar._EASharpBinding_838();
		}

		// Token: 0x0600086E RID: 2158
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_839(void* _ThisPtr);

		// Token: 0x0600086F RID: 2159 RVA: 0x0000B31C File Offset: 0x0000A31C
		~SafeHouseActiveCar()
		{
			SafeHouseActiveCar._EASharpBinding_839(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000870 RID: 2160
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_840(void* self, void* val);

		// Token: 0x06000871 RID: 2161
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_841(void* self);

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000872 RID: 2162 RVA: 0x0000B358 File Offset: 0x0000A358
		// (set) Token: 0x06000873 RID: 2163 RVA: 0x0000B37E File Offset: 0x0000A37E
		public FECarData ActiveCar
		{
			get
			{
				return new FECarData(default(ExposeTag_InitOwned), SafeHouseActiveCar._EASharpBinding_841(this.mSelf));
			}
			set
			{
				SafeHouseActiveCar._EASharpBinding_840(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
			}
		}
	}
}
