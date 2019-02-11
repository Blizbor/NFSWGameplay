using System;
using server_packet;
using xsd2cpp;

namespace Victory.Service
{
	// Token: 0x020002F6 RID: 758
	public class LobbyEntrantInfo : IRequestBody
	{
		// Token: 0x060020DF RID: 8415 RVA: 0x0004E3AC File Offset: 0x0004D3AC
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x0400088A RID: 2186
		public int GridIndex;

		// Token: 0x0400088B RID: 2187
		public float Heat;

		// Token: 0x0400088C RID: 2188
		public int Level;

		// Token: 0x0400088D RID: 2189
		public long PersonaId;

		// Token: 0x0400088E RID: 2190
		public LobbyEntrantState State;
	}
}
