using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace GameCore
{
	// Token: 0x0200006D RID: 109
	[ExportOnlyCreate(false)]
	public class XmlParser : ExposedCommonBase
	{
		// Token: 0x0600056A RID: 1386 RVA: 0x000078F0 File Offset: 0x000068F0
		public unsafe static XmlParser CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new XmlParser(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00007913 File Offset: 0x00006913
		public unsafe XmlParser(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x0000791D File Offset: 0x0000691D
		protected internal XmlParser(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00007926 File Offset: 0x00006926
		protected internal unsafe XmlParser(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600056E RID: 1390
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_547();

		// Token: 0x0600056F RID: 1391 RVA: 0x00007930 File Offset: 0x00006930
		public XmlParser() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = XmlParser._EASharpBinding_547();
		}

		// Token: 0x06000570 RID: 1392
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_548(void* _ThisPtr);

		// Token: 0x06000571 RID: 1393 RVA: 0x00007958 File Offset: 0x00006958
		~XmlParser()
		{
			XmlParser._EASharpBinding_548(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000572 RID: 1394
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_549(void* _ThisPtr, void* xmlString);

		// Token: 0x06000573 RID: 1395 RVA: 0x00007994 File Offset: 0x00006994
		public bool Parse(XmlString xmlString)
		{
			return XmlParser._EASharpBinding_549(this.mSelf, object.ReferenceEquals(xmlString, null) ? null : xmlString._GetRaw());
		}

		// Token: 0x06000574 RID: 1396
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_550(void* _ThisPtr, sbyte* xml);

		// Token: 0x06000575 RID: 1397 RVA: 0x000079C4 File Offset: 0x000069C4
		public unsafe bool Parse(string xml)
		{
			int byteCount = Encoding.ASCII.GetByteCount(xml);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(xml, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return XmlParser._EASharpBinding_550(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000576 RID: 1398
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_551(void* _ThisPtr);

		// Token: 0x06000577 RID: 1399 RVA: 0x00007A2C File Offset: 0x00006A2C
		public bool Root()
		{
			return XmlParser._EASharpBinding_551(this.mSelf);
		}

		// Token: 0x06000578 RID: 1400
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_552(void* _ThisPtr);

		// Token: 0x06000579 RID: 1401 RVA: 0x00007A48 File Offset: 0x00006A48
		public bool FirstChild()
		{
			return XmlParser._EASharpBinding_552(this.mSelf);
		}

		// Token: 0x0600057A RID: 1402
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_553(void* _ThisPtr, sbyte* pName);

		// Token: 0x0600057B RID: 1403 RVA: 0x00007A64 File Offset: 0x00006A64
		public unsafe bool FirstChild(string pName)
		{
			int byteCount = Encoding.ASCII.GetByteCount(pName);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(pName, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return XmlParser._EASharpBinding_553(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x0600057C RID: 1404
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_554(void* _ThisPtr);

		// Token: 0x0600057D RID: 1405 RVA: 0x00007ACC File Offset: 0x00006ACC
		public bool NextChild()
		{
			return XmlParser._EASharpBinding_554(this.mSelf);
		}

		// Token: 0x0600057E RID: 1406
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_555(void* _ThisPtr, sbyte* pName);

		// Token: 0x0600057F RID: 1407 RVA: 0x00007AE8 File Offset: 0x00006AE8
		public unsafe bool NextChild(string pName)
		{
			int byteCount = Encoding.ASCII.GetByteCount(pName);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(pName, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return XmlParser._EASharpBinding_555(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000580 RID: 1408
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_556(void* _ThisPtr);

		// Token: 0x06000581 RID: 1409 RVA: 0x00007B50 File Offset: 0x00006B50
		public bool Parent()
		{
			return XmlParser._EASharpBinding_556(this.mSelf);
		}

		// Token: 0x06000582 RID: 1410
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_557(void* _ThisPtr);

		// Token: 0x06000583 RID: 1411 RVA: 0x00007B6C File Offset: 0x00006B6C
		public bool FirstAttribute()
		{
			return XmlParser._EASharpBinding_557(this.mSelf);
		}

		// Token: 0x06000584 RID: 1412
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_558(void* _ThisPtr);

		// Token: 0x06000585 RID: 1413 RVA: 0x00007B88 File Offset: 0x00006B88
		public bool NextAttribute()
		{
			return XmlParser._EASharpBinding_558(this.mSelf);
		}

		// Token: 0x06000586 RID: 1414
		[DllImport("<internal>")]
		private unsafe static extern sbyte* _EASharpBinding_559(void* _ThisPtr);

		// Token: 0x06000587 RID: 1415 RVA: 0x00007BA4 File Offset: 0x00006BA4
		public string GetName()
		{
			return InternalUtil.ConvertFromCString(XmlParser._EASharpBinding_559(this.mSelf));
		}

		// Token: 0x06000588 RID: 1416
		[DllImport("<internal>")]
		private unsafe static extern sbyte* _EASharpBinding_560(void* _ThisPtr);

		// Token: 0x06000589 RID: 1417 RVA: 0x00007BC4 File Offset: 0x00006BC4
		public string GetValue()
		{
			return InternalUtil.ConvertFromCString(XmlParser._EASharpBinding_560(this.mSelf));
		}

		// Token: 0x0600058A RID: 1418
		[DllImport("<internal>")]
		private unsafe static extern sbyte* _EASharpBinding_561(void* _ThisPtr, sbyte* name);

		// Token: 0x0600058B RID: 1419 RVA: 0x00007BE4 File Offset: 0x00006BE4
		public unsafe string GetAttributeValue(string name)
		{
			int byteCount = Encoding.ASCII.GetByteCount(name);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(name, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return InternalUtil.ConvertFromCString(XmlParser._EASharpBinding_561(this.mSelf, (sbyte*)ptr));
			}
		}

		// Token: 0x0600058C RID: 1420
		[DllImport("<internal>")]
		private unsafe static extern sbyte* _EASharpBinding_562(void* _ThisPtr);

		// Token: 0x0600058D RID: 1421 RVA: 0x00007C50 File Offset: 0x00006C50
		public string GetAttributeName()
		{
			return InternalUtil.ConvertFromCString(XmlParser._EASharpBinding_562(this.mSelf));
		}

		// Token: 0x0600058E RID: 1422
		[DllImport("<internal>")]
		private unsafe static extern sbyte* _EASharpBinding_563(void* _ThisPtr);

		// Token: 0x0600058F RID: 1423 RVA: 0x00007C70 File Offset: 0x00006C70
		public string GetAttributeValue()
		{
			return InternalUtil.ConvertFromCString(XmlParser._EASharpBinding_563(this.mSelf));
		}

		// Token: 0x06000590 RID: 1424
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_564(void* _ThisPtr, sbyte* Name);

		// Token: 0x06000591 RID: 1425 RVA: 0x00007C90 File Offset: 0x00006C90
		public unsafe bool AddChild(string Name)
		{
			int byteCount = Encoding.ASCII.GetByteCount(Name);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(Name, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return XmlParser._EASharpBinding_564(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000592 RID: 1426
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_565(void* _ThisPtr, sbyte* Name, sbyte* Value);

		// Token: 0x06000593 RID: 1427 RVA: 0x00007CF8 File Offset: 0x00006CF8
		public unsafe bool AddChild(string Name, string Value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(Name);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(Name, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				int byteCount2 = Encoding.ASCII.GetByteCount(Value);
				byte[] array2 = new byte[byteCount2 + 1];
				Encoding.ASCII.GetBytes(Value, 0, byteCount2, array2, 0);
				array2[byteCount2] = 0;
				fixed (byte* ptr2 = array2)
				{
					return XmlParser._EASharpBinding_565(this.mSelf, (sbyte*)ptr, (sbyte*)ptr2);
				}
			}
		}

		// Token: 0x06000594 RID: 1428
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_566(void* _ThisPtr, sbyte* Name, sbyte* Value);

		// Token: 0x06000595 RID: 1429 RVA: 0x00007DAC File Offset: 0x00006DAC
		public unsafe bool AddAttribute(string Name, string Value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(Name);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(Name, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				int byteCount2 = Encoding.ASCII.GetByteCount(Value);
				byte[] array2 = new byte[byteCount2 + 1];
				Encoding.ASCII.GetBytes(Value, 0, byteCount2, array2, 0);
				array2[byteCount2] = 0;
				fixed (byte* ptr2 = array2)
				{
					return XmlParser._EASharpBinding_566(this.mSelf, (sbyte*)ptr, (sbyte*)ptr2);
				}
			}
		}

		// Token: 0x06000596 RID: 1430
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_567(void* _ThisPtr, sbyte* Value);

		// Token: 0x06000597 RID: 1431 RVA: 0x00007E60 File Offset: 0x00006E60
		public unsafe bool SetValue(string Value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(Value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(Value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return XmlParser._EASharpBinding_567(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000598 RID: 1432
		[DllImport("<internal>")]
		private unsafe static extern sbyte* _EASharpBinding_568(void* _ThisPtr);

		// Token: 0x06000599 RID: 1433 RVA: 0x00007EC8 File Offset: 0x00006EC8
		public string GetXml()
		{
			return InternalUtil.ConvertFromCString(XmlParser._EASharpBinding_568(this.mSelf));
		}
	}
}
