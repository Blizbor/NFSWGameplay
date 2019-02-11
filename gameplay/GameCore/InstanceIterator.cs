using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x02000039 RID: 57
	[ExportOnlyCreate(false)]
	public class InstanceIterator : ExposedCommonBase
	{
		// Token: 0x0600019A RID: 410 RVA: 0x00003C18 File Offset: 0x00002C18
		public unsafe static InstanceIterator CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new InstanceIterator(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00003C3B File Offset: 0x00002C3B
		public unsafe InstanceIterator(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00003C45 File Offset: 0x00002C45
		protected internal InstanceIterator(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00003C4E File Offset: 0x00002C4E
		protected internal unsafe InstanceIterator(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600019E RID: 414
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_120(void* self);

		// Token: 0x0600019F RID: 415 RVA: 0x00003C58 File Offset: 0x00002C58
		[DisableExceptionHandling]
		~InstanceIterator()
		{
			InstanceIterator._EASharpBinding_120(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060001A0 RID: 416
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_121(int objType);

		// Token: 0x060001A1 RID: 417 RVA: 0x00003C94 File Offset: 0x00002C94
		public InstanceIterator(ObjType objType) : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = InstanceIterator._EASharpBinding_121((int)objType);
		}

		// Token: 0x060001A2 RID: 418
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_122(int objType, uint flagMask);

		// Token: 0x060001A3 RID: 419 RVA: 0x00003CBC File Offset: 0x00002CBC
		public InstanceIterator(ObjType objType, uint flagMask) : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = InstanceIterator._EASharpBinding_122((int)objType, flagMask);
		}

		// Token: 0x060001A4 RID: 420
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_123(void* _ThisPtr);

		// Token: 0x060001A5 RID: 421 RVA: 0x00003CE5 File Offset: 0x00002CE5
		public void Advance()
		{
			InstanceIterator._EASharpBinding_123(this.mSelf);
		}

		// Token: 0x060001A6 RID: 422
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_124(void* _ThisPtr);

		// Token: 0x060001A7 RID: 423 RVA: 0x00003CF4 File Offset: 0x00002CF4
		public bool IsValid()
		{
			return InstanceIterator._EASharpBinding_124(this.mSelf);
		}

		// Token: 0x060001A8 RID: 424
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_125(void* _ThisPtr);

		// Token: 0x060001A9 RID: 425 RVA: 0x00003D10 File Offset: 0x00002D10
		public InternalInstance GetInstance()
		{
			return InternalInstance.CreateInitUnowned(InstanceIterator._EASharpBinding_125(this.mSelf));
		}
	}
}
