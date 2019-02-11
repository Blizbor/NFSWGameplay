using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x020000C5 RID: 197
	[ExportOnlyCreate(true)]
	public class FilterList : ISerializable
	{
		// Token: 0x06000BBE RID: 3006 RVA: 0x0000EA94 File Offset: 0x0000DA94
		public new unsafe static FilterList CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new FilterList(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x0000EAB7 File Offset: 0x0000DAB7
		public unsafe FilterList(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x0000EAC1 File Offset: 0x0000DAC1
		protected internal FilterList(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x0000EACA File Offset: 0x0000DACA
		protected internal unsafe FilterList(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000BC2 RID: 3010
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1192();

		// Token: 0x06000BC3 RID: 3011 RVA: 0x0000EAD4 File Offset: 0x0000DAD4
		public FilterList() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = FilterList._EASharpBinding_1192();
		}

		// Token: 0x06000BC4 RID: 3012
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1193(void* _ThisPtr);

		// Token: 0x06000BC5 RID: 3013 RVA: 0x0000EAFC File Offset: 0x0000DAFC
		~FilterList()
		{
			FilterList._EASharpBinding_1193(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000BC6 RID: 3014
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1194(void* _ThisPtr, void* value);

		// Token: 0x06000BC7 RID: 3015 RVA: 0x0000EB38 File Offset: 0x0000DB38
		public void AddItems(Filter value)
		{
			FilterList._EASharpBinding_1194(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
		}

		// Token: 0x06000BC8 RID: 3016
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1195(void* self, int val);

		// Token: 0x06000BC9 RID: 3017
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1196(void* self);

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000BCA RID: 3018 RVA: 0x0000EB58 File Offset: 0x0000DB58
		// (set) Token: 0x06000BCB RID: 3019 RVA: 0x0000EB65 File Offset: 0x0000DB65
		public int DefaultIndex
		{
			get
			{
				return FilterList._EASharpBinding_1196(this.mSelf);
			}
			set
			{
				FilterList._EASharpBinding_1195(this.mSelf, value);
			}
		}
	}
}
