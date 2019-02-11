using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x020002B3 RID: 691
	public class FraudConfig : IRequestBody
	{
		// Token: 0x0600206B RID: 8299 RVA: 0x0004D340 File Offset: 0x0004C340
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x0400074B RID: 1867
		public int enabledBitField;

		// Token: 0x0400074C RID: 1868
		public int gameFileFreq;

		// Token: 0x0400074D RID: 1869
		public int moduleFreq;

		// Token: 0x0400074E RID: 1870
		public int startUpFreq;

		// Token: 0x0400074F RID: 1871
		public long userID;
	}
}
