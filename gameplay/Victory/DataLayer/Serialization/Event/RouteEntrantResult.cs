using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization.Event
{
	// Token: 0x020002CA RID: 714
	public class RouteEntrantResult : EntrantResult, IRequestBody
	{
		// Token: 0x06002099 RID: 8345 RVA: 0x0004D7A4 File Offset: 0x0004C7A4
		public override string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040007C2 RID: 1986
		public uint BestLapDurationInMilliseconds;

		// Token: 0x040007C3 RID: 1987
		public float TopSpeed;
	}
}
