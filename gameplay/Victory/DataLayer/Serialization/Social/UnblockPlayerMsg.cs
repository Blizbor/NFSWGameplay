using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization.Social
{
	// Token: 0x020002E1 RID: 737
	public class UnblockPlayerMsg : IRequestBody
	{
		// Token: 0x060020BF RID: 8383 RVA: 0x0004DED0 File Offset: 0x0004CED0
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000842 RID: 2114
		public long userId;
	}
}
