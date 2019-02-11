using System;

namespace GameCore
{
	// Token: 0x0200001F RID: 31
	public enum LoadEventType
	{
		// Token: 0x040000BE RID: 190
		kLETNone,
		// Token: 0x040000BF RID: 191
		kLETPageRequest,
		// Token: 0x040000C0 RID: 192
		kLETPageRedirect,
		// Token: 0x040000C1 RID: 193
		kLETResponseReceived,
		// Token: 0x040000C2 RID: 194
		kLETContentLengthReceived,
		// Token: 0x040000C3 RID: 195
		kLETLoadCompleted,
		// Token: 0x040000C4 RID: 196
		kLETLoadFailed,
		// Token: 0x040000C5 RID: 197
		kLETWillClose,
		// Token: 0x040000C6 RID: 198
		kLETLoadStarted,
		// Token: 0x040000C7 RID: 199
		kLETTitleReceived,
		// Token: 0x040000C8 RID: 200
		kLETLoadCommitted,
		// Token: 0x040000C9 RID: 201
		kLETLayoutCompleted,
		// Token: 0x040000CA RID: 202
		kLETWillShow,
		// Token: 0x040000CB RID: 203
		kLETLoadProgressUpdate
	}
}
