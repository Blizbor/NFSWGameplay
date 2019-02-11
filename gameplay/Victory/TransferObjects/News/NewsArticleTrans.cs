using System;
using server_packet;
using xsd2cpp;

namespace Victory.TransferObjects.News
{
	// Token: 0x02000333 RID: 819
	public class NewsArticleTrans : IRequestBody
	{
		// Token: 0x06002153 RID: 8531 RVA: 0x0004EF84 File Offset: 0x0004DF84
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040009AA RID: 2474
		public DateTime ExpiryTime = DateTime.FromBinary(0L);

		// Token: 0x040009AB RID: 2475
		public int Filters;

		// Token: 0x040009AC RID: 2476
		public int IconType;

		// Token: 0x040009AD RID: 2477
		public string LongText_HALId = "";

		// Token: 0x040009AE RID: 2478
		public long NewsId;

		// Token: 0x040009AF RID: 2479
		public string Parameters = "";

		// Token: 0x040009B0 RID: 2480
		public long PersonaId;

		// Token: 0x040009B1 RID: 2481
		public string ShortText_HALId = "";

		// Token: 0x040009B2 RID: 2482
		public int Sticky;

		// Token: 0x040009B3 RID: 2483
		public long Timestamp;

		// Token: 0x040009B4 RID: 2484
		public int Type;
	}
}
