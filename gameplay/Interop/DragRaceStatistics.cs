using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace Interop
{
	// Token: 0x020000A6 RID: 166
	[ExportOnlyCreate(true)]
	public class DragRaceStatistics : ISerializable
	{
		// Token: 0x0600092C RID: 2348 RVA: 0x0000BFC0 File Offset: 0x0000AFC0
		public new unsafe static DragRaceStatistics CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new DragRaceStatistics(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x0000BFE3 File Offset: 0x0000AFE3
		public unsafe DragRaceStatistics(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
			this.__InitializeArrayPropertyHelpers(this.mSelf);
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x0000BFF9 File Offset: 0x0000AFF9
		protected internal DragRaceStatistics(ExposeTag_NoInitOwned tag) : base(tag)
		{
			this.__InitializeArrayPropertyHelpers(this.mSelf);
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x0000C00E File Offset: 0x0000B00E
		protected internal unsafe DragRaceStatistics(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
			this.__InitializeArrayPropertyHelpers(this.mSelf);
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x0000C024 File Offset: 0x0000B024
		private unsafe void __InitializeArrayPropertyHelpers(void* self)
		{
			this.RPMThresholds = new DragRaceStatistics.RPMThresholds__Array(self);
		}

		// Token: 0x06000931 RID: 2353
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_924();

		// Token: 0x06000932 RID: 2354 RVA: 0x0000C034 File Offset: 0x0000B034
		public DragRaceStatistics() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = DragRaceStatistics._EASharpBinding_924();
			this.__InitializeArrayPropertyHelpers(this.mSelf);
		}

		// Token: 0x06000933 RID: 2355
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_925(void* _ThisPtr);

		// Token: 0x06000934 RID: 2356 RVA: 0x0000C068 File Offset: 0x0000B068
		~DragRaceStatistics()
		{
			DragRaceStatistics._EASharpBinding_925(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000935 RID: 2357
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_926(void* _ThisPtr, sbyte* value);

		// Token: 0x06000936 RID: 2358 RVA: 0x0000C0A4 File Offset: 0x0000B0A4
		public unsafe void SetGear(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				DragRaceStatistics._EASharpBinding_926(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000937 RID: 2359
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_927(void* _ThisPtr, sbyte* value);

		// Token: 0x06000938 RID: 2360 RVA: 0x0000C104 File Offset: 0x0000B104
		public unsafe void SetTopGear(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				DragRaceStatistics._EASharpBinding_927(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000939 RID: 2361
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_928(void* self, float val);

		// Token: 0x0600093A RID: 2362
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_929(void* self);

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x0000C161 File Offset: 0x0000B161
		// (set) Token: 0x0600093C RID: 2364 RVA: 0x0000C16E File Offset: 0x0000B16E
		public float RPM
		{
			get
			{
				return DragRaceStatistics._EASharpBinding_929(this.mSelf);
			}
			set
			{
				DragRaceStatistics._EASharpBinding_928(this.mSelf, value);
			}
		}

		// Token: 0x0600093D RID: 2365
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_930(void* self, float val);

		// Token: 0x0600093E RID: 2366
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_931(void* self);

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600093F RID: 2367 RVA: 0x0000C17C File Offset: 0x0000B17C
		// (set) Token: 0x06000940 RID: 2368 RVA: 0x0000C189 File Offset: 0x0000B189
		public float NumRPMThresholds
		{
			get
			{
				return DragRaceStatistics._EASharpBinding_931(this.mSelf);
			}
			set
			{
				DragRaceStatistics._EASharpBinding_930(this.mSelf, value);
			}
		}

		// Token: 0x06000941 RID: 2369
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_932(void* self, float val);

		// Token: 0x06000942 RID: 2370
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_933(void* self);

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000943 RID: 2371 RVA: 0x0000C197 File Offset: 0x0000B197
		// (set) Token: 0x06000944 RID: 2372 RVA: 0x0000C1A4 File Offset: 0x0000B1A4
		public float OptimalStartingRPM
		{
			get
			{
				return DragRaceStatistics._EASharpBinding_933(this.mSelf);
			}
			set
			{
				DragRaceStatistics._EASharpBinding_932(this.mSelf, value);
			}
		}

		// Token: 0x04000138 RID: 312
		public DragRaceStatistics.RPMThresholds__Array RPMThresholds;

		// Token: 0x020000A7 RID: 167
		public class RPMThresholds__Array
		{
			// Token: 0x06000945 RID: 2373 RVA: 0x0000C1B2 File Offset: 0x0000B1B2
			public unsafe RPMThresholds__Array(void* self)
			{
				this.mSelf = self;
			}

			// Token: 0x06000946 RID: 2374
			[DllImport("<internal>")]
			public unsafe static extern float _EASharpBinding_935(void* self, int index);

			// Token: 0x06000947 RID: 2375
			[DllImport("<internal>")]
			public unsafe static extern void _EASharpBinding_934(void* self, int index, float value);

			// Token: 0x17000075 RID: 117
			public float this[int index]
			{
				get
				{
					if (index < 0 && index >= 5)
					{
						throw new IndexOutOfRangeException();
					}
					return DragRaceStatistics.RPMThresholds__Array._EASharpBinding_935(this.mSelf, index);
				}
				set
				{
					if (index < 0 && index >= 5)
					{
						throw new IndexOutOfRangeException();
					}
					DragRaceStatistics.RPMThresholds__Array._EASharpBinding_934(this.mSelf, index, value);
				}
			}

			// Token: 0x0600094A RID: 2378 RVA: 0x0000C201 File Offset: 0x0000B201
			public DragRaceStatistics.RPMThresholds__Array.Iter GetEnumerator()
			{
				return new DragRaceStatistics.RPMThresholds__Array.Iter(this);
			}

			// Token: 0x04000139 RID: 313
			private unsafe void* mSelf;

			// Token: 0x0400013A RID: 314
			public int Length = 5;

			// Token: 0x020000A8 RID: 168
			public class Iter
			{
				// Token: 0x0600094B RID: 2379 RVA: 0x0000C209 File Offset: 0x0000B209
				public Iter(DragRaceStatistics.RPMThresholds__Array array)
				{
					this.Array = array;
					this.Index = -1;
				}

				// Token: 0x17000076 RID: 118
				// (get) Token: 0x0600094C RID: 2380 RVA: 0x0000C21F File Offset: 0x0000B21F
				public float Current
				{
					get
					{
						return this.Array[this.Index];
					}
				}

				// Token: 0x0600094D RID: 2381 RVA: 0x0000C232 File Offset: 0x0000B232
				public bool MoveNext()
				{
					if (this.Index == 4)
					{
						return false;
					}
					this.Index++;
					return true;
				}

				// Token: 0x0400013B RID: 315
				private DragRaceStatistics.RPMThresholds__Array Array;

				// Token: 0x0400013C RID: 316
				private int Index;
			}
		}
	}
}
