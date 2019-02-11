using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization.Event
{
	// Token: 0x020002CD RID: 717
	public class TeamEscapeEventResult : EventResult, IRequestBody
	{
		// Token: 0x0600209F RID: 8351 RVA: 0x0004D804 File Offset: 0x0004C804
		public override string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040007C6 RID: 1990
		public List<TeamEscapeEntrantResult> Entrants;
	}
}
