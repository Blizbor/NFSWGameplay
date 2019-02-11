using System;
using System.Collections.Generic;
using GameCore;
using Victory;
using Victory.Data.Objects.Customization;
using Victory.DataLayer.Serialization;
using Victory.DataLayer.Serialization.Event;
using Victory.DataLayer.Serialization.Gift;
using Victory.DataLayer.Serialization.LoginAnnouncement;
using Victory.DataLayer.Serialization.PowerUp;
using Victory.DataLayer.Serialization.Social;
using Victory.DataObjects.Objects.LoginAnnouncement;
using Victory.Service;
using Victory.Service.Objects;
using Victory.Service.Objects.Event;
using Victory.TransferObjects.DriverPersona;
using Victory.TransferObjects.News;
using Victory.TransferObjects.Session;
using Victory.TransferObjects.User;
using Victory.Voip;

namespace xsd2cpp
{
	// Token: 0x02000290 RID: 656
	public static class XSD2CPP
	{
		// Token: 0x060019F0 RID: 6640 RVA: 0x0002F7B0 File Offset: 0x0002E7B0
		public static bool ReadArrayOfstringClass(XmlParser doc, List<string> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.microsoft.com/2003/10/Serialization/Arrays");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfstring(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x0002F7F8 File Offset: 0x0002E7F8
		public static bool ReadArrayOfintClass(XmlParser doc, List<int> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.microsoft.com/2003/10/Serialization/Arrays");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfint(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x0002F840 File Offset: 0x0002E840
		public static bool ReadArrayOflongClass(XmlParser doc, List<long> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.microsoft.com/2003/10/Serialization/Arrays");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOflong(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x060019F3 RID: 6643 RVA: 0x0002F888 File Offset: 0x0002E888
		private static bool ReadArrayOfstring(XmlParser doc, List<string> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "string";
			}
			string item;
			while (Xsd2CppUtil.ReadString(doc, out item))
			{
				data.Add(item);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060019F4 RID: 6644 RVA: 0x0002F8D4 File Offset: 0x0002E8D4
		private static bool ReadArrayOfint(XmlParser doc, List<int> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "int";
			}
			int item;
			while (Xsd2CppUtil.ReadInt(doc, out item))
			{
				data.Add(item);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060019F5 RID: 6645 RVA: 0x0002F920 File Offset: 0x0002E920
		private static bool ReadArrayOflong(XmlParser doc, List<long> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "long";
			}
			long item;
			while (Xsd2CppUtil.ReadLong(doc, out item))
			{
				data.Add(item);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060019F6 RID: 6646 RVA: 0x0002F96C File Offset: 0x0002E96C
		public static bool Reader(XmlString xmlString, out List<string> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfstring"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<string>();
						if (XSD2CPP.ReadArrayOfstringClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x060019F7 RID: 6647 RVA: 0x0002F9C8 File Offset: 0x0002E9C8
		public static bool ReadArrayOfstring(XmlString xmlString, out List<string> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x0002F9D4 File Offset: 0x0002E9D4
		public static bool Reader(XmlString xmlString, out List<int> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfint"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<int>();
						if (XSD2CPP.ReadArrayOfintClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x0002FA30 File Offset: 0x0002EA30
		public static bool ReadArrayOfint(XmlString xmlString, out List<int> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x0002FA3C File Offset: 0x0002EA3C
		public static bool Reader(XmlString xmlString, out List<long> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOflong"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<long>();
						if (XSD2CPP.ReadArrayOflongClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x060019FB RID: 6651 RVA: 0x0002FA98 File Offset: 0x0002EA98
		public static bool ReadArrayOflong(XmlString xmlString, out List<long> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x060019FC RID: 6652 RVA: 0x0002FAA4 File Offset: 0x0002EAA4
		private static void WriteArrayOfstring(XmlParser doc, List<string> data)
		{
			doc.AddAttribute("xmlns:array", "http://schemas.microsoft.com/2003/10/Serialization/Arrays");
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("array:string");
				Xsd2CppUtil.WriteString(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x060019FD RID: 6653 RVA: 0x0002FAF4 File Offset: 0x0002EAF4
		private static void WriteArrayOfint(XmlParser doc, List<int> data)
		{
			doc.AddAttribute("xmlns:array", "http://schemas.microsoft.com/2003/10/Serialization/Arrays");
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("array:int");
				Xsd2CppUtil.WriteInt(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x0002FB44 File Offset: 0x0002EB44
		private static void WriteArrayOflong(XmlParser doc, List<long> data)
		{
			doc.AddAttribute("xmlns:array", "http://schemas.microsoft.com/2003/10/Serialization/Arrays");
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("array:long");
				Xsd2CppUtil.WriteLong(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x0002FB94 File Offset: 0x0002EB94
		public static bool WriterXML(List<string> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfstring");
			xmlParser.AddAttribute("xmlns", "http://schemas.microsoft.com/2003/10/Serialization/Arrays");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfstring(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x0002FBE5 File Offset: 0x0002EBE5
		public static bool Writer(List<string> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x0002FBEE File Offset: 0x0002EBEE
		public static bool WriteArrayOfstring(List<string> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001A02 RID: 6658 RVA: 0x0002FBF8 File Offset: 0x0002EBF8
		public static bool WriterXML(List<int> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfint");
			xmlParser.AddAttribute("xmlns", "http://schemas.microsoft.com/2003/10/Serialization/Arrays");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfint(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x0002FC49 File Offset: 0x0002EC49
		public static bool Writer(List<int> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001A04 RID: 6660 RVA: 0x0002FC52 File Offset: 0x0002EC52
		public static bool WriteArrayOfint(List<int> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x0002FC5C File Offset: 0x0002EC5C
		public static bool WriterXML(List<long> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOflong");
			xmlParser.AddAttribute("xmlns", "http://schemas.microsoft.com/2003/10/Serialization/Arrays");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOflong(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x0002FCAD File Offset: 0x0002ECAD
		public static bool Writer(List<long> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x0002FCB6 File Offset: 0x0002ECB6
		public static bool WriteArrayOflong(List<long> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x0002FCBF File Offset: 0x0002ECBF
		private static bool ReadSkillModEffectTypeAttribute(string pValue, out SkillModEffectType data)
		{
			return SkillModEffectTypeConverter.Parse(pValue, out data);
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x0002FCC8 File Offset: 0x0002ECC8
		private static bool ReadSkillModEffectType(XmlParser doc, out SkillModEffectType data)
		{
			string value = doc.GetValue();
			return SkillModEffectTypeConverter.Parse(value, out data);
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x0002FCE3 File Offset: 0x0002ECE3
		private static bool ReadSkillModEffectAmountConversionAttribute(string pValue, out SkillModEffectAmountConversion data)
		{
			return SkillModEffectAmountConversionConverter.Parse(pValue, out data);
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x0002FCEC File Offset: 0x0002ECEC
		private static bool ReadSkillModEffectAmountConversion(XmlParser doc, out SkillModEffectAmountConversion data)
		{
			string value = doc.GetValue();
			return SkillModEffectAmountConversionConverter.Parse(value, out data);
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x0002FD07 File Offset: 0x0002ED07
		private static void WriteSkillModEffectType(XmlParser doc, SkillModEffectType data)
		{
			Xsd2CppUtil.WriteString(doc, data.ToString());
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x0002FD1B File Offset: 0x0002ED1B
		private static void WriteSkillModEffectAmountConversion(XmlParser doc, SkillModEffectAmountConversion data)
		{
			Xsd2CppUtil.WriteString(doc, data.ToString());
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x0002FD30 File Offset: 0x0002ED30
		public static bool ReadEventTimedOutClass(XmlParser doc, EventTimedOut data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadEventTimedOut(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001A0F RID: 6671 RVA: 0x0002FD78 File Offset: 0x0002ED78
		public static bool ReadRewardClass(XmlParser doc, Reward data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadReward(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001A10 RID: 6672 RVA: 0x0002FDC0 File Offset: 0x0002EDC0
		public static bool ReadLuckyDrawInfoClass(XmlParser doc, LuckyDrawInfo data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadLuckyDrawInfo(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x0002FE08 File Offset: 0x0002EE08
		public static bool ReadAccoladesClass(XmlParser doc, Accolades data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadAccolades(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x0002FE50 File Offset: 0x0002EE50
		public static bool ReadEventResultClass(XmlParser doc, EventResult data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadEventResult(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x0002FE98 File Offset: 0x0002EE98
		public static bool ReadLuckyDrawBoxClass(XmlParser doc, LuckyDrawBox data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadLuckyDrawBox(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x0002FEE0 File Offset: 0x0002EEE0
		public static bool ReadArrayOfLuckyDrawBoxClass(XmlParser doc, List<LuckyDrawBox> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfLuckyDrawBox(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x0002FF28 File Offset: 0x0002EF28
		public static bool ReadLuckyDrawItemClass(XmlParser doc, LuckyDrawItem data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadLuckyDrawItem(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x0002FF70 File Offset: 0x0002EF70
		public static bool ReadArrayOfLuckyDrawItemClass(XmlParser doc, List<LuckyDrawItem> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfLuckyDrawItem(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x0002FFB8 File Offset: 0x0002EFB8
		public static bool ReadRewardPartClass(XmlParser doc, RewardPart data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadRewardPart(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x00030000 File Offset: 0x0002F000
		public static bool ReadArrayOfRewardPartClass(XmlParser doc, List<RewardPart> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfRewardPart(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x00030048 File Offset: 0x0002F048
		public static bool ReadRouteEventResultClass(XmlParser doc, RouteEventResult data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadRouteEventResult(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x00030090 File Offset: 0x0002F090
		public static bool ReadEntrantResultClass(XmlParser doc, EntrantResult data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadEntrantResult(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x000300D8 File Offset: 0x0002F0D8
		public static bool ReadRouteEntrantResultClass(XmlParser doc, RouteEntrantResult data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadRouteEntrantResult(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001A1C RID: 6684 RVA: 0x00030120 File Offset: 0x0002F120
		public static bool ReadArrayOfRouteEntrantResultClass(XmlParser doc, List<RouteEntrantResult> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfRouteEntrantResult(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x00030168 File Offset: 0x0002F168
		public static bool ReadDragEventResultClass(XmlParser doc, DragEventResult data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadDragEventResult(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001A1E RID: 6686 RVA: 0x000301B0 File Offset: 0x0002F1B0
		public static bool ReadDragEntrantResultClass(XmlParser doc, DragEntrantResult data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadDragEntrantResult(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x000301F8 File Offset: 0x0002F1F8
		public static bool ReadArrayOfDragEntrantResultClass(XmlParser doc, List<DragEntrantResult> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfDragEntrantResult(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001A20 RID: 6688 RVA: 0x00030240 File Offset: 0x0002F240
		public static bool ReadTeamEscapeEventResultClass(XmlParser doc, TeamEscapeEventResult data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadTeamEscapeEventResult(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x00030288 File Offset: 0x0002F288
		public static bool ReadTeamEscapeEntrantResultClass(XmlParser doc, TeamEscapeEntrantResult data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadTeamEscapeEntrantResult(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x000302D0 File Offset: 0x0002F2D0
		public static bool ReadArrayOfTeamEscapeEntrantResultClass(XmlParser doc, List<TeamEscapeEntrantResult> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfTeamEscapeEntrantResult(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x00030318 File Offset: 0x0002F318
		public static bool ReadPursuitEventResultClass(XmlParser doc, PursuitEventResult data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadPursuitEventResult(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x00030360 File Offset: 0x0002F360
		public static bool ReadEventTimingOutClass(XmlParser doc, EventTimingOut data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadEventTimingOut(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x000303A8 File Offset: 0x0002F3A8
		public static bool ReadTreasureHuntEventSessionClass(XmlParser doc, TreasureHuntEventSession data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadTreasureHuntEventSession(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x000303F0 File Offset: 0x0002F3F0
		public static bool ReadEventsPacketClass(XmlParser doc, EventsPacket data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadEventsPacket(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x00030438 File Offset: 0x0002F438
		public static bool ReadEventDefinitionClass(XmlParser doc, Victory.DataLayer.Serialization.Event.EventDefinition data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadEventDefinition(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x00030480 File Offset: 0x0002F480
		public static bool ReadArrayOfEventDefinitionClass(XmlParser doc, List<Victory.DataLayer.Serialization.Event.EventDefinition> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfEventDefinition(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x000304C8 File Offset: 0x0002F4C8
		private static bool ReadFinishReasonAttribute(string pValue, out FinishReason data)
		{
			return FinishReasonConverter.Parse(pValue, out data);
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x000304D4 File Offset: 0x0002F4D4
		private static bool ReadFinishReason(XmlParser doc, out FinishReason data)
		{
			string value = doc.GetValue();
			return FinishReasonConverter.Parse(value, out data);
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x000304EF File Offset: 0x0002F4EF
		private static bool ReadenumRewardCategoryAttribute(string pValue, out enumRewardCategory data)
		{
			return enumRewardCategoryConverter.Parse(pValue, out data);
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x000304F8 File Offset: 0x0002F4F8
		private static bool ReadenumRewardCategory(XmlParser doc, out enumRewardCategory data)
		{
			string value = doc.GetValue();
			return enumRewardCategoryConverter.Parse(value, out data);
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x00030513 File Offset: 0x0002F513
		private static bool ReadenumRewardTypeAttribute(string pValue, out enumRewardType data)
		{
			return enumRewardTypeConverter.Parse(pValue, out data);
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x0003051C File Offset: 0x0002F51C
		private static bool ReadenumRewardType(XmlParser doc, out enumRewardType data)
		{
			string value = doc.GetValue();
			return enumRewardTypeConverter.Parse(value, out data);
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x00030537 File Offset: 0x0002F537
		private static bool ReadExitPathAttribute(string pValue, out ExitPath data)
		{
			return ExitPathConverter.Parse(pValue, out data);
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x00030540 File Offset: 0x0002F540
		private static bool ReadExitPath(XmlParser doc, out ExitPath data)
		{
			string value = doc.GetValue();
			return ExitPathConverter.Parse(value, out data);
		}

		// Token: 0x06001A31 RID: 6705 RVA: 0x0003055C File Offset: 0x0002F55C
		private static bool ReadEventTimedOut(XmlParser doc, EventTimedOut data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "EventSessionId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.EventSessionId);
			}
			return true;
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x000305A0 File Offset: 0x0002F5A0
		private static bool ReadReward(XmlParser doc, Reward data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "Rep";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Rep);
			}
			doc.Parent();
			pName = prefix + "Tokens";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Tokens);
			}
			return true;
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x0003060C File Offset: 0x0002F60C
		private static bool ReadLuckyDrawInfo(XmlParser doc, LuckyDrawInfo data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "Boxes";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.Boxes = new List<LuckyDrawBox>();
				XSD2CPP.ReadArrayOfLuckyDrawBoxClass(doc, data.Boxes);
			}
			doc.Parent();
			pName = prefix + "CardDeck";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.CardDeck);
			}
			doc.Parent();
			pName = prefix + "CurrentStreak";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.CurrentStreak);
			}
			doc.Parent();
			pName = prefix + "IsStreakBroken";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.IsStreakBroken);
			}
			doc.Parent();
			pName = prefix + "Items";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.Items = new List<LuckyDrawItem>();
				XSD2CPP.ReadArrayOfLuckyDrawItemClass(doc, data.Items);
			}
			doc.Parent();
			pName = prefix + "NumBoxAnimations";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.NumBoxAnimations);
			}
			doc.Parent();
			pName = prefix + "NumCards";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.NumCards);
			}
			return true;
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x0003076C File Offset: 0x0002F76C
		private static bool ReadAccolades(XmlParser doc, Accolades data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "FinalRewards";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.FinalRewards = new Reward();
				XSD2CPP.ReadRewardClass(doc, data.FinalRewards);
			}
			doc.Parent();
			pName = prefix + "HasLeveledUp";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.HasLeveledUp);
			}
			doc.Parent();
			pName = prefix + "LuckyDrawInfo";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.LuckyDrawInfo = new LuckyDrawInfo();
				XSD2CPP.ReadLuckyDrawInfoClass(doc, data.LuckyDrawInfo);
			}
			doc.Parent();
			pName = prefix + "OriginalRewards";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.OriginalRewards = new Reward();
				XSD2CPP.ReadRewardClass(doc, data.OriginalRewards);
			}
			doc.Parent();
			pName = prefix + "RewardInfo";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.RewardInfo = new List<RewardPart>();
				XSD2CPP.ReadArrayOfRewardPartClass(doc, data.RewardInfo);
			}
			return true;
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x000308A0 File Offset: 0x0002F8A0
		private static bool ReadEventResult(XmlParser doc, EventResult data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "Accolades";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.Accolades = new Accolades();
				XSD2CPP.ReadAccoladesClass(doc, data.Accolades);
			}
			doc.Parent();
			pName = prefix + "Durability";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Durability);
			}
			doc.Parent();
			pName = prefix + "EventId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.EventId);
			}
			doc.Parent();
			pName = prefix + "EventSessionId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.EventSessionId);
			}
			doc.Parent();
			pName = prefix + "ExitPath";
			if (doc.FirstChild(pName))
			{
				XSD2CPP.ReadExitPath(doc, out data.ExitPath);
			}
			doc.Parent();
			pName = prefix + "InviteLifetimeInMilliseconds";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.InviteLifetimeInMilliseconds);
			}
			doc.Parent();
			pName = prefix + "LobbyInviteId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.LobbyInviteId);
			}
			doc.Parent();
			pName = prefix + "PersonaId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.PersonaId);
			}
			return true;
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x00030A14 File Offset: 0x0002FA14
		private static bool ReadLuckyDrawBox(XmlParser doc, LuckyDrawBox data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "IsValid";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.IsValid);
			}
			doc.Parent();
			pName = prefix + "LocalizationString";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.LocalizationString);
			}
			doc.Parent();
			pName = prefix + "LuckyDrawSetCategoryId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.LuckyDrawSetCategoryId);
			}
			return true;
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x00030AA8 File Offset: 0x0002FAA8
		private static bool ReadArrayOfLuckyDrawBox(XmlParser doc, List<LuckyDrawBox> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "LuckyDrawBox";
			}
			for (;;)
			{
				LuckyDrawBox luckyDrawBox = new LuckyDrawBox();
				if (!XSD2CPP.ReadLuckyDrawBoxClass(doc, luckyDrawBox))
				{
					break;
				}
				data.Add(luckyDrawBox);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x00030AF8 File Offset: 0x0002FAF8
		private static bool ReadLuckyDrawItem(XmlParser doc, LuckyDrawItem data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "Description";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Description);
			}
			doc.Parent();
			pName = prefix + "Hash";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Hash);
			}
			doc.Parent();
			pName = prefix + "Icon";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Icon);
			}
			doc.Parent();
			pName = prefix + "RemainingUseCount";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.RemainingUseCount);
			}
			doc.Parent();
			pName = prefix + "ResellPrice";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadFloat(doc, out data.ResellPrice);
			}
			doc.Parent();
			pName = prefix + "VirtualItem";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.VirtualItem);
			}
			doc.Parent();
			pName = prefix + "VirtualItemType";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.VirtualItemType);
			}
			doc.Parent();
			pName = prefix + "WasSold";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.WasSold);
			}
			return true;
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x00030C5C File Offset: 0x0002FC5C
		private static bool ReadArrayOfLuckyDrawItem(XmlParser doc, List<LuckyDrawItem> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "LuckyDrawItem";
			}
			for (;;)
			{
				LuckyDrawItem luckyDrawItem = new LuckyDrawItem();
				if (!XSD2CPP.ReadLuckyDrawItemClass(doc, luckyDrawItem))
				{
					break;
				}
				data.Add(luckyDrawItem);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x00030CAC File Offset: 0x0002FCAC
		private static bool ReadRewardPart(XmlParser doc, RewardPart data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "RepPart";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.RepPart);
			}
			doc.Parent();
			pName = prefix + "RewardCategory";
			if (doc.FirstChild(pName))
			{
				XSD2CPP.ReadenumRewardCategory(doc, out data.RewardCategory);
			}
			doc.Parent();
			pName = prefix + "RewardType";
			if (doc.FirstChild(pName))
			{
				XSD2CPP.ReadenumRewardType(doc, out data.RewardType);
			}
			doc.Parent();
			pName = prefix + "TokenPart";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.TokenPart);
			}
			return true;
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x00030D6C File Offset: 0x0002FD6C
		private static bool ReadArrayOfRewardPart(XmlParser doc, List<RewardPart> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "RewardPart";
			}
			for (;;)
			{
				RewardPart rewardPart = new RewardPart();
				if (!XSD2CPP.ReadRewardPartClass(doc, rewardPart))
				{
					break;
				}
				data.Add(rewardPart);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x00030DBC File Offset: 0x0002FDBC
		private static bool ReadRouteEventResult(XmlParser doc, RouteEventResult data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			XSD2CPP.ReadEventResult(doc, data, prefix);
			doc.Parent();
			string pName = prefix + "Entrants";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.Entrants = new List<RouteEntrantResult>();
				XSD2CPP.ReadArrayOfRouteEntrantResultClass(doc, data.Entrants);
			}
			return true;
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x00030E1C File Offset: 0x0002FE1C
		private static bool ReadEntrantResult(XmlParser doc, EntrantResult data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "EventDurationInMilliseconds";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.EventDurationInMilliseconds);
			}
			doc.Parent();
			pName = prefix + "EventSessionId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.EventSessionId);
			}
			doc.Parent();
			pName = prefix + "FinishReason";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.FinishReason);
			}
			doc.Parent();
			pName = prefix + "PersonaId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.PersonaId);
			}
			doc.Parent();
			pName = prefix + "Ranking";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Ranking);
			}
			return true;
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x00030F04 File Offset: 0x0002FF04
		private static bool ReadRouteEntrantResult(XmlParser doc, RouteEntrantResult data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			XSD2CPP.ReadEntrantResult(doc, data, prefix);
			doc.Parent();
			string pName = prefix + "BestLapDurationInMilliseconds";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.BestLapDurationInMilliseconds);
			}
			doc.Parent();
			pName = prefix + "TopSpeed";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadFloat(doc, out data.TopSpeed);
			}
			return true;
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x00030F78 File Offset: 0x0002FF78
		private static bool ReadArrayOfRouteEntrantResult(XmlParser doc, List<RouteEntrantResult> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "RouteEntrantResult";
			}
			for (;;)
			{
				RouteEntrantResult routeEntrantResult = new RouteEntrantResult();
				if (!XSD2CPP.ReadRouteEntrantResultClass(doc, routeEntrantResult))
				{
					break;
				}
				data.Add(routeEntrantResult);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x00030FC8 File Offset: 0x0002FFC8
		private static bool ReadDragEventResult(XmlParser doc, DragEventResult data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			XSD2CPP.ReadEventResult(doc, data, prefix);
			doc.Parent();
			string pName = prefix + "Entrants";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.Entrants = new List<DragEntrantResult>();
				XSD2CPP.ReadArrayOfDragEntrantResultClass(doc, data.Entrants);
			}
			return true;
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x00031028 File Offset: 0x00030028
		private static bool ReadDragEntrantResult(XmlParser doc, DragEntrantResult data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			XSD2CPP.ReadEntrantResult(doc, data, prefix);
			doc.Parent();
			string pName = prefix + "TopSpeed";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadFloat(doc, out data.TopSpeed);
			}
			return true;
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x00031074 File Offset: 0x00030074
		private static bool ReadArrayOfDragEntrantResult(XmlParser doc, List<DragEntrantResult> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "DragEntrantResult";
			}
			for (;;)
			{
				DragEntrantResult dragEntrantResult = new DragEntrantResult();
				if (!XSD2CPP.ReadDragEntrantResultClass(doc, dragEntrantResult))
				{
					break;
				}
				data.Add(dragEntrantResult);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x000310C4 File Offset: 0x000300C4
		private static bool ReadTeamEscapeEventResult(XmlParser doc, TeamEscapeEventResult data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			XSD2CPP.ReadEventResult(doc, data, prefix);
			doc.Parent();
			string pName = prefix + "Entrants";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.Entrants = new List<TeamEscapeEntrantResult>();
				XSD2CPP.ReadArrayOfTeamEscapeEntrantResultClass(doc, data.Entrants);
			}
			return true;
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x00031124 File Offset: 0x00030124
		private static bool ReadTeamEscapeEntrantResult(XmlParser doc, TeamEscapeEntrantResult data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			XSD2CPP.ReadEntrantResult(doc, data, prefix);
			doc.Parent();
			string pName = prefix + "DistanceToFinish";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadFloat(doc, out data.DistanceToFinish);
			}
			doc.Parent();
			pName = prefix + "FractionCompleted";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadFloat(doc, out data.FractionCompleted);
			}
			return true;
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x00031198 File Offset: 0x00030198
		private static bool ReadArrayOfTeamEscapeEntrantResult(XmlParser doc, List<TeamEscapeEntrantResult> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "TeamEscapeEntrantResult";
			}
			for (;;)
			{
				TeamEscapeEntrantResult teamEscapeEntrantResult = new TeamEscapeEntrantResult();
				if (!XSD2CPP.ReadTeamEscapeEntrantResultClass(doc, teamEscapeEntrantResult))
				{
					break;
				}
				data.Add(teamEscapeEntrantResult);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x000311E8 File Offset: 0x000301E8
		private static bool ReadPursuitEventResult(XmlParser doc, PursuitEventResult data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			XSD2CPP.ReadEventResult(doc, data, prefix);
			doc.Parent();
			string pName = prefix + "Heat";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadFloat(doc, out data.Heat);
			}
			return true;
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x00031234 File Offset: 0x00030234
		private static bool ReadEventTimingOut(XmlParser doc, EventTimingOut data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "EventSessionId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.EventSessionId);
			}
			doc.Parent();
			pName = prefix + "TimeInMilliseconds";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.TimeInMilliseconds);
			}
			return true;
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x000312A0 File Offset: 0x000302A0
		private static bool ReadTreasureHuntEventSession(XmlParser doc, TreasureHuntEventSession data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "CoinsCollected";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.CoinsCollected);
			}
			doc.Parent();
			pName = prefix + "IsStreakBroken";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.IsStreakBroken);
			}
			doc.Parent();
			pName = prefix + "NumCoins";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.NumCoins);
			}
			doc.Parent();
			pName = prefix + "Seed";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Seed);
			}
			doc.Parent();
			pName = prefix + "Streak";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Streak);
			}
			return true;
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x00031388 File Offset: 0x00030388
		private static bool ReadEventsPacket(XmlParser doc, EventsPacket data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "Events";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.Events = new List<Victory.DataLayer.Serialization.Event.EventDefinition>();
				XSD2CPP.ReadArrayOfEventDefinitionClass(doc, data.Events);
			}
			return true;
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x000313E0 File Offset: 0x000303E0
		private static bool ReadEventDefinition(XmlParser doc, Victory.DataLayer.Serialization.Event.EventDefinition data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "CarClassHash";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.CarClassHash);
			}
			doc.Parent();
			pName = prefix + "Coins";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Coins);
			}
			doc.Parent();
			pName = prefix + "EngagePoint";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.EngagePoint = new Vector3();
				XSD2CPP.ReadVector3Class(doc, data.EngagePoint);
			}
			doc.Parent();
			pName = prefix + "EventId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.EventId);
			}
			doc.Parent();
			pName = prefix + "EventLocalization";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.EventLocalization);
			}
			doc.Parent();
			pName = prefix + "EventModeDescriptionLocalization";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.EventModeDescriptionLocalization);
			}
			doc.Parent();
			pName = prefix + "EventModeIcon";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.EventModeIcon);
			}
			doc.Parent();
			pName = prefix + "EventModeId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.EventModeId);
			}
			doc.Parent();
			pName = prefix + "EventModeLocalization";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.EventModeLocalization);
			}
			doc.Parent();
			pName = prefix + "IsEnabled";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.IsEnabled);
			}
			doc.Parent();
			pName = prefix + "IsLocked";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.IsLocked);
			}
			doc.Parent();
			pName = prefix + "Laps";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Laps);
			}
			doc.Parent();
			pName = prefix + "Length";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadFloat(doc, out data.Length);
			}
			doc.Parent();
			pName = prefix + "MaxClassRating";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.MaxClassRating);
			}
			doc.Parent();
			pName = prefix + "MaxEntrants";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.MaxEntrants);
			}
			doc.Parent();
			pName = prefix + "MaxLevel";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.MaxLevel);
			}
			doc.Parent();
			pName = prefix + "MinClassRating";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.MinClassRating);
			}
			doc.Parent();
			pName = prefix + "MinEntrants";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.MinEntrants);
			}
			doc.Parent();
			pName = prefix + "MinLevel";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.MinLevel);
			}
			doc.Parent();
			pName = prefix + "RegionLocalization";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.RegionLocalization);
			}
			doc.Parent();
			pName = prefix + "RewardModes";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.RewardModes = new List<int>();
				XSD2CPP.ReadArrayOfintClass(doc, data.RewardModes);
			}
			doc.Parent();
			pName = prefix + "TimeLimit";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadFloat(doc, out data.TimeLimit);
			}
			doc.Parent();
			pName = prefix + "TrackLayoutMap";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.TrackLayoutMap);
			}
			doc.Parent();
			pName = prefix + "TrackLocalization";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.TrackLocalization);
			}
			return true;
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x000317F8 File Offset: 0x000307F8
		private static bool ReadArrayOfEventDefinition(XmlParser doc, List<Victory.DataLayer.Serialization.Event.EventDefinition> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "EventDefinition";
			}
			for (;;)
			{
				Victory.DataLayer.Serialization.Event.EventDefinition eventDefinition = new Victory.DataLayer.Serialization.Event.EventDefinition();
				if (!XSD2CPP.ReadEventDefinitionClass(doc, eventDefinition))
				{
					break;
				}
				data.Add(eventDefinition);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x00031848 File Offset: 0x00030848
		public static bool Reader(XmlString xmlString, out EventTimedOut data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "EventTimedOut"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new EventTimedOut();
						if (XSD2CPP.ReadEventTimedOutClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x000318A4 File Offset: 0x000308A4
		public static bool ReadEventTimedOut(XmlString xmlString, out EventTimedOut data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x000318B0 File Offset: 0x000308B0
		public static bool Reader(XmlString xmlString, out Reward data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "Reward"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new Reward();
						if (XSD2CPP.ReadRewardClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x0003190C File Offset: 0x0003090C
		public static bool ReadReward(XmlString xmlString, out Reward data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x00031918 File Offset: 0x00030918
		public static bool Reader(XmlString xmlString, out LuckyDrawInfo data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "LuckyDrawInfo"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new LuckyDrawInfo();
						if (XSD2CPP.ReadLuckyDrawInfoClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x00031974 File Offset: 0x00030974
		public static bool ReadLuckyDrawInfo(XmlString xmlString, out LuckyDrawInfo data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x00031980 File Offset: 0x00030980
		public static bool Reader(XmlString xmlString, out Accolades data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "Accolades"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new Accolades();
						if (XSD2CPP.ReadAccoladesClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x000319DC File Offset: 0x000309DC
		public static bool ReadAccolades(XmlString xmlString, out Accolades data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x000319E8 File Offset: 0x000309E8
		public static bool Reader(XmlString xmlString, out EventResult data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "EventResult"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new EventResult();
						if (XSD2CPP.ReadEventResultClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x00031A44 File Offset: 0x00030A44
		public static bool ReadEventResult(XmlString xmlString, out EventResult data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001A56 RID: 6742 RVA: 0x00031A50 File Offset: 0x00030A50
		public static bool Reader(XmlString xmlString, out LuckyDrawBox data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "LuckyDrawBox"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new LuckyDrawBox();
						if (XSD2CPP.ReadLuckyDrawBoxClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x00031AAC File Offset: 0x00030AAC
		public static bool ReadLuckyDrawBox(XmlString xmlString, out LuckyDrawBox data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x00031AB8 File Offset: 0x00030AB8
		public static bool Reader(XmlString xmlString, out List<LuckyDrawBox> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfLuckyDrawBox"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<LuckyDrawBox>();
						if (XSD2CPP.ReadArrayOfLuckyDrawBoxClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x00031B14 File Offset: 0x00030B14
		public static bool ReadArrayOfLuckyDrawBox(XmlString xmlString, out List<LuckyDrawBox> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x00031B20 File Offset: 0x00030B20
		public static bool Reader(XmlString xmlString, out LuckyDrawItem data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "LuckyDrawItem"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new LuckyDrawItem();
						if (XSD2CPP.ReadLuckyDrawItemClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x00031B7C File Offset: 0x00030B7C
		public static bool ReadLuckyDrawItem(XmlString xmlString, out LuckyDrawItem data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x00031B88 File Offset: 0x00030B88
		public static bool Reader(XmlString xmlString, out List<LuckyDrawItem> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfLuckyDrawItem"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<LuckyDrawItem>();
						if (XSD2CPP.ReadArrayOfLuckyDrawItemClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x00031BE4 File Offset: 0x00030BE4
		public static bool ReadArrayOfLuckyDrawItem(XmlString xmlString, out List<LuckyDrawItem> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x00031BF0 File Offset: 0x00030BF0
		public static bool Reader(XmlString xmlString, out RewardPart data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "RewardPart"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new RewardPart();
						if (XSD2CPP.ReadRewardPartClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x00031C4C File Offset: 0x00030C4C
		public static bool ReadRewardPart(XmlString xmlString, out RewardPart data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x00031C58 File Offset: 0x00030C58
		public static bool Reader(XmlString xmlString, out List<RewardPart> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfRewardPart"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<RewardPart>();
						if (XSD2CPP.ReadArrayOfRewardPartClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001A61 RID: 6753 RVA: 0x00031CB4 File Offset: 0x00030CB4
		public static bool ReadArrayOfRewardPart(XmlString xmlString, out List<RewardPart> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x00031CC0 File Offset: 0x00030CC0
		public static bool Reader(XmlString xmlString, out RouteEventResult data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "RouteEventResult"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new RouteEventResult();
						if (XSD2CPP.ReadRouteEventResultClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001A63 RID: 6755 RVA: 0x00031D1C File Offset: 0x00030D1C
		public static bool ReadRouteEventResult(XmlString xmlString, out RouteEventResult data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x00031D28 File Offset: 0x00030D28
		public static bool Reader(XmlString xmlString, out EntrantResult data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "EntrantResult"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new EntrantResult();
						if (XSD2CPP.ReadEntrantResultClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001A65 RID: 6757 RVA: 0x00031D84 File Offset: 0x00030D84
		public static bool ReadEntrantResult(XmlString xmlString, out EntrantResult data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001A66 RID: 6758 RVA: 0x00031D90 File Offset: 0x00030D90
		public static bool Reader(XmlString xmlString, out RouteEntrantResult data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "RouteEntrantResult"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new RouteEntrantResult();
						if (XSD2CPP.ReadRouteEntrantResultClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001A67 RID: 6759 RVA: 0x00031DEC File Offset: 0x00030DEC
		public static bool ReadRouteEntrantResult(XmlString xmlString, out RouteEntrantResult data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001A68 RID: 6760 RVA: 0x00031DF8 File Offset: 0x00030DF8
		public static bool Reader(XmlString xmlString, out List<RouteEntrantResult> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfRouteEntrantResult"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<RouteEntrantResult>();
						if (XSD2CPP.ReadArrayOfRouteEntrantResultClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x00031E54 File Offset: 0x00030E54
		public static bool ReadArrayOfRouteEntrantResult(XmlString xmlString, out List<RouteEntrantResult> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x00031E60 File Offset: 0x00030E60
		public static bool Reader(XmlString xmlString, out DragEventResult data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "DragEventResult"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new DragEventResult();
						if (XSD2CPP.ReadDragEventResultClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x00031EBC File Offset: 0x00030EBC
		public static bool ReadDragEventResult(XmlString xmlString, out DragEventResult data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x00031EC8 File Offset: 0x00030EC8
		public static bool Reader(XmlString xmlString, out DragEntrantResult data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "DragEntrantResult"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new DragEntrantResult();
						if (XSD2CPP.ReadDragEntrantResultClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001A6D RID: 6765 RVA: 0x00031F24 File Offset: 0x00030F24
		public static bool ReadDragEntrantResult(XmlString xmlString, out DragEntrantResult data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001A6E RID: 6766 RVA: 0x00031F30 File Offset: 0x00030F30
		public static bool Reader(XmlString xmlString, out List<DragEntrantResult> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfDragEntrantResult"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<DragEntrantResult>();
						if (XSD2CPP.ReadArrayOfDragEntrantResultClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x00031F8C File Offset: 0x00030F8C
		public static bool ReadArrayOfDragEntrantResult(XmlString xmlString, out List<DragEntrantResult> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001A70 RID: 6768 RVA: 0x00031F98 File Offset: 0x00030F98
		public static bool Reader(XmlString xmlString, out TeamEscapeEventResult data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "TeamEscapeEventResult"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new TeamEscapeEventResult();
						if (XSD2CPP.ReadTeamEscapeEventResultClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x00031FF4 File Offset: 0x00030FF4
		public static bool ReadTeamEscapeEventResult(XmlString xmlString, out TeamEscapeEventResult data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x00032000 File Offset: 0x00031000
		public static bool Reader(XmlString xmlString, out TeamEscapeEntrantResult data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "TeamEscapeEntrantResult"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new TeamEscapeEntrantResult();
						if (XSD2CPP.ReadTeamEscapeEntrantResultClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x0003205C File Offset: 0x0003105C
		public static bool ReadTeamEscapeEntrantResult(XmlString xmlString, out TeamEscapeEntrantResult data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x00032068 File Offset: 0x00031068
		public static bool Reader(XmlString xmlString, out List<TeamEscapeEntrantResult> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfTeamEscapeEntrantResult"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<TeamEscapeEntrantResult>();
						if (XSD2CPP.ReadArrayOfTeamEscapeEntrantResultClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x000320C4 File Offset: 0x000310C4
		public static bool ReadArrayOfTeamEscapeEntrantResult(XmlString xmlString, out List<TeamEscapeEntrantResult> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x000320D0 File Offset: 0x000310D0
		public static bool Reader(XmlString xmlString, out PursuitEventResult data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "PursuitEventResult"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new PursuitEventResult();
						if (XSD2CPP.ReadPursuitEventResultClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x0003212C File Offset: 0x0003112C
		public static bool ReadPursuitEventResult(XmlString xmlString, out PursuitEventResult data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x00032138 File Offset: 0x00031138
		public static bool Reader(XmlString xmlString, out EventTimingOut data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "EventTimingOut"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new EventTimingOut();
						if (XSD2CPP.ReadEventTimingOutClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x00032194 File Offset: 0x00031194
		public static bool ReadEventTimingOut(XmlString xmlString, out EventTimingOut data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x000321A0 File Offset: 0x000311A0
		public static bool Reader(XmlString xmlString, out TreasureHuntEventSession data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "TreasureHuntEventSession"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new TreasureHuntEventSession();
						if (XSD2CPP.ReadTreasureHuntEventSessionClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x000321FC File Offset: 0x000311FC
		public static bool ReadTreasureHuntEventSession(XmlString xmlString, out TreasureHuntEventSession data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001A7C RID: 6780 RVA: 0x00032208 File Offset: 0x00031208
		public static bool Reader(XmlString xmlString, out EventsPacket data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "EventsPacket"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new EventsPacket();
						if (XSD2CPP.ReadEventsPacketClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001A7D RID: 6781 RVA: 0x00032264 File Offset: 0x00031264
		public static bool ReadEventsPacket(XmlString xmlString, out EventsPacket data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001A7E RID: 6782 RVA: 0x00032270 File Offset: 0x00031270
		public static bool Reader(XmlString xmlString, out Victory.DataLayer.Serialization.Event.EventDefinition data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "EventDefinition"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new Victory.DataLayer.Serialization.Event.EventDefinition();
						if (XSD2CPP.ReadEventDefinitionClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x000322CC File Offset: 0x000312CC
		public static bool ReadEventDefinition(XmlString xmlString, out Victory.DataLayer.Serialization.Event.EventDefinition data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x000322D8 File Offset: 0x000312D8
		public static bool Reader(XmlString xmlString, out List<Victory.DataLayer.Serialization.Event.EventDefinition> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfEventDefinition"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<Victory.DataLayer.Serialization.Event.EventDefinition>();
						if (XSD2CPP.ReadArrayOfEventDefinitionClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x00032334 File Offset: 0x00031334
		public static bool ReadArrayOfEventDefinition(XmlString xmlString, out List<Victory.DataLayer.Serialization.Event.EventDefinition> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x0003233D File Offset: 0x0003133D
		private static void WriteFinishReason(XmlParser doc, FinishReason data)
		{
			Xsd2CppUtil.WriteString(doc, data.ToString());
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x00032351 File Offset: 0x00031351
		private static void WriteenumRewardCategory(XmlParser doc, enumRewardCategory data)
		{
			Xsd2CppUtil.WriteString(doc, data.ToString());
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x00032365 File Offset: 0x00031365
		private static void WriteenumRewardType(XmlParser doc, enumRewardType data)
		{
			Xsd2CppUtil.WriteString(doc, data.ToString());
		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x00032379 File Offset: 0x00031379
		private static void WriteExitPath(XmlParser doc, ExitPath data)
		{
			Xsd2CppUtil.WriteString(doc, data.ToString());
		}

		// Token: 0x06001A86 RID: 6790 RVA: 0x0003238D File Offset: 0x0003138D
		private static void WriteEventTimedOut(XmlParser doc, EventTimedOut data)
		{
			doc.AddChild("EventSessionId");
			Xsd2CppUtil.WriteLong(doc, data.EventSessionId);
			doc.Parent();
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x000323B0 File Offset: 0x000313B0
		private static void WriteReward(XmlParser doc, Reward data)
		{
			doc.AddChild("Rep");
			Xsd2CppUtil.WriteInt(doc, data.Rep);
			doc.Parent();
			doc.AddChild("Tokens");
			Xsd2CppUtil.WriteInt(doc, data.Tokens);
			doc.Parent();
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x00032400 File Offset: 0x00031400
		private static void WriteLuckyDrawInfo(XmlParser doc, LuckyDrawInfo data)
		{
			doc.AddChild("Boxes");
			XSD2CPP.WriteArrayOfLuckyDrawBox(doc, data.Boxes);
			doc.Parent();
			doc.AddChild("CardDeck");
			Xsd2CppUtil.WriteString(doc, data.CardDeck);
			doc.Parent();
			doc.AddChild("CurrentStreak");
			Xsd2CppUtil.WriteInt(doc, data.CurrentStreak);
			doc.Parent();
			doc.AddChild("IsStreakBroken");
			Xsd2CppUtil.WriteBoolean(doc, data.IsStreakBroken);
			doc.Parent();
			doc.AddChild("Items");
			XSD2CPP.WriteArrayOfLuckyDrawItem(doc, data.Items);
			doc.Parent();
			doc.AddChild("NumBoxAnimations");
			Xsd2CppUtil.WriteInt(doc, data.NumBoxAnimations);
			doc.Parent();
			doc.AddChild("NumCards");
			Xsd2CppUtil.WriteInt(doc, data.NumCards);
			doc.Parent();
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x000324EC File Offset: 0x000314EC
		private static void WriteAccolades(XmlParser doc, Accolades data)
		{
			doc.AddChild("FinalRewards");
			XSD2CPP.WriteReward(doc, data.FinalRewards);
			doc.Parent();
			doc.AddChild("HasLeveledUp");
			Xsd2CppUtil.WriteBoolean(doc, data.HasLeveledUp);
			doc.Parent();
			doc.AddChild("LuckyDrawInfo");
			XSD2CPP.WriteLuckyDrawInfo(doc, data.LuckyDrawInfo);
			doc.Parent();
			doc.AddChild("OriginalRewards");
			XSD2CPP.WriteReward(doc, data.OriginalRewards);
			doc.Parent();
			doc.AddChild("RewardInfo");
			XSD2CPP.WriteArrayOfRewardPart(doc, data.RewardInfo);
			doc.Parent();
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x00032598 File Offset: 0x00031598
		private static void WriteEventResult(XmlParser doc, EventResult data)
		{
			doc.AddChild("Accolades");
			XSD2CPP.WriteAccolades(doc, data.Accolades);
			doc.Parent();
			doc.AddChild("Durability");
			Xsd2CppUtil.WriteInt(doc, data.Durability);
			doc.Parent();
			doc.AddChild("EventId");
			Xsd2CppUtil.WriteInt(doc, data.EventId);
			doc.Parent();
			doc.AddChild("EventSessionId");
			Xsd2CppUtil.WriteLong(doc, data.EventSessionId);
			doc.Parent();
			doc.AddChild("ExitPath");
			XSD2CPP.WriteExitPath(doc, data.ExitPath);
			doc.Parent();
			doc.AddChild("InviteLifetimeInMilliseconds");
			Xsd2CppUtil.WriteInt(doc, data.InviteLifetimeInMilliseconds);
			doc.Parent();
			doc.AddChild("LobbyInviteId");
			Xsd2CppUtil.WriteLong(doc, data.LobbyInviteId);
			doc.Parent();
			doc.AddChild("PersonaId");
			Xsd2CppUtil.WriteLong(doc, data.PersonaId);
			doc.Parent();
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x000326A4 File Offset: 0x000316A4
		private static void WriteLuckyDrawBox(XmlParser doc, LuckyDrawBox data)
		{
			doc.AddChild("IsValid");
			Xsd2CppUtil.WriteBoolean(doc, data.IsValid);
			doc.Parent();
			doc.AddChild("LocalizationString");
			Xsd2CppUtil.WriteString(doc, data.LocalizationString);
			doc.Parent();
			doc.AddChild("LuckyDrawSetCategoryId");
			Xsd2CppUtil.WriteInt(doc, data.LuckyDrawSetCategoryId);
			doc.Parent();
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x00032714 File Offset: 0x00031714
		private static void WriteArrayOfLuckyDrawBox(XmlParser doc, List<LuckyDrawBox> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("LuckyDrawBox");
				XSD2CPP.WriteLuckyDrawBox(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x00032754 File Offset: 0x00031754
		private static void WriteLuckyDrawItem(XmlParser doc, LuckyDrawItem data)
		{
			doc.AddChild("Description");
			Xsd2CppUtil.WriteString(doc, data.Description);
			doc.Parent();
			doc.AddChild("Hash");
			Xsd2CppUtil.WriteInt(doc, data.Hash);
			doc.Parent();
			doc.AddChild("Icon");
			Xsd2CppUtil.WriteString(doc, data.Icon);
			doc.Parent();
			doc.AddChild("RemainingUseCount");
			Xsd2CppUtil.WriteInt(doc, data.RemainingUseCount);
			doc.Parent();
			doc.AddChild("ResellPrice");
			Xsd2CppUtil.WriteFloat(doc, data.ResellPrice);
			doc.Parent();
			doc.AddChild("VirtualItem");
			Xsd2CppUtil.WriteString(doc, data.VirtualItem);
			doc.Parent();
			doc.AddChild("VirtualItemType");
			Xsd2CppUtil.WriteString(doc, data.VirtualItemType);
			doc.Parent();
			doc.AddChild("WasSold");
			Xsd2CppUtil.WriteBoolean(doc, data.WasSold);
			doc.Parent();
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x00032864 File Offset: 0x00031864
		private static void WriteArrayOfLuckyDrawItem(XmlParser doc, List<LuckyDrawItem> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("LuckyDrawItem");
				XSD2CPP.WriteLuckyDrawItem(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x000328A4 File Offset: 0x000318A4
		private static void WriteRewardPart(XmlParser doc, RewardPart data)
		{
			doc.AddChild("RepPart");
			Xsd2CppUtil.WriteInt(doc, data.RepPart);
			doc.Parent();
			doc.AddChild("RewardCategory");
			XSD2CPP.WriteenumRewardCategory(doc, data.RewardCategory);
			doc.Parent();
			doc.AddChild("RewardType");
			XSD2CPP.WriteenumRewardType(doc, data.RewardType);
			doc.Parent();
			doc.AddChild("TokenPart");
			Xsd2CppUtil.WriteInt(doc, data.TokenPart);
			doc.Parent();
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x00032930 File Offset: 0x00031930
		private static void WriteArrayOfRewardPart(XmlParser doc, List<RewardPart> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("RewardPart");
				XSD2CPP.WriteRewardPart(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x0003296E File Offset: 0x0003196E
		private static void WriteRouteEventResult(XmlParser doc, RouteEventResult data)
		{
			XSD2CPP.WriteEventResult(doc, data);
			doc.AddChild("Entrants");
			XSD2CPP.WriteArrayOfRouteEntrantResult(doc, data.Entrants);
			doc.Parent();
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x00032998 File Offset: 0x00031998
		private static void WriteEntrantResult(XmlParser doc, EntrantResult data)
		{
			doc.AddChild("EventDurationInMilliseconds");
			Xsd2CppUtil.WriteUInt(doc, data.EventDurationInMilliseconds);
			doc.Parent();
			doc.AddChild("EventSessionId");
			Xsd2CppUtil.WriteLong(doc, data.EventSessionId);
			doc.Parent();
			doc.AddChild("FinishReason");
			Xsd2CppUtil.WriteInt(doc, data.FinishReason);
			doc.Parent();
			doc.AddChild("PersonaId");
			Xsd2CppUtil.WriteLong(doc, data.PersonaId);
			doc.Parent();
			doc.AddChild("Ranking");
			Xsd2CppUtil.WriteInt(doc, data.Ranking);
			doc.Parent();
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x00032A48 File Offset: 0x00031A48
		private static void WriteRouteEntrantResult(XmlParser doc, RouteEntrantResult data)
		{
			XSD2CPP.WriteEntrantResult(doc, data);
			doc.AddChild("BestLapDurationInMilliseconds");
			Xsd2CppUtil.WriteUInt(doc, data.BestLapDurationInMilliseconds);
			doc.Parent();
			doc.AddChild("TopSpeed");
			Xsd2CppUtil.WriteFloat(doc, data.TopSpeed);
			doc.Parent();
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x00032A9C File Offset: 0x00031A9C
		private static void WriteArrayOfRouteEntrantResult(XmlParser doc, List<RouteEntrantResult> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("RouteEntrantResult");
				XSD2CPP.WriteRouteEntrantResult(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x00032ADA File Offset: 0x00031ADA
		private static void WriteDragEventResult(XmlParser doc, DragEventResult data)
		{
			XSD2CPP.WriteEventResult(doc, data);
			doc.AddChild("Entrants");
			XSD2CPP.WriteArrayOfDragEntrantResult(doc, data.Entrants);
			doc.Parent();
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x00032B02 File Offset: 0x00031B02
		private static void WriteDragEntrantResult(XmlParser doc, DragEntrantResult data)
		{
			XSD2CPP.WriteEntrantResult(doc, data);
			doc.AddChild("TopSpeed");
			Xsd2CppUtil.WriteFloat(doc, data.TopSpeed);
			doc.Parent();
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x00032B2C File Offset: 0x00031B2C
		private static void WriteArrayOfDragEntrantResult(XmlParser doc, List<DragEntrantResult> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("DragEntrantResult");
				XSD2CPP.WriteDragEntrantResult(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x00032B6A File Offset: 0x00031B6A
		private static void WriteTeamEscapeEventResult(XmlParser doc, TeamEscapeEventResult data)
		{
			XSD2CPP.WriteEventResult(doc, data);
			doc.AddChild("Entrants");
			XSD2CPP.WriteArrayOfTeamEscapeEntrantResult(doc, data.Entrants);
			doc.Parent();
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x00032B94 File Offset: 0x00031B94
		private static void WriteTeamEscapeEntrantResult(XmlParser doc, TeamEscapeEntrantResult data)
		{
			XSD2CPP.WriteEntrantResult(doc, data);
			doc.AddChild("DistanceToFinish");
			Xsd2CppUtil.WriteFloat(doc, data.DistanceToFinish);
			doc.Parent();
			doc.AddChild("FractionCompleted");
			Xsd2CppUtil.WriteFloat(doc, data.FractionCompleted);
			doc.Parent();
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x00032BE8 File Offset: 0x00031BE8
		private static void WriteArrayOfTeamEscapeEntrantResult(XmlParser doc, List<TeamEscapeEntrantResult> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("TeamEscapeEntrantResult");
				XSD2CPP.WriteTeamEscapeEntrantResult(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x00032C26 File Offset: 0x00031C26
		private static void WritePursuitEventResult(XmlParser doc, PursuitEventResult data)
		{
			XSD2CPP.WriteEventResult(doc, data);
			doc.AddChild("Heat");
			Xsd2CppUtil.WriteFloat(doc, data.Heat);
			doc.Parent();
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x00032C50 File Offset: 0x00031C50
		private static void WriteEventTimingOut(XmlParser doc, EventTimingOut data)
		{
			doc.AddChild("EventSessionId");
			Xsd2CppUtil.WriteLong(doc, data.EventSessionId);
			doc.Parent();
			doc.AddChild("TimeInMilliseconds");
			Xsd2CppUtil.WriteLong(doc, data.TimeInMilliseconds);
			doc.Parent();
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x00032CA0 File Offset: 0x00031CA0
		private static void WriteTreasureHuntEventSession(XmlParser doc, TreasureHuntEventSession data)
		{
			doc.AddChild("CoinsCollected");
			Xsd2CppUtil.WriteInt(doc, data.CoinsCollected);
			doc.Parent();
			doc.AddChild("IsStreakBroken");
			Xsd2CppUtil.WriteBoolean(doc, data.IsStreakBroken);
			doc.Parent();
			doc.AddChild("NumCoins");
			Xsd2CppUtil.WriteInt(doc, data.NumCoins);
			doc.Parent();
			doc.AddChild("Seed");
			Xsd2CppUtil.WriteInt(doc, data.Seed);
			doc.Parent();
			doc.AddChild("Streak");
			Xsd2CppUtil.WriteInt(doc, data.Streak);
			doc.Parent();
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x00032D4D File Offset: 0x00031D4D
		private static void WriteEventsPacket(XmlParser doc, EventsPacket data)
		{
			doc.AddChild("Events");
			XSD2CPP.WriteArrayOfEventDefinition(doc, data.Events);
			doc.Parent();
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x00032D70 File Offset: 0x00031D70
		private static void WriteEventDefinition(XmlParser doc, Victory.DataLayer.Serialization.Event.EventDefinition data)
		{
			doc.AddChild("CarClassHash");
			Xsd2CppUtil.WriteInt(doc, data.CarClassHash);
			doc.Parent();
			doc.AddChild("Coins");
			Xsd2CppUtil.WriteInt(doc, data.Coins);
			doc.Parent();
			doc.AddChild("EngagePoint");
			XSD2CPP.WriteVector3(doc, data.EngagePoint);
			doc.Parent();
			doc.AddChild("EventId");
			Xsd2CppUtil.WriteInt(doc, data.EventId);
			doc.Parent();
			doc.AddChild("EventLocalization");
			Xsd2CppUtil.WriteInt(doc, data.EventLocalization);
			doc.Parent();
			doc.AddChild("EventModeDescriptionLocalization");
			Xsd2CppUtil.WriteInt(doc, data.EventModeDescriptionLocalization);
			doc.Parent();
			doc.AddChild("EventModeIcon");
			Xsd2CppUtil.WriteString(doc, data.EventModeIcon);
			doc.Parent();
			doc.AddChild("EventModeId");
			Xsd2CppUtil.WriteInt(doc, data.EventModeId);
			doc.Parent();
			doc.AddChild("EventModeLocalization");
			Xsd2CppUtil.WriteInt(doc, data.EventModeLocalization);
			doc.Parent();
			doc.AddChild("IsEnabled");
			Xsd2CppUtil.WriteBoolean(doc, data.IsEnabled);
			doc.Parent();
			doc.AddChild("IsLocked");
			Xsd2CppUtil.WriteBoolean(doc, data.IsLocked);
			doc.Parent();
			doc.AddChild("Laps");
			Xsd2CppUtil.WriteInt(doc, data.Laps);
			doc.Parent();
			doc.AddChild("Length");
			Xsd2CppUtil.WriteFloat(doc, data.Length);
			doc.Parent();
			doc.AddChild("MaxClassRating");
			Xsd2CppUtil.WriteInt(doc, data.MaxClassRating);
			doc.Parent();
			doc.AddChild("MaxEntrants");
			Xsd2CppUtil.WriteInt(doc, data.MaxEntrants);
			doc.Parent();
			doc.AddChild("MaxLevel");
			Xsd2CppUtil.WriteInt(doc, data.MaxLevel);
			doc.Parent();
			doc.AddChild("MinClassRating");
			Xsd2CppUtil.WriteInt(doc, data.MinClassRating);
			doc.Parent();
			doc.AddChild("MinEntrants");
			Xsd2CppUtil.WriteInt(doc, data.MinEntrants);
			doc.Parent();
			doc.AddChild("MinLevel");
			Xsd2CppUtil.WriteInt(doc, data.MinLevel);
			doc.Parent();
			doc.AddChild("RegionLocalization");
			Xsd2CppUtil.WriteInt(doc, data.RegionLocalization);
			doc.Parent();
			doc.AddChild("RewardModes");
			XSD2CPP.WriteArrayOfint(doc, data.RewardModes);
			doc.Parent();
			doc.AddChild("TimeLimit");
			Xsd2CppUtil.WriteFloat(doc, data.TimeLimit);
			doc.Parent();
			doc.AddChild("TrackLayoutMap");
			Xsd2CppUtil.WriteString(doc, data.TrackLayoutMap);
			doc.Parent();
			doc.AddChild("TrackLocalization");
			Xsd2CppUtil.WriteInt(doc, data.TrackLocalization);
			doc.Parent();
		}

		// Token: 0x06001AA0 RID: 6816 RVA: 0x0003307C File Offset: 0x0003207C
		private static void WriteArrayOfEventDefinition(XmlParser doc, List<Victory.DataLayer.Serialization.Event.EventDefinition> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("EventDefinition");
				XSD2CPP.WriteEventDefinition(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x000330BC File Offset: 0x000320BC
		public static bool WriterXML(EventTimedOut data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("EventTimedOut");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteEventTimedOut(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x0003310D File Offset: 0x0003210D
		public static bool Writer(EventTimedOut data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x00033116 File Offset: 0x00032116
		public static bool WriteEventTimedOut(EventTimedOut data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x00033120 File Offset: 0x00032120
		public static bool WriterXML(Reward data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("Reward");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteReward(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x00033171 File Offset: 0x00032171
		public static bool Writer(Reward data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x0003317A File Offset: 0x0003217A
		public static bool WriteReward(Reward data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x00033184 File Offset: 0x00032184
		public static bool WriterXML(LuckyDrawInfo data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("LuckyDrawInfo");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteLuckyDrawInfo(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x000331D5 File Offset: 0x000321D5
		public static bool Writer(LuckyDrawInfo data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x000331DE File Offset: 0x000321DE
		public static bool WriteLuckyDrawInfo(LuckyDrawInfo data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x000331E8 File Offset: 0x000321E8
		public static bool WriterXML(Accolades data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("Accolades");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteAccolades(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x00033239 File Offset: 0x00032239
		public static bool Writer(Accolades data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x00033242 File Offset: 0x00032242
		public static bool WriteAccolades(Accolades data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x0003324C File Offset: 0x0003224C
		public static bool WriterXML(EventResult data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("EventResult");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteEventResult(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x0003329D File Offset: 0x0003229D
		public static bool Writer(EventResult data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x000332A6 File Offset: 0x000322A6
		public static bool WriteEventResult(EventResult data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001AB0 RID: 6832 RVA: 0x000332B0 File Offset: 0x000322B0
		public static bool WriterXML(LuckyDrawBox data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("LuckyDrawBox");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteLuckyDrawBox(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x00033301 File Offset: 0x00032301
		public static bool Writer(LuckyDrawBox data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x0003330A File Offset: 0x0003230A
		public static bool WriteLuckyDrawBox(LuckyDrawBox data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x00033314 File Offset: 0x00032314
		public static bool WriterXML(List<LuckyDrawBox> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfLuckyDrawBox");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfLuckyDrawBox(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x00033365 File Offset: 0x00032365
		public static bool Writer(List<LuckyDrawBox> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x0003336E File Offset: 0x0003236E
		public static bool WriteArrayOfLuckyDrawBox(List<LuckyDrawBox> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x00033378 File Offset: 0x00032378
		public static bool WriterXML(LuckyDrawItem data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("LuckyDrawItem");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteLuckyDrawItem(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x000333C9 File Offset: 0x000323C9
		public static bool Writer(LuckyDrawItem data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x000333D2 File Offset: 0x000323D2
		public static bool WriteLuckyDrawItem(LuckyDrawItem data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x000333DC File Offset: 0x000323DC
		public static bool WriterXML(List<LuckyDrawItem> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfLuckyDrawItem");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfLuckyDrawItem(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x0003342D File Offset: 0x0003242D
		public static bool Writer(List<LuckyDrawItem> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001ABB RID: 6843 RVA: 0x00033436 File Offset: 0x00032436
		public static bool WriteArrayOfLuckyDrawItem(List<LuckyDrawItem> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001ABC RID: 6844 RVA: 0x00033440 File Offset: 0x00032440
		public static bool WriterXML(RewardPart data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("RewardPart");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteRewardPart(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x00033491 File Offset: 0x00032491
		public static bool Writer(RewardPart data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x0003349A File Offset: 0x0003249A
		public static bool WriteRewardPart(RewardPart data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001ABF RID: 6847 RVA: 0x000334A4 File Offset: 0x000324A4
		public static bool WriterXML(List<RewardPart> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfRewardPart");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfRewardPart(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001AC0 RID: 6848 RVA: 0x000334F5 File Offset: 0x000324F5
		public static bool Writer(List<RewardPart> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001AC1 RID: 6849 RVA: 0x000334FE File Offset: 0x000324FE
		public static bool WriteArrayOfRewardPart(List<RewardPart> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001AC2 RID: 6850 RVA: 0x00033508 File Offset: 0x00032508
		public static bool WriterXML(RouteEventResult data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("RouteEventResult");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteRouteEventResult(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001AC3 RID: 6851 RVA: 0x00033559 File Offset: 0x00032559
		public static bool Writer(RouteEventResult data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001AC4 RID: 6852 RVA: 0x00033562 File Offset: 0x00032562
		public static bool WriteRouteEventResult(RouteEventResult data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001AC5 RID: 6853 RVA: 0x0003356C File Offset: 0x0003256C
		public static bool WriterXML(EntrantResult data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("EntrantResult");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteEntrantResult(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001AC6 RID: 6854 RVA: 0x000335BD File Offset: 0x000325BD
		public static bool Writer(EntrantResult data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x000335C6 File Offset: 0x000325C6
		public static bool WriteEntrantResult(EntrantResult data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001AC8 RID: 6856 RVA: 0x000335D0 File Offset: 0x000325D0
		public static bool WriterXML(RouteEntrantResult data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("RouteEntrantResult");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteRouteEntrantResult(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001AC9 RID: 6857 RVA: 0x00033621 File Offset: 0x00032621
		public static bool Writer(RouteEntrantResult data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x0003362A File Offset: 0x0003262A
		public static bool WriteRouteEntrantResult(RouteEntrantResult data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x00033634 File Offset: 0x00032634
		public static bool WriterXML(List<RouteEntrantResult> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfRouteEntrantResult");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfRouteEntrantResult(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x00033685 File Offset: 0x00032685
		public static bool Writer(List<RouteEntrantResult> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001ACD RID: 6861 RVA: 0x0003368E File Offset: 0x0003268E
		public static bool WriteArrayOfRouteEntrantResult(List<RouteEntrantResult> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001ACE RID: 6862 RVA: 0x00033698 File Offset: 0x00032698
		public static bool WriterXML(DragEventResult data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("DragEventResult");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteDragEventResult(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x000336E9 File Offset: 0x000326E9
		public static bool Writer(DragEventResult data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001AD0 RID: 6864 RVA: 0x000336F2 File Offset: 0x000326F2
		public static bool WriteDragEventResult(DragEventResult data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001AD1 RID: 6865 RVA: 0x000336FC File Offset: 0x000326FC
		public static bool WriterXML(DragEntrantResult data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("DragEntrantResult");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteDragEntrantResult(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x0003374D File Offset: 0x0003274D
		public static bool Writer(DragEntrantResult data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x00033756 File Offset: 0x00032756
		public static bool WriteDragEntrantResult(DragEntrantResult data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001AD4 RID: 6868 RVA: 0x00033760 File Offset: 0x00032760
		public static bool WriterXML(List<DragEntrantResult> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfDragEntrantResult");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfDragEntrantResult(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x000337B1 File Offset: 0x000327B1
		public static bool Writer(List<DragEntrantResult> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x000337BA File Offset: 0x000327BA
		public static bool WriteArrayOfDragEntrantResult(List<DragEntrantResult> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x000337C4 File Offset: 0x000327C4
		public static bool WriterXML(TeamEscapeEventResult data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("TeamEscapeEventResult");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteTeamEscapeEventResult(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001AD8 RID: 6872 RVA: 0x00033815 File Offset: 0x00032815
		public static bool Writer(TeamEscapeEventResult data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x0003381E File Offset: 0x0003281E
		public static bool WriteTeamEscapeEventResult(TeamEscapeEventResult data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001ADA RID: 6874 RVA: 0x00033828 File Offset: 0x00032828
		public static bool WriterXML(TeamEscapeEntrantResult data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("TeamEscapeEntrantResult");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteTeamEscapeEntrantResult(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001ADB RID: 6875 RVA: 0x00033879 File Offset: 0x00032879
		public static bool Writer(TeamEscapeEntrantResult data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x00033882 File Offset: 0x00032882
		public static bool WriteTeamEscapeEntrantResult(TeamEscapeEntrantResult data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x0003388C File Offset: 0x0003288C
		public static bool WriterXML(List<TeamEscapeEntrantResult> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfTeamEscapeEntrantResult");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfTeamEscapeEntrantResult(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001ADE RID: 6878 RVA: 0x000338DD File Offset: 0x000328DD
		public static bool Writer(List<TeamEscapeEntrantResult> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x000338E6 File Offset: 0x000328E6
		public static bool WriteArrayOfTeamEscapeEntrantResult(List<TeamEscapeEntrantResult> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x000338F0 File Offset: 0x000328F0
		public static bool WriterXML(PursuitEventResult data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("PursuitEventResult");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WritePursuitEventResult(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x00033941 File Offset: 0x00032941
		public static bool Writer(PursuitEventResult data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x0003394A File Offset: 0x0003294A
		public static bool WritePursuitEventResult(PursuitEventResult data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001AE3 RID: 6883 RVA: 0x00033954 File Offset: 0x00032954
		public static bool WriterXML(EventTimingOut data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("EventTimingOut");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteEventTimingOut(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x000339A5 File Offset: 0x000329A5
		public static bool Writer(EventTimingOut data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001AE5 RID: 6885 RVA: 0x000339AE File Offset: 0x000329AE
		public static bool WriteEventTimingOut(EventTimingOut data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001AE6 RID: 6886 RVA: 0x000339B8 File Offset: 0x000329B8
		public static bool WriterXML(TreasureHuntEventSession data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("TreasureHuntEventSession");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteTreasureHuntEventSession(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001AE7 RID: 6887 RVA: 0x00033A09 File Offset: 0x00032A09
		public static bool Writer(TreasureHuntEventSession data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001AE8 RID: 6888 RVA: 0x00033A12 File Offset: 0x00032A12
		public static bool WriteTreasureHuntEventSession(TreasureHuntEventSession data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001AE9 RID: 6889 RVA: 0x00033A1C File Offset: 0x00032A1C
		public static bool WriterXML(EventsPacket data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("EventsPacket");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteEventsPacket(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001AEA RID: 6890 RVA: 0x00033A6D File Offset: 0x00032A6D
		public static bool Writer(EventsPacket data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001AEB RID: 6891 RVA: 0x00033A76 File Offset: 0x00032A76
		public static bool WriteEventsPacket(EventsPacket data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001AEC RID: 6892 RVA: 0x00033A80 File Offset: 0x00032A80
		public static bool WriterXML(Victory.DataLayer.Serialization.Event.EventDefinition data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("EventDefinition");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteEventDefinition(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x00033AD1 File Offset: 0x00032AD1
		public static bool Writer(Victory.DataLayer.Serialization.Event.EventDefinition data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x00033ADA File Offset: 0x00032ADA
		public static bool WriteEventDefinition(Victory.DataLayer.Serialization.Event.EventDefinition data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x00033AE4 File Offset: 0x00032AE4
		public static bool WriterXML(List<Victory.DataLayer.Serialization.Event.EventDefinition> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfEventDefinition");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfEventDefinition(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x00033B35 File Offset: 0x00032B35
		public static bool Writer(List<Victory.DataLayer.Serialization.Event.EventDefinition> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001AF1 RID: 6897 RVA: 0x00033B3E File Offset: 0x00032B3E
		public static bool WriteArrayOfEventDefinition(List<Victory.DataLayer.Serialization.Event.EventDefinition> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001AF2 RID: 6898 RVA: 0x00033B48 File Offset: 0x00032B48
		public static bool ReadLevelGiftDefinitionClass(XmlParser doc, LevelGiftDefinition data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Gift");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadLevelGiftDefinition(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001AF3 RID: 6899 RVA: 0x00033B90 File Offset: 0x00032B90
		public static bool ReadArrayOfLevelGiftDefinitionClass(XmlParser doc, List<LevelGiftDefinition> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Gift");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfLevelGiftDefinition(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001AF4 RID: 6900 RVA: 0x00033BD8 File Offset: 0x00032BD8
		private static bool ReadLevelGiftDefinition(XmlParser doc, LevelGiftDefinition data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "Boost";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Boost);
			}
			doc.Parent();
			pName = prefix + "Level";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Level);
			}
			doc.Parent();
			pName = prefix + "LevelGiftId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.LevelGiftId);
			}
			return true;
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x00033C6C File Offset: 0x00032C6C
		private static bool ReadArrayOfLevelGiftDefinition(XmlParser doc, List<LevelGiftDefinition> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "LevelGiftDefinition";
			}
			for (;;)
			{
				LevelGiftDefinition levelGiftDefinition = new LevelGiftDefinition();
				if (!XSD2CPP.ReadLevelGiftDefinitionClass(doc, levelGiftDefinition))
				{
					break;
				}
				data.Add(levelGiftDefinition);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x00033CBC File Offset: 0x00032CBC
		public static bool Reader(XmlString xmlString, out LevelGiftDefinition data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "LevelGiftDefinition"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new LevelGiftDefinition();
						if (XSD2CPP.ReadLevelGiftDefinitionClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x00033D18 File Offset: 0x00032D18
		public static bool ReadLevelGiftDefinition(XmlString xmlString, out LevelGiftDefinition data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001AF8 RID: 6904 RVA: 0x00033D24 File Offset: 0x00032D24
		public static bool Reader(XmlString xmlString, out List<LevelGiftDefinition> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfLevelGiftDefinition"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<LevelGiftDefinition>();
						if (XSD2CPP.ReadArrayOfLevelGiftDefinitionClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x00033D80 File Offset: 0x00032D80
		public static bool ReadArrayOfLevelGiftDefinition(XmlString xmlString, out List<LevelGiftDefinition> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x00033D8C File Offset: 0x00032D8C
		private static void WriteLevelGiftDefinition(XmlParser doc, LevelGiftDefinition data)
		{
			doc.AddChild("Boost");
			Xsd2CppUtil.WriteInt(doc, data.Boost);
			doc.Parent();
			doc.AddChild("Level");
			Xsd2CppUtil.WriteInt(doc, data.Level);
			doc.Parent();
			doc.AddChild("LevelGiftId");
			Xsd2CppUtil.WriteInt(doc, data.LevelGiftId);
			doc.Parent();
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x00033DFC File Offset: 0x00032DFC
		private static void WriteArrayOfLevelGiftDefinition(XmlParser doc, List<LevelGiftDefinition> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("LevelGiftDefinition");
				XSD2CPP.WriteLevelGiftDefinition(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x00033E3C File Offset: 0x00032E3C
		public static bool WriterXML(LevelGiftDefinition data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("LevelGiftDefinition");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Gift");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteLevelGiftDefinition(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x00033E8D File Offset: 0x00032E8D
		public static bool Writer(LevelGiftDefinition data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x00033E96 File Offset: 0x00032E96
		public static bool WriteLevelGiftDefinition(LevelGiftDefinition data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001AFF RID: 6911 RVA: 0x00033EA0 File Offset: 0x00032EA0
		public static bool WriterXML(List<LevelGiftDefinition> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfLevelGiftDefinition");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Gift");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfLevelGiftDefinition(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001B00 RID: 6912 RVA: 0x00033EF1 File Offset: 0x00032EF1
		public static bool Writer(List<LevelGiftDefinition> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x00033EFA File Offset: 0x00032EFA
		public static bool WriteArrayOfLevelGiftDefinition(List<LevelGiftDefinition> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x00033F04 File Offset: 0x00032F04
		public static bool ReadLoginAnnouncementsModifiedMsgClass(XmlParser doc, LoginAnnouncementsModifiedMsg data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.LoginAnnouncement");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadLoginAnnouncementsModifiedMsg(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x00033F4C File Offset: 0x00032F4C
		public static bool ReadLoginAnnouncementsDefinitionClass(XmlParser doc, LoginAnnouncementsDefinition data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.LoginAnnouncement");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadLoginAnnouncementsDefinition(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x00033F94 File Offset: 0x00032F94
		public static bool ReadLoginAnnouncementDefinitionClass(XmlParser doc, LoginAnnouncementDefinition data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.LoginAnnouncement");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadLoginAnnouncementDefinition(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x00033FDC File Offset: 0x00032FDC
		public static bool ReadArrayOfLoginAnnouncementDefinitionClass(XmlParser doc, List<LoginAnnouncementDefinition> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.LoginAnnouncement");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfLoginAnnouncementDefinition(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x00034024 File Offset: 0x00033024
		private static bool ReadLoginAnnouncementsModifiedMsg(XmlParser doc, LoginAnnouncementsModifiedMsg data, string prefix)
		{
			return !(doc == null);
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x00034034 File Offset: 0x00033034
		private static bool ReadLoginAnnouncementsDefinition(XmlParser doc, LoginAnnouncementsDefinition data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "Announcements";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.Announcements = new List<LoginAnnouncementDefinition>();
				XSD2CPP.ReadArrayOfLoginAnnouncementDefinitionClass(doc, data.Announcements);
			}
			doc.Parent();
			pName = prefix + "ImagesPath";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.ImagesPath);
			}
			return true;
		}

		// Token: 0x06001B08 RID: 6920 RVA: 0x000340B4 File Offset: 0x000330B4
		private static bool ReadLoginAnnouncementDefinition(XmlParser doc, LoginAnnouncementDefinition data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "Context";
			if (doc.FirstChild(pName))
			{
				XSD2CPP.ReadLoginAnnouncementContext(doc, out data.Context);
			}
			doc.Parent();
			pName = prefix + "Id";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Id);
			}
			doc.Parent();
			pName = prefix + "ImageChecksum";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.ImageChecksum);
			}
			doc.Parent();
			pName = prefix + "ImageUrl";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.ImageUrl);
			}
			doc.Parent();
			pName = prefix + "Target";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Target);
			}
			doc.Parent();
			pName = prefix + "Type";
			if (doc.FirstChild(pName))
			{
				XSD2CPP.ReadLoginAnnouncementType(doc, out data.Type);
			}
			return true;
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x000341C4 File Offset: 0x000331C4
		private static bool ReadArrayOfLoginAnnouncementDefinition(XmlParser doc, List<LoginAnnouncementDefinition> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "LoginAnnouncementDefinition";
			}
			for (;;)
			{
				LoginAnnouncementDefinition loginAnnouncementDefinition = new LoginAnnouncementDefinition();
				if (!XSD2CPP.ReadLoginAnnouncementDefinitionClass(doc, loginAnnouncementDefinition))
				{
					break;
				}
				data.Add(loginAnnouncementDefinition);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001B0A RID: 6922 RVA: 0x00034214 File Offset: 0x00033214
		public static bool Reader(XmlString xmlString, out LoginAnnouncementsModifiedMsg data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "LoginAnnouncementsModifiedMsg"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new LoginAnnouncementsModifiedMsg();
						if (XSD2CPP.ReadLoginAnnouncementsModifiedMsgClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001B0B RID: 6923 RVA: 0x00034270 File Offset: 0x00033270
		public static bool ReadLoginAnnouncementsModifiedMsg(XmlString xmlString, out LoginAnnouncementsModifiedMsg data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x0003427C File Offset: 0x0003327C
		public static bool Reader(XmlString xmlString, out LoginAnnouncementsDefinition data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "LoginAnnouncementsDefinition"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new LoginAnnouncementsDefinition();
						if (XSD2CPP.ReadLoginAnnouncementsDefinitionClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x000342D8 File Offset: 0x000332D8
		public static bool ReadLoginAnnouncementsDefinition(XmlString xmlString, out LoginAnnouncementsDefinition data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x000342E4 File Offset: 0x000332E4
		public static bool Reader(XmlString xmlString, out LoginAnnouncementDefinition data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "LoginAnnouncementDefinition"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new LoginAnnouncementDefinition();
						if (XSD2CPP.ReadLoginAnnouncementDefinitionClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x00034340 File Offset: 0x00033340
		public static bool ReadLoginAnnouncementDefinition(XmlString xmlString, out LoginAnnouncementDefinition data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001B10 RID: 6928 RVA: 0x0003434C File Offset: 0x0003334C
		public static bool Reader(XmlString xmlString, out List<LoginAnnouncementDefinition> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfLoginAnnouncementDefinition"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<LoginAnnouncementDefinition>();
						if (XSD2CPP.ReadArrayOfLoginAnnouncementDefinitionClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x000343A8 File Offset: 0x000333A8
		public static bool ReadArrayOfLoginAnnouncementDefinition(XmlString xmlString, out List<LoginAnnouncementDefinition> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001B12 RID: 6930 RVA: 0x000343B1 File Offset: 0x000333B1
		private static void WriteLoginAnnouncementsModifiedMsg(XmlParser doc, LoginAnnouncementsModifiedMsg data)
		{
		}

		// Token: 0x06001B13 RID: 6931 RVA: 0x000343B4 File Offset: 0x000333B4
		private static void WriteLoginAnnouncementsDefinition(XmlParser doc, LoginAnnouncementsDefinition data)
		{
			doc.AddChild("Announcements");
			XSD2CPP.WriteArrayOfLoginAnnouncementDefinition(doc, data.Announcements);
			doc.Parent();
			doc.AddChild("ImagesPath");
			Xsd2CppUtil.WriteString(doc, data.ImagesPath);
			doc.Parent();
		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x00034400 File Offset: 0x00033400
		private static void WriteLoginAnnouncementDefinition(XmlParser doc, LoginAnnouncementDefinition data)
		{
			doc.AddChild("Context");
			XSD2CPP.WriteLoginAnnouncementContext(doc, data.Context);
			doc.Parent();
			doc.AddChild("Id");
			Xsd2CppUtil.WriteInt(doc, data.Id);
			doc.Parent();
			doc.AddChild("ImageChecksum");
			Xsd2CppUtil.WriteInt(doc, data.ImageChecksum);
			doc.Parent();
			doc.AddChild("ImageUrl");
			Xsd2CppUtil.WriteString(doc, data.ImageUrl);
			doc.Parent();
			doc.AddChild("Target");
			Xsd2CppUtil.WriteString(doc, data.Target);
			doc.Parent();
			doc.AddChild("Type");
			XSD2CPP.WriteLoginAnnouncementType(doc, data.Type);
			doc.Parent();
		}

		// Token: 0x06001B15 RID: 6933 RVA: 0x000344CC File Offset: 0x000334CC
		private static void WriteArrayOfLoginAnnouncementDefinition(XmlParser doc, List<LoginAnnouncementDefinition> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("LoginAnnouncementDefinition");
				XSD2CPP.WriteLoginAnnouncementDefinition(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001B16 RID: 6934 RVA: 0x0003450C File Offset: 0x0003350C
		public static bool WriterXML(LoginAnnouncementsModifiedMsg data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("LoginAnnouncementsModifiedMsg");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.LoginAnnouncement");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteLoginAnnouncementsModifiedMsg(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001B17 RID: 6935 RVA: 0x0003455D File Offset: 0x0003355D
		public static bool Writer(LoginAnnouncementsModifiedMsg data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x00034566 File Offset: 0x00033566
		public static bool WriteLoginAnnouncementsModifiedMsg(LoginAnnouncementsModifiedMsg data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x00034570 File Offset: 0x00033570
		public static bool WriterXML(LoginAnnouncementsDefinition data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("LoginAnnouncementsDefinition");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.LoginAnnouncement");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteLoginAnnouncementsDefinition(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001B1A RID: 6938 RVA: 0x000345C1 File Offset: 0x000335C1
		public static bool Writer(LoginAnnouncementsDefinition data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001B1B RID: 6939 RVA: 0x000345CA File Offset: 0x000335CA
		public static bool WriteLoginAnnouncementsDefinition(LoginAnnouncementsDefinition data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x000345D4 File Offset: 0x000335D4
		public static bool WriterXML(LoginAnnouncementDefinition data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("LoginAnnouncementDefinition");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.LoginAnnouncement");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteLoginAnnouncementDefinition(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001B1D RID: 6941 RVA: 0x00034625 File Offset: 0x00033625
		public static bool Writer(LoginAnnouncementDefinition data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001B1E RID: 6942 RVA: 0x0003462E File Offset: 0x0003362E
		public static bool WriteLoginAnnouncementDefinition(LoginAnnouncementDefinition data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x00034638 File Offset: 0x00033638
		public static bool WriterXML(List<LoginAnnouncementDefinition> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfLoginAnnouncementDefinition");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.LoginAnnouncement");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfLoginAnnouncementDefinition(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x00034689 File Offset: 0x00033689
		public static bool Writer(List<LoginAnnouncementDefinition> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x00034692 File Offset: 0x00033692
		public static bool WriteArrayOfLoginAnnouncementDefinition(List<LoginAnnouncementDefinition> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x0003469C File Offset: 0x0003369C
		public static bool ReadPowerupActivatedClass(XmlParser doc, PowerupActivated data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.PowerUp");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadPowerupActivated(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x000346E4 File Offset: 0x000336E4
		private static bool ReadPowerupActivated(XmlParser doc, PowerupActivated data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "Count";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Count);
			}
			doc.Parent();
			pName = prefix + "Id";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Id);
			}
			doc.Parent();
			pName = prefix + "PersonaId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.PersonaId);
			}
			doc.Parent();
			pName = prefix + "TargetPersonaId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.TargetPersonaId);
			}
			return true;
		}

		// Token: 0x06001B24 RID: 6948 RVA: 0x000347A4 File Offset: 0x000337A4
		public static bool Reader(XmlString xmlString, out PowerupActivated data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "PowerupActivated"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new PowerupActivated();
						if (XSD2CPP.ReadPowerupActivatedClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001B25 RID: 6949 RVA: 0x00034800 File Offset: 0x00033800
		public static bool ReadPowerupActivated(XmlString xmlString, out PowerupActivated data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001B26 RID: 6950 RVA: 0x0003480C File Offset: 0x0003380C
		private static void WritePowerupActivated(XmlParser doc, PowerupActivated data)
		{
			doc.AddChild("Count");
			Xsd2CppUtil.WriteInt(doc, data.Count);
			doc.Parent();
			doc.AddChild("Id");
			Xsd2CppUtil.WriteInt(doc, data.Id);
			doc.Parent();
			doc.AddChild("PersonaId");
			Xsd2CppUtil.WriteLong(doc, data.PersonaId);
			doc.Parent();
			doc.AddChild("TargetPersonaId");
			Xsd2CppUtil.WriteLong(doc, data.TargetPersonaId);
			doc.Parent();
		}

		// Token: 0x06001B27 RID: 6951 RVA: 0x0003489C File Offset: 0x0003389C
		public static bool WriterXML(PowerupActivated data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("PowerupActivated");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.PowerUp");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WritePowerupActivated(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001B28 RID: 6952 RVA: 0x000348ED File Offset: 0x000338ED
		public static bool Writer(PowerupActivated data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x000348F6 File Offset: 0x000338F6
		public static bool WritePowerupActivated(PowerupActivated data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001B2A RID: 6954 RVA: 0x00034900 File Offset: 0x00033900
		public static bool ReadUnblockPlayerMsgClass(XmlParser doc, UnblockPlayerMsg data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Social");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadUnblockPlayerMsg(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x00034948 File Offset: 0x00033948
		public static bool ReadRemoveFriendMsgClass(XmlParser doc, RemoveFriendMsg data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Social");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadRemoveFriendMsg(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x00034990 File Offset: 0x00033990
		public static bool ReadBlockPlayerMsgClass(XmlParser doc, BlockPlayerMsg data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Social");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadBlockPlayerMsg(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B2D RID: 6957 RVA: 0x000349D8 File Offset: 0x000339D8
		public static bool ReadBasicBlockPlayerInfoClass(XmlParser doc, BasicBlockPlayerInfo data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Social");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadBasicBlockPlayerInfo(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B2E RID: 6958 RVA: 0x00034A20 File Offset: 0x00033A20
		public static bool ReadArrayOfBasicBlockPlayerInfoClass(XmlParser doc, List<BasicBlockPlayerInfo> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Social");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfBasicBlockPlayerInfo(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B2F RID: 6959 RVA: 0x00034A68 File Offset: 0x00033A68
		public static bool ReadSocialSettingsClass(XmlParser doc, SocialSettings data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Social");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadSocialSettings(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B30 RID: 6960 RVA: 0x00034AB0 File Offset: 0x00033AB0
		public static bool ReadUserPersonaMapListClass(XmlParser doc, UserPersonaMapList data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Social");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadUserPersonaMapList(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x00034AF8 File Offset: 0x00033AF8
		public static bool ReadUserPersonaMapClass(XmlParser doc, UserPersonaMap data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Social");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadUserPersonaMap(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B32 RID: 6962 RVA: 0x00034B40 File Offset: 0x00033B40
		public static bool ReadArrayOfUserPersonaMapClass(XmlParser doc, List<UserPersonaMap> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Social");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfUserPersonaMap(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x00034B88 File Offset: 0x00033B88
		public static bool ReadSocialNetworkInfoClass(XmlParser doc, SocialNetworkInfo data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Social");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadSocialNetworkInfo(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B34 RID: 6964 RVA: 0x00034BD0 File Offset: 0x00033BD0
		private static bool ReadUnblockPlayerMsg(XmlParser doc, UnblockPlayerMsg data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "userId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.userId);
			}
			return true;
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x00034C14 File Offset: 0x00033C14
		private static bool ReadRemoveFriendMsg(XmlParser doc, RemoveFriendMsg data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "personaId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.personaId);
			}
			return true;
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x00034C58 File Offset: 0x00033C58
		private static bool ReadBlockPlayerMsg(XmlParser doc, BlockPlayerMsg data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "userId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.userId);
			}
			return true;
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x00034C9C File Offset: 0x00033C9C
		private static bool ReadBasicBlockPlayerInfo(XmlParser doc, BasicBlockPlayerInfo data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "personaId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.personaId);
			}
			doc.Parent();
			pName = prefix + "userId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.userId);
			}
			return true;
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x00034D08 File Offset: 0x00033D08
		private static bool ReadArrayOfBasicBlockPlayerInfo(XmlParser doc, List<BasicBlockPlayerInfo> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "BasicBlockPlayerInfo";
			}
			for (;;)
			{
				BasicBlockPlayerInfo basicBlockPlayerInfo = new BasicBlockPlayerInfo();
				if (!XSD2CPP.ReadBasicBlockPlayerInfoClass(doc, basicBlockPlayerInfo))
				{
					break;
				}
				data.Add(basicBlockPlayerInfo);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x00034D58 File Offset: 0x00033D58
		private static bool ReadSocialSettings(XmlParser doc, SocialSettings data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "AppearOffline";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.AppearOffline);
			}
			doc.Parent();
			pName = prefix + "DeclineGroupInvite";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.DeclineGroupInvite);
			}
			doc.Parent();
			pName = prefix + "DeclineIncommingFriendRequests";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.DeclineIncommingFriendRequests);
			}
			doc.Parent();
			pName = prefix + "DeclinePrivateInvite";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.DeclinePrivateInvite);
			}
			doc.Parent();
			pName = prefix + "HideOfflineFriends";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.HideOfflineFriends);
			}
			doc.Parent();
			pName = prefix + "ShowNewsOnSignIn";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.ShowNewsOnSignIn);
			}
			doc.Parent();
			pName = prefix + "ShowOnlyPlayersInSameChatChannel";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.ShowOnlyPlayersInSameChatChannel);
			}
			return true;
		}

		// Token: 0x06001B3A RID: 6970 RVA: 0x00034E90 File Offset: 0x00033E90
		private static bool ReadUserPersonaMapList(XmlParser doc, UserPersonaMapList data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "map";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.map = new List<UserPersonaMap>();
				XSD2CPP.ReadArrayOfUserPersonaMapClass(doc, data.map);
			}
			return true;
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x00034EE8 File Offset: 0x00033EE8
		private static bool ReadUserPersonaMap(XmlParser doc, UserPersonaMap data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "personaId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.personaId);
			}
			doc.Parent();
			pName = prefix + "userId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.userId);
			}
			return true;
		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x00034F54 File Offset: 0x00033F54
		private static bool ReadArrayOfUserPersonaMap(XmlParser doc, List<UserPersonaMap> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "UserPersonaMap";
			}
			for (;;)
			{
				UserPersonaMap userPersonaMap = new UserPersonaMap();
				if (!XSD2CPP.ReadUserPersonaMapClass(doc, userPersonaMap))
				{
					break;
				}
				data.Add(userPersonaMap);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x00034FA4 File Offset: 0x00033FA4
		private static bool ReadSocialNetworkInfo(XmlParser doc, SocialNetworkInfo data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "facebookName";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.facebookName);
			}
			return true;
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x00034FE8 File Offset: 0x00033FE8
		public static bool Reader(XmlString xmlString, out UnblockPlayerMsg data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "UnblockPlayerMsg"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new UnblockPlayerMsg();
						if (XSD2CPP.ReadUnblockPlayerMsgClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x00035044 File Offset: 0x00034044
		public static bool ReadUnblockPlayerMsg(XmlString xmlString, out UnblockPlayerMsg data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x00035050 File Offset: 0x00034050
		public static bool Reader(XmlString xmlString, out RemoveFriendMsg data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "RemoveFriendMsg"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new RemoveFriendMsg();
						if (XSD2CPP.ReadRemoveFriendMsgClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x000350AC File Offset: 0x000340AC
		public static bool ReadRemoveFriendMsg(XmlString xmlString, out RemoveFriendMsg data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x000350B8 File Offset: 0x000340B8
		public static bool Reader(XmlString xmlString, out BlockPlayerMsg data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "BlockPlayerMsg"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new BlockPlayerMsg();
						if (XSD2CPP.ReadBlockPlayerMsgClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x00035114 File Offset: 0x00034114
		public static bool ReadBlockPlayerMsg(XmlString xmlString, out BlockPlayerMsg data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x00035120 File Offset: 0x00034120
		public static bool Reader(XmlString xmlString, out BasicBlockPlayerInfo data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "BasicBlockPlayerInfo"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new BasicBlockPlayerInfo();
						if (XSD2CPP.ReadBasicBlockPlayerInfoClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x0003517C File Offset: 0x0003417C
		public static bool ReadBasicBlockPlayerInfo(XmlString xmlString, out BasicBlockPlayerInfo data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x00035188 File Offset: 0x00034188
		public static bool Reader(XmlString xmlString, out List<BasicBlockPlayerInfo> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfBasicBlockPlayerInfo"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<BasicBlockPlayerInfo>();
						if (XSD2CPP.ReadArrayOfBasicBlockPlayerInfoClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x000351E4 File Offset: 0x000341E4
		public static bool ReadArrayOfBasicBlockPlayerInfo(XmlString xmlString, out List<BasicBlockPlayerInfo> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x000351F0 File Offset: 0x000341F0
		public static bool Reader(XmlString xmlString, out SocialSettings data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "SocialSettings"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new SocialSettings();
						if (XSD2CPP.ReadSocialSettingsClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x0003524C File Offset: 0x0003424C
		public static bool ReadSocialSettings(XmlString xmlString, out SocialSettings data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x00035258 File Offset: 0x00034258
		public static bool Reader(XmlString xmlString, out UserPersonaMapList data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "UserPersonaMapList"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new UserPersonaMapList();
						if (XSD2CPP.ReadUserPersonaMapListClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001B4B RID: 6987 RVA: 0x000352B4 File Offset: 0x000342B4
		public static bool ReadUserPersonaMapList(XmlString xmlString, out UserPersonaMapList data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001B4C RID: 6988 RVA: 0x000352C0 File Offset: 0x000342C0
		public static bool Reader(XmlString xmlString, out UserPersonaMap data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "UserPersonaMap"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new UserPersonaMap();
						if (XSD2CPP.ReadUserPersonaMapClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x0003531C File Offset: 0x0003431C
		public static bool ReadUserPersonaMap(XmlString xmlString, out UserPersonaMap data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x00035328 File Offset: 0x00034328
		public static bool Reader(XmlString xmlString, out List<UserPersonaMap> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfUserPersonaMap"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<UserPersonaMap>();
						if (XSD2CPP.ReadArrayOfUserPersonaMapClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x00035384 File Offset: 0x00034384
		public static bool ReadArrayOfUserPersonaMap(XmlString xmlString, out List<UserPersonaMap> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x00035390 File Offset: 0x00034390
		public static bool Reader(XmlString xmlString, out SocialNetworkInfo data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "SocialNetworkInfo"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new SocialNetworkInfo();
						if (XSD2CPP.ReadSocialNetworkInfoClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x000353EC File Offset: 0x000343EC
		public static bool ReadSocialNetworkInfo(XmlString xmlString, out SocialNetworkInfo data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x000353F5 File Offset: 0x000343F5
		private static void WriteUnblockPlayerMsg(XmlParser doc, UnblockPlayerMsg data)
		{
			doc.AddChild("userId");
			Xsd2CppUtil.WriteLong(doc, data.userId);
			doc.Parent();
		}

		// Token: 0x06001B53 RID: 6995 RVA: 0x00035417 File Offset: 0x00034417
		private static void WriteRemoveFriendMsg(XmlParser doc, RemoveFriendMsg data)
		{
			doc.AddChild("personaId");
			Xsd2CppUtil.WriteLong(doc, data.personaId);
			doc.Parent();
		}

		// Token: 0x06001B54 RID: 6996 RVA: 0x00035439 File Offset: 0x00034439
		private static void WriteBlockPlayerMsg(XmlParser doc, BlockPlayerMsg data)
		{
			doc.AddChild("userId");
			Xsd2CppUtil.WriteLong(doc, data.userId);
			doc.Parent();
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x0003545C File Offset: 0x0003445C
		private static void WriteBasicBlockPlayerInfo(XmlParser doc, BasicBlockPlayerInfo data)
		{
			doc.AddChild("personaId");
			Xsd2CppUtil.WriteLong(doc, data.personaId);
			doc.Parent();
			doc.AddChild("userId");
			Xsd2CppUtil.WriteLong(doc, data.userId);
			doc.Parent();
		}

		// Token: 0x06001B56 RID: 6998 RVA: 0x000354AC File Offset: 0x000344AC
		private static void WriteArrayOfBasicBlockPlayerInfo(XmlParser doc, List<BasicBlockPlayerInfo> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("BasicBlockPlayerInfo");
				XSD2CPP.WriteBasicBlockPlayerInfo(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001B57 RID: 6999 RVA: 0x000354EC File Offset: 0x000344EC
		private static void WriteSocialSettings(XmlParser doc, SocialSettings data)
		{
			doc.AddChild("AppearOffline");
			Xsd2CppUtil.WriteBoolean(doc, data.AppearOffline);
			doc.Parent();
			doc.AddChild("DeclineGroupInvite");
			Xsd2CppUtil.WriteInt(doc, data.DeclineGroupInvite);
			doc.Parent();
			doc.AddChild("DeclineIncommingFriendRequests");
			Xsd2CppUtil.WriteBoolean(doc, data.DeclineIncommingFriendRequests);
			doc.Parent();
			doc.AddChild("DeclinePrivateInvite");
			Xsd2CppUtil.WriteInt(doc, data.DeclinePrivateInvite);
			doc.Parent();
			doc.AddChild("HideOfflineFriends");
			Xsd2CppUtil.WriteBoolean(doc, data.HideOfflineFriends);
			doc.Parent();
			doc.AddChild("ShowNewsOnSignIn");
			Xsd2CppUtil.WriteBoolean(doc, data.ShowNewsOnSignIn);
			doc.Parent();
			doc.AddChild("ShowOnlyPlayersInSameChatChannel");
			Xsd2CppUtil.WriteBoolean(doc, data.ShowOnlyPlayersInSameChatChannel);
			doc.Parent();
		}

		// Token: 0x06001B58 RID: 7000 RVA: 0x000355D9 File Offset: 0x000345D9
		private static void WriteUserPersonaMapList(XmlParser doc, UserPersonaMapList data)
		{
			doc.AddChild("map");
			XSD2CPP.WriteArrayOfUserPersonaMap(doc, data.map);
			doc.Parent();
		}

		// Token: 0x06001B59 RID: 7001 RVA: 0x000355FC File Offset: 0x000345FC
		private static void WriteUserPersonaMap(XmlParser doc, UserPersonaMap data)
		{
			doc.AddChild("personaId");
			Xsd2CppUtil.WriteLong(doc, data.personaId);
			doc.Parent();
			doc.AddChild("userId");
			Xsd2CppUtil.WriteLong(doc, data.userId);
			doc.Parent();
		}

		// Token: 0x06001B5A RID: 7002 RVA: 0x0003564C File Offset: 0x0003464C
		private static void WriteArrayOfUserPersonaMap(XmlParser doc, List<UserPersonaMap> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("UserPersonaMap");
				XSD2CPP.WriteUserPersonaMap(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001B5B RID: 7003 RVA: 0x0003568A File Offset: 0x0003468A
		private static void WriteSocialNetworkInfo(XmlParser doc, SocialNetworkInfo data)
		{
			doc.AddChild("facebookName");
			Xsd2CppUtil.WriteString(doc, data.facebookName);
			doc.Parent();
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x000356AC File Offset: 0x000346AC
		public static bool WriterXML(UnblockPlayerMsg data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("UnblockPlayerMsg");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Social");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteUnblockPlayerMsg(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001B5D RID: 7005 RVA: 0x000356FD File Offset: 0x000346FD
		public static bool Writer(UnblockPlayerMsg data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001B5E RID: 7006 RVA: 0x00035706 File Offset: 0x00034706
		public static bool WriteUnblockPlayerMsg(UnblockPlayerMsg data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001B5F RID: 7007 RVA: 0x00035710 File Offset: 0x00034710
		public static bool WriterXML(RemoveFriendMsg data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("RemoveFriendMsg");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Social");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteRemoveFriendMsg(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001B60 RID: 7008 RVA: 0x00035761 File Offset: 0x00034761
		public static bool Writer(RemoveFriendMsg data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x0003576A File Offset: 0x0003476A
		public static bool WriteRemoveFriendMsg(RemoveFriendMsg data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x00035774 File Offset: 0x00034774
		public static bool WriterXML(BlockPlayerMsg data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("BlockPlayerMsg");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Social");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteBlockPlayerMsg(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x000357C5 File Offset: 0x000347C5
		public static bool Writer(BlockPlayerMsg data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x000357CE File Offset: 0x000347CE
		public static bool WriteBlockPlayerMsg(BlockPlayerMsg data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x000357D8 File Offset: 0x000347D8
		public static bool WriterXML(BasicBlockPlayerInfo data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("BasicBlockPlayerInfo");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Social");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteBasicBlockPlayerInfo(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x00035829 File Offset: 0x00034829
		public static bool Writer(BasicBlockPlayerInfo data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x00035832 File Offset: 0x00034832
		public static bool WriteBasicBlockPlayerInfo(BasicBlockPlayerInfo data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x0003583C File Offset: 0x0003483C
		public static bool WriterXML(List<BasicBlockPlayerInfo> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfBasicBlockPlayerInfo");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Social");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfBasicBlockPlayerInfo(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001B69 RID: 7017 RVA: 0x0003588D File Offset: 0x0003488D
		public static bool Writer(List<BasicBlockPlayerInfo> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001B6A RID: 7018 RVA: 0x00035896 File Offset: 0x00034896
		public static bool WriteArrayOfBasicBlockPlayerInfo(List<BasicBlockPlayerInfo> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001B6B RID: 7019 RVA: 0x000358A0 File Offset: 0x000348A0
		public static bool WriterXML(SocialSettings data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("SocialSettings");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Social");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteSocialSettings(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001B6C RID: 7020 RVA: 0x000358F1 File Offset: 0x000348F1
		public static bool Writer(SocialSettings data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001B6D RID: 7021 RVA: 0x000358FA File Offset: 0x000348FA
		public static bool WriteSocialSettings(SocialSettings data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001B6E RID: 7022 RVA: 0x00035904 File Offset: 0x00034904
		public static bool WriterXML(UserPersonaMapList data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("UserPersonaMapList");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Social");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteUserPersonaMapList(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x00035955 File Offset: 0x00034955
		public static bool Writer(UserPersonaMapList data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x0003595E File Offset: 0x0003495E
		public static bool WriteUserPersonaMapList(UserPersonaMapList data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x00035968 File Offset: 0x00034968
		public static bool WriterXML(UserPersonaMap data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("UserPersonaMap");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Social");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteUserPersonaMap(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x000359B9 File Offset: 0x000349B9
		public static bool Writer(UserPersonaMap data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x000359C2 File Offset: 0x000349C2
		public static bool WriteUserPersonaMap(UserPersonaMap data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x000359CC File Offset: 0x000349CC
		public static bool WriterXML(List<UserPersonaMap> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfUserPersonaMap");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Social");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfUserPersonaMap(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x00035A1D File Offset: 0x00034A1D
		public static bool Writer(List<UserPersonaMap> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x00035A26 File Offset: 0x00034A26
		public static bool WriteArrayOfUserPersonaMap(List<UserPersonaMap> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x00035A30 File Offset: 0x00034A30
		public static bool WriterXML(SocialNetworkInfo data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("SocialNetworkInfo");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Social");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteSocialNetworkInfo(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x00035A81 File Offset: 0x00034A81
		public static bool Writer(SocialNetworkInfo data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001B79 RID: 7033 RVA: 0x00035A8A File Offset: 0x00034A8A
		public static bool WriteSocialNetworkInfo(SocialNetworkInfo data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001B7A RID: 7034 RVA: 0x00035A94 File Offset: 0x00034A94
		public static bool ReadClientLogClass(XmlParser doc, ClientLog data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadClientLog(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B7B RID: 7035 RVA: 0x00035ADC File Offset: 0x00034ADC
		public static bool ReadBasketTransClass(XmlParser doc, BasketTrans data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadBasketTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B7C RID: 7036 RVA: 0x00035B24 File Offset: 0x00034B24
		public static bool ReadCommerceItemTransClass(XmlParser doc, CommerceItemTrans data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadCommerceItemTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B7D RID: 7037 RVA: 0x00035B6C File Offset: 0x00034B6C
		public static bool ReadArrayOfCommerceItemTransClass(XmlParser doc, List<CommerceItemTrans> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfCommerceItemTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x00035BB4 File Offset: 0x00034BB4
		public static bool ReadInvalidBasketTransClass(XmlParser doc, InvalidBasketTrans data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadInvalidBasketTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x00035BFC File Offset: 0x00034BFC
		public static bool ReadCommerceResultTransClass(XmlParser doc, CommerceResultTrans data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadCommerceResultTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x00035C44 File Offset: 0x00034C44
		public static bool ReadBasketItemTransClass(XmlParser doc, BasketItemTrans data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadBasketItemTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x00035C8C File Offset: 0x00034C8C
		public static bool ReadArrayOfBasketItemTransClass(XmlParser doc, List<BasketItemTrans> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfBasketItemTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x00035CD4 File Offset: 0x00034CD4
		public static bool ReadInvalidBasketItemTransClass(XmlParser doc, InvalidBasketItemTrans data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadInvalidBasketItemTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x00035D1C File Offset: 0x00034D1C
		public static bool ReadArrayOfInvalidBasketItemTransClass(XmlParser doc, List<InvalidBasketItemTrans> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfInvalidBasketItemTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x00035D64 File Offset: 0x00034D64
		public static bool ReadInventoryItemTransClass(XmlParser doc, InventoryItemTrans data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadInventoryItemTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x00035DAC File Offset: 0x00034DAC
		public static bool ReadArrayOfInventoryItemTransClass(XmlParser doc, List<InventoryItemTrans> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfInventoryItemTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x00035DF4 File Offset: 0x00034DF4
		public static bool ReadCustomCarTransClass(XmlParser doc, CustomCarTrans data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadCustomCarTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x00035E3C File Offset: 0x00034E3C
		public static bool ReadOwnedCarTransClass(XmlParser doc, OwnedCarTrans data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadOwnedCarTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x00035E84 File Offset: 0x00034E84
		public static bool ReadArrayOfOwnedCarTransClass(XmlParser doc, List<OwnedCarTrans> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfOwnedCarTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x00035ECC File Offset: 0x00034ECC
		public static bool ReadCustomPaintTransClass(XmlParser doc, CustomPaintTrans data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadCustomPaintTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x00035F14 File Offset: 0x00034F14
		public static bool ReadArrayOfCustomPaintTransClass(XmlParser doc, List<CustomPaintTrans> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfCustomPaintTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x00035F5C File Offset: 0x00034F5C
		public static bool ReadPerformancePartTransClass(XmlParser doc, PerformancePartTrans data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadPerformancePartTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x00035FA4 File Offset: 0x00034FA4
		public static bool ReadArrayOfPerformancePartTransClass(XmlParser doc, List<PerformancePartTrans> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfPerformancePartTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x00035FEC File Offset: 0x00034FEC
		public static bool ReadSkillModPartTransClass(XmlParser doc, SkillModPartTrans data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadSkillModPartTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x00036034 File Offset: 0x00035034
		public static bool ReadArrayOfSkillModPartTransClass(XmlParser doc, List<SkillModPartTrans> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfSkillModPartTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x0003607C File Offset: 0x0003507C
		public static bool ReadCustomVinylTransClass(XmlParser doc, CustomVinylTrans data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadCustomVinylTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x000360C4 File Offset: 0x000350C4
		public static bool ReadArrayOfCustomVinylTransClass(XmlParser doc, List<CustomVinylTrans> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfCustomVinylTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x0003610C File Offset: 0x0003510C
		public static bool ReadVisualPartTransClass(XmlParser doc, VisualPartTrans data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadVisualPartTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x00036154 File Offset: 0x00035154
		public static bool ReadArrayOfVisualPartTransClass(XmlParser doc, List<VisualPartTrans> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfVisualPartTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x0003619C File Offset: 0x0003519C
		public static bool ReadWalletTransClass(XmlParser doc, WalletTrans data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadWalletTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x000361E4 File Offset: 0x000351E4
		public static bool ReadArrayOfWalletTransClass(XmlParser doc, List<WalletTrans> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfWalletTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x0003622C File Offset: 0x0003522C
		public static bool ReadCredentialsClass(XmlParser doc, Credentials data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadCredentials(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B96 RID: 7062 RVA: 0x00036274 File Offset: 0x00035274
		public static bool ReadTokenClass(XmlParser doc, Token data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadToken(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B97 RID: 7063 RVA: 0x000362BC File Offset: 0x000352BC
		public static bool ReadGetPermanentSessionDataClass(XmlParser doc, GetPermanentSessionData data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadGetPermanentSessionData(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x00036304 File Offset: 0x00035304
		public static bool ReadClientConfigTransClass(XmlParser doc, ClientConfigTrans data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadClientConfigTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x0003634C File Offset: 0x0003534C
		public static bool ReadClientConfigClass(XmlParser doc, ClientConfig data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadClientConfig(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B9A RID: 7066 RVA: 0x00036394 File Offset: 0x00035394
		public static bool ReadArrayOfClientConfigClass(XmlParser doc, List<ClientConfig> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfClientConfig(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B9B RID: 7067 RVA: 0x000363DC File Offset: 0x000353DC
		public static bool ReadUser_SettingsClass(XmlParser doc, User_Settings data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadUser_Settings(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B9C RID: 7068 RVA: 0x00036424 File Offset: 0x00035424
		public static bool ReadHardwareInfoClass(XmlParser doc, HardwareInfo data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadHardwareInfo(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B9D RID: 7069 RVA: 0x0003646C File Offset: 0x0003546C
		public static bool ReadUserSettingsClass(XmlParser doc, UserSettings data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadUserSettings(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x000364B4 File Offset: 0x000354B4
		public static bool ReadMachineIdentificationClass(XmlParser doc, MachineIdentification data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadMachineIdentification(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x000364FC File Offset: 0x000354FC
		public static bool ReadLauncherStartTransClass(XmlParser doc, LauncherStartTrans data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadLauncherStartTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001BA0 RID: 7072 RVA: 0x00036544 File Offset: 0x00035544
		public static bool ReadLauncherEndTransClass(XmlParser doc, LauncherEndTrans data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadLauncherEndTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001BA1 RID: 7073 RVA: 0x0003658C File Offset: 0x0003558C
		public static bool ReadVector3Class(XmlParser doc, Vector3 data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadVector3(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x000365D4 File Offset: 0x000355D4
		public static bool ReadHeartBeatClass(XmlParser doc, HeartBeat data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadHeartBeat(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001BA3 RID: 7075 RVA: 0x0003661C File Offset: 0x0003561C
		public static bool ReadFraudConfigClass(XmlParser doc, FraudConfig data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadFraudConfig(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x00036664 File Offset: 0x00035664
		public static bool ReadProductTransClass(XmlParser doc, ProductTrans data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadProductTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x000366AC File Offset: 0x000356AC
		public static bool ReadArrayOfProductTransClass(XmlParser doc, List<ProductTrans> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfProductTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x000366F4 File Offset: 0x000356F4
		public static bool ReadInventoryTransClass(XmlParser doc, InventoryTrans data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadInventoryTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x0003673C File Offset: 0x0003573C
		public static bool ReadEntitlementTransClass(XmlParser doc, EntitlementTrans data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadEntitlementTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x00036784 File Offset: 0x00035784
		public static bool ReadEntitlementItemTransClass(XmlParser doc, EntitlementItemTrans data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadEntitlementItemTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x000367CC File Offset: 0x000357CC
		public static bool ReadArrayOfEntitlementItemTransClass(XmlParser doc, List<EntitlementItemTrans> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfEntitlementItemTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x00036814 File Offset: 0x00035814
		public static bool ReadCategoryTransClass(XmlParser doc, CategoryTrans data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadCategoryTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x0003685C File Offset: 0x0003585C
		public static bool ReadArrayOfCategoryTransClass(XmlParser doc, List<CategoryTrans> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfCategoryTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x000368A4 File Offset: 0x000358A4
		public static bool ReadCommerceSessionTransClass(XmlParser doc, CommerceSessionTrans data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadCommerceSessionTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x000368EC File Offset: 0x000358EC
		public static bool ReadCommerceSessionResultTransClass(XmlParser doc, CommerceSessionResultTrans data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadCommerceSessionResultTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x00036934 File Offset: 0x00035934
		public static bool ReadClientServerCryptoTicketClass(XmlParser doc, ClientServerCryptoTicket data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadClientServerCryptoTicket(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x0003697C File Offset: 0x0003597C
		public static bool ReadUdpRelayCryptoTicketClass(XmlParser doc, UdpRelayCryptoTicket data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadUdpRelayCryptoTicket(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x000369C4 File Offset: 0x000359C4
		public static bool ReadUdpRelayInfoClass(XmlParser doc, UdpRelayInfo data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadUdpRelayInfo(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x00036A0C File Offset: 0x00035A0C
		public static bool ReadArrayOfUdpRelayInfoClass(XmlParser doc, List<UdpRelayInfo> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfUdpRelayInfo(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x00036A54 File Offset: 0x00035A54
		public static bool ReadRegionInfoClass(XmlParser doc, RegionInfo data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadRegionInfo(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x00036A9C File Offset: 0x00035A9C
		public static bool ReadCarSlotInfoTransClass(XmlParser doc, CarSlotInfoTrans data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadCarSlotInfoTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x00036AE4 File Offset: 0x00035AE4
		private static bool ReadMetagameFlagsAttribute(string pValue, out MetagameFlags data)
		{
			return MetagameFlagsConverter.Parse(pValue, out data);
		}

		// Token: 0x06001BB5 RID: 7093 RVA: 0x00036AF0 File Offset: 0x00035AF0
		private static bool ReadMetagameFlags(XmlParser doc, out MetagameFlags data)
		{
			string value = doc.GetValue();
			return MetagameFlagsConverter.Parse(value, out data);
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x00036B0B File Offset: 0x00035B0B
		private static bool ReadenumPowerUpTypeAttribute(string pValue, out enumPowerUpType data)
		{
			return enumPowerUpTypeConverter.Parse(pValue, out data);
		}

		// Token: 0x06001BB7 RID: 7095 RVA: 0x00036B14 File Offset: 0x00035B14
		private static bool ReadenumPowerUpType(XmlParser doc, out enumPowerUpType data)
		{
			string value = doc.GetValue();
			return enumPowerUpTypeConverter.Parse(value, out data);
		}

		// Token: 0x06001BB8 RID: 7096 RVA: 0x00036B2F File Offset: 0x00035B2F
		private static bool ReadCommerceResultStatusAttribute(string pValue, out CommerceResultStatus data)
		{
			return CommerceResultStatusConverter.Parse(pValue, out data);
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x00036B38 File Offset: 0x00035B38
		private static bool ReadCommerceResultStatus(XmlParser doc, out CommerceResultStatus data)
		{
			string value = doc.GetValue();
			return CommerceResultStatusConverter.Parse(value, out data);
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x00036B54 File Offset: 0x00035B54
		private static bool ReadClientLog(XmlParser doc, ClientLog data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "date";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadDateTime(doc, out data.date);
			}
			doc.Parent();
			pName = prefix + "message";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.message);
			}
			return true;
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x00036BC0 File Offset: 0x00035BC0
		private static bool ReadBasketTrans(XmlParser doc, BasketTrans data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "Items";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.Items = new List<BasketItemTrans>();
				XSD2CPP.ReadArrayOfBasketItemTransClass(doc, data.Items);
			}
			return true;
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x00036C18 File Offset: 0x00035C18
		private static bool ReadCommerceItemTrans(XmlParser doc, CommerceItemTrans data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "Hash";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Hash);
			}
			doc.Parent();
			pName = prefix + "Title";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Title);
			}
			return true;
		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x00036C84 File Offset: 0x00035C84
		private static bool ReadArrayOfCommerceItemTrans(XmlParser doc, List<CommerceItemTrans> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "CommerceItemTrans";
			}
			for (;;)
			{
				CommerceItemTrans commerceItemTrans = new CommerceItemTrans();
				if (!XSD2CPP.ReadCommerceItemTransClass(doc, commerceItemTrans))
				{
					break;
				}
				data.Add(commerceItemTrans);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x00036CD4 File Offset: 0x00035CD4
		private static bool ReadInvalidBasketTrans(XmlParser doc, InvalidBasketTrans data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "Basket";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.Basket = new BasketTrans();
				XSD2CPP.ReadBasketTransClass(doc, data.Basket);
			}
			doc.Parent();
			pName = prefix + "InvalidItems";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.InvalidItems = new List<InvalidBasketItemTrans>();
				XSD2CPP.ReadArrayOfInvalidBasketItemTransClass(doc, data.InvalidItems);
			}
			return true;
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x00036D68 File Offset: 0x00035D68
		private static bool ReadCommerceResultTrans(XmlParser doc, CommerceResultTrans data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "CommerceItems";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.CommerceItems = new List<CommerceItemTrans>();
				XSD2CPP.ReadArrayOfCommerceItemTransClass(doc, data.CommerceItems);
			}
			doc.Parent();
			pName = prefix + "InvalidBasket";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.InvalidBasket = new InvalidBasketTrans();
				XSD2CPP.ReadInvalidBasketTransClass(doc, data.InvalidBasket);
			}
			doc.Parent();
			pName = prefix + "InventoryItems";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.InventoryItems = new List<InventoryItemTrans>();
				XSD2CPP.ReadArrayOfInventoryItemTransClass(doc, data.InventoryItems);
			}
			doc.Parent();
			pName = prefix + "PurchasedCars";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.PurchasedCars = new List<OwnedCarTrans>();
				XSD2CPP.ReadArrayOfOwnedCarTransClass(doc, data.PurchasedCars);
			}
			doc.Parent();
			pName = prefix + "Status";
			if (doc.FirstChild(pName))
			{
				XSD2CPP.ReadCommerceResultStatus(doc, out data.Status);
			}
			doc.Parent();
			pName = prefix + "Wallets";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.Wallets = new List<WalletTrans>();
				XSD2CPP.ReadArrayOfWalletTransClass(doc, data.Wallets);
			}
			return true;
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x00036ED8 File Offset: 0x00035ED8
		private static bool ReadBasketItemTrans(XmlParser doc, BasketItemTrans data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "ProductId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.ProductId);
			}
			doc.Parent();
			pName = prefix + "Quantity";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Quantity);
			}
			return true;
		}

		// Token: 0x06001BC1 RID: 7105 RVA: 0x00036F44 File Offset: 0x00035F44
		private static bool ReadArrayOfBasketItemTrans(XmlParser doc, List<BasketItemTrans> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "BasketItemTrans";
			}
			for (;;)
			{
				BasketItemTrans basketItemTrans = new BasketItemTrans();
				if (!XSD2CPP.ReadBasketItemTransClass(doc, basketItemTrans))
				{
					break;
				}
				data.Add(basketItemTrans);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001BC2 RID: 7106 RVA: 0x00036F94 File Offset: 0x00035F94
		private static bool ReadInvalidBasketItemTrans(XmlParser doc, InvalidBasketItemTrans data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "Index";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Index);
			}
			doc.Parent();
			pName = prefix + "Reason";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Reason);
			}
			return true;
		}

		// Token: 0x06001BC3 RID: 7107 RVA: 0x00037000 File Offset: 0x00036000
		private static bool ReadArrayOfInvalidBasketItemTrans(XmlParser doc, List<InvalidBasketItemTrans> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "InvalidBasketItemTrans";
			}
			for (;;)
			{
				InvalidBasketItemTrans invalidBasketItemTrans = new InvalidBasketItemTrans();
				if (!XSD2CPP.ReadInvalidBasketItemTransClass(doc, invalidBasketItemTrans))
				{
					break;
				}
				data.Add(invalidBasketItemTrans);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001BC4 RID: 7108 RVA: 0x00037050 File Offset: 0x00036050
		private static bool ReadInventoryItemTrans(XmlParser doc, InventoryItemTrans data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "EntitlementTag";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.EntitlementTag);
			}
			doc.Parent();
			pName = prefix + "ExpirationDate";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadDateTime(doc, out data.ExpirationDate);
			}
			doc.Parent();
			pName = prefix + "Hash";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Hash);
			}
			doc.Parent();
			pName = prefix + "InventoryId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.InventoryId);
			}
			doc.Parent();
			pName = prefix + "ProductId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.ProductId);
			}
			doc.Parent();
			pName = prefix + "RemainingUseCount";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.RemainingUseCount);
			}
			doc.Parent();
			pName = prefix + "ResellPrice";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadDouble(doc, out data.ResellPrice);
			}
			doc.Parent();
			pName = prefix + "Status";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Status);
			}
			doc.Parent();
			pName = prefix + "StringHash";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.StringHash);
			}
			doc.Parent();
			pName = prefix + "VirtualItemType";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.VirtualItemType);
			}
			return true;
		}

		// Token: 0x06001BC5 RID: 7109 RVA: 0x00037204 File Offset: 0x00036204
		private static bool ReadArrayOfInventoryItemTrans(XmlParser doc, List<InventoryItemTrans> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "InventoryItemTrans";
			}
			for (;;)
			{
				InventoryItemTrans inventoryItemTrans = new InventoryItemTrans();
				if (!XSD2CPP.ReadInventoryItemTransClass(doc, inventoryItemTrans))
				{
					break;
				}
				data.Add(inventoryItemTrans);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001BC6 RID: 7110 RVA: 0x00037254 File Offset: 0x00036254
		private static bool ReadCustomCarTrans(XmlParser doc, CustomCarTrans data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "BaseCar";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.BaseCar);
			}
			doc.Parent();
			pName = prefix + "CarClassHash";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.CarClassHash);
			}
			doc.Parent();
			pName = prefix + "Id";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Id);
			}
			doc.Parent();
			pName = prefix + "IsPreset";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.IsPreset);
			}
			doc.Parent();
			pName = prefix + "Level";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Level);
			}
			doc.Parent();
			pName = prefix + "Name";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Name);
			}
			doc.Parent();
			pName = prefix + "Paints";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.Paints = new List<CustomPaintTrans>();
				XSD2CPP.ReadArrayOfCustomPaintTransClass(doc, data.Paints);
			}
			doc.Parent();
			pName = prefix + "PerformanceParts";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.PerformanceParts = new List<PerformancePartTrans>();
				XSD2CPP.ReadArrayOfPerformancePartTransClass(doc, data.PerformanceParts);
			}
			doc.Parent();
			pName = prefix + "PhysicsProfileHash";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.PhysicsProfileHash);
			}
			doc.Parent();
			pName = prefix + "Rating";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Rating);
			}
			doc.Parent();
			pName = prefix + "ResalePrice";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadFloat(doc, out data.ResalePrice);
			}
			doc.Parent();
			pName = prefix + "RideHeightDrop";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadFloat(doc, out data.RideHeightDrop);
			}
			doc.Parent();
			pName = prefix + "SkillModParts";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.SkillModParts = new List<SkillModPartTrans>();
				XSD2CPP.ReadArrayOfSkillModPartTransClass(doc, data.SkillModParts);
			}
			doc.Parent();
			pName = prefix + "SkillModSlotCount";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.SkillModSlotCount);
			}
			doc.Parent();
			pName = prefix + "Version";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Version);
			}
			doc.Parent();
			pName = prefix + "Vinyls";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.Vinyls = new List<CustomVinylTrans>();
				XSD2CPP.ReadArrayOfCustomVinylTransClass(doc, data.Vinyls);
			}
			doc.Parent();
			pName = prefix + "VisualParts";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.VisualParts = new List<VisualPartTrans>();
				XSD2CPP.ReadArrayOfVisualPartTransClass(doc, data.VisualParts);
			}
			return true;
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x00037588 File Offset: 0x00036588
		private static bool ReadOwnedCarTrans(XmlParser doc, OwnedCarTrans data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "CustomCar";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.CustomCar = new CustomCarTrans();
				XSD2CPP.ReadCustomCarTransClass(doc, data.CustomCar);
			}
			doc.Parent();
			pName = prefix + "Durability";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Durability);
			}
			doc.Parent();
			pName = prefix + "ExpirationDate";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadDateTime(doc, out data.ExpirationDate);
			}
			doc.Parent();
			pName = prefix + "Heat";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadFloat(doc, out data.Heat);
			}
			doc.Parent();
			pName = prefix + "Id";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.Id);
			}
			doc.Parent();
			pName = prefix + "OwnershipType";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.OwnershipType);
			}
			return true;
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x000376AC File Offset: 0x000366AC
		private static bool ReadArrayOfOwnedCarTrans(XmlParser doc, List<OwnedCarTrans> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "OwnedCarTrans";
			}
			for (;;)
			{
				OwnedCarTrans ownedCarTrans = new OwnedCarTrans();
				if (!XSD2CPP.ReadOwnedCarTransClass(doc, ownedCarTrans))
				{
					break;
				}
				data.Add(ownedCarTrans);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x000376FC File Offset: 0x000366FC
		private static bool ReadCustomPaintTrans(XmlParser doc, CustomPaintTrans data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "Group";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Group);
			}
			doc.Parent();
			pName = prefix + "Hue";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Hue);
			}
			doc.Parent();
			pName = prefix + "Sat";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Sat);
			}
			doc.Parent();
			pName = prefix + "Slot";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Slot);
			}
			doc.Parent();
			pName = prefix + "Var";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Var);
			}
			return true;
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x000377E4 File Offset: 0x000367E4
		private static bool ReadArrayOfCustomPaintTrans(XmlParser doc, List<CustomPaintTrans> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "CustomPaintTrans";
			}
			for (;;)
			{
				CustomPaintTrans customPaintTrans = new CustomPaintTrans();
				if (!XSD2CPP.ReadCustomPaintTransClass(doc, customPaintTrans))
				{
					break;
				}
				data.Add(customPaintTrans);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x00037834 File Offset: 0x00036834
		private static bool ReadPerformancePartTrans(XmlParser doc, PerformancePartTrans data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "PerformancePartAttribHash";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.PerformancePartAttribHash);
			}
			return true;
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x00037878 File Offset: 0x00036878
		private static bool ReadArrayOfPerformancePartTrans(XmlParser doc, List<PerformancePartTrans> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "PerformancePartTrans";
			}
			for (;;)
			{
				PerformancePartTrans performancePartTrans = new PerformancePartTrans();
				if (!XSD2CPP.ReadPerformancePartTransClass(doc, performancePartTrans))
				{
					break;
				}
				data.Add(performancePartTrans);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x000378C8 File Offset: 0x000368C8
		private static bool ReadSkillModPartTrans(XmlParser doc, SkillModPartTrans data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "IsFixed";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.IsFixed);
			}
			doc.Parent();
			pName = prefix + "SkillModPartAttribHash";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.SkillModPartAttribHash);
			}
			return true;
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x00037934 File Offset: 0x00036934
		private static bool ReadArrayOfSkillModPartTrans(XmlParser doc, List<SkillModPartTrans> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "SkillModPartTrans";
			}
			for (;;)
			{
				SkillModPartTrans skillModPartTrans = new SkillModPartTrans();
				if (!XSD2CPP.ReadSkillModPartTransClass(doc, skillModPartTrans))
				{
					break;
				}
				data.Add(skillModPartTrans);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x00037984 File Offset: 0x00036984
		private static bool ReadCustomVinylTrans(XmlParser doc, CustomVinylTrans data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "Hash";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Hash);
			}
			doc.Parent();
			pName = prefix + "Hue1";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Hue1);
			}
			doc.Parent();
			pName = prefix + "Hue2";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Hue2);
			}
			doc.Parent();
			pName = prefix + "Hue3";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Hue3);
			}
			doc.Parent();
			pName = prefix + "Hue4";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Hue4);
			}
			doc.Parent();
			pName = prefix + "Layer";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Layer);
			}
			doc.Parent();
			pName = prefix + "Mir";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.Mir);
			}
			doc.Parent();
			pName = prefix + "Rot";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Rot);
			}
			doc.Parent();
			pName = prefix + "Sat1";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Sat1);
			}
			doc.Parent();
			pName = prefix + "Sat2";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Sat2);
			}
			doc.Parent();
			pName = prefix + "Sat3";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Sat3);
			}
			doc.Parent();
			pName = prefix + "Sat4";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Sat4);
			}
			doc.Parent();
			pName = prefix + "ScaleX";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.ScaleX);
			}
			doc.Parent();
			pName = prefix + "ScaleY";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.ScaleY);
			}
			doc.Parent();
			pName = prefix + "Shear";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Shear);
			}
			doc.Parent();
			pName = prefix + "TranX";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.TranX);
			}
			doc.Parent();
			pName = prefix + "TranY";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.TranY);
			}
			doc.Parent();
			pName = prefix + "Var1";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Var1);
			}
			doc.Parent();
			pName = prefix + "Var2";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Var2);
			}
			doc.Parent();
			pName = prefix + "Var3";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Var3);
			}
			doc.Parent();
			pName = prefix + "Var4";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Var4);
			}
			return true;
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x00037CFC File Offset: 0x00036CFC
		private static bool ReadArrayOfCustomVinylTrans(XmlParser doc, List<CustomVinylTrans> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "CustomVinylTrans";
			}
			for (;;)
			{
				CustomVinylTrans customVinylTrans = new CustomVinylTrans();
				if (!XSD2CPP.ReadCustomVinylTransClass(doc, customVinylTrans))
				{
					break;
				}
				data.Add(customVinylTrans);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x00037D4C File Offset: 0x00036D4C
		private static bool ReadVisualPartTrans(XmlParser doc, VisualPartTrans data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "PartHash";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.PartHash);
			}
			doc.Parent();
			pName = prefix + "SlotHash";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.SlotHash);
			}
			return true;
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x00037DB8 File Offset: 0x00036DB8
		private static bool ReadArrayOfVisualPartTrans(XmlParser doc, List<VisualPartTrans> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "VisualPartTrans";
			}
			for (;;)
			{
				VisualPartTrans visualPartTrans = new VisualPartTrans();
				if (!XSD2CPP.ReadVisualPartTransClass(doc, visualPartTrans))
				{
					break;
				}
				data.Add(visualPartTrans);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x00037E08 File Offset: 0x00036E08
		private static bool ReadWalletTrans(XmlParser doc, WalletTrans data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "Balance";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadDouble(doc, out data.Balance);
			}
			doc.Parent();
			pName = prefix + "Currency";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Currency);
			}
			return true;
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x00037E74 File Offset: 0x00036E74
		private static bool ReadArrayOfWalletTrans(XmlParser doc, List<WalletTrans> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "WalletTrans";
			}
			for (;;)
			{
				WalletTrans walletTrans = new WalletTrans();
				if (!XSD2CPP.ReadWalletTransClass(doc, walletTrans))
				{
					break;
				}
				data.Add(walletTrans);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x00037EC4 File Offset: 0x00036EC4
		private static bool ReadCredentials(XmlParser doc, Credentials data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "Email";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Email);
			}
			doc.Parent();
			pName = prefix + "Password";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Password);
			}
			doc.Parent();
			pName = prefix + "Region";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Region);
			}
			return true;
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x00037F58 File Offset: 0x00036F58
		private static bool ReadToken(XmlParser doc, Token data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "EualaAccepted";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.EualaAccepted);
			}
			doc.Parent();
			pName = prefix + "Region";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Region);
			}
			doc.Parent();
			pName = prefix + "Value";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Value);
			}
			return true;
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x00037FEC File Offset: 0x00036FEC
		private static bool ReadGetPermanentSessionData(XmlParser doc, GetPermanentSessionData data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "machineID";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.machineID);
			}
			doc.Parent();
			pName = prefix + "version";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.version);
			}
			return true;
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x00038058 File Offset: 0x00037058
		private static bool ReadClientConfigTrans(XmlParser doc, ClientConfigTrans data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "clientConfigs";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.clientConfigs = new List<ClientConfig>();
				XSD2CPP.ReadArrayOfClientConfigClass(doc, data.clientConfigs);
			}
			return true;
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x000380B0 File Offset: 0x000370B0
		private static bool ReadClientConfig(XmlParser doc, ClientConfig data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "group";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.group);
			}
			doc.Parent();
			pName = prefix + "level";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.level);
			}
			return true;
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x0003811C File Offset: 0x0003711C
		private static bool ReadArrayOfClientConfig(XmlParser doc, List<ClientConfig> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "ClientConfig";
			}
			for (;;)
			{
				ClientConfig clientConfig = new ClientConfig();
				if (!XSD2CPP.ReadClientConfigClass(doc, clientConfig))
				{
					break;
				}
				data.Add(clientConfig);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001BDB RID: 7131 RVA: 0x0003816C File Offset: 0x0003716C
		private static bool ReadUser_Settings(XmlParser doc, User_Settings data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "CarCacheAgeLimit";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.CarCacheAgeLimit);
			}
			doc.Parent();
			pName = prefix + "IsRaceNowEnabled";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.IsRaceNowEnabled);
			}
			doc.Parent();
			pName = prefix + "MaxCarCacheSize";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.MaxCarCacheSize);
			}
			doc.Parent();
			pName = prefix + "MinRaceNowLevel";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.MinRaceNowLevel);
			}
			doc.Parent();
			pName = prefix + "VoipAvailable";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.VoipAvailable);
			}
			doc.Parent();
			pName = prefix + "activatedHolidaySceneryGroups";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.activatedHolidaySceneryGroups = new List<string>();
				XSD2CPP.ReadArrayOfstringClass(doc, data.activatedHolidaySceneryGroups);
			}
			doc.Parent();
			pName = prefix + "activeHolidayIds";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.activeHolidayIds = new List<long>();
				XSD2CPP.ReadArrayOflongClass(doc, data.activeHolidayIds);
			}
			doc.Parent();
			pName = prefix + "disactivatedHolidaySceneryGroups";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.disactivatedHolidaySceneryGroups = new List<string>();
				XSD2CPP.ReadArrayOfstringClass(doc, data.disactivatedHolidaySceneryGroups);
			}
			doc.Parent();
			pName = prefix + "firstTimeLogin";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.firstTimeLogin);
			}
			doc.Parent();
			pName = prefix + "maxLevel";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.maxLevel);
			}
			doc.Parent();
			pName = prefix + "starterPackApplied";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.starterPackApplied);
			}
			doc.Parent();
			pName = prefix + "userId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.userId);
			}
			return true;
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x000383AC File Offset: 0x000373AC
		private static bool ReadHardwareInfo(XmlParser doc, HardwareInfo data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "availableMem";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.availableMem);
			}
			doc.Parent();
			pName = prefix + "cpuBrand";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.cpuBrand);
			}
			doc.Parent();
			pName = prefix + "cpuid0";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.cpuid0);
			}
			doc.Parent();
			pName = prefix + "cpuid1_0";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.cpuid1_0);
			}
			doc.Parent();
			pName = prefix + "cpuid1_1";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.cpuid1_1);
			}
			doc.Parent();
			pName = prefix + "cpuid1_2";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.cpuid1_2);
			}
			doc.Parent();
			pName = prefix + "cpuid1_3";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.cpuid1_3);
			}
			doc.Parent();
			pName = prefix + "deviceID";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.deviceID);
			}
			doc.Parent();
			pName = prefix + "excpuid1_0";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.excpuid1_0);
			}
			doc.Parent();
			pName = prefix + "excpuid1_1";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.excpuid1_1);
			}
			doc.Parent();
			pName = prefix + "excpuid1_2";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.excpuid1_2);
			}
			doc.Parent();
			pName = prefix + "excpuid1_3";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.excpuid1_3);
			}
			doc.Parent();
			pName = prefix + "gpuDescription";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.gpuDescription);
			}
			doc.Parent();
			pName = prefix + "gpuDriverBuild";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.gpuDriverBuild);
			}
			doc.Parent();
			pName = prefix + "gpuDriverSubversion";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.gpuDriverSubversion);
			}
			doc.Parent();
			pName = prefix + "gpuDriverVersion";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.gpuDriverVersion);
			}
			doc.Parent();
			pName = prefix + "gpuMemory";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.gpuMemory);
			}
			doc.Parent();
			pName = prefix + "gpuProduct";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.gpuProduct);
			}
			doc.Parent();
			pName = prefix + "osBuildNumber";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.osBuildNumber);
			}
			doc.Parent();
			pName = prefix + "osMajorVersion";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.osMajorVersion);
			}
			doc.Parent();
			pName = prefix + "osMinorVersion";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.osMinorVersion);
			}
			doc.Parent();
			pName = prefix + "physicalCores";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.physicalCores);
			}
			doc.Parent();
			pName = prefix + "platformID";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.platformID);
			}
			doc.Parent();
			pName = prefix + "processAffinityMask";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.processAffinityMask);
			}
			doc.Parent();
			pName = prefix + "servicePack";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.servicePack);
			}
			doc.Parent();
			pName = prefix + "systemAffinityMask";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.systemAffinityMask);
			}
			doc.Parent();
			pName = prefix + "totalMemory";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.totalMemory);
			}
			doc.Parent();
			pName = prefix + "userID";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.userID);
			}
			doc.Parent();
			pName = prefix + "vendorID";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.vendorID);
			}
			return true;
		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x0003886C File Offset: 0x0003786C
		private static bool ReadUserSettings(XmlParser doc, UserSettings data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "desktopResHeight";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.desktopResHeight);
			}
			doc.Parent();
			pName = prefix + "desktopResWidth";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.desktopResWidth);
			}
			doc.Parent();
			pName = prefix + "fullscreen";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.fullscreen);
			}
			doc.Parent();
			pName = prefix + "gameResHeight";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.gameResHeight);
			}
			doc.Parent();
			pName = prefix + "gameResWidth";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.gameResWidth);
			}
			doc.Parent();
			pName = prefix + "globalDetailLevel";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.globalDetailLevel);
			}
			doc.Parent();
			pName = prefix + "userID";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.userID);
			}
			return true;
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x000389A4 File Offset: 0x000379A4
		private static bool ReadMachineIdentification(XmlParser doc, MachineIdentification data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "cpuID";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.cpuID);
			}
			doc.Parent();
			pName = prefix + "diskSerialNumber";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.diskSerialNumber);
			}
			doc.Parent();
			pName = prefix + "gpuID";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.gpuID);
			}
			doc.Parent();
			pName = prefix + "mac";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.mac);
			}
			doc.Parent();
			pName = prefix + "machineName";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.machineName);
			}
			doc.Parent();
			pName = prefix + "userID";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.userID);
			}
			doc.Parent();
			pName = prefix + "volumeName";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.volumeName);
			}
			doc.Parent();
			pName = prefix + "volumeSerialNumber";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.volumeSerialNumber);
			}
			return true;
		}

		// Token: 0x06001BDF RID: 7135 RVA: 0x00038B08 File Offset: 0x00037B08
		private static bool ReadLauncherStartTrans(XmlParser doc, LauncherStartTrans data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "autoLogin";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.autoLogin);
			}
			doc.Parent();
			pName = prefix + "autoStart";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.autoStart);
			}
			doc.Parent();
			pName = prefix + "language";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.language);
			}
			doc.Parent();
			pName = prefix + "languageCode";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.languageCode);
			}
			doc.Parent();
			pName = prefix + "region";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.region);
			}
			doc.Parent();
			pName = prefix + "sku";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.sku);
			}
			doc.Parent();
			pName = prefix + "userID";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.userID);
			}
			return true;
		}

		// Token: 0x06001BE0 RID: 7136 RVA: 0x00038C40 File Offset: 0x00037C40
		private static bool ReadLauncherEndTrans(XmlParser doc, LauncherEndTrans data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "leaveReasonID";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.leaveReasonID);
			}
			doc.Parent();
			pName = prefix + "patchTime";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.patchTime);
			}
			doc.Parent();
			pName = prefix + "userID";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.userID);
			}
			return true;
		}

		// Token: 0x06001BE1 RID: 7137 RVA: 0x00038CD4 File Offset: 0x00037CD4
		private static bool ReadVector3(XmlParser doc, Vector3 data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "X";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadFloat(doc, out data.X);
			}
			doc.Parent();
			pName = prefix + "Y";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadFloat(doc, out data.Y);
			}
			doc.Parent();
			pName = prefix + "Z";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadFloat(doc, out data.Z);
			}
			return true;
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x00038D68 File Offset: 0x00037D68
		private static bool ReadHeartBeat(XmlParser doc, HeartBeat data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "MetagameFlags";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.MetagameFlags);
			}
			doc.Parent();
			pName = prefix + "enabledBitField";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.enabledBitField);
			}
			return true;
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x00038DD4 File Offset: 0x00037DD4
		private static bool ReadFraudConfig(XmlParser doc, FraudConfig data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "enabledBitField";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.enabledBitField);
			}
			doc.Parent();
			pName = prefix + "gameFileFreq";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.gameFileFreq);
			}
			doc.Parent();
			pName = prefix + "moduleFreq";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.moduleFreq);
			}
			doc.Parent();
			pName = prefix + "startUpFreq";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.startUpFreq);
			}
			doc.Parent();
			pName = prefix + "userID";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.userID);
			}
			return true;
		}

		// Token: 0x06001BE4 RID: 7140 RVA: 0x00038EBC File Offset: 0x00037EBC
		private static bool ReadProductTrans(XmlParser doc, ProductTrans data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "BundleItems";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.BundleItems = new List<ProductTrans>();
				XSD2CPP.ReadArrayOfProductTransClass(doc, data.BundleItems);
			}
			doc.Parent();
			pName = prefix + "CategoryId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.CategoryId);
			}
			doc.Parent();
			pName = prefix + "Currency";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Currency);
			}
			doc.Parent();
			pName = prefix + "Description";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Description);
			}
			doc.Parent();
			pName = prefix + "DurationMinute";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.DurationMinute);
			}
			doc.Parent();
			pName = prefix + "Hash";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Hash);
			}
			doc.Parent();
			pName = prefix + "Icon";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Icon);
			}
			doc.Parent();
			pName = prefix + "Level";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Level);
			}
			doc.Parent();
			pName = prefix + "LongDescription";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.LongDescription);
			}
			doc.Parent();
			pName = prefix + "Price";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadDouble(doc, out data.Price);
			}
			doc.Parent();
			pName = prefix + "Priority";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Priority);
			}
			doc.Parent();
			pName = prefix + "ProductId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.ProductId);
			}
			doc.Parent();
			pName = prefix + "ProductTitle";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.ProductTitle);
			}
			doc.Parent();
			pName = prefix + "ProductType";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.ProductType);
			}
			doc.Parent();
			pName = prefix + "SecondaryIcon";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.SecondaryIcon);
			}
			doc.Parent();
			pName = prefix + "UseCount";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.UseCount);
			}
			doc.Parent();
			pName = prefix + "VisualStyle";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.VisualStyle);
			}
			doc.Parent();
			pName = prefix + "WebIcon";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.WebIcon);
			}
			doc.Parent();
			pName = prefix + "WebLocation";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.WebLocation);
			}
			return true;
		}

		// Token: 0x06001BE5 RID: 7141 RVA: 0x000391F4 File Offset: 0x000381F4
		private static bool ReadArrayOfProductTrans(XmlParser doc, List<ProductTrans> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "ProductTrans";
			}
			for (;;)
			{
				ProductTrans productTrans = new ProductTrans();
				if (!XSD2CPP.ReadProductTransClass(doc, productTrans))
				{
					break;
				}
				data.Add(productTrans);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001BE6 RID: 7142 RVA: 0x00039244 File Offset: 0x00038244
		private static bool ReadInventoryTrans(XmlParser doc, InventoryTrans data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "InventoryItems";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.InventoryItems = new List<InventoryItemTrans>();
				XSD2CPP.ReadArrayOfInventoryItemTransClass(doc, data.InventoryItems);
			}
			doc.Parent();
			pName = prefix + "PerformancePartsCapacity";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.PerformancePartsCapacity);
			}
			doc.Parent();
			pName = prefix + "PerformancePartsUsedSlotCount";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.PerformancePartsUsedSlotCount);
			}
			doc.Parent();
			pName = prefix + "SkillModPartsCapacity";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.SkillModPartsCapacity);
			}
			doc.Parent();
			pName = prefix + "SkillModPartsUsedSlotCount";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.SkillModPartsUsedSlotCount);
			}
			doc.Parent();
			pName = prefix + "VisualPartsCapacity";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.VisualPartsCapacity);
			}
			doc.Parent();
			pName = prefix + "VisualPartsUsedSlotCount";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.VisualPartsUsedSlotCount);
			}
			return true;
		}

		// Token: 0x06001BE7 RID: 7143 RVA: 0x00039390 File Offset: 0x00038390
		private static bool ReadEntitlementTrans(XmlParser doc, EntitlementTrans data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "Items";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.Items = new List<EntitlementItemTrans>();
				XSD2CPP.ReadArrayOfEntitlementItemTransClass(doc, data.Items);
			}
			return true;
		}

		// Token: 0x06001BE8 RID: 7144 RVA: 0x000393E8 File Offset: 0x000383E8
		private static bool ReadEntitlementItemTrans(XmlParser doc, EntitlementItemTrans data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "EntitlementId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.EntitlementId);
			}
			doc.Parent();
			pName = prefix + "Quantity";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Quantity);
			}
			return true;
		}

		// Token: 0x06001BE9 RID: 7145 RVA: 0x00039454 File Offset: 0x00038454
		private static bool ReadArrayOfEntitlementItemTrans(XmlParser doc, List<EntitlementItemTrans> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "EntitlementItemTrans";
			}
			for (;;)
			{
				EntitlementItemTrans entitlementItemTrans = new EntitlementItemTrans();
				if (!XSD2CPP.ReadEntitlementItemTransClass(doc, entitlementItemTrans))
				{
					break;
				}
				data.Add(entitlementItemTrans);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001BEA RID: 7146 RVA: 0x000394A4 File Offset: 0x000384A4
		private static bool ReadCategoryTrans(XmlParser doc, CategoryTrans data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "CatalogVersion";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.CatalogVersion);
			}
			doc.Parent();
			pName = prefix + "Categories";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.Categories = new List<CategoryTrans>();
				XSD2CPP.ReadArrayOfCategoryTransClass(doc, data.Categories);
			}
			doc.Parent();
			pName = prefix + "DisplayName";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.DisplayName);
			}
			doc.Parent();
			pName = prefix + "FilterType";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.FilterType);
			}
			doc.Parent();
			pName = prefix + "Icon";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Icon);
			}
			doc.Parent();
			pName = prefix + "Id";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Id);
			}
			doc.Parent();
			pName = prefix + "LongDescription";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.LongDescription);
			}
			doc.Parent();
			pName = prefix + "Name";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Name);
			}
			doc.Parent();
			pName = prefix + "Priority";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Priority);
			}
			doc.Parent();
			pName = prefix + "Products";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.Products = new List<ProductTrans>();
				XSD2CPP.ReadArrayOfProductTransClass(doc, data.Products);
			}
			doc.Parent();
			pName = prefix + "ShortDescription";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.ShortDescription);
			}
			doc.Parent();
			pName = prefix + "ShowInNavigationPane";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.ShowInNavigationPane);
			}
			doc.Parent();
			pName = prefix + "ShowPromoPage";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.ShowPromoPage);
			}
			doc.Parent();
			pName = prefix + "WebIcon";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.WebIcon);
			}
			return true;
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x00039724 File Offset: 0x00038724
		private static bool ReadArrayOfCategoryTrans(XmlParser doc, List<CategoryTrans> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "CategoryTrans";
			}
			for (;;)
			{
				CategoryTrans categoryTrans = new CategoryTrans();
				if (!XSD2CPP.ReadCategoryTransClass(doc, categoryTrans))
				{
					break;
				}
				data.Add(categoryTrans);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x00039774 File Offset: 0x00038774
		private static bool ReadCommerceSessionTrans(XmlParser doc, CommerceSessionTrans data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "Basket";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.Basket = new BasketTrans();
				XSD2CPP.ReadBasketTransClass(doc, data.Basket);
			}
			doc.Parent();
			pName = prefix + "EntitlementsToSell";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.EntitlementsToSell = new EntitlementTrans();
				XSD2CPP.ReadEntitlementTransClass(doc, data.EntitlementsToSell);
			}
			doc.Parent();
			pName = prefix + "UpdatedCar";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.UpdatedCar = new OwnedCarTrans();
				XSD2CPP.ReadOwnedCarTransClass(doc, data.UpdatedCar);
			}
			return true;
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x00039844 File Offset: 0x00038844
		private static bool ReadCommerceSessionResultTrans(XmlParser doc, CommerceSessionResultTrans data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "InvalidBasket";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.InvalidBasket = new InvalidBasketTrans();
				XSD2CPP.ReadInvalidBasketTransClass(doc, data.InvalidBasket);
			}
			doc.Parent();
			pName = prefix + "InventoryItems";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.InventoryItems = new List<InventoryItemTrans>();
				XSD2CPP.ReadArrayOfInventoryItemTransClass(doc, data.InventoryItems);
			}
			doc.Parent();
			pName = prefix + "Status";
			if (doc.FirstChild(pName))
			{
				XSD2CPP.ReadCommerceResultStatus(doc, out data.Status);
			}
			doc.Parent();
			pName = prefix + "UpdatedCar";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.UpdatedCar = new OwnedCarTrans();
				XSD2CPP.ReadOwnedCarTransClass(doc, data.UpdatedCar);
			}
			doc.Parent();
			pName = prefix + "Wallets";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.Wallets = new List<WalletTrans>();
				XSD2CPP.ReadArrayOfWalletTransClass(doc, data.Wallets);
			}
			return true;
		}

		// Token: 0x06001BEE RID: 7150 RVA: 0x00039978 File Offset: 0x00038978
		private static bool ReadClientServerCryptoTicket(XmlParser doc, ClientServerCryptoTicket data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "CryptoTicket";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.CryptoTicket);
			}
			doc.Parent();
			pName = prefix + "SessionKey";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.SessionKey);
			}
			doc.Parent();
			pName = prefix + "TicketIv";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.TicketIv);
			}
			return true;
		}

		// Token: 0x06001BEF RID: 7151 RVA: 0x00039A0C File Offset: 0x00038A0C
		private static bool ReadUdpRelayCryptoTicket(XmlParser doc, UdpRelayCryptoTicket data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "CryptoTicket";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.CryptoTicket);
			}
			doc.Parent();
			pName = prefix + "SessionKey";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.SessionKey);
			}
			doc.Parent();
			pName = prefix + "TicketIv";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.TicketIv);
			}
			return true;
		}

		// Token: 0x06001BF0 RID: 7152 RVA: 0x00039AA0 File Offset: 0x00038AA0
		private static bool ReadUdpRelayInfo(XmlParser doc, UdpRelayInfo data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "Host";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Host);
			}
			doc.Parent();
			pName = prefix + "Port";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Port);
			}
			return true;
		}

		// Token: 0x06001BF1 RID: 7153 RVA: 0x00039B0C File Offset: 0x00038B0C
		private static bool ReadArrayOfUdpRelayInfo(XmlParser doc, List<UdpRelayInfo> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "UdpRelayInfo";
			}
			for (;;)
			{
				UdpRelayInfo udpRelayInfo = new UdpRelayInfo();
				if (!XSD2CPP.ReadUdpRelayInfoClass(doc, udpRelayInfo))
				{
					break;
				}
				data.Add(udpRelayInfo);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x00039B5C File Offset: 0x00038B5C
		private static bool ReadRegionInfo(XmlParser doc, RegionInfo data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "CountdownProposalInMilliseconds";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.CountdownProposalInMilliseconds);
			}
			doc.Parent();
			pName = prefix + "DirectConnectTimeoutInMilliseconds";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.DirectConnectTimeoutInMilliseconds);
			}
			doc.Parent();
			pName = prefix + "DropOutTimeInMilliseconds";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.DropOutTimeInMilliseconds);
			}
			doc.Parent();
			pName = prefix + "EventLoadTimeoutInMilliseconds";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.EventLoadTimeoutInMilliseconds);
			}
			doc.Parent();
			pName = prefix + "HeartbeatIntervalInMilliseconds";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.HeartbeatIntervalInMilliseconds);
			}
			doc.Parent();
			pName = prefix + "UdpRelayBandwidthInBps";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.UdpRelayBandwidthInBps);
			}
			doc.Parent();
			pName = prefix + "UdpRelayTimeoutInMilliseconds";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.UdpRelayTimeoutInMilliseconds);
			}
			return true;
		}

		// Token: 0x06001BF3 RID: 7155 RVA: 0x00039C94 File Offset: 0x00038C94
		private static bool ReadCarSlotInfoTrans(XmlParser doc, CarSlotInfoTrans data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "CarsOwnedByPersona";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.CarsOwnedByPersona = new List<OwnedCarTrans>();
				XSD2CPP.ReadArrayOfOwnedCarTransClass(doc, data.CarsOwnedByPersona);
			}
			doc.Parent();
			pName = prefix + "DefaultOwnedCarIndex";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.DefaultOwnedCarIndex);
			}
			doc.Parent();
			pName = prefix + "ObtainableSlots";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.ObtainableSlots = new List<ProductTrans>();
				XSD2CPP.ReadArrayOfProductTransClass(doc, data.ObtainableSlots);
			}
			doc.Parent();
			pName = prefix + "OwnedCarSlotsCount";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.OwnedCarSlotsCount);
			}
			return true;
		}

		// Token: 0x06001BF4 RID: 7156 RVA: 0x00039D78 File Offset: 0x00038D78
		public static bool Reader(XmlString xmlString, out ClientLog data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ClientLog"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new ClientLog();
						if (XSD2CPP.ReadClientLogClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x00039DD4 File Offset: 0x00038DD4
		public static bool ReadClientLog(XmlString xmlString, out ClientLog data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x00039DE0 File Offset: 0x00038DE0
		public static bool Reader(XmlString xmlString, out BasketTrans data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "BasketTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new BasketTrans();
						if (XSD2CPP.ReadBasketTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x00039E3C File Offset: 0x00038E3C
		public static bool ReadBasketTrans(XmlString xmlString, out BasketTrans data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x00039E48 File Offset: 0x00038E48
		public static bool Reader(XmlString xmlString, out CommerceItemTrans data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "CommerceItemTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new CommerceItemTrans();
						if (XSD2CPP.ReadCommerceItemTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x00039EA4 File Offset: 0x00038EA4
		public static bool ReadCommerceItemTrans(XmlString xmlString, out CommerceItemTrans data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x00039EB0 File Offset: 0x00038EB0
		public static bool Reader(XmlString xmlString, out List<CommerceItemTrans> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfCommerceItemTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<CommerceItemTrans>();
						if (XSD2CPP.ReadArrayOfCommerceItemTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x00039F0C File Offset: 0x00038F0C
		public static bool ReadArrayOfCommerceItemTrans(XmlString xmlString, out List<CommerceItemTrans> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x00039F18 File Offset: 0x00038F18
		public static bool Reader(XmlString xmlString, out InvalidBasketTrans data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "InvalidBasketTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new InvalidBasketTrans();
						if (XSD2CPP.ReadInvalidBasketTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x00039F74 File Offset: 0x00038F74
		public static bool ReadInvalidBasketTrans(XmlString xmlString, out InvalidBasketTrans data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x00039F80 File Offset: 0x00038F80
		public static bool Reader(XmlString xmlString, out CommerceResultTrans data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "CommerceResultTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new CommerceResultTrans();
						if (XSD2CPP.ReadCommerceResultTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x00039FDC File Offset: 0x00038FDC
		public static bool ReadCommerceResultTrans(XmlString xmlString, out CommerceResultTrans data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x00039FE8 File Offset: 0x00038FE8
		public static bool Reader(XmlString xmlString, out BasketItemTrans data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "BasketItemTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new BasketItemTrans();
						if (XSD2CPP.ReadBasketItemTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x0003A044 File Offset: 0x00039044
		public static bool ReadBasketItemTrans(XmlString xmlString, out BasketItemTrans data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x0003A050 File Offset: 0x00039050
		public static bool Reader(XmlString xmlString, out List<BasketItemTrans> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfBasketItemTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<BasketItemTrans>();
						if (XSD2CPP.ReadArrayOfBasketItemTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x0003A0AC File Offset: 0x000390AC
		public static bool ReadArrayOfBasketItemTrans(XmlString xmlString, out List<BasketItemTrans> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x0003A0B8 File Offset: 0x000390B8
		public static bool Reader(XmlString xmlString, out InvalidBasketItemTrans data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "InvalidBasketItemTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new InvalidBasketItemTrans();
						if (XSD2CPP.ReadInvalidBasketItemTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x0003A114 File Offset: 0x00039114
		public static bool ReadInvalidBasketItemTrans(XmlString xmlString, out InvalidBasketItemTrans data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x0003A120 File Offset: 0x00039120
		public static bool Reader(XmlString xmlString, out List<InvalidBasketItemTrans> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfInvalidBasketItemTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<InvalidBasketItemTrans>();
						if (XSD2CPP.ReadArrayOfInvalidBasketItemTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x0003A17C File Offset: 0x0003917C
		public static bool ReadArrayOfInvalidBasketItemTrans(XmlString xmlString, out List<InvalidBasketItemTrans> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x0003A188 File Offset: 0x00039188
		public static bool Reader(XmlString xmlString, out InventoryItemTrans data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "InventoryItemTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new InventoryItemTrans();
						if (XSD2CPP.ReadInventoryItemTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x0003A1E4 File Offset: 0x000391E4
		public static bool ReadInventoryItemTrans(XmlString xmlString, out InventoryItemTrans data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x0003A1F0 File Offset: 0x000391F0
		public static bool Reader(XmlString xmlString, out List<InventoryItemTrans> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfInventoryItemTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<InventoryItemTrans>();
						if (XSD2CPP.ReadArrayOfInventoryItemTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x0003A24C File Offset: 0x0003924C
		public static bool ReadArrayOfInventoryItemTrans(XmlString xmlString, out List<InventoryItemTrans> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x0003A258 File Offset: 0x00039258
		public static bool Reader(XmlString xmlString, out CustomCarTrans data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "CustomCarTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new CustomCarTrans();
						if (XSD2CPP.ReadCustomCarTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x0003A2B4 File Offset: 0x000392B4
		public static bool ReadCustomCarTrans(XmlString xmlString, out CustomCarTrans data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x0003A2C0 File Offset: 0x000392C0
		public static bool Reader(XmlString xmlString, out OwnedCarTrans data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "OwnedCarTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new OwnedCarTrans();
						if (XSD2CPP.ReadOwnedCarTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x0003A31C File Offset: 0x0003931C
		public static bool ReadOwnedCarTrans(XmlString xmlString, out OwnedCarTrans data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x0003A328 File Offset: 0x00039328
		public static bool Reader(XmlString xmlString, out List<OwnedCarTrans> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfOwnedCarTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<OwnedCarTrans>();
						if (XSD2CPP.ReadArrayOfOwnedCarTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x0003A384 File Offset: 0x00039384
		public static bool ReadArrayOfOwnedCarTrans(XmlString xmlString, out List<OwnedCarTrans> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x0003A390 File Offset: 0x00039390
		public static bool Reader(XmlString xmlString, out CustomPaintTrans data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "CustomPaintTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new CustomPaintTrans();
						if (XSD2CPP.ReadCustomPaintTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x0003A3EC File Offset: 0x000393EC
		public static bool ReadCustomPaintTrans(XmlString xmlString, out CustomPaintTrans data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x0003A3F8 File Offset: 0x000393F8
		public static bool Reader(XmlString xmlString, out List<CustomPaintTrans> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfCustomPaintTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<CustomPaintTrans>();
						if (XSD2CPP.ReadArrayOfCustomPaintTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x0003A454 File Offset: 0x00039454
		public static bool ReadArrayOfCustomPaintTrans(XmlString xmlString, out List<CustomPaintTrans> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x0003A460 File Offset: 0x00039460
		public static bool Reader(XmlString xmlString, out PerformancePartTrans data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "PerformancePartTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new PerformancePartTrans();
						if (XSD2CPP.ReadPerformancePartTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x0003A4BC File Offset: 0x000394BC
		public static bool ReadPerformancePartTrans(XmlString xmlString, out PerformancePartTrans data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x0003A4C8 File Offset: 0x000394C8
		public static bool Reader(XmlString xmlString, out List<PerformancePartTrans> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfPerformancePartTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<PerformancePartTrans>();
						if (XSD2CPP.ReadArrayOfPerformancePartTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x0003A524 File Offset: 0x00039524
		public static bool ReadArrayOfPerformancePartTrans(XmlString xmlString, out List<PerformancePartTrans> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x0003A530 File Offset: 0x00039530
		public static bool Reader(XmlString xmlString, out SkillModPartTrans data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "SkillModPartTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new SkillModPartTrans();
						if (XSD2CPP.ReadSkillModPartTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x0003A58C File Offset: 0x0003958C
		public static bool ReadSkillModPartTrans(XmlString xmlString, out SkillModPartTrans data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x0003A598 File Offset: 0x00039598
		public static bool Reader(XmlString xmlString, out List<SkillModPartTrans> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfSkillModPartTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<SkillModPartTrans>();
						if (XSD2CPP.ReadArrayOfSkillModPartTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x0003A5F4 File Offset: 0x000395F4
		public static bool ReadArrayOfSkillModPartTrans(XmlString xmlString, out List<SkillModPartTrans> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x0003A600 File Offset: 0x00039600
		public static bool Reader(XmlString xmlString, out CustomVinylTrans data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "CustomVinylTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new CustomVinylTrans();
						if (XSD2CPP.ReadCustomVinylTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x0003A65C File Offset: 0x0003965C
		public static bool ReadCustomVinylTrans(XmlString xmlString, out CustomVinylTrans data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x0003A668 File Offset: 0x00039668
		public static bool Reader(XmlString xmlString, out List<CustomVinylTrans> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfCustomVinylTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<CustomVinylTrans>();
						if (XSD2CPP.ReadArrayOfCustomVinylTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x0003A6C4 File Offset: 0x000396C4
		public static bool ReadArrayOfCustomVinylTrans(XmlString xmlString, out List<CustomVinylTrans> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x0003A6D0 File Offset: 0x000396D0
		public static bool Reader(XmlString xmlString, out VisualPartTrans data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "VisualPartTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new VisualPartTrans();
						if (XSD2CPP.ReadVisualPartTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x0003A72C File Offset: 0x0003972C
		public static bool ReadVisualPartTrans(XmlString xmlString, out VisualPartTrans data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x0003A738 File Offset: 0x00039738
		public static bool Reader(XmlString xmlString, out List<VisualPartTrans> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfVisualPartTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<VisualPartTrans>();
						if (XSD2CPP.ReadArrayOfVisualPartTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x0003A794 File Offset: 0x00039794
		public static bool ReadArrayOfVisualPartTrans(XmlString xmlString, out List<VisualPartTrans> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x0003A7A0 File Offset: 0x000397A0
		public static bool Reader(XmlString xmlString, out WalletTrans data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "WalletTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new WalletTrans();
						if (XSD2CPP.ReadWalletTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x0003A7FC File Offset: 0x000397FC
		public static bool ReadWalletTrans(XmlString xmlString, out WalletTrans data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x0003A808 File Offset: 0x00039808
		public static bool Reader(XmlString xmlString, out List<WalletTrans> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfWalletTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<WalletTrans>();
						if (XSD2CPP.ReadArrayOfWalletTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x0003A864 File Offset: 0x00039864
		public static bool ReadArrayOfWalletTrans(XmlString xmlString, out List<WalletTrans> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C2A RID: 7210 RVA: 0x0003A870 File Offset: 0x00039870
		public static bool Reader(XmlString xmlString, out Credentials data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "Credentials"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new Credentials();
						if (XSD2CPP.ReadCredentialsClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C2B RID: 7211 RVA: 0x0003A8CC File Offset: 0x000398CC
		public static bool ReadCredentials(XmlString xmlString, out Credentials data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x0003A8D8 File Offset: 0x000398D8
		public static bool Reader(XmlString xmlString, out Token data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "Token"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new Token();
						if (XSD2CPP.ReadTokenClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C2D RID: 7213 RVA: 0x0003A934 File Offset: 0x00039934
		public static bool ReadToken(XmlString xmlString, out Token data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C2E RID: 7214 RVA: 0x0003A940 File Offset: 0x00039940
		public static bool Reader(XmlString xmlString, out GetPermanentSessionData data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "GetPermanentSessionData"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new GetPermanentSessionData();
						if (XSD2CPP.ReadGetPermanentSessionDataClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C2F RID: 7215 RVA: 0x0003A99C File Offset: 0x0003999C
		public static bool ReadGetPermanentSessionData(XmlString xmlString, out GetPermanentSessionData data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C30 RID: 7216 RVA: 0x0003A9A8 File Offset: 0x000399A8
		public static bool Reader(XmlString xmlString, out ClientConfigTrans data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ClientConfigTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new ClientConfigTrans();
						if (XSD2CPP.ReadClientConfigTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x0003AA04 File Offset: 0x00039A04
		public static bool ReadClientConfigTrans(XmlString xmlString, out ClientConfigTrans data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x0003AA10 File Offset: 0x00039A10
		public static bool Reader(XmlString xmlString, out ClientConfig data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ClientConfig"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new ClientConfig();
						if (XSD2CPP.ReadClientConfigClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x0003AA6C File Offset: 0x00039A6C
		public static bool ReadClientConfig(XmlString xmlString, out ClientConfig data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x0003AA78 File Offset: 0x00039A78
		public static bool Reader(XmlString xmlString, out List<ClientConfig> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfClientConfig"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<ClientConfig>();
						if (XSD2CPP.ReadArrayOfClientConfigClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x0003AAD4 File Offset: 0x00039AD4
		public static bool ReadArrayOfClientConfig(XmlString xmlString, out List<ClientConfig> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x0003AAE0 File Offset: 0x00039AE0
		public static bool Reader(XmlString xmlString, out User_Settings data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "User_Settings"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new User_Settings();
						if (XSD2CPP.ReadUser_SettingsClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x0003AB3C File Offset: 0x00039B3C
		public static bool ReadUser_Settings(XmlString xmlString, out User_Settings data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x0003AB48 File Offset: 0x00039B48
		public static bool Reader(XmlString xmlString, out HardwareInfo data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "HardwareInfo"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new HardwareInfo();
						if (XSD2CPP.ReadHardwareInfoClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C39 RID: 7225 RVA: 0x0003ABA4 File Offset: 0x00039BA4
		public static bool ReadHardwareInfo(XmlString xmlString, out HardwareInfo data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C3A RID: 7226 RVA: 0x0003ABB0 File Offset: 0x00039BB0
		public static bool Reader(XmlString xmlString, out UserSettings data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "UserSettings"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new UserSettings();
						if (XSD2CPP.ReadUserSettingsClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x0003AC0C File Offset: 0x00039C0C
		public static bool ReadUserSettings(XmlString xmlString, out UserSettings data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x0003AC18 File Offset: 0x00039C18
		public static bool Reader(XmlString xmlString, out MachineIdentification data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "MachineIdentification"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new MachineIdentification();
						if (XSD2CPP.ReadMachineIdentificationClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C3D RID: 7229 RVA: 0x0003AC74 File Offset: 0x00039C74
		public static bool ReadMachineIdentification(XmlString xmlString, out MachineIdentification data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x0003AC80 File Offset: 0x00039C80
		public static bool Reader(XmlString xmlString, out LauncherStartTrans data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "LauncherStartTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new LauncherStartTrans();
						if (XSD2CPP.ReadLauncherStartTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C3F RID: 7231 RVA: 0x0003ACDC File Offset: 0x00039CDC
		public static bool ReadLauncherStartTrans(XmlString xmlString, out LauncherStartTrans data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x0003ACE8 File Offset: 0x00039CE8
		public static bool Reader(XmlString xmlString, out LauncherEndTrans data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "LauncherEndTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new LauncherEndTrans();
						if (XSD2CPP.ReadLauncherEndTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x0003AD44 File Offset: 0x00039D44
		public static bool ReadLauncherEndTrans(XmlString xmlString, out LauncherEndTrans data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C42 RID: 7234 RVA: 0x0003AD50 File Offset: 0x00039D50
		public static bool Reader(XmlString xmlString, out Vector3 data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "Vector3"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new Vector3();
						if (XSD2CPP.ReadVector3Class(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C43 RID: 7235 RVA: 0x0003ADAC File Offset: 0x00039DAC
		public static bool ReadVector3(XmlString xmlString, out Vector3 data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C44 RID: 7236 RVA: 0x0003ADB8 File Offset: 0x00039DB8
		public static bool Reader(XmlString xmlString, out HeartBeat data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "HeartBeat"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new HeartBeat();
						if (XSD2CPP.ReadHeartBeatClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x0003AE14 File Offset: 0x00039E14
		public static bool ReadHeartBeat(XmlString xmlString, out HeartBeat data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C46 RID: 7238 RVA: 0x0003AE20 File Offset: 0x00039E20
		public static bool Reader(XmlString xmlString, out FraudConfig data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "FraudConfig"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new FraudConfig();
						if (XSD2CPP.ReadFraudConfigClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x0003AE7C File Offset: 0x00039E7C
		public static bool ReadFraudConfig(XmlString xmlString, out FraudConfig data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x0003AE88 File Offset: 0x00039E88
		public static bool Reader(XmlString xmlString, out ProductTrans data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ProductTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new ProductTrans();
						if (XSD2CPP.ReadProductTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x0003AEE4 File Offset: 0x00039EE4
		public static bool ReadProductTrans(XmlString xmlString, out ProductTrans data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C4A RID: 7242 RVA: 0x0003AEF0 File Offset: 0x00039EF0
		public static bool Reader(XmlString xmlString, out List<ProductTrans> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfProductTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<ProductTrans>();
						if (XSD2CPP.ReadArrayOfProductTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x0003AF4C File Offset: 0x00039F4C
		public static bool ReadArrayOfProductTrans(XmlString xmlString, out List<ProductTrans> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x0003AF58 File Offset: 0x00039F58
		public static bool Reader(XmlString xmlString, out InventoryTrans data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "InventoryTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new InventoryTrans();
						if (XSD2CPP.ReadInventoryTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x0003AFB4 File Offset: 0x00039FB4
		public static bool ReadInventoryTrans(XmlString xmlString, out InventoryTrans data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C4E RID: 7246 RVA: 0x0003AFC0 File Offset: 0x00039FC0
		public static bool Reader(XmlString xmlString, out EntitlementTrans data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "EntitlementTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new EntitlementTrans();
						if (XSD2CPP.ReadEntitlementTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C4F RID: 7247 RVA: 0x0003B01C File Offset: 0x0003A01C
		public static bool ReadEntitlementTrans(XmlString xmlString, out EntitlementTrans data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x0003B028 File Offset: 0x0003A028
		public static bool Reader(XmlString xmlString, out EntitlementItemTrans data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "EntitlementItemTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new EntitlementItemTrans();
						if (XSD2CPP.ReadEntitlementItemTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x0003B084 File Offset: 0x0003A084
		public static bool ReadEntitlementItemTrans(XmlString xmlString, out EntitlementItemTrans data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x0003B090 File Offset: 0x0003A090
		public static bool Reader(XmlString xmlString, out List<EntitlementItemTrans> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfEntitlementItemTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<EntitlementItemTrans>();
						if (XSD2CPP.ReadArrayOfEntitlementItemTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C53 RID: 7251 RVA: 0x0003B0EC File Offset: 0x0003A0EC
		public static bool ReadArrayOfEntitlementItemTrans(XmlString xmlString, out List<EntitlementItemTrans> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C54 RID: 7252 RVA: 0x0003B0F8 File Offset: 0x0003A0F8
		public static bool Reader(XmlString xmlString, out CategoryTrans data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "CategoryTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new CategoryTrans();
						if (XSD2CPP.ReadCategoryTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C55 RID: 7253 RVA: 0x0003B154 File Offset: 0x0003A154
		public static bool ReadCategoryTrans(XmlString xmlString, out CategoryTrans data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x0003B160 File Offset: 0x0003A160
		public static bool Reader(XmlString xmlString, out List<CategoryTrans> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfCategoryTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<CategoryTrans>();
						if (XSD2CPP.ReadArrayOfCategoryTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C57 RID: 7255 RVA: 0x0003B1BC File Offset: 0x0003A1BC
		public static bool ReadArrayOfCategoryTrans(XmlString xmlString, out List<CategoryTrans> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x0003B1C8 File Offset: 0x0003A1C8
		public static bool Reader(XmlString xmlString, out CommerceSessionTrans data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "CommerceSessionTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new CommerceSessionTrans();
						if (XSD2CPP.ReadCommerceSessionTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C59 RID: 7257 RVA: 0x0003B224 File Offset: 0x0003A224
		public static bool ReadCommerceSessionTrans(XmlString xmlString, out CommerceSessionTrans data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C5A RID: 7258 RVA: 0x0003B230 File Offset: 0x0003A230
		public static bool Reader(XmlString xmlString, out CommerceSessionResultTrans data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "CommerceSessionResultTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new CommerceSessionResultTrans();
						if (XSD2CPP.ReadCommerceSessionResultTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C5B RID: 7259 RVA: 0x0003B28C File Offset: 0x0003A28C
		public static bool ReadCommerceSessionResultTrans(XmlString xmlString, out CommerceSessionResultTrans data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C5C RID: 7260 RVA: 0x0003B298 File Offset: 0x0003A298
		public static bool Reader(XmlString xmlString, out ClientServerCryptoTicket data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ClientServerCryptoTicket"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new ClientServerCryptoTicket();
						if (XSD2CPP.ReadClientServerCryptoTicketClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C5D RID: 7261 RVA: 0x0003B2F4 File Offset: 0x0003A2F4
		public static bool ReadClientServerCryptoTicket(XmlString xmlString, out ClientServerCryptoTicket data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C5E RID: 7262 RVA: 0x0003B300 File Offset: 0x0003A300
		public static bool Reader(XmlString xmlString, out UdpRelayCryptoTicket data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "UdpRelayCryptoTicket"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new UdpRelayCryptoTicket();
						if (XSD2CPP.ReadUdpRelayCryptoTicketClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C5F RID: 7263 RVA: 0x0003B35C File Offset: 0x0003A35C
		public static bool ReadUdpRelayCryptoTicket(XmlString xmlString, out UdpRelayCryptoTicket data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C60 RID: 7264 RVA: 0x0003B368 File Offset: 0x0003A368
		public static bool Reader(XmlString xmlString, out UdpRelayInfo data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "UdpRelayInfo"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new UdpRelayInfo();
						if (XSD2CPP.ReadUdpRelayInfoClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C61 RID: 7265 RVA: 0x0003B3C4 File Offset: 0x0003A3C4
		public static bool ReadUdpRelayInfo(XmlString xmlString, out UdpRelayInfo data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C62 RID: 7266 RVA: 0x0003B3D0 File Offset: 0x0003A3D0
		public static bool Reader(XmlString xmlString, out List<UdpRelayInfo> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfUdpRelayInfo"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<UdpRelayInfo>();
						if (XSD2CPP.ReadArrayOfUdpRelayInfoClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C63 RID: 7267 RVA: 0x0003B42C File Offset: 0x0003A42C
		public static bool ReadArrayOfUdpRelayInfo(XmlString xmlString, out List<UdpRelayInfo> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C64 RID: 7268 RVA: 0x0003B438 File Offset: 0x0003A438
		public static bool Reader(XmlString xmlString, out RegionInfo data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "RegionInfo"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new RegionInfo();
						if (XSD2CPP.ReadRegionInfoClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C65 RID: 7269 RVA: 0x0003B494 File Offset: 0x0003A494
		public static bool ReadRegionInfo(XmlString xmlString, out RegionInfo data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C66 RID: 7270 RVA: 0x0003B4A0 File Offset: 0x0003A4A0
		public static bool Reader(XmlString xmlString, out CarSlotInfoTrans data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "CarSlotInfoTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new CarSlotInfoTrans();
						if (XSD2CPP.ReadCarSlotInfoTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001C67 RID: 7271 RVA: 0x0003B4FC File Offset: 0x0003A4FC
		public static bool ReadCarSlotInfoTrans(XmlString xmlString, out CarSlotInfoTrans data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x0003B505 File Offset: 0x0003A505
		private static void WriteMetagameFlags(XmlParser doc, MetagameFlags data)
		{
			Xsd2CppUtil.WriteString(doc, data.ToString());
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x0003B519 File Offset: 0x0003A519
		private static void WriteenumPowerUpType(XmlParser doc, enumPowerUpType data)
		{
			Xsd2CppUtil.WriteString(doc, data.ToString());
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x0003B52D File Offset: 0x0003A52D
		private static void WriteCommerceResultStatus(XmlParser doc, CommerceResultStatus data)
		{
			Xsd2CppUtil.WriteString(doc, data.ToString());
		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x0003B544 File Offset: 0x0003A544
		private static void WriteClientLog(XmlParser doc, ClientLog data)
		{
			doc.AddChild("date");
			Xsd2CppUtil.WriteDateTime(doc, data.date);
			doc.Parent();
			doc.AddChild("message");
			Xsd2CppUtil.WriteString(doc, data.message);
			doc.Parent();
		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x0003B591 File Offset: 0x0003A591
		private static void WriteBasketTrans(XmlParser doc, BasketTrans data)
		{
			doc.AddChild("Items");
			XSD2CPP.WriteArrayOfBasketItemTrans(doc, data.Items);
			doc.Parent();
		}

		// Token: 0x06001C6D RID: 7277 RVA: 0x0003B5B4 File Offset: 0x0003A5B4
		private static void WriteCommerceItemTrans(XmlParser doc, CommerceItemTrans data)
		{
			doc.AddChild("Hash");
			Xsd2CppUtil.WriteInt(doc, data.Hash);
			doc.Parent();
			doc.AddChild("Title");
			Xsd2CppUtil.WriteString(doc, data.Title);
			doc.Parent();
		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x0003B604 File Offset: 0x0003A604
		private static void WriteArrayOfCommerceItemTrans(XmlParser doc, List<CommerceItemTrans> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("CommerceItemTrans");
				XSD2CPP.WriteCommerceItemTrans(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x0003B642 File Offset: 0x0003A642
		private static void WriteInvalidBasketTrans(XmlParser doc, InvalidBasketTrans data)
		{
			doc.AddChild("Basket");
			XSD2CPP.WriteBasketTrans(doc, data.Basket);
			doc.Parent();
			doc.AddChild("InvalidItems");
			XSD2CPP.WriteArrayOfInvalidBasketItemTrans(doc, data.InvalidItems);
			doc.Parent();
		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x0003B684 File Offset: 0x0003A684
		private static void WriteCommerceResultTrans(XmlParser doc, CommerceResultTrans data)
		{
			doc.AddChild("CommerceItems");
			XSD2CPP.WriteArrayOfCommerceItemTrans(doc, data.CommerceItems);
			doc.Parent();
			doc.AddChild("InvalidBasket");
			XSD2CPP.WriteInvalidBasketTrans(doc, data.InvalidBasket);
			doc.Parent();
			doc.AddChild("InventoryItems");
			XSD2CPP.WriteArrayOfInventoryItemTrans(doc, data.InventoryItems);
			doc.Parent();
			doc.AddChild("PurchasedCars");
			XSD2CPP.WriteArrayOfOwnedCarTrans(doc, data.PurchasedCars);
			doc.Parent();
			doc.AddChild("Status");
			XSD2CPP.WriteCommerceResultStatus(doc, data.Status);
			doc.Parent();
			doc.AddChild("Wallets");
			XSD2CPP.WriteArrayOfWalletTrans(doc, data.Wallets);
			doc.Parent();
		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x0003B74C File Offset: 0x0003A74C
		private static void WriteBasketItemTrans(XmlParser doc, BasketItemTrans data)
		{
			doc.AddChild("ProductId");
			Xsd2CppUtil.WriteString(doc, data.ProductId);
			doc.Parent();
			doc.AddChild("Quantity");
			Xsd2CppUtil.WriteInt(doc, data.Quantity);
			doc.Parent();
		}

		// Token: 0x06001C72 RID: 7282 RVA: 0x0003B79C File Offset: 0x0003A79C
		private static void WriteArrayOfBasketItemTrans(XmlParser doc, List<BasketItemTrans> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("BasketItemTrans");
				XSD2CPP.WriteBasketItemTrans(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001C73 RID: 7283 RVA: 0x0003B7DC File Offset: 0x0003A7DC
		private static void WriteInvalidBasketItemTrans(XmlParser doc, InvalidBasketItemTrans data)
		{
			doc.AddChild("Index");
			Xsd2CppUtil.WriteInt(doc, data.Index);
			doc.Parent();
			doc.AddChild("Reason");
			Xsd2CppUtil.WriteInt(doc, data.Reason);
			doc.Parent();
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x0003B82C File Offset: 0x0003A82C
		private static void WriteArrayOfInvalidBasketItemTrans(XmlParser doc, List<InvalidBasketItemTrans> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("InvalidBasketItemTrans");
				XSD2CPP.WriteInvalidBasketItemTrans(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x0003B86C File Offset: 0x0003A86C
		private static void WriteInventoryItemTrans(XmlParser doc, InventoryItemTrans data)
		{
			doc.AddChild("EntitlementTag");
			Xsd2CppUtil.WriteString(doc, data.EntitlementTag);
			doc.Parent();
			doc.AddChild("ExpirationDate");
			Xsd2CppUtil.WriteDateTime(doc, data.ExpirationDate);
			doc.Parent();
			doc.AddChild("Hash");
			Xsd2CppUtil.WriteInt(doc, data.Hash);
			doc.Parent();
			doc.AddChild("InventoryId");
			Xsd2CppUtil.WriteLong(doc, data.InventoryId);
			doc.Parent();
			doc.AddChild("ProductId");
			Xsd2CppUtil.WriteString(doc, data.ProductId);
			doc.Parent();
			doc.AddChild("RemainingUseCount");
			Xsd2CppUtil.WriteLong(doc, data.RemainingUseCount);
			doc.Parent();
			doc.AddChild("ResellPrice");
			Xsd2CppUtil.WriteDouble(doc, data.ResellPrice);
			doc.Parent();
			doc.AddChild("Status");
			Xsd2CppUtil.WriteString(doc, data.Status);
			doc.Parent();
			doc.AddChild("StringHash");
			Xsd2CppUtil.WriteString(doc, data.StringHash);
			doc.Parent();
			doc.AddChild("VirtualItemType");
			Xsd2CppUtil.WriteString(doc, data.VirtualItemType);
			doc.Parent();
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x0003B9BC File Offset: 0x0003A9BC
		private static void WriteArrayOfInventoryItemTrans(XmlParser doc, List<InventoryItemTrans> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("InventoryItemTrans");
				XSD2CPP.WriteInventoryItemTrans(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x0003B9FC File Offset: 0x0003A9FC
		private static void WriteCustomCarTrans(XmlParser doc, CustomCarTrans data)
		{
			doc.AddChild("BaseCar");
			Xsd2CppUtil.WriteInt(doc, data.BaseCar);
			doc.Parent();
			doc.AddChild("CarClassHash");
			Xsd2CppUtil.WriteInt(doc, data.CarClassHash);
			doc.Parent();
			doc.AddChild("Id");
			Xsd2CppUtil.WriteInt(doc, data.Id);
			doc.Parent();
			doc.AddChild("IsPreset");
			Xsd2CppUtil.WriteBoolean(doc, data.IsPreset);
			doc.Parent();
			doc.AddChild("Level");
			Xsd2CppUtil.WriteInt(doc, data.Level);
			doc.Parent();
			doc.AddChild("Name");
			Xsd2CppUtil.WriteString(doc, data.Name);
			doc.Parent();
			doc.AddChild("Paints");
			XSD2CPP.WriteArrayOfCustomPaintTrans(doc, data.Paints);
			doc.Parent();
			doc.AddChild("PerformanceParts");
			XSD2CPP.WriteArrayOfPerformancePartTrans(doc, data.PerformanceParts);
			doc.Parent();
			doc.AddChild("PhysicsProfileHash");
			Xsd2CppUtil.WriteInt(doc, data.PhysicsProfileHash);
			doc.Parent();
			doc.AddChild("Rating");
			Xsd2CppUtil.WriteInt(doc, data.Rating);
			doc.Parent();
			doc.AddChild("ResalePrice");
			Xsd2CppUtil.WriteFloat(doc, data.ResalePrice);
			doc.Parent();
			doc.AddChild("RideHeightDrop");
			Xsd2CppUtil.WriteFloat(doc, data.RideHeightDrop);
			doc.Parent();
			doc.AddChild("SkillModParts");
			XSD2CPP.WriteArrayOfSkillModPartTrans(doc, data.SkillModParts);
			doc.Parent();
			doc.AddChild("SkillModSlotCount");
			Xsd2CppUtil.WriteInt(doc, data.SkillModSlotCount);
			doc.Parent();
			doc.AddChild("Version");
			Xsd2CppUtil.WriteInt(doc, data.Version);
			doc.Parent();
			doc.AddChild("Vinyls");
			XSD2CPP.WriteArrayOfCustomVinylTrans(doc, data.Vinyls);
			doc.Parent();
			doc.AddChild("VisualParts");
			XSD2CPP.WriteArrayOfVisualPartTrans(doc, data.VisualParts);
			doc.Parent();
		}

		// Token: 0x06001C78 RID: 7288 RVA: 0x0003BC24 File Offset: 0x0003AC24
		private static void WriteOwnedCarTrans(XmlParser doc, OwnedCarTrans data)
		{
			doc.AddChild("CustomCar");
			XSD2CPP.WriteCustomCarTrans(doc, data.CustomCar);
			doc.Parent();
			doc.AddChild("Durability");
			Xsd2CppUtil.WriteInt(doc, data.Durability);
			doc.Parent();
			doc.AddChild("ExpirationDate");
			Xsd2CppUtil.WriteDateTime(doc, data.ExpirationDate);
			doc.Parent();
			doc.AddChild("Heat");
			Xsd2CppUtil.WriteFloat(doc, data.Heat);
			doc.Parent();
			doc.AddChild("Id");
			Xsd2CppUtil.WriteLong(doc, data.Id);
			doc.Parent();
			doc.AddChild("OwnershipType");
			Xsd2CppUtil.WriteString(doc, data.OwnershipType);
			doc.Parent();
		}

		// Token: 0x06001C79 RID: 7289 RVA: 0x0003BCF0 File Offset: 0x0003ACF0
		private static void WriteArrayOfOwnedCarTrans(XmlParser doc, List<OwnedCarTrans> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("OwnedCarTrans");
				XSD2CPP.WriteOwnedCarTrans(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001C7A RID: 7290 RVA: 0x0003BD30 File Offset: 0x0003AD30
		private static void WriteCustomPaintTrans(XmlParser doc, CustomPaintTrans data)
		{
			doc.AddChild("Group");
			Xsd2CppUtil.WriteInt(doc, data.Group);
			doc.Parent();
			doc.AddChild("Hue");
			Xsd2CppUtil.WriteInt(doc, data.Hue);
			doc.Parent();
			doc.AddChild("Sat");
			Xsd2CppUtil.WriteInt(doc, data.Sat);
			doc.Parent();
			doc.AddChild("Slot");
			Xsd2CppUtil.WriteInt(doc, data.Slot);
			doc.Parent();
			doc.AddChild("Var");
			Xsd2CppUtil.WriteInt(doc, data.Var);
			doc.Parent();
		}

		// Token: 0x06001C7B RID: 7291 RVA: 0x0003BDE0 File Offset: 0x0003ADE0
		private static void WriteArrayOfCustomPaintTrans(XmlParser doc, List<CustomPaintTrans> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("CustomPaintTrans");
				XSD2CPP.WriteCustomPaintTrans(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x0003BE1E File Offset: 0x0003AE1E
		private static void WritePerformancePartTrans(XmlParser doc, PerformancePartTrans data)
		{
			doc.AddChild("PerformancePartAttribHash");
			Xsd2CppUtil.WriteInt(doc, data.PerformancePartAttribHash);
			doc.Parent();
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x0003BE40 File Offset: 0x0003AE40
		private static void WriteArrayOfPerformancePartTrans(XmlParser doc, List<PerformancePartTrans> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("PerformancePartTrans");
				XSD2CPP.WritePerformancePartTrans(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x0003BE80 File Offset: 0x0003AE80
		private static void WriteSkillModPartTrans(XmlParser doc, SkillModPartTrans data)
		{
			doc.AddChild("IsFixed");
			Xsd2CppUtil.WriteBoolean(doc, data.IsFixed);
			doc.Parent();
			doc.AddChild("SkillModPartAttribHash");
			Xsd2CppUtil.WriteInt(doc, data.SkillModPartAttribHash);
			doc.Parent();
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x0003BED0 File Offset: 0x0003AED0
		private static void WriteArrayOfSkillModPartTrans(XmlParser doc, List<SkillModPartTrans> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("SkillModPartTrans");
				XSD2CPP.WriteSkillModPartTrans(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001C80 RID: 7296 RVA: 0x0003BF10 File Offset: 0x0003AF10
		private static void WriteCustomVinylTrans(XmlParser doc, CustomVinylTrans data)
		{
			doc.AddChild("Hash");
			Xsd2CppUtil.WriteInt(doc, data.Hash);
			doc.Parent();
			doc.AddChild("Hue1");
			Xsd2CppUtil.WriteInt(doc, data.Hue1);
			doc.Parent();
			doc.AddChild("Hue2");
			Xsd2CppUtil.WriteInt(doc, data.Hue2);
			doc.Parent();
			doc.AddChild("Hue3");
			Xsd2CppUtil.WriteInt(doc, data.Hue3);
			doc.Parent();
			doc.AddChild("Hue4");
			Xsd2CppUtil.WriteInt(doc, data.Hue4);
			doc.Parent();
			doc.AddChild("Layer");
			Xsd2CppUtil.WriteInt(doc, data.Layer);
			doc.Parent();
			doc.AddChild("Mir");
			Xsd2CppUtil.WriteBoolean(doc, data.Mir);
			doc.Parent();
			doc.AddChild("Rot");
			Xsd2CppUtil.WriteInt(doc, data.Rot);
			doc.Parent();
			doc.AddChild("Sat1");
			Xsd2CppUtil.WriteInt(doc, data.Sat1);
			doc.Parent();
			doc.AddChild("Sat2");
			Xsd2CppUtil.WriteInt(doc, data.Sat2);
			doc.Parent();
			doc.AddChild("Sat3");
			Xsd2CppUtil.WriteInt(doc, data.Sat3);
			doc.Parent();
			doc.AddChild("Sat4");
			Xsd2CppUtil.WriteInt(doc, data.Sat4);
			doc.Parent();
			doc.AddChild("ScaleX");
			Xsd2CppUtil.WriteInt(doc, data.ScaleX);
			doc.Parent();
			doc.AddChild("ScaleY");
			Xsd2CppUtil.WriteInt(doc, data.ScaleY);
			doc.Parent();
			doc.AddChild("Shear");
			Xsd2CppUtil.WriteInt(doc, data.Shear);
			doc.Parent();
			doc.AddChild("TranX");
			Xsd2CppUtil.WriteInt(doc, data.TranX);
			doc.Parent();
			doc.AddChild("TranY");
			Xsd2CppUtil.WriteInt(doc, data.TranY);
			doc.Parent();
			doc.AddChild("Var1");
			Xsd2CppUtil.WriteInt(doc, data.Var1);
			doc.Parent();
			doc.AddChild("Var2");
			Xsd2CppUtil.WriteInt(doc, data.Var2);
			doc.Parent();
			doc.AddChild("Var3");
			Xsd2CppUtil.WriteInt(doc, data.Var3);
			doc.Parent();
			doc.AddChild("Var4");
			Xsd2CppUtil.WriteInt(doc, data.Var4);
			doc.Parent();
		}

		// Token: 0x06001C81 RID: 7297 RVA: 0x0003C1C0 File Offset: 0x0003B1C0
		private static void WriteArrayOfCustomVinylTrans(XmlParser doc, List<CustomVinylTrans> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("CustomVinylTrans");
				XSD2CPP.WriteCustomVinylTrans(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x0003C200 File Offset: 0x0003B200
		private static void WriteVisualPartTrans(XmlParser doc, VisualPartTrans data)
		{
			doc.AddChild("PartHash");
			Xsd2CppUtil.WriteInt(doc, data.PartHash);
			doc.Parent();
			doc.AddChild("SlotHash");
			Xsd2CppUtil.WriteInt(doc, data.SlotHash);
			doc.Parent();
		}

		// Token: 0x06001C83 RID: 7299 RVA: 0x0003C250 File Offset: 0x0003B250
		private static void WriteArrayOfVisualPartTrans(XmlParser doc, List<VisualPartTrans> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("VisualPartTrans");
				XSD2CPP.WriteVisualPartTrans(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001C84 RID: 7300 RVA: 0x0003C290 File Offset: 0x0003B290
		private static void WriteWalletTrans(XmlParser doc, WalletTrans data)
		{
			doc.AddChild("Balance");
			Xsd2CppUtil.WriteDouble(doc, data.Balance);
			doc.Parent();
			doc.AddChild("Currency");
			Xsd2CppUtil.WriteString(doc, data.Currency);
			doc.Parent();
		}

		// Token: 0x06001C85 RID: 7301 RVA: 0x0003C2E0 File Offset: 0x0003B2E0
		private static void WriteArrayOfWalletTrans(XmlParser doc, List<WalletTrans> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("WalletTrans");
				XSD2CPP.WriteWalletTrans(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001C86 RID: 7302 RVA: 0x0003C320 File Offset: 0x0003B320
		private static void WriteCredentials(XmlParser doc, Credentials data)
		{
			doc.AddChild("Email");
			Xsd2CppUtil.WriteString(doc, data.Email);
			doc.Parent();
			doc.AddChild("Password");
			Xsd2CppUtil.WriteString(doc, data.Password);
			doc.Parent();
			doc.AddChild("Region");
			Xsd2CppUtil.WriteString(doc, data.Region);
			doc.Parent();
		}

		// Token: 0x06001C87 RID: 7303 RVA: 0x0003C390 File Offset: 0x0003B390
		private static void WriteToken(XmlParser doc, Token data)
		{
			doc.AddChild("EualaAccepted");
			Xsd2CppUtil.WriteBoolean(doc, data.EualaAccepted);
			doc.Parent();
			doc.AddChild("Region");
			Xsd2CppUtil.WriteString(doc, data.Region);
			doc.Parent();
			doc.AddChild("Value");
			Xsd2CppUtil.WriteString(doc, data.Value);
			doc.Parent();
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x0003C400 File Offset: 0x0003B400
		private static void WriteGetPermanentSessionData(XmlParser doc, GetPermanentSessionData data)
		{
			doc.AddChild("machineID");
			Xsd2CppUtil.WriteLong(doc, data.machineID);
			doc.Parent();
			doc.AddChild("version");
			Xsd2CppUtil.WriteString(doc, data.version);
			doc.Parent();
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x0003C44D File Offset: 0x0003B44D
		private static void WriteClientConfigTrans(XmlParser doc, ClientConfigTrans data)
		{
			doc.AddChild("clientConfigs");
			XSD2CPP.WriteArrayOfClientConfig(doc, data.clientConfigs);
			doc.Parent();
		}

		// Token: 0x06001C8A RID: 7306 RVA: 0x0003C470 File Offset: 0x0003B470
		private static void WriteClientConfig(XmlParser doc, ClientConfig data)
		{
			doc.AddChild("group");
			Xsd2CppUtil.WriteString(doc, data.group);
			doc.Parent();
			doc.AddChild("level");
			Xsd2CppUtil.WriteLong(doc, data.level);
			doc.Parent();
		}

		// Token: 0x06001C8B RID: 7307 RVA: 0x0003C4C0 File Offset: 0x0003B4C0
		private static void WriteArrayOfClientConfig(XmlParser doc, List<ClientConfig> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("ClientConfig");
				XSD2CPP.WriteClientConfig(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001C8C RID: 7308 RVA: 0x0003C500 File Offset: 0x0003B500
		private static void WriteUser_Settings(XmlParser doc, User_Settings data)
		{
			doc.AddChild("CarCacheAgeLimit");
			Xsd2CppUtil.WriteInt(doc, data.CarCacheAgeLimit);
			doc.Parent();
			doc.AddChild("IsRaceNowEnabled");
			Xsd2CppUtil.WriteBoolean(doc, data.IsRaceNowEnabled);
			doc.Parent();
			doc.AddChild("MaxCarCacheSize");
			Xsd2CppUtil.WriteInt(doc, data.MaxCarCacheSize);
			doc.Parent();
			doc.AddChild("MinRaceNowLevel");
			Xsd2CppUtil.WriteInt(doc, data.MinRaceNowLevel);
			doc.Parent();
			doc.AddChild("VoipAvailable");
			Xsd2CppUtil.WriteBoolean(doc, data.VoipAvailable);
			doc.Parent();
			doc.AddChild("activatedHolidaySceneryGroups");
			XSD2CPP.WriteArrayOfstring(doc, data.activatedHolidaySceneryGroups);
			doc.Parent();
			doc.AddChild("activeHolidayIds");
			XSD2CPP.WriteArrayOflong(doc, data.activeHolidayIds);
			doc.Parent();
			doc.AddChild("disactivatedHolidaySceneryGroups");
			XSD2CPP.WriteArrayOfstring(doc, data.disactivatedHolidaySceneryGroups);
			doc.Parent();
			doc.AddChild("firstTimeLogin");
			Xsd2CppUtil.WriteBoolean(doc, data.firstTimeLogin);
			doc.Parent();
			doc.AddChild("maxLevel");
			Xsd2CppUtil.WriteInt(doc, data.maxLevel);
			doc.Parent();
			doc.AddChild("starterPackApplied");
			Xsd2CppUtil.WriteBoolean(doc, data.starterPackApplied);
			doc.Parent();
			doc.AddChild("userId");
			Xsd2CppUtil.WriteLong(doc, data.userId);
			doc.Parent();
		}

		// Token: 0x06001C8D RID: 7309 RVA: 0x0003C68C File Offset: 0x0003B68C
		private static void WriteHardwareInfo(XmlParser doc, HardwareInfo data)
		{
			doc.AddChild("availableMem");
			Xsd2CppUtil.WriteUInt(doc, data.availableMem);
			doc.Parent();
			doc.AddChild("cpuBrand");
			Xsd2CppUtil.WriteString(doc, data.cpuBrand);
			doc.Parent();
			doc.AddChild("cpuid0");
			Xsd2CppUtil.WriteString(doc, data.cpuid0);
			doc.Parent();
			doc.AddChild("cpuid1_0");
			Xsd2CppUtil.WriteUInt(doc, data.cpuid1_0);
			doc.Parent();
			doc.AddChild("cpuid1_1");
			Xsd2CppUtil.WriteUInt(doc, data.cpuid1_1);
			doc.Parent();
			doc.AddChild("cpuid1_2");
			Xsd2CppUtil.WriteUInt(doc, data.cpuid1_2);
			doc.Parent();
			doc.AddChild("cpuid1_3");
			Xsd2CppUtil.WriteUInt(doc, data.cpuid1_3);
			doc.Parent();
			doc.AddChild("deviceID");
			Xsd2CppUtil.WriteUInt(doc, data.deviceID);
			doc.Parent();
			doc.AddChild("excpuid1_0");
			Xsd2CppUtil.WriteUInt(doc, data.excpuid1_0);
			doc.Parent();
			doc.AddChild("excpuid1_1");
			Xsd2CppUtil.WriteUInt(doc, data.excpuid1_1);
			doc.Parent();
			doc.AddChild("excpuid1_2");
			Xsd2CppUtil.WriteUInt(doc, data.excpuid1_2);
			doc.Parent();
			doc.AddChild("excpuid1_3");
			Xsd2CppUtil.WriteUInt(doc, data.excpuid1_3);
			doc.Parent();
			doc.AddChild("gpuDescription");
			Xsd2CppUtil.WriteString(doc, data.gpuDescription);
			doc.Parent();
			doc.AddChild("gpuDriverBuild");
			Xsd2CppUtil.WriteUInt(doc, data.gpuDriverBuild);
			doc.Parent();
			doc.AddChild("gpuDriverSubversion");
			Xsd2CppUtil.WriteUInt(doc, data.gpuDriverSubversion);
			doc.Parent();
			doc.AddChild("gpuDriverVersion");
			Xsd2CppUtil.WriteUInt(doc, data.gpuDriverVersion);
			doc.Parent();
			doc.AddChild("gpuMemory");
			Xsd2CppUtil.WriteUInt(doc, data.gpuMemory);
			doc.Parent();
			doc.AddChild("gpuProduct");
			Xsd2CppUtil.WriteUInt(doc, data.gpuProduct);
			doc.Parent();
			doc.AddChild("osBuildNumber");
			Xsd2CppUtil.WriteUInt(doc, data.osBuildNumber);
			doc.Parent();
			doc.AddChild("osMajorVersion");
			Xsd2CppUtil.WriteUInt(doc, data.osMajorVersion);
			doc.Parent();
			doc.AddChild("osMinorVersion");
			Xsd2CppUtil.WriteUInt(doc, data.osMinorVersion);
			doc.Parent();
			doc.AddChild("physicalCores");
			Xsd2CppUtil.WriteUInt(doc, data.physicalCores);
			doc.Parent();
			doc.AddChild("platformID");
			Xsd2CppUtil.WriteUInt(doc, data.platformID);
			doc.Parent();
			doc.AddChild("processAffinityMask");
			Xsd2CppUtil.WriteUInt(doc, data.processAffinityMask);
			doc.Parent();
			doc.AddChild("servicePack");
			Xsd2CppUtil.WriteString(doc, data.servicePack);
			doc.Parent();
			doc.AddChild("systemAffinityMask");
			Xsd2CppUtil.WriteUInt(doc, data.systemAffinityMask);
			doc.Parent();
			doc.AddChild("totalMemory");
			Xsd2CppUtil.WriteUInt(doc, data.totalMemory);
			doc.Parent();
			doc.AddChild("userID");
			Xsd2CppUtil.WriteLong(doc, data.userID);
			doc.Parent();
			doc.AddChild("vendorID");
			Xsd2CppUtil.WriteUInt(doc, data.vendorID);
			doc.Parent();
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x0003CA3C File Offset: 0x0003BA3C
		private static void WriteUserSettings(XmlParser doc, UserSettings data)
		{
			doc.AddChild("desktopResHeight");
			Xsd2CppUtil.WriteUInt(doc, data.desktopResHeight);
			doc.Parent();
			doc.AddChild("desktopResWidth");
			Xsd2CppUtil.WriteUInt(doc, data.desktopResWidth);
			doc.Parent();
			doc.AddChild("fullscreen");
			Xsd2CppUtil.WriteBoolean(doc, data.fullscreen);
			doc.Parent();
			doc.AddChild("gameResHeight");
			Xsd2CppUtil.WriteUInt(doc, data.gameResHeight);
			doc.Parent();
			doc.AddChild("gameResWidth");
			Xsd2CppUtil.WriteUInt(doc, data.gameResWidth);
			doc.Parent();
			doc.AddChild("globalDetailLevel");
			Xsd2CppUtil.WriteUInt(doc, data.globalDetailLevel);
			doc.Parent();
			doc.AddChild("userID");
			Xsd2CppUtil.WriteLong(doc, data.userID);
			doc.Parent();
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x0003CB2C File Offset: 0x0003BB2C
		private static void WriteMachineIdentification(XmlParser doc, MachineIdentification data)
		{
			doc.AddChild("cpuID");
			Xsd2CppUtil.WriteUInt(doc, data.cpuID);
			doc.Parent();
			doc.AddChild("diskSerialNumber");
			Xsd2CppUtil.WriteString(doc, data.diskSerialNumber);
			doc.Parent();
			doc.AddChild("gpuID");
			Xsd2CppUtil.WriteUInt(doc, data.gpuID);
			doc.Parent();
			doc.AddChild("mac");
			Xsd2CppUtil.WriteLong(doc, data.mac);
			doc.Parent();
			doc.AddChild("machineName");
			Xsd2CppUtil.WriteString(doc, data.machineName);
			doc.Parent();
			doc.AddChild("userID");
			Xsd2CppUtil.WriteLong(doc, data.userID);
			doc.Parent();
			doc.AddChild("volumeName");
			Xsd2CppUtil.WriteString(doc, data.volumeName);
			doc.Parent();
			doc.AddChild("volumeSerialNumber");
			Xsd2CppUtil.WriteUInt(doc, data.volumeSerialNumber);
			doc.Parent();
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x0003CC3C File Offset: 0x0003BC3C
		private static void WriteLauncherStartTrans(XmlParser doc, LauncherStartTrans data)
		{
			doc.AddChild("autoLogin");
			Xsd2CppUtil.WriteString(doc, data.autoLogin);
			doc.Parent();
			doc.AddChild("autoStart");
			Xsd2CppUtil.WriteString(doc, data.autoStart);
			doc.Parent();
			doc.AddChild("language");
			Xsd2CppUtil.WriteString(doc, data.language);
			doc.Parent();
			doc.AddChild("languageCode");
			Xsd2CppUtil.WriteString(doc, data.languageCode);
			doc.Parent();
			doc.AddChild("region");
			Xsd2CppUtil.WriteString(doc, data.region);
			doc.Parent();
			doc.AddChild("sku");
			Xsd2CppUtil.WriteString(doc, data.sku);
			doc.Parent();
			doc.AddChild("userID");
			Xsd2CppUtil.WriteLong(doc, data.userID);
			doc.Parent();
		}

		// Token: 0x06001C91 RID: 7313 RVA: 0x0003CD2C File Offset: 0x0003BD2C
		private static void WriteLauncherEndTrans(XmlParser doc, LauncherEndTrans data)
		{
			doc.AddChild("leaveReasonID");
			Xsd2CppUtil.WriteString(doc, data.leaveReasonID);
			doc.Parent();
			doc.AddChild("patchTime");
			Xsd2CppUtil.WriteString(doc, data.patchTime);
			doc.Parent();
			doc.AddChild("userID");
			Xsd2CppUtil.WriteLong(doc, data.userID);
			doc.Parent();
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x0003CD9C File Offset: 0x0003BD9C
		private static void WriteVector3(XmlParser doc, Vector3 data)
		{
			doc.AddChild("X");
			Xsd2CppUtil.WriteFloat(doc, data.X);
			doc.Parent();
			doc.AddChild("Y");
			Xsd2CppUtil.WriteFloat(doc, data.Y);
			doc.Parent();
			doc.AddChild("Z");
			Xsd2CppUtil.WriteFloat(doc, data.Z);
			doc.Parent();
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x0003CE0C File Offset: 0x0003BE0C
		private static void WriteHeartBeat(XmlParser doc, HeartBeat data)
		{
			doc.AddChild("MetagameFlags");
			Xsd2CppUtil.WriteInt(doc, data.MetagameFlags);
			doc.Parent();
			doc.AddChild("enabledBitField");
			Xsd2CppUtil.WriteInt(doc, data.enabledBitField);
			doc.Parent();
		}

		// Token: 0x06001C94 RID: 7316 RVA: 0x0003CE5C File Offset: 0x0003BE5C
		private static void WriteFraudConfig(XmlParser doc, FraudConfig data)
		{
			doc.AddChild("enabledBitField");
			Xsd2CppUtil.WriteInt(doc, data.enabledBitField);
			doc.Parent();
			doc.AddChild("gameFileFreq");
			Xsd2CppUtil.WriteInt(doc, data.gameFileFreq);
			doc.Parent();
			doc.AddChild("moduleFreq");
			Xsd2CppUtil.WriteInt(doc, data.moduleFreq);
			doc.Parent();
			doc.AddChild("startUpFreq");
			Xsd2CppUtil.WriteInt(doc, data.startUpFreq);
			doc.Parent();
			doc.AddChild("userID");
			Xsd2CppUtil.WriteLong(doc, data.userID);
			doc.Parent();
		}

		// Token: 0x06001C95 RID: 7317 RVA: 0x0003CF0C File Offset: 0x0003BF0C
		private static void WriteProductTrans(XmlParser doc, ProductTrans data)
		{
			doc.AddChild("BundleItems");
			XSD2CPP.WriteArrayOfProductTrans(doc, data.BundleItems);
			doc.Parent();
			doc.AddChild("CategoryId");
			Xsd2CppUtil.WriteString(doc, data.CategoryId);
			doc.Parent();
			doc.AddChild("Currency");
			Xsd2CppUtil.WriteString(doc, data.Currency);
			doc.Parent();
			doc.AddChild("Description");
			Xsd2CppUtil.WriteString(doc, data.Description);
			doc.Parent();
			doc.AddChild("DurationMinute");
			Xsd2CppUtil.WriteInt(doc, data.DurationMinute);
			doc.Parent();
			doc.AddChild("Hash");
			Xsd2CppUtil.WriteInt(doc, data.Hash);
			doc.Parent();
			doc.AddChild("Icon");
			Xsd2CppUtil.WriteString(doc, data.Icon);
			doc.Parent();
			doc.AddChild("Level");
			Xsd2CppUtil.WriteInt(doc, data.Level);
			doc.Parent();
			doc.AddChild("LongDescription");
			Xsd2CppUtil.WriteString(doc, data.LongDescription);
			doc.Parent();
			doc.AddChild("Price");
			Xsd2CppUtil.WriteDouble(doc, data.Price);
			doc.Parent();
			doc.AddChild("Priority");
			Xsd2CppUtil.WriteInt(doc, data.Priority);
			doc.Parent();
			doc.AddChild("ProductId");
			Xsd2CppUtil.WriteString(doc, data.ProductId);
			doc.Parent();
			doc.AddChild("ProductTitle");
			Xsd2CppUtil.WriteString(doc, data.ProductTitle);
			doc.Parent();
			doc.AddChild("ProductType");
			Xsd2CppUtil.WriteString(doc, data.ProductType);
			doc.Parent();
			doc.AddChild("SecondaryIcon");
			Xsd2CppUtil.WriteString(doc, data.SecondaryIcon);
			doc.Parent();
			doc.AddChild("UseCount");
			Xsd2CppUtil.WriteInt(doc, data.UseCount);
			doc.Parent();
			doc.AddChild("VisualStyle");
			Xsd2CppUtil.WriteString(doc, data.VisualStyle);
			doc.Parent();
			doc.AddChild("WebIcon");
			Xsd2CppUtil.WriteString(doc, data.WebIcon);
			doc.Parent();
			doc.AddChild("WebLocation");
			Xsd2CppUtil.WriteString(doc, data.WebLocation);
			doc.Parent();
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x0003D178 File Offset: 0x0003C178
		private static void WriteArrayOfProductTrans(XmlParser doc, List<ProductTrans> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("ProductTrans");
				XSD2CPP.WriteProductTrans(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001C97 RID: 7319 RVA: 0x0003D1B8 File Offset: 0x0003C1B8
		private static void WriteInventoryTrans(XmlParser doc, InventoryTrans data)
		{
			doc.AddChild("InventoryItems");
			XSD2CPP.WriteArrayOfInventoryItemTrans(doc, data.InventoryItems);
			doc.Parent();
			doc.AddChild("PerformancePartsCapacity");
			Xsd2CppUtil.WriteLong(doc, data.PerformancePartsCapacity);
			doc.Parent();
			doc.AddChild("PerformancePartsUsedSlotCount");
			Xsd2CppUtil.WriteLong(doc, data.PerformancePartsUsedSlotCount);
			doc.Parent();
			doc.AddChild("SkillModPartsCapacity");
			Xsd2CppUtil.WriteLong(doc, data.SkillModPartsCapacity);
			doc.Parent();
			doc.AddChild("SkillModPartsUsedSlotCount");
			Xsd2CppUtil.WriteLong(doc, data.SkillModPartsUsedSlotCount);
			doc.Parent();
			doc.AddChild("VisualPartsCapacity");
			Xsd2CppUtil.WriteLong(doc, data.VisualPartsCapacity);
			doc.Parent();
			doc.AddChild("VisualPartsUsedSlotCount");
			Xsd2CppUtil.WriteLong(doc, data.VisualPartsUsedSlotCount);
			doc.Parent();
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x0003D2A4 File Offset: 0x0003C2A4
		private static void WriteEntitlementTrans(XmlParser doc, EntitlementTrans data)
		{
			doc.AddChild("Items");
			XSD2CPP.WriteArrayOfEntitlementItemTrans(doc, data.Items);
			doc.Parent();
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x0003D2C8 File Offset: 0x0003C2C8
		private static void WriteEntitlementItemTrans(XmlParser doc, EntitlementItemTrans data)
		{
			doc.AddChild("EntitlementId");
			Xsd2CppUtil.WriteString(doc, data.EntitlementId);
			doc.Parent();
			doc.AddChild("Quantity");
			Xsd2CppUtil.WriteInt(doc, data.Quantity);
			doc.Parent();
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x0003D318 File Offset: 0x0003C318
		private static void WriteArrayOfEntitlementItemTrans(XmlParser doc, List<EntitlementItemTrans> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("EntitlementItemTrans");
				XSD2CPP.WriteEntitlementItemTrans(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x0003D358 File Offset: 0x0003C358
		private static void WriteCategoryTrans(XmlParser doc, CategoryTrans data)
		{
			doc.AddChild("CatalogVersion");
			Xsd2CppUtil.WriteInt(doc, data.CatalogVersion);
			doc.Parent();
			doc.AddChild("Categories");
			XSD2CPP.WriteArrayOfCategoryTrans(doc, data.Categories);
			doc.Parent();
			doc.AddChild("DisplayName");
			Xsd2CppUtil.WriteString(doc, data.DisplayName);
			doc.Parent();
			doc.AddChild("FilterType");
			Xsd2CppUtil.WriteInt(doc, data.FilterType);
			doc.Parent();
			doc.AddChild("Icon");
			Xsd2CppUtil.WriteString(doc, data.Icon);
			doc.Parent();
			doc.AddChild("Id");
			Xsd2CppUtil.WriteString(doc, data.Id);
			doc.Parent();
			doc.AddChild("LongDescription");
			Xsd2CppUtil.WriteString(doc, data.LongDescription);
			doc.Parent();
			doc.AddChild("Name");
			Xsd2CppUtil.WriteString(doc, data.Name);
			doc.Parent();
			doc.AddChild("Priority");
			Xsd2CppUtil.WriteInt(doc, data.Priority);
			doc.Parent();
			doc.AddChild("Products");
			XSD2CPP.WriteArrayOfProductTrans(doc, data.Products);
			doc.Parent();
			doc.AddChild("ShortDescription");
			Xsd2CppUtil.WriteString(doc, data.ShortDescription);
			doc.Parent();
			doc.AddChild("ShowInNavigationPane");
			Xsd2CppUtil.WriteBoolean(doc, data.ShowInNavigationPane);
			doc.Parent();
			doc.AddChild("ShowPromoPage");
			Xsd2CppUtil.WriteBoolean(doc, data.ShowPromoPage);
			doc.Parent();
			doc.AddChild("WebIcon");
			Xsd2CppUtil.WriteString(doc, data.WebIcon);
			doc.Parent();
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x0003D524 File Offset: 0x0003C524
		private static void WriteArrayOfCategoryTrans(XmlParser doc, List<CategoryTrans> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("CategoryTrans");
				XSD2CPP.WriteCategoryTrans(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x0003D564 File Offset: 0x0003C564
		private static void WriteCommerceSessionTrans(XmlParser doc, CommerceSessionTrans data)
		{
			doc.AddChild("Basket");
			XSD2CPP.WriteBasketTrans(doc, data.Basket);
			doc.Parent();
			doc.AddChild("EntitlementsToSell");
			XSD2CPP.WriteEntitlementTrans(doc, data.EntitlementsToSell);
			doc.Parent();
			doc.AddChild("UpdatedCar");
			XSD2CPP.WriteOwnedCarTrans(doc, data.UpdatedCar);
			doc.Parent();
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x0003D5D0 File Offset: 0x0003C5D0
		private static void WriteCommerceSessionResultTrans(XmlParser doc, CommerceSessionResultTrans data)
		{
			doc.AddChild("InvalidBasket");
			XSD2CPP.WriteInvalidBasketTrans(doc, data.InvalidBasket);
			doc.Parent();
			doc.AddChild("InventoryItems");
			XSD2CPP.WriteArrayOfInventoryItemTrans(doc, data.InventoryItems);
			doc.Parent();
			doc.AddChild("Status");
			XSD2CPP.WriteCommerceResultStatus(doc, data.Status);
			doc.Parent();
			doc.AddChild("UpdatedCar");
			XSD2CPP.WriteOwnedCarTrans(doc, data.UpdatedCar);
			doc.Parent();
			doc.AddChild("Wallets");
			XSD2CPP.WriteArrayOfWalletTrans(doc, data.Wallets);
			doc.Parent();
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x0003D678 File Offset: 0x0003C678
		private static void WriteClientServerCryptoTicket(XmlParser doc, ClientServerCryptoTicket data)
		{
			doc.AddChild("CryptoTicket");
			Xsd2CppUtil.WriteString(doc, data.CryptoTicket);
			doc.Parent();
			doc.AddChild("SessionKey");
			Xsd2CppUtil.WriteString(doc, data.SessionKey);
			doc.Parent();
			doc.AddChild("TicketIv");
			Xsd2CppUtil.WriteString(doc, data.TicketIv);
			doc.Parent();
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x0003D6E8 File Offset: 0x0003C6E8
		private static void WriteUdpRelayCryptoTicket(XmlParser doc, UdpRelayCryptoTicket data)
		{
			doc.AddChild("CryptoTicket");
			Xsd2CppUtil.WriteString(doc, data.CryptoTicket);
			doc.Parent();
			doc.AddChild("SessionKey");
			Xsd2CppUtil.WriteString(doc, data.SessionKey);
			doc.Parent();
			doc.AddChild("TicketIv");
			Xsd2CppUtil.WriteString(doc, data.TicketIv);
			doc.Parent();
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x0003D758 File Offset: 0x0003C758
		private static void WriteUdpRelayInfo(XmlParser doc, UdpRelayInfo data)
		{
			doc.AddChild("Host");
			Xsd2CppUtil.WriteString(doc, data.Host);
			doc.Parent();
			doc.AddChild("Port");
			Xsd2CppUtil.WriteInt(doc, data.Port);
			doc.Parent();
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x0003D7A8 File Offset: 0x0003C7A8
		private static void WriteArrayOfUdpRelayInfo(XmlParser doc, List<UdpRelayInfo> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("UdpRelayInfo");
				XSD2CPP.WriteUdpRelayInfo(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x0003D7E8 File Offset: 0x0003C7E8
		private static void WriteRegionInfo(XmlParser doc, RegionInfo data)
		{
			doc.AddChild("CountdownProposalInMilliseconds");
			Xsd2CppUtil.WriteInt(doc, data.CountdownProposalInMilliseconds);
			doc.Parent();
			doc.AddChild("DirectConnectTimeoutInMilliseconds");
			Xsd2CppUtil.WriteInt(doc, data.DirectConnectTimeoutInMilliseconds);
			doc.Parent();
			doc.AddChild("DropOutTimeInMilliseconds");
			Xsd2CppUtil.WriteInt(doc, data.DropOutTimeInMilliseconds);
			doc.Parent();
			doc.AddChild("EventLoadTimeoutInMilliseconds");
			Xsd2CppUtil.WriteInt(doc, data.EventLoadTimeoutInMilliseconds);
			doc.Parent();
			doc.AddChild("HeartbeatIntervalInMilliseconds");
			Xsd2CppUtil.WriteInt(doc, data.HeartbeatIntervalInMilliseconds);
			doc.Parent();
			doc.AddChild("UdpRelayBandwidthInBps");
			Xsd2CppUtil.WriteInt(doc, data.UdpRelayBandwidthInBps);
			doc.Parent();
			doc.AddChild("UdpRelayTimeoutInMilliseconds");
			Xsd2CppUtil.WriteInt(doc, data.UdpRelayTimeoutInMilliseconds);
			doc.Parent();
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x0003D8D8 File Offset: 0x0003C8D8
		private static void WriteCarSlotInfoTrans(XmlParser doc, CarSlotInfoTrans data)
		{
			doc.AddChild("CarsOwnedByPersona");
			XSD2CPP.WriteArrayOfOwnedCarTrans(doc, data.CarsOwnedByPersona);
			doc.Parent();
			doc.AddChild("DefaultOwnedCarIndex");
			Xsd2CppUtil.WriteInt(doc, data.DefaultOwnedCarIndex);
			doc.Parent();
			doc.AddChild("ObtainableSlots");
			XSD2CPP.WriteArrayOfProductTrans(doc, data.ObtainableSlots);
			doc.Parent();
			doc.AddChild("OwnedCarSlotsCount");
			Xsd2CppUtil.WriteInt(doc, data.OwnedCarSlotsCount);
			doc.Parent();
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x0003D964 File Offset: 0x0003C964
		public static bool WriterXML(ClientLog data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ClientLog");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteClientLog(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x0003D9B5 File Offset: 0x0003C9B5
		public static bool Writer(ClientLog data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x0003D9BE File Offset: 0x0003C9BE
		public static bool WriteClientLog(ClientLog data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001CA8 RID: 7336 RVA: 0x0003D9C8 File Offset: 0x0003C9C8
		public static bool WriterXML(BasketTrans data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("BasketTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteBasketTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001CA9 RID: 7337 RVA: 0x0003DA19 File Offset: 0x0003CA19
		public static bool Writer(BasketTrans data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x0003DA22 File Offset: 0x0003CA22
		public static bool WriteBasketTrans(BasketTrans data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x0003DA2C File Offset: 0x0003CA2C
		public static bool WriterXML(CommerceItemTrans data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("CommerceItemTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteCommerceItemTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x0003DA7D File Offset: 0x0003CA7D
		public static bool Writer(CommerceItemTrans data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x0003DA86 File Offset: 0x0003CA86
		public static bool WriteCommerceItemTrans(CommerceItemTrans data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001CAE RID: 7342 RVA: 0x0003DA90 File Offset: 0x0003CA90
		public static bool WriterXML(List<CommerceItemTrans> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfCommerceItemTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfCommerceItemTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x0003DAE1 File Offset: 0x0003CAE1
		public static bool Writer(List<CommerceItemTrans> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x0003DAEA File Offset: 0x0003CAEA
		public static bool WriteArrayOfCommerceItemTrans(List<CommerceItemTrans> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x0003DAF4 File Offset: 0x0003CAF4
		public static bool WriterXML(InvalidBasketTrans data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("InvalidBasketTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteInvalidBasketTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001CB2 RID: 7346 RVA: 0x0003DB45 File Offset: 0x0003CB45
		public static bool Writer(InvalidBasketTrans data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x0003DB4E File Offset: 0x0003CB4E
		public static bool WriteInvalidBasketTrans(InvalidBasketTrans data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x0003DB58 File Offset: 0x0003CB58
		public static bool WriterXML(CommerceResultTrans data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("CommerceResultTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteCommerceResultTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x0003DBA9 File Offset: 0x0003CBA9
		public static bool Writer(CommerceResultTrans data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x0003DBB2 File Offset: 0x0003CBB2
		public static bool WriteCommerceResultTrans(CommerceResultTrans data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x0003DBBC File Offset: 0x0003CBBC
		public static bool WriterXML(BasketItemTrans data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("BasketItemTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteBasketItemTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x0003DC0D File Offset: 0x0003CC0D
		public static bool Writer(BasketItemTrans data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x0003DC16 File Offset: 0x0003CC16
		public static bool WriteBasketItemTrans(BasketItemTrans data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x0003DC20 File Offset: 0x0003CC20
		public static bool WriterXML(List<BasketItemTrans> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfBasketItemTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfBasketItemTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x0003DC71 File Offset: 0x0003CC71
		public static bool Writer(List<BasketItemTrans> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x0003DC7A File Offset: 0x0003CC7A
		public static bool WriteArrayOfBasketItemTrans(List<BasketItemTrans> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001CBD RID: 7357 RVA: 0x0003DC84 File Offset: 0x0003CC84
		public static bool WriterXML(InvalidBasketItemTrans data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("InvalidBasketItemTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteInvalidBasketItemTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001CBE RID: 7358 RVA: 0x0003DCD5 File Offset: 0x0003CCD5
		public static bool Writer(InvalidBasketItemTrans data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001CBF RID: 7359 RVA: 0x0003DCDE File Offset: 0x0003CCDE
		public static bool WriteInvalidBasketItemTrans(InvalidBasketItemTrans data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001CC0 RID: 7360 RVA: 0x0003DCE8 File Offset: 0x0003CCE8
		public static bool WriterXML(List<InvalidBasketItemTrans> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfInvalidBasketItemTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfInvalidBasketItemTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001CC1 RID: 7361 RVA: 0x0003DD39 File Offset: 0x0003CD39
		public static bool Writer(List<InvalidBasketItemTrans> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001CC2 RID: 7362 RVA: 0x0003DD42 File Offset: 0x0003CD42
		public static bool WriteArrayOfInvalidBasketItemTrans(List<InvalidBasketItemTrans> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001CC3 RID: 7363 RVA: 0x0003DD4C File Offset: 0x0003CD4C
		public static bool WriterXML(InventoryItemTrans data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("InventoryItemTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteInventoryItemTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001CC4 RID: 7364 RVA: 0x0003DD9D File Offset: 0x0003CD9D
		public static bool Writer(InventoryItemTrans data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001CC5 RID: 7365 RVA: 0x0003DDA6 File Offset: 0x0003CDA6
		public static bool WriteInventoryItemTrans(InventoryItemTrans data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001CC6 RID: 7366 RVA: 0x0003DDB0 File Offset: 0x0003CDB0
		public static bool WriterXML(List<InventoryItemTrans> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfInventoryItemTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfInventoryItemTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001CC7 RID: 7367 RVA: 0x0003DE01 File Offset: 0x0003CE01
		public static bool Writer(List<InventoryItemTrans> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001CC8 RID: 7368 RVA: 0x0003DE0A File Offset: 0x0003CE0A
		public static bool WriteArrayOfInventoryItemTrans(List<InventoryItemTrans> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001CC9 RID: 7369 RVA: 0x0003DE14 File Offset: 0x0003CE14
		public static bool WriterXML(CustomCarTrans data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("CustomCarTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteCustomCarTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001CCA RID: 7370 RVA: 0x0003DE65 File Offset: 0x0003CE65
		public static bool Writer(CustomCarTrans data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001CCB RID: 7371 RVA: 0x0003DE6E File Offset: 0x0003CE6E
		public static bool WriteCustomCarTrans(CustomCarTrans data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x0003DE78 File Offset: 0x0003CE78
		public static bool WriterXML(OwnedCarTrans data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("OwnedCarTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteOwnedCarTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001CCD RID: 7373 RVA: 0x0003DEC9 File Offset: 0x0003CEC9
		public static bool Writer(OwnedCarTrans data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x0003DED2 File Offset: 0x0003CED2
		public static bool WriteOwnedCarTrans(OwnedCarTrans data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x0003DEDC File Offset: 0x0003CEDC
		public static bool WriterXML(List<OwnedCarTrans> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfOwnedCarTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfOwnedCarTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x0003DF2D File Offset: 0x0003CF2D
		public static bool Writer(List<OwnedCarTrans> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x0003DF36 File Offset: 0x0003CF36
		public static bool WriteArrayOfOwnedCarTrans(List<OwnedCarTrans> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x0003DF40 File Offset: 0x0003CF40
		public static bool WriterXML(CustomPaintTrans data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("CustomPaintTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteCustomPaintTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x0003DF91 File Offset: 0x0003CF91
		public static bool Writer(CustomPaintTrans data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x0003DF9A File Offset: 0x0003CF9A
		public static bool WriteCustomPaintTrans(CustomPaintTrans data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x0003DFA4 File Offset: 0x0003CFA4
		public static bool WriterXML(List<CustomPaintTrans> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfCustomPaintTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfCustomPaintTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x0003DFF5 File Offset: 0x0003CFF5
		public static bool Writer(List<CustomPaintTrans> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x0003DFFE File Offset: 0x0003CFFE
		public static bool WriteArrayOfCustomPaintTrans(List<CustomPaintTrans> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x0003E008 File Offset: 0x0003D008
		public static bool WriterXML(PerformancePartTrans data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("PerformancePartTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WritePerformancePartTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001CD9 RID: 7385 RVA: 0x0003E059 File Offset: 0x0003D059
		public static bool Writer(PerformancePartTrans data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x0003E062 File Offset: 0x0003D062
		public static bool WritePerformancePartTrans(PerformancePartTrans data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x0003E06C File Offset: 0x0003D06C
		public static bool WriterXML(List<PerformancePartTrans> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfPerformancePartTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfPerformancePartTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x0003E0BD File Offset: 0x0003D0BD
		public static bool Writer(List<PerformancePartTrans> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x0003E0C6 File Offset: 0x0003D0C6
		public static bool WriteArrayOfPerformancePartTrans(List<PerformancePartTrans> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x0003E0D0 File Offset: 0x0003D0D0
		public static bool WriterXML(SkillModPartTrans data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("SkillModPartTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteSkillModPartTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x0003E121 File Offset: 0x0003D121
		public static bool Writer(SkillModPartTrans data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001CE0 RID: 7392 RVA: 0x0003E12A File Offset: 0x0003D12A
		public static bool WriteSkillModPartTrans(SkillModPartTrans data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001CE1 RID: 7393 RVA: 0x0003E134 File Offset: 0x0003D134
		public static bool WriterXML(List<SkillModPartTrans> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfSkillModPartTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfSkillModPartTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001CE2 RID: 7394 RVA: 0x0003E185 File Offset: 0x0003D185
		public static bool Writer(List<SkillModPartTrans> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001CE3 RID: 7395 RVA: 0x0003E18E File Offset: 0x0003D18E
		public static bool WriteArrayOfSkillModPartTrans(List<SkillModPartTrans> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001CE4 RID: 7396 RVA: 0x0003E198 File Offset: 0x0003D198
		public static bool WriterXML(CustomVinylTrans data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("CustomVinylTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteCustomVinylTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001CE5 RID: 7397 RVA: 0x0003E1E9 File Offset: 0x0003D1E9
		public static bool Writer(CustomVinylTrans data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001CE6 RID: 7398 RVA: 0x0003E1F2 File Offset: 0x0003D1F2
		public static bool WriteCustomVinylTrans(CustomVinylTrans data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001CE7 RID: 7399 RVA: 0x0003E1FC File Offset: 0x0003D1FC
		public static bool WriterXML(List<CustomVinylTrans> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfCustomVinylTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfCustomVinylTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001CE8 RID: 7400 RVA: 0x0003E24D File Offset: 0x0003D24D
		public static bool Writer(List<CustomVinylTrans> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x0003E256 File Offset: 0x0003D256
		public static bool WriteArrayOfCustomVinylTrans(List<CustomVinylTrans> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x0003E260 File Offset: 0x0003D260
		public static bool WriterXML(VisualPartTrans data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("VisualPartTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteVisualPartTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x0003E2B1 File Offset: 0x0003D2B1
		public static bool Writer(VisualPartTrans data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x0003E2BA File Offset: 0x0003D2BA
		public static bool WriteVisualPartTrans(VisualPartTrans data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x0003E2C4 File Offset: 0x0003D2C4
		public static bool WriterXML(List<VisualPartTrans> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfVisualPartTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfVisualPartTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x0003E315 File Offset: 0x0003D315
		public static bool Writer(List<VisualPartTrans> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x0003E31E File Offset: 0x0003D31E
		public static bool WriteArrayOfVisualPartTrans(List<VisualPartTrans> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001CF0 RID: 7408 RVA: 0x0003E328 File Offset: 0x0003D328
		public static bool WriterXML(WalletTrans data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("WalletTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteWalletTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001CF1 RID: 7409 RVA: 0x0003E379 File Offset: 0x0003D379
		public static bool Writer(WalletTrans data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001CF2 RID: 7410 RVA: 0x0003E382 File Offset: 0x0003D382
		public static bool WriteWalletTrans(WalletTrans data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001CF3 RID: 7411 RVA: 0x0003E38C File Offset: 0x0003D38C
		public static bool WriterXML(List<WalletTrans> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfWalletTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfWalletTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x0003E3DD File Offset: 0x0003D3DD
		public static bool Writer(List<WalletTrans> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x0003E3E6 File Offset: 0x0003D3E6
		public static bool WriteArrayOfWalletTrans(List<WalletTrans> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x0003E3F0 File Offset: 0x0003D3F0
		public static bool WriterXML(Credentials data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("Credentials");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteCredentials(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001CF7 RID: 7415 RVA: 0x0003E441 File Offset: 0x0003D441
		public static bool Writer(Credentials data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x0003E44A File Offset: 0x0003D44A
		public static bool WriteCredentials(Credentials data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x0003E454 File Offset: 0x0003D454
		public static bool WriterXML(Token data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("Token");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteToken(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001CFA RID: 7418 RVA: 0x0003E4A5 File Offset: 0x0003D4A5
		public static bool Writer(Token data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001CFB RID: 7419 RVA: 0x0003E4AE File Offset: 0x0003D4AE
		public static bool WriteToken(Token data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001CFC RID: 7420 RVA: 0x0003E4B8 File Offset: 0x0003D4B8
		public static bool WriterXML(GetPermanentSessionData data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("GetPermanentSessionData");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteGetPermanentSessionData(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001CFD RID: 7421 RVA: 0x0003E509 File Offset: 0x0003D509
		public static bool Writer(GetPermanentSessionData data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x0003E512 File Offset: 0x0003D512
		public static bool WriteGetPermanentSessionData(GetPermanentSessionData data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001CFF RID: 7423 RVA: 0x0003E51C File Offset: 0x0003D51C
		public static bool WriterXML(ClientConfigTrans data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ClientConfigTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteClientConfigTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001D00 RID: 7424 RVA: 0x0003E56D File Offset: 0x0003D56D
		public static bool Writer(ClientConfigTrans data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x0003E576 File Offset: 0x0003D576
		public static bool WriteClientConfigTrans(ClientConfigTrans data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001D02 RID: 7426 RVA: 0x0003E580 File Offset: 0x0003D580
		public static bool WriterXML(ClientConfig data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ClientConfig");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteClientConfig(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x0003E5D1 File Offset: 0x0003D5D1
		public static bool Writer(ClientConfig data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x0003E5DA File Offset: 0x0003D5DA
		public static bool WriteClientConfig(ClientConfig data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x0003E5E4 File Offset: 0x0003D5E4
		public static bool WriterXML(List<ClientConfig> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfClientConfig");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfClientConfig(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x0003E635 File Offset: 0x0003D635
		public static bool Writer(List<ClientConfig> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x0003E63E File Offset: 0x0003D63E
		public static bool WriteArrayOfClientConfig(List<ClientConfig> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001D08 RID: 7432 RVA: 0x0003E648 File Offset: 0x0003D648
		public static bool WriterXML(User_Settings data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("User_Settings");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteUser_Settings(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001D09 RID: 7433 RVA: 0x0003E699 File Offset: 0x0003D699
		public static bool Writer(User_Settings data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001D0A RID: 7434 RVA: 0x0003E6A2 File Offset: 0x0003D6A2
		public static bool WriteUser_Settings(User_Settings data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001D0B RID: 7435 RVA: 0x0003E6AC File Offset: 0x0003D6AC
		public static bool WriterXML(HardwareInfo data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("HardwareInfo");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteHardwareInfo(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x0003E6FD File Offset: 0x0003D6FD
		public static bool Writer(HardwareInfo data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x0003E706 File Offset: 0x0003D706
		public static bool WriteHardwareInfo(HardwareInfo data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001D0E RID: 7438 RVA: 0x0003E710 File Offset: 0x0003D710
		public static bool WriterXML(UserSettings data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("UserSettings");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteUserSettings(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001D0F RID: 7439 RVA: 0x0003E761 File Offset: 0x0003D761
		public static bool Writer(UserSettings data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x0003E76A File Offset: 0x0003D76A
		public static bool WriteUserSettings(UserSettings data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x0003E774 File Offset: 0x0003D774
		public static bool WriterXML(MachineIdentification data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("MachineIdentification");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteMachineIdentification(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001D12 RID: 7442 RVA: 0x0003E7C5 File Offset: 0x0003D7C5
		public static bool Writer(MachineIdentification data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001D13 RID: 7443 RVA: 0x0003E7CE File Offset: 0x0003D7CE
		public static bool WriteMachineIdentification(MachineIdentification data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001D14 RID: 7444 RVA: 0x0003E7D8 File Offset: 0x0003D7D8
		public static bool WriterXML(LauncherStartTrans data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("LauncherStartTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteLauncherStartTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001D15 RID: 7445 RVA: 0x0003E829 File Offset: 0x0003D829
		public static bool Writer(LauncherStartTrans data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001D16 RID: 7446 RVA: 0x0003E832 File Offset: 0x0003D832
		public static bool WriteLauncherStartTrans(LauncherStartTrans data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001D17 RID: 7447 RVA: 0x0003E83C File Offset: 0x0003D83C
		public static bool WriterXML(LauncherEndTrans data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("LauncherEndTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteLauncherEndTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x0003E88D File Offset: 0x0003D88D
		public static bool Writer(LauncherEndTrans data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001D19 RID: 7449 RVA: 0x0003E896 File Offset: 0x0003D896
		public static bool WriteLauncherEndTrans(LauncherEndTrans data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001D1A RID: 7450 RVA: 0x0003E8A0 File Offset: 0x0003D8A0
		public static bool WriterXML(Vector3 data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("Vector3");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteVector3(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001D1B RID: 7451 RVA: 0x0003E8F1 File Offset: 0x0003D8F1
		public static bool Writer(Vector3 data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001D1C RID: 7452 RVA: 0x0003E8FA File Offset: 0x0003D8FA
		public static bool WriteVector3(Vector3 data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001D1D RID: 7453 RVA: 0x0003E904 File Offset: 0x0003D904
		public static bool WriterXML(HeartBeat data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("HeartBeat");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteHeartBeat(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x0003E955 File Offset: 0x0003D955
		public static bool Writer(HeartBeat data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x0003E95E File Offset: 0x0003D95E
		public static bool WriteHeartBeat(HeartBeat data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001D20 RID: 7456 RVA: 0x0003E968 File Offset: 0x0003D968
		public static bool WriterXML(FraudConfig data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("FraudConfig");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteFraudConfig(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001D21 RID: 7457 RVA: 0x0003E9B9 File Offset: 0x0003D9B9
		public static bool Writer(FraudConfig data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001D22 RID: 7458 RVA: 0x0003E9C2 File Offset: 0x0003D9C2
		public static bool WriteFraudConfig(FraudConfig data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001D23 RID: 7459 RVA: 0x0003E9CC File Offset: 0x0003D9CC
		public static bool WriterXML(ProductTrans data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ProductTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteProductTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001D24 RID: 7460 RVA: 0x0003EA1D File Offset: 0x0003DA1D
		public static bool Writer(ProductTrans data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001D25 RID: 7461 RVA: 0x0003EA26 File Offset: 0x0003DA26
		public static bool WriteProductTrans(ProductTrans data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x0003EA30 File Offset: 0x0003DA30
		public static bool WriterXML(List<ProductTrans> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfProductTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfProductTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001D27 RID: 7463 RVA: 0x0003EA81 File Offset: 0x0003DA81
		public static bool Writer(List<ProductTrans> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001D28 RID: 7464 RVA: 0x0003EA8A File Offset: 0x0003DA8A
		public static bool WriteArrayOfProductTrans(List<ProductTrans> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001D29 RID: 7465 RVA: 0x0003EA94 File Offset: 0x0003DA94
		public static bool WriterXML(InventoryTrans data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("InventoryTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteInventoryTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001D2A RID: 7466 RVA: 0x0003EAE5 File Offset: 0x0003DAE5
		public static bool Writer(InventoryTrans data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001D2B RID: 7467 RVA: 0x0003EAEE File Offset: 0x0003DAEE
		public static bool WriteInventoryTrans(InventoryTrans data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001D2C RID: 7468 RVA: 0x0003EAF8 File Offset: 0x0003DAF8
		public static bool WriterXML(EntitlementTrans data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("EntitlementTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteEntitlementTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001D2D RID: 7469 RVA: 0x0003EB49 File Offset: 0x0003DB49
		public static bool Writer(EntitlementTrans data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001D2E RID: 7470 RVA: 0x0003EB52 File Offset: 0x0003DB52
		public static bool WriteEntitlementTrans(EntitlementTrans data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001D2F RID: 7471 RVA: 0x0003EB5C File Offset: 0x0003DB5C
		public static bool WriterXML(EntitlementItemTrans data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("EntitlementItemTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteEntitlementItemTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001D30 RID: 7472 RVA: 0x0003EBAD File Offset: 0x0003DBAD
		public static bool Writer(EntitlementItemTrans data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001D31 RID: 7473 RVA: 0x0003EBB6 File Offset: 0x0003DBB6
		public static bool WriteEntitlementItemTrans(EntitlementItemTrans data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001D32 RID: 7474 RVA: 0x0003EBC0 File Offset: 0x0003DBC0
		public static bool WriterXML(List<EntitlementItemTrans> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfEntitlementItemTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfEntitlementItemTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001D33 RID: 7475 RVA: 0x0003EC11 File Offset: 0x0003DC11
		public static bool Writer(List<EntitlementItemTrans> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001D34 RID: 7476 RVA: 0x0003EC1A File Offset: 0x0003DC1A
		public static bool WriteArrayOfEntitlementItemTrans(List<EntitlementItemTrans> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001D35 RID: 7477 RVA: 0x0003EC24 File Offset: 0x0003DC24
		public static bool WriterXML(CategoryTrans data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("CategoryTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteCategoryTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001D36 RID: 7478 RVA: 0x0003EC75 File Offset: 0x0003DC75
		public static bool Writer(CategoryTrans data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001D37 RID: 7479 RVA: 0x0003EC7E File Offset: 0x0003DC7E
		public static bool WriteCategoryTrans(CategoryTrans data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001D38 RID: 7480 RVA: 0x0003EC88 File Offset: 0x0003DC88
		public static bool WriterXML(List<CategoryTrans> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfCategoryTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfCategoryTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001D39 RID: 7481 RVA: 0x0003ECD9 File Offset: 0x0003DCD9
		public static bool Writer(List<CategoryTrans> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001D3A RID: 7482 RVA: 0x0003ECE2 File Offset: 0x0003DCE2
		public static bool WriteArrayOfCategoryTrans(List<CategoryTrans> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001D3B RID: 7483 RVA: 0x0003ECEC File Offset: 0x0003DCEC
		public static bool WriterXML(CommerceSessionTrans data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("CommerceSessionTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteCommerceSessionTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001D3C RID: 7484 RVA: 0x0003ED3D File Offset: 0x0003DD3D
		public static bool Writer(CommerceSessionTrans data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001D3D RID: 7485 RVA: 0x0003ED46 File Offset: 0x0003DD46
		public static bool WriteCommerceSessionTrans(CommerceSessionTrans data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001D3E RID: 7486 RVA: 0x0003ED50 File Offset: 0x0003DD50
		public static bool WriterXML(CommerceSessionResultTrans data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("CommerceSessionResultTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteCommerceSessionResultTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001D3F RID: 7487 RVA: 0x0003EDA1 File Offset: 0x0003DDA1
		public static bool Writer(CommerceSessionResultTrans data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001D40 RID: 7488 RVA: 0x0003EDAA File Offset: 0x0003DDAA
		public static bool WriteCommerceSessionResultTrans(CommerceSessionResultTrans data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001D41 RID: 7489 RVA: 0x0003EDB4 File Offset: 0x0003DDB4
		public static bool WriterXML(ClientServerCryptoTicket data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ClientServerCryptoTicket");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteClientServerCryptoTicket(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001D42 RID: 7490 RVA: 0x0003EE05 File Offset: 0x0003DE05
		public static bool Writer(ClientServerCryptoTicket data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001D43 RID: 7491 RVA: 0x0003EE0E File Offset: 0x0003DE0E
		public static bool WriteClientServerCryptoTicket(ClientServerCryptoTicket data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001D44 RID: 7492 RVA: 0x0003EE18 File Offset: 0x0003DE18
		public static bool WriterXML(UdpRelayCryptoTicket data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("UdpRelayCryptoTicket");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteUdpRelayCryptoTicket(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001D45 RID: 7493 RVA: 0x0003EE69 File Offset: 0x0003DE69
		public static bool Writer(UdpRelayCryptoTicket data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001D46 RID: 7494 RVA: 0x0003EE72 File Offset: 0x0003DE72
		public static bool WriteUdpRelayCryptoTicket(UdpRelayCryptoTicket data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x0003EE7C File Offset: 0x0003DE7C
		public static bool WriterXML(UdpRelayInfo data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("UdpRelayInfo");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteUdpRelayInfo(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001D48 RID: 7496 RVA: 0x0003EECD File Offset: 0x0003DECD
		public static bool Writer(UdpRelayInfo data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001D49 RID: 7497 RVA: 0x0003EED6 File Offset: 0x0003DED6
		public static bool WriteUdpRelayInfo(UdpRelayInfo data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001D4A RID: 7498 RVA: 0x0003EEE0 File Offset: 0x0003DEE0
		public static bool WriterXML(List<UdpRelayInfo> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfUdpRelayInfo");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfUdpRelayInfo(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001D4B RID: 7499 RVA: 0x0003EF31 File Offset: 0x0003DF31
		public static bool Writer(List<UdpRelayInfo> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x0003EF3A File Offset: 0x0003DF3A
		public static bool WriteArrayOfUdpRelayInfo(List<UdpRelayInfo> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001D4D RID: 7501 RVA: 0x0003EF44 File Offset: 0x0003DF44
		public static bool WriterXML(RegionInfo data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("RegionInfo");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteRegionInfo(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001D4E RID: 7502 RVA: 0x0003EF95 File Offset: 0x0003DF95
		public static bool Writer(RegionInfo data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001D4F RID: 7503 RVA: 0x0003EF9E File Offset: 0x0003DF9E
		public static bool WriteRegionInfo(RegionInfo data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001D50 RID: 7504 RVA: 0x0003EFA8 File Offset: 0x0003DFA8
		public static bool WriterXML(CarSlotInfoTrans data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("CarSlotInfoTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteCarSlotInfoTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001D51 RID: 7505 RVA: 0x0003EFF9 File Offset: 0x0003DFF9
		public static bool Writer(CarSlotInfoTrans data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001D52 RID: 7506 RVA: 0x0003F002 File Offset: 0x0003E002
		public static bool WriteCarSlotInfoTrans(CarSlotInfoTrans data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001D53 RID: 7507 RVA: 0x0003F00B File Offset: 0x0003E00B
		private static bool ReadLoginAnnouncementContextAttribute(string pValue, out LoginAnnouncementContext data)
		{
			return LoginAnnouncementContextConverter.Parse(pValue, out data);
		}

		// Token: 0x06001D54 RID: 7508 RVA: 0x0003F014 File Offset: 0x0003E014
		private static bool ReadLoginAnnouncementContext(XmlParser doc, out LoginAnnouncementContext data)
		{
			string value = doc.GetValue();
			return LoginAnnouncementContextConverter.Parse(value, out data);
		}

		// Token: 0x06001D55 RID: 7509 RVA: 0x0003F02F File Offset: 0x0003E02F
		private static bool ReadLoginAnnouncementTypeAttribute(string pValue, out LoginAnnouncementType data)
		{
			return LoginAnnouncementTypeConverter.Parse(pValue, out data);
		}

		// Token: 0x06001D56 RID: 7510 RVA: 0x0003F038 File Offset: 0x0003E038
		private static bool ReadLoginAnnouncementType(XmlParser doc, out LoginAnnouncementType data)
		{
			string value = doc.GetValue();
			return LoginAnnouncementTypeConverter.Parse(value, out data);
		}

		// Token: 0x06001D57 RID: 7511 RVA: 0x0003F053 File Offset: 0x0003E053
		private static void WriteLoginAnnouncementContext(XmlParser doc, LoginAnnouncementContext data)
		{
			Xsd2CppUtil.WriteString(doc, data.ToString());
		}

		// Token: 0x06001D58 RID: 7512 RVA: 0x0003F067 File Offset: 0x0003E067
		private static void WriteLoginAnnouncementType(XmlParser doc, LoginAnnouncementType data)
		{
			Xsd2CppUtil.WriteString(doc, data.ToString());
		}

		// Token: 0x06001D59 RID: 7513 RVA: 0x0003F07C File Offset: 0x0003E07C
		public static bool ReadCarClassClass(XmlParser doc, CarClass data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects.Event");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadCarClass(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D5A RID: 7514 RVA: 0x0003F0C4 File Offset: 0x0003E0C4
		public static bool ReadArrayOfCarClassClass(XmlParser doc, List<CarClass> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects.Event");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfCarClass(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D5B RID: 7515 RVA: 0x0003F10C File Offset: 0x0003E10C
		private static bool ReadCarClass(XmlParser doc, CarClass data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "CarClassHash";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.CarClassHash);
			}
			doc.Parent();
			pName = prefix + "MaxRating";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadShort(doc, out data.MaxRating);
			}
			doc.Parent();
			pName = prefix + "MinRating";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadShort(doc, out data.MinRating);
			}
			return true;
		}

		// Token: 0x06001D5C RID: 7516 RVA: 0x0003F1A0 File Offset: 0x0003E1A0
		private static bool ReadArrayOfCarClass(XmlParser doc, List<CarClass> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "CarClass";
			}
			for (;;)
			{
				CarClass carClass = new CarClass();
				if (!XSD2CPP.ReadCarClassClass(doc, carClass))
				{
					break;
				}
				data.Add(carClass);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001D5D RID: 7517 RVA: 0x0003F1F0 File Offset: 0x0003E1F0
		public static bool Reader(XmlString xmlString, out CarClass data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "CarClass"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new CarClass();
						if (XSD2CPP.ReadCarClassClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001D5E RID: 7518 RVA: 0x0003F24C File Offset: 0x0003E24C
		public static bool ReadCarClass(XmlString xmlString, out CarClass data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001D5F RID: 7519 RVA: 0x0003F258 File Offset: 0x0003E258
		public static bool Reader(XmlString xmlString, out List<CarClass> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfCarClass"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<CarClass>();
						if (XSD2CPP.ReadArrayOfCarClassClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001D60 RID: 7520 RVA: 0x0003F2B4 File Offset: 0x0003E2B4
		public static bool ReadArrayOfCarClass(XmlString xmlString, out List<CarClass> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001D61 RID: 7521 RVA: 0x0003F2C0 File Offset: 0x0003E2C0
		private static void WriteCarClass(XmlParser doc, CarClass data)
		{
			doc.AddChild("CarClassHash");
			Xsd2CppUtil.WriteInt(doc, data.CarClassHash);
			doc.Parent();
			doc.AddChild("MaxRating");
			Xsd2CppUtil.WriteShort(doc, data.MaxRating);
			doc.Parent();
			doc.AddChild("MinRating");
			Xsd2CppUtil.WriteShort(doc, data.MinRating);
			doc.Parent();
		}

		// Token: 0x06001D62 RID: 7522 RVA: 0x0003F330 File Offset: 0x0003E330
		private static void WriteArrayOfCarClass(XmlParser doc, List<CarClass> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("CarClass");
				XSD2CPP.WriteCarClass(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001D63 RID: 7523 RVA: 0x0003F370 File Offset: 0x0003E370
		public static bool WriterXML(CarClass data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("CarClass");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects.Event");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteCarClass(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001D64 RID: 7524 RVA: 0x0003F3C1 File Offset: 0x0003E3C1
		public static bool Writer(CarClass data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001D65 RID: 7525 RVA: 0x0003F3CA File Offset: 0x0003E3CA
		public static bool WriteCarClass(CarClass data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001D66 RID: 7526 RVA: 0x0003F3D4 File Offset: 0x0003E3D4
		public static bool WriterXML(List<CarClass> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfCarClass");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects.Event");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfCarClass(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001D67 RID: 7527 RVA: 0x0003F425 File Offset: 0x0003E425
		public static bool Writer(List<CarClass> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001D68 RID: 7528 RVA: 0x0003F42E File Offset: 0x0003E42E
		public static bool WriteArrayOfCarClass(List<CarClass> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001D69 RID: 7529 RVA: 0x0003F438 File Offset: 0x0003E438
		public static bool ReadAchievementsAwardedClass(XmlParser doc, AchievementsAwarded data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadAchievementsAwarded(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D6A RID: 7530 RVA: 0x0003F480 File Offset: 0x0003E480
		public static bool ReadAchievementAwardedClass(XmlParser doc, AchievementAwarded data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadAchievementAwarded(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D6B RID: 7531 RVA: 0x0003F4C8 File Offset: 0x0003E4C8
		public static bool ReadArrayOfAchievementAwardedClass(XmlParser doc, List<AchievementAwarded> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfAchievementAwarded(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D6C RID: 7532 RVA: 0x0003F510 File Offset: 0x0003E510
		public static bool ReadBadgePacketClass(XmlParser doc, BadgePacket data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadBadgePacket(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D6D RID: 7533 RVA: 0x0003F558 File Offset: 0x0003E558
		public static bool ReadArrayOfBadgePacketClass(XmlParser doc, List<BadgePacket> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfBadgePacket(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D6E RID: 7534 RVA: 0x0003F5A0 File Offset: 0x0003E5A0
		public static bool ReadAchievementProgressClass(XmlParser doc, AchievementProgress data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadAchievementProgress(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D6F RID: 7535 RVA: 0x0003F5E8 File Offset: 0x0003E5E8
		public static bool ReadArrayOfAchievementProgressClass(XmlParser doc, List<AchievementProgress> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfAchievementProgress(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D70 RID: 7536 RVA: 0x0003F630 File Offset: 0x0003E630
		public static bool ReadPersonaBaseClass(XmlParser doc, PersonaBase data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadPersonaBase(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D71 RID: 7537 RVA: 0x0003F678 File Offset: 0x0003E678
		public static bool ReadFraudDetectionClass(XmlParser doc, FraudDetection data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadFraudDetection(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D72 RID: 7538 RVA: 0x0003F6C0 File Offset: 0x0003E6C0
		public static bool ReadClientPhysicsMetricsClass(XmlParser doc, ClientPhysicsMetrics data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadClientPhysicsMetrics(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D73 RID: 7539 RVA: 0x0003F708 File Offset: 0x0003E708
		public static bool ReadSecurityResponseClass(XmlParser doc, SecurityResponse data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadSecurityResponse(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D74 RID: 7540 RVA: 0x0003F750 File Offset: 0x0003E750
		public static bool ReadArbitrationPacketClass(XmlParser doc, ArbitrationPacket data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArbitrationPacket(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D75 RID: 7541 RVA: 0x0003F798 File Offset: 0x0003E798
		public static bool ReadPursuitArbitrationPacketClass(XmlParser doc, PursuitArbitrationPacket data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadPursuitArbitrationPacket(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D76 RID: 7542 RVA: 0x0003F7E0 File Offset: 0x0003E7E0
		public static bool ReadRouteArbitrationPacketClass(XmlParser doc, RouteArbitrationPacket data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadRouteArbitrationPacket(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D77 RID: 7543 RVA: 0x0003F828 File Offset: 0x0003E828
		public static bool ReadDragArbitrationPacketClass(XmlParser doc, DragArbitrationPacket data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadDragArbitrationPacket(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D78 RID: 7544 RVA: 0x0003F870 File Offset: 0x0003E870
		public static bool ReadTeamEscapeArbitrationPacketClass(XmlParser doc, TeamEscapeArbitrationPacket data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadTeamEscapeArbitrationPacket(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D79 RID: 7545 RVA: 0x0003F8B8 File Offset: 0x0003E8B8
		public static bool ReadStatNameListClass(XmlParser doc, StatNameList data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadStatNameList(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D7A RID: 7546 RVA: 0x0003F900 File Offset: 0x0003E900
		public static bool ReadProfileDataClass(XmlParser doc, Victory.Service.Objects.ProfileData data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadProfileData(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D7B RID: 7547 RVA: 0x0003F948 File Offset: 0x0003E948
		public static bool ReadArrayOfPersonaBaseClass(XmlParser doc, List<PersonaBase> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfPersonaBase(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D7C RID: 7548 RVA: 0x0003F990 File Offset: 0x0003E990
		public static bool ReadAchievementsPacketClass(XmlParser doc, AchievementsPacket data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadAchievementsPacket(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D7D RID: 7549 RVA: 0x0003F9D8 File Offset: 0x0003E9D8
		public static bool ReadBadgeDefinitionPacketClass(XmlParser doc, BadgeDefinitionPacket data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadBadgeDefinitionPacket(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D7E RID: 7550 RVA: 0x0003FA20 File Offset: 0x0003EA20
		public static bool ReadArrayOfBadgeDefinitionPacketClass(XmlParser doc, List<BadgeDefinitionPacket> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfBadgeDefinitionPacket(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D7F RID: 7551 RVA: 0x0003FA68 File Offset: 0x0003EA68
		public static bool ReadAchievementDefinitionPacketClass(XmlParser doc, AchievementDefinitionPacket data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadAchievementDefinitionPacket(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D80 RID: 7552 RVA: 0x0003FAB0 File Offset: 0x0003EAB0
		public static bool ReadArrayOfAchievementDefinitionPacketClass(XmlParser doc, List<AchievementDefinitionPacket> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfAchievementDefinitionPacket(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D81 RID: 7553 RVA: 0x0003FAF8 File Offset: 0x0003EAF8
		public static bool ReadAchievementRankPacketClass(XmlParser doc, AchievementRankPacket data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadAchievementRankPacket(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D82 RID: 7554 RVA: 0x0003FB40 File Offset: 0x0003EB40
		public static bool ReadArrayOfAchievementRankPacketClass(XmlParser doc, List<AchievementRankPacket> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfAchievementRankPacket(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D83 RID: 7555 RVA: 0x0003FB88 File Offset: 0x0003EB88
		public static bool ReadAchievementRewardsClass(XmlParser doc, AchievementRewards data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadAchievementRewards(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D84 RID: 7556 RVA: 0x0003FBD0 File Offset: 0x0003EBD0
		public static bool ReadBadgeBundleClass(XmlParser doc, BadgeBundle data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadBadgeBundle(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x0003FC18 File Offset: 0x0003EC18
		public static bool ReadBadgeInputClass(XmlParser doc, BadgeInput data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadBadgeInput(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D86 RID: 7558 RVA: 0x0003FC60 File Offset: 0x0003EC60
		public static bool ReadArrayOfBadgeInputClass(XmlParser doc, List<BadgeInput> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfBadgeInput(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D87 RID: 7559 RVA: 0x0003FCA8 File Offset: 0x0003ECA8
		public static bool ReadBadgesPacketClass(XmlParser doc, BadgesPacket data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadBadgesPacket(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D88 RID: 7560 RVA: 0x0003FCF0 File Offset: 0x0003ECF0
		public static bool ReadShardInfoClass(XmlParser doc, ShardInfo data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadShardInfo(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D89 RID: 7561 RVA: 0x0003FD38 File Offset: 0x0003ED38
		public static bool ReadArrayOfShardInfoClass(XmlParser doc, List<ShardInfo> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfShardInfo(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D8A RID: 7562 RVA: 0x0003FD80 File Offset: 0x0003ED80
		public static bool ReadReportClass(XmlParser doc, Report data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadReport(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D8B RID: 7563 RVA: 0x0003FDC8 File Offset: 0x0003EDC8
		public static bool ReadChatTranscriptClass(XmlParser doc, ChatTranscript data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadChatTranscript(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D8C RID: 7564 RVA: 0x0003FE10 File Offset: 0x0003EE10
		public static bool ReadArrayOfChatTranscriptClass(XmlParser doc, List<ChatTranscript> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfChatTranscript(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D8D RID: 7565 RVA: 0x0003FE58 File Offset: 0x0003EE58
		public static bool ReadErrorReportClass(XmlParser doc, ErrorReport data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadErrorReport(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D8E RID: 7566 RVA: 0x0003FEA0 File Offset: 0x0003EEA0
		public static bool ReadArrayOfErrorReportClass(XmlParser doc, List<ErrorReport> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfErrorReport(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D8F RID: 7567 RVA: 0x0003FEE8 File Offset: 0x0003EEE8
		public static bool ReadArrayOfFraudDetectionClass(XmlParser doc, List<FraudDetection> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfFraudDetection(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D90 RID: 7568 RVA: 0x0003FF30 File Offset: 0x0003EF30
		public static bool ReadShortcutUsageClass(XmlParser doc, ShortcutUsage data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadShortcutUsage(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D91 RID: 7569 RVA: 0x0003FF78 File Offset: 0x0003EF78
		public static bool ReadArrayOfShortcutUsageClass(XmlParser doc, List<ShortcutUsage> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfShortcutUsage(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D92 RID: 7570 RVA: 0x0003FFC0 File Offset: 0x0003EFC0
		public static bool ReadFraudDetectionCollectionClass(XmlParser doc, FraudDetectionCollection data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadFraudDetectionCollection(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001D93 RID: 7571 RVA: 0x00040008 File Offset: 0x0003F008
		private static bool ReadAchievementStateAttribute(string pValue, out AchievementState data)
		{
			return AchievementStateConverter.Parse(pValue, out data);
		}

		// Token: 0x06001D94 RID: 7572 RVA: 0x00040014 File Offset: 0x0003F014
		private static bool ReadAchievementState(XmlParser doc, out AchievementState data)
		{
			string value = doc.GetValue();
			return AchievementStateConverter.Parse(value, out data);
		}

		// Token: 0x06001D95 RID: 7573 RVA: 0x0004002F File Offset: 0x0003F02F
		private static bool ReadStatConversionAttribute(string pValue, out StatConversion data)
		{
			return StatConversionConverter.Parse(pValue, out data);
		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x00040038 File Offset: 0x0003F038
		private static bool ReadStatConversion(XmlParser doc, out StatConversion data)
		{
			string value = doc.GetValue();
			return StatConversionConverter.Parse(value, out data);
		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x00040054 File Offset: 0x0003F054
		private static bool ReadAchievementsAwarded(XmlParser doc, AchievementsAwarded data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "Achievements";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.Achievements = new List<AchievementAwarded>();
				XSD2CPP.ReadArrayOfAchievementAwardedClass(doc, data.Achievements);
			}
			doc.Parent();
			pName = prefix + "Badges";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.Badges = new List<BadgePacket>();
				XSD2CPP.ReadArrayOfBadgePacketClass(doc, data.Badges);
			}
			doc.Parent();
			pName = prefix + "PersonaId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.PersonaId);
			}
			doc.Parent();
			pName = prefix + "Progressed";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.Progressed = new List<AchievementProgress>();
				XSD2CPP.ReadArrayOfAchievementProgressClass(doc, data.Progressed);
			}
			doc.Parent();
			pName = prefix + "Score";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Score);
			}
			return true;
		}

		// Token: 0x06001D98 RID: 7576 RVA: 0x00040174 File Offset: 0x0003F174
		private static bool ReadAchievementAwarded(XmlParser doc, AchievementAwarded data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "AchievedOn";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadDateTime(doc, out data.AchievedOn);
			}
			doc.Parent();
			pName = prefix + "AchievementDefinitionId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.AchievementDefinitionId);
			}
			doc.Parent();
			pName = prefix + "AchievementRankId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.AchievementRankId);
			}
			doc.Parent();
			pName = prefix + "Clip";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Clip);
			}
			doc.Parent();
			pName = prefix + "ClipLengthInSeconds";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadFloat(doc, out data.ClipLengthInSeconds);
			}
			doc.Parent();
			pName = prefix + "Description";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Description);
			}
			doc.Parent();
			pName = prefix + "Icon";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Icon);
			}
			doc.Parent();
			pName = prefix + "IsRare";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.IsRare);
			}
			doc.Parent();
			pName = prefix + "Name";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Name);
			}
			doc.Parent();
			pName = prefix + "Points";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadShort(doc, out data.Points);
			}
			doc.Parent();
			pName = prefix + "Rarity";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadFloat(doc, out data.Rarity);
			}
			return true;
		}

		// Token: 0x06001D99 RID: 7577 RVA: 0x00040350 File Offset: 0x0003F350
		private static bool ReadArrayOfAchievementAwarded(XmlParser doc, List<AchievementAwarded> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "AchievementAwarded";
			}
			for (;;)
			{
				AchievementAwarded achievementAwarded = new AchievementAwarded();
				if (!XSD2CPP.ReadAchievementAwardedClass(doc, achievementAwarded))
				{
					break;
				}
				data.Add(achievementAwarded);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001D9A RID: 7578 RVA: 0x000403A0 File Offset: 0x0003F3A0
		private static bool ReadBadgePacket(XmlParser doc, BadgePacket data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "AchievementRankId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.AchievementRankId);
			}
			doc.Parent();
			pName = prefix + "BadgeDefinitionId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.BadgeDefinitionId);
			}
			doc.Parent();
			pName = prefix + "IsRare";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.IsRare);
			}
			doc.Parent();
			pName = prefix + "Rarity";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadFloat(doc, out data.Rarity);
			}
			doc.Parent();
			pName = prefix + "SlotId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadShort(doc, out data.SlotId);
			}
			return true;
		}

		// Token: 0x06001D9B RID: 7579 RVA: 0x00040488 File Offset: 0x0003F488
		private static bool ReadArrayOfBadgePacket(XmlParser doc, List<BadgePacket> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "BadgePacket";
			}
			for (;;)
			{
				BadgePacket badgePacket = new BadgePacket();
				if (!XSD2CPP.ReadBadgePacketClass(doc, badgePacket))
				{
					break;
				}
				data.Add(badgePacket);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001D9C RID: 7580 RVA: 0x000404D8 File Offset: 0x0003F4D8
		private static bool ReadAchievementProgress(XmlParser doc, AchievementProgress data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "AchievementDefinitionId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.AchievementDefinitionId);
			}
			doc.Parent();
			pName = prefix + "CurrentValue";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.CurrentValue);
			}
			return true;
		}

		// Token: 0x06001D9D RID: 7581 RVA: 0x00040544 File Offset: 0x0003F544
		private static bool ReadArrayOfAchievementProgress(XmlParser doc, List<AchievementProgress> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "AchievementProgress";
			}
			for (;;)
			{
				AchievementProgress achievementProgress = new AchievementProgress();
				if (!XSD2CPP.ReadAchievementProgressClass(doc, achievementProgress))
				{
					break;
				}
				data.Add(achievementProgress);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001D9E RID: 7582 RVA: 0x00040594 File Offset: 0x0003F594
		private static bool ReadPersonaBase(XmlParser doc, PersonaBase data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "Badges";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.Badges = new List<BadgePacket>();
				XSD2CPP.ReadArrayOfBadgePacketClass(doc, data.Badges);
			}
			doc.Parent();
			pName = prefix + "IconIndex";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.IconIndex);
			}
			doc.Parent();
			pName = prefix + "Level";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Level);
			}
			doc.Parent();
			pName = prefix + "Motto";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Motto);
			}
			doc.Parent();
			pName = prefix + "Name";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Name);
			}
			doc.Parent();
			pName = prefix + "PersonaId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.PersonaId);
			}
			doc.Parent();
			pName = prefix + "Presence";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Presence);
			}
			doc.Parent();
			pName = prefix + "Score";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Score);
			}
			doc.Parent();
			pName = prefix + "UserId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.UserId);
			}
			return true;
		}

		// Token: 0x06001D9F RID: 7583 RVA: 0x00040734 File Offset: 0x0003F734
		private static bool ReadFraudDetection(XmlParser doc, FraudDetection data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "Checksum";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Checksum);
			}
			doc.Parent();
			pName = prefix + "IntValue1";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.IntValue1);
			}
			doc.Parent();
			pName = prefix + "IntValue2";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.IntValue2);
			}
			doc.Parent();
			pName = prefix + "IntValue3";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.IntValue3);
			}
			doc.Parent();
			pName = prefix + "IntValue4";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.IntValue4);
			}
			doc.Parent();
			pName = prefix + "IsEncrypted";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.IsEncrypted);
			}
			doc.Parent();
			pName = prefix + "ModuleName";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.ModuleName);
			}
			doc.Parent();
			pName = prefix + "ModulePath";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.ModulePath);
			}
			doc.Parent();
			pName = prefix + "ModuleValue";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.ModuleValue);
			}
			doc.Parent();
			pName = prefix + "StringValue1";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.StringValue1);
			}
			doc.Parent();
			pName = prefix + "StringValue2";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.StringValue2);
			}
			return true;
		}

		// Token: 0x06001DA0 RID: 7584 RVA: 0x00040910 File Offset: 0x0003F910
		private static bool ReadClientPhysicsMetrics(XmlParser doc, ClientPhysicsMetrics data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "AccelerationAverage";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadFloat(doc, out data.AccelerationAverage);
			}
			doc.Parent();
			pName = prefix + "AccelerationMaximum";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadFloat(doc, out data.AccelerationMaximum);
			}
			doc.Parent();
			pName = prefix + "AccelerationMedian";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadFloat(doc, out data.AccelerationMedian);
			}
			doc.Parent();
			pName = prefix + "SpeedAverage";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadFloat(doc, out data.SpeedAverage);
			}
			doc.Parent();
			pName = prefix + "SpeedMaximum";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadFloat(doc, out data.SpeedMaximum);
			}
			doc.Parent();
			pName = prefix + "SpeedMedian";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadFloat(doc, out data.SpeedMedian);
			}
			return true;
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x00040A20 File Offset: 0x0003FA20
		private static bool ReadSecurityResponse(XmlParser doc, SecurityResponse data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "ChallengeId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.ChallengeId);
			}
			doc.Parent();
			pName = prefix + "Result";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.Result);
			}
			return true;
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x00040A8C File Offset: 0x0003FA8C
		private static bool ReadArbitrationPacket(XmlParser doc, ArbitrationPacket data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "AlternateEventDurationInMilliseconds";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.AlternateEventDurationInMilliseconds);
			}
			doc.Parent();
			pName = prefix + "CarId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.CarId);
			}
			doc.Parent();
			pName = prefix + "EventDurationInMilliseconds";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.EventDurationInMilliseconds);
			}
			doc.Parent();
			pName = prefix + "FinishReason";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.FinishReason);
			}
			doc.Parent();
			pName = prefix + "FraudDetectionInfo";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.FraudDetectionInfo = new FraudDetection();
				XSD2CPP.ReadFraudDetectionClass(doc, data.FraudDetectionInfo);
			}
			doc.Parent();
			pName = prefix + "HacksDetected";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.HacksDetected);
			}
			doc.Parent();
			pName = prefix + "PhysicsMetrics";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.PhysicsMetrics = new ClientPhysicsMetrics();
				XSD2CPP.ReadClientPhysicsMetricsClass(doc, data.PhysicsMetrics);
			}
			doc.Parent();
			pName = prefix + "Rank";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Rank);
			}
			doc.Parent();
			pName = prefix + "Response";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.Response = new SecurityResponse();
				XSD2CPP.ReadSecurityResponseClass(doc, data.Response);
			}
			return true;
		}

		// Token: 0x06001DA3 RID: 7587 RVA: 0x00040C50 File Offset: 0x0003FC50
		private static bool ReadPursuitArbitrationPacket(XmlParser doc, PursuitArbitrationPacket data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			XSD2CPP.ReadArbitrationPacket(doc, data, prefix);
			doc.Parent();
			string pName = prefix + "CopsDeployed";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.CopsDeployed);
			}
			doc.Parent();
			pName = prefix + "CopsDisabled";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.CopsDisabled);
			}
			doc.Parent();
			pName = prefix + "CopsRammed";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.CopsRammed);
			}
			doc.Parent();
			pName = prefix + "CostToState";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.CostToState);
			}
			doc.Parent();
			pName = prefix + "Heat";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadFloat(doc, out data.Heat);
			}
			doc.Parent();
			pName = prefix + "Infractions";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Infractions);
			}
			doc.Parent();
			pName = prefix + "LongestJumpDurationInMilliseconds";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.LongestJumpDurationInMilliseconds);
			}
			doc.Parent();
			pName = prefix + "RoadBlocksDodged";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.RoadBlocksDodged);
			}
			doc.Parent();
			pName = prefix + "SpikeStripsDodged";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.SpikeStripsDodged);
			}
			doc.Parent();
			pName = prefix + "SumOfJumpsDurationInMilliseconds";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.SumOfJumpsDurationInMilliseconds);
			}
			doc.Parent();
			pName = prefix + "TopSpeed";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadFloat(doc, out data.TopSpeed);
			}
			return true;
		}

		// Token: 0x06001DA4 RID: 7588 RVA: 0x00040E38 File Offset: 0x0003FE38
		private static bool ReadRouteArbitrationPacket(XmlParser doc, RouteArbitrationPacket data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			XSD2CPP.ReadArbitrationPacket(doc, data, prefix);
			doc.Parent();
			string pName = prefix + "BestLapDurationInMilliseconds";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.BestLapDurationInMilliseconds);
			}
			doc.Parent();
			pName = prefix + "FractionCompleted";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadFloat(doc, out data.FractionCompleted);
			}
			doc.Parent();
			pName = prefix + "LongestJumpDurationInMilliseconds";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.LongestJumpDurationInMilliseconds);
			}
			doc.Parent();
			pName = prefix + "NumberOfCollisions";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.NumberOfCollisions);
			}
			doc.Parent();
			pName = prefix + "PerfectStart";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.PerfectStart);
			}
			doc.Parent();
			pName = prefix + "SumOfJumpsDurationInMilliseconds";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.SumOfJumpsDurationInMilliseconds);
			}
			doc.Parent();
			pName = prefix + "TopSpeed";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadFloat(doc, out data.TopSpeed);
			}
			return true;
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x00040F7C File Offset: 0x0003FF7C
		private static bool ReadDragArbitrationPacket(XmlParser doc, DragArbitrationPacket data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			XSD2CPP.ReadArbitrationPacket(doc, data, prefix);
			doc.Parent();
			string pName = prefix + "FractionCompleted";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadFloat(doc, out data.FractionCompleted);
			}
			doc.Parent();
			pName = prefix + "LongestJumpDurationInMilliseconds";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.LongestJumpDurationInMilliseconds);
			}
			doc.Parent();
			pName = prefix + "NumberOfCollisions";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.NumberOfCollisions);
			}
			doc.Parent();
			pName = prefix + "PerfectStart";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.PerfectStart);
			}
			doc.Parent();
			pName = prefix + "SumOfJumpsDurationInMilliseconds";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.SumOfJumpsDurationInMilliseconds);
			}
			doc.Parent();
			pName = prefix + "TopSpeed";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadFloat(doc, out data.TopSpeed);
			}
			return true;
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x00041094 File Offset: 0x00040094
		private static bool ReadTeamEscapeArbitrationPacket(XmlParser doc, TeamEscapeArbitrationPacket data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			XSD2CPP.ReadArbitrationPacket(doc, data, prefix);
			doc.Parent();
			string pName = prefix + "BustedCount";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.BustedCount);
			}
			doc.Parent();
			pName = prefix + "CopsDeployed";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.CopsDeployed);
			}
			doc.Parent();
			pName = prefix + "CopsDisabled";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.CopsDisabled);
			}
			doc.Parent();
			pName = prefix + "CopsRammed";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.CopsRammed);
			}
			doc.Parent();
			pName = prefix + "CostToState";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.CostToState);
			}
			doc.Parent();
			pName = prefix + "DistanceToFinish";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadFloat(doc, out data.DistanceToFinish);
			}
			doc.Parent();
			pName = prefix + "FractionCompleted";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadFloat(doc, out data.FractionCompleted);
			}
			doc.Parent();
			pName = prefix + "Infractions";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Infractions);
			}
			doc.Parent();
			pName = prefix + "LongestJumpDurationInMilliseconds";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.LongestJumpDurationInMilliseconds);
			}
			doc.Parent();
			pName = prefix + "NumberOfCollisions";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.NumberOfCollisions);
			}
			doc.Parent();
			pName = prefix + "PerfectStart";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.PerfectStart);
			}
			doc.Parent();
			pName = prefix + "RoadBlocksDodged";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.RoadBlocksDodged);
			}
			doc.Parent();
			pName = prefix + "SpikeStripsDodged";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.SpikeStripsDodged);
			}
			doc.Parent();
			pName = prefix + "SumOfJumpsDurationInMilliseconds";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadUInt(doc, out data.SumOfJumpsDurationInMilliseconds);
			}
			doc.Parent();
			pName = prefix + "TopSpeed";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadFloat(doc, out data.TopSpeed);
			}
			return true;
		}

		// Token: 0x06001DA7 RID: 7591 RVA: 0x00041320 File Offset: 0x00040320
		private static bool ReadStatNameList(XmlParser doc, StatNameList data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "Stats";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.Stats = new List<string>();
				XSD2CPP.ReadArrayOfstringClass(doc, data.Stats);
			}
			return true;
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x00041378 File Offset: 0x00040378
		private static bool ReadProfileData(XmlParser doc, Victory.Service.Objects.ProfileData data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "Badges";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.Badges = new List<BadgePacket>();
				XSD2CPP.ReadArrayOfBadgePacketClass(doc, data.Badges);
			}
			doc.Parent();
			pName = prefix + "Cash";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadDouble(doc, out data.Cash);
			}
			doc.Parent();
			pName = prefix + "IconIndex";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.IconIndex);
			}
			doc.Parent();
			pName = prefix + "Level";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Level);
			}
			doc.Parent();
			pName = prefix + "Motto";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Motto);
			}
			doc.Parent();
			pName = prefix + "Name";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Name);
			}
			doc.Parent();
			pName = prefix + "PercentToLevel";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadFloat(doc, out data.PercentToLevel);
			}
			doc.Parent();
			pName = prefix + "PersonaId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.PersonaId);
			}
			doc.Parent();
			pName = prefix + "Rating";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadDouble(doc, out data.Rating);
			}
			doc.Parent();
			pName = prefix + "Rep";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadDouble(doc, out data.Rep);
			}
			doc.Parent();
			pName = prefix + "RepAtCurrentLevel";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.RepAtCurrentLevel);
			}
			doc.Parent();
			pName = prefix + "Score";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Score);
			}
			return true;
		}

		// Token: 0x06001DA9 RID: 7593 RVA: 0x00041590 File Offset: 0x00040590
		private static bool ReadArrayOfPersonaBase(XmlParser doc, List<PersonaBase> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "PersonaBase";
			}
			for (;;)
			{
				PersonaBase personaBase = new PersonaBase();
				if (!XSD2CPP.ReadPersonaBaseClass(doc, personaBase))
				{
					break;
				}
				data.Add(personaBase);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001DAA RID: 7594 RVA: 0x000415E0 File Offset: 0x000405E0
		private static bool ReadAchievementsPacket(XmlParser doc, AchievementsPacket data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "Badges";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.Badges = new List<BadgeDefinitionPacket>();
				XSD2CPP.ReadArrayOfBadgeDefinitionPacketClass(doc, data.Badges);
			}
			doc.Parent();
			pName = prefix + "Definitions";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.Definitions = new List<AchievementDefinitionPacket>();
				XSD2CPP.ReadArrayOfAchievementDefinitionPacketClass(doc, data.Definitions);
			}
			doc.Parent();
			pName = prefix + "PersonaId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.PersonaId);
			}
			return true;
		}

		// Token: 0x06001DAB RID: 7595 RVA: 0x0004169C File Offset: 0x0004069C
		private static bool ReadBadgeDefinitionPacket(XmlParser doc, BadgeDefinitionPacket data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "Background";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Background);
			}
			doc.Parent();
			pName = prefix + "BadgeDefinitionId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.BadgeDefinitionId);
			}
			doc.Parent();
			pName = prefix + "Border";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Border);
			}
			doc.Parent();
			pName = prefix + "Description";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Description);
			}
			doc.Parent();
			pName = prefix + "Icon";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Icon);
			}
			doc.Parent();
			pName = prefix + "Name";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Name);
			}
			return true;
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x000417AC File Offset: 0x000407AC
		private static bool ReadArrayOfBadgeDefinitionPacket(XmlParser doc, List<BadgeDefinitionPacket> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "BadgeDefinitionPacket";
			}
			for (;;)
			{
				BadgeDefinitionPacket badgeDefinitionPacket = new BadgeDefinitionPacket();
				if (!XSD2CPP.ReadBadgeDefinitionPacketClass(doc, badgeDefinitionPacket))
				{
					break;
				}
				data.Add(badgeDefinitionPacket);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x000417FC File Offset: 0x000407FC
		private static bool ReadAchievementDefinitionPacket(XmlParser doc, AchievementDefinitionPacket data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "AchievementDefinitionId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.AchievementDefinitionId);
			}
			doc.Parent();
			pName = prefix + "AchievementRanks";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.AchievementRanks = new List<AchievementRankPacket>();
				XSD2CPP.ReadArrayOfAchievementRankPacketClass(doc, data.AchievementRanks);
			}
			doc.Parent();
			pName = prefix + "BadgeDefinitionId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.BadgeDefinitionId);
			}
			doc.Parent();
			pName = prefix + "CanProgress";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.CanProgress);
			}
			doc.Parent();
			pName = prefix + "CurrentValue";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.CurrentValue);
			}
			doc.Parent();
			pName = prefix + "IsVisible";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.IsVisible);
			}
			doc.Parent();
			pName = prefix + "ProgressText";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.ProgressText);
			}
			doc.Parent();
			pName = prefix + "StatConversion";
			if (doc.FirstChild(pName))
			{
				XSD2CPP.ReadStatConversion(doc, out data.StatConversion);
			}
			return true;
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x00041970 File Offset: 0x00040970
		private static bool ReadArrayOfAchievementDefinitionPacket(XmlParser doc, List<AchievementDefinitionPacket> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "AchievementDefinitionPacket";
			}
			for (;;)
			{
				AchievementDefinitionPacket achievementDefinitionPacket = new AchievementDefinitionPacket();
				if (!XSD2CPP.ReadAchievementDefinitionPacketClass(doc, achievementDefinitionPacket))
				{
					break;
				}
				data.Add(achievementDefinitionPacket);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x000419C0 File Offset: 0x000409C0
		private static bool ReadAchievementRankPacket(XmlParser doc, AchievementRankPacket data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "AchievedOn";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadDateTime(doc, out data.AchievedOn);
			}
			doc.Parent();
			pName = prefix + "AchievementRankId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.AchievementRankId);
			}
			doc.Parent();
			pName = prefix + "IsRare";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.IsRare);
			}
			doc.Parent();
			pName = prefix + "Points";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadShort(doc, out data.Points);
			}
			doc.Parent();
			pName = prefix + "Rank";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadShort(doc, out data.Rank);
			}
			doc.Parent();
			pName = prefix + "Rarity";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadFloat(doc, out data.Rarity);
			}
			doc.Parent();
			pName = prefix + "RewardDescription";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.RewardDescription);
			}
			doc.Parent();
			pName = prefix + "RewardType";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.RewardType);
			}
			doc.Parent();
			pName = prefix + "RewardVisualStyle";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.RewardVisualStyle);
			}
			doc.Parent();
			pName = prefix + "State";
			if (doc.FirstChild(pName))
			{
				XSD2CPP.ReadAchievementState(doc, out data.State);
			}
			doc.Parent();
			pName = prefix + "ThresholdValue";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.ThresholdValue);
			}
			return true;
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x00041B9C File Offset: 0x00040B9C
		private static bool ReadArrayOfAchievementRankPacket(XmlParser doc, List<AchievementRankPacket> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "AchievementRankPacket";
			}
			for (;;)
			{
				AchievementRankPacket achievementRankPacket = new AchievementRankPacket();
				if (!XSD2CPP.ReadAchievementRankPacketClass(doc, achievementRankPacket))
				{
					break;
				}
				data.Add(achievementRankPacket);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x00041BEC File Offset: 0x00040BEC
		private static bool ReadAchievementRewards(XmlParser doc, AchievementRewards data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			XSD2CPP.ReadCommerceResultTrans(doc, data, prefix);
			doc.Parent();
			string pName = prefix + "AchievementRankId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.AchievementRankId);
			}
			doc.Parent();
			pName = prefix + "VisualStyle";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.VisualStyle);
			}
			return true;
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x00041C60 File Offset: 0x00040C60
		private static bool ReadBadgeBundle(XmlParser doc, BadgeBundle data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "Badges";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.Badges = new List<BadgeInput>();
				XSD2CPP.ReadArrayOfBadgeInputClass(doc, data.Badges);
			}
			return true;
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x00041CB8 File Offset: 0x00040CB8
		private static bool ReadBadgeInput(XmlParser doc, BadgeInput data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "BadgeDefinitionId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.BadgeDefinitionId);
			}
			doc.Parent();
			pName = prefix + "SlotId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadShort(doc, out data.SlotId);
			}
			return true;
		}

		// Token: 0x06001DB4 RID: 7604 RVA: 0x00041D24 File Offset: 0x00040D24
		private static bool ReadArrayOfBadgeInput(XmlParser doc, List<BadgeInput> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "BadgeInput";
			}
			for (;;)
			{
				BadgeInput badgeInput = new BadgeInput();
				if (!XSD2CPP.ReadBadgeInputClass(doc, badgeInput))
				{
					break;
				}
				data.Add(badgeInput);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001DB5 RID: 7605 RVA: 0x00041D74 File Offset: 0x00040D74
		private static bool ReadBadgesPacket(XmlParser doc, BadgesPacket data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "Badges";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.Badges = new List<BadgePacket>();
				XSD2CPP.ReadArrayOfBadgePacketClass(doc, data.Badges);
			}
			return true;
		}

		// Token: 0x06001DB6 RID: 7606 RVA: 0x00041DCC File Offset: 0x00040DCC
		private static bool ReadShardInfo(XmlParser doc, ShardInfo data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "RegionId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.RegionId);
			}
			doc.Parent();
			pName = prefix + "RegionName";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.RegionName);
			}
			doc.Parent();
			pName = prefix + "ShardName";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.ShardName);
			}
			doc.Parent();
			pName = prefix + "Url";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Url);
			}
			return true;
		}

		// Token: 0x06001DB7 RID: 7607 RVA: 0x00041E8C File Offset: 0x00040E8C
		private static bool ReadArrayOfShardInfo(XmlParser doc, List<ShardInfo> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "ShardInfo";
			}
			for (;;)
			{
				ShardInfo shardInfo = new ShardInfo();
				if (!XSD2CPP.ReadShardInfoClass(doc, shardInfo))
				{
					break;
				}
				data.Add(shardInfo);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001DB8 RID: 7608 RVA: 0x00041EDC File Offset: 0x00040EDC
		private static bool ReadReport(XmlParser doc, Report data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "chatTranscripts";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.chatTranscripts = new List<ChatTranscript>();
				XSD2CPP.ReadArrayOfChatTranscriptClass(doc, data.chatTranscripts);
			}
			doc.Parent();
			pName = prefix + "errorReport";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.errorReport = new List<ErrorReport>();
				XSD2CPP.ReadArrayOfErrorReportClass(doc, data.errorReport);
			}
			doc.Parent();
			pName = prefix + "fraudDetectionReport";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.fraudDetectionReport = new List<FraudDetection>();
				XSD2CPP.ReadArrayOfFraudDetectionClass(doc, data.fraudDetectionReport);
			}
			doc.Parent();
			pName = prefix + "shortcutUsage";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.shortcutUsage = new List<ShortcutUsage>();
				XSD2CPP.ReadArrayOfShortcutUsageClass(doc, data.shortcutUsage);
			}
			return true;
		}

		// Token: 0x06001DB9 RID: 7609 RVA: 0x00041FE8 File Offset: 0x00040FE8
		private static bool ReadChatTranscript(XmlParser doc, ChatTranscript data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "Message";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Message);
			}
			doc.Parent();
			pName = prefix + "PersonaId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.PersonaId);
			}
			doc.Parent();
			pName = prefix + "TargetPersonaId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.TargetPersonaId);
			}
			doc.Parent();
			pName = prefix + "UserId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.UserId);
			}
			return true;
		}

		// Token: 0x06001DBA RID: 7610 RVA: 0x000420A8 File Offset: 0x000410A8
		private static bool ReadArrayOfChatTranscript(XmlParser doc, List<ChatTranscript> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "ChatTranscript";
			}
			for (;;)
			{
				ChatTranscript chatTranscript = new ChatTranscript();
				if (!XSD2CPP.ReadChatTranscriptClass(doc, chatTranscript))
				{
					break;
				}
				data.Add(chatTranscript);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001DBB RID: 7611 RVA: 0x000420F8 File Offset: 0x000410F8
		private static bool ReadErrorReport(XmlParser doc, ErrorReport data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "errorCode";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.errorCode);
			}
			doc.Parent();
			pName = prefix + "errorDescription";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.errorDescription);
			}
			return true;
		}

		// Token: 0x06001DBC RID: 7612 RVA: 0x00042164 File Offset: 0x00041164
		private static bool ReadArrayOfErrorReport(XmlParser doc, List<ErrorReport> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "ErrorReport";
			}
			for (;;)
			{
				ErrorReport errorReport = new ErrorReport();
				if (!XSD2CPP.ReadErrorReportClass(doc, errorReport))
				{
					break;
				}
				data.Add(errorReport);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001DBD RID: 7613 RVA: 0x000421B4 File Offset: 0x000411B4
		private static bool ReadArrayOfFraudDetection(XmlParser doc, List<FraudDetection> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "FraudDetection";
			}
			for (;;)
			{
				FraudDetection fraudDetection = new FraudDetection();
				if (!XSD2CPP.ReadFraudDetectionClass(doc, fraudDetection))
				{
					break;
				}
				data.Add(fraudDetection);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001DBE RID: 7614 RVA: 0x00042204 File Offset: 0x00041204
		private static bool ReadShortcutUsage(XmlParser doc, ShortcutUsage data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "shortCut";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.shortCut);
			}
			doc.Parent();
			pName = prefix + "timesUsed";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.timesUsed);
			}
			return true;
		}

		// Token: 0x06001DBF RID: 7615 RVA: 0x00042270 File Offset: 0x00041270
		private static bool ReadArrayOfShortcutUsage(XmlParser doc, List<ShortcutUsage> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "ShortcutUsage";
			}
			for (;;)
			{
				ShortcutUsage shortcutUsage = new ShortcutUsage();
				if (!XSD2CPP.ReadShortcutUsageClass(doc, shortcutUsage))
				{
					break;
				}
				data.Add(shortcutUsage);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x000422C0 File Offset: 0x000412C0
		private static bool ReadFraudDetectionCollection(XmlParser doc, FraudDetectionCollection data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "FraudDetectionLogs";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.FraudDetectionLogs = new List<FraudDetection>();
				XSD2CPP.ReadArrayOfFraudDetectionClass(doc, data.FraudDetectionLogs);
			}
			return true;
		}

		// Token: 0x06001DC1 RID: 7617 RVA: 0x00042318 File Offset: 0x00041318
		public static bool Reader(XmlString xmlString, out AchievementsAwarded data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "AchievementsAwarded"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new AchievementsAwarded();
						if (XSD2CPP.ReadAchievementsAwardedClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001DC2 RID: 7618 RVA: 0x00042374 File Offset: 0x00041374
		public static bool ReadAchievementsAwarded(XmlString xmlString, out AchievementsAwarded data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001DC3 RID: 7619 RVA: 0x00042380 File Offset: 0x00041380
		public static bool Reader(XmlString xmlString, out AchievementAwarded data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "AchievementAwarded"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new AchievementAwarded();
						if (XSD2CPP.ReadAchievementAwardedClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x000423DC File Offset: 0x000413DC
		public static bool ReadAchievementAwarded(XmlString xmlString, out AchievementAwarded data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001DC5 RID: 7621 RVA: 0x000423E8 File Offset: 0x000413E8
		public static bool Reader(XmlString xmlString, out List<AchievementAwarded> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfAchievementAwarded"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<AchievementAwarded>();
						if (XSD2CPP.ReadArrayOfAchievementAwardedClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001DC6 RID: 7622 RVA: 0x00042444 File Offset: 0x00041444
		public static bool ReadArrayOfAchievementAwarded(XmlString xmlString, out List<AchievementAwarded> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001DC7 RID: 7623 RVA: 0x00042450 File Offset: 0x00041450
		public static bool Reader(XmlString xmlString, out BadgePacket data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "BadgePacket"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new BadgePacket();
						if (XSD2CPP.ReadBadgePacketClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001DC8 RID: 7624 RVA: 0x000424AC File Offset: 0x000414AC
		public static bool ReadBadgePacket(XmlString xmlString, out BadgePacket data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001DC9 RID: 7625 RVA: 0x000424B8 File Offset: 0x000414B8
		public static bool Reader(XmlString xmlString, out List<BadgePacket> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfBadgePacket"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<BadgePacket>();
						if (XSD2CPP.ReadArrayOfBadgePacketClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001DCA RID: 7626 RVA: 0x00042514 File Offset: 0x00041514
		public static bool ReadArrayOfBadgePacket(XmlString xmlString, out List<BadgePacket> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001DCB RID: 7627 RVA: 0x00042520 File Offset: 0x00041520
		public static bool Reader(XmlString xmlString, out AchievementProgress data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "AchievementProgress"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new AchievementProgress();
						if (XSD2CPP.ReadAchievementProgressClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001DCC RID: 7628 RVA: 0x0004257C File Offset: 0x0004157C
		public static bool ReadAchievementProgress(XmlString xmlString, out AchievementProgress data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001DCD RID: 7629 RVA: 0x00042588 File Offset: 0x00041588
		public static bool Reader(XmlString xmlString, out List<AchievementProgress> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfAchievementProgress"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<AchievementProgress>();
						if (XSD2CPP.ReadArrayOfAchievementProgressClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001DCE RID: 7630 RVA: 0x000425E4 File Offset: 0x000415E4
		public static bool ReadArrayOfAchievementProgress(XmlString xmlString, out List<AchievementProgress> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001DCF RID: 7631 RVA: 0x000425F0 File Offset: 0x000415F0
		public static bool Reader(XmlString xmlString, out PersonaBase data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "PersonaBase"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new PersonaBase();
						if (XSD2CPP.ReadPersonaBaseClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001DD0 RID: 7632 RVA: 0x0004264C File Offset: 0x0004164C
		public static bool ReadPersonaBase(XmlString xmlString, out PersonaBase data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001DD1 RID: 7633 RVA: 0x00042658 File Offset: 0x00041658
		public static bool Reader(XmlString xmlString, out FraudDetection data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "FraudDetection"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new FraudDetection();
						if (XSD2CPP.ReadFraudDetectionClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001DD2 RID: 7634 RVA: 0x000426B4 File Offset: 0x000416B4
		public static bool ReadFraudDetection(XmlString xmlString, out FraudDetection data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001DD3 RID: 7635 RVA: 0x000426C0 File Offset: 0x000416C0
		public static bool Reader(XmlString xmlString, out ClientPhysicsMetrics data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ClientPhysicsMetrics"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new ClientPhysicsMetrics();
						if (XSD2CPP.ReadClientPhysicsMetricsClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001DD4 RID: 7636 RVA: 0x0004271C File Offset: 0x0004171C
		public static bool ReadClientPhysicsMetrics(XmlString xmlString, out ClientPhysicsMetrics data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001DD5 RID: 7637 RVA: 0x00042728 File Offset: 0x00041728
		public static bool Reader(XmlString xmlString, out SecurityResponse data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "SecurityResponse"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new SecurityResponse();
						if (XSD2CPP.ReadSecurityResponseClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001DD6 RID: 7638 RVA: 0x00042784 File Offset: 0x00041784
		public static bool ReadSecurityResponse(XmlString xmlString, out SecurityResponse data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001DD7 RID: 7639 RVA: 0x00042790 File Offset: 0x00041790
		public static bool Reader(XmlString xmlString, out ArbitrationPacket data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArbitrationPacket"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new ArbitrationPacket();
						if (XSD2CPP.ReadArbitrationPacketClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001DD8 RID: 7640 RVA: 0x000427EC File Offset: 0x000417EC
		public static bool ReadArbitrationPacket(XmlString xmlString, out ArbitrationPacket data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001DD9 RID: 7641 RVA: 0x000427F8 File Offset: 0x000417F8
		public static bool Reader(XmlString xmlString, out PursuitArbitrationPacket data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "PursuitArbitrationPacket"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new PursuitArbitrationPacket();
						if (XSD2CPP.ReadPursuitArbitrationPacketClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001DDA RID: 7642 RVA: 0x00042854 File Offset: 0x00041854
		public static bool ReadPursuitArbitrationPacket(XmlString xmlString, out PursuitArbitrationPacket data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001DDB RID: 7643 RVA: 0x00042860 File Offset: 0x00041860
		public static bool Reader(XmlString xmlString, out RouteArbitrationPacket data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "RouteArbitrationPacket"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new RouteArbitrationPacket();
						if (XSD2CPP.ReadRouteArbitrationPacketClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001DDC RID: 7644 RVA: 0x000428BC File Offset: 0x000418BC
		public static bool ReadRouteArbitrationPacket(XmlString xmlString, out RouteArbitrationPacket data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001DDD RID: 7645 RVA: 0x000428C8 File Offset: 0x000418C8
		public static bool Reader(XmlString xmlString, out DragArbitrationPacket data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "DragArbitrationPacket"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new DragArbitrationPacket();
						if (XSD2CPP.ReadDragArbitrationPacketClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001DDE RID: 7646 RVA: 0x00042924 File Offset: 0x00041924
		public static bool ReadDragArbitrationPacket(XmlString xmlString, out DragArbitrationPacket data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x00042930 File Offset: 0x00041930
		public static bool Reader(XmlString xmlString, out TeamEscapeArbitrationPacket data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "TeamEscapeArbitrationPacket"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new TeamEscapeArbitrationPacket();
						if (XSD2CPP.ReadTeamEscapeArbitrationPacketClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001DE0 RID: 7648 RVA: 0x0004298C File Offset: 0x0004198C
		public static bool ReadTeamEscapeArbitrationPacket(XmlString xmlString, out TeamEscapeArbitrationPacket data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001DE1 RID: 7649 RVA: 0x00042998 File Offset: 0x00041998
		public static bool Reader(XmlString xmlString, out StatNameList data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "StatNameList"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new StatNameList();
						if (XSD2CPP.ReadStatNameListClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001DE2 RID: 7650 RVA: 0x000429F4 File Offset: 0x000419F4
		public static bool ReadStatNameList(XmlString xmlString, out StatNameList data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001DE3 RID: 7651 RVA: 0x00042A00 File Offset: 0x00041A00
		public static bool Reader(XmlString xmlString, out Victory.Service.Objects.ProfileData data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ProfileData"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new Victory.Service.Objects.ProfileData();
						if (XSD2CPP.ReadProfileDataClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001DE4 RID: 7652 RVA: 0x00042A5C File Offset: 0x00041A5C
		public static bool ReadProfileData(XmlString xmlString, out Victory.Service.Objects.ProfileData data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001DE5 RID: 7653 RVA: 0x00042A68 File Offset: 0x00041A68
		public static bool Reader(XmlString xmlString, out List<PersonaBase> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfPersonaBase"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<PersonaBase>();
						if (XSD2CPP.ReadArrayOfPersonaBaseClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001DE6 RID: 7654 RVA: 0x00042AC4 File Offset: 0x00041AC4
		public static bool ReadArrayOfPersonaBase(XmlString xmlString, out List<PersonaBase> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001DE7 RID: 7655 RVA: 0x00042AD0 File Offset: 0x00041AD0
		public static bool Reader(XmlString xmlString, out AchievementsPacket data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "AchievementsPacket"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new AchievementsPacket();
						if (XSD2CPP.ReadAchievementsPacketClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001DE8 RID: 7656 RVA: 0x00042B2C File Offset: 0x00041B2C
		public static bool ReadAchievementsPacket(XmlString xmlString, out AchievementsPacket data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001DE9 RID: 7657 RVA: 0x00042B38 File Offset: 0x00041B38
		public static bool Reader(XmlString xmlString, out BadgeDefinitionPacket data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "BadgeDefinitionPacket"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new BadgeDefinitionPacket();
						if (XSD2CPP.ReadBadgeDefinitionPacketClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x00042B94 File Offset: 0x00041B94
		public static bool ReadBadgeDefinitionPacket(XmlString xmlString, out BadgeDefinitionPacket data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001DEB RID: 7659 RVA: 0x00042BA0 File Offset: 0x00041BA0
		public static bool Reader(XmlString xmlString, out List<BadgeDefinitionPacket> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfBadgeDefinitionPacket"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<BadgeDefinitionPacket>();
						if (XSD2CPP.ReadArrayOfBadgeDefinitionPacketClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001DEC RID: 7660 RVA: 0x00042BFC File Offset: 0x00041BFC
		public static bool ReadArrayOfBadgeDefinitionPacket(XmlString xmlString, out List<BadgeDefinitionPacket> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001DED RID: 7661 RVA: 0x00042C08 File Offset: 0x00041C08
		public static bool Reader(XmlString xmlString, out AchievementDefinitionPacket data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "AchievementDefinitionPacket"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new AchievementDefinitionPacket();
						if (XSD2CPP.ReadAchievementDefinitionPacketClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001DEE RID: 7662 RVA: 0x00042C64 File Offset: 0x00041C64
		public static bool ReadAchievementDefinitionPacket(XmlString xmlString, out AchievementDefinitionPacket data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001DEF RID: 7663 RVA: 0x00042C70 File Offset: 0x00041C70
		public static bool Reader(XmlString xmlString, out List<AchievementDefinitionPacket> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfAchievementDefinitionPacket"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<AchievementDefinitionPacket>();
						if (XSD2CPP.ReadArrayOfAchievementDefinitionPacketClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001DF0 RID: 7664 RVA: 0x00042CCC File Offset: 0x00041CCC
		public static bool ReadArrayOfAchievementDefinitionPacket(XmlString xmlString, out List<AchievementDefinitionPacket> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001DF1 RID: 7665 RVA: 0x00042CD8 File Offset: 0x00041CD8
		public static bool Reader(XmlString xmlString, out AchievementRankPacket data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "AchievementRankPacket"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new AchievementRankPacket();
						if (XSD2CPP.ReadAchievementRankPacketClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001DF2 RID: 7666 RVA: 0x00042D34 File Offset: 0x00041D34
		public static bool ReadAchievementRankPacket(XmlString xmlString, out AchievementRankPacket data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001DF3 RID: 7667 RVA: 0x00042D40 File Offset: 0x00041D40
		public static bool Reader(XmlString xmlString, out List<AchievementRankPacket> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfAchievementRankPacket"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<AchievementRankPacket>();
						if (XSD2CPP.ReadArrayOfAchievementRankPacketClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001DF4 RID: 7668 RVA: 0x00042D9C File Offset: 0x00041D9C
		public static bool ReadArrayOfAchievementRankPacket(XmlString xmlString, out List<AchievementRankPacket> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001DF5 RID: 7669 RVA: 0x00042DA8 File Offset: 0x00041DA8
		public static bool Reader(XmlString xmlString, out AchievementRewards data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "AchievementRewards"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new AchievementRewards();
						if (XSD2CPP.ReadAchievementRewardsClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001DF6 RID: 7670 RVA: 0x00042E04 File Offset: 0x00041E04
		public static bool ReadAchievementRewards(XmlString xmlString, out AchievementRewards data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x00042E10 File Offset: 0x00041E10
		public static bool Reader(XmlString xmlString, out BadgeBundle data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "BadgeBundle"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new BadgeBundle();
						if (XSD2CPP.ReadBadgeBundleClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001DF8 RID: 7672 RVA: 0x00042E6C File Offset: 0x00041E6C
		public static bool ReadBadgeBundle(XmlString xmlString, out BadgeBundle data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001DF9 RID: 7673 RVA: 0x00042E78 File Offset: 0x00041E78
		public static bool Reader(XmlString xmlString, out BadgeInput data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "BadgeInput"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new BadgeInput();
						if (XSD2CPP.ReadBadgeInputClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001DFA RID: 7674 RVA: 0x00042ED4 File Offset: 0x00041ED4
		public static bool ReadBadgeInput(XmlString xmlString, out BadgeInput data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001DFB RID: 7675 RVA: 0x00042EE0 File Offset: 0x00041EE0
		public static bool Reader(XmlString xmlString, out List<BadgeInput> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfBadgeInput"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<BadgeInput>();
						if (XSD2CPP.ReadArrayOfBadgeInputClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001DFC RID: 7676 RVA: 0x00042F3C File Offset: 0x00041F3C
		public static bool ReadArrayOfBadgeInput(XmlString xmlString, out List<BadgeInput> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001DFD RID: 7677 RVA: 0x00042F48 File Offset: 0x00041F48
		public static bool Reader(XmlString xmlString, out BadgesPacket data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "BadgesPacket"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new BadgesPacket();
						if (XSD2CPP.ReadBadgesPacketClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001DFE RID: 7678 RVA: 0x00042FA4 File Offset: 0x00041FA4
		public static bool ReadBadgesPacket(XmlString xmlString, out BadgesPacket data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x00042FB0 File Offset: 0x00041FB0
		public static bool Reader(XmlString xmlString, out ShardInfo data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ShardInfo"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new ShardInfo();
						if (XSD2CPP.ReadShardInfoClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x0004300C File Offset: 0x0004200C
		public static bool ReadShardInfo(XmlString xmlString, out ShardInfo data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001E01 RID: 7681 RVA: 0x00043018 File Offset: 0x00042018
		public static bool Reader(XmlString xmlString, out List<ShardInfo> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfShardInfo"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<ShardInfo>();
						if (XSD2CPP.ReadArrayOfShardInfoClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001E02 RID: 7682 RVA: 0x00043074 File Offset: 0x00042074
		public static bool ReadArrayOfShardInfo(XmlString xmlString, out List<ShardInfo> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001E03 RID: 7683 RVA: 0x00043080 File Offset: 0x00042080
		public static bool Reader(XmlString xmlString, out Report data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "Report"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new Report();
						if (XSD2CPP.ReadReportClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001E04 RID: 7684 RVA: 0x000430DC File Offset: 0x000420DC
		public static bool ReadReport(XmlString xmlString, out Report data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001E05 RID: 7685 RVA: 0x000430E8 File Offset: 0x000420E8
		public static bool Reader(XmlString xmlString, out ChatTranscript data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ChatTranscript"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new ChatTranscript();
						if (XSD2CPP.ReadChatTranscriptClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001E06 RID: 7686 RVA: 0x00043144 File Offset: 0x00042144
		public static bool ReadChatTranscript(XmlString xmlString, out ChatTranscript data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001E07 RID: 7687 RVA: 0x00043150 File Offset: 0x00042150
		public static bool Reader(XmlString xmlString, out List<ChatTranscript> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfChatTranscript"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<ChatTranscript>();
						if (XSD2CPP.ReadArrayOfChatTranscriptClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001E08 RID: 7688 RVA: 0x000431AC File Offset: 0x000421AC
		public static bool ReadArrayOfChatTranscript(XmlString xmlString, out List<ChatTranscript> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001E09 RID: 7689 RVA: 0x000431B8 File Offset: 0x000421B8
		public static bool Reader(XmlString xmlString, out ErrorReport data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ErrorReport"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new ErrorReport();
						if (XSD2CPP.ReadErrorReportClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001E0A RID: 7690 RVA: 0x00043214 File Offset: 0x00042214
		public static bool ReadErrorReport(XmlString xmlString, out ErrorReport data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001E0B RID: 7691 RVA: 0x00043220 File Offset: 0x00042220
		public static bool Reader(XmlString xmlString, out List<ErrorReport> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfErrorReport"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<ErrorReport>();
						if (XSD2CPP.ReadArrayOfErrorReportClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001E0C RID: 7692 RVA: 0x0004327C File Offset: 0x0004227C
		public static bool ReadArrayOfErrorReport(XmlString xmlString, out List<ErrorReport> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001E0D RID: 7693 RVA: 0x00043288 File Offset: 0x00042288
		public static bool Reader(XmlString xmlString, out List<FraudDetection> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfFraudDetection"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<FraudDetection>();
						if (XSD2CPP.ReadArrayOfFraudDetectionClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001E0E RID: 7694 RVA: 0x000432E4 File Offset: 0x000422E4
		public static bool ReadArrayOfFraudDetection(XmlString xmlString, out List<FraudDetection> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001E0F RID: 7695 RVA: 0x000432F0 File Offset: 0x000422F0
		public static bool Reader(XmlString xmlString, out ShortcutUsage data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ShortcutUsage"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new ShortcutUsage();
						if (XSD2CPP.ReadShortcutUsageClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001E10 RID: 7696 RVA: 0x0004334C File Offset: 0x0004234C
		public static bool ReadShortcutUsage(XmlString xmlString, out ShortcutUsage data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001E11 RID: 7697 RVA: 0x00043358 File Offset: 0x00042358
		public static bool Reader(XmlString xmlString, out List<ShortcutUsage> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfShortcutUsage"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<ShortcutUsage>();
						if (XSD2CPP.ReadArrayOfShortcutUsageClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001E12 RID: 7698 RVA: 0x000433B4 File Offset: 0x000423B4
		public static bool ReadArrayOfShortcutUsage(XmlString xmlString, out List<ShortcutUsage> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001E13 RID: 7699 RVA: 0x000433C0 File Offset: 0x000423C0
		public static bool Reader(XmlString xmlString, out FraudDetectionCollection data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "FraudDetectionCollection"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new FraudDetectionCollection();
						if (XSD2CPP.ReadFraudDetectionCollectionClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001E14 RID: 7700 RVA: 0x0004341C File Offset: 0x0004241C
		public static bool ReadFraudDetectionCollection(XmlString xmlString, out FraudDetectionCollection data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001E15 RID: 7701 RVA: 0x00043425 File Offset: 0x00042425
		private static void WriteAchievementState(XmlParser doc, AchievementState data)
		{
			Xsd2CppUtil.WriteString(doc, data.ToString());
		}

		// Token: 0x06001E16 RID: 7702 RVA: 0x00043439 File Offset: 0x00042439
		private static void WriteStatConversion(XmlParser doc, StatConversion data)
		{
			Xsd2CppUtil.WriteString(doc, data.ToString());
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x00043450 File Offset: 0x00042450
		private static void WriteAchievementsAwarded(XmlParser doc, AchievementsAwarded data)
		{
			doc.AddChild("Achievements");
			XSD2CPP.WriteArrayOfAchievementAwarded(doc, data.Achievements);
			doc.Parent();
			doc.AddChild("Badges");
			XSD2CPP.WriteArrayOfBadgePacket(doc, data.Badges);
			doc.Parent();
			doc.AddChild("PersonaId");
			Xsd2CppUtil.WriteLong(doc, data.PersonaId);
			doc.Parent();
			doc.AddChild("Progressed");
			XSD2CPP.WriteArrayOfAchievementProgress(doc, data.Progressed);
			doc.Parent();
			doc.AddChild("Score");
			Xsd2CppUtil.WriteInt(doc, data.Score);
			doc.Parent();
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x000434FC File Offset: 0x000424FC
		private static void WriteAchievementAwarded(XmlParser doc, AchievementAwarded data)
		{
			doc.AddChild("AchievedOn");
			Xsd2CppUtil.WriteDateTime(doc, data.AchievedOn);
			doc.Parent();
			doc.AddChild("AchievementDefinitionId");
			Xsd2CppUtil.WriteInt(doc, data.AchievementDefinitionId);
			doc.Parent();
			doc.AddChild("AchievementRankId");
			Xsd2CppUtil.WriteInt(doc, data.AchievementRankId);
			doc.Parent();
			doc.AddChild("Clip");
			Xsd2CppUtil.WriteString(doc, data.Clip);
			doc.Parent();
			doc.AddChild("ClipLengthInSeconds");
			Xsd2CppUtil.WriteFloat(doc, data.ClipLengthInSeconds);
			doc.Parent();
			doc.AddChild("Description");
			Xsd2CppUtil.WriteString(doc, data.Description);
			doc.Parent();
			doc.AddChild("Icon");
			Xsd2CppUtil.WriteString(doc, data.Icon);
			doc.Parent();
			doc.AddChild("IsRare");
			Xsd2CppUtil.WriteBoolean(doc, data.IsRare);
			doc.Parent();
			doc.AddChild("Name");
			Xsd2CppUtil.WriteString(doc, data.Name);
			doc.Parent();
			doc.AddChild("Points");
			Xsd2CppUtil.WriteShort(doc, data.Points);
			doc.Parent();
			doc.AddChild("Rarity");
			Xsd2CppUtil.WriteFloat(doc, data.Rarity);
			doc.Parent();
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x0004366C File Offset: 0x0004266C
		private static void WriteArrayOfAchievementAwarded(XmlParser doc, List<AchievementAwarded> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("AchievementAwarded");
				XSD2CPP.WriteAchievementAwarded(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x000436AC File Offset: 0x000426AC
		private static void WriteBadgePacket(XmlParser doc, BadgePacket data)
		{
			doc.AddChild("AchievementRankId");
			Xsd2CppUtil.WriteInt(doc, data.AchievementRankId);
			doc.Parent();
			doc.AddChild("BadgeDefinitionId");
			Xsd2CppUtil.WriteInt(doc, data.BadgeDefinitionId);
			doc.Parent();
			doc.AddChild("IsRare");
			Xsd2CppUtil.WriteBoolean(doc, data.IsRare);
			doc.Parent();
			doc.AddChild("Rarity");
			Xsd2CppUtil.WriteFloat(doc, data.Rarity);
			doc.Parent();
			doc.AddChild("SlotId");
			Xsd2CppUtil.WriteShort(doc, data.SlotId);
			doc.Parent();
		}

		// Token: 0x06001E1B RID: 7707 RVA: 0x0004375C File Offset: 0x0004275C
		private static void WriteArrayOfBadgePacket(XmlParser doc, List<BadgePacket> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("BadgePacket");
				XSD2CPP.WriteBadgePacket(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001E1C RID: 7708 RVA: 0x0004379C File Offset: 0x0004279C
		private static void WriteAchievementProgress(XmlParser doc, AchievementProgress data)
		{
			doc.AddChild("AchievementDefinitionId");
			Xsd2CppUtil.WriteInt(doc, data.AchievementDefinitionId);
			doc.Parent();
			doc.AddChild("CurrentValue");
			Xsd2CppUtil.WriteLong(doc, data.CurrentValue);
			doc.Parent();
		}

		// Token: 0x06001E1D RID: 7709 RVA: 0x000437EC File Offset: 0x000427EC
		private static void WriteArrayOfAchievementProgress(XmlParser doc, List<AchievementProgress> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("AchievementProgress");
				XSD2CPP.WriteAchievementProgress(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x0004382C File Offset: 0x0004282C
		private static void WritePersonaBase(XmlParser doc, PersonaBase data)
		{
			doc.AddChild("Badges");
			XSD2CPP.WriteArrayOfBadgePacket(doc, data.Badges);
			doc.Parent();
			doc.AddChild("IconIndex");
			Xsd2CppUtil.WriteInt(doc, data.IconIndex);
			doc.Parent();
			doc.AddChild("Level");
			Xsd2CppUtil.WriteInt(doc, data.Level);
			doc.Parent();
			doc.AddChild("Motto");
			Xsd2CppUtil.WriteString(doc, data.Motto);
			doc.Parent();
			doc.AddChild("Name");
			Xsd2CppUtil.WriteString(doc, data.Name);
			doc.Parent();
			doc.AddChild("PersonaId");
			Xsd2CppUtil.WriteLong(doc, data.PersonaId);
			doc.Parent();
			doc.AddChild("Presence");
			Xsd2CppUtil.WriteInt(doc, data.Presence);
			doc.Parent();
			doc.AddChild("Score");
			Xsd2CppUtil.WriteInt(doc, data.Score);
			doc.Parent();
			doc.AddChild("UserId");
			Xsd2CppUtil.WriteLong(doc, data.UserId);
			doc.Parent();
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x00043958 File Offset: 0x00042958
		private static void WriteFraudDetection(XmlParser doc, FraudDetection data)
		{
			doc.AddChild("Checksum");
			Xsd2CppUtil.WriteInt(doc, data.Checksum);
			doc.Parent();
			doc.AddChild("IntValue1");
			Xsd2CppUtil.WriteInt(doc, data.IntValue1);
			doc.Parent();
			doc.AddChild("IntValue2");
			Xsd2CppUtil.WriteInt(doc, data.IntValue2);
			doc.Parent();
			doc.AddChild("IntValue3");
			Xsd2CppUtil.WriteInt(doc, data.IntValue3);
			doc.Parent();
			doc.AddChild("IntValue4");
			Xsd2CppUtil.WriteInt(doc, data.IntValue4);
			doc.Parent();
			doc.AddChild("IsEncrypted");
			Xsd2CppUtil.WriteBoolean(doc, data.IsEncrypted);
			doc.Parent();
			doc.AddChild("ModuleName");
			Xsd2CppUtil.WriteString(doc, data.ModuleName);
			doc.Parent();
			doc.AddChild("ModulePath");
			Xsd2CppUtil.WriteString(doc, data.ModulePath);
			doc.Parent();
			doc.AddChild("ModuleValue");
			Xsd2CppUtil.WriteString(doc, data.ModuleValue);
			doc.Parent();
			doc.AddChild("StringValue1");
			Xsd2CppUtil.WriteString(doc, data.StringValue1);
			doc.Parent();
			doc.AddChild("StringValue2");
			Xsd2CppUtil.WriteString(doc, data.StringValue2);
			doc.Parent();
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x00043AC8 File Offset: 0x00042AC8
		private static void WriteClientPhysicsMetrics(XmlParser doc, ClientPhysicsMetrics data)
		{
			doc.AddChild("AccelerationAverage");
			Xsd2CppUtil.WriteFloat(doc, data.AccelerationAverage);
			doc.Parent();
			doc.AddChild("AccelerationMaximum");
			Xsd2CppUtil.WriteFloat(doc, data.AccelerationMaximum);
			doc.Parent();
			doc.AddChild("AccelerationMedian");
			Xsd2CppUtil.WriteFloat(doc, data.AccelerationMedian);
			doc.Parent();
			doc.AddChild("SpeedAverage");
			Xsd2CppUtil.WriteFloat(doc, data.SpeedAverage);
			doc.Parent();
			doc.AddChild("SpeedMaximum");
			Xsd2CppUtil.WriteFloat(doc, data.SpeedMaximum);
			doc.Parent();
			doc.AddChild("SpeedMedian");
			Xsd2CppUtil.WriteFloat(doc, data.SpeedMedian);
			doc.Parent();
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x00043B98 File Offset: 0x00042B98
		private static void WriteSecurityResponse(XmlParser doc, SecurityResponse data)
		{
			doc.AddChild("ChallengeId");
			Xsd2CppUtil.WriteString(doc, data.ChallengeId);
			doc.Parent();
			doc.AddChild("Result");
			Xsd2CppUtil.WriteLong(doc, data.Result);
			doc.Parent();
		}

		// Token: 0x06001E22 RID: 7714 RVA: 0x00043BE8 File Offset: 0x00042BE8
		private static void WriteArbitrationPacket(XmlParser doc, ArbitrationPacket data)
		{
			doc.AddChild("AlternateEventDurationInMilliseconds");
			Xsd2CppUtil.WriteUInt(doc, data.AlternateEventDurationInMilliseconds);
			doc.Parent();
			doc.AddChild("CarId");
			Xsd2CppUtil.WriteLong(doc, data.CarId);
			doc.Parent();
			doc.AddChild("EventDurationInMilliseconds");
			Xsd2CppUtil.WriteUInt(doc, data.EventDurationInMilliseconds);
			doc.Parent();
			doc.AddChild("FinishReason");
			Xsd2CppUtil.WriteInt(doc, data.FinishReason);
			doc.Parent();
			doc.AddChild("FraudDetectionInfo");
			XSD2CPP.WriteFraudDetection(doc, data.FraudDetectionInfo);
			doc.Parent();
			doc.AddChild("HacksDetected");
			Xsd2CppUtil.WriteUInt(doc, data.HacksDetected);
			doc.Parent();
			doc.AddChild("PhysicsMetrics");
			XSD2CPP.WriteClientPhysicsMetrics(doc, data.PhysicsMetrics);
			doc.Parent();
			doc.AddChild("Rank");
			Xsd2CppUtil.WriteInt(doc, data.Rank);
			doc.Parent();
			doc.AddChild("Response");
			XSD2CPP.WriteSecurityResponse(doc, data.Response);
			doc.Parent();
		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x00043D14 File Offset: 0x00042D14
		private static void WritePursuitArbitrationPacket(XmlParser doc, PursuitArbitrationPacket data)
		{
			XSD2CPP.WriteArbitrationPacket(doc, data);
			doc.AddChild("CopsDeployed");
			Xsd2CppUtil.WriteInt(doc, data.CopsDeployed);
			doc.Parent();
			doc.AddChild("CopsDisabled");
			Xsd2CppUtil.WriteInt(doc, data.CopsDisabled);
			doc.Parent();
			doc.AddChild("CopsRammed");
			Xsd2CppUtil.WriteInt(doc, data.CopsRammed);
			doc.Parent();
			doc.AddChild("CostToState");
			Xsd2CppUtil.WriteInt(doc, data.CostToState);
			doc.Parent();
			doc.AddChild("Heat");
			Xsd2CppUtil.WriteFloat(doc, data.Heat);
			doc.Parent();
			doc.AddChild("Infractions");
			Xsd2CppUtil.WriteInt(doc, data.Infractions);
			doc.Parent();
			doc.AddChild("LongestJumpDurationInMilliseconds");
			Xsd2CppUtil.WriteUInt(doc, data.LongestJumpDurationInMilliseconds);
			doc.Parent();
			doc.AddChild("RoadBlocksDodged");
			Xsd2CppUtil.WriteInt(doc, data.RoadBlocksDodged);
			doc.Parent();
			doc.AddChild("SpikeStripsDodged");
			Xsd2CppUtil.WriteInt(doc, data.SpikeStripsDodged);
			doc.Parent();
			doc.AddChild("SumOfJumpsDurationInMilliseconds");
			Xsd2CppUtil.WriteUInt(doc, data.SumOfJumpsDurationInMilliseconds);
			doc.Parent();
			doc.AddChild("TopSpeed");
			Xsd2CppUtil.WriteFloat(doc, data.TopSpeed);
			doc.Parent();
		}

		// Token: 0x06001E24 RID: 7716 RVA: 0x00043E88 File Offset: 0x00042E88
		private static void WriteRouteArbitrationPacket(XmlParser doc, RouteArbitrationPacket data)
		{
			XSD2CPP.WriteArbitrationPacket(doc, data);
			doc.AddChild("BestLapDurationInMilliseconds");
			Xsd2CppUtil.WriteUInt(doc, data.BestLapDurationInMilliseconds);
			doc.Parent();
			doc.AddChild("FractionCompleted");
			Xsd2CppUtil.WriteFloat(doc, data.FractionCompleted);
			doc.Parent();
			doc.AddChild("LongestJumpDurationInMilliseconds");
			Xsd2CppUtil.WriteUInt(doc, data.LongestJumpDurationInMilliseconds);
			doc.Parent();
			doc.AddChild("NumberOfCollisions");
			Xsd2CppUtil.WriteInt(doc, data.NumberOfCollisions);
			doc.Parent();
			doc.AddChild("PerfectStart");
			Xsd2CppUtil.WriteInt(doc, data.PerfectStart);
			doc.Parent();
			doc.AddChild("SumOfJumpsDurationInMilliseconds");
			Xsd2CppUtil.WriteUInt(doc, data.SumOfJumpsDurationInMilliseconds);
			doc.Parent();
			doc.AddChild("TopSpeed");
			Xsd2CppUtil.WriteFloat(doc, data.TopSpeed);
			doc.Parent();
		}

		// Token: 0x06001E25 RID: 7717 RVA: 0x00043F7C File Offset: 0x00042F7C
		private static void WriteDragArbitrationPacket(XmlParser doc, DragArbitrationPacket data)
		{
			XSD2CPP.WriteArbitrationPacket(doc, data);
			doc.AddChild("FractionCompleted");
			Xsd2CppUtil.WriteFloat(doc, data.FractionCompleted);
			doc.Parent();
			doc.AddChild("LongestJumpDurationInMilliseconds");
			Xsd2CppUtil.WriteUInt(doc, data.LongestJumpDurationInMilliseconds);
			doc.Parent();
			doc.AddChild("NumberOfCollisions");
			Xsd2CppUtil.WriteInt(doc, data.NumberOfCollisions);
			doc.Parent();
			doc.AddChild("PerfectStart");
			Xsd2CppUtil.WriteInt(doc, data.PerfectStart);
			doc.Parent();
			doc.AddChild("SumOfJumpsDurationInMilliseconds");
			Xsd2CppUtil.WriteUInt(doc, data.SumOfJumpsDurationInMilliseconds);
			doc.Parent();
			doc.AddChild("TopSpeed");
			Xsd2CppUtil.WriteFloat(doc, data.TopSpeed);
			doc.Parent();
		}

		// Token: 0x06001E26 RID: 7718 RVA: 0x00044050 File Offset: 0x00043050
		private static void WriteTeamEscapeArbitrationPacket(XmlParser doc, TeamEscapeArbitrationPacket data)
		{
			XSD2CPP.WriteArbitrationPacket(doc, data);
			doc.AddChild("BustedCount");
			Xsd2CppUtil.WriteInt(doc, data.BustedCount);
			doc.Parent();
			doc.AddChild("CopsDeployed");
			Xsd2CppUtil.WriteInt(doc, data.CopsDeployed);
			doc.Parent();
			doc.AddChild("CopsDisabled");
			Xsd2CppUtil.WriteInt(doc, data.CopsDisabled);
			doc.Parent();
			doc.AddChild("CopsRammed");
			Xsd2CppUtil.WriteInt(doc, data.CopsRammed);
			doc.Parent();
			doc.AddChild("CostToState");
			Xsd2CppUtil.WriteInt(doc, data.CostToState);
			doc.Parent();
			doc.AddChild("DistanceToFinish");
			Xsd2CppUtil.WriteFloat(doc, data.DistanceToFinish);
			doc.Parent();
			doc.AddChild("FractionCompleted");
			Xsd2CppUtil.WriteFloat(doc, data.FractionCompleted);
			doc.Parent();
			doc.AddChild("Infractions");
			Xsd2CppUtil.WriteInt(doc, data.Infractions);
			doc.Parent();
			doc.AddChild("LongestJumpDurationInMilliseconds");
			Xsd2CppUtil.WriteUInt(doc, data.LongestJumpDurationInMilliseconds);
			doc.Parent();
			doc.AddChild("NumberOfCollisions");
			Xsd2CppUtil.WriteInt(doc, data.NumberOfCollisions);
			doc.Parent();
			doc.AddChild("PerfectStart");
			Xsd2CppUtil.WriteInt(doc, data.PerfectStart);
			doc.Parent();
			doc.AddChild("RoadBlocksDodged");
			Xsd2CppUtil.WriteInt(doc, data.RoadBlocksDodged);
			doc.Parent();
			doc.AddChild("SpikeStripsDodged");
			Xsd2CppUtil.WriteInt(doc, data.SpikeStripsDodged);
			doc.Parent();
			doc.AddChild("SumOfJumpsDurationInMilliseconds");
			Xsd2CppUtil.WriteUInt(doc, data.SumOfJumpsDurationInMilliseconds);
			doc.Parent();
			doc.AddChild("TopSpeed");
			Xsd2CppUtil.WriteFloat(doc, data.TopSpeed);
			doc.Parent();
		}

		// Token: 0x06001E27 RID: 7719 RVA: 0x00044244 File Offset: 0x00043244
		private static void WriteStatNameList(XmlParser doc, StatNameList data)
		{
			doc.AddChild("Stats");
			XSD2CPP.WriteArrayOfstring(doc, data.Stats);
			doc.Parent();
		}

		// Token: 0x06001E28 RID: 7720 RVA: 0x00044268 File Offset: 0x00043268
		private static void WriteProfileData(XmlParser doc, Victory.Service.Objects.ProfileData data)
		{
			doc.AddChild("Badges");
			XSD2CPP.WriteArrayOfBadgePacket(doc, data.Badges);
			doc.Parent();
			doc.AddChild("Cash");
			Xsd2CppUtil.WriteDouble(doc, data.Cash);
			doc.Parent();
			doc.AddChild("IconIndex");
			Xsd2CppUtil.WriteInt(doc, data.IconIndex);
			doc.Parent();
			doc.AddChild("Level");
			Xsd2CppUtil.WriteInt(doc, data.Level);
			doc.Parent();
			doc.AddChild("Motto");
			Xsd2CppUtil.WriteString(doc, data.Motto);
			doc.Parent();
			doc.AddChild("Name");
			Xsd2CppUtil.WriteString(doc, data.Name);
			doc.Parent();
			doc.AddChild("PercentToLevel");
			Xsd2CppUtil.WriteFloat(doc, data.PercentToLevel);
			doc.Parent();
			doc.AddChild("PersonaId");
			Xsd2CppUtil.WriteLong(doc, data.PersonaId);
			doc.Parent();
			doc.AddChild("Rating");
			Xsd2CppUtil.WriteDouble(doc, data.Rating);
			doc.Parent();
			doc.AddChild("Rep");
			Xsd2CppUtil.WriteDouble(doc, data.Rep);
			doc.Parent();
			doc.AddChild("RepAtCurrentLevel");
			Xsd2CppUtil.WriteInt(doc, data.RepAtCurrentLevel);
			doc.Parent();
			doc.AddChild("Score");
			Xsd2CppUtil.WriteInt(doc, data.Score);
			doc.Parent();
		}

		// Token: 0x06001E29 RID: 7721 RVA: 0x000443F4 File Offset: 0x000433F4
		private static void WriteArrayOfPersonaBase(XmlParser doc, List<PersonaBase> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("PersonaBase");
				XSD2CPP.WritePersonaBase(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001E2A RID: 7722 RVA: 0x00044434 File Offset: 0x00043434
		private static void WriteAchievementsPacket(XmlParser doc, AchievementsPacket data)
		{
			doc.AddChild("Badges");
			XSD2CPP.WriteArrayOfBadgeDefinitionPacket(doc, data.Badges);
			doc.Parent();
			doc.AddChild("Definitions");
			XSD2CPP.WriteArrayOfAchievementDefinitionPacket(doc, data.Definitions);
			doc.Parent();
			doc.AddChild("PersonaId");
			Xsd2CppUtil.WriteLong(doc, data.PersonaId);
			doc.Parent();
		}

		// Token: 0x06001E2B RID: 7723 RVA: 0x000444A0 File Offset: 0x000434A0
		private static void WriteBadgeDefinitionPacket(XmlParser doc, BadgeDefinitionPacket data)
		{
			doc.AddChild("Background");
			Xsd2CppUtil.WriteString(doc, data.Background);
			doc.Parent();
			doc.AddChild("BadgeDefinitionId");
			Xsd2CppUtil.WriteInt(doc, data.BadgeDefinitionId);
			doc.Parent();
			doc.AddChild("Border");
			Xsd2CppUtil.WriteString(doc, data.Border);
			doc.Parent();
			doc.AddChild("Description");
			Xsd2CppUtil.WriteString(doc, data.Description);
			doc.Parent();
			doc.AddChild("Icon");
			Xsd2CppUtil.WriteString(doc, data.Icon);
			doc.Parent();
			doc.AddChild("Name");
			Xsd2CppUtil.WriteString(doc, data.Name);
			doc.Parent();
		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x00044570 File Offset: 0x00043570
		private static void WriteArrayOfBadgeDefinitionPacket(XmlParser doc, List<BadgeDefinitionPacket> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("BadgeDefinitionPacket");
				XSD2CPP.WriteBadgeDefinitionPacket(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001E2D RID: 7725 RVA: 0x000445B0 File Offset: 0x000435B0
		private static void WriteAchievementDefinitionPacket(XmlParser doc, AchievementDefinitionPacket data)
		{
			doc.AddChild("AchievementDefinitionId");
			Xsd2CppUtil.WriteInt(doc, data.AchievementDefinitionId);
			doc.Parent();
			doc.AddChild("AchievementRanks");
			XSD2CPP.WriteArrayOfAchievementRankPacket(doc, data.AchievementRanks);
			doc.Parent();
			doc.AddChild("BadgeDefinitionId");
			Xsd2CppUtil.WriteInt(doc, data.BadgeDefinitionId);
			doc.Parent();
			doc.AddChild("CanProgress");
			Xsd2CppUtil.WriteBoolean(doc, data.CanProgress);
			doc.Parent();
			doc.AddChild("CurrentValue");
			Xsd2CppUtil.WriteLong(doc, data.CurrentValue);
			doc.Parent();
			doc.AddChild("IsVisible");
			Xsd2CppUtil.WriteBoolean(doc, data.IsVisible);
			doc.Parent();
			doc.AddChild("ProgressText");
			Xsd2CppUtil.WriteString(doc, data.ProgressText);
			doc.Parent();
			doc.AddChild("StatConversion");
			XSD2CPP.WriteStatConversion(doc, data.StatConversion);
			doc.Parent();
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x000446BC File Offset: 0x000436BC
		private static void WriteArrayOfAchievementDefinitionPacket(XmlParser doc, List<AchievementDefinitionPacket> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("AchievementDefinitionPacket");
				XSD2CPP.WriteAchievementDefinitionPacket(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x000446FC File Offset: 0x000436FC
		private static void WriteAchievementRankPacket(XmlParser doc, AchievementRankPacket data)
		{
			doc.AddChild("AchievedOn");
			Xsd2CppUtil.WriteDateTime(doc, data.AchievedOn);
			doc.Parent();
			doc.AddChild("AchievementRankId");
			Xsd2CppUtil.WriteInt(doc, data.AchievementRankId);
			doc.Parent();
			doc.AddChild("IsRare");
			Xsd2CppUtil.WriteBoolean(doc, data.IsRare);
			doc.Parent();
			doc.AddChild("Points");
			Xsd2CppUtil.WriteShort(doc, data.Points);
			doc.Parent();
			doc.AddChild("Rank");
			Xsd2CppUtil.WriteShort(doc, data.Rank);
			doc.Parent();
			doc.AddChild("Rarity");
			Xsd2CppUtil.WriteFloat(doc, data.Rarity);
			doc.Parent();
			doc.AddChild("RewardDescription");
			Xsd2CppUtil.WriteString(doc, data.RewardDescription);
			doc.Parent();
			doc.AddChild("RewardType");
			Xsd2CppUtil.WriteString(doc, data.RewardType);
			doc.Parent();
			doc.AddChild("RewardVisualStyle");
			Xsd2CppUtil.WriteString(doc, data.RewardVisualStyle);
			doc.Parent();
			doc.AddChild("State");
			XSD2CPP.WriteAchievementState(doc, data.State);
			doc.Parent();
			doc.AddChild("ThresholdValue");
			Xsd2CppUtil.WriteLong(doc, data.ThresholdValue);
			doc.Parent();
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x00044868 File Offset: 0x00043868
		private static void WriteArrayOfAchievementRankPacket(XmlParser doc, List<AchievementRankPacket> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("AchievementRankPacket");
				XSD2CPP.WriteAchievementRankPacket(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x000448A8 File Offset: 0x000438A8
		private static void WriteAchievementRewards(XmlParser doc, AchievementRewards data)
		{
			XSD2CPP.WriteCommerceResultTrans(doc, data);
			doc.AddChild("AchievementRankId");
			Xsd2CppUtil.WriteInt(doc, data.AchievementRankId);
			doc.Parent();
			doc.AddChild("VisualStyle");
			Xsd2CppUtil.WriteString(doc, data.VisualStyle);
			doc.Parent();
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x000448FC File Offset: 0x000438FC
		private static void WriteBadgeBundle(XmlParser doc, BadgeBundle data)
		{
			doc.AddChild("Badges");
			XSD2CPP.WriteArrayOfBadgeInput(doc, data.Badges);
			doc.Parent();
		}

		// Token: 0x06001E33 RID: 7731 RVA: 0x00044920 File Offset: 0x00043920
		private static void WriteBadgeInput(XmlParser doc, BadgeInput data)
		{
			doc.AddChild("BadgeDefinitionId");
			Xsd2CppUtil.WriteInt(doc, data.BadgeDefinitionId);
			doc.Parent();
			doc.AddChild("SlotId");
			Xsd2CppUtil.WriteShort(doc, data.SlotId);
			doc.Parent();
		}

		// Token: 0x06001E34 RID: 7732 RVA: 0x00044970 File Offset: 0x00043970
		private static void WriteArrayOfBadgeInput(XmlParser doc, List<BadgeInput> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("BadgeInput");
				XSD2CPP.WriteBadgeInput(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001E35 RID: 7733 RVA: 0x000449AE File Offset: 0x000439AE
		private static void WriteBadgesPacket(XmlParser doc, BadgesPacket data)
		{
			doc.AddChild("Badges");
			XSD2CPP.WriteArrayOfBadgePacket(doc, data.Badges);
			doc.Parent();
		}

		// Token: 0x06001E36 RID: 7734 RVA: 0x000449D0 File Offset: 0x000439D0
		private static void WriteShardInfo(XmlParser doc, ShardInfo data)
		{
			doc.AddChild("RegionId");
			Xsd2CppUtil.WriteInt(doc, data.RegionId);
			doc.Parent();
			doc.AddChild("RegionName");
			Xsd2CppUtil.WriteString(doc, data.RegionName);
			doc.Parent();
			doc.AddChild("ShardName");
			Xsd2CppUtil.WriteString(doc, data.ShardName);
			doc.Parent();
			doc.AddChild("Url");
			Xsd2CppUtil.WriteString(doc, data.Url);
			doc.Parent();
		}

		// Token: 0x06001E37 RID: 7735 RVA: 0x00044A60 File Offset: 0x00043A60
		private static void WriteArrayOfShardInfo(XmlParser doc, List<ShardInfo> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("ShardInfo");
				XSD2CPP.WriteShardInfo(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x00044AA0 File Offset: 0x00043AA0
		private static void WriteReport(XmlParser doc, Report data)
		{
			doc.AddChild("chatTranscripts");
			XSD2CPP.WriteArrayOfChatTranscript(doc, data.chatTranscripts);
			doc.Parent();
			doc.AddChild("errorReport");
			XSD2CPP.WriteArrayOfErrorReport(doc, data.errorReport);
			doc.Parent();
			doc.AddChild("fraudDetectionReport");
			XSD2CPP.WriteArrayOfFraudDetection(doc, data.fraudDetectionReport);
			doc.Parent();
			doc.AddChild("shortcutUsage");
			XSD2CPP.WriteArrayOfShortcutUsage(doc, data.shortcutUsage);
			doc.Parent();
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x00044B2C File Offset: 0x00043B2C
		private static void WriteChatTranscript(XmlParser doc, ChatTranscript data)
		{
			doc.AddChild("Message");
			Xsd2CppUtil.WriteString(doc, data.Message);
			doc.Parent();
			doc.AddChild("PersonaId");
			Xsd2CppUtil.WriteLong(doc, data.PersonaId);
			doc.Parent();
			doc.AddChild("TargetPersonaId");
			Xsd2CppUtil.WriteString(doc, data.TargetPersonaId);
			doc.Parent();
			doc.AddChild("UserId");
			Xsd2CppUtil.WriteLong(doc, data.UserId);
			doc.Parent();
		}

		// Token: 0x06001E3A RID: 7738 RVA: 0x00044BBC File Offset: 0x00043BBC
		private static void WriteArrayOfChatTranscript(XmlParser doc, List<ChatTranscript> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("ChatTranscript");
				XSD2CPP.WriteChatTranscript(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001E3B RID: 7739 RVA: 0x00044BFC File Offset: 0x00043BFC
		private static void WriteErrorReport(XmlParser doc, ErrorReport data)
		{
			doc.AddChild("errorCode");
			Xsd2CppUtil.WriteInt(doc, data.errorCode);
			doc.Parent();
			doc.AddChild("errorDescription");
			Xsd2CppUtil.WriteString(doc, data.errorDescription);
			doc.Parent();
		}

		// Token: 0x06001E3C RID: 7740 RVA: 0x00044C4C File Offset: 0x00043C4C
		private static void WriteArrayOfErrorReport(XmlParser doc, List<ErrorReport> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("ErrorReport");
				XSD2CPP.WriteErrorReport(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x00044C8C File Offset: 0x00043C8C
		private static void WriteArrayOfFraudDetection(XmlParser doc, List<FraudDetection> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("FraudDetection");
				XSD2CPP.WriteFraudDetection(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x00044CCC File Offset: 0x00043CCC
		private static void WriteShortcutUsage(XmlParser doc, ShortcutUsage data)
		{
			doc.AddChild("shortCut");
			Xsd2CppUtil.WriteString(doc, data.shortCut);
			doc.Parent();
			doc.AddChild("timesUsed");
			Xsd2CppUtil.WriteInt(doc, data.timesUsed);
			doc.Parent();
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x00044D1C File Offset: 0x00043D1C
		private static void WriteArrayOfShortcutUsage(XmlParser doc, List<ShortcutUsage> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("ShortcutUsage");
				XSD2CPP.WriteShortcutUsage(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001E40 RID: 7744 RVA: 0x00044D5A File Offset: 0x00043D5A
		private static void WriteFraudDetectionCollection(XmlParser doc, FraudDetectionCollection data)
		{
			doc.AddChild("FraudDetectionLogs");
			XSD2CPP.WriteArrayOfFraudDetection(doc, data.FraudDetectionLogs);
			doc.Parent();
		}

		// Token: 0x06001E41 RID: 7745 RVA: 0x00044D7C File Offset: 0x00043D7C
		public static bool WriterXML(AchievementsAwarded data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("AchievementsAwarded");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteAchievementsAwarded(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001E42 RID: 7746 RVA: 0x00044DCD File Offset: 0x00043DCD
		public static bool Writer(AchievementsAwarded data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001E43 RID: 7747 RVA: 0x00044DD6 File Offset: 0x00043DD6
		public static bool WriteAchievementsAwarded(AchievementsAwarded data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x00044DE0 File Offset: 0x00043DE0
		public static bool WriterXML(AchievementAwarded data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("AchievementAwarded");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteAchievementAwarded(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x00044E31 File Offset: 0x00043E31
		public static bool Writer(AchievementAwarded data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001E46 RID: 7750 RVA: 0x00044E3A File Offset: 0x00043E3A
		public static bool WriteAchievementAwarded(AchievementAwarded data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001E47 RID: 7751 RVA: 0x00044E44 File Offset: 0x00043E44
		public static bool WriterXML(List<AchievementAwarded> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfAchievementAwarded");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfAchievementAwarded(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001E48 RID: 7752 RVA: 0x00044E95 File Offset: 0x00043E95
		public static bool Writer(List<AchievementAwarded> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001E49 RID: 7753 RVA: 0x00044E9E File Offset: 0x00043E9E
		public static bool WriteArrayOfAchievementAwarded(List<AchievementAwarded> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x00044EA8 File Offset: 0x00043EA8
		public static bool WriterXML(BadgePacket data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("BadgePacket");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteBadgePacket(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x00044EF9 File Offset: 0x00043EF9
		public static bool Writer(BadgePacket data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x00044F02 File Offset: 0x00043F02
		public static bool WriteBadgePacket(BadgePacket data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x00044F0C File Offset: 0x00043F0C
		public static bool WriterXML(List<BadgePacket> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfBadgePacket");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfBadgePacket(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x00044F5D File Offset: 0x00043F5D
		public static bool Writer(List<BadgePacket> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x00044F66 File Offset: 0x00043F66
		public static bool WriteArrayOfBadgePacket(List<BadgePacket> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x00044F70 File Offset: 0x00043F70
		public static bool WriterXML(AchievementProgress data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("AchievementProgress");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteAchievementProgress(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x00044FC1 File Offset: 0x00043FC1
		public static bool Writer(AchievementProgress data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x00044FCA File Offset: 0x00043FCA
		public static bool WriteAchievementProgress(AchievementProgress data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x00044FD4 File Offset: 0x00043FD4
		public static bool WriterXML(List<AchievementProgress> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfAchievementProgress");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfAchievementProgress(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x00045025 File Offset: 0x00044025
		public static bool Writer(List<AchievementProgress> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x0004502E File Offset: 0x0004402E
		public static bool WriteArrayOfAchievementProgress(List<AchievementProgress> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x00045038 File Offset: 0x00044038
		public static bool WriterXML(PersonaBase data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("PersonaBase");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WritePersonaBase(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x00045089 File Offset: 0x00044089
		public static bool Writer(PersonaBase data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x00045092 File Offset: 0x00044092
		public static bool WritePersonaBase(PersonaBase data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001E59 RID: 7769 RVA: 0x0004509C File Offset: 0x0004409C
		public static bool WriterXML(FraudDetection data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("FraudDetection");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteFraudDetection(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001E5A RID: 7770 RVA: 0x000450ED File Offset: 0x000440ED
		public static bool Writer(FraudDetection data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001E5B RID: 7771 RVA: 0x000450F6 File Offset: 0x000440F6
		public static bool WriteFraudDetection(FraudDetection data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001E5C RID: 7772 RVA: 0x00045100 File Offset: 0x00044100
		public static bool WriterXML(ClientPhysicsMetrics data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ClientPhysicsMetrics");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteClientPhysicsMetrics(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x00045151 File Offset: 0x00044151
		public static bool Writer(ClientPhysicsMetrics data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001E5E RID: 7774 RVA: 0x0004515A File Offset: 0x0004415A
		public static bool WriteClientPhysicsMetrics(ClientPhysicsMetrics data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x00045164 File Offset: 0x00044164
		public static bool WriterXML(SecurityResponse data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("SecurityResponse");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteSecurityResponse(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x000451B5 File Offset: 0x000441B5
		public static bool Writer(SecurityResponse data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001E61 RID: 7777 RVA: 0x000451BE File Offset: 0x000441BE
		public static bool WriteSecurityResponse(SecurityResponse data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x000451C8 File Offset: 0x000441C8
		public static bool WriterXML(ArbitrationPacket data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArbitrationPacket");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArbitrationPacket(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001E63 RID: 7779 RVA: 0x00045219 File Offset: 0x00044219
		public static bool Writer(ArbitrationPacket data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001E64 RID: 7780 RVA: 0x00045222 File Offset: 0x00044222
		public static bool WriteArbitrationPacket(ArbitrationPacket data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001E65 RID: 7781 RVA: 0x0004522C File Offset: 0x0004422C
		public static bool WriterXML(PursuitArbitrationPacket data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("PursuitArbitrationPacket");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WritePursuitArbitrationPacket(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001E66 RID: 7782 RVA: 0x0004527D File Offset: 0x0004427D
		public static bool Writer(PursuitArbitrationPacket data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001E67 RID: 7783 RVA: 0x00045286 File Offset: 0x00044286
		public static bool WritePursuitArbitrationPacket(PursuitArbitrationPacket data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001E68 RID: 7784 RVA: 0x00045290 File Offset: 0x00044290
		public static bool WriterXML(RouteArbitrationPacket data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("RouteArbitrationPacket");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteRouteArbitrationPacket(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001E69 RID: 7785 RVA: 0x000452E1 File Offset: 0x000442E1
		public static bool Writer(RouteArbitrationPacket data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x000452EA File Offset: 0x000442EA
		public static bool WriteRouteArbitrationPacket(RouteArbitrationPacket data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x000452F4 File Offset: 0x000442F4
		public static bool WriterXML(DragArbitrationPacket data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("DragArbitrationPacket");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteDragArbitrationPacket(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x00045345 File Offset: 0x00044345
		public static bool Writer(DragArbitrationPacket data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x0004534E File Offset: 0x0004434E
		public static bool WriteDragArbitrationPacket(DragArbitrationPacket data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x00045358 File Offset: 0x00044358
		public static bool WriterXML(TeamEscapeArbitrationPacket data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("TeamEscapeArbitrationPacket");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteTeamEscapeArbitrationPacket(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x000453A9 File Offset: 0x000443A9
		public static bool Writer(TeamEscapeArbitrationPacket data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001E70 RID: 7792 RVA: 0x000453B2 File Offset: 0x000443B2
		public static bool WriteTeamEscapeArbitrationPacket(TeamEscapeArbitrationPacket data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001E71 RID: 7793 RVA: 0x000453BC File Offset: 0x000443BC
		public static bool WriterXML(StatNameList data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("StatNameList");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteStatNameList(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001E72 RID: 7794 RVA: 0x0004540D File Offset: 0x0004440D
		public static bool Writer(StatNameList data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001E73 RID: 7795 RVA: 0x00045416 File Offset: 0x00044416
		public static bool WriteStatNameList(StatNameList data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001E74 RID: 7796 RVA: 0x00045420 File Offset: 0x00044420
		public static bool WriterXML(Victory.Service.Objects.ProfileData data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ProfileData");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteProfileData(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001E75 RID: 7797 RVA: 0x00045471 File Offset: 0x00044471
		public static bool Writer(Victory.Service.Objects.ProfileData data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001E76 RID: 7798 RVA: 0x0004547A File Offset: 0x0004447A
		public static bool WriteProfileData(Victory.Service.Objects.ProfileData data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001E77 RID: 7799 RVA: 0x00045484 File Offset: 0x00044484
		public static bool WriterXML(List<PersonaBase> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfPersonaBase");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfPersonaBase(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x000454D5 File Offset: 0x000444D5
		public static bool Writer(List<PersonaBase> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001E79 RID: 7801 RVA: 0x000454DE File Offset: 0x000444DE
		public static bool WriteArrayOfPersonaBase(List<PersonaBase> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001E7A RID: 7802 RVA: 0x000454E8 File Offset: 0x000444E8
		public static bool WriterXML(AchievementsPacket data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("AchievementsPacket");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteAchievementsPacket(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001E7B RID: 7803 RVA: 0x00045539 File Offset: 0x00044539
		public static bool Writer(AchievementsPacket data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001E7C RID: 7804 RVA: 0x00045542 File Offset: 0x00044542
		public static bool WriteAchievementsPacket(AchievementsPacket data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001E7D RID: 7805 RVA: 0x0004554C File Offset: 0x0004454C
		public static bool WriterXML(BadgeDefinitionPacket data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("BadgeDefinitionPacket");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteBadgeDefinitionPacket(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001E7E RID: 7806 RVA: 0x0004559D File Offset: 0x0004459D
		public static bool Writer(BadgeDefinitionPacket data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001E7F RID: 7807 RVA: 0x000455A6 File Offset: 0x000445A6
		public static bool WriteBadgeDefinitionPacket(BadgeDefinitionPacket data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001E80 RID: 7808 RVA: 0x000455B0 File Offset: 0x000445B0
		public static bool WriterXML(List<BadgeDefinitionPacket> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfBadgeDefinitionPacket");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfBadgeDefinitionPacket(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x00045601 File Offset: 0x00044601
		public static bool Writer(List<BadgeDefinitionPacket> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001E82 RID: 7810 RVA: 0x0004560A File Offset: 0x0004460A
		public static bool WriteArrayOfBadgeDefinitionPacket(List<BadgeDefinitionPacket> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001E83 RID: 7811 RVA: 0x00045614 File Offset: 0x00044614
		public static bool WriterXML(AchievementDefinitionPacket data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("AchievementDefinitionPacket");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteAchievementDefinitionPacket(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001E84 RID: 7812 RVA: 0x00045665 File Offset: 0x00044665
		public static bool Writer(AchievementDefinitionPacket data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001E85 RID: 7813 RVA: 0x0004566E File Offset: 0x0004466E
		public static bool WriteAchievementDefinitionPacket(AchievementDefinitionPacket data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001E86 RID: 7814 RVA: 0x00045678 File Offset: 0x00044678
		public static bool WriterXML(List<AchievementDefinitionPacket> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfAchievementDefinitionPacket");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfAchievementDefinitionPacket(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001E87 RID: 7815 RVA: 0x000456C9 File Offset: 0x000446C9
		public static bool Writer(List<AchievementDefinitionPacket> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001E88 RID: 7816 RVA: 0x000456D2 File Offset: 0x000446D2
		public static bool WriteArrayOfAchievementDefinitionPacket(List<AchievementDefinitionPacket> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001E89 RID: 7817 RVA: 0x000456DC File Offset: 0x000446DC
		public static bool WriterXML(AchievementRankPacket data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("AchievementRankPacket");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteAchievementRankPacket(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001E8A RID: 7818 RVA: 0x0004572D File Offset: 0x0004472D
		public static bool Writer(AchievementRankPacket data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001E8B RID: 7819 RVA: 0x00045736 File Offset: 0x00044736
		public static bool WriteAchievementRankPacket(AchievementRankPacket data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001E8C RID: 7820 RVA: 0x00045740 File Offset: 0x00044740
		public static bool WriterXML(List<AchievementRankPacket> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfAchievementRankPacket");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfAchievementRankPacket(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001E8D RID: 7821 RVA: 0x00045791 File Offset: 0x00044791
		public static bool Writer(List<AchievementRankPacket> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001E8E RID: 7822 RVA: 0x0004579A File Offset: 0x0004479A
		public static bool WriteArrayOfAchievementRankPacket(List<AchievementRankPacket> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001E8F RID: 7823 RVA: 0x000457A4 File Offset: 0x000447A4
		public static bool WriterXML(AchievementRewards data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("AchievementRewards");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteAchievementRewards(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001E90 RID: 7824 RVA: 0x000457F5 File Offset: 0x000447F5
		public static bool Writer(AchievementRewards data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001E91 RID: 7825 RVA: 0x000457FE File Offset: 0x000447FE
		public static bool WriteAchievementRewards(AchievementRewards data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001E92 RID: 7826 RVA: 0x00045808 File Offset: 0x00044808
		public static bool WriterXML(BadgeBundle data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("BadgeBundle");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteBadgeBundle(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001E93 RID: 7827 RVA: 0x00045859 File Offset: 0x00044859
		public static bool Writer(BadgeBundle data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001E94 RID: 7828 RVA: 0x00045862 File Offset: 0x00044862
		public static bool WriteBadgeBundle(BadgeBundle data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001E95 RID: 7829 RVA: 0x0004586C File Offset: 0x0004486C
		public static bool WriterXML(BadgeInput data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("BadgeInput");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteBadgeInput(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001E96 RID: 7830 RVA: 0x000458BD File Offset: 0x000448BD
		public static bool Writer(BadgeInput data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001E97 RID: 7831 RVA: 0x000458C6 File Offset: 0x000448C6
		public static bool WriteBadgeInput(BadgeInput data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001E98 RID: 7832 RVA: 0x000458D0 File Offset: 0x000448D0
		public static bool WriterXML(List<BadgeInput> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfBadgeInput");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfBadgeInput(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x00045921 File Offset: 0x00044921
		public static bool Writer(List<BadgeInput> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x0004592A File Offset: 0x0004492A
		public static bool WriteArrayOfBadgeInput(List<BadgeInput> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001E9B RID: 7835 RVA: 0x00045934 File Offset: 0x00044934
		public static bool WriterXML(BadgesPacket data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("BadgesPacket");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteBadgesPacket(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001E9C RID: 7836 RVA: 0x00045985 File Offset: 0x00044985
		public static bool Writer(BadgesPacket data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x0004598E File Offset: 0x0004498E
		public static bool WriteBadgesPacket(BadgesPacket data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001E9E RID: 7838 RVA: 0x00045998 File Offset: 0x00044998
		public static bool WriterXML(ShardInfo data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ShardInfo");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteShardInfo(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x000459E9 File Offset: 0x000449E9
		public static bool Writer(ShardInfo data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x000459F2 File Offset: 0x000449F2
		public static bool WriteShardInfo(ShardInfo data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x000459FC File Offset: 0x000449FC
		public static bool WriterXML(List<ShardInfo> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfShardInfo");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfShardInfo(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x00045A4D File Offset: 0x00044A4D
		public static bool Writer(List<ShardInfo> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001EA3 RID: 7843 RVA: 0x00045A56 File Offset: 0x00044A56
		public static bool WriteArrayOfShardInfo(List<ShardInfo> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x00045A60 File Offset: 0x00044A60
		public static bool WriterXML(Report data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("Report");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteReport(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x00045AB1 File Offset: 0x00044AB1
		public static bool Writer(Report data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001EA6 RID: 7846 RVA: 0x00045ABA File Offset: 0x00044ABA
		public static bool WriteReport(Report data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x00045AC4 File Offset: 0x00044AC4
		public static bool WriterXML(ChatTranscript data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ChatTranscript");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteChatTranscript(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x00045B15 File Offset: 0x00044B15
		public static bool Writer(ChatTranscript data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x00045B1E File Offset: 0x00044B1E
		public static bool WriteChatTranscript(ChatTranscript data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001EAA RID: 7850 RVA: 0x00045B28 File Offset: 0x00044B28
		public static bool WriterXML(List<ChatTranscript> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfChatTranscript");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfChatTranscript(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001EAB RID: 7851 RVA: 0x00045B79 File Offset: 0x00044B79
		public static bool Writer(List<ChatTranscript> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001EAC RID: 7852 RVA: 0x00045B82 File Offset: 0x00044B82
		public static bool WriteArrayOfChatTranscript(List<ChatTranscript> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001EAD RID: 7853 RVA: 0x00045B8C File Offset: 0x00044B8C
		public static bool WriterXML(ErrorReport data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ErrorReport");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteErrorReport(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001EAE RID: 7854 RVA: 0x00045BDD File Offset: 0x00044BDD
		public static bool Writer(ErrorReport data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001EAF RID: 7855 RVA: 0x00045BE6 File Offset: 0x00044BE6
		public static bool WriteErrorReport(ErrorReport data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001EB0 RID: 7856 RVA: 0x00045BF0 File Offset: 0x00044BF0
		public static bool WriterXML(List<ErrorReport> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfErrorReport");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfErrorReport(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001EB1 RID: 7857 RVA: 0x00045C41 File Offset: 0x00044C41
		public static bool Writer(List<ErrorReport> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001EB2 RID: 7858 RVA: 0x00045C4A File Offset: 0x00044C4A
		public static bool WriteArrayOfErrorReport(List<ErrorReport> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001EB3 RID: 7859 RVA: 0x00045C54 File Offset: 0x00044C54
		public static bool WriterXML(List<FraudDetection> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfFraudDetection");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfFraudDetection(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001EB4 RID: 7860 RVA: 0x00045CA5 File Offset: 0x00044CA5
		public static bool Writer(List<FraudDetection> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001EB5 RID: 7861 RVA: 0x00045CAE File Offset: 0x00044CAE
		public static bool WriteArrayOfFraudDetection(List<FraudDetection> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001EB6 RID: 7862 RVA: 0x00045CB8 File Offset: 0x00044CB8
		public static bool WriterXML(ShortcutUsage data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ShortcutUsage");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteShortcutUsage(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001EB7 RID: 7863 RVA: 0x00045D09 File Offset: 0x00044D09
		public static bool Writer(ShortcutUsage data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001EB8 RID: 7864 RVA: 0x00045D12 File Offset: 0x00044D12
		public static bool WriteShortcutUsage(ShortcutUsage data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001EB9 RID: 7865 RVA: 0x00045D1C File Offset: 0x00044D1C
		public static bool WriterXML(List<ShortcutUsage> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfShortcutUsage");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfShortcutUsage(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001EBA RID: 7866 RVA: 0x00045D6D File Offset: 0x00044D6D
		public static bool Writer(List<ShortcutUsage> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001EBB RID: 7867 RVA: 0x00045D76 File Offset: 0x00044D76
		public static bool WriteArrayOfShortcutUsage(List<ShortcutUsage> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001EBC RID: 7868 RVA: 0x00045D80 File Offset: 0x00044D80
		public static bool WriterXML(FraudDetectionCollection data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("FraudDetectionCollection");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service.Objects");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteFraudDetectionCollection(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x00045DD1 File Offset: 0x00044DD1
		public static bool Writer(FraudDetectionCollection data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001EBE RID: 7870 RVA: 0x00045DDA File Offset: 0x00044DDA
		public static bool WriteFraudDetectionCollection(FraudDetectionCollection data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001EBF RID: 7871 RVA: 0x00045DE4 File Offset: 0x00044DE4
		public static bool ReadLobbyEntrantRemovedClass(XmlParser doc, LobbyEntrantRemoved data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadLobbyEntrantRemoved(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x00045E2C File Offset: 0x00044E2C
		public static bool ReadSecurityChallengeClass(XmlParser doc, SecurityChallenge data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadSecurityChallenge(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x00045E74 File Offset: 0x00044E74
		public static bool ReadP2PCryptoTicketClass(XmlParser doc, P2PCryptoTicket data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadP2PCryptoTicket(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001EC2 RID: 7874 RVA: 0x00045EBC File Offset: 0x00044EBC
		public static bool ReadArrayOfP2PCryptoTicketClass(XmlParser doc, List<P2PCryptoTicket> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfP2PCryptoTicket(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001EC3 RID: 7875 RVA: 0x00045F04 File Offset: 0x00044F04
		public static bool ReadLobbyEntrantInfoClass(XmlParser doc, LobbyEntrantInfo data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadLobbyEntrantInfo(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001EC4 RID: 7876 RVA: 0x00045F4C File Offset: 0x00044F4C
		public static bool ReadArrayOfLobbyEntrantInfoClass(XmlParser doc, List<LobbyEntrantInfo> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfLobbyEntrantInfo(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001EC5 RID: 7877 RVA: 0x00045F94 File Offset: 0x00044F94
		public static bool ReadSessionInfoClass(XmlParser doc, SessionInfo data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadSessionInfo(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001EC6 RID: 7878 RVA: 0x00045FDC File Offset: 0x00044FDC
		public static bool ReadLobbyLaunchedClass(XmlParser doc, LobbyLaunched data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadLobbyLaunched(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001EC7 RID: 7879 RVA: 0x00046024 File Offset: 0x00045024
		public static bool ReadEngineInnerExceptionTransClass(XmlParser doc, EngineInnerExceptionTrans data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadEngineInnerExceptionTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001EC8 RID: 7880 RVA: 0x0004606C File Offset: 0x0004506C
		public static bool ReadEngineExceptionTransClass(XmlParser doc, EngineExceptionTrans data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadEngineExceptionTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001EC9 RID: 7881 RVA: 0x000460B4 File Offset: 0x000450B4
		public static bool ReadLobbyCancelledClass(XmlParser doc, LobbyCancelled data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadLobbyCancelled(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001ECA RID: 7882 RVA: 0x000460FC File Offset: 0x000450FC
		public static bool ReadLobbyInviteClass(XmlParser doc, LobbyInvite data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadLobbyInvite(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001ECB RID: 7883 RVA: 0x00046144 File Offset: 0x00045144
		public static bool ReadLobbyCountdownClass(XmlParser doc, LobbyCountdown data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadLobbyCountdown(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001ECC RID: 7884 RVA: 0x0004618C File Offset: 0x0004518C
		public static bool ReadLobbyEntrantAddedClass(XmlParser doc, LobbyEntrantAdded data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadLobbyEntrantAdded(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001ECD RID: 7885 RVA: 0x000461D4 File Offset: 0x000451D4
		public static bool ReadLobbyEntrantUpdatedClass(XmlParser doc, LobbyEntrantUpdated data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadLobbyEntrantUpdated(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001ECE RID: 7886 RVA: 0x0004621C File Offset: 0x0004521C
		public static bool ReadLobbyInfoClass(XmlParser doc, LobbyInfo data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadLobbyInfo(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001ECF RID: 7887 RVA: 0x00046264 File Offset: 0x00045264
		public static bool ReadSystemInfoClass(XmlParser doc, SystemInfo data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadSystemInfo(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001ED0 RID: 7888 RVA: 0x000462AC File Offset: 0x000452AC
		public static bool ReadCdnClass(XmlParser doc, Cdn data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadCdn(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001ED1 RID: 7889 RVA: 0x000462F4 File Offset: 0x000452F4
		public static bool ReadregionClass(XmlParser doc, region data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.Readregion(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x0004633C File Offset: 0x0004533C
		public static bool ReadArrayOfregionClass(XmlParser doc, List<region> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfregion(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001ED3 RID: 7891 RVA: 0x00046384 File Offset: 0x00045384
		public static bool ReadTermsOfServiceClass(XmlParser doc, TermsOfService data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadTermsOfService(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x000463CC File Offset: 0x000453CC
		public static bool ReadconfigurationClass(XmlParser doc, configuration data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.Readconfiguration(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x00046414 File Offset: 0x00045414
		public static bool ReadServerTimeClass(XmlParser doc, ServerTime data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Service");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadServerTime(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001ED6 RID: 7894 RVA: 0x0004645C File Offset: 0x0004545C
		private static bool ReadLobbyEntrantStateAttribute(string pValue, out LobbyEntrantState data)
		{
			return LobbyEntrantStateConverter.Parse(pValue, out data);
		}

		// Token: 0x06001ED7 RID: 7895 RVA: 0x00046468 File Offset: 0x00045468
		private static bool ReadLobbyEntrantState(XmlParser doc, out LobbyEntrantState data)
		{
			string value = doc.GetValue();
			return LobbyEntrantStateConverter.Parse(value, out data);
		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x00046484 File Offset: 0x00045484
		private static bool ReadLobbyEntrantRemoved(XmlParser doc, LobbyEntrantRemoved data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "LobbyId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.LobbyId);
			}
			doc.Parent();
			pName = prefix + "PersonaId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.PersonaId);
			}
			return true;
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x000464F0 File Offset: 0x000454F0
		private static bool ReadSecurityChallenge(XmlParser doc, SecurityChallenge data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "ChallengeId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.ChallengeId);
			}
			doc.Parent();
			pName = prefix + "LeftSize";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.LeftSize);
			}
			doc.Parent();
			pName = prefix + "Pattern";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Pattern);
			}
			doc.Parent();
			pName = prefix + "RightSize";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.RightSize);
			}
			return true;
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x000465B0 File Offset: 0x000455B0
		private static bool ReadP2PCryptoTicket(XmlParser doc, P2PCryptoTicket data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "PersonaId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.PersonaId);
			}
			doc.Parent();
			pName = prefix + "SessionKey";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.SessionKey);
			}
			return true;
		}

		// Token: 0x06001EDB RID: 7899 RVA: 0x0004661C File Offset: 0x0004561C
		private static bool ReadArrayOfP2PCryptoTicket(XmlParser doc, List<P2PCryptoTicket> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "P2PCryptoTicket";
			}
			for (;;)
			{
				P2PCryptoTicket p2PCryptoTicket = new P2PCryptoTicket();
				if (!XSD2CPP.ReadP2PCryptoTicketClass(doc, p2PCryptoTicket))
				{
					break;
				}
				data.Add(p2PCryptoTicket);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001EDC RID: 7900 RVA: 0x0004666C File Offset: 0x0004566C
		private static bool ReadLobbyEntrantInfo(XmlParser doc, LobbyEntrantInfo data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "GridIndex";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.GridIndex);
			}
			doc.Parent();
			pName = prefix + "Heat";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadFloat(doc, out data.Heat);
			}
			doc.Parent();
			pName = prefix + "Level";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Level);
			}
			doc.Parent();
			pName = prefix + "PersonaId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.PersonaId);
			}
			doc.Parent();
			pName = prefix + "State";
			if (doc.FirstChild(pName))
			{
				XSD2CPP.ReadLobbyEntrantState(doc, out data.State);
			}
			return true;
		}

		// Token: 0x06001EDD RID: 7901 RVA: 0x00046754 File Offset: 0x00045754
		private static bool ReadArrayOfLobbyEntrantInfo(XmlParser doc, List<LobbyEntrantInfo> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "LobbyEntrantInfo";
			}
			for (;;)
			{
				LobbyEntrantInfo lobbyEntrantInfo = new LobbyEntrantInfo();
				if (!XSD2CPP.ReadLobbyEntrantInfoClass(doc, lobbyEntrantInfo))
				{
					break;
				}
				data.Add(lobbyEntrantInfo);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001EDE RID: 7902 RVA: 0x000467A4 File Offset: 0x000457A4
		private static bool ReadSessionInfo(XmlParser doc, SessionInfo data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "Challenge";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.Challenge = new SecurityChallenge();
				XSD2CPP.ReadSecurityChallengeClass(doc, data.Challenge);
			}
			doc.Parent();
			pName = prefix + "EventId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.EventId);
			}
			doc.Parent();
			pName = prefix + "SessionId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.SessionId);
			}
			return true;
		}

		// Token: 0x06001EDF RID: 7903 RVA: 0x0004684C File Offset: 0x0004584C
		private static bool ReadLobbyLaunched(XmlParser doc, LobbyLaunched data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "CryptoTickets";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.CryptoTickets = new List<P2PCryptoTicket>();
				XSD2CPP.ReadArrayOfP2PCryptoTicketClass(doc, data.CryptoTickets);
			}
			doc.Parent();
			pName = prefix + "Entrants";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.Entrants = new List<LobbyEntrantInfo>();
				XSD2CPP.ReadArrayOfLobbyEntrantInfoClass(doc, data.Entrants);
			}
			doc.Parent();
			pName = prefix + "EventSession";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.EventSession = new SessionInfo();
				XSD2CPP.ReadSessionInfoClass(doc, data.EventSession);
			}
			doc.Parent();
			pName = prefix + "IsNewRelayServer";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.IsNewRelayServer);
			}
			doc.Parent();
			pName = prefix + "LobbyId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.LobbyId);
			}
			doc.Parent();
			pName = prefix + "UdpRelayHost";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.UdpRelayHost);
			}
			doc.Parent();
			pName = prefix + "UdpRelayPort";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.UdpRelayPort);
			}
			return true;
		}

		// Token: 0x06001EE0 RID: 7904 RVA: 0x000469C0 File Offset: 0x000459C0
		private static bool ReadEngineInnerExceptionTrans(XmlParser doc, EngineInnerExceptionTrans data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "Description";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Description);
			}
			doc.Parent();
			pName = prefix + "ErrorCode";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.ErrorCode);
			}
			doc.Parent();
			pName = prefix + "Message";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Message);
			}
			doc.Parent();
			pName = prefix + "StackTrace";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.StackTrace);
			}
			return true;
		}

		// Token: 0x06001EE1 RID: 7905 RVA: 0x00046A80 File Offset: 0x00045A80
		private static bool ReadEngineExceptionTrans(XmlParser doc, EngineExceptionTrans data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "Description";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Description);
			}
			doc.Parent();
			pName = prefix + "ErrorCode";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.ErrorCode);
			}
			doc.Parent();
			pName = prefix + "InnerException";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.InnerException = new EngineInnerExceptionTrans();
				XSD2CPP.ReadEngineInnerExceptionTransClass(doc, data.InnerException);
			}
			doc.Parent();
			pName = prefix + "Message";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Message);
			}
			doc.Parent();
			pName = prefix + "StackTrace";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.StackTrace);
			}
			return true;
		}

		// Token: 0x06001EE2 RID: 7906 RVA: 0x00046B79 File Offset: 0x00045B79
		private static bool ReadLobbyCancelled(XmlParser doc, LobbyCancelled data, string prefix)
		{
			return !(doc == null);
		}

		// Token: 0x06001EE3 RID: 7907 RVA: 0x00046B88 File Offset: 0x00045B88
		private static bool ReadLobbyInvite(XmlParser doc, LobbyInvite data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "EventId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.EventId);
			}
			doc.Parent();
			pName = prefix + "InviteLifetimeInMilliseconds";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.InviteLifetimeInMilliseconds);
			}
			doc.Parent();
			pName = prefix + "InvitedByPersonaId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.InvitedByPersonaId);
			}
			doc.Parent();
			pName = prefix + "IsPrivate";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.IsPrivate);
			}
			doc.Parent();
			pName = prefix + "LobbyInviteId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.LobbyInviteId);
			}
			return true;
		}

		// Token: 0x06001EE4 RID: 7908 RVA: 0x00046C70 File Offset: 0x00045C70
		private static bool ReadLobbyCountdown(XmlParser doc, LobbyCountdown data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "EventId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.EventId);
			}
			doc.Parent();
			pName = prefix + "IsWaiting";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.IsWaiting);
			}
			doc.Parent();
			pName = prefix + "LobbyCountdownInMilliseconds";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.LobbyCountdownInMilliseconds);
			}
			doc.Parent();
			pName = prefix + "LobbyId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.LobbyId);
			}
			doc.Parent();
			pName = prefix + "LobbyStuckDurationInMilliseconds";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.LobbyStuckDurationInMilliseconds);
			}
			return true;
		}

		// Token: 0x06001EE5 RID: 7909 RVA: 0x00046D58 File Offset: 0x00045D58
		private static bool ReadLobbyEntrantAdded(XmlParser doc, LobbyEntrantAdded data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			XSD2CPP.ReadLobbyEntrantInfo(doc, data, prefix);
			doc.Parent();
			string pName = prefix + "LobbyId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.LobbyId);
			}
			return true;
		}

		// Token: 0x06001EE6 RID: 7910 RVA: 0x00046DA4 File Offset: 0x00045DA4
		private static bool ReadLobbyEntrantUpdated(XmlParser doc, LobbyEntrantUpdated data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "PersonaId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.PersonaId);
			}
			doc.Parent();
			pName = prefix + "State";
			if (doc.FirstChild(pName))
			{
				XSD2CPP.ReadLobbyEntrantState(doc, out data.State);
			}
			return true;
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x00046E10 File Offset: 0x00045E10
		private static bool ReadLobbyInfo(XmlParser doc, LobbyInfo data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "Countdown";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.Countdown = new LobbyCountdown();
				XSD2CPP.ReadLobbyCountdownClass(doc, data.Countdown);
			}
			doc.Parent();
			pName = prefix + "Entrants";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.Entrants = new List<LobbyEntrantInfo>();
				XSD2CPP.ReadArrayOfLobbyEntrantInfoClass(doc, data.Entrants);
			}
			doc.Parent();
			pName = prefix + "EventId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.EventId);
			}
			doc.Parent();
			pName = prefix + "IsInviteEnabled";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.IsInviteEnabled);
			}
			doc.Parent();
			pName = prefix + "LobbyId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.LobbyId);
			}
			doc.Parent();
			pName = prefix + "LobbyInviteId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.LobbyInviteId);
			}
			return true;
		}

		// Token: 0x06001EE8 RID: 7912 RVA: 0x00046F48 File Offset: 0x00045F48
		private static bool ReadSystemInfo(XmlParser doc, SystemInfo data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "Branch";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Branch);
			}
			doc.Parent();
			pName = prefix + "ChangeList";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.ChangeList);
			}
			doc.Parent();
			pName = prefix + "ClientVersion";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.ClientVersion);
			}
			doc.Parent();
			pName = prefix + "ClientVersionCheck";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.ClientVersionCheck);
			}
			doc.Parent();
			pName = prefix + "Deployed";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Deployed);
			}
			doc.Parent();
			pName = prefix + "EntitlementsToDownload";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.EntitlementsToDownload);
			}
			doc.Parent();
			pName = prefix + "ForcePermanentSession";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.ForcePermanentSession);
			}
			doc.Parent();
			pName = prefix + "JidPrepender";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.JidPrepender);
			}
			doc.Parent();
			pName = prefix + "LauncherServiceUrl";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.LauncherServiceUrl);
			}
			doc.Parent();
			pName = prefix + "NucleusNamespace";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.NucleusNamespace);
			}
			doc.Parent();
			pName = prefix + "NucleusNamespaceWeb";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.NucleusNamespaceWeb);
			}
			doc.Parent();
			pName = prefix + "PersonaCacheTimeout";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.PersonaCacheTimeout);
			}
			doc.Parent();
			pName = prefix + "PortalDomain";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.PortalDomain);
			}
			doc.Parent();
			pName = prefix + "PortalSecureDomain";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.PortalSecureDomain);
			}
			doc.Parent();
			pName = prefix + "PortalStoreFailurePage";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.PortalStoreFailurePage);
			}
			doc.Parent();
			pName = prefix + "PortalTimeOut";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.PortalTimeOut);
			}
			doc.Parent();
			pName = prefix + "ShardName";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.ShardName);
			}
			doc.Parent();
			pName = prefix + "Time";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadDateTime(doc, out data.Time);
			}
			doc.Parent();
			pName = prefix + "Version";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Version);
			}
			return true;
		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x0004726C File Offset: 0x0004626C
		private static bool ReadCdn(XmlParser doc, Cdn data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "game";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.game);
			}
			doc.Parent();
			pName = prefix + "launcher";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.launcher);
			}
			return true;
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x000472D8 File Offset: 0x000462D8
		private static bool Readregion(XmlParser doc, region data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "name";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.name);
			}
			return true;
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x0004731C File Offset: 0x0004631C
		private static bool ReadArrayOfregion(XmlParser doc, List<region> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "region";
			}
			for (;;)
			{
				region region = new region();
				if (!XSD2CPP.ReadregionClass(doc, region))
				{
					break;
				}
				data.Add(region);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x0004736C File Offset: 0x0004636C
		private static bool ReadTermsOfService(XmlParser doc, TermsOfService data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "en";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.en);
			}
			doc.Parent();
			pName = prefix + "de";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.de);
			}
			doc.Parent();
			pName = prefix + "es";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.es);
			}
			doc.Parent();
			pName = prefix + "fr";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.fr);
			}
			doc.Parent();
			pName = prefix + "pl";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.pl);
			}
			doc.Parent();
			pName = prefix + "pt";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.pt);
			}
			doc.Parent();
			pName = prefix + "ru";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.ru);
			}
			doc.Parent();
			pName = prefix + "th";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.th);
			}
			doc.Parent();
			pName = prefix + "tr";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.tr);
			}
			doc.Parent();
			pName = prefix + "zh";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.zh);
			}
			doc.Parent();
			pName = prefix + "zh_chs";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.zh_chs);
			}
			return true;
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x00047548 File Offset: 0x00046548
		private static bool Readconfiguration(XmlParser doc, configuration data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "gameserver";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.gameserver);
			}
			doc.Parent();
			pName = prefix + "webserver";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.webserver);
			}
			doc.Parent();
			pName = prefix + "regions";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.regions = new List<region>();
				XSD2CPP.ReadArrayOfregionClass(doc, data.regions);
			}
			doc.Parent();
			pName = prefix + "cdn";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.cdn = new Cdn();
				XSD2CPP.ReadCdnClass(doc, data.cdn);
			}
			doc.Parent();
			pName = prefix + "termsofservice";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.termsofservice = new TermsOfService();
				XSD2CPP.ReadTermsOfServiceClass(doc, data.termsofservice);
			}
			return true;
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x00047668 File Offset: 0x00046668
		private static bool ReadServerTime(XmlParser doc, ServerTime data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "Current";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadDateTime(doc, out data.Current);
			}
			return true;
		}

		// Token: 0x06001EEF RID: 7919 RVA: 0x000476AC File Offset: 0x000466AC
		public static bool Reader(XmlString xmlString, out LobbyEntrantRemoved data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "LobbyEntrantRemoved"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new LobbyEntrantRemoved();
						if (XSD2CPP.ReadLobbyEntrantRemovedClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001EF0 RID: 7920 RVA: 0x00047708 File Offset: 0x00046708
		public static bool ReadLobbyEntrantRemoved(XmlString xmlString, out LobbyEntrantRemoved data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001EF1 RID: 7921 RVA: 0x00047714 File Offset: 0x00046714
		public static bool Reader(XmlString xmlString, out SecurityChallenge data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "SecurityChallenge"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new SecurityChallenge();
						if (XSD2CPP.ReadSecurityChallengeClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001EF2 RID: 7922 RVA: 0x00047770 File Offset: 0x00046770
		public static bool ReadSecurityChallenge(XmlString xmlString, out SecurityChallenge data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001EF3 RID: 7923 RVA: 0x0004777C File Offset: 0x0004677C
		public static bool Reader(XmlString xmlString, out P2PCryptoTicket data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "P2PCryptoTicket"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new P2PCryptoTicket();
						if (XSD2CPP.ReadP2PCryptoTicketClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001EF4 RID: 7924 RVA: 0x000477D8 File Offset: 0x000467D8
		public static bool ReadP2PCryptoTicket(XmlString xmlString, out P2PCryptoTicket data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001EF5 RID: 7925 RVA: 0x000477E4 File Offset: 0x000467E4
		public static bool Reader(XmlString xmlString, out List<P2PCryptoTicket> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfP2PCryptoTicket"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<P2PCryptoTicket>();
						if (XSD2CPP.ReadArrayOfP2PCryptoTicketClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001EF6 RID: 7926 RVA: 0x00047840 File Offset: 0x00046840
		public static bool ReadArrayOfP2PCryptoTicket(XmlString xmlString, out List<P2PCryptoTicket> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001EF7 RID: 7927 RVA: 0x0004784C File Offset: 0x0004684C
		public static bool Reader(XmlString xmlString, out LobbyEntrantInfo data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "LobbyEntrantInfo"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new LobbyEntrantInfo();
						if (XSD2CPP.ReadLobbyEntrantInfoClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x000478A8 File Offset: 0x000468A8
		public static bool ReadLobbyEntrantInfo(XmlString xmlString, out LobbyEntrantInfo data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x000478B4 File Offset: 0x000468B4
		public static bool Reader(XmlString xmlString, out List<LobbyEntrantInfo> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfLobbyEntrantInfo"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<LobbyEntrantInfo>();
						if (XSD2CPP.ReadArrayOfLobbyEntrantInfoClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x00047910 File Offset: 0x00046910
		public static bool ReadArrayOfLobbyEntrantInfo(XmlString xmlString, out List<LobbyEntrantInfo> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x0004791C File Offset: 0x0004691C
		public static bool Reader(XmlString xmlString, out SessionInfo data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "SessionInfo"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new SessionInfo();
						if (XSD2CPP.ReadSessionInfoClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x00047978 File Offset: 0x00046978
		public static bool ReadSessionInfo(XmlString xmlString, out SessionInfo data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x00047984 File Offset: 0x00046984
		public static bool Reader(XmlString xmlString, out LobbyLaunched data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "LobbyLaunched"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new LobbyLaunched();
						if (XSD2CPP.ReadLobbyLaunchedClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001EFE RID: 7934 RVA: 0x000479E0 File Offset: 0x000469E0
		public static bool ReadLobbyLaunched(XmlString xmlString, out LobbyLaunched data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001EFF RID: 7935 RVA: 0x000479EC File Offset: 0x000469EC
		public static bool Reader(XmlString xmlString, out EngineInnerExceptionTrans data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "EngineInnerExceptionTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new EngineInnerExceptionTrans();
						if (XSD2CPP.ReadEngineInnerExceptionTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001F00 RID: 7936 RVA: 0x00047A48 File Offset: 0x00046A48
		public static bool ReadEngineInnerExceptionTrans(XmlString xmlString, out EngineInnerExceptionTrans data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001F01 RID: 7937 RVA: 0x00047A54 File Offset: 0x00046A54
		public static bool Reader(XmlString xmlString, out EngineExceptionTrans data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "EngineExceptionTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new EngineExceptionTrans();
						if (XSD2CPP.ReadEngineExceptionTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001F02 RID: 7938 RVA: 0x00047AB0 File Offset: 0x00046AB0
		public static bool ReadEngineExceptionTrans(XmlString xmlString, out EngineExceptionTrans data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001F03 RID: 7939 RVA: 0x00047ABC File Offset: 0x00046ABC
		public static bool Reader(XmlString xmlString, out LobbyCancelled data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "LobbyCancelled"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new LobbyCancelled();
						if (XSD2CPP.ReadLobbyCancelledClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001F04 RID: 7940 RVA: 0x00047B18 File Offset: 0x00046B18
		public static bool ReadLobbyCancelled(XmlString xmlString, out LobbyCancelled data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001F05 RID: 7941 RVA: 0x00047B24 File Offset: 0x00046B24
		public static bool Reader(XmlString xmlString, out LobbyInvite data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "LobbyInvite"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new LobbyInvite();
						if (XSD2CPP.ReadLobbyInviteClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001F06 RID: 7942 RVA: 0x00047B80 File Offset: 0x00046B80
		public static bool ReadLobbyInvite(XmlString xmlString, out LobbyInvite data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001F07 RID: 7943 RVA: 0x00047B8C File Offset: 0x00046B8C
		public static bool Reader(XmlString xmlString, out LobbyCountdown data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "LobbyCountdown"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new LobbyCountdown();
						if (XSD2CPP.ReadLobbyCountdownClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001F08 RID: 7944 RVA: 0x00047BE8 File Offset: 0x00046BE8
		public static bool ReadLobbyCountdown(XmlString xmlString, out LobbyCountdown data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001F09 RID: 7945 RVA: 0x00047BF4 File Offset: 0x00046BF4
		public static bool Reader(XmlString xmlString, out LobbyEntrantAdded data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "LobbyEntrantAdded"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new LobbyEntrantAdded();
						if (XSD2CPP.ReadLobbyEntrantAddedClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001F0A RID: 7946 RVA: 0x00047C50 File Offset: 0x00046C50
		public static bool ReadLobbyEntrantAdded(XmlString xmlString, out LobbyEntrantAdded data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001F0B RID: 7947 RVA: 0x00047C5C File Offset: 0x00046C5C
		public static bool Reader(XmlString xmlString, out LobbyEntrantUpdated data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "LobbyEntrantUpdated"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new LobbyEntrantUpdated();
						if (XSD2CPP.ReadLobbyEntrantUpdatedClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001F0C RID: 7948 RVA: 0x00047CB8 File Offset: 0x00046CB8
		public static bool ReadLobbyEntrantUpdated(XmlString xmlString, out LobbyEntrantUpdated data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001F0D RID: 7949 RVA: 0x00047CC4 File Offset: 0x00046CC4
		public static bool Reader(XmlString xmlString, out LobbyInfo data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "LobbyInfo"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new LobbyInfo();
						if (XSD2CPP.ReadLobbyInfoClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001F0E RID: 7950 RVA: 0x00047D20 File Offset: 0x00046D20
		public static bool ReadLobbyInfo(XmlString xmlString, out LobbyInfo data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001F0F RID: 7951 RVA: 0x00047D2C File Offset: 0x00046D2C
		public static bool Reader(XmlString xmlString, out SystemInfo data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "SystemInfo"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new SystemInfo();
						if (XSD2CPP.ReadSystemInfoClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001F10 RID: 7952 RVA: 0x00047D88 File Offset: 0x00046D88
		public static bool ReadSystemInfo(XmlString xmlString, out SystemInfo data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001F11 RID: 7953 RVA: 0x00047D94 File Offset: 0x00046D94
		public static bool Reader(XmlString xmlString, out Cdn data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "Cdn"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new Cdn();
						if (XSD2CPP.ReadCdnClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001F12 RID: 7954 RVA: 0x00047DF0 File Offset: 0x00046DF0
		public static bool ReadCdn(XmlString xmlString, out Cdn data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001F13 RID: 7955 RVA: 0x00047DFC File Offset: 0x00046DFC
		public static bool Reader(XmlString xmlString, out region data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "region"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new region();
						if (XSD2CPP.ReadregionClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x00047E58 File Offset: 0x00046E58
		public static bool Readregion(XmlString xmlString, out region data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001F15 RID: 7957 RVA: 0x00047E64 File Offset: 0x00046E64
		public static bool Reader(XmlString xmlString, out List<region> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfregion"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<region>();
						if (XSD2CPP.ReadArrayOfregionClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001F16 RID: 7958 RVA: 0x00047EC0 File Offset: 0x00046EC0
		public static bool ReadArrayOfregion(XmlString xmlString, out List<region> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001F17 RID: 7959 RVA: 0x00047ECC File Offset: 0x00046ECC
		public static bool Reader(XmlString xmlString, out TermsOfService data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "TermsOfService"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new TermsOfService();
						if (XSD2CPP.ReadTermsOfServiceClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001F18 RID: 7960 RVA: 0x00047F28 File Offset: 0x00046F28
		public static bool ReadTermsOfService(XmlString xmlString, out TermsOfService data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001F19 RID: 7961 RVA: 0x00047F34 File Offset: 0x00046F34
		public static bool Reader(XmlString xmlString, out configuration data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "configuration"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new configuration();
						if (XSD2CPP.ReadconfigurationClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001F1A RID: 7962 RVA: 0x00047F90 File Offset: 0x00046F90
		public static bool Readconfiguration(XmlString xmlString, out configuration data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001F1B RID: 7963 RVA: 0x00047F9C File Offset: 0x00046F9C
		public static bool Reader(XmlString xmlString, out ServerTime data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ServerTime"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new ServerTime();
						if (XSD2CPP.ReadServerTimeClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001F1C RID: 7964 RVA: 0x00047FF8 File Offset: 0x00046FF8
		public static bool ReadServerTime(XmlString xmlString, out ServerTime data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001F1D RID: 7965 RVA: 0x00048001 File Offset: 0x00047001
		private static void WriteLobbyEntrantState(XmlParser doc, LobbyEntrantState data)
		{
			Xsd2CppUtil.WriteString(doc, data.ToString());
		}

		// Token: 0x06001F1E RID: 7966 RVA: 0x00048018 File Offset: 0x00047018
		private static void WriteLobbyEntrantRemoved(XmlParser doc, LobbyEntrantRemoved data)
		{
			doc.AddChild("LobbyId");
			Xsd2CppUtil.WriteLong(doc, data.LobbyId);
			doc.Parent();
			doc.AddChild("PersonaId");
			Xsd2CppUtil.WriteLong(doc, data.PersonaId);
			doc.Parent();
		}

		// Token: 0x06001F1F RID: 7967 RVA: 0x00048068 File Offset: 0x00047068
		private static void WriteSecurityChallenge(XmlParser doc, SecurityChallenge data)
		{
			doc.AddChild("ChallengeId");
			Xsd2CppUtil.WriteString(doc, data.ChallengeId);
			doc.Parent();
			doc.AddChild("LeftSize");
			Xsd2CppUtil.WriteInt(doc, data.LeftSize);
			doc.Parent();
			doc.AddChild("Pattern");
			Xsd2CppUtil.WriteString(doc, data.Pattern);
			doc.Parent();
			doc.AddChild("RightSize");
			Xsd2CppUtil.WriteInt(doc, data.RightSize);
			doc.Parent();
		}

		// Token: 0x06001F20 RID: 7968 RVA: 0x000480F8 File Offset: 0x000470F8
		private static void WriteP2PCryptoTicket(XmlParser doc, P2PCryptoTicket data)
		{
			doc.AddChild("PersonaId");
			Xsd2CppUtil.WriteLong(doc, data.PersonaId);
			doc.Parent();
			doc.AddChild("SessionKey");
			Xsd2CppUtil.WriteString(doc, data.SessionKey);
			doc.Parent();
		}

		// Token: 0x06001F21 RID: 7969 RVA: 0x00048148 File Offset: 0x00047148
		private static void WriteArrayOfP2PCryptoTicket(XmlParser doc, List<P2PCryptoTicket> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("P2PCryptoTicket");
				XSD2CPP.WriteP2PCryptoTicket(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001F22 RID: 7970 RVA: 0x00048188 File Offset: 0x00047188
		private static void WriteLobbyEntrantInfo(XmlParser doc, LobbyEntrantInfo data)
		{
			doc.AddChild("GridIndex");
			Xsd2CppUtil.WriteInt(doc, data.GridIndex);
			doc.Parent();
			doc.AddChild("Heat");
			Xsd2CppUtil.WriteFloat(doc, data.Heat);
			doc.Parent();
			doc.AddChild("Level");
			Xsd2CppUtil.WriteInt(doc, data.Level);
			doc.Parent();
			doc.AddChild("PersonaId");
			Xsd2CppUtil.WriteLong(doc, data.PersonaId);
			doc.Parent();
			doc.AddChild("State");
			XSD2CPP.WriteLobbyEntrantState(doc, data.State);
			doc.Parent();
		}

		// Token: 0x06001F23 RID: 7971 RVA: 0x00048234 File Offset: 0x00047234
		private static void WriteArrayOfLobbyEntrantInfo(XmlParser doc, List<LobbyEntrantInfo> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("LobbyEntrantInfo");
				XSD2CPP.WriteLobbyEntrantInfo(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001F24 RID: 7972 RVA: 0x00048274 File Offset: 0x00047274
		private static void WriteSessionInfo(XmlParser doc, SessionInfo data)
		{
			doc.AddChild("Challenge");
			XSD2CPP.WriteSecurityChallenge(doc, data.Challenge);
			doc.Parent();
			doc.AddChild("EventId");
			Xsd2CppUtil.WriteInt(doc, data.EventId);
			doc.Parent();
			doc.AddChild("SessionId");
			Xsd2CppUtil.WriteLong(doc, data.SessionId);
			doc.Parent();
		}

		// Token: 0x06001F25 RID: 7973 RVA: 0x000482E0 File Offset: 0x000472E0
		private static void WriteLobbyLaunched(XmlParser doc, LobbyLaunched data)
		{
			doc.AddChild("CryptoTickets");
			XSD2CPP.WriteArrayOfP2PCryptoTicket(doc, data.CryptoTickets);
			doc.Parent();
			doc.AddChild("Entrants");
			XSD2CPP.WriteArrayOfLobbyEntrantInfo(doc, data.Entrants);
			doc.Parent();
			doc.AddChild("EventSession");
			XSD2CPP.WriteSessionInfo(doc, data.EventSession);
			doc.Parent();
			doc.AddChild("IsNewRelayServer");
			Xsd2CppUtil.WriteBoolean(doc, data.IsNewRelayServer);
			doc.Parent();
			doc.AddChild("LobbyId");
			Xsd2CppUtil.WriteLong(doc, data.LobbyId);
			doc.Parent();
			doc.AddChild("UdpRelayHost");
			Xsd2CppUtil.WriteString(doc, data.UdpRelayHost);
			doc.Parent();
			doc.AddChild("UdpRelayPort");
			Xsd2CppUtil.WriteInt(doc, data.UdpRelayPort);
			doc.Parent();
		}

		// Token: 0x06001F26 RID: 7974 RVA: 0x000483CC File Offset: 0x000473CC
		private static void WriteEngineInnerExceptionTrans(XmlParser doc, EngineInnerExceptionTrans data)
		{
			doc.AddChild("Description");
			Xsd2CppUtil.WriteString(doc, data.Description);
			doc.Parent();
			doc.AddChild("ErrorCode");
			Xsd2CppUtil.WriteInt(doc, data.ErrorCode);
			doc.Parent();
			doc.AddChild("Message");
			Xsd2CppUtil.WriteString(doc, data.Message);
			doc.Parent();
			doc.AddChild("StackTrace");
			Xsd2CppUtil.WriteString(doc, data.StackTrace);
			doc.Parent();
		}

		// Token: 0x06001F27 RID: 7975 RVA: 0x0004845C File Offset: 0x0004745C
		private static void WriteEngineExceptionTrans(XmlParser doc, EngineExceptionTrans data)
		{
			doc.AddChild("Description");
			Xsd2CppUtil.WriteString(doc, data.Description);
			doc.Parent();
			doc.AddChild("ErrorCode");
			Xsd2CppUtil.WriteInt(doc, data.ErrorCode);
			doc.Parent();
			doc.AddChild("InnerException");
			XSD2CPP.WriteEngineInnerExceptionTrans(doc, data.InnerException);
			doc.Parent();
			doc.AddChild("Message");
			Xsd2CppUtil.WriteString(doc, data.Message);
			doc.Parent();
			doc.AddChild("StackTrace");
			Xsd2CppUtil.WriteString(doc, data.StackTrace);
			doc.Parent();
		}

		// Token: 0x06001F28 RID: 7976 RVA: 0x00048508 File Offset: 0x00047508
		private static void WriteLobbyCancelled(XmlParser doc, LobbyCancelled data)
		{
		}

		// Token: 0x06001F29 RID: 7977 RVA: 0x0004850C File Offset: 0x0004750C
		private static void WriteLobbyInvite(XmlParser doc, LobbyInvite data)
		{
			doc.AddChild("EventId");
			Xsd2CppUtil.WriteInt(doc, data.EventId);
			doc.Parent();
			doc.AddChild("InviteLifetimeInMilliseconds");
			Xsd2CppUtil.WriteInt(doc, data.InviteLifetimeInMilliseconds);
			doc.Parent();
			doc.AddChild("InvitedByPersonaId");
			Xsd2CppUtil.WriteLong(doc, data.InvitedByPersonaId);
			doc.Parent();
			doc.AddChild("IsPrivate");
			Xsd2CppUtil.WriteBoolean(doc, data.IsPrivate);
			doc.Parent();
			doc.AddChild("LobbyInviteId");
			Xsd2CppUtil.WriteLong(doc, data.LobbyInviteId);
			doc.Parent();
		}

		// Token: 0x06001F2A RID: 7978 RVA: 0x000485BC File Offset: 0x000475BC
		private static void WriteLobbyCountdown(XmlParser doc, LobbyCountdown data)
		{
			doc.AddChild("EventId");
			Xsd2CppUtil.WriteInt(doc, data.EventId);
			doc.Parent();
			doc.AddChild("IsWaiting");
			Xsd2CppUtil.WriteBoolean(doc, data.IsWaiting);
			doc.Parent();
			doc.AddChild("LobbyCountdownInMilliseconds");
			Xsd2CppUtil.WriteInt(doc, data.LobbyCountdownInMilliseconds);
			doc.Parent();
			doc.AddChild("LobbyId");
			Xsd2CppUtil.WriteLong(doc, data.LobbyId);
			doc.Parent();
			doc.AddChild("LobbyStuckDurationInMilliseconds");
			Xsd2CppUtil.WriteInt(doc, data.LobbyStuckDurationInMilliseconds);
			doc.Parent();
		}

		// Token: 0x06001F2B RID: 7979 RVA: 0x00048669 File Offset: 0x00047669
		private static void WriteLobbyEntrantAdded(XmlParser doc, LobbyEntrantAdded data)
		{
			XSD2CPP.WriteLobbyEntrantInfo(doc, data);
			doc.AddChild("LobbyId");
			Xsd2CppUtil.WriteLong(doc, data.LobbyId);
			doc.Parent();
		}

		// Token: 0x06001F2C RID: 7980 RVA: 0x00048694 File Offset: 0x00047694
		private static void WriteLobbyEntrantUpdated(XmlParser doc, LobbyEntrantUpdated data)
		{
			doc.AddChild("PersonaId");
			Xsd2CppUtil.WriteLong(doc, data.PersonaId);
			doc.Parent();
			doc.AddChild("State");
			XSD2CPP.WriteLobbyEntrantState(doc, data.State);
			doc.Parent();
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x000486E0 File Offset: 0x000476E0
		private static void WriteLobbyInfo(XmlParser doc, LobbyInfo data)
		{
			doc.AddChild("Countdown");
			XSD2CPP.WriteLobbyCountdown(doc, data.Countdown);
			doc.Parent();
			doc.AddChild("Entrants");
			XSD2CPP.WriteArrayOfLobbyEntrantInfo(doc, data.Entrants);
			doc.Parent();
			doc.AddChild("EventId");
			Xsd2CppUtil.WriteInt(doc, data.EventId);
			doc.Parent();
			doc.AddChild("IsInviteEnabled");
			Xsd2CppUtil.WriteBoolean(doc, data.IsInviteEnabled);
			doc.Parent();
			doc.AddChild("LobbyId");
			Xsd2CppUtil.WriteLong(doc, data.LobbyId);
			doc.Parent();
			doc.AddChild("LobbyInviteId");
			Xsd2CppUtil.WriteLong(doc, data.LobbyInviteId);
			doc.Parent();
		}

		// Token: 0x06001F2E RID: 7982 RVA: 0x000487AC File Offset: 0x000477AC
		private static void WriteSystemInfo(XmlParser doc, SystemInfo data)
		{
			doc.AddChild("Branch");
			Xsd2CppUtil.WriteString(doc, data.Branch);
			doc.Parent();
			doc.AddChild("ChangeList");
			Xsd2CppUtil.WriteString(doc, data.ChangeList);
			doc.Parent();
			doc.AddChild("ClientVersion");
			Xsd2CppUtil.WriteString(doc, data.ClientVersion);
			doc.Parent();
			doc.AddChild("ClientVersionCheck");
			Xsd2CppUtil.WriteBoolean(doc, data.ClientVersionCheck);
			doc.Parent();
			doc.AddChild("Deployed");
			Xsd2CppUtil.WriteString(doc, data.Deployed);
			doc.Parent();
			doc.AddChild("EntitlementsToDownload");
			Xsd2CppUtil.WriteBoolean(doc, data.EntitlementsToDownload);
			doc.Parent();
			doc.AddChild("ForcePermanentSession");
			Xsd2CppUtil.WriteBoolean(doc, data.ForcePermanentSession);
			doc.Parent();
			doc.AddChild("JidPrepender");
			Xsd2CppUtil.WriteString(doc, data.JidPrepender);
			doc.Parent();
			doc.AddChild("LauncherServiceUrl");
			Xsd2CppUtil.WriteString(doc, data.LauncherServiceUrl);
			doc.Parent();
			doc.AddChild("NucleusNamespace");
			Xsd2CppUtil.WriteString(doc, data.NucleusNamespace);
			doc.Parent();
			doc.AddChild("NucleusNamespaceWeb");
			Xsd2CppUtil.WriteString(doc, data.NucleusNamespaceWeb);
			doc.Parent();
			doc.AddChild("PersonaCacheTimeout");
			Xsd2CppUtil.WriteInt(doc, data.PersonaCacheTimeout);
			doc.Parent();
			doc.AddChild("PortalDomain");
			Xsd2CppUtil.WriteString(doc, data.PortalDomain);
			doc.Parent();
			doc.AddChild("PortalSecureDomain");
			Xsd2CppUtil.WriteString(doc, data.PortalSecureDomain);
			doc.Parent();
			doc.AddChild("PortalStoreFailurePage");
			Xsd2CppUtil.WriteString(doc, data.PortalStoreFailurePage);
			doc.Parent();
			doc.AddChild("PortalTimeOut");
			Xsd2CppUtil.WriteString(doc, data.PortalTimeOut);
			doc.Parent();
			doc.AddChild("ShardName");
			Xsd2CppUtil.WriteString(doc, data.ShardName);
			doc.Parent();
			doc.AddChild("Time");
			Xsd2CppUtil.WriteDateTime(doc, data.Time);
			doc.Parent();
			doc.AddChild("Version");
			Xsd2CppUtil.WriteString(doc, data.Version);
			doc.Parent();
		}

		// Token: 0x06001F2F RID: 7983 RVA: 0x00048A1C File Offset: 0x00047A1C
		private static void WriteCdn(XmlParser doc, Cdn data)
		{
			doc.AddChild("game");
			Xsd2CppUtil.WriteString(doc, data.game);
			doc.Parent();
			doc.AddChild("launcher");
			Xsd2CppUtil.WriteString(doc, data.launcher);
			doc.Parent();
		}

		// Token: 0x06001F30 RID: 7984 RVA: 0x00048A69 File Offset: 0x00047A69
		private static void Writeregion(XmlParser doc, region data)
		{
			doc.AddChild("name");
			Xsd2CppUtil.WriteString(doc, data.name);
			doc.Parent();
		}

		// Token: 0x06001F31 RID: 7985 RVA: 0x00048A8C File Offset: 0x00047A8C
		private static void WriteArrayOfregion(XmlParser doc, List<region> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("region");
				XSD2CPP.Writeregion(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001F32 RID: 7986 RVA: 0x00048ACC File Offset: 0x00047ACC
		private static void WriteTermsOfService(XmlParser doc, TermsOfService data)
		{
			doc.AddChild("en");
			Xsd2CppUtil.WriteString(doc, data.en);
			doc.Parent();
			doc.AddChild("de");
			Xsd2CppUtil.WriteString(doc, data.de);
			doc.Parent();
			doc.AddChild("es");
			Xsd2CppUtil.WriteString(doc, data.es);
			doc.Parent();
			doc.AddChild("fr");
			Xsd2CppUtil.WriteString(doc, data.fr);
			doc.Parent();
			doc.AddChild("pl");
			Xsd2CppUtil.WriteString(doc, data.pl);
			doc.Parent();
			doc.AddChild("pt");
			Xsd2CppUtil.WriteString(doc, data.pt);
			doc.Parent();
			doc.AddChild("ru");
			Xsd2CppUtil.WriteString(doc, data.ru);
			doc.Parent();
			doc.AddChild("th");
			Xsd2CppUtil.WriteString(doc, data.th);
			doc.Parent();
			doc.AddChild("tr");
			Xsd2CppUtil.WriteString(doc, data.tr);
			doc.Parent();
			doc.AddChild("zh");
			Xsd2CppUtil.WriteString(doc, data.zh);
			doc.Parent();
			doc.AddChild("zh_chs");
			Xsd2CppUtil.WriteString(doc, data.zh_chs);
			doc.Parent();
		}

		// Token: 0x06001F33 RID: 7987 RVA: 0x00048C3C File Offset: 0x00047C3C
		private static void Writeconfiguration(XmlParser doc, configuration data)
		{
			doc.AddChild("gameserver");
			Xsd2CppUtil.WriteString(doc, data.gameserver);
			doc.Parent();
			doc.AddChild("webserver");
			Xsd2CppUtil.WriteString(doc, data.webserver);
			doc.Parent();
			doc.AddChild("regions");
			XSD2CPP.WriteArrayOfregion(doc, data.regions);
			doc.Parent();
			doc.AddChild("cdn");
			XSD2CPP.WriteCdn(doc, data.cdn);
			doc.Parent();
			doc.AddChild("termsofservice");
			XSD2CPP.WriteTermsOfService(doc, data.termsofservice);
			doc.Parent();
		}

		// Token: 0x06001F34 RID: 7988 RVA: 0x00048CE6 File Offset: 0x00047CE6
		private static void WriteServerTime(XmlParser doc, ServerTime data)
		{
			doc.AddChild("Current");
			Xsd2CppUtil.WriteDateTime(doc, data.Current);
			doc.Parent();
		}

		// Token: 0x06001F35 RID: 7989 RVA: 0x00048D08 File Offset: 0x00047D08
		public static bool WriterXML(LobbyEntrantRemoved data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("LobbyEntrantRemoved");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteLobbyEntrantRemoved(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001F36 RID: 7990 RVA: 0x00048D59 File Offset: 0x00047D59
		public static bool Writer(LobbyEntrantRemoved data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001F37 RID: 7991 RVA: 0x00048D62 File Offset: 0x00047D62
		public static bool WriteLobbyEntrantRemoved(LobbyEntrantRemoved data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001F38 RID: 7992 RVA: 0x00048D6C File Offset: 0x00047D6C
		public static bool WriterXML(SecurityChallenge data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("SecurityChallenge");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteSecurityChallenge(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001F39 RID: 7993 RVA: 0x00048DBD File Offset: 0x00047DBD
		public static bool Writer(SecurityChallenge data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001F3A RID: 7994 RVA: 0x00048DC6 File Offset: 0x00047DC6
		public static bool WriteSecurityChallenge(SecurityChallenge data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001F3B RID: 7995 RVA: 0x00048DD0 File Offset: 0x00047DD0
		public static bool WriterXML(P2PCryptoTicket data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("P2PCryptoTicket");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteP2PCryptoTicket(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001F3C RID: 7996 RVA: 0x00048E21 File Offset: 0x00047E21
		public static bool Writer(P2PCryptoTicket data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001F3D RID: 7997 RVA: 0x00048E2A File Offset: 0x00047E2A
		public static bool WriteP2PCryptoTicket(P2PCryptoTicket data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001F3E RID: 7998 RVA: 0x00048E34 File Offset: 0x00047E34
		public static bool WriterXML(List<P2PCryptoTicket> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfP2PCryptoTicket");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfP2PCryptoTicket(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001F3F RID: 7999 RVA: 0x00048E85 File Offset: 0x00047E85
		public static bool Writer(List<P2PCryptoTicket> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001F40 RID: 8000 RVA: 0x00048E8E File Offset: 0x00047E8E
		public static bool WriteArrayOfP2PCryptoTicket(List<P2PCryptoTicket> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001F41 RID: 8001 RVA: 0x00048E98 File Offset: 0x00047E98
		public static bool WriterXML(LobbyEntrantInfo data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("LobbyEntrantInfo");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteLobbyEntrantInfo(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001F42 RID: 8002 RVA: 0x00048EE9 File Offset: 0x00047EE9
		public static bool Writer(LobbyEntrantInfo data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001F43 RID: 8003 RVA: 0x00048EF2 File Offset: 0x00047EF2
		public static bool WriteLobbyEntrantInfo(LobbyEntrantInfo data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001F44 RID: 8004 RVA: 0x00048EFC File Offset: 0x00047EFC
		public static bool WriterXML(List<LobbyEntrantInfo> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfLobbyEntrantInfo");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfLobbyEntrantInfo(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001F45 RID: 8005 RVA: 0x00048F4D File Offset: 0x00047F4D
		public static bool Writer(List<LobbyEntrantInfo> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001F46 RID: 8006 RVA: 0x00048F56 File Offset: 0x00047F56
		public static bool WriteArrayOfLobbyEntrantInfo(List<LobbyEntrantInfo> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001F47 RID: 8007 RVA: 0x00048F60 File Offset: 0x00047F60
		public static bool WriterXML(SessionInfo data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("SessionInfo");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteSessionInfo(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001F48 RID: 8008 RVA: 0x00048FB1 File Offset: 0x00047FB1
		public static bool Writer(SessionInfo data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001F49 RID: 8009 RVA: 0x00048FBA File Offset: 0x00047FBA
		public static bool WriteSessionInfo(SessionInfo data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001F4A RID: 8010 RVA: 0x00048FC4 File Offset: 0x00047FC4
		public static bool WriterXML(LobbyLaunched data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("LobbyLaunched");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteLobbyLaunched(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001F4B RID: 8011 RVA: 0x00049015 File Offset: 0x00048015
		public static bool Writer(LobbyLaunched data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001F4C RID: 8012 RVA: 0x0004901E File Offset: 0x0004801E
		public static bool WriteLobbyLaunched(LobbyLaunched data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001F4D RID: 8013 RVA: 0x00049028 File Offset: 0x00048028
		public static bool WriterXML(EngineInnerExceptionTrans data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("EngineInnerExceptionTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteEngineInnerExceptionTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001F4E RID: 8014 RVA: 0x00049079 File Offset: 0x00048079
		public static bool Writer(EngineInnerExceptionTrans data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001F4F RID: 8015 RVA: 0x00049082 File Offset: 0x00048082
		public static bool WriteEngineInnerExceptionTrans(EngineInnerExceptionTrans data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001F50 RID: 8016 RVA: 0x0004908C File Offset: 0x0004808C
		public static bool WriterXML(EngineExceptionTrans data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("EngineExceptionTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteEngineExceptionTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001F51 RID: 8017 RVA: 0x000490DD File Offset: 0x000480DD
		public static bool Writer(EngineExceptionTrans data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001F52 RID: 8018 RVA: 0x000490E6 File Offset: 0x000480E6
		public static bool WriteEngineExceptionTrans(EngineExceptionTrans data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001F53 RID: 8019 RVA: 0x000490F0 File Offset: 0x000480F0
		public static bool WriterXML(LobbyCancelled data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("LobbyCancelled");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteLobbyCancelled(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001F54 RID: 8020 RVA: 0x00049141 File Offset: 0x00048141
		public static bool Writer(LobbyCancelled data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001F55 RID: 8021 RVA: 0x0004914A File Offset: 0x0004814A
		public static bool WriteLobbyCancelled(LobbyCancelled data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001F56 RID: 8022 RVA: 0x00049154 File Offset: 0x00048154
		public static bool WriterXML(LobbyInvite data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("LobbyInvite");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteLobbyInvite(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001F57 RID: 8023 RVA: 0x000491A5 File Offset: 0x000481A5
		public static bool Writer(LobbyInvite data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001F58 RID: 8024 RVA: 0x000491AE File Offset: 0x000481AE
		public static bool WriteLobbyInvite(LobbyInvite data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001F59 RID: 8025 RVA: 0x000491B8 File Offset: 0x000481B8
		public static bool WriterXML(LobbyCountdown data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("LobbyCountdown");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteLobbyCountdown(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001F5A RID: 8026 RVA: 0x00049209 File Offset: 0x00048209
		public static bool Writer(LobbyCountdown data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001F5B RID: 8027 RVA: 0x00049212 File Offset: 0x00048212
		public static bool WriteLobbyCountdown(LobbyCountdown data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001F5C RID: 8028 RVA: 0x0004921C File Offset: 0x0004821C
		public static bool WriterXML(LobbyEntrantAdded data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("LobbyEntrantAdded");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteLobbyEntrantAdded(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001F5D RID: 8029 RVA: 0x0004926D File Offset: 0x0004826D
		public static bool Writer(LobbyEntrantAdded data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001F5E RID: 8030 RVA: 0x00049276 File Offset: 0x00048276
		public static bool WriteLobbyEntrantAdded(LobbyEntrantAdded data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001F5F RID: 8031 RVA: 0x00049280 File Offset: 0x00048280
		public static bool WriterXML(LobbyEntrantUpdated data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("LobbyEntrantUpdated");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteLobbyEntrantUpdated(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001F60 RID: 8032 RVA: 0x000492D1 File Offset: 0x000482D1
		public static bool Writer(LobbyEntrantUpdated data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001F61 RID: 8033 RVA: 0x000492DA File Offset: 0x000482DA
		public static bool WriteLobbyEntrantUpdated(LobbyEntrantUpdated data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001F62 RID: 8034 RVA: 0x000492E4 File Offset: 0x000482E4
		public static bool WriterXML(LobbyInfo data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("LobbyInfo");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteLobbyInfo(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001F63 RID: 8035 RVA: 0x00049335 File Offset: 0x00048335
		public static bool Writer(LobbyInfo data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001F64 RID: 8036 RVA: 0x0004933E File Offset: 0x0004833E
		public static bool WriteLobbyInfo(LobbyInfo data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001F65 RID: 8037 RVA: 0x00049348 File Offset: 0x00048348
		public static bool WriterXML(SystemInfo data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("SystemInfo");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteSystemInfo(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001F66 RID: 8038 RVA: 0x00049399 File Offset: 0x00048399
		public static bool Writer(SystemInfo data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001F67 RID: 8039 RVA: 0x000493A2 File Offset: 0x000483A2
		public static bool WriteSystemInfo(SystemInfo data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001F68 RID: 8040 RVA: 0x000493AC File Offset: 0x000483AC
		public static bool WriterXML(Cdn data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("Cdn");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteCdn(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001F69 RID: 8041 RVA: 0x000493FD File Offset: 0x000483FD
		public static bool Writer(Cdn data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001F6A RID: 8042 RVA: 0x00049406 File Offset: 0x00048406
		public static bool WriteCdn(Cdn data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001F6B RID: 8043 RVA: 0x00049410 File Offset: 0x00048410
		public static bool WriterXML(region data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("region");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.Writeregion(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001F6C RID: 8044 RVA: 0x00049461 File Offset: 0x00048461
		public static bool Writer(region data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001F6D RID: 8045 RVA: 0x0004946A File Offset: 0x0004846A
		public static bool Writeregion(region data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001F6E RID: 8046 RVA: 0x00049474 File Offset: 0x00048474
		public static bool WriterXML(List<region> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfregion");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfregion(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001F6F RID: 8047 RVA: 0x000494C5 File Offset: 0x000484C5
		public static bool Writer(List<region> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001F70 RID: 8048 RVA: 0x000494CE File Offset: 0x000484CE
		public static bool WriteArrayOfregion(List<region> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001F71 RID: 8049 RVA: 0x000494D8 File Offset: 0x000484D8
		public static bool WriterXML(TermsOfService data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("TermsOfService");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteTermsOfService(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001F72 RID: 8050 RVA: 0x00049529 File Offset: 0x00048529
		public static bool Writer(TermsOfService data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001F73 RID: 8051 RVA: 0x00049532 File Offset: 0x00048532
		public static bool WriteTermsOfService(TermsOfService data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001F74 RID: 8052 RVA: 0x0004953C File Offset: 0x0004853C
		public static bool WriterXML(configuration data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("configuration");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.Writeconfiguration(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001F75 RID: 8053 RVA: 0x0004958D File Offset: 0x0004858D
		public static bool Writer(configuration data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001F76 RID: 8054 RVA: 0x00049596 File Offset: 0x00048596
		public static bool Writeconfiguration(configuration data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001F77 RID: 8055 RVA: 0x000495A0 File Offset: 0x000485A0
		public static bool WriterXML(ServerTime data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ServerTime");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Service");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteServerTime(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001F78 RID: 8056 RVA: 0x000495F1 File Offset: 0x000485F1
		public static bool Writer(ServerTime data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001F79 RID: 8057 RVA: 0x000495FA File Offset: 0x000485FA
		public static bool WriteServerTime(ServerTime data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001F7A RID: 8058 RVA: 0x00049604 File Offset: 0x00048604
		public static bool ReadPersonaDeletedClass(XmlParser doc, PersonaDeleted data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.DriverPersona");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadPersonaDeleted(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001F7B RID: 8059 RVA: 0x0004964C File Offset: 0x0004864C
		public static bool ReadPersonaIdArrayClass(XmlParser doc, PersonaIdArray data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.DriverPersona");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadPersonaIdArray(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001F7C RID: 8060 RVA: 0x00049694 File Offset: 0x00048694
		public static bool ReadPersonaPresenceClass(XmlParser doc, PersonaPresence data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.DriverPersona");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadPersonaPresence(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001F7D RID: 8061 RVA: 0x000496DC File Offset: 0x000486DC
		public static bool ReadPersonaMottoClass(XmlParser doc, PersonaMotto data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.DriverPersona");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadPersonaMotto(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001F7E RID: 8062 RVA: 0x00049724 File Offset: 0x00048724
		public static bool ReadFriendPersonaClass(XmlParser doc, FriendPersona data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.DriverPersona");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadFriendPersona(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001F7F RID: 8063 RVA: 0x0004976C File Offset: 0x0004876C
		public static bool ReadFriendResultClass(XmlParser doc, FriendResult data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.DriverPersona");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadFriendResult(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001F80 RID: 8064 RVA: 0x000497B4 File Offset: 0x000487B4
		public static bool ReadPersonaFriendsListClass(XmlParser doc, PersonaFriendsList data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.DriverPersona");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadPersonaFriendsList(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001F81 RID: 8065 RVA: 0x000497FC File Offset: 0x000487FC
		public static bool ReadArrayOfFriendPersonaClass(XmlParser doc, List<FriendPersona> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.DriverPersona");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfFriendPersona(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001F82 RID: 8066 RVA: 0x00049844 File Offset: 0x00048844
		public static bool ReadUserIdArrayClass(XmlParser doc, UserIdArray data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.DriverPersona");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadUserIdArray(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001F83 RID: 8067 RVA: 0x0004988C File Offset: 0x0004888C
		private static bool ReadPersonaDeleted(XmlParser doc, PersonaDeleted data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "personaId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.personaId);
			}
			return true;
		}

		// Token: 0x06001F84 RID: 8068 RVA: 0x000498D0 File Offset: 0x000488D0
		private static bool ReadPersonaIdArray(XmlParser doc, PersonaIdArray data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "PersonaIds";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.PersonaIds = new List<long>();
				XSD2CPP.ReadArrayOflongClass(doc, data.PersonaIds);
			}
			return true;
		}

		// Token: 0x06001F85 RID: 8069 RVA: 0x00049928 File Offset: 0x00048928
		private static bool ReadPersonaPresence(XmlParser doc, PersonaPresence data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "personaId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.personaId);
			}
			doc.Parent();
			pName = prefix + "presence";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.presence);
			}
			doc.Parent();
			pName = prefix + "userId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.userId);
			}
			return true;
		}

		// Token: 0x06001F86 RID: 8070 RVA: 0x000499BC File Offset: 0x000489BC
		private static bool ReadPersonaMotto(XmlParser doc, PersonaMotto data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "message";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.message);
			}
			doc.Parent();
			pName = prefix + "personaId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.personaId);
			}
			return true;
		}

		// Token: 0x06001F87 RID: 8071 RVA: 0x00049A28 File Offset: 0x00048A28
		private static bool ReadFriendPersona(XmlParser doc, FriendPersona data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "iconIndex";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.iconIndex);
			}
			doc.Parent();
			pName = prefix + "level";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.level);
			}
			doc.Parent();
			pName = prefix + "name";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.name);
			}
			doc.Parent();
			pName = prefix + "originalName";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.originalName);
			}
			doc.Parent();
			pName = prefix + "personaId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.personaId);
			}
			doc.Parent();
			pName = prefix + "presence";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.presence);
			}
			doc.Parent();
			pName = prefix + "socialNetwork";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.socialNetwork);
			}
			doc.Parent();
			pName = prefix + "userId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.userId);
			}
			return true;
		}

		// Token: 0x06001F88 RID: 8072 RVA: 0x00049B8C File Offset: 0x00048B8C
		private static bool ReadFriendResult(XmlParser doc, FriendResult data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "persona";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.persona = new FriendPersona();
				XSD2CPP.ReadFriendPersonaClass(doc, data.persona);
			}
			doc.Parent();
			pName = prefix + "result";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.result);
			}
			return true;
		}

		// Token: 0x06001F89 RID: 8073 RVA: 0x00049C0C File Offset: 0x00048C0C
		private static bool ReadPersonaFriendsList(XmlParser doc, PersonaFriendsList data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "friendPersona";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.friendPersona = new List<FriendPersona>();
				XSD2CPP.ReadArrayOfFriendPersonaClass(doc, data.friendPersona);
			}
			return true;
		}

		// Token: 0x06001F8A RID: 8074 RVA: 0x00049C64 File Offset: 0x00048C64
		private static bool ReadArrayOfFriendPersona(XmlParser doc, List<FriendPersona> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "FriendPersona";
			}
			for (;;)
			{
				FriendPersona friendPersona = new FriendPersona();
				if (!XSD2CPP.ReadFriendPersonaClass(doc, friendPersona))
				{
					break;
				}
				data.Add(friendPersona);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001F8B RID: 8075 RVA: 0x00049CB4 File Offset: 0x00048CB4
		private static bool ReadUserIdArray(XmlParser doc, UserIdArray data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "UserIds";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.UserIds = new List<long>();
				XSD2CPP.ReadArrayOflongClass(doc, data.UserIds);
			}
			return true;
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x00049D0C File Offset: 0x00048D0C
		public static bool Reader(XmlString xmlString, out PersonaDeleted data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "PersonaDeleted"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new PersonaDeleted();
						if (XSD2CPP.ReadPersonaDeletedClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001F8D RID: 8077 RVA: 0x00049D68 File Offset: 0x00048D68
		public static bool ReadPersonaDeleted(XmlString xmlString, out PersonaDeleted data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001F8E RID: 8078 RVA: 0x00049D74 File Offset: 0x00048D74
		public static bool Reader(XmlString xmlString, out PersonaIdArray data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "PersonaIdArray"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new PersonaIdArray();
						if (XSD2CPP.ReadPersonaIdArrayClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001F8F RID: 8079 RVA: 0x00049DD0 File Offset: 0x00048DD0
		public static bool ReadPersonaIdArray(XmlString xmlString, out PersonaIdArray data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001F90 RID: 8080 RVA: 0x00049DDC File Offset: 0x00048DDC
		public static bool Reader(XmlString xmlString, out PersonaPresence data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "PersonaPresence"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new PersonaPresence();
						if (XSD2CPP.ReadPersonaPresenceClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001F91 RID: 8081 RVA: 0x00049E38 File Offset: 0x00048E38
		public static bool ReadPersonaPresence(XmlString xmlString, out PersonaPresence data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001F92 RID: 8082 RVA: 0x00049E44 File Offset: 0x00048E44
		public static bool Reader(XmlString xmlString, out PersonaMotto data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "PersonaMotto"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new PersonaMotto();
						if (XSD2CPP.ReadPersonaMottoClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001F93 RID: 8083 RVA: 0x00049EA0 File Offset: 0x00048EA0
		public static bool ReadPersonaMotto(XmlString xmlString, out PersonaMotto data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001F94 RID: 8084 RVA: 0x00049EAC File Offset: 0x00048EAC
		public static bool Reader(XmlString xmlString, out FriendPersona data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "FriendPersona"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new FriendPersona();
						if (XSD2CPP.ReadFriendPersonaClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001F95 RID: 8085 RVA: 0x00049F08 File Offset: 0x00048F08
		public static bool ReadFriendPersona(XmlString xmlString, out FriendPersona data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001F96 RID: 8086 RVA: 0x00049F14 File Offset: 0x00048F14
		public static bool Reader(XmlString xmlString, out FriendResult data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "FriendResult"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new FriendResult();
						if (XSD2CPP.ReadFriendResultClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001F97 RID: 8087 RVA: 0x00049F70 File Offset: 0x00048F70
		public static bool ReadFriendResult(XmlString xmlString, out FriendResult data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001F98 RID: 8088 RVA: 0x00049F7C File Offset: 0x00048F7C
		public static bool Reader(XmlString xmlString, out PersonaFriendsList data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "PersonaFriendsList"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new PersonaFriendsList();
						if (XSD2CPP.ReadPersonaFriendsListClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001F99 RID: 8089 RVA: 0x00049FD8 File Offset: 0x00048FD8
		public static bool ReadPersonaFriendsList(XmlString xmlString, out PersonaFriendsList data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001F9A RID: 8090 RVA: 0x00049FE4 File Offset: 0x00048FE4
		public static bool Reader(XmlString xmlString, out List<FriendPersona> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfFriendPersona"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<FriendPersona>();
						if (XSD2CPP.ReadArrayOfFriendPersonaClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001F9B RID: 8091 RVA: 0x0004A040 File Offset: 0x00049040
		public static bool ReadArrayOfFriendPersona(XmlString xmlString, out List<FriendPersona> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001F9C RID: 8092 RVA: 0x0004A04C File Offset: 0x0004904C
		public static bool Reader(XmlString xmlString, out UserIdArray data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "UserIdArray"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new UserIdArray();
						if (XSD2CPP.ReadUserIdArrayClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001F9D RID: 8093 RVA: 0x0004A0A8 File Offset: 0x000490A8
		public static bool ReadUserIdArray(XmlString xmlString, out UserIdArray data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001F9E RID: 8094 RVA: 0x0004A0B1 File Offset: 0x000490B1
		private static void WritePersonaDeleted(XmlParser doc, PersonaDeleted data)
		{
			doc.AddChild("personaId");
			Xsd2CppUtil.WriteLong(doc, data.personaId);
			doc.Parent();
		}

		// Token: 0x06001F9F RID: 8095 RVA: 0x0004A0D3 File Offset: 0x000490D3
		private static void WritePersonaIdArray(XmlParser doc, PersonaIdArray data)
		{
			doc.AddChild("PersonaIds");
			XSD2CPP.WriteArrayOflong(doc, data.PersonaIds);
			doc.Parent();
		}

		// Token: 0x06001FA0 RID: 8096 RVA: 0x0004A0F4 File Offset: 0x000490F4
		private static void WritePersonaPresence(XmlParser doc, PersonaPresence data)
		{
			doc.AddChild("personaId");
			Xsd2CppUtil.WriteLong(doc, data.personaId);
			doc.Parent();
			doc.AddChild("presence");
			Xsd2CppUtil.WriteInt(doc, data.presence);
			doc.Parent();
			doc.AddChild("userId");
			Xsd2CppUtil.WriteLong(doc, data.userId);
			doc.Parent();
		}

		// Token: 0x06001FA1 RID: 8097 RVA: 0x0004A164 File Offset: 0x00049164
		private static void WritePersonaMotto(XmlParser doc, PersonaMotto data)
		{
			doc.AddChild("message");
			Xsd2CppUtil.WriteString(doc, data.message);
			doc.Parent();
			doc.AddChild("personaId");
			Xsd2CppUtil.WriteLong(doc, data.personaId);
			doc.Parent();
		}

		// Token: 0x06001FA2 RID: 8098 RVA: 0x0004A1B4 File Offset: 0x000491B4
		private static void WriteFriendPersona(XmlParser doc, FriendPersona data)
		{
			doc.AddChild("iconIndex");
			Xsd2CppUtil.WriteInt(doc, data.iconIndex);
			doc.Parent();
			doc.AddChild("level");
			Xsd2CppUtil.WriteInt(doc, data.level);
			doc.Parent();
			doc.AddChild("name");
			Xsd2CppUtil.WriteString(doc, data.name);
			doc.Parent();
			doc.AddChild("originalName");
			Xsd2CppUtil.WriteString(doc, data.originalName);
			doc.Parent();
			doc.AddChild("personaId");
			Xsd2CppUtil.WriteLong(doc, data.personaId);
			doc.Parent();
			doc.AddChild("presence");
			Xsd2CppUtil.WriteInt(doc, data.presence);
			doc.Parent();
			doc.AddChild("socialNetwork");
			Xsd2CppUtil.WriteInt(doc, data.socialNetwork);
			doc.Parent();
			doc.AddChild("userId");
			Xsd2CppUtil.WriteLong(doc, data.userId);
			doc.Parent();
		}

		// Token: 0x06001FA3 RID: 8099 RVA: 0x0004A2C4 File Offset: 0x000492C4
		private static void WriteFriendResult(XmlParser doc, FriendResult data)
		{
			doc.AddChild("persona");
			XSD2CPP.WriteFriendPersona(doc, data.persona);
			doc.Parent();
			doc.AddChild("result");
			Xsd2CppUtil.WriteInt(doc, data.result);
			doc.Parent();
		}

		// Token: 0x06001FA4 RID: 8100 RVA: 0x0004A310 File Offset: 0x00049310
		private static void WritePersonaFriendsList(XmlParser doc, PersonaFriendsList data)
		{
			doc.AddChild("friendPersona");
			XSD2CPP.WriteArrayOfFriendPersona(doc, data.friendPersona);
			doc.Parent();
		}

		// Token: 0x06001FA5 RID: 8101 RVA: 0x0004A334 File Offset: 0x00049334
		private static void WriteArrayOfFriendPersona(XmlParser doc, List<FriendPersona> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("FriendPersona");
				XSD2CPP.WriteFriendPersona(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001FA6 RID: 8102 RVA: 0x0004A372 File Offset: 0x00049372
		private static void WriteUserIdArray(XmlParser doc, UserIdArray data)
		{
			doc.AddChild("UserIds");
			XSD2CPP.WriteArrayOflong(doc, data.UserIds);
			doc.Parent();
		}

		// Token: 0x06001FA7 RID: 8103 RVA: 0x0004A394 File Offset: 0x00049394
		public static bool WriterXML(PersonaDeleted data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("PersonaDeleted");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.DriverPersona");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WritePersonaDeleted(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001FA8 RID: 8104 RVA: 0x0004A3E5 File Offset: 0x000493E5
		public static bool Writer(PersonaDeleted data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001FA9 RID: 8105 RVA: 0x0004A3EE File Offset: 0x000493EE
		public static bool WritePersonaDeleted(PersonaDeleted data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001FAA RID: 8106 RVA: 0x0004A3F8 File Offset: 0x000493F8
		public static bool WriterXML(PersonaIdArray data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("PersonaIdArray");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.DriverPersona");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WritePersonaIdArray(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001FAB RID: 8107 RVA: 0x0004A449 File Offset: 0x00049449
		public static bool Writer(PersonaIdArray data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001FAC RID: 8108 RVA: 0x0004A452 File Offset: 0x00049452
		public static bool WritePersonaIdArray(PersonaIdArray data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001FAD RID: 8109 RVA: 0x0004A45C File Offset: 0x0004945C
		public static bool WriterXML(PersonaPresence data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("PersonaPresence");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.DriverPersona");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WritePersonaPresence(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001FAE RID: 8110 RVA: 0x0004A4AD File Offset: 0x000494AD
		public static bool Writer(PersonaPresence data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001FAF RID: 8111 RVA: 0x0004A4B6 File Offset: 0x000494B6
		public static bool WritePersonaPresence(PersonaPresence data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001FB0 RID: 8112 RVA: 0x0004A4C0 File Offset: 0x000494C0
		public static bool WriterXML(PersonaMotto data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("PersonaMotto");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.DriverPersona");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WritePersonaMotto(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001FB1 RID: 8113 RVA: 0x0004A511 File Offset: 0x00049511
		public static bool Writer(PersonaMotto data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001FB2 RID: 8114 RVA: 0x0004A51A File Offset: 0x0004951A
		public static bool WritePersonaMotto(PersonaMotto data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001FB3 RID: 8115 RVA: 0x0004A524 File Offset: 0x00049524
		public static bool WriterXML(FriendPersona data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("FriendPersona");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.DriverPersona");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteFriendPersona(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001FB4 RID: 8116 RVA: 0x0004A575 File Offset: 0x00049575
		public static bool Writer(FriendPersona data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001FB5 RID: 8117 RVA: 0x0004A57E File Offset: 0x0004957E
		public static bool WriteFriendPersona(FriendPersona data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001FB6 RID: 8118 RVA: 0x0004A588 File Offset: 0x00049588
		public static bool WriterXML(FriendResult data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("FriendResult");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.DriverPersona");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteFriendResult(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001FB7 RID: 8119 RVA: 0x0004A5D9 File Offset: 0x000495D9
		public static bool Writer(FriendResult data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001FB8 RID: 8120 RVA: 0x0004A5E2 File Offset: 0x000495E2
		public static bool WriteFriendResult(FriendResult data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001FB9 RID: 8121 RVA: 0x0004A5EC File Offset: 0x000495EC
		public static bool WriterXML(PersonaFriendsList data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("PersonaFriendsList");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.DriverPersona");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WritePersonaFriendsList(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001FBA RID: 8122 RVA: 0x0004A63D File Offset: 0x0004963D
		public static bool Writer(PersonaFriendsList data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001FBB RID: 8123 RVA: 0x0004A646 File Offset: 0x00049646
		public static bool WritePersonaFriendsList(PersonaFriendsList data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001FBC RID: 8124 RVA: 0x0004A650 File Offset: 0x00049650
		public static bool WriterXML(List<FriendPersona> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfFriendPersona");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.DriverPersona");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfFriendPersona(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001FBD RID: 8125 RVA: 0x0004A6A1 File Offset: 0x000496A1
		public static bool Writer(List<FriendPersona> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001FBE RID: 8126 RVA: 0x0004A6AA File Offset: 0x000496AA
		public static bool WriteArrayOfFriendPersona(List<FriendPersona> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001FBF RID: 8127 RVA: 0x0004A6B4 File Offset: 0x000496B4
		public static bool WriterXML(UserIdArray data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("UserIdArray");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.DriverPersona");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteUserIdArray(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001FC0 RID: 8128 RVA: 0x0004A705 File Offset: 0x00049705
		public static bool Writer(UserIdArray data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001FC1 RID: 8129 RVA: 0x0004A70E File Offset: 0x0004970E
		public static bool WriteUserIdArray(UserIdArray data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001FC2 RID: 8130 RVA: 0x0004A718 File Offset: 0x00049718
		public static bool ReadNewsArticleTransClass(XmlParser doc, NewsArticleTrans data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.News");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadNewsArticleTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001FC3 RID: 8131 RVA: 0x0004A760 File Offset: 0x00049760
		public static bool ReadArrayOfNewsArticleTransClass(XmlParser doc, List<NewsArticleTrans> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.News");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfNewsArticleTrans(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001FC4 RID: 8132 RVA: 0x0004A7A8 File Offset: 0x000497A8
		private static bool ReadNewsArticleTypeAttribute(string pValue, out NewsArticleType data)
		{
			return NewsArticleTypeConverter.Parse(pValue, out data);
		}

		// Token: 0x06001FC5 RID: 8133 RVA: 0x0004A7B4 File Offset: 0x000497B4
		private static bool ReadNewsArticleType(XmlParser doc, out NewsArticleType data)
		{
			string value = doc.GetValue();
			return NewsArticleTypeConverter.Parse(value, out data);
		}

		// Token: 0x06001FC6 RID: 8134 RVA: 0x0004A7CF File Offset: 0x000497CF
		private static bool ReadNewsArticleFiltersAttribute(string pValue, out NewsArticleFilters data)
		{
			return NewsArticleFiltersConverter.Parse(pValue, out data);
		}

		// Token: 0x06001FC7 RID: 8135 RVA: 0x0004A7D8 File Offset: 0x000497D8
		private static bool ReadNewsArticleFilters(XmlParser doc, out NewsArticleFilters data)
		{
			string value = doc.GetValue();
			return NewsArticleFiltersConverter.Parse(value, out data);
		}

		// Token: 0x06001FC8 RID: 8136 RVA: 0x0004A7F4 File Offset: 0x000497F4
		private static bool ReadNewsArticleTrans(XmlParser doc, NewsArticleTrans data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "ExpiryTime";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadDateTime(doc, out data.ExpiryTime);
			}
			doc.Parent();
			pName = prefix + "Filters";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Filters);
			}
			doc.Parent();
			pName = prefix + "IconType";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.IconType);
			}
			doc.Parent();
			pName = prefix + "LongText_HALId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.LongText_HALId);
			}
			doc.Parent();
			pName = prefix + "NewsId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.NewsId);
			}
			doc.Parent();
			pName = prefix + "Parameters";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Parameters);
			}
			doc.Parent();
			pName = prefix + "PersonaId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.PersonaId);
			}
			doc.Parent();
			pName = prefix + "ShortText_HALId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.ShortText_HALId);
			}
			doc.Parent();
			pName = prefix + "Sticky";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Sticky);
			}
			doc.Parent();
			pName = prefix + "Timestamp";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.Timestamp);
			}
			doc.Parent();
			pName = prefix + "Type";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Type);
			}
			return true;
		}

		// Token: 0x06001FC9 RID: 8137 RVA: 0x0004A9D0 File Offset: 0x000499D0
		private static bool ReadArrayOfNewsArticleTrans(XmlParser doc, List<NewsArticleTrans> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "NewsArticleTrans";
			}
			for (;;)
			{
				NewsArticleTrans newsArticleTrans = new NewsArticleTrans();
				if (!XSD2CPP.ReadNewsArticleTransClass(doc, newsArticleTrans))
				{
					break;
				}
				data.Add(newsArticleTrans);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001FCA RID: 8138 RVA: 0x0004AA20 File Offset: 0x00049A20
		public static bool Reader(XmlString xmlString, out NewsArticleTrans data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "NewsArticleTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new NewsArticleTrans();
						if (XSD2CPP.ReadNewsArticleTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001FCB RID: 8139 RVA: 0x0004AA7C File Offset: 0x00049A7C
		public static bool ReadNewsArticleTrans(XmlString xmlString, out NewsArticleTrans data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001FCC RID: 8140 RVA: 0x0004AA88 File Offset: 0x00049A88
		public static bool Reader(XmlString xmlString, out List<NewsArticleTrans> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfNewsArticleTrans"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<NewsArticleTrans>();
						if (XSD2CPP.ReadArrayOfNewsArticleTransClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001FCD RID: 8141 RVA: 0x0004AAE4 File Offset: 0x00049AE4
		public static bool ReadArrayOfNewsArticleTrans(XmlString xmlString, out List<NewsArticleTrans> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001FCE RID: 8142 RVA: 0x0004AAED File Offset: 0x00049AED
		private static void WriteNewsArticleType(XmlParser doc, NewsArticleType data)
		{
			Xsd2CppUtil.WriteString(doc, data.ToString());
		}

		// Token: 0x06001FCF RID: 8143 RVA: 0x0004AB01 File Offset: 0x00049B01
		private static void WriteNewsArticleFilters(XmlParser doc, NewsArticleFilters data)
		{
			Xsd2CppUtil.WriteString(doc, data.ToString());
		}

		// Token: 0x06001FD0 RID: 8144 RVA: 0x0004AB18 File Offset: 0x00049B18
		private static void WriteNewsArticleTrans(XmlParser doc, NewsArticleTrans data)
		{
			doc.AddChild("ExpiryTime");
			Xsd2CppUtil.WriteDateTime(doc, data.ExpiryTime);
			doc.Parent();
			doc.AddChild("Filters");
			Xsd2CppUtil.WriteInt(doc, data.Filters);
			doc.Parent();
			doc.AddChild("IconType");
			Xsd2CppUtil.WriteInt(doc, data.IconType);
			doc.Parent();
			doc.AddChild("LongText_HALId");
			Xsd2CppUtil.WriteString(doc, data.LongText_HALId);
			doc.Parent();
			doc.AddChild("NewsId");
			Xsd2CppUtil.WriteLong(doc, data.NewsId);
			doc.Parent();
			doc.AddChild("Parameters");
			Xsd2CppUtil.WriteString(doc, data.Parameters);
			doc.Parent();
			doc.AddChild("PersonaId");
			Xsd2CppUtil.WriteLong(doc, data.PersonaId);
			doc.Parent();
			doc.AddChild("ShortText_HALId");
			Xsd2CppUtil.WriteString(doc, data.ShortText_HALId);
			doc.Parent();
			doc.AddChild("Sticky");
			Xsd2CppUtil.WriteInt(doc, data.Sticky);
			doc.Parent();
			doc.AddChild("Timestamp");
			Xsd2CppUtil.WriteLong(doc, data.Timestamp);
			doc.Parent();
			doc.AddChild("Type");
			Xsd2CppUtil.WriteInt(doc, data.Type);
			doc.Parent();
		}

		// Token: 0x06001FD1 RID: 8145 RVA: 0x0004AC88 File Offset: 0x00049C88
		private static void WriteArrayOfNewsArticleTrans(XmlParser doc, List<NewsArticleTrans> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("NewsArticleTrans");
				XSD2CPP.WriteNewsArticleTrans(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001FD2 RID: 8146 RVA: 0x0004ACC8 File Offset: 0x00049CC8
		public static bool WriterXML(NewsArticleTrans data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("NewsArticleTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.News");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteNewsArticleTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001FD3 RID: 8147 RVA: 0x0004AD19 File Offset: 0x00049D19
		public static bool Writer(NewsArticleTrans data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001FD4 RID: 8148 RVA: 0x0004AD22 File Offset: 0x00049D22
		public static bool WriteNewsArticleTrans(NewsArticleTrans data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001FD5 RID: 8149 RVA: 0x0004AD2C File Offset: 0x00049D2C
		public static bool WriterXML(List<NewsArticleTrans> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfNewsArticleTrans");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.News");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfNewsArticleTrans(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001FD6 RID: 8150 RVA: 0x0004AD7D File Offset: 0x00049D7D
		public static bool Writer(List<NewsArticleTrans> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001FD7 RID: 8151 RVA: 0x0004AD86 File Offset: 0x00049D86
		public static bool WriteArrayOfNewsArticleTrans(List<NewsArticleTrans> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001FD8 RID: 8152 RVA: 0x0004AD90 File Offset: 0x00049D90
		public static bool ReadchatServerClass(XmlParser doc, chatServer data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.Session");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadchatServer(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001FD9 RID: 8153 RVA: 0x0004ADD8 File Offset: 0x00049DD8
		public static bool ReadchatRoomClass(XmlParser doc, chatRoom data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.Session");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadchatRoom(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001FDA RID: 8154 RVA: 0x0004AE20 File Offset: 0x00049E20
		public static bool ReadArrayOfchatRoomClass(XmlParser doc, List<chatRoom> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.Session");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfchatRoom(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001FDB RID: 8155 RVA: 0x0004AE68 File Offset: 0x00049E68
		private static bool ReadchatServer(XmlParser doc, chatServer data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "Rooms";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.Rooms = new List<chatRoom>();
				XSD2CPP.ReadArrayOfchatRoomClass(doc, data.Rooms);
			}
			doc.Parent();
			pName = prefix + "ip";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.ip);
			}
			doc.Parent();
			pName = prefix + "port";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.port);
			}
			doc.Parent();
			pName = prefix + "prefix";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.prefix);
			}
			return true;
		}

		// Token: 0x06001FDC RID: 8156 RVA: 0x0004AF38 File Offset: 0x00049F38
		private static bool ReadchatRoom(XmlParser doc, chatRoom data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "channelCount";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.channelCount);
			}
			doc.Parent();
			pName = prefix + "longName";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.longName);
			}
			doc.Parent();
			pName = prefix + "shortName";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.shortName);
			}
			return true;
		}

		// Token: 0x06001FDD RID: 8157 RVA: 0x0004AFCC File Offset: 0x00049FCC
		private static bool ReadArrayOfchatRoom(XmlParser doc, List<chatRoom> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "chatRoom";
			}
			for (;;)
			{
				chatRoom chatRoom = new chatRoom();
				if (!XSD2CPP.ReadchatRoomClass(doc, chatRoom))
				{
					break;
				}
				data.Add(chatRoom);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001FDE RID: 8158 RVA: 0x0004B01C File Offset: 0x0004A01C
		public static bool Reader(XmlString xmlString, out chatServer data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "chatServer"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new chatServer();
						if (XSD2CPP.ReadchatServerClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001FDF RID: 8159 RVA: 0x0004B078 File Offset: 0x0004A078
		public static bool ReadchatServer(XmlString xmlString, out chatServer data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001FE0 RID: 8160 RVA: 0x0004B084 File Offset: 0x0004A084
		public static bool Reader(XmlString xmlString, out chatRoom data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "chatRoom"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new chatRoom();
						if (XSD2CPP.ReadchatRoomClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001FE1 RID: 8161 RVA: 0x0004B0E0 File Offset: 0x0004A0E0
		public static bool ReadchatRoom(XmlString xmlString, out chatRoom data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x0004B0EC File Offset: 0x0004A0EC
		public static bool Reader(XmlString xmlString, out List<chatRoom> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfchatRoom"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<chatRoom>();
						if (XSD2CPP.ReadArrayOfchatRoomClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x0004B148 File Offset: 0x0004A148
		public static bool ReadArrayOfchatRoom(XmlString xmlString, out List<chatRoom> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001FE4 RID: 8164 RVA: 0x0004B154 File Offset: 0x0004A154
		private static void WritechatServer(XmlParser doc, chatServer data)
		{
			doc.AddChild("Rooms");
			XSD2CPP.WriteArrayOfchatRoom(doc, data.Rooms);
			doc.Parent();
			doc.AddChild("ip");
			Xsd2CppUtil.WriteString(doc, data.ip);
			doc.Parent();
			doc.AddChild("port");
			Xsd2CppUtil.WriteInt(doc, data.port);
			doc.Parent();
			doc.AddChild("prefix");
			Xsd2CppUtil.WriteString(doc, data.prefix);
			doc.Parent();
		}

		// Token: 0x06001FE5 RID: 8165 RVA: 0x0004B1E0 File Offset: 0x0004A1E0
		private static void WritechatRoom(XmlParser doc, chatRoom data)
		{
			doc.AddChild("channelCount");
			Xsd2CppUtil.WriteInt(doc, data.channelCount);
			doc.Parent();
			doc.AddChild("longName");
			Xsd2CppUtil.WriteString(doc, data.longName);
			doc.Parent();
			doc.AddChild("shortName");
			Xsd2CppUtil.WriteString(doc, data.shortName);
			doc.Parent();
		}

		// Token: 0x06001FE6 RID: 8166 RVA: 0x0004B250 File Offset: 0x0004A250
		private static void WriteArrayOfchatRoom(XmlParser doc, List<chatRoom> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("chatRoom");
				XSD2CPP.WritechatRoom(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x06001FE7 RID: 8167 RVA: 0x0004B290 File Offset: 0x0004A290
		public static bool WriterXML(chatServer data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("chatServer");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.Session");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WritechatServer(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001FE8 RID: 8168 RVA: 0x0004B2E1 File Offset: 0x0004A2E1
		public static bool Writer(chatServer data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001FE9 RID: 8169 RVA: 0x0004B2EA File Offset: 0x0004A2EA
		public static bool WritechatServer(chatServer data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001FEA RID: 8170 RVA: 0x0004B2F4 File Offset: 0x0004A2F4
		public static bool WriterXML(chatRoom data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("chatRoom");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.Session");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WritechatRoom(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001FEB RID: 8171 RVA: 0x0004B345 File Offset: 0x0004A345
		public static bool Writer(chatRoom data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001FEC RID: 8172 RVA: 0x0004B34E File Offset: 0x0004A34E
		public static bool WritechatRoom(chatRoom data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001FED RID: 8173 RVA: 0x0004B358 File Offset: 0x0004A358
		public static bool WriterXML(List<chatRoom> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfchatRoom");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.Session");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfchatRoom(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x0004B3A9 File Offset: 0x0004A3A9
		public static bool Writer(List<chatRoom> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x0004B3B2 File Offset: 0x0004A3B2
		public static bool WriteArrayOfchatRoom(List<chatRoom> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x0004B3BC File Offset: 0x0004A3BC
		public static bool ReadUserClass(XmlParser doc, User data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.User");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadUser(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001FF1 RID: 8177 RVA: 0x0004B404 File Offset: 0x0004A404
		public static bool ReadUserInfoClass(XmlParser doc, UserInfo data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.User");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadUserInfo(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001FF2 RID: 8178 RVA: 0x0004B44C File Offset: 0x0004A44C
		public static bool ReadProfileDataClass(XmlParser doc, Victory.TransferObjects.User.ProfileData data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.User");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadProfileData(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001FF3 RID: 8179 RVA: 0x0004B494 File Offset: 0x0004A494
		public static bool ReadArrayOfProfileDataClass(XmlParser doc, List<Victory.TransferObjects.User.ProfileData> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.User");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfProfileData(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x0004B4DC File Offset: 0x0004A4DC
		public static bool ReadPersonaCCarClass(XmlParser doc, PersonaCCar data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.User");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadPersonaCCar(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001FF5 RID: 8181 RVA: 0x0004B524 File Offset: 0x0004A524
		public static bool ReadArrayOfPersonaCCarClass(XmlParser doc, List<PersonaCCar> data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.User");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadArrayOfPersonaCCar(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x0004B56C File Offset: 0x0004A56C
		private static bool ReadUser(XmlParser doc, User data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "address1";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.address1);
			}
			doc.Parent();
			pName = prefix + "address2";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.address2);
			}
			doc.Parent();
			pName = prefix + "country";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.country);
			}
			doc.Parent();
			pName = prefix + "dateCreated";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.dateCreated);
			}
			doc.Parent();
			pName = prefix + "dob";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.dob);
			}
			doc.Parent();
			pName = prefix + "email";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.email);
			}
			doc.Parent();
			pName = prefix + "emailStatus";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.emailStatus);
			}
			doc.Parent();
			pName = prefix + "firstName";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.firstName);
			}
			doc.Parent();
			pName = prefix + "fullGameAccess";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.fullGameAccess);
			}
			doc.Parent();
			pName = prefix + "gender";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.gender);
			}
			doc.Parent();
			pName = prefix + "idDigits";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.idDigits);
			}
			doc.Parent();
			pName = prefix + "isComplete";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.isComplete);
			}
			doc.Parent();
			pName = prefix + "landlinePhone";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.landlinePhone);
			}
			doc.Parent();
			pName = prefix + "language";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.language);
			}
			doc.Parent();
			pName = prefix + "lastAuthDate";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.lastAuthDate);
			}
			doc.Parent();
			pName = prefix + "lastName";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.lastName);
			}
			doc.Parent();
			pName = prefix + "mobile";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.mobile);
			}
			doc.Parent();
			pName = prefix + "nickname";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.nickname);
			}
			doc.Parent();
			pName = prefix + "postalCode";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.postalCode);
			}
			doc.Parent();
			pName = prefix + "realName";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.realName);
			}
			doc.Parent();
			pName = prefix + "reasonCode";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.reasonCode);
			}
			doc.Parent();
			pName = prefix + "remoteUserId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.remoteUserId);
			}
			doc.Parent();
			pName = prefix + "securityToken";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.securityToken);
			}
			doc.Parent();
			pName = prefix + "starterPackEntitlementTag";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.starterPackEntitlementTag);
			}
			doc.Parent();
			pName = prefix + "status";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.status);
			}
			doc.Parent();
			pName = prefix + "subscribeMsg";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.subscribeMsg);
			}
			doc.Parent();
			pName = prefix + "tosVersion";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.tosVersion);
			}
			doc.Parent();
			pName = prefix + "userId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.userId);
			}
			doc.Parent();
			pName = prefix + "username";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.username);
			}
			return true;
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x0004BA2C File Offset: 0x0004AA2C
		private static bool ReadUserInfo(XmlParser doc, UserInfo data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "defaultPersonaIdx";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.defaultPersonaIdx);
			}
			doc.Parent();
			pName = prefix + "personas";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.personas = new List<Victory.TransferObjects.User.ProfileData>();
				XSD2CPP.ReadArrayOfProfileDataClass(doc, data.personas);
			}
			doc.Parent();
			pName = prefix + "user";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.user = new User();
				XSD2CPP.ReadUserClass(doc, data.user);
			}
			return true;
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x0004BAE8 File Offset: 0x0004AAE8
		private static bool ReadProfileData(XmlParser doc, Victory.TransferObjects.User.ProfileData data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "Boost";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadDouble(doc, out data.Boost);
			}
			doc.Parent();
			pName = prefix + "Cash";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadDouble(doc, out data.Cash);
			}
			doc.Parent();
			pName = prefix + "IconIndex";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.IconIndex);
			}
			doc.Parent();
			pName = prefix + "Level";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Level);
			}
			doc.Parent();
			pName = prefix + "Motto";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Motto);
			}
			doc.Parent();
			pName = prefix + "Name";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Name);
			}
			doc.Parent();
			pName = prefix + "PercentToLevel";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadFloat(doc, out data.PercentToLevel);
			}
			doc.Parent();
			pName = prefix + "PersonaId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.PersonaId);
			}
			doc.Parent();
			pName = prefix + "Rating";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadDouble(doc, out data.Rating);
			}
			doc.Parent();
			pName = prefix + "Rep";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadDouble(doc, out data.Rep);
			}
			doc.Parent();
			pName = prefix + "RepAtCurrentLevel";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.RepAtCurrentLevel);
			}
			doc.Parent();
			pName = prefix + "ccar";
			if (doc.FirstChild(pName) && Xsd2CppUtil.HasInstance(doc))
			{
				data.ccar = new List<PersonaCCar>();
				XSD2CPP.ReadArrayOfPersonaCCarClass(doc, data.ccar);
			}
			return true;
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x0004BD00 File Offset: 0x0004AD00
		private static bool ReadArrayOfProfileData(XmlParser doc, List<Victory.TransferObjects.User.ProfileData> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "ProfileData";
			}
			for (;;)
			{
				Victory.TransferObjects.User.ProfileData profileData = new Victory.TransferObjects.User.ProfileData();
				if (!XSD2CPP.ReadProfileDataClass(doc, profileData))
				{
					break;
				}
				data.Add(profileData);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x0004BD50 File Offset: 0x0004AD50
		private static bool ReadPersonaCCar(XmlParser doc, PersonaCCar data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "CCID";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.CCID);
			}
			doc.Parent();
			pName = prefix + "Durability";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadInt(doc, out data.Durability);
			}
			doc.Parent();
			pName = prefix + "Heat";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadFloat(doc, out data.Heat);
			}
			doc.Parent();
			pName = prefix + "IsDefault";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadBoolean(doc, out data.IsDefault);
			}
			doc.Parent();
			pName = prefix + "PersonaId";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadLong(doc, out data.PersonaId);
			}
			return true;
		}

		// Token: 0x06001FFB RID: 8187 RVA: 0x0004BE38 File Offset: 0x0004AE38
		private static bool ReadArrayOfPersonaCCar(XmlParser doc, List<PersonaCCar> data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			if (prefix.Length > 0)
			{
				prefix + "PersonaCCar";
			}
			for (;;)
			{
				PersonaCCar personaCCar = new PersonaCCar();
				if (!XSD2CPP.ReadPersonaCCarClass(doc, personaCCar))
				{
					break;
				}
				data.Add(personaCCar);
				if (!doc.NextChild())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x0004BE88 File Offset: 0x0004AE88
		public static bool Reader(XmlString xmlString, out User data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "User"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new User();
						if (XSD2CPP.ReadUserClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001FFD RID: 8189 RVA: 0x0004BEE4 File Offset: 0x0004AEE4
		public static bool ReadUser(XmlString xmlString, out User data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06001FFE RID: 8190 RVA: 0x0004BEF0 File Offset: 0x0004AEF0
		public static bool Reader(XmlString xmlString, out UserInfo data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "UserInfo"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new UserInfo();
						if (XSD2CPP.ReadUserInfoClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06001FFF RID: 8191 RVA: 0x0004BF4C File Offset: 0x0004AF4C
		public static bool ReadUserInfo(XmlString xmlString, out UserInfo data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06002000 RID: 8192 RVA: 0x0004BF58 File Offset: 0x0004AF58
		public static bool Reader(XmlString xmlString, out Victory.TransferObjects.User.ProfileData data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ProfileData"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new Victory.TransferObjects.User.ProfileData();
						if (XSD2CPP.ReadProfileDataClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06002001 RID: 8193 RVA: 0x0004BFB4 File Offset: 0x0004AFB4
		public static bool ReadProfileData(XmlString xmlString, out Victory.TransferObjects.User.ProfileData data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06002002 RID: 8194 RVA: 0x0004BFC0 File Offset: 0x0004AFC0
		public static bool Reader(XmlString xmlString, out List<Victory.TransferObjects.User.ProfileData> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfProfileData"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<Victory.TransferObjects.User.ProfileData>();
						if (XSD2CPP.ReadArrayOfProfileDataClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06002003 RID: 8195 RVA: 0x0004C01C File Offset: 0x0004B01C
		public static bool ReadArrayOfProfileData(XmlString xmlString, out List<Victory.TransferObjects.User.ProfileData> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06002004 RID: 8196 RVA: 0x0004C028 File Offset: 0x0004B028
		public static bool Reader(XmlString xmlString, out PersonaCCar data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "PersonaCCar"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new PersonaCCar();
						if (XSD2CPP.ReadPersonaCCarClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06002005 RID: 8197 RVA: 0x0004C084 File Offset: 0x0004B084
		public static bool ReadPersonaCCar(XmlString xmlString, out PersonaCCar data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06002006 RID: 8198 RVA: 0x0004C090 File Offset: 0x0004B090
		public static bool Reader(XmlString xmlString, out List<PersonaCCar> data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "ArrayOfPersonaCCar"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new List<PersonaCCar>();
						if (XSD2CPP.ReadArrayOfPersonaCCarClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06002007 RID: 8199 RVA: 0x0004C0EC File Offset: 0x0004B0EC
		public static bool ReadArrayOfPersonaCCar(XmlString xmlString, out List<PersonaCCar> data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06002008 RID: 8200 RVA: 0x0004C0F8 File Offset: 0x0004B0F8
		private static void WriteUser(XmlParser doc, User data)
		{
			doc.AddChild("address1");
			Xsd2CppUtil.WriteString(doc, data.address1);
			doc.Parent();
			doc.AddChild("address2");
			Xsd2CppUtil.WriteString(doc, data.address2);
			doc.Parent();
			doc.AddChild("country");
			Xsd2CppUtil.WriteString(doc, data.country);
			doc.Parent();
			doc.AddChild("dateCreated");
			Xsd2CppUtil.WriteString(doc, data.dateCreated);
			doc.Parent();
			doc.AddChild("dob");
			Xsd2CppUtil.WriteString(doc, data.dob);
			doc.Parent();
			doc.AddChild("email");
			Xsd2CppUtil.WriteString(doc, data.email);
			doc.Parent();
			doc.AddChild("emailStatus");
			Xsd2CppUtil.WriteString(doc, data.emailStatus);
			doc.Parent();
			doc.AddChild("firstName");
			Xsd2CppUtil.WriteString(doc, data.firstName);
			doc.Parent();
			doc.AddChild("fullGameAccess");
			Xsd2CppUtil.WriteBoolean(doc, data.fullGameAccess);
			doc.Parent();
			doc.AddChild("gender");
			Xsd2CppUtil.WriteString(doc, data.gender);
			doc.Parent();
			doc.AddChild("idDigits");
			Xsd2CppUtil.WriteString(doc, data.idDigits);
			doc.Parent();
			doc.AddChild("isComplete");
			Xsd2CppUtil.WriteBoolean(doc, data.isComplete);
			doc.Parent();
			doc.AddChild("landlinePhone");
			Xsd2CppUtil.WriteString(doc, data.landlinePhone);
			doc.Parent();
			doc.AddChild("language");
			Xsd2CppUtil.WriteString(doc, data.language);
			doc.Parent();
			doc.AddChild("lastAuthDate");
			Xsd2CppUtil.WriteString(doc, data.lastAuthDate);
			doc.Parent();
			doc.AddChild("lastName");
			Xsd2CppUtil.WriteString(doc, data.lastName);
			doc.Parent();
			doc.AddChild("mobile");
			Xsd2CppUtil.WriteString(doc, data.mobile);
			doc.Parent();
			doc.AddChild("nickname");
			Xsd2CppUtil.WriteString(doc, data.nickname);
			doc.Parent();
			doc.AddChild("postalCode");
			Xsd2CppUtil.WriteString(doc, data.postalCode);
			doc.Parent();
			doc.AddChild("realName");
			Xsd2CppUtil.WriteString(doc, data.realName);
			doc.Parent();
			doc.AddChild("reasonCode");
			Xsd2CppUtil.WriteString(doc, data.reasonCode);
			doc.Parent();
			doc.AddChild("remoteUserId");
			Xsd2CppUtil.WriteLong(doc, data.remoteUserId);
			doc.Parent();
			doc.AddChild("securityToken");
			Xsd2CppUtil.WriteString(doc, data.securityToken);
			doc.Parent();
			doc.AddChild("starterPackEntitlementTag");
			Xsd2CppUtil.WriteString(doc, data.starterPackEntitlementTag);
			doc.Parent();
			doc.AddChild("status");
			Xsd2CppUtil.WriteString(doc, data.status);
			doc.Parent();
			doc.AddChild("subscribeMsg");
			Xsd2CppUtil.WriteBoolean(doc, data.subscribeMsg);
			doc.Parent();
			doc.AddChild("tosVersion");
			Xsd2CppUtil.WriteString(doc, data.tosVersion);
			doc.Parent();
			doc.AddChild("userId");
			Xsd2CppUtil.WriteLong(doc, data.userId);
			doc.Parent();
			doc.AddChild("username");
			Xsd2CppUtil.WriteString(doc, data.username);
			doc.Parent();
		}

		// Token: 0x06002009 RID: 8201 RVA: 0x0004C4A8 File Offset: 0x0004B4A8
		private static void WriteUserInfo(XmlParser doc, UserInfo data)
		{
			doc.AddChild("defaultPersonaIdx");
			Xsd2CppUtil.WriteInt(doc, data.defaultPersonaIdx);
			doc.Parent();
			doc.AddChild("personas");
			XSD2CPP.WriteArrayOfProfileData(doc, data.personas);
			doc.Parent();
			doc.AddChild("user");
			XSD2CPP.WriteUser(doc, data.user);
			doc.Parent();
		}

		// Token: 0x0600200A RID: 8202 RVA: 0x0004C514 File Offset: 0x0004B514
		private static void WriteProfileData(XmlParser doc, Victory.TransferObjects.User.ProfileData data)
		{
			doc.AddChild("Boost");
			Xsd2CppUtil.WriteDouble(doc, data.Boost);
			doc.Parent();
			doc.AddChild("Cash");
			Xsd2CppUtil.WriteDouble(doc, data.Cash);
			doc.Parent();
			doc.AddChild("IconIndex");
			Xsd2CppUtil.WriteInt(doc, data.IconIndex);
			doc.Parent();
			doc.AddChild("Level");
			Xsd2CppUtil.WriteInt(doc, data.Level);
			doc.Parent();
			doc.AddChild("Motto");
			Xsd2CppUtil.WriteString(doc, data.Motto);
			doc.Parent();
			doc.AddChild("Name");
			Xsd2CppUtil.WriteString(doc, data.Name);
			doc.Parent();
			doc.AddChild("PercentToLevel");
			Xsd2CppUtil.WriteFloat(doc, data.PercentToLevel);
			doc.Parent();
			doc.AddChild("PersonaId");
			Xsd2CppUtil.WriteLong(doc, data.PersonaId);
			doc.Parent();
			doc.AddChild("Rating");
			Xsd2CppUtil.WriteDouble(doc, data.Rating);
			doc.Parent();
			doc.AddChild("Rep");
			Xsd2CppUtil.WriteDouble(doc, data.Rep);
			doc.Parent();
			doc.AddChild("RepAtCurrentLevel");
			Xsd2CppUtil.WriteInt(doc, data.RepAtCurrentLevel);
			doc.Parent();
			doc.AddChild("ccar");
			XSD2CPP.WriteArrayOfPersonaCCar(doc, data.ccar);
			doc.Parent();
		}

		// Token: 0x0600200B RID: 8203 RVA: 0x0004C6A0 File Offset: 0x0004B6A0
		private static void WriteArrayOfProfileData(XmlParser doc, List<Victory.TransferObjects.User.ProfileData> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("ProfileData");
				XSD2CPP.WriteProfileData(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x0600200C RID: 8204 RVA: 0x0004C6E0 File Offset: 0x0004B6E0
		private static void WritePersonaCCar(XmlParser doc, PersonaCCar data)
		{
			doc.AddChild("CCID");
			Xsd2CppUtil.WriteInt(doc, data.CCID);
			doc.Parent();
			doc.AddChild("Durability");
			Xsd2CppUtil.WriteInt(doc, data.Durability);
			doc.Parent();
			doc.AddChild("Heat");
			Xsd2CppUtil.WriteFloat(doc, data.Heat);
			doc.Parent();
			doc.AddChild("IsDefault");
			Xsd2CppUtil.WriteBoolean(doc, data.IsDefault);
			doc.Parent();
			doc.AddChild("PersonaId");
			Xsd2CppUtil.WriteLong(doc, data.PersonaId);
			doc.Parent();
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x0004C790 File Offset: 0x0004B790
		private static void WriteArrayOfPersonaCCar(XmlParser doc, List<PersonaCCar> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				doc.AddChild("PersonaCCar");
				XSD2CPP.WritePersonaCCar(doc, data[i]);
				doc.Parent();
			}
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x0004C7D0 File Offset: 0x0004B7D0
		public static bool WriterXML(User data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("User");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.User");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteUser(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x0600200F RID: 8207 RVA: 0x0004C821 File Offset: 0x0004B821
		public static bool Writer(User data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06002010 RID: 8208 RVA: 0x0004C82A File Offset: 0x0004B82A
		public static bool WriteUser(User data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06002011 RID: 8209 RVA: 0x0004C834 File Offset: 0x0004B834
		public static bool WriterXML(UserInfo data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("UserInfo");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.User");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteUserInfo(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06002012 RID: 8210 RVA: 0x0004C885 File Offset: 0x0004B885
		public static bool Writer(UserInfo data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06002013 RID: 8211 RVA: 0x0004C88E File Offset: 0x0004B88E
		public static bool WriteUserInfo(UserInfo data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06002014 RID: 8212 RVA: 0x0004C898 File Offset: 0x0004B898
		public static bool WriterXML(Victory.TransferObjects.User.ProfileData data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ProfileData");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.User");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteProfileData(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06002015 RID: 8213 RVA: 0x0004C8E9 File Offset: 0x0004B8E9
		public static bool Writer(Victory.TransferObjects.User.ProfileData data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06002016 RID: 8214 RVA: 0x0004C8F2 File Offset: 0x0004B8F2
		public static bool WriteProfileData(Victory.TransferObjects.User.ProfileData data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06002017 RID: 8215 RVA: 0x0004C8FC File Offset: 0x0004B8FC
		public static bool WriterXML(List<Victory.TransferObjects.User.ProfileData> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfProfileData");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.User");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfProfileData(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x0004C94D File Offset: 0x0004B94D
		public static bool Writer(List<Victory.TransferObjects.User.ProfileData> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06002019 RID: 8217 RVA: 0x0004C956 File Offset: 0x0004B956
		public static bool WriteArrayOfProfileData(List<Victory.TransferObjects.User.ProfileData> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x0600201A RID: 8218 RVA: 0x0004C960 File Offset: 0x0004B960
		public static bool WriterXML(PersonaCCar data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("PersonaCCar");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.User");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WritePersonaCCar(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x0600201B RID: 8219 RVA: 0x0004C9B1 File Offset: 0x0004B9B1
		public static bool Writer(PersonaCCar data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x0600201C RID: 8220 RVA: 0x0004C9BA File Offset: 0x0004B9BA
		public static bool WritePersonaCCar(PersonaCCar data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x0600201D RID: 8221 RVA: 0x0004C9C4 File Offset: 0x0004B9C4
		public static bool WriterXML(List<PersonaCCar> data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("ArrayOfPersonaCCar");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.User");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteArrayOfPersonaCCar(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x0004CA15 File Offset: 0x0004BA15
		public static bool Writer(List<PersonaCCar> data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x0004CA1E File Offset: 0x0004BA1E
		public static bool WriteArrayOfPersonaCCar(List<PersonaCCar> data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06002020 RID: 8224 RVA: 0x0004CA28 File Offset: 0x0004BA28
		public static bool ReadVoipRoomInfoClass(XmlParser doc, VoipRoomInfo data)
		{
			bool result = true;
			string text = Xsd2CppUtil.GetPrefix(doc, "http://schemas.datacontract.org/2004/07/Victory.Voip");
			if (text.Length != 0)
			{
				text += ":";
			}
			if (doc.FirstChild())
			{
				result = XSD2CPP.ReadVoipRoomInfo(doc, data, text);
			}
			doc.Parent();
			return result;
		}

		// Token: 0x06002021 RID: 8225 RVA: 0x0004CA70 File Offset: 0x0004BA70
		private static bool ReadVoipRoomInfo(XmlParser doc, VoipRoomInfo data, string prefix)
		{
			if (doc == null)
			{
				return false;
			}
			doc.Parent();
			string pName = prefix + "Token";
			if (doc.FirstChild(pName))
			{
				Xsd2CppUtil.ReadString(doc, out data.Token);
			}
			return true;
		}

		// Token: 0x06002022 RID: 8226 RVA: 0x0004CAB4 File Offset: 0x0004BAB4
		public static bool Reader(XmlString xmlString, out VoipRoomInfo data)
		{
			data = null;
			XmlParser xmlParser = new XmlParser();
			xmlParser.Parse(xmlString);
			bool flag = false;
			xmlParser.Root();
			while (!(xmlParser.GetName() == "VoipRoomInfo"))
			{
				if (!xmlParser.NextChild())
				{
					IL_38:
					if (flag)
					{
						data = new VoipRoomInfo();
						if (XSD2CPP.ReadVoipRoomInfoClass(xmlParser, data))
						{
							return true;
						}
					}
					return false;
				}
			}
			flag = true;
			goto IL_38;
		}

		// Token: 0x06002023 RID: 8227 RVA: 0x0004CB10 File Offset: 0x0004BB10
		public static bool ReadVoipRoomInfo(XmlString xmlString, out VoipRoomInfo data)
		{
			return XSD2CPP.Reader(xmlString, out data);
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x0004CB19 File Offset: 0x0004BB19
		private static void WriteVoipRoomInfo(XmlParser doc, VoipRoomInfo data)
		{
			doc.AddChild("Token");
			Xsd2CppUtil.WriteString(doc, data.Token);
			doc.Parent();
		}

		// Token: 0x06002025 RID: 8229 RVA: 0x0004CB3C File Offset: 0x0004BB3C
		public static bool WriterXML(VoipRoomInfo data, out string pString)
		{
			XmlParser xmlParser = new XmlParser();
			xmlParser.AddChild("VoipRoomInfo");
			xmlParser.AddAttribute("xmlns", "http://schemas.datacontract.org/2004/07/Victory.Voip");
			xmlParser.AddAttribute("xmlns:i", "http://www.w3.org/2001/XMLSchema-instance");
			XSD2CPP.WriteVoipRoomInfo(xmlParser, data);
			return XSD2CPP.WriteXML(xmlParser, out pString);
		}

		// Token: 0x06002026 RID: 8230 RVA: 0x0004CB8D File Offset: 0x0004BB8D
		public static bool Writer(VoipRoomInfo data, out string pString)
		{
			return XSD2CPP.WriterXML(data, out pString);
		}

		// Token: 0x06002027 RID: 8231 RVA: 0x0004CB96 File Offset: 0x0004BB96
		public static bool WriteVoipRoomInfo(VoipRoomInfo data, out string pString)
		{
			return XSD2CPP.Writer(data, out pString);
		}

		// Token: 0x06002028 RID: 8232 RVA: 0x0004CB9F File Offset: 0x0004BB9F
		private static bool ReadEngineErrorCodeAttribute(string pValue, out EngineErrorCode data)
		{
			return EngineErrorCodeConverter.Parse(pValue, out data);
		}

		// Token: 0x06002029 RID: 8233 RVA: 0x0004CBA8 File Offset: 0x0004BBA8
		private static bool ReadEngineErrorCode(XmlParser doc, out EngineErrorCode data)
		{
			string value = doc.GetValue();
			return EngineErrorCodeConverter.Parse(value, out data);
		}

		// Token: 0x0600202A RID: 8234 RVA: 0x0004CBC3 File Offset: 0x0004BBC3
		private static void WriteEngineErrorCode(XmlParser doc, EngineErrorCode data)
		{
			Xsd2CppUtil.WriteString(doc, data.ToString());
		}

		// Token: 0x0600202B RID: 8235 RVA: 0x0004CBD7 File Offset: 0x0004BBD7
		private static bool WriteXML(XmlParser doc, out string pString)
		{
			doc.Root();
			pString = doc.GetXml();
			return true;
		}
	}
}
