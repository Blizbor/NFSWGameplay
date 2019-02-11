using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace Interop
{
	// Token: 0x02000095 RID: 149
	[ExportOnlyCreate(true)]
	public class CarPartData : ISerializable
	{
		// Token: 0x06000786 RID: 1926 RVA: 0x0000A0F8 File Offset: 0x000090F8
		public new unsafe static CarPartData CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new CarPartData(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x0000A11B File Offset: 0x0000911B
		public unsafe CarPartData(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x0000A125 File Offset: 0x00009125
		protected internal CarPartData(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x0000A12E File Offset: 0x0000912E
		protected internal unsafe CarPartData(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600078A RID: 1930
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_747(void* self);

		// Token: 0x0600078B RID: 1931 RVA: 0x0000A138 File Offset: 0x00009138
		[DisableExceptionHandling]
		~CarPartData()
		{
			CarPartData._EASharpBinding_747(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x0600078C RID: 1932
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_748();

		// Token: 0x0600078D RID: 1933 RVA: 0x0000A174 File Offset: 0x00009174
		public CarPartData() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = CarPartData._EASharpBinding_748();
		}

		// Token: 0x0600078E RID: 1934
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_749(void* _ThisPtr);

		// Token: 0x0600078F RID: 1935 RVA: 0x0000A19B File Offset: 0x0000919B
		public void Reset()
		{
			CarPartData._EASharpBinding_749(this.mSelf);
		}

		// Token: 0x06000790 RID: 1936
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_750(void* _ThisPtr, sbyte* value);

		// Token: 0x06000791 RID: 1937 RVA: 0x0000A1A8 File Offset: 0x000091A8
		public unsafe void SetIcon(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				CarPartData._EASharpBinding_750(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000792 RID: 1938
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_751(void* self, int val);

		// Token: 0x06000793 RID: 1939
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_752(void* self);

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000794 RID: 1940 RVA: 0x0000A205 File Offset: 0x00009205
		// (set) Token: 0x06000795 RID: 1941 RVA: 0x0000A212 File Offset: 0x00009212
		public int Id
		{
			get
			{
				return CarPartData._EASharpBinding_752(this.mSelf);
			}
			set
			{
				CarPartData._EASharpBinding_751(this.mSelf, value);
			}
		}
	}
}
