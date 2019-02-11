using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization.Social
{
	// Token: 0x020002E8 RID: 744
	public class SocialNetworkInfo : IRequestBody
	{
		// Token: 0x060020CD RID: 8397 RVA: 0x0004DFB0 File Offset: 0x0004CFB0
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000851 RID: 2129
		public string facebookName = "";
	}
}
