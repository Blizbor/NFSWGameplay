using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x0200005C RID: 92
	[ExportOnlyCreate(true)]
	public class ObjectiveSlot : ExposedCommonBase
	{
		// Token: 0x0600042A RID: 1066 RVA: 0x000062D4 File Offset: 0x000052D4
		public unsafe static ObjectiveSlot CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new ObjectiveSlot(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x000062F7 File Offset: 0x000052F7
		public unsafe ObjectiveSlot(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00006301 File Offset: 0x00005301
		protected internal ObjectiveSlot(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0000630A File Offset: 0x0000530A
		protected internal unsafe ObjectiveSlot(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600042E RID: 1070
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_416(void* self);

		// Token: 0x0600042F RID: 1071 RVA: 0x00006314 File Offset: 0x00005314
		[DisableExceptionHandling]
		~ObjectiveSlot()
		{
			ObjectiveSlot._EASharpBinding_416(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000430 RID: 1072
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_417(void* self, void* val);

		// Token: 0x06000431 RID: 1073
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_418(void* self);

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x00006350 File Offset: 0x00005350
		// (set) Token: 0x06000433 RID: 1075 RVA: 0x00006376 File Offset: 0x00005376
		public GCollectionKey mAnnouncementKey
		{
			get
			{
				return new GCollectionKey(default(ExposeTag_InitOwned), ObjectiveSlot._EASharpBinding_418(this.mSelf));
			}
			set
			{
				ObjectiveSlot._EASharpBinding_417(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
			}
		}

		// Token: 0x06000434 RID: 1076
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_419(void* self, int val);

		// Token: 0x06000435 RID: 1077
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_420(void* self);

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x00006396 File Offset: 0x00005396
		// (set) Token: 0x06000437 RID: 1079 RVA: 0x000063A3 File Offset: 0x000053A3
		public int mCount
		{
			get
			{
				return ObjectiveSlot._EASharpBinding_420(this.mSelf);
			}
			set
			{
				ObjectiveSlot._EASharpBinding_419(this.mSelf, value);
			}
		}
	}
}
