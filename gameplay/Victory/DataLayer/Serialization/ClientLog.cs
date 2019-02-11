using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x02000296 RID: 662
	public class ClientLog : IRequestBody
	{
		// Token: 0x06002031 RID: 8241 RVA: 0x0004CDEC File Offset: 0x0004BDEC
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040006A6 RID: 1702
		public DateTime date = DateTime.FromBinary(0L);

		// Token: 0x040006A7 RID: 1703
		public string message = "";
	}
}
