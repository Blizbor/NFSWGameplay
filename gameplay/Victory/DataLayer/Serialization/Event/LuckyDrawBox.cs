using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization.Event
{
	// Token: 0x020002C5 RID: 709
	public class LuckyDrawBox : IRequestBody
	{
		// Token: 0x0600208F RID: 8335 RVA: 0x0004D6CC File Offset: 0x0004C6CC
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040007AD RID: 1965
		public bool IsValid;

		// Token: 0x040007AE RID: 1966
		public string LocalizationString = "";

		// Token: 0x040007AF RID: 1967
		public int LuckyDrawSetCategoryId;
	}
}
