using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization.Event
{
	// Token: 0x020002C7 RID: 711
	public class RewardPart : IRequestBody
	{
		// Token: 0x06002093 RID: 8339 RVA: 0x0004D744 File Offset: 0x0004C744
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040007B8 RID: 1976
		public int RepPart;

		// Token: 0x040007B9 RID: 1977
		public enumRewardCategory RewardCategory;

		// Token: 0x040007BA RID: 1978
		public enumRewardType RewardType;

		// Token: 0x040007BB RID: 1979
		public int TokenPart;
	}
}
