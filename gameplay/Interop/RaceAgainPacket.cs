using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x020000B6 RID: 182
	[ExportOnlyCreate(true)]
	public class RaceAgainPacket : ISerializable
	{
		// Token: 0x06000A62 RID: 2658 RVA: 0x0000D418 File Offset: 0x0000C418
		public new unsafe static RaceAgainPacket CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new RaceAgainPacket(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x0000D43B File Offset: 0x0000C43B
		public unsafe RaceAgainPacket(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x0000D445 File Offset: 0x0000C445
		protected internal RaceAgainPacket(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x0000D44E File Offset: 0x0000C44E
		protected internal unsafe RaceAgainPacket(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000A66 RID: 2662
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1048();

		// Token: 0x06000A67 RID: 2663 RVA: 0x0000D458 File Offset: 0x0000C458
		public RaceAgainPacket() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = RaceAgainPacket._EASharpBinding_1048();
		}

		// Token: 0x06000A68 RID: 2664
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1049(void* _ThisPtr);

		// Token: 0x06000A69 RID: 2665 RVA: 0x0000D480 File Offset: 0x0000C480
		~RaceAgainPacket()
		{
			RaceAgainPacket._EASharpBinding_1049(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000A6A RID: 2666
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1050(void* self, bool val);

		// Token: 0x06000A6B RID: 2667
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_1051(void* self);

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000A6C RID: 2668 RVA: 0x0000D4BC File Offset: 0x0000C4BC
		// (set) Token: 0x06000A6D RID: 2669 RVA: 0x0000D4C9 File Offset: 0x0000C4C9
		public bool RaceAgainAvailable
		{
			get
			{
				return RaceAgainPacket._EASharpBinding_1051(this.mSelf);
			}
			set
			{
				RaceAgainPacket._EASharpBinding_1050(this.mSelf, value);
			}
		}

		// Token: 0x06000A6E RID: 2670
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1052(void* self, bool val);

		// Token: 0x06000A6F RID: 2671
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_1053(void* self);

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000A70 RID: 2672 RVA: 0x0000D4D7 File Offset: 0x0000C4D7
		// (set) Token: 0x06000A71 RID: 2673 RVA: 0x0000D4E4 File Offset: 0x0000C4E4
		public bool HurryUp
		{
			get
			{
				return RaceAgainPacket._EASharpBinding_1053(this.mSelf);
			}
			set
			{
				RaceAgainPacket._EASharpBinding_1052(this.mSelf, value);
			}
		}
	}
}
