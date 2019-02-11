using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x020000B5 RID: 181
	[ExportOnlyCreate(true)]
	public class TreasureHuntLivePacket : LivePacket
	{
		// Token: 0x06000A52 RID: 2642 RVA: 0x0000D328 File Offset: 0x0000C328
		public new unsafe static TreasureHuntLivePacket CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new TreasureHuntLivePacket(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x0000D34B File Offset: 0x0000C34B
		public unsafe TreasureHuntLivePacket(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x0000D355 File Offset: 0x0000C355
		protected internal TreasureHuntLivePacket(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x0000D35E File Offset: 0x0000C35E
		protected internal unsafe TreasureHuntLivePacket(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000A56 RID: 2646
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1042();

		// Token: 0x06000A57 RID: 2647 RVA: 0x0000D368 File Offset: 0x0000C368
		public TreasureHuntLivePacket() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = TreasureHuntLivePacket._EASharpBinding_1042();
		}

		// Token: 0x06000A58 RID: 2648
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1043(void* _ThisPtr);

		// Token: 0x06000A59 RID: 2649 RVA: 0x0000D390 File Offset: 0x0000C390
		~TreasureHuntLivePacket()
		{
			TreasureHuntLivePacket._EASharpBinding_1043(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000A5A RID: 2650
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1044(void* _ThisPtr);

		// Token: 0x06000A5B RID: 2651 RVA: 0x0000D3CC File Offset: 0x0000C3CC
		public override void Reset()
		{
			TreasureHuntLivePacket._EASharpBinding_1044(this.mSelf);
		}

		// Token: 0x06000A5C RID: 2652
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1045(void* _ThisPtr);

		// Token: 0x06000A5D RID: 2653 RVA: 0x0000D3DC File Offset: 0x0000C3DC
		public TreasureHuntEntrantLivePacket CreateEntrantLivePacket()
		{
			return TreasureHuntEntrantLivePacket.CreateInitUnowned(TreasureHuntLivePacket._EASharpBinding_1045(this.mSelf));
		}

		// Token: 0x06000A5E RID: 2654
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1046(void* self, int val);

		// Token: 0x06000A5F RID: 2655
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1047(void* self);

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x0000D3FB File Offset: 0x0000C3FB
		// (set) Token: 0x06000A61 RID: 2657 RVA: 0x0000D408 File Offset: 0x0000C408
		public int NumCoinsToCollect
		{
			get
			{
				return TreasureHuntLivePacket._EASharpBinding_1047(this.mSelf);
			}
			set
			{
				TreasureHuntLivePacket._EASharpBinding_1046(this.mSelf, value);
			}
		}
	}
}
