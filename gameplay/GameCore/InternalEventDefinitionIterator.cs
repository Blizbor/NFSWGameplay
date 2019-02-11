using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x0200003E RID: 62
	[ExportOnlyCreate(false)]
	public class InternalEventDefinitionIterator : ExposedCommonBase
	{
		// Token: 0x060001F2 RID: 498 RVA: 0x00004128 File Offset: 0x00003128
		public unsafe static InternalEventDefinitionIterator CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new InternalEventDefinitionIterator(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000414B File Offset: 0x0000314B
		public unsafe InternalEventDefinitionIterator(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00004155 File Offset: 0x00003155
		protected internal InternalEventDefinitionIterator(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0000415E File Offset: 0x0000315E
		protected internal unsafe InternalEventDefinitionIterator(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060001F6 RID: 502
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_179(void* self);

		// Token: 0x060001F7 RID: 503 RVA: 0x00004168 File Offset: 0x00003168
		[DisableExceptionHandling]
		~InternalEventDefinitionIterator()
		{
			InternalEventDefinitionIterator._EASharpBinding_179(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060001F8 RID: 504
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_180(void* _ThisPtr);

		// Token: 0x060001F9 RID: 505 RVA: 0x000041A4 File Offset: 0x000031A4
		public void Advance()
		{
			InternalEventDefinitionIterator._EASharpBinding_180(this.mSelf);
		}

		// Token: 0x060001FA RID: 506
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_181(void* _ThisPtr);

		// Token: 0x060001FB RID: 507 RVA: 0x000041B4 File Offset: 0x000031B4
		public bool IsValid()
		{
			return InternalEventDefinitionIterator._EASharpBinding_181(this.mSelf);
		}

		// Token: 0x060001FC RID: 508
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_182(void* _ThisPtr);

		// Token: 0x060001FD RID: 509 RVA: 0x000041D0 File Offset: 0x000031D0
		public InternalEventDefinition GetEvent()
		{
			return InternalEventDefinition.CreateInitUnowned(InternalEventDefinitionIterator._EASharpBinding_182(this.mSelf));
		}
	}
}
