using System;
using server_packet;
using xsd2cpp;

namespace Victory.Service
{
	// Token: 0x02000306 RID: 774
	public class ServerTime : IRequestBody
	{
		// Token: 0x060020FF RID: 8447 RVA: 0x0004E76C File Offset: 0x0004D76C
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040008DB RID: 2267
		public DateTime Current = DateTime.FromBinary(0L);
	}
}
