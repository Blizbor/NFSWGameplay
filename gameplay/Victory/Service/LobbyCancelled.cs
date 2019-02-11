using System;
using server_packet;
using xsd2cpp;

namespace Victory.Service
{
	// Token: 0x020002FB RID: 763
	public class LobbyCancelled : IRequestBody
	{
		// Token: 0x060020E9 RID: 8425 RVA: 0x0004E498 File Offset: 0x0004D498
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}
	}
}
