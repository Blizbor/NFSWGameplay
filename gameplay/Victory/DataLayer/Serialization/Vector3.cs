using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x020002B1 RID: 689
	public class Vector3 : IRequestBody
	{
		// Token: 0x06002067 RID: 8295 RVA: 0x0004D300 File Offset: 0x0004C300
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000746 RID: 1862
		public float X;

		// Token: 0x04000747 RID: 1863
		public float Y;

		// Token: 0x04000748 RID: 1864
		public float Z;
	}
}
