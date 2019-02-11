using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x020000DA RID: 218
	[ExportOnlyCreate(false)]
	public class LivePacketRequester : ExposedCommonBase
	{
		// Token: 0x06000D74 RID: 3444 RVA: 0x000103F0 File Offset: 0x0000F3F0
		public unsafe static LivePacketRequester CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new LivePacketRequester(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x00010413 File Offset: 0x0000F413
		public unsafe LivePacketRequester(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x0001041D File Offset: 0x0000F41D
		protected internal LivePacketRequester(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x00010426 File Offset: 0x0000F426
		protected internal unsafe LivePacketRequester(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000D78 RID: 3448
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1369(void* self);

		// Token: 0x06000D79 RID: 3449 RVA: 0x00010430 File Offset: 0x0000F430
		[DisableExceptionHandling]
		~LivePacketRequester()
		{
			LivePacketRequester._EASharpBinding_1369(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000D7A RID: 3450
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1370(void* _ThisPtr, void* livePacket);

		// Token: 0x06000D7B RID: 3451 RVA: 0x0001046C File Offset: 0x0000F46C
		public void Respond(LivePacket livePacket)
		{
			LivePacketRequester._EASharpBinding_1370(this.mSelf, object.ReferenceEquals(livePacket, null) ? null : livePacket._GetRaw());
		}
	}
}
