using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x0200003F RID: 63
	[ExportOnlyCreate(false)]
	public class InternalEventRepository : ExposedCommonBase
	{
		// Token: 0x060001FE RID: 510 RVA: 0x000041F0 File Offset: 0x000031F0
		public unsafe static InternalEventRepository CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new InternalEventRepository(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00004213 File Offset: 0x00003213
		public unsafe InternalEventRepository(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000421D File Offset: 0x0000321D
		protected internal InternalEventRepository(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00004226 File Offset: 0x00003226
		protected internal unsafe InternalEventRepository(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000202 RID: 514
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_183(void* self);

		// Token: 0x06000203 RID: 515 RVA: 0x00004230 File Offset: 0x00003230
		[DisableExceptionHandling]
		~InternalEventRepository()
		{
			InternalEventRepository._EASharpBinding_183(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000204 RID: 516
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_184(void* _ThisPtr, uint eventId);

		// Token: 0x06000205 RID: 517 RVA: 0x0000426C File Offset: 0x0000326C
		public virtual InternalEventDefinition FindByEventId(uint eventId)
		{
			return InternalEventDefinition.CreateInitUnowned(InternalEventRepository._EASharpBinding_184(this.mSelf, eventId));
		}

		// Token: 0x06000206 RID: 518
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_185(void* _ThisPtr, uint eventKey);

		// Token: 0x06000207 RID: 519 RVA: 0x0000428C File Offset: 0x0000328C
		public virtual InternalEventDefinition FindByEventKey(uint eventKey)
		{
			return InternalEventDefinition.CreateInitUnowned(InternalEventRepository._EASharpBinding_185(this.mSelf, eventKey));
		}

		// Token: 0x06000208 RID: 520
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_186(void* _ThisPtr, uint index);

		// Token: 0x06000209 RID: 521 RVA: 0x000042AC File Offset: 0x000032AC
		public virtual InternalEventDefinition FindByEventIndex(uint index)
		{
			return InternalEventDefinition.CreateInitUnowned(InternalEventRepository._EASharpBinding_186(this.mSelf, index));
		}

		// Token: 0x0600020A RID: 522
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_187(void* _ThisPtr);

		// Token: 0x0600020B RID: 523 RVA: 0x000042CC File Offset: 0x000032CC
		public virtual int Count()
		{
			return InternalEventRepository._EASharpBinding_187(this.mSelf);
		}

		// Token: 0x0600020C RID: 524
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_188(void* _ThisPtr);

		// Token: 0x0600020D RID: 525 RVA: 0x000042E6 File Offset: 0x000032E6
		public virtual void RefreshEvents()
		{
			InternalEventRepository._EASharpBinding_188(this.mSelf);
		}
	}
}
