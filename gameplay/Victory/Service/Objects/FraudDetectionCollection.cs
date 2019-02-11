using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.Service.Objects
{
	// Token: 0x02000323 RID: 803
	public class FraudDetectionCollection : IRequestBody
	{
		// Token: 0x06002139 RID: 8505 RVA: 0x0004ECA0 File Offset: 0x0004DCA0
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x0400097E RID: 2430
		public List<FraudDetection> FraudDetectionLogs;
	}
}
