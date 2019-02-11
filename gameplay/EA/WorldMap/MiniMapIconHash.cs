using System;
using System.Runtime.InteropServices;
using EASharp;

namespace EA.WorldMap
{
	// Token: 0x020000E7 RID: 231
	[ExportOnlyCreate(true)]
	public class MiniMapIconHash : ExposedCommonBase
	{
		// Token: 0x06000DDC RID: 3548 RVA: 0x00010A1C File Offset: 0x0000FA1C
		public unsafe static MiniMapIconHash CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new MiniMapIconHash(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x00010A3F File Offset: 0x0000FA3F
		public unsafe MiniMapIconHash(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x00010A49 File Offset: 0x0000FA49
		protected internal MiniMapIconHash(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x00010A52 File Offset: 0x0000FA52
		protected internal unsafe MiniMapIconHash(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000DE0 RID: 3552
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1411(void* self);

		// Token: 0x06000DE1 RID: 3553 RVA: 0x00010A5C File Offset: 0x0000FA5C
		[DisableExceptionHandling]
		~MiniMapIconHash()
		{
			MiniMapIconHash._EASharpBinding_1411(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000DE2 RID: 3554
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1412(void* self, uint val);

		// Token: 0x06000DE3 RID: 3555
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_1413(void* self);

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000DE4 RID: 3556 RVA: 0x00010A98 File Offset: 0x0000FA98
		// (set) Token: 0x06000DE5 RID: 3557 RVA: 0x00010AA5 File Offset: 0x0000FAA5
		public uint Hash
		{
			get
			{
				return MiniMapIconHash._EASharpBinding_1413(this.mSelf);
			}
			set
			{
				MiniMapIconHash._EASharpBinding_1412(this.mSelf, value);
			}
		}
	}
}
