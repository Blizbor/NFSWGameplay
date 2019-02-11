using System;
using System.Runtime.InteropServices;
using EASharp;
using GameCore.Streaming;
using UMath;

namespace GameCore
{
	// Token: 0x02000063 RID: 99
	[ExportOnlyCreate(false)]
	public class StreamingToken : ExposedCommonBase
	{
		// Token: 0x0600048E RID: 1166 RVA: 0x00006B40 File Offset: 0x00005B40
		public unsafe static StreamingToken CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new StreamingToken(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00006B63 File Offset: 0x00005B63
		public unsafe StreamingToken(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00006B6D File Offset: 0x00005B6D
		protected internal StreamingToken(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00006B76 File Offset: 0x00005B76
		protected internal unsafe StreamingToken(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000492 RID: 1170
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_452(void* self);

		// Token: 0x06000493 RID: 1171 RVA: 0x00006B80 File Offset: 0x00005B80
		[DisableExceptionHandling]
		~StreamingToken()
		{
			StreamingToken._EASharpBinding_452(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000494 RID: 1172
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_453(void* _ThisPtr);

		// Token: 0x06000495 RID: 1173 RVA: 0x00006BBC File Offset: 0x00005BBC
		public int GetSectionId()
		{
			return StreamingToken._EASharpBinding_453(this.mSelf);
		}

		// Token: 0x06000496 RID: 1174
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_454(void* _ThisPtr);

		// Token: 0x06000497 RID: 1175 RVA: 0x00006BD8 File Offset: 0x00005BD8
		public int GetCombinedSectionId()
		{
			return StreamingToken._EASharpBinding_454(this.mSelf);
		}

		// Token: 0x06000498 RID: 1176
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_455(void* _ThisPtr, void* position, float radius);

		// Token: 0x06000499 RID: 1177 RVA: 0x00006BF4 File Offset: 0x00005BF4
		public bool IsNear(Vector3 position, float radius)
		{
			return StreamingToken._EASharpBinding_455(this.mSelf, object.ReferenceEquals(position, null) ? null : position._GetRaw(), radius);
		}

		// Token: 0x0600049A RID: 1178
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_456(void* _ThisPtr, int sectionId);

		// Token: 0x0600049B RID: 1179 RVA: 0x00006C24 File Offset: 0x00005C24
		public bool IsOnSection(int sectionId)
		{
			return StreamingToken._EASharpBinding_456(this.mSelf, sectionId);
		}

		// Token: 0x0600049C RID: 1180
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_457(void* _ThisPtr, object listener);

		// Token: 0x0600049D RID: 1181 RVA: 0x00006C3F File Offset: 0x00005C3F
		public void Listen(ITokenListener listener)
		{
			StreamingToken._EASharpBinding_457(this.mSelf, listener);
		}
	}
}
