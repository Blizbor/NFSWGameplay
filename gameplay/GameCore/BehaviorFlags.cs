using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x02000055 RID: 85
	[ExportOnlyCreate(true)]
	public class BehaviorFlags : ExposedCommonBase
	{
		// Token: 0x060003D4 RID: 980 RVA: 0x00005D60 File Offset: 0x00004D60
		public unsafe static BehaviorFlags CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new BehaviorFlags(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00005D83 File Offset: 0x00004D83
		public unsafe BehaviorFlags(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00005D8D File Offset: 0x00004D8D
		protected internal BehaviorFlags(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00005D96 File Offset: 0x00004D96
		protected internal unsafe BehaviorFlags(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060003D8 RID: 984
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_387(void* self);

		// Token: 0x060003D9 RID: 985 RVA: 0x00005DA0 File Offset: 0x00004DA0
		[DisableExceptionHandling]
		~BehaviorFlags()
		{
			BehaviorFlags._EASharpBinding_387(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060003DA RID: 986
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_388(void* self, uint val);

		// Token: 0x060003DB RID: 987
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_389(void* self);

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060003DC RID: 988 RVA: 0x00005DDC File Offset: 0x00004DDC
		// (set) Token: 0x060003DD RID: 989 RVA: 0x00005DE9 File Offset: 0x00004DE9
		public uint mBits
		{
			get
			{
				return BehaviorFlags._EASharpBinding_389(this.mSelf);
			}
			set
			{
				BehaviorFlags._EASharpBinding_388(this.mSelf, value);
			}
		}
	}
}
