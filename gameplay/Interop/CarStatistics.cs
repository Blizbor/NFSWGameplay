using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace Interop
{
	// Token: 0x020000A5 RID: 165
	[ExportOnlyCreate(true)]
	public class CarStatistics : ISerializable
	{
		// Token: 0x060008F6 RID: 2294 RVA: 0x0000BCF0 File Offset: 0x0000ACF0
		public new unsafe static CarStatistics CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new CarStatistics(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x0000BD13 File Offset: 0x0000AD13
		public unsafe CarStatistics(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x0000BD1D File Offset: 0x0000AD1D
		protected internal CarStatistics(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x0000BD26 File Offset: 0x0000AD26
		protected internal unsafe CarStatistics(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060008FA RID: 2298
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_899();

		// Token: 0x060008FB RID: 2299 RVA: 0x0000BD30 File Offset: 0x0000AD30
		public CarStatistics() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = CarStatistics._EASharpBinding_899();
		}

		// Token: 0x060008FC RID: 2300
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_900(void* _ThisPtr);

		// Token: 0x060008FD RID: 2301 RVA: 0x0000BD58 File Offset: 0x0000AD58
		~CarStatistics()
		{
			CarStatistics._EASharpBinding_900(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060008FE RID: 2302
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_901(void* _ThisPtr, sbyte* value);

		// Token: 0x060008FF RID: 2303 RVA: 0x0000BD94 File Offset: 0x0000AD94
		public unsafe void SetSpeedLabel(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				CarStatistics._EASharpBinding_901(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000900 RID: 2304
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_902(void* _ThisPtr, sbyte* value);

		// Token: 0x06000901 RID: 2305 RVA: 0x0000BDF4 File Offset: 0x0000ADF4
		public unsafe void SetGear(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				CarStatistics._EASharpBinding_902(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000902 RID: 2306
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_903(void* _ThisPtr, sbyte* value);

		// Token: 0x06000903 RID: 2307 RVA: 0x0000BE54 File Offset: 0x0000AE54
		public unsafe void SetDurabilityToolTip(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				CarStatistics._EASharpBinding_903(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000904 RID: 2308
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_904(void* self, float val);

		// Token: 0x06000905 RID: 2309
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_905(void* self);

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000906 RID: 2310 RVA: 0x0000BEB1 File Offset: 0x0000AEB1
		// (set) Token: 0x06000907 RID: 2311 RVA: 0x0000BEBE File Offset: 0x0000AEBE
		public float Speed
		{
			get
			{
				return CarStatistics._EASharpBinding_905(this.mSelf);
			}
			set
			{
				CarStatistics._EASharpBinding_904(this.mSelf, value);
			}
		}

		// Token: 0x06000908 RID: 2312
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_906(void* self, float val);

		// Token: 0x06000909 RID: 2313
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_907(void* self);

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600090A RID: 2314 RVA: 0x0000BECC File Offset: 0x0000AECC
		// (set) Token: 0x0600090B RID: 2315 RVA: 0x0000BED9 File Offset: 0x0000AED9
		public float RPM
		{
			get
			{
				return CarStatistics._EASharpBinding_907(this.mSelf);
			}
			set
			{
				CarStatistics._EASharpBinding_906(this.mSelf, value);
			}
		}

		// Token: 0x0600090C RID: 2316
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_908(void* self, float val);

		// Token: 0x0600090D RID: 2317
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_909(void* self);

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600090E RID: 2318 RVA: 0x0000BEE7 File Offset: 0x0000AEE7
		// (set) Token: 0x0600090F RID: 2319 RVA: 0x0000BEF4 File Offset: 0x0000AEF4
		public float MaxRPM
		{
			get
			{
				return CarStatistics._EASharpBinding_909(this.mSelf);
			}
			set
			{
				CarStatistics._EASharpBinding_908(this.mSelf, value);
			}
		}

		// Token: 0x06000910 RID: 2320
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_910(void* self, float val);

		// Token: 0x06000911 RID: 2321
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_911(void* self);

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000912 RID: 2322 RVA: 0x0000BF02 File Offset: 0x0000AF02
		// (set) Token: 0x06000913 RID: 2323 RVA: 0x0000BF0F File Offset: 0x0000AF0F
		public float RotationDeg
		{
			get
			{
				return CarStatistics._EASharpBinding_911(this.mSelf);
			}
			set
			{
				CarStatistics._EASharpBinding_910(this.mSelf, value);
			}
		}

		// Token: 0x06000914 RID: 2324
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_912(void* self, bool val);

		// Token: 0x06000915 RID: 2325
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_913(void* self);

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000916 RID: 2326 RVA: 0x0000BF1D File Offset: 0x0000AF1D
		// (set) Token: 0x06000917 RID: 2327 RVA: 0x0000BF2A File Offset: 0x0000AF2A
		public bool PerfectLaunchEnabled
		{
			get
			{
				return CarStatistics._EASharpBinding_913(this.mSelf);
			}
			set
			{
				CarStatistics._EASharpBinding_912(this.mSelf, value);
			}
		}

		// Token: 0x06000918 RID: 2328
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_914(void* self, float val);

		// Token: 0x06000919 RID: 2329
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_915(void* self);

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600091A RID: 2330 RVA: 0x0000BF38 File Offset: 0x0000AF38
		// (set) Token: 0x0600091B RID: 2331 RVA: 0x0000BF45 File Offset: 0x0000AF45
		public float PerfectLaunchLBound
		{
			get
			{
				return CarStatistics._EASharpBinding_915(this.mSelf);
			}
			set
			{
				CarStatistics._EASharpBinding_914(this.mSelf, value);
			}
		}

		// Token: 0x0600091C RID: 2332
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_916(void* self, float val);

		// Token: 0x0600091D RID: 2333
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_917(void* self);

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x0000BF53 File Offset: 0x0000AF53
		// (set) Token: 0x0600091F RID: 2335 RVA: 0x0000BF60 File Offset: 0x0000AF60
		public float PerfectLaunchUBound
		{
			get
			{
				return CarStatistics._EASharpBinding_917(this.mSelf);
			}
			set
			{
				CarStatistics._EASharpBinding_916(this.mSelf, value);
			}
		}

		// Token: 0x06000920 RID: 2336
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_918(void* self, float val);

		// Token: 0x06000921 RID: 2337
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_919(void* self);

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000922 RID: 2338 RVA: 0x0000BF6E File Offset: 0x0000AF6E
		// (set) Token: 0x06000923 RID: 2339 RVA: 0x0000BF7B File Offset: 0x0000AF7B
		public float Heat
		{
			get
			{
				return CarStatistics._EASharpBinding_919(this.mSelf);
			}
			set
			{
				CarStatistics._EASharpBinding_918(this.mSelf, value);
			}
		}

		// Token: 0x06000924 RID: 2340
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_920(void* self, float val);

		// Token: 0x06000925 RID: 2341
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_921(void* self);

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x0000BF89 File Offset: 0x0000AF89
		// (set) Token: 0x06000927 RID: 2343 RVA: 0x0000BF96 File Offset: 0x0000AF96
		public float Durability
		{
			get
			{
				return CarStatistics._EASharpBinding_921(this.mSelf);
			}
			set
			{
				CarStatistics._EASharpBinding_920(this.mSelf, value);
			}
		}

		// Token: 0x06000928 RID: 2344
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_922(void* self, int val);

		// Token: 0x06000929 RID: 2345
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_923(void* self);

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600092A RID: 2346 RVA: 0x0000BFA4 File Offset: 0x0000AFA4
		// (set) Token: 0x0600092B RID: 2347 RVA: 0x0000BFB1 File Offset: 0x0000AFB1
		public CarsDurabilityState DurabilityState
		{
			get
			{
				return (CarsDurabilityState)CarStatistics._EASharpBinding_923(this.mSelf);
			}
			set
			{
				CarStatistics._EASharpBinding_922(this.mSelf, (int)value);
			}
		}
	}
}
