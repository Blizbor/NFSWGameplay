using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x020002A1 RID: 673
	public class PerformancePartTrans : IRequestBody
	{
		// Token: 0x06002047 RID: 8263 RVA: 0x0004CFF0 File Offset: 0x0004BFF0
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040006DD RID: 1757
		public int PerformancePartAttribHash;
	}
}
