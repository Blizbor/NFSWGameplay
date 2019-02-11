using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x02000056 RID: 86
	[ExportOnlyCreate(true)]
	public class BehaviorSlot : ExposedCommonBase
	{
		// Token: 0x060003DE RID: 990 RVA: 0x00005DF8 File Offset: 0x00004DF8
		public unsafe static BehaviorSlot CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new BehaviorSlot(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00005E1B File Offset: 0x00004E1B
		public unsafe BehaviorSlot(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00005E25 File Offset: 0x00004E25
		protected internal BehaviorSlot(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00005E2E File Offset: 0x00004E2E
		protected internal unsafe BehaviorSlot(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060003E2 RID: 994
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_390(void* self);

		// Token: 0x060003E3 RID: 995 RVA: 0x00005E38 File Offset: 0x00004E38
		[DisableExceptionHandling]
		~BehaviorSlot()
		{
			BehaviorSlot._EASharpBinding_390(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060003E4 RID: 996
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_391(void* self, void* val);

		// Token: 0x060003E5 RID: 997
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_392(void* self);

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x00005E74 File Offset: 0x00004E74
		// (set) Token: 0x060003E7 RID: 999 RVA: 0x00005E9A File Offset: 0x00004E9A
		public StringKey mBehaviorChannel
		{
			get
			{
				return new StringKey(default(ExposeTag_InitOwned), BehaviorSlot._EASharpBinding_392(this.mSelf));
			}
			set
			{
				BehaviorSlot._EASharpBinding_391(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
			}
		}

		// Token: 0x060003E8 RID: 1000
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_393(void* self, void* val);

		// Token: 0x060003E9 RID: 1001
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_394(void* self);

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x00005EBC File Offset: 0x00004EBC
		// (set) Token: 0x060003EB RID: 1003 RVA: 0x00005EE2 File Offset: 0x00004EE2
		public StringKey mBehaviorType
		{
			get
			{
				return new StringKey(default(ExposeTag_InitOwned), BehaviorSlot._EASharpBinding_394(this.mSelf));
			}
			set
			{
				BehaviorSlot._EASharpBinding_393(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
			}
		}

		// Token: 0x060003EC RID: 1004
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_395(void* self, void* val);

		// Token: 0x060003ED RID: 1005
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_396(void* self);

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x00005F04 File Offset: 0x00004F04
		// (set) Token: 0x060003EF RID: 1007 RVA: 0x00005F2A File Offset: 0x00004F2A
		public BehaviorFlags mFlags
		{
			get
			{
				return new BehaviorFlags(default(ExposeTag_InitOwned), BehaviorSlot._EASharpBinding_396(this.mSelf));
			}
			set
			{
				BehaviorSlot._EASharpBinding_395(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
			}
		}
	}
}
