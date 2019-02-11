using System;
using System.Runtime.InteropServices;
using EASharp;
using GameCore.Math;

namespace GameCore
{
	// Token: 0x0200003D RID: 61
	[ExportOnlyCreate(false)]
	public class InternalEventDefinition : InternalInstance
	{
		// Token: 0x060001D8 RID: 472 RVA: 0x00003F8C File Offset: 0x00002F8C
		public new unsafe static InternalEventDefinition CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new InternalEventDefinition(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00003FAF File Offset: 0x00002FAF
		public unsafe InternalEventDefinition(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00003FB9 File Offset: 0x00002FB9
		protected internal InternalEventDefinition(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00003FC2 File Offset: 0x00002FC2
		protected internal unsafe InternalEventDefinition(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060001DC RID: 476
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_168(void* self);

		// Token: 0x060001DD RID: 477 RVA: 0x00003FCC File Offset: 0x00002FCC
		[DisableExceptionHandling]
		~InternalEventDefinition()
		{
			InternalEventDefinition._EASharpBinding_168(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060001DE RID: 478
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_169(void* _ThisPtr);

		// Token: 0x060001DF RID: 479 RVA: 0x00004008 File Offset: 0x00003008
		public uint GetEventId()
		{
			return InternalEventDefinition._EASharpBinding_169(this.mSelf);
		}

		// Token: 0x060001E0 RID: 480
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_170(void* _ThisPtr);

		// Token: 0x060001E1 RID: 481 RVA: 0x00004024 File Offset: 0x00003024
		public uint GetEventType()
		{
			return InternalEventDefinition._EASharpBinding_170(this.mSelf);
		}

		// Token: 0x060001E2 RID: 482
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_171(void* _ThisPtr);

		// Token: 0x060001E3 RID: 483 RVA: 0x00004040 File Offset: 0x00003040
		public uint EventLocalization()
		{
			return InternalEventDefinition._EASharpBinding_171(this.mSelf);
		}

		// Token: 0x060001E4 RID: 484
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_172(void* _ThisPtr);

		// Token: 0x060001E5 RID: 485 RVA: 0x0000405C File Offset: 0x0000305C
		public uint EventModeLocalization()
		{
			return InternalEventDefinition._EASharpBinding_172(this.mSelf);
		}

		// Token: 0x060001E6 RID: 486
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_173(void* _ThisPtr);

		// Token: 0x060001E7 RID: 487 RVA: 0x00004078 File Offset: 0x00003078
		public uint GetEffectHash()
		{
			return InternalEventDefinition._EASharpBinding_173(this.mSelf);
		}

		// Token: 0x060001E8 RID: 488
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_174(void* _ThisPtr);

		// Token: 0x060001E9 RID: 489 RVA: 0x00004094 File Offset: 0x00003094
		public Vector3 GetPosition()
		{
			return Vector3.CreateInitUnowned(InternalEventDefinition._EASharpBinding_174(this.mSelf));
		}

		// Token: 0x060001EA RID: 490
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_175(void* _ThisPtr);

		// Token: 0x060001EB RID: 491 RVA: 0x000040B4 File Offset: 0x000030B4
		public float GetRotation()
		{
			return InternalEventDefinition._EASharpBinding_175(this.mSelf);
		}

		// Token: 0x060001EC RID: 492
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_176(void* _ThisPtr);

		// Token: 0x060001ED RID: 493 RVA: 0x000040D0 File Offset: 0x000030D0
		public float GetRadius()
		{
			return InternalEventDefinition._EASharpBinding_176(this.mSelf);
		}

		// Token: 0x060001EE RID: 494
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_177(void* _ThisPtr);

		// Token: 0x060001EF RID: 495 RVA: 0x000040EC File Offset: 0x000030EC
		public int GetStrikeCount()
		{
			return InternalEventDefinition._EASharpBinding_177(this.mSelf);
		}

		// Token: 0x060001F0 RID: 496
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_178(void* _ThisPtr);

		// Token: 0x060001F1 RID: 497 RVA: 0x00004108 File Offset: 0x00003108
		public override IInternalBehaviorOwner BehaviorOwner()
		{
			return IInternalBehaviorOwner.CreateInitUnowned(InternalEventDefinition._EASharpBinding_178(this.mSelf));
		}
	}
}
