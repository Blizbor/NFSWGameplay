using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace GameCore.Pursuit
{
	// Token: 0x02000083 RID: 131
	[ExportOnlyCreate(true)]
	public class CopCountRecord : ExposedCommonBase
	{
		// Token: 0x06000688 RID: 1672 RVA: 0x00008EC0 File Offset: 0x00007EC0
		public unsafe static CopCountRecord CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new CopCountRecord(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x00008EE3 File Offset: 0x00007EE3
		public unsafe CopCountRecord(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00008EED File Offset: 0x00007EED
		protected internal CopCountRecord(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00008EF6 File Offset: 0x00007EF6
		protected internal unsafe CopCountRecord(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600068C RID: 1676
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_640(void* self);

		// Token: 0x0600068D RID: 1677 RVA: 0x00008F00 File Offset: 0x00007F00
		[DisableExceptionHandling]
		~CopCountRecord()
		{
			CopCountRecord._EASharpBinding_640(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x0600068E RID: 1678
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_641(void* self, sbyte* val);

		// Token: 0x0600068F RID: 1679
		[DllImport("<internal>")]
		private unsafe static extern sbyte* _EASharpBinding_642(void* self);

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000690 RID: 1680 RVA: 0x00008F3C File Offset: 0x00007F3C
		// (set) Token: 0x06000691 RID: 1681 RVA: 0x00008F50 File Offset: 0x00007F50
		public unsafe string CopType
		{
			get
			{
				return InternalUtil.ConvertFromCString(CopCountRecord._EASharpBinding_642(this.mSelf));
			}
			set
			{
				int byteCount = Encoding.ASCII.GetByteCount(value);
				byte[] array = new byte[byteCount + 1];
				Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
				array[byteCount] = 0;
				fixed (byte* ptr = array)
				{
					CopCountRecord._EASharpBinding_641(this.mSelf, (sbyte*)ptr);
				}
			}
		}

		// Token: 0x06000692 RID: 1682
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_643(void* self, uint val);

		// Token: 0x06000693 RID: 1683
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_644(void* self);

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x00008FAD File Offset: 0x00007FAD
		// (set) Token: 0x06000695 RID: 1685 RVA: 0x00008FBA File Offset: 0x00007FBA
		public uint CopTypeHash32
		{
			get
			{
				return CopCountRecord._EASharpBinding_644(this.mSelf);
			}
			set
			{
				CopCountRecord._EASharpBinding_643(this.mSelf, value);
			}
		}

		// Token: 0x06000696 RID: 1686
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_645(void* self, uint val);

		// Token: 0x06000697 RID: 1687
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_646(void* self);

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000698 RID: 1688 RVA: 0x00008FC8 File Offset: 0x00007FC8
		// (set) Token: 0x06000699 RID: 1689 RVA: 0x00008FD5 File Offset: 0x00007FD5
		public uint Count
		{
			get
			{
				return CopCountRecord._EASharpBinding_646(this.mSelf);
			}
			set
			{
				CopCountRecord._EASharpBinding_645(this.mSelf, value);
			}
		}

		// Token: 0x0600069A RID: 1690
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_647(void* self, uint val);

		// Token: 0x0600069B RID: 1691
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_648(void* self);

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x00008FE3 File Offset: 0x00007FE3
		// (set) Token: 0x0600069D RID: 1693 RVA: 0x00008FF0 File Offset: 0x00007FF0
		public uint Chance
		{
			get
			{
				return CopCountRecord._EASharpBinding_648(this.mSelf);
			}
			set
			{
				CopCountRecord._EASharpBinding_647(this.mSelf, value);
			}
		}
	}
}
