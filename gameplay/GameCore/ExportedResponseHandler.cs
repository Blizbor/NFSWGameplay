using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace GameCore
{
	// Token: 0x0200002D RID: 45
	[ExportOnlyCreate(false)]
	public class ExportedResponseHandler : ExposedCommonBase
	{
		// Token: 0x060000E6 RID: 230 RVA: 0x00002F08 File Offset: 0x00001F08
		public unsafe static ExportedResponseHandler CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new ExportedResponseHandler(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002F2B File Offset: 0x00001F2B
		public unsafe ExportedResponseHandler(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002F35 File Offset: 0x00001F35
		protected internal ExportedResponseHandler(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002F3E File Offset: 0x00001F3E
		protected internal unsafe ExportedResponseHandler(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060000EA RID: 234
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_54(object responseHandler);

		// Token: 0x060000EB RID: 235 RVA: 0x00002F48 File Offset: 0x00001F48
		public ExportedResponseHandler(ResponseHandler responseHandler) : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = ExportedResponseHandler._EASharpBinding_54(responseHandler);
		}

		// Token: 0x060000EC RID: 236
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_55(void* _ThisPtr);

		// Token: 0x060000ED RID: 237 RVA: 0x00002F70 File Offset: 0x00001F70
		~ExportedResponseHandler()
		{
			ExportedResponseHandler._EASharpBinding_55(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060000EE RID: 238
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_56(void* _ThisPtr, sbyte* pResponse);

		// Token: 0x060000EF RID: 239 RVA: 0x00002FAC File Offset: 0x00001FAC
		public unsafe virtual void OnSucceeded(string pResponse)
		{
			int byteCount = Encoding.ASCII.GetByteCount(pResponse);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(pResponse, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				ExportedResponseHandler._EASharpBinding_56(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x060000F0 RID: 240
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_57(void* _ThisPtr, int status);

		// Token: 0x060000F1 RID: 241 RVA: 0x00003009 File Offset: 0x00002009
		public virtual void OnFailed(int status)
		{
			ExportedResponseHandler._EASharpBinding_57(this.mSelf, status);
		}

		// Token: 0x060000F2 RID: 242
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_58(void* _ThisPtr);

		// Token: 0x060000F3 RID: 243 RVA: 0x00003018 File Offset: 0x00002018
		public virtual bool HasSucceededFunction()
		{
			return ExportedResponseHandler._EASharpBinding_58(this.mSelf);
		}

		// Token: 0x060000F4 RID: 244
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_59(void* _ThisPtr);

		// Token: 0x060000F5 RID: 245 RVA: 0x00003034 File Offset: 0x00002034
		public virtual bool HasFailedFunction()
		{
			return ExportedResponseHandler._EASharpBinding_59(this.mSelf);
		}

		// Token: 0x060000F6 RID: 246
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_60(void* _ThisPtr);

		// Token: 0x060000F7 RID: 247 RVA: 0x0000304E File Offset: 0x0000204E
		public virtual void Release()
		{
			ExportedResponseHandler._EASharpBinding_60(this.mSelf);
		}
	}
}
