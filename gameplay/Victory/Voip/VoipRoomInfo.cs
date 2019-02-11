using System;
using server_packet;
using xsd2cpp;

namespace Victory.Voip
{
	// Token: 0x0200033E RID: 830
	public class VoipRoomInfo : IRequestBody
	{
		// Token: 0x06002165 RID: 8549 RVA: 0x0004F440 File Offset: 0x0004E440
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000A0F RID: 2575
		public string Token = "";
	}
}
