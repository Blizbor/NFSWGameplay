using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization.PowerUp
{
	// Token: 0x020002E0 RID: 736
	public class PowerupActivated : IRequestBody
	{
		// Token: 0x060020BD RID: 8381 RVA: 0x0004DEB0 File Offset: 0x0004CEB0
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x0400083E RID: 2110
		public int Count;

		// Token: 0x0400083F RID: 2111
		public int Id;

		// Token: 0x04000840 RID: 2112
		public long PersonaId;

		// Token: 0x04000841 RID: 2113
		public long TargetPersonaId;
	}
}
