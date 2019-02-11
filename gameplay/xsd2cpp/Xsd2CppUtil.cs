using System;
using GameCore;

namespace xsd2cpp
{
	// Token: 0x0200028F RID: 655
	public static class Xsd2CppUtil
	{
		// Token: 0x060019D9 RID: 6617 RVA: 0x0002F5AE File Offset: 0x0002E5AE
		public static bool ReadInt(XmlParser doc, out int value)
		{
			return int.TryParse(doc.GetValue(), out value);
		}

		// Token: 0x060019DA RID: 6618 RVA: 0x0002F5BC File Offset: 0x0002E5BC
		public static bool ReadUInt(XmlParser doc, out uint value)
		{
			return uint.TryParse(doc.GetValue(), out value);
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x0002F5CA File Offset: 0x0002E5CA
		public static bool ReadShort(XmlParser doc, out short value)
		{
			return short.TryParse(doc.GetValue(), out value);
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x0002F5D8 File Offset: 0x0002E5D8
		public static bool ReadLong(XmlParser doc, out long value)
		{
			return long.TryParse(doc.GetValue(), out value);
		}

		// Token: 0x060019DD RID: 6621 RVA: 0x0002F5E6 File Offset: 0x0002E5E6
		public static bool ReadString(XmlParser doc, out string value)
		{
			value = doc.GetValue();
			return value != null;
		}

		// Token: 0x060019DE RID: 6622 RVA: 0x0002F5F8 File Offset: 0x0002E5F8
		public static bool ReadFloat(XmlParser doc, out float value)
		{
			return float.TryParse(doc.GetValue(), out value);
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x0002F606 File Offset: 0x0002E606
		public static bool ReadBoolean(XmlParser doc, out bool value)
		{
			return bool.TryParse(doc.GetValue().ToLower(), out value);
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x0002F619 File Offset: 0x0002E619
		public static bool ReadDouble(XmlParser doc, out double value)
		{
			return double.TryParse(doc.GetValue(), out value);
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x0002F627 File Offset: 0x0002E627
		public static bool ReadDateTime(XmlParser doc, out DateTime value)
		{
			value = DateTime.MinValue;
			return true;
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x0002F635 File Offset: 0x0002E635
		public static bool ReadDecimal(XmlParser doc, out decimal value)
		{
			return decimal.TryParse(doc.GetValue(), out value);
		}

		// Token: 0x060019E3 RID: 6627 RVA: 0x0002F644 File Offset: 0x0002E644
		public static bool IsCommandOfType(string Type, string pCommand)
		{
			int length = Type.Length;
			for (int i = 0; i < length; i++)
			{
				if (pCommand[i + 1] != Type[i])
				{
					return false;
				}
			}
			return pCommand[length + 1] == ' ' || pCommand[length + 1] == '>' || pCommand[length + 1] == '/';
		}

		// Token: 0x060019E4 RID: 6628 RVA: 0x0002F6A4 File Offset: 0x0002E6A4
		public static string GetPrefix(XmlParser doc, string nameSpace)
		{
			string result = "";
			if (doc.FirstAttribute())
			{
				while (!(doc.GetAttributeValue() == nameSpace))
				{
					if (!doc.NextAttribute())
					{
						return result;
					}
				}
				if (doc.GetAttributeName().Length > 6)
				{
					result = doc.GetAttributeName().Substring(6);
				}
				return result;
			}
			return result;
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x0002F6F3 File Offset: 0x0002E6F3
		public static bool HasInstance(XmlParser doc)
		{
			if (doc.FirstAttribute())
			{
				while (!(doc.GetAttributeName() == "i:nil"))
				{
					if (!doc.NextAttribute())
					{
						return true;
					}
				}
				return false;
			}
			return true;
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x0002F71A File Offset: 0x0002E71A
		public static bool WriteInt(XmlParser doc, int value)
		{
			return Xsd2CppUtil.WriteString(doc, value.ToString());
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x0002F729 File Offset: 0x0002E729
		public static bool WriteUInt(XmlParser doc, uint value)
		{
			return Xsd2CppUtil.WriteString(doc, value.ToString());
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x0002F738 File Offset: 0x0002E738
		public static bool WriteShort(XmlParser doc, short value)
		{
			return Xsd2CppUtil.WriteString(doc, value.ToString());
		}

		// Token: 0x060019E9 RID: 6633 RVA: 0x0002F747 File Offset: 0x0002E747
		public static bool WriteLong(XmlParser doc, long value)
		{
			return Xsd2CppUtil.WriteString(doc, value.ToString());
		}

		// Token: 0x060019EA RID: 6634 RVA: 0x0002F756 File Offset: 0x0002E756
		public static bool WriteString(XmlParser doc, string value)
		{
			return doc.SetValue(value);
		}

		// Token: 0x060019EB RID: 6635 RVA: 0x0002F75F File Offset: 0x0002E75F
		public static bool WriteFloat(XmlParser doc, float value)
		{
			return Xsd2CppUtil.WriteString(doc, value.ToString());
		}

		// Token: 0x060019EC RID: 6636 RVA: 0x0002F76E File Offset: 0x0002E76E
		public static bool WriteBoolean(XmlParser doc, bool value)
		{
			return Xsd2CppUtil.WriteString(doc, value ? "true" : "false");
		}

		// Token: 0x060019ED RID: 6637 RVA: 0x0002F785 File Offset: 0x0002E785
		public static bool WriteDouble(XmlParser doc, double value)
		{
			return Xsd2CppUtil.WriteString(doc, value.ToString());
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x0002F794 File Offset: 0x0002E794
		public static bool WriteDateTime(XmlParser doc, DateTime value)
		{
			return Xsd2CppUtil.WriteString(doc, "1980-01-01T00:00:00+00:00");
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x0002F7A1 File Offset: 0x0002E7A1
		public static bool WriteDecimal(XmlParser doc, decimal value)
		{
			return Xsd2CppUtil.WriteString(doc, "0.00");
		}
	}
}
