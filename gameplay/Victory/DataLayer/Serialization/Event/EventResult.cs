using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization.Event
{
	// Token: 0x020002C4 RID: 708
	public class EventResult : IRequestBody
	{
		// Token: 0x0600208D RID: 8333 RVA: 0x0004D6AC File Offset: 0x0004C6AC
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040007A5 RID: 1957
		public Accolades Accolades;

		// Token: 0x040007A6 RID: 1958
		public int Durability;

		// Token: 0x040007A7 RID: 1959
		public int EventId;

		// Token: 0x040007A8 RID: 1960
		public long EventSessionId;

		// Token: 0x040007A9 RID: 1961
		public ExitPath ExitPath;

		// Token: 0x040007AA RID: 1962
		public int InviteLifetimeInMilliseconds;

		// Token: 0x040007AB RID: 1963
		public long LobbyInviteId;

		// Token: 0x040007AC RID: 1964
		public long PersonaId;
	}
}
