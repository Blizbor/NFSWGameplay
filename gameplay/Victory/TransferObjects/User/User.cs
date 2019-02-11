using System;
using server_packet;
using xsd2cpp;

namespace Victory.TransferObjects.User
{
	// Token: 0x0200033A RID: 826
	public class User : IRequestBody
	{
		// Token: 0x0600215D RID: 8541 RVA: 0x0004F294 File Offset: 0x0004E294
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040009DE RID: 2526
		public string address1 = "";

		// Token: 0x040009DF RID: 2527
		public string address2 = "";

		// Token: 0x040009E0 RID: 2528
		public string country = "";

		// Token: 0x040009E1 RID: 2529
		public string dateCreated = "";

		// Token: 0x040009E2 RID: 2530
		public string dob = "";

		// Token: 0x040009E3 RID: 2531
		public string email = "";

		// Token: 0x040009E4 RID: 2532
		public string emailStatus = "";

		// Token: 0x040009E5 RID: 2533
		public string firstName = "";

		// Token: 0x040009E6 RID: 2534
		public bool fullGameAccess;

		// Token: 0x040009E7 RID: 2535
		public string gender = "";

		// Token: 0x040009E8 RID: 2536
		public string idDigits = "";

		// Token: 0x040009E9 RID: 2537
		public bool isComplete;

		// Token: 0x040009EA RID: 2538
		public string landlinePhone = "";

		// Token: 0x040009EB RID: 2539
		public string language = "";

		// Token: 0x040009EC RID: 2540
		public string lastAuthDate = "";

		// Token: 0x040009ED RID: 2541
		public string lastName = "";

		// Token: 0x040009EE RID: 2542
		public string mobile = "";

		// Token: 0x040009EF RID: 2543
		public string nickname = "";

		// Token: 0x040009F0 RID: 2544
		public string postalCode = "";

		// Token: 0x040009F1 RID: 2545
		public string realName = "";

		// Token: 0x040009F2 RID: 2546
		public string reasonCode = "";

		// Token: 0x040009F3 RID: 2547
		public long remoteUserId;

		// Token: 0x040009F4 RID: 2548
		public string securityToken = "";

		// Token: 0x040009F5 RID: 2549
		public string starterPackEntitlementTag = "";

		// Token: 0x040009F6 RID: 2550
		public string status = "";

		// Token: 0x040009F7 RID: 2551
		public bool subscribeMsg;

		// Token: 0x040009F8 RID: 2552
		public string tosVersion = "";

		// Token: 0x040009F9 RID: 2553
		public long userId;

		// Token: 0x040009FA RID: 2554
		public string username = "";
	}
}
