using System;

namespace GameCore
{
	// Token: 0x0200024D RID: 589
	internal interface IPortHandler
	{
		// Token: 0x060017DA RID: 6106
		void OnHandleMessage(Message message);

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060017DB RID: 6107
		uint Port { get; }
	}
}
