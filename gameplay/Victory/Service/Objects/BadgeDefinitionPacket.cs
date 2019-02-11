using System;
using server_packet;
using xsd2cpp;

namespace Victory.Service.Objects
{
	// Token: 0x02000317 RID: 791
	public class BadgeDefinitionPacket : IRequestBody
	{
		// Token: 0x06002121 RID: 8481 RVA: 0x0004EA50 File Offset: 0x0004DA50
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x0400094F RID: 2383
		public string Background = "";

		// Token: 0x04000950 RID: 2384
		public int BadgeDefinitionId;

		// Token: 0x04000951 RID: 2385
		public string Border = "";

		// Token: 0x04000952 RID: 2386
		public string Description = "";

		// Token: 0x04000953 RID: 2387
		public string Icon = "";

		// Token: 0x04000954 RID: 2388
		public string Name = "";
	}
}
