using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization.Event
{
	// Token: 0x020002D2 RID: 722
	public class EventsPacket : IRequestBody
	{
		// Token: 0x060020A9 RID: 8361 RVA: 0x0004D8A4 File Offset: 0x0004C8A4
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040007D1 RID: 2001
		public List<EventDefinition> Events;
	}
}
