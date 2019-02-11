using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization.Social
{
	// Token: 0x020002E7 RID: 743
	public class UserPersonaMap : IRequestBody
	{
		// Token: 0x060020CB RID: 8395 RVA: 0x0004DF90 File Offset: 0x0004CF90
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x0400084F RID: 2127
		public long personaId;

		// Token: 0x04000850 RID: 2128
		public long userId;
	}
}
