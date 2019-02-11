using System;
using server_packet;
using xsd2cpp;

namespace Victory.TransferObjects.DriverPersona
{
	// Token: 0x0200032E RID: 814
	public class PersonaMotto : IRequestBody
	{
		// Token: 0x06002149 RID: 8521 RVA: 0x0004EEC0 File Offset: 0x0004DEC0
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x0400099C RID: 2460
		public string message = "";

		// Token: 0x0400099D RID: 2461
		public long personaId;
	}
}
