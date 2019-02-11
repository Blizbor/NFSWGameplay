using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x0200003A RID: 58
	[ExportOnlyCreate(false)]
	public class InternalBehaviorContainer : ExposedCommonBase
	{
		// Token: 0x060001AA RID: 426 RVA: 0x00003D30 File Offset: 0x00002D30
		public unsafe static InternalBehaviorContainer CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new InternalBehaviorContainer(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00003D53 File Offset: 0x00002D53
		public unsafe InternalBehaviorContainer(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00003D5D File Offset: 0x00002D5D
		protected internal InternalBehaviorContainer(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00003D66 File Offset: 0x00002D66
		protected internal unsafe InternalBehaviorContainer(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060001AE RID: 430
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_126(void* instance);

		// Token: 0x060001AF RID: 431 RVA: 0x00003D70 File Offset: 0x00002D70
		public InternalBehaviorContainer(InternalInstance instance) : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = InternalBehaviorContainer._EASharpBinding_126(object.ReferenceEquals(instance, null) ? null : instance._GetRaw());
		}

		// Token: 0x060001B0 RID: 432
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_127(void* _ThisPtr);

		// Token: 0x060001B1 RID: 433 RVA: 0x00003DAC File Offset: 0x00002DAC
		~InternalBehaviorContainer()
		{
			InternalBehaviorContainer._EASharpBinding_127(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060001B2 RID: 434
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_128(void* _ThisPtr, void* owner);

		// Token: 0x060001B3 RID: 435 RVA: 0x00003DE8 File Offset: 0x00002DE8
		public void Load(IInternalBehaviorOwner owner)
		{
			InternalBehaviorContainer._EASharpBinding_128(this.mSelf, object.ReferenceEquals(owner, null) ? null : owner._GetRaw());
		}

		// Token: 0x060001B4 RID: 436
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_129(void* _ThisPtr);

		// Token: 0x060001B5 RID: 437 RVA: 0x00003E08 File Offset: 0x00002E08
		public void Unload()
		{
			InternalBehaviorContainer._EASharpBinding_129(this.mSelf);
		}

		// Token: 0x060001B6 RID: 438
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_130(void* _ThisPtr);

		// Token: 0x060001B7 RID: 439 RVA: 0x00003E15 File Offset: 0x00002E15
		public void Activate()
		{
			InternalBehaviorContainer._EASharpBinding_130(this.mSelf);
		}

		// Token: 0x060001B8 RID: 440
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_131(void* _ThisPtr);

		// Token: 0x060001B9 RID: 441 RVA: 0x00003E22 File Offset: 0x00002E22
		public void Deactivate()
		{
			InternalBehaviorContainer._EASharpBinding_131(this.mSelf);
		}
	}
}
