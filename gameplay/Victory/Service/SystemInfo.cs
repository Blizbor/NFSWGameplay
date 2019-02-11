using System;
using server_packet;
using xsd2cpp;

namespace Victory.Service
{
	// Token: 0x02000301 RID: 769
	public class SystemInfo : IRequestBody
	{
		// Token: 0x060020F5 RID: 8437 RVA: 0x0004E558 File Offset: 0x0004D558
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040008B5 RID: 2229
		public string Branch = "";

		// Token: 0x040008B6 RID: 2230
		public string ChangeList = "";

		// Token: 0x040008B7 RID: 2231
		public string ClientVersion = "";

		// Token: 0x040008B8 RID: 2232
		public bool ClientVersionCheck;

		// Token: 0x040008B9 RID: 2233
		public string Deployed = "";

		// Token: 0x040008BA RID: 2234
		public bool EntitlementsToDownload;

		// Token: 0x040008BB RID: 2235
		public bool ForcePermanentSession;

		// Token: 0x040008BC RID: 2236
		public string JidPrepender = "";

		// Token: 0x040008BD RID: 2237
		public string LauncherServiceUrl = "";

		// Token: 0x040008BE RID: 2238
		public string NucleusNamespace = "";

		// Token: 0x040008BF RID: 2239
		public string NucleusNamespaceWeb = "";

		// Token: 0x040008C0 RID: 2240
		public int PersonaCacheTimeout;

		// Token: 0x040008C1 RID: 2241
		public string PortalDomain = "";

		// Token: 0x040008C2 RID: 2242
		public string PortalSecureDomain = "";

		// Token: 0x040008C3 RID: 2243
		public string PortalStoreFailurePage = "";

		// Token: 0x040008C4 RID: 2244
		public string PortalTimeOut = "";

		// Token: 0x040008C5 RID: 2245
		public string ShardName = "";

		// Token: 0x040008C6 RID: 2246
		public DateTime Time = DateTime.FromBinary(0L);

		// Token: 0x040008C7 RID: 2247
		public string Version = "";
	}
}
