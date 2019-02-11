using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.TransferObjects.DriverPersona
{
	// Token: 0x0200032C RID: 812
	public class PersonaIdArray : IRequestBody
	{
		// Token: 0x06002145 RID: 8517 RVA: 0x0004EE80 File Offset: 0x0004DE80
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000998 RID: 2456
		public List<long> PersonaIds;
	}
}
