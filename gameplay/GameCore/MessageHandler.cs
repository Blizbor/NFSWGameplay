using System;

namespace GameCore
{
	// Token: 0x02000244 RID: 580
	// (Invoke) Token: 0x06001799 RID: 6041
	public delegate void MessageHandler<T>(T message) where T : Message;
}
