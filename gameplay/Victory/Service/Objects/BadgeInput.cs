using System;
using server_packet;
using xsd2cpp;

namespace Victory.Service.Objects
{
	// Token: 0x0200031C RID: 796
	public class BadgeInput : IRequestBody
	{
		// Token: 0x0600212B RID: 8491 RVA: 0x0004EB70 File Offset: 0x0004DB70
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x0400096B RID: 2411
		public int BadgeDefinitionId;

		// Token: 0x0400096C RID: 2412
		public short SlotId;
	}
}
