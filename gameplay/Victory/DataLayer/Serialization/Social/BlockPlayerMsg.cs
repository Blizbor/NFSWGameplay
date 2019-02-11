using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization.Social
{
	// Token: 0x020002E3 RID: 739
	public class BlockPlayerMsg : IRequestBody
	{
		// Token: 0x060020C3 RID: 8387 RVA: 0x0004DF10 File Offset: 0x0004CF10
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000844 RID: 2116
		public long userId;
	}
}
