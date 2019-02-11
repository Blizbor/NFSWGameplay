using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization.Social
{
	// Token: 0x020002E5 RID: 741
	public class SocialSettings : IRequestBody
	{
		// Token: 0x060020C7 RID: 8391 RVA: 0x0004DF50 File Offset: 0x0004CF50
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000847 RID: 2119
		public bool AppearOffline;

		// Token: 0x04000848 RID: 2120
		public int DeclineGroupInvite;

		// Token: 0x04000849 RID: 2121
		public bool DeclineIncommingFriendRequests;

		// Token: 0x0400084A RID: 2122
		public int DeclinePrivateInvite;

		// Token: 0x0400084B RID: 2123
		public bool HideOfflineFriends;

		// Token: 0x0400084C RID: 2124
		public bool ShowNewsOnSignIn;

		// Token: 0x0400084D RID: 2125
		public bool ShowOnlyPlayersInSameChatChannel;
	}
}
