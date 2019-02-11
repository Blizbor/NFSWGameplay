using System;
using server_packet;
using Victory.DataLayer.Serialization;
using xsd2cpp;

namespace Victory.Service.Objects
{
	// Token: 0x0200031A RID: 794
	public class AchievementRewards : CommerceResultTrans, IRequestBody
	{
		// Token: 0x06002127 RID: 8487 RVA: 0x0004EB24 File Offset: 0x0004DB24
		public override string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000968 RID: 2408
		public int AchievementRankId;

		// Token: 0x04000969 RID: 2409
		public string VisualStyle = "";
	}
}
