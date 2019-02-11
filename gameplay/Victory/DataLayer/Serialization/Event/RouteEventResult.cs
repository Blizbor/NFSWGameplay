using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization.Event
{
	// Token: 0x020002C8 RID: 712
	public class RouteEventResult : EventResult, IRequestBody
	{
		// Token: 0x06002095 RID: 8341 RVA: 0x0004D764 File Offset: 0x0004C764
		public override string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040007BC RID: 1980
		public List<RouteEntrantResult> Entrants;
	}
}
