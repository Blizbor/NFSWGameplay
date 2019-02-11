using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;
using GameCore;

namespace Interop
{
	// Token: 0x020000C0 RID: 192
	[ExportOnlyCreate(true)]
	public class WebKitLoadInfo : ISerializable
	{
		// Token: 0x06000B4E RID: 2894 RVA: 0x0000E3C8 File Offset: 0x0000D3C8
		public new unsafe static WebKitLoadInfo CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new WebKitLoadInfo(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x0000E3EB File Offset: 0x0000D3EB
		public unsafe WebKitLoadInfo(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x0000E3F5 File Offset: 0x0000D3F5
		protected internal WebKitLoadInfo(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x0000E3FE File Offset: 0x0000D3FE
		protected internal unsafe WebKitLoadInfo(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000B52 RID: 2898
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1146();

		// Token: 0x06000B53 RID: 2899 RVA: 0x0000E408 File Offset: 0x0000D408
		public WebKitLoadInfo() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = WebKitLoadInfo._EASharpBinding_1146();
		}

		// Token: 0x06000B54 RID: 2900
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1147(void* _ThisPtr);

		// Token: 0x06000B55 RID: 2901 RVA: 0x0000E430 File Offset: 0x0000D430
		~WebKitLoadInfo()
		{
			WebKitLoadInfo._EASharpBinding_1147(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000B56 RID: 2902
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1148(void* _ThisPtr);

		// Token: 0x06000B57 RID: 2903 RVA: 0x0000E46C File Offset: 0x0000D46C
		public virtual void Reset()
		{
			WebKitLoadInfo._EASharpBinding_1148(this.mSelf);
		}

		// Token: 0x06000B58 RID: 2904
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1149(void* _ThisPtr, sbyte* value);

		// Token: 0x06000B59 RID: 2905 RVA: 0x0000E47C File Offset: 0x0000D47C
		public unsafe void SetmURI(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				WebKitLoadInfo._EASharpBinding_1149(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000B5A RID: 2906
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1150(void* _ThisPtr, sbyte* value);

		// Token: 0x06000B5B RID: 2907 RVA: 0x0000E4DC File Offset: 0x0000D4DC
		public unsafe void SetmResourceURI(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				WebKitLoadInfo._EASharpBinding_1150(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000B5C RID: 2908
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1151(void* _ThisPtr, sbyte* value);

		// Token: 0x06000B5D RID: 2909 RVA: 0x0000E53C File Offset: 0x0000D53C
		public unsafe void SetmPageTitle(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				WebKitLoadInfo._EASharpBinding_1151(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000B5E RID: 2910
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1152(void* self, int val);

		// Token: 0x06000B5F RID: 2911
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1153(void* self);

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000B60 RID: 2912 RVA: 0x0000E599 File Offset: 0x0000D599
		// (set) Token: 0x06000B61 RID: 2913 RVA: 0x0000E5A6 File Offset: 0x0000D5A6
		public LoadEventType mLET
		{
			get
			{
				return (LoadEventType)WebKitLoadInfo._EASharpBinding_1153(this.mSelf);
			}
			set
			{
				WebKitLoadInfo._EASharpBinding_1152(this.mSelf, (int)value);
			}
		}

		// Token: 0x06000B62 RID: 2914
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1154(void* self, bool val);

		// Token: 0x06000B63 RID: 2915
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_1155(void* self);

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000B64 RID: 2916 RVA: 0x0000E5B4 File Offset: 0x0000D5B4
		// (set) Token: 0x06000B65 RID: 2917 RVA: 0x0000E5C1 File Offset: 0x0000D5C1
		public bool mbStarted
		{
			get
			{
				return WebKitLoadInfo._EASharpBinding_1155(this.mSelf);
			}
			set
			{
				WebKitLoadInfo._EASharpBinding_1154(this.mSelf, value);
			}
		}

		// Token: 0x06000B66 RID: 2918
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1156(void* self, bool val);

		// Token: 0x06000B67 RID: 2919
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_1157(void* self);

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000B68 RID: 2920 RVA: 0x0000E5CF File Offset: 0x0000D5CF
		// (set) Token: 0x06000B69 RID: 2921 RVA: 0x0000E5DC File Offset: 0x0000D5DC
		public bool mbCompleted
		{
			get
			{
				return WebKitLoadInfo._EASharpBinding_1157(this.mSelf);
			}
			set
			{
				WebKitLoadInfo._EASharpBinding_1156(this.mSelf, value);
			}
		}

		// Token: 0x06000B6A RID: 2922
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1158(void* self, int val);

		// Token: 0x06000B6B RID: 2923
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1159(void* self);

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000B6C RID: 2924 RVA: 0x0000E5EA File Offset: 0x0000D5EA
		// (set) Token: 0x06000B6D RID: 2925 RVA: 0x0000E5F7 File Offset: 0x0000D5F7
		public int mContentLength
		{
			get
			{
				return WebKitLoadInfo._EASharpBinding_1159(this.mSelf);
			}
			set
			{
				WebKitLoadInfo._EASharpBinding_1158(this.mSelf, value);
			}
		}

		// Token: 0x06000B6E RID: 2926
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1160(void* self, double val);

		// Token: 0x06000B6F RID: 2927
		[DllImport("<internal>")]
		private unsafe static extern double _EASharpBinding_1161(void* self);

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000B70 RID: 2928 RVA: 0x0000E605 File Offset: 0x0000D605
		// (set) Token: 0x06000B71 RID: 2929 RVA: 0x0000E612 File Offset: 0x0000D612
		public double mProgressEstimation
		{
			get
			{
				return WebKitLoadInfo._EASharpBinding_1161(this.mSelf);
			}
			set
			{
				WebKitLoadInfo._EASharpBinding_1160(this.mSelf, value);
			}
		}

		// Token: 0x06000B72 RID: 2930
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1162(void* self, int val);

		// Token: 0x06000B73 RID: 2931
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1163(void* self);

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000B74 RID: 2932 RVA: 0x0000E620 File Offset: 0x0000D620
		// (set) Token: 0x06000B75 RID: 2933 RVA: 0x0000E62D File Offset: 0x0000D62D
		public int mLastChangedTime
		{
			get
			{
				return WebKitLoadInfo._EASharpBinding_1163(this.mSelf);
			}
			set
			{
				WebKitLoadInfo._EASharpBinding_1162(this.mSelf, value);
			}
		}

		// Token: 0x06000B76 RID: 2934
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1164(void* self, int val);

		// Token: 0x06000B77 RID: 2935
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1165(void* self);

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000B78 RID: 2936 RVA: 0x0000E63B File Offset: 0x0000D63B
		// (set) Token: 0x06000B79 RID: 2937 RVA: 0x0000E648 File Offset: 0x0000D648
		public int mStatusCode
		{
			get
			{
				return WebKitLoadInfo._EASharpBinding_1165(this.mSelf);
			}
			set
			{
				WebKitLoadInfo._EASharpBinding_1164(this.mSelf, value);
			}
		}
	}
}
