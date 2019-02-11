using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x020000B1 RID: 177
	[ExportOnlyCreate(true)]
	public class TeamEscapeLivePacket : LivePacket
	{
		// Token: 0x06000A12 RID: 2578 RVA: 0x0000CF70 File Offset: 0x0000BF70
		public new unsafe static TeamEscapeLivePacket CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new TeamEscapeLivePacket(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x0000CF93 File Offset: 0x0000BF93
		public unsafe TeamEscapeLivePacket(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x0000CF9D File Offset: 0x0000BF9D
		protected internal TeamEscapeLivePacket(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x0000CFA6 File Offset: 0x0000BFA6
		protected internal unsafe TeamEscapeLivePacket(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000A16 RID: 2582
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1018();

		// Token: 0x06000A17 RID: 2583 RVA: 0x0000CFB0 File Offset: 0x0000BFB0
		public TeamEscapeLivePacket() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = TeamEscapeLivePacket._EASharpBinding_1018();
		}

		// Token: 0x06000A18 RID: 2584
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1019(void* _ThisPtr);

		// Token: 0x06000A19 RID: 2585 RVA: 0x0000CFD8 File Offset: 0x0000BFD8
		~TeamEscapeLivePacket()
		{
			TeamEscapeLivePacket._EASharpBinding_1019(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000A1A RID: 2586
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1020(void* _ThisPtr);

		// Token: 0x06000A1B RID: 2587 RVA: 0x0000D014 File Offset: 0x0000C014
		public override void Reset()
		{
			TeamEscapeLivePacket._EASharpBinding_1020(this.mSelf);
		}

		// Token: 0x06000A1C RID: 2588
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1021(void* _ThisPtr);

		// Token: 0x06000A1D RID: 2589 RVA: 0x0000D024 File Offset: 0x0000C024
		public TeamEscapeEntrantLivePacket CreateEntrantLivePacket()
		{
			return TeamEscapeEntrantLivePacket.CreateInitUnowned(TeamEscapeLivePacket._EASharpBinding_1021(this.mSelf));
		}

		// Token: 0x06000A1E RID: 2590
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1022(void* _ThisPtr);

		// Token: 0x06000A1F RID: 2591 RVA: 0x0000D044 File Offset: 0x0000C044
		public TimeSpan GetEventTimer()
		{
			return TimeSpan.CreateInitUnowned(TeamEscapeLivePacket._EASharpBinding_1022(this.mSelf));
		}

		// Token: 0x06000A20 RID: 2592
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1023(void* self, int val);

		// Token: 0x06000A21 RID: 2593
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1024(void* self);

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x0000D063 File Offset: 0x0000C063
		// (set) Token: 0x06000A23 RID: 2595 RVA: 0x0000D070 File Offset: 0x0000C070
		public int NumBusts
		{
			get
			{
				return TeamEscapeLivePacket._EASharpBinding_1024(this.mSelf);
			}
			set
			{
				TeamEscapeLivePacket._EASharpBinding_1023(this.mSelf, value);
			}
		}

		// Token: 0x06000A24 RID: 2596
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1025(void* self, int val);

		// Token: 0x06000A25 RID: 2597
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1026(void* self);

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x0000D07E File Offset: 0x0000C07E
		// (set) Token: 0x06000A27 RID: 2599 RVA: 0x0000D08B File Offset: 0x0000C08B
		public int MaxStrikes
		{
			get
			{
				return TeamEscapeLivePacket._EASharpBinding_1026(this.mSelf);
			}
			set
			{
				TeamEscapeLivePacket._EASharpBinding_1025(this.mSelf, value);
			}
		}

		// Token: 0x06000A28 RID: 2600
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1027(void* self, bool val);

		// Token: 0x06000A29 RID: 2601
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_1028(void* self);

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x0000D099 File Offset: 0x0000C099
		// (set) Token: 0x06000A2B RID: 2603 RVA: 0x0000D0A6 File Offset: 0x0000C0A6
		public bool IsTimerUrgent
		{
			get
			{
				return TeamEscapeLivePacket._EASharpBinding_1028(this.mSelf);
			}
			set
			{
				TeamEscapeLivePacket._EASharpBinding_1027(this.mSelf, value);
			}
		}
	}
}
