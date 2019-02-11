using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization.Social
{
	// Token: 0x020002E4 RID: 740
	public class BasicBlockPlayerInfo : IRequestBody
	{
		// Token: 0x060020C5 RID: 8389 RVA: 0x0004DF30 File Offset: 0x0004CF30
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000845 RID: 2117
		public long personaId;

		// Token: 0x04000846 RID: 2118
		public long userId;
	}
}
