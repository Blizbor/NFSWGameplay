using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization.Event
{
	// Token: 0x020002CB RID: 715
	public class DragEventResult : EventResult, IRequestBody
	{
		// Token: 0x0600209B RID: 8347 RVA: 0x0004D7C4 File Offset: 0x0004C7C4
		public override string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040007C4 RID: 1988
		public List<DragEntrantResult> Entrants;
	}
}
