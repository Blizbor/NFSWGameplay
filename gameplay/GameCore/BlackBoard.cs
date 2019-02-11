using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x02000026 RID: 38
	[ExportOnlyCreate(false)]
	public class BlackBoard : ExposedCommonBase
	{
		// Token: 0x0600003A RID: 58 RVA: 0x0000248C File Offset: 0x0000148C
		public unsafe static BlackBoard CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new BlackBoard(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000024AF File Offset: 0x000014AF
		public unsafe BlackBoard(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000024B9 File Offset: 0x000014B9
		protected internal BlackBoard(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000024C2 File Offset: 0x000014C2
		protected internal unsafe BlackBoard(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600003E RID: 62
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_18(void* _ThisPtr, int channel);

		// Token: 0x0600003F RID: 63 RVA: 0x000024CC File Offset: 0x000014CC
		public uint GetCurrentKey(BlackBoardChannel channel)
		{
			return BlackBoard._EASharpBinding_18(this.mSelf, (int)channel);
		}

		// Token: 0x06000040 RID: 64
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_19(void* _ThisPtr, int channel, uint boardKey);

		// Token: 0x06000041 RID: 65 RVA: 0x000024E7 File Offset: 0x000014E7
		public void Change(BlackBoardChannel channel, uint boardKey)
		{
			BlackBoard._EASharpBinding_19(this.mSelf, (int)channel, boardKey);
		}

		// Token: 0x06000042 RID: 66
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_20();

		// Token: 0x06000043 RID: 67 RVA: 0x000024F8 File Offset: 0x000014F8
		public static BlackBoard Get()
		{
			return BlackBoard.CreateInitUnowned(BlackBoard._EASharpBinding_20());
		}

		// Token: 0x02000027 RID: 39
		[ExportOnlyCreate(true)]
		public class BoardMonitorPair : ExposedCommonBase
		{
			// Token: 0x06000044 RID: 68 RVA: 0x00002514 File Offset: 0x00001514
			public unsafe static BlackBoard.BoardMonitorPair CreateInitUnowned(void* self)
			{
				if (self != null)
				{
					return new BlackBoard.BoardMonitorPair(default(ExposeTag_InitUnowned), self);
				}
				return null;
			}

			// Token: 0x06000045 RID: 69 RVA: 0x00002537 File Offset: 0x00001537
			public unsafe BoardMonitorPair(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
			{
			}

			// Token: 0x06000046 RID: 70 RVA: 0x00002541 File Offset: 0x00001541
			protected internal BoardMonitorPair(ExposeTag_NoInitOwned tag) : base(tag)
			{
			}

			// Token: 0x06000047 RID: 71 RVA: 0x0000254A File Offset: 0x0000154A
			protected internal unsafe BoardMonitorPair(ExposeTag_InitOwned tag, void* self) : base(tag, self)
			{
			}

			// Token: 0x06000048 RID: 72
			[DoesNotBlock]
			[DllImport("<internal>")]
			private unsafe static extern void _EASharpBinding_21(void* self);

			// Token: 0x06000049 RID: 73 RVA: 0x00002554 File Offset: 0x00001554
			[DisableExceptionHandling]
			~BoardMonitorPair()
			{
				BlackBoard.BoardMonitorPair._EASharpBinding_21(this.mSelf);
				this.mSelf = null;
			}

			// Token: 0x0600004A RID: 74
			[DllImport("<internal>")]
			private unsafe static extern void _EASharpBinding_22(void* self, int val);

			// Token: 0x0600004B RID: 75
			[DllImport("<internal>")]
			private unsafe static extern int _EASharpBinding_23(void* self);

			// Token: 0x17000001 RID: 1
			// (get) Token: 0x0600004C RID: 76 RVA: 0x00002590 File Offset: 0x00001590
			// (set) Token: 0x0600004D RID: 77 RVA: 0x0000259D File Offset: 0x0000159D
			public BlackBoardChannel board
			{
				get
				{
					return (BlackBoardChannel)BlackBoard.BoardMonitorPair._EASharpBinding_23(this.mSelf);
				}
				set
				{
					BlackBoard.BoardMonitorPair._EASharpBinding_22(this.mSelf, (int)value);
				}
			}

			// Token: 0x0600004E RID: 78
			[DllImport("<internal>")]
			private unsafe static extern void _EASharpBinding_24(void* self, void* val);

			// Token: 0x0600004F RID: 79
			[DllImport("<internal>")]
			private unsafe static extern void* _EASharpBinding_25(void* self);

			// Token: 0x17000002 RID: 2
			// (get) Token: 0x06000050 RID: 80 RVA: 0x000025AB File Offset: 0x000015AB
			// (set) Token: 0x06000051 RID: 81 RVA: 0x000025B8 File Offset: 0x000015B8
			public unsafe void* monitor
			{
				get
				{
					return BlackBoard.BoardMonitorPair._EASharpBinding_25(this.mSelf);
				}
				set
				{
					BlackBoard.BoardMonitorPair._EASharpBinding_24(this.mSelf, value);
				}
			}
		}
	}
}
