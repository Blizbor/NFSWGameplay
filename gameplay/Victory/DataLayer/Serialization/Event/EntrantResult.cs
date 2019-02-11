using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization.Event
{
	// Token: 0x020002C9 RID: 713
	public class EntrantResult : IRequestBody
	{
		// Token: 0x06002097 RID: 8343 RVA: 0x0004D784 File Offset: 0x0004C784
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040007BD RID: 1981
		public uint EventDurationInMilliseconds;

		// Token: 0x040007BE RID: 1982
		public long EventSessionId;

		// Token: 0x040007BF RID: 1983
		public int FinishReason;

		// Token: 0x040007C0 RID: 1984
		public long PersonaId;

		// Token: 0x040007C1 RID: 1985
		public int Ranking;
	}
}
