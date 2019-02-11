using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization.Event
{
	// Token: 0x020002CF RID: 719
	public class PursuitEventResult : EventResult, IRequestBody
	{
		// Token: 0x060020A3 RID: 8355 RVA: 0x0004D844 File Offset: 0x0004C844
		public override string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040007C9 RID: 1993
		public float Heat;
	}
}
