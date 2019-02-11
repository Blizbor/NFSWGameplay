using System;
using EASharp;

namespace GameCore.Security
{
	// Token: 0x02000206 RID: 518
	[Export]
	public class FraudDetection
	{
		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060015A9 RID: 5545 RVA: 0x00026274 File Offset: 0x00025274
		// (set) Token: 0x060015AA RID: 5546 RVA: 0x0002627C File Offset: 0x0002527C
		public int Checksum { get; set; }

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060015AB RID: 5547 RVA: 0x00026285 File Offset: 0x00025285
		// (set) Token: 0x060015AC RID: 5548 RVA: 0x0002628D File Offset: 0x0002528D
		public int IntValue1 { get; set; }

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060015AD RID: 5549 RVA: 0x00026296 File Offset: 0x00025296
		// (set) Token: 0x060015AE RID: 5550 RVA: 0x0002629E File Offset: 0x0002529E
		public int IntValue2 { get; set; }

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060015AF RID: 5551 RVA: 0x000262A7 File Offset: 0x000252A7
		// (set) Token: 0x060015B0 RID: 5552 RVA: 0x000262AF File Offset: 0x000252AF
		public int IntValue3 { get; set; }

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060015B1 RID: 5553 RVA: 0x000262B8 File Offset: 0x000252B8
		// (set) Token: 0x060015B2 RID: 5554 RVA: 0x000262C0 File Offset: 0x000252C0
		public int IntValue4 { get; set; }

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060015B3 RID: 5555 RVA: 0x000262C9 File Offset: 0x000252C9
		// (set) Token: 0x060015B4 RID: 5556 RVA: 0x000262D1 File Offset: 0x000252D1
		public bool IsEncrypted { get; set; }

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060015B5 RID: 5557 RVA: 0x000262DA File Offset: 0x000252DA
		// (set) Token: 0x060015B6 RID: 5558 RVA: 0x000262E2 File Offset: 0x000252E2
		public string ModuleName { get; set; }

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060015B7 RID: 5559 RVA: 0x000262EB File Offset: 0x000252EB
		// (set) Token: 0x060015B8 RID: 5560 RVA: 0x000262F3 File Offset: 0x000252F3
		public string ModulePath { get; set; }

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060015B9 RID: 5561 RVA: 0x000262FC File Offset: 0x000252FC
		// (set) Token: 0x060015BA RID: 5562 RVA: 0x00026304 File Offset: 0x00025304
		public string ModuleValue { get; set; }

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060015BB RID: 5563 RVA: 0x0002630D File Offset: 0x0002530D
		// (set) Token: 0x060015BC RID: 5564 RVA: 0x00026315 File Offset: 0x00025315
		public string StringValue1 { get; set; }

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060015BD RID: 5565 RVA: 0x0002631E File Offset: 0x0002531E
		// (set) Token: 0x060015BE RID: 5566 RVA: 0x00026326 File Offset: 0x00025326
		public string StringValue2 { get; set; }
	}
}
