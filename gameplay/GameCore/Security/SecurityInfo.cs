using System;
using EASharp;

namespace GameCore.Security
{
	// Token: 0x02000208 RID: 520
	[Export]
	public class SecurityInfo
	{
		// Token: 0x060015CD RID: 5581 RVA: 0x000263A5 File Offset: 0x000253A5
		public SecurityInfo()
		{
			this.FraudDetection = new FraudDetection();
			this.SecurityResponse = new SecurityResponse();
			this.PhysicsMetrics = new PhysicsMetrics();
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060015CE RID: 5582 RVA: 0x000263CE File Offset: 0x000253CE
		// (set) Token: 0x060015CF RID: 5583 RVA: 0x000263D6 File Offset: 0x000253D6
		public long CustomizationDataId { get; set; }

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060015D0 RID: 5584 RVA: 0x000263DF File Offset: 0x000253DF
		// (set) Token: 0x060015D1 RID: 5585 RVA: 0x000263E7 File Offset: 0x000253E7
		public FraudDetection FraudDetection { get; set; }

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060015D2 RID: 5586 RVA: 0x000263F0 File Offset: 0x000253F0
		// (set) Token: 0x060015D3 RID: 5587 RVA: 0x000263F8 File Offset: 0x000253F8
		public SecurityResponse SecurityResponse { get; set; }

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060015D4 RID: 5588 RVA: 0x00026401 File Offset: 0x00025401
		// (set) Token: 0x060015D5 RID: 5589 RVA: 0x00026409 File Offset: 0x00025409
		public PhysicsMetrics PhysicsMetrics { get; set; }
	}
}
