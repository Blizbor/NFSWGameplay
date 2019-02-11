using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x020000AC RID: 172
	[ExportOnlyCreate(true)]
	public class RouteEntrantLivePacket : EntrantLivePacket
	{
		// Token: 0x060009C0 RID: 2496 RVA: 0x0000CA7C File Offset: 0x0000BA7C
		public new unsafe static RouteEntrantLivePacket CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new RouteEntrantLivePacket(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x0000CA9F File Offset: 0x0000BA9F
		public unsafe RouteEntrantLivePacket(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x0000CAA9 File Offset: 0x0000BAA9
		protected internal RouteEntrantLivePacket(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x0000CAB2 File Offset: 0x0000BAB2
		protected internal unsafe RouteEntrantLivePacket(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060009C4 RID: 2500
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_987();

		// Token: 0x060009C5 RID: 2501 RVA: 0x0000CABC File Offset: 0x0000BABC
		public RouteEntrantLivePacket() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = RouteEntrantLivePacket._EASharpBinding_987();
		}

		// Token: 0x060009C6 RID: 2502
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_988(void* _ThisPtr);

		// Token: 0x060009C7 RID: 2503 RVA: 0x0000CAE4 File Offset: 0x0000BAE4
		~RouteEntrantLivePacket()
		{
			RouteEntrantLivePacket._EASharpBinding_988(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060009C8 RID: 2504
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_989(void* _ThisPtr);

		// Token: 0x060009C9 RID: 2505 RVA: 0x0000CB20 File Offset: 0x0000BB20
		public TimeSpan GetBestLapTime()
		{
			return TimeSpan.CreateInitUnowned(RouteEntrantLivePacket._EASharpBinding_989(this.mSelf));
		}

		// Token: 0x060009CA RID: 2506
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_990(void* _ThisPtr);

		// Token: 0x060009CB RID: 2507 RVA: 0x0000CB40 File Offset: 0x0000BB40
		public TimeSpan GetLapTime()
		{
			return TimeSpan.CreateInitUnowned(RouteEntrantLivePacket._EASharpBinding_990(this.mSelf));
		}

		// Token: 0x060009CC RID: 2508
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_991(void* self, float val);

		// Token: 0x060009CD RID: 2509
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_992(void* self);

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060009CE RID: 2510 RVA: 0x0000CB5F File Offset: 0x0000BB5F
		// (set) Token: 0x060009CF RID: 2511 RVA: 0x0000CB6C File Offset: 0x0000BB6C
		public float Percentage
		{
			get
			{
				return RouteEntrantLivePacket._EASharpBinding_992(this.mSelf);
			}
			set
			{
				RouteEntrantLivePacket._EASharpBinding_991(this.mSelf, value);
			}
		}

		// Token: 0x060009D0 RID: 2512
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_993(void* self, int val);

		// Token: 0x060009D1 RID: 2513
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_994(void* self);

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060009D2 RID: 2514 RVA: 0x0000CB7A File Offset: 0x0000BB7A
		// (set) Token: 0x060009D3 RID: 2515 RVA: 0x0000CB87 File Offset: 0x0000BB87
		public int Lap
		{
			get
			{
				return RouteEntrantLivePacket._EASharpBinding_994(this.mSelf);
			}
			set
			{
				RouteEntrantLivePacket._EASharpBinding_993(this.mSelf, value);
			}
		}
	}
}
