using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x0200009A RID: 154
	[ExportOnlyCreate(true)]
	public class FECarDataList : ISerializable
	{
		// Token: 0x0600080C RID: 2060 RVA: 0x0000AB4C File Offset: 0x00009B4C
		public new unsafe static FECarDataList CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new FECarDataList(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x0000AB6F File Offset: 0x00009B6F
		public unsafe FECarDataList(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x0000AB79 File Offset: 0x00009B79
		protected internal FECarDataList(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x0000AB82 File Offset: 0x00009B82
		protected internal unsafe FECarDataList(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000810 RID: 2064
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_804();

		// Token: 0x06000811 RID: 2065 RVA: 0x0000AB8C File Offset: 0x00009B8C
		public FECarDataList() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = FECarDataList._EASharpBinding_804();
		}

		// Token: 0x06000812 RID: 2066
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_805(void* _ThisPtr);

		// Token: 0x06000813 RID: 2067 RVA: 0x0000ABB4 File Offset: 0x00009BB4
		~FECarDataList()
		{
			FECarDataList._EASharpBinding_805(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000814 RID: 2068
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_806(void* _ThisPtr, void* value);

		// Token: 0x06000815 RID: 2069 RVA: 0x0000ABF0 File Offset: 0x00009BF0
		public void AddCars(FECarData value)
		{
			FECarDataList._EASharpBinding_806(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
		}
	}
}
