using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore.Collections
{
	// Token: 0x02000078 RID: 120
	[ExportOnlyCreate(false)]
	public class KeyList : ExposedCommonBase
	{
		// Token: 0x06000610 RID: 1552 RVA: 0x000086CC File Offset: 0x000076CC
		public unsafe static KeyList CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new KeyList(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x000086EF File Offset: 0x000076EF
		public unsafe KeyList(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x000086F9 File Offset: 0x000076F9
		protected internal KeyList(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00008702 File Offset: 0x00007702
		protected internal unsafe KeyList(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000614 RID: 1556
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_610(void* self);

		// Token: 0x06000615 RID: 1557 RVA: 0x0000870C File Offset: 0x0000770C
		[DisableExceptionHandling]
		~KeyList()
		{
			KeyList._EASharpBinding_610(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000616 RID: 1558
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_611(uint reserve);

		// Token: 0x06000617 RID: 1559 RVA: 0x00008748 File Offset: 0x00007748
		public KeyList(uint reserve) : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = KeyList._EASharpBinding_611(reserve);
		}

		// Token: 0x06000618 RID: 1560
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_612(void* _ThisPtr, uint key);

		// Token: 0x06000619 RID: 1561 RVA: 0x00008770 File Offset: 0x00007770
		public void AddKey(uint key)
		{
			KeyList._EASharpBinding_612(this.mSelf, key);
		}

		// Token: 0x0600061A RID: 1562
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_613(void* _ThisPtr);

		// Token: 0x0600061B RID: 1563 RVA: 0x0000877E File Offset: 0x0000777E
		public void Clear()
		{
			KeyList._EASharpBinding_613(this.mSelf);
		}

		// Token: 0x0600061C RID: 1564
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_614(void* _ThisPtr);

		// Token: 0x0600061D RID: 1565 RVA: 0x0000878C File Offset: 0x0000778C
		public uint Count()
		{
			return KeyList._EASharpBinding_614(this.mSelf);
		}

		// Token: 0x0600061E RID: 1566
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_615(void* _ThisPtr, int index);

		// Token: 0x0600061F RID: 1567 RVA: 0x000087A8 File Offset: 0x000077A8
		public uint Get(int index)
		{
			return KeyList._EASharpBinding_615(this.mSelf, index);
		}
	}
}
