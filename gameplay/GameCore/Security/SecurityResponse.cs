using System;
using EASharp;

namespace GameCore.Security
{
	// Token: 0x02000209 RID: 521
	[Export]
	public class SecurityResponse
	{
		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060015D6 RID: 5590 RVA: 0x00026412 File Offset: 0x00025412
		// (set) Token: 0x060015D7 RID: 5591 RVA: 0x0002641A File Offset: 0x0002541A
		public string ChallengeId { get; set; }

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060015D8 RID: 5592 RVA: 0x00026423 File Offset: 0x00025423
		// (set) Token: 0x060015D9 RID: 5593 RVA: 0x0002642B File Offset: 0x0002542B
		public long Result { get; set; }
	}
}
