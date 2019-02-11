using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization.Event
{
	// Token: 0x020002C6 RID: 710
	public class LuckyDrawItem : IRequestBody
	{
		// Token: 0x06002091 RID: 8337 RVA: 0x0004D6F8 File Offset: 0x0004C6F8
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040007B0 RID: 1968
		public string Description = "";

		// Token: 0x040007B1 RID: 1969
		public int Hash;

		// Token: 0x040007B2 RID: 1970
		public string Icon = "";

		// Token: 0x040007B3 RID: 1971
		public int RemainingUseCount;

		// Token: 0x040007B4 RID: 1972
		public float ResellPrice;

		// Token: 0x040007B5 RID: 1973
		public string VirtualItem = "";

		// Token: 0x040007B6 RID: 1974
		public string VirtualItemType = "";

		// Token: 0x040007B7 RID: 1975
		public bool WasSold;
	}
}
