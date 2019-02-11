using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization.Event
{
	// Token: 0x020002D0 RID: 720
	public class EventTimingOut : IRequestBody
	{
		// Token: 0x060020A5 RID: 8357 RVA: 0x0004D864 File Offset: 0x0004C864
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040007CA RID: 1994
		public long EventSessionId;

		// Token: 0x040007CB RID: 1995
		public long TimeInMilliseconds;
	}
}
