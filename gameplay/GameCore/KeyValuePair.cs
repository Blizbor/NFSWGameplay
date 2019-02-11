using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace GameCore
{
	// Token: 0x02000052 RID: 82
	[ExportOnlyCreate(true)]
	public class KeyValuePair : ExposedCommonBase
	{
		// Token: 0x060003B0 RID: 944 RVA: 0x00005B0C File Offset: 0x00004B0C
		public unsafe static KeyValuePair CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new KeyValuePair(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00005B2F File Offset: 0x00004B2F
		public unsafe KeyValuePair(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00005B39 File Offset: 0x00004B39
		protected internal KeyValuePair(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00005B42 File Offset: 0x00004B42
		protected internal unsafe KeyValuePair(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060003B4 RID: 948
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_375(void* self);

		// Token: 0x060003B5 RID: 949 RVA: 0x00005B4C File Offset: 0x00004B4C
		[DisableExceptionHandling]
		~KeyValuePair()
		{
			KeyValuePair._EASharpBinding_375(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060003B6 RID: 950
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_376(void* self, sbyte* val);

		// Token: 0x060003B7 RID: 951
		[DllImport("<internal>")]
		private unsafe static extern sbyte* _EASharpBinding_377(void* self);

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x00005B88 File Offset: 0x00004B88
		// (set) Token: 0x060003B9 RID: 953 RVA: 0x00005B9C File Offset: 0x00004B9C
		public unsafe string KeyString
		{
			get
			{
				return InternalUtil.ConvertFromCString(KeyValuePair._EASharpBinding_377(this.mSelf));
			}
			set
			{
				int byteCount = Encoding.ASCII.GetByteCount(value);
				byte[] array = new byte[byteCount + 1];
				Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
				array[byteCount] = 0;
				fixed (byte* ptr = array)
				{
					KeyValuePair._EASharpBinding_376(this.mSelf, (sbyte*)ptr);
				}
			}
		}

		// Token: 0x060003BA RID: 954
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_378(void* self, uint val);

		// Token: 0x060003BB RID: 955
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_379(void* self);

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060003BC RID: 956 RVA: 0x00005BF9 File Offset: 0x00004BF9
		// (set) Token: 0x060003BD RID: 957 RVA: 0x00005C06 File Offset: 0x00004C06
		public uint KeyHash32
		{
			get
			{
				return KeyValuePair._EASharpBinding_379(this.mSelf);
			}
			set
			{
				KeyValuePair._EASharpBinding_378(this.mSelf, value);
			}
		}

		// Token: 0x060003BE RID: 958
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_380(void* self, float val);

		// Token: 0x060003BF RID: 959
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_381(void* self);

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x00005C14 File Offset: 0x00004C14
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x00005C21 File Offset: 0x00004C21
		public float Value
		{
			get
			{
				return KeyValuePair._EASharpBinding_381(this.mSelf);
			}
			set
			{
				KeyValuePair._EASharpBinding_380(this.mSelf, value);
			}
		}
	}
}
