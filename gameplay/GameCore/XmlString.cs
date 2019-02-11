using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace GameCore
{
	// Token: 0x0200006E RID: 110
	[ExportOnlyCreate(false)]
	public class XmlString : ExposedCommonBase
	{
		// Token: 0x0600059A RID: 1434 RVA: 0x00007EE8 File Offset: 0x00006EE8
		public unsafe static XmlString CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new XmlString(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00007F0B File Offset: 0x00006F0B
		public unsafe XmlString(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00007F15 File Offset: 0x00006F15
		protected internal XmlString(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00007F1E File Offset: 0x00006F1E
		protected internal unsafe XmlString(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600059E RID: 1438
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_569(void* self);

		// Token: 0x0600059F RID: 1439 RVA: 0x00007F28 File Offset: 0x00006F28
		[DisableExceptionHandling]
		~XmlString()
		{
			XmlString._EASharpBinding_569(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060005A0 RID: 1440
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_570(sbyte* string_0);

		// Token: 0x060005A1 RID: 1441 RVA: 0x00007F64 File Offset: 0x00006F64
		public unsafe XmlString(string string_0) : base(default(ExposeTag_NoInitOwned))
		{
			int byteCount = Encoding.ASCII.GetByteCount(string_0);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(string_0, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				this.mSelf = XmlString._EASharpBinding_570((sbyte*)ptr);
			}
		}

		// Token: 0x060005A2 RID: 1442
		[DllImport("<internal>")]
		private unsafe static extern sbyte* _EASharpBinding_571(void* _ThisPtr);

		// Token: 0x060005A3 RID: 1443 RVA: 0x00007FD4 File Offset: 0x00006FD4
		public string GetString()
		{
			return InternalUtil.ConvertFromCString(XmlString._EASharpBinding_571(this.mSelf));
		}
	}
}
