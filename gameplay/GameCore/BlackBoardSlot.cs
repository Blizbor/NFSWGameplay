using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x02000058 RID: 88
	[ExportOnlyCreate(true)]
	public class BlackBoardSlot : ExposedCommonBase
	{
		// Token: 0x060003FA RID: 1018 RVA: 0x00005FE4 File Offset: 0x00004FE4
		public unsafe static BlackBoardSlot CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new BlackBoardSlot(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00006007 File Offset: 0x00005007
		public unsafe BlackBoardSlot(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00006011 File Offset: 0x00005011
		protected internal BlackBoardSlot(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0000601A File Offset: 0x0000501A
		protected internal unsafe BlackBoardSlot(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060003FE RID: 1022
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_400(void* self);

		// Token: 0x060003FF RID: 1023 RVA: 0x00006024 File Offset: 0x00005024
		[DisableExceptionHandling]
		~BlackBoardSlot()
		{
			BlackBoardSlot._EASharpBinding_400(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000400 RID: 1024
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_401(void* self, int val);

		// Token: 0x06000401 RID: 1025
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_402(void* self);

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x00006060 File Offset: 0x00005060
		// (set) Token: 0x06000403 RID: 1027 RVA: 0x0000606D File Offset: 0x0000506D
		public BlackBoardChannel mChannel
		{
			get
			{
				return (BlackBoardChannel)BlackBoardSlot._EASharpBinding_402(this.mSelf);
			}
			set
			{
				BlackBoardSlot._EASharpBinding_401(this.mSelf, (int)value);
			}
		}

		// Token: 0x06000404 RID: 1028
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_403(void* self, void* val);

		// Token: 0x06000405 RID: 1029
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_404(void* self);

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x0000607C File Offset: 0x0000507C
		// (set) Token: 0x06000407 RID: 1031 RVA: 0x000060A2 File Offset: 0x000050A2
		public StringKey mBlackBoardKey
		{
			get
			{
				return new StringKey(default(ExposeTag_InitOwned), BlackBoardSlot._EASharpBinding_404(this.mSelf));
			}
			set
			{
				BlackBoardSlot._EASharpBinding_403(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
			}
		}

		// Token: 0x06000408 RID: 1032
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_405(void* self, void* val);

		// Token: 0x06000409 RID: 1033
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_406(void* self);

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x000060C4 File Offset: 0x000050C4
		// (set) Token: 0x0600040B RID: 1035 RVA: 0x000060EA File Offset: 0x000050EA
		public BlackBoardFlags mFlags
		{
			get
			{
				return new BlackBoardFlags(default(ExposeTag_InitOwned), BlackBoardSlot._EASharpBinding_406(this.mSelf));
			}
			set
			{
				BlackBoardSlot._EASharpBinding_405(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
			}
		}
	}
}
