using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace GameCore
{
	// Token: 0x02000050 RID: 80
	[ExportOnlyCreate(false)]
	public class InternalTickKeeper : ExposedCommonBase
	{
		// Token: 0x0600038A RID: 906 RVA: 0x00005870 File Offset: 0x00004870
		public unsafe static InternalTickKeeper CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new InternalTickKeeper(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00005893 File Offset: 0x00004893
		public unsafe InternalTickKeeper(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0000589D File Offset: 0x0000489D
		protected internal InternalTickKeeper(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x0600038D RID: 909 RVA: 0x000058A6 File Offset: 0x000048A6
		protected internal unsafe InternalTickKeeper(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600038E RID: 910
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_360(void* self);

		// Token: 0x0600038F RID: 911 RVA: 0x000058B0 File Offset: 0x000048B0
		[DisableExceptionHandling]
		~InternalTickKeeper()
		{
			InternalTickKeeper._EASharpBinding_360(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000390 RID: 912
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_361(sbyte* name);

		// Token: 0x06000391 RID: 913 RVA: 0x000058EC File Offset: 0x000048EC
		public unsafe InternalTickKeeper(string name) : base(default(ExposeTag_NoInitOwned))
		{
			int byteCount = Encoding.ASCII.GetByteCount(name);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(name, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				this.mSelf = InternalTickKeeper._EASharpBinding_361((sbyte*)ptr);
			}
		}

		// Token: 0x06000392 RID: 914
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_362(void* _ThisPtr, float time);

		// Token: 0x06000393 RID: 915 RVA: 0x0000595B File Offset: 0x0000495B
		public void Record(float time)
		{
			InternalTickKeeper._EASharpBinding_362(this.mSelf, time);
		}
	}
}
