using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x02000077 RID: 119
	[ExportOnlyCreate(false)]
	public class EventGridPacket : ExposedCommonBase
	{
		// Token: 0x060005FC RID: 1532 RVA: 0x00008598 File Offset: 0x00007598
		public unsafe static EventGridPacket CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new EventGridPacket(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x000085BB File Offset: 0x000075BB
		public unsafe EventGridPacket(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x000085C5 File Offset: 0x000075C5
		protected internal EventGridPacket(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x000085CE File Offset: 0x000075CE
		protected internal unsafe EventGridPacket(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000600 RID: 1536
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_602(void* self);

		// Token: 0x06000601 RID: 1537 RVA: 0x000085D8 File Offset: 0x000075D8
		[DisableExceptionHandling]
		~EventGridPacket()
		{
			EventGridPacket._EASharpBinding_602(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000602 RID: 1538
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_603();

		// Token: 0x06000603 RID: 1539 RVA: 0x00008614 File Offset: 0x00007614
		public EventGridPacket() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = EventGridPacket._EASharpBinding_603();
		}

		// Token: 0x06000604 RID: 1540
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_604(void* _ThisPtr, long personaId, int gridIndex);

		// Token: 0x06000605 RID: 1541 RVA: 0x0000863B File Offset: 0x0000763B
		public void AddOpponent(long personaId, int gridIndex)
		{
			EventGridPacket._EASharpBinding_604(this.mSelf, personaId, gridIndex);
		}

		// Token: 0x06000606 RID: 1542
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_605(void* _ThisPtr, long personaId, int gridIndex);

		// Token: 0x06000607 RID: 1543 RVA: 0x0000864A File Offset: 0x0000764A
		public void SetGridIndex(long personaId, int gridIndex)
		{
			EventGridPacket._EASharpBinding_605(this.mSelf, personaId, gridIndex);
		}

		// Token: 0x06000608 RID: 1544
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_606(void* _ThisPtr, long personaId);

		// Token: 0x06000609 RID: 1545 RVA: 0x0000865C File Offset: 0x0000765C
		public int GetGridIndex(long personaId)
		{
			return EventGridPacket._EASharpBinding_606(this.mSelf, personaId);
		}

		// Token: 0x0600060A RID: 1546
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_607(void* _ThisPtr);

		// Token: 0x0600060B RID: 1547 RVA: 0x00008678 File Offset: 0x00007678
		public int GetOpponentCount()
		{
			return EventGridPacket._EASharpBinding_607(this.mSelf);
		}

		// Token: 0x0600060C RID: 1548
		[DllImport("<internal>")]
		private unsafe static extern long _EASharpBinding_608(void* _ThisPtr, int index);

		// Token: 0x0600060D RID: 1549 RVA: 0x00008694 File Offset: 0x00007694
		public long GetPersonaId(int index)
		{
			return EventGridPacket._EASharpBinding_608(this.mSelf, index);
		}

		// Token: 0x0600060E RID: 1550
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_609(void* _ThisPtr, int index);

		// Token: 0x0600060F RID: 1551 RVA: 0x000086B0 File Offset: 0x000076B0
		public int GetOpponentGridIndex(int index)
		{
			return EventGridPacket._EASharpBinding_609(this.mSelf, index);
		}
	}
}
