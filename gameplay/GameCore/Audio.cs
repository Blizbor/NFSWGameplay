using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace GameCore
{
	// Token: 0x02000025 RID: 37
	[ExportOnlyCreate(false)]
	public class Audio : ExposedCommonBase
	{
		// Token: 0x0600002C RID: 44 RVA: 0x0000233C File Offset: 0x0000133C
		public unsafe static Audio CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new Audio(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000235F File Offset: 0x0000135F
		public unsafe Audio(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002369 File Offset: 0x00001369
		protected internal Audio(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002372 File Offset: 0x00001372
		protected internal unsafe Audio(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000030 RID: 48
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_13(void* self);

		// Token: 0x06000031 RID: 49 RVA: 0x0000237C File Offset: 0x0000137C
		[DisableExceptionHandling]
		~Audio()
		{
			Audio._EASharpBinding_13(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000032 RID: 50
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_14();

		// Token: 0x06000033 RID: 51 RVA: 0x000023B8 File Offset: 0x000013B8
		public static void CommitAssets()
		{
			Audio._EASharpBinding_14();
		}

		// Token: 0x06000034 RID: 52
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_15(void* opponent);

		// Token: 0x06000035 RID: 53 RVA: 0x000023BF File Offset: 0x000013BF
		public static void EntrantBusted(InternalOpponent opponent)
		{
			Audio._EASharpBinding_15(object.ReferenceEquals(opponent, null) ? null : opponent._GetRaw());
		}

		// Token: 0x06000036 RID: 54
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_16(sbyte* pSoundString);

		// Token: 0x06000037 RID: 55 RVA: 0x000023DC File Offset: 0x000013DC
		public unsafe static void PlaySound(string pSoundString)
		{
			int byteCount = Encoding.ASCII.GetByteCount(pSoundString);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(pSoundString, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				Audio._EASharpBinding_16((sbyte*)ptr);
			}
		}

		// Token: 0x06000038 RID: 56
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_17(sbyte* pMixTriggerString, int value);

		// Token: 0x06000039 RID: 57 RVA: 0x00002434 File Offset: 0x00001434
		public unsafe static void SendMixTrigger(string pMixTriggerString, int value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(pMixTriggerString);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(pMixTriggerString, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				Audio._EASharpBinding_17((sbyte*)ptr, value);
			}
		}
	}
}
