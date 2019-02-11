using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization.Social
{
	// Token: 0x020002E2 RID: 738
	public class RemoveFriendMsg : IRequestBody
	{
		// Token: 0x060020C1 RID: 8385 RVA: 0x0004DEF0 File Offset: 0x0004CEF0
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000843 RID: 2115
		public long personaId;
	}
}
