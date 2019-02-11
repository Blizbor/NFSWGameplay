using System;
using server_packet;
using xsd2cpp;

namespace Victory.Service.Objects
{
	// Token: 0x0200030A RID: 778
	public class AchievementProgress : IRequestBody
	{
		// Token: 0x06002107 RID: 8455 RVA: 0x0004E83C File Offset: 0x0004D83C
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040008F1 RID: 2289
		public int AchievementDefinitionId;

		// Token: 0x040008F2 RID: 2290
		public long CurrentValue;
	}
}
