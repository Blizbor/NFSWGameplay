using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization.Event
{
	// Token: 0x020002CE RID: 718
	public class TeamEscapeEntrantResult : EntrantResult, IRequestBody
	{
		// Token: 0x060020A1 RID: 8353 RVA: 0x0004D824 File Offset: 0x0004C824
		public override string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040007C7 RID: 1991
		public float DistanceToFinish;

		// Token: 0x040007C8 RID: 1992
		public float FractionCompleted;
	}
}
