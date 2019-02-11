using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization.Event
{
	// Token: 0x020002CC RID: 716
	public class DragEntrantResult : EntrantResult, IRequestBody
	{
		// Token: 0x0600209D RID: 8349 RVA: 0x0004D7E4 File Offset: 0x0004C7E4
		public override string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040007C5 RID: 1989
		public float TopSpeed;
	}
}
