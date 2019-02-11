using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;
using GameCore;

namespace Interop
{
	// Token: 0x020000A9 RID: 169
	[ExportOnlyCreate(true)]
	public class EventInfo : ISerializable
	{
		// Token: 0x0600094E RID: 2382 RVA: 0x0000C250 File Offset: 0x0000B250
		public new unsafe static EventInfo CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new EventInfo(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x0000C273 File Offset: 0x0000B273
		public unsafe EventInfo(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x0000C27D File Offset: 0x0000B27D
		protected internal EventInfo(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x0000C286 File Offset: 0x0000B286
		protected internal unsafe EventInfo(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000952 RID: 2386
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_936();

		// Token: 0x06000953 RID: 2387 RVA: 0x0000C290 File Offset: 0x0000B290
		public EventInfo() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = EventInfo._EASharpBinding_936();
		}

		// Token: 0x06000954 RID: 2388
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_937(void* _ThisPtr);

		// Token: 0x06000955 RID: 2389 RVA: 0x0000C2B8 File Offset: 0x0000B2B8
		~EventInfo()
		{
			EventInfo._EASharpBinding_937(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000956 RID: 2390
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_938(void* _ThisPtr, sbyte* value);

		// Token: 0x06000957 RID: 2391 RVA: 0x0000C2F4 File Offset: 0x0000B2F4
		public unsafe void SetCourseName(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				EventInfo._EASharpBinding_938(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000958 RID: 2392
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_939(void* _ThisPtr, sbyte* value);

		// Token: 0x06000959 RID: 2393 RVA: 0x0000C354 File Offset: 0x0000B354
		public unsafe void SetGameModeName(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				EventInfo._EASharpBinding_939(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x0600095A RID: 2394
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_940(void* _ThisPtr, sbyte* value);

		// Token: 0x0600095B RID: 2395 RVA: 0x0000C3B4 File Offset: 0x0000B3B4
		public unsafe void SetTrackLength(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				EventInfo._EASharpBinding_940(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x0600095C RID: 2396
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_941(void* _ThisPtr, sbyte* value);

		// Token: 0x0600095D RID: 2397 RVA: 0x0000C414 File Offset: 0x0000B414
		public unsafe void SetCourseMap(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				EventInfo._EASharpBinding_941(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x0600095E RID: 2398
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_942(void* _ThisPtr, sbyte* value);

		// Token: 0x0600095F RID: 2399 RVA: 0x0000C474 File Offset: 0x0000B474
		public unsafe void SetCondition(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				EventInfo._EASharpBinding_942(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000960 RID: 2400
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_943(void* _ThisPtr, sbyte* value);

		// Token: 0x06000961 RID: 2401 RVA: 0x0000C4D4 File Offset: 0x0000B4D4
		public unsafe void SetGameModeIcon(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				EventInfo._EASharpBinding_943(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000962 RID: 2402
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_944(void* _ThisPtr, sbyte* value);

		// Token: 0x06000963 RID: 2403 RVA: 0x0000C534 File Offset: 0x0000B534
		public unsafe void SetCarClassIcon(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				EventInfo._EASharpBinding_944(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000964 RID: 2404
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_945(void* _ThisPtr, sbyte* value);

		// Token: 0x06000965 RID: 2405 RVA: 0x0000C594 File Offset: 0x0000B594
		public unsafe void SetCarClassLockedIcon(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				EventInfo._EASharpBinding_945(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000966 RID: 2406
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_946(void* _ThisPtr, sbyte* value);

		// Token: 0x06000967 RID: 2407 RVA: 0x0000C5F4 File Offset: 0x0000B5F4
		public unsafe void SetEventDetails(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				EventInfo._EASharpBinding_946(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000968 RID: 2408
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_947(void* _ThisPtr, sbyte* value);

		// Token: 0x06000969 RID: 2409 RVA: 0x0000C654 File Offset: 0x0000B654
		public unsafe void SetEventCategory(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				EventInfo._EASharpBinding_947(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x0600096A RID: 2410
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_948(void* _ThisPtr, sbyte* value);

		// Token: 0x0600096B RID: 2411 RVA: 0x0000C6B4 File Offset: 0x0000B6B4
		public unsafe void SetTimeLimit(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				EventInfo._EASharpBinding_948(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x0600096C RID: 2412
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_949(void* _ThisPtr, sbyte* value);

		// Token: 0x0600096D RID: 2413 RVA: 0x0000C714 File Offset: 0x0000B714
		public unsafe void SetLockedReason(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				EventInfo._EASharpBinding_949(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x0600096E RID: 2414
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_950(void* self, uint val);

		// Token: 0x0600096F RID: 2415
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_951(void* self);

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000970 RID: 2416 RVA: 0x0000C771 File Offset: 0x0000B771
		// (set) Token: 0x06000971 RID: 2417 RVA: 0x0000C77E File Offset: 0x0000B77E
		public uint EventId
		{
			get
			{
				return EventInfo._EASharpBinding_951(this.mSelf);
			}
			set
			{
				EventInfo._EASharpBinding_950(this.mSelf, value);
			}
		}

		// Token: 0x06000972 RID: 2418
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_952(void* self, int val);

		// Token: 0x06000973 RID: 2419
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_953(void* self);

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000974 RID: 2420 RVA: 0x0000C78C File Offset: 0x0000B78C
		// (set) Token: 0x06000975 RID: 2421 RVA: 0x0000C799 File Offset: 0x0000B799
		public EventMode EventModeId
		{
			get
			{
				return (EventMode)EventInfo._EASharpBinding_953(this.mSelf);
			}
			set
			{
				EventInfo._EASharpBinding_952(this.mSelf, (int)value);
			}
		}

		// Token: 0x06000976 RID: 2422
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_954(void* self, bool val);

		// Token: 0x06000977 RID: 2423
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_955(void* self);

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000978 RID: 2424 RVA: 0x0000C7A7 File Offset: 0x0000B7A7
		// (set) Token: 0x06000979 RID: 2425 RVA: 0x0000C7B4 File Offset: 0x0000B7B4
		public bool IsLocked
		{
			get
			{
				return EventInfo._EASharpBinding_955(this.mSelf);
			}
			set
			{
				EventInfo._EASharpBinding_954(this.mSelf, value);
			}
		}

		// Token: 0x0600097A RID: 2426
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_956(void* self, int val);

		// Token: 0x0600097B RID: 2427
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_957(void* self);

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600097C RID: 2428 RVA: 0x0000C7C2 File Offset: 0x0000B7C2
		// (set) Token: 0x0600097D RID: 2429 RVA: 0x0000C7CF File Offset: 0x0000B7CF
		public int Laps
		{
			get
			{
				return EventInfo._EASharpBinding_957(this.mSelf);
			}
			set
			{
				EventInfo._EASharpBinding_956(this.mSelf, value);
			}
		}

		// Token: 0x0600097E RID: 2430
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_958(void* self, int val);

		// Token: 0x0600097F RID: 2431
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_959(void* self);

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000980 RID: 2432 RVA: 0x0000C7DD File Offset: 0x0000B7DD
		// (set) Token: 0x06000981 RID: 2433 RVA: 0x0000C7EA File Offset: 0x0000B7EA
		public int ZoneHeat
		{
			get
			{
				return EventInfo._EASharpBinding_959(this.mSelf);
			}
			set
			{
				EventInfo._EASharpBinding_958(this.mSelf, value);
			}
		}

		// Token: 0x06000982 RID: 2434
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_960(void* self, int val);

		// Token: 0x06000983 RID: 2435
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_961(void* self);

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000984 RID: 2436 RVA: 0x0000C7F8 File Offset: 0x0000B7F8
		// (set) Token: 0x06000985 RID: 2437 RVA: 0x0000C805 File Offset: 0x0000B805
		public int MaxPlayers
		{
			get
			{
				return EventInfo._EASharpBinding_961(this.mSelf);
			}
			set
			{
				EventInfo._EASharpBinding_960(this.mSelf, value);
			}
		}

		// Token: 0x06000986 RID: 2438
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_962(void* self, bool val);

		// Token: 0x06000987 RID: 2439
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_963(void* self);

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000988 RID: 2440 RVA: 0x0000C813 File Offset: 0x0000B813
		// (set) Token: 0x06000989 RID: 2441 RVA: 0x0000C820 File Offset: 0x0000B820
		public bool SinglePlayer
		{
			get
			{
				return EventInfo._EASharpBinding_963(this.mSelf);
			}
			set
			{
				EventInfo._EASharpBinding_962(this.mSelf, value);
			}
		}

		// Token: 0x0600098A RID: 2442
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_964(void* self, bool val);

		// Token: 0x0600098B RID: 2443
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_965(void* self);

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600098C RID: 2444 RVA: 0x0000C82E File Offset: 0x0000B82E
		// (set) Token: 0x0600098D RID: 2445 RVA: 0x0000C83B File Offset: 0x0000B83B
		public bool MultiPlayer
		{
			get
			{
				return EventInfo._EASharpBinding_965(this.mSelf);
			}
			set
			{
				EventInfo._EASharpBinding_964(this.mSelf, value);
			}
		}

		// Token: 0x0600098E RID: 2446
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_966(void* self, bool val);

		// Token: 0x0600098F RID: 2447
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_967(void* self);

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000990 RID: 2448 RVA: 0x0000C849 File Offset: 0x0000B849
		// (set) Token: 0x06000991 RID: 2449 RVA: 0x0000C856 File Offset: 0x0000B856
		public bool PrivateMultiPlayer
		{
			get
			{
				return EventInfo._EASharpBinding_967(this.mSelf);
			}
			set
			{
				EventInfo._EASharpBinding_966(this.mSelf, value);
			}
		}

		// Token: 0x06000992 RID: 2450
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_968(void* self, int val);

		// Token: 0x06000993 RID: 2451
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_969(void* self);

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000994 RID: 2452 RVA: 0x0000C864 File Offset: 0x0000B864
		// (set) Token: 0x06000995 RID: 2453 RVA: 0x0000C871 File Offset: 0x0000B871
		public int MinLevel
		{
			get
			{
				return EventInfo._EASharpBinding_969(this.mSelf);
			}
			set
			{
				EventInfo._EASharpBinding_968(this.mSelf, value);
			}
		}

		// Token: 0x06000996 RID: 2454
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_970(void* self, int val);

		// Token: 0x06000997 RID: 2455
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_971(void* self);

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000998 RID: 2456 RVA: 0x0000C87F File Offset: 0x0000B87F
		// (set) Token: 0x06000999 RID: 2457 RVA: 0x0000C88C File Offset: 0x0000B88C
		public int MinHeatLevel
		{
			get
			{
				return EventInfo._EASharpBinding_971(this.mSelf);
			}
			set
			{
				EventInfo._EASharpBinding_970(this.mSelf, value);
			}
		}

		// Token: 0x0600099A RID: 2458
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_972(void* self, int val);

		// Token: 0x0600099B RID: 2459
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_973(void* self);

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600099C RID: 2460 RVA: 0x0000C89A File Offset: 0x0000B89A
		// (set) Token: 0x0600099D RID: 2461 RVA: 0x0000C8A7 File Offset: 0x0000B8A7
		public int BustLimit
		{
			get
			{
				return EventInfo._EASharpBinding_973(this.mSelf);
			}
			set
			{
				EventInfo._EASharpBinding_972(this.mSelf, value);
			}
		}

		// Token: 0x0600099E RID: 2462
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_974(void* self, float val);

		// Token: 0x0600099F RID: 2463
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_975(void* self);

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x0000C8B5 File Offset: 0x0000B8B5
		// (set) Token: 0x060009A1 RID: 2465 RVA: 0x0000C8C2 File Offset: 0x0000B8C2
		public float PlayerHeat
		{
			get
			{
				return EventInfo._EASharpBinding_975(this.mSelf);
			}
			set
			{
				EventInfo._EASharpBinding_974(this.mSelf, value);
			}
		}

		// Token: 0x060009A2 RID: 2466
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_976(void* self, bool val);

		// Token: 0x060009A3 RID: 2467
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_977(void* self);

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060009A4 RID: 2468 RVA: 0x0000C8D0 File Offset: 0x0000B8D0
		// (set) Token: 0x060009A5 RID: 2469 RVA: 0x0000C8DD File Offset: 0x0000B8DD
		public bool Traffic
		{
			get
			{
				return EventInfo._EASharpBinding_977(this.mSelf);
			}
			set
			{
				EventInfo._EASharpBinding_976(this.mSelf, value);
			}
		}
	}
}
