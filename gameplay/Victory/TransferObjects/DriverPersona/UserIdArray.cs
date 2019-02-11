using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.TransferObjects.DriverPersona
{
	// Token: 0x02000332 RID: 818
	public class UserIdArray : IRequestBody
	{
		// Token: 0x06002151 RID: 8529 RVA: 0x0004EF64 File Offset: 0x0004DF64
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040009A9 RID: 2473
		public List<long> UserIds;
	}
}
