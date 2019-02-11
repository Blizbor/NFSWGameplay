using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization.Event
{
	// Token: 0x020002C0 RID: 704
	public class EventTimedOut : IRequestBody
	{
		// Token: 0x06002085 RID: 8325 RVA: 0x0004D620 File Offset: 0x0004C620
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000796 RID: 1942
		public long EventSessionId;
	}
}
