using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace Interop
{
	// Token: 0x020000CD RID: 205
	[ExportOnlyCreate(true)]
	public class PowerupUsage : ExposedCommonBase
	{
		// Token: 0x06000C68 RID: 3176 RVA: 0x0000F5CC File Offset: 0x0000E5CC
		public unsafe static PowerupUsage CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new PowerupUsage(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x0000F5EF File Offset: 0x0000E5EF
		public unsafe PowerupUsage(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x0000F5F9 File Offset: 0x0000E5F9
		protected internal PowerupUsage(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x0000F602 File Offset: 0x0000E602
		protected internal unsafe PowerupUsage(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000C6C RID: 3180
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1261();

		// Token: 0x06000C6D RID: 3181 RVA: 0x0000F60C File Offset: 0x0000E60C
		public PowerupUsage() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = PowerupUsage._EASharpBinding_1261();
		}

		// Token: 0x06000C6E RID: 3182
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1262(void* _ThisPtr);

		// Token: 0x06000C6F RID: 3183 RVA: 0x0000F634 File Offset: 0x0000E634
		~PowerupUsage()
		{
			PowerupUsage._EASharpBinding_1262(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000C70 RID: 3184
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1263(void* _ThisPtr, sbyte* value);

		// Token: 0x06000C71 RID: 3185 RVA: 0x0000F670 File Offset: 0x0000E670
		public unsafe void SetIcon(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				PowerupUsage._EASharpBinding_1263(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000C72 RID: 3186
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1264(void* self, uint val);

		// Token: 0x06000C73 RID: 3187
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_1265(void* self);

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000C74 RID: 3188 RVA: 0x0000F6CD File Offset: 0x0000E6CD
		// (set) Token: 0x06000C75 RID: 3189 RVA: 0x0000F6DA File Offset: 0x0000E6DA
		public uint Key
		{
			get
			{
				return PowerupUsage._EASharpBinding_1265(this.mSelf);
			}
			set
			{
				PowerupUsage._EASharpBinding_1264(this.mSelf, value);
			}
		}

		// Token: 0x06000C76 RID: 3190
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1266(void* self, uint val);

		// Token: 0x06000C77 RID: 3191
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_1267(void* self);

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000C78 RID: 3192 RVA: 0x0000F6E8 File Offset: 0x0000E6E8
		// (set) Token: 0x06000C79 RID: 3193 RVA: 0x0000F6F5 File Offset: 0x0000E6F5
		public uint Count
		{
			get
			{
				return PowerupUsage._EASharpBinding_1267(this.mSelf);
			}
			set
			{
				PowerupUsage._EASharpBinding_1266(this.mSelf, value);
			}
		}
	}
}
