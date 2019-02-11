using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x02000024 RID: 36
	[ExportOnlyCreate(false)]
	public class Attribute : ExposedCommonBase
	{
		// Token: 0x06000012 RID: 18 RVA: 0x000021A8 File Offset: 0x000011A8
		public unsafe static Attribute CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new Attribute(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000021CB File Offset: 0x000011CB
		public unsafe Attribute(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000021D5 File Offset: 0x000011D5
		protected internal Attribute(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000021DE File Offset: 0x000011DE
		protected internal unsafe Attribute(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000016 RID: 22
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1(void* self);

		// Token: 0x06000017 RID: 23 RVA: 0x000021E8 File Offset: 0x000011E8
		[DisableExceptionHandling]
		~Attribute()
		{
			Attribute._EASharpBinding_1(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000018 RID: 24
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_2(void* _ThisPtr);

		// Token: 0x06000019 RID: 25 RVA: 0x00002224 File Offset: 0x00001224
		public bool IsValid()
		{
			return Attribute._EASharpBinding_2(this.mSelf);
		}

		// Token: 0x0600001A RID: 26
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_3(void* _ThisPtr);

		// Token: 0x0600001B RID: 27 RVA: 0x00002240 File Offset: 0x00001240
		public bool IsInherited()
		{
			return Attribute._EASharpBinding_3(this.mSelf);
		}

		// Token: 0x0600001C RID: 28
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_4(void* _ThisPtr);

		// Token: 0x0600001D RID: 29 RVA: 0x0000225C File Offset: 0x0000125C
		public bool IsMutable()
		{
			return Attribute._EASharpBinding_4(this.mSelf);
		}

		// Token: 0x0600001E RID: 30
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_5(void* _ThisPtr);

		// Token: 0x0600001F RID: 31 RVA: 0x00002278 File Offset: 0x00001278
		public uint GetKey()
		{
			return Attribute._EASharpBinding_5(this.mSelf);
		}

		// Token: 0x06000020 RID: 32
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_7(void* _ThisPtr);

		// Token: 0x06000021 RID: 33 RVA: 0x00002294 File Offset: 0x00001294
		public uint GetSize()
		{
			return Attribute._EASharpBinding_7(this.mSelf);
		}

		// Token: 0x06000022 RID: 34
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_8(void* _ThisPtr);

		// Token: 0x06000023 RID: 35 RVA: 0x000022B0 File Offset: 0x000012B0
		public uint GetLength()
		{
			return Attribute._EASharpBinding_8(this.mSelf);
		}

		// Token: 0x06000024 RID: 36
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_9(void* _ThisPtr, uint len);

		// Token: 0x06000025 RID: 37 RVA: 0x000022CC File Offset: 0x000012CC
		public bool SetLength(uint len)
		{
			return Attribute._EASharpBinding_9(this.mSelf, len);
		}

		// Token: 0x06000026 RID: 38
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_10(void* _ThisPtr, uint index);

		// Token: 0x06000027 RID: 39 RVA: 0x000022E8 File Offset: 0x000012E8
		public unsafe void* Get(uint index)
		{
			return Attribute._EASharpBinding_10(this.mSelf, index);
		}

		// Token: 0x06000028 RID: 40
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_11(void* _ThisPtr, uint index, void* result);

		// Token: 0x06000029 RID: 41 RVA: 0x00002304 File Offset: 0x00001304
		public unsafe bool Get(uint index, void* result)
		{
			return Attribute._EASharpBinding_11(this.mSelf, index, result);
		}

		// Token: 0x0600002A RID: 42
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_12(void* _ThisPtr, uint index, void* data);

		// Token: 0x0600002B RID: 43 RVA: 0x00002320 File Offset: 0x00001320
		public unsafe bool Set(uint index, void* data)
		{
			return Attribute._EASharpBinding_12(this.mSelf, index, data);
		}
	}
}
