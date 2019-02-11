using System;
using System.Runtime.InteropServices;
using EASharp;
using GameCore.Math;

namespace GameCore
{
	// Token: 0x02000062 RID: 98
	[ExportOnlyCreate(false)]
	public class StreamingMonitor : ExposedCommonBase
	{
		// Token: 0x0600047A RID: 1146 RVA: 0x000069F0 File Offset: 0x000059F0
		public unsafe static StreamingMonitor CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new StreamingMonitor(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00006A13 File Offset: 0x00005A13
		public unsafe StreamingMonitor(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00006A1D File Offset: 0x00005A1D
		protected internal StreamingMonitor(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00006A26 File Offset: 0x00005A26
		protected internal unsafe StreamingMonitor(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600047E RID: 1150
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_444();

		// Token: 0x0600047F RID: 1151 RVA: 0x00006A30 File Offset: 0x00005A30
		public StreamingMonitor() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = StreamingMonitor._EASharpBinding_444();
		}

		// Token: 0x06000480 RID: 1152
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_445(void* _ThisPtr);

		// Token: 0x06000481 RID: 1153 RVA: 0x00006A58 File Offset: 0x00005A58
		~StreamingMonitor()
		{
			StreamingMonitor._EASharpBinding_445(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000482 RID: 1154
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_446(void* _ThisPtr, void* position, float rotation);

		// Token: 0x06000483 RID: 1155 RVA: 0x00006A94 File Offset: 0x00005A94
		public StreamingToken Create(Vector3 position, float rotation)
		{
			return StreamingToken.CreateInitUnowned(StreamingMonitor._EASharpBinding_446(this.mSelf, object.ReferenceEquals(position, null) ? null : position._GetRaw(), rotation));
		}

		// Token: 0x06000484 RID: 1156
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_447(void* _ThisPtr, void* token);

		// Token: 0x06000485 RID: 1157 RVA: 0x00006AC7 File Offset: 0x00005AC7
		public void Destroy(StreamingToken token)
		{
			StreamingMonitor._EASharpBinding_447(this.mSelf, object.ReferenceEquals(token, null) ? null : token._GetRaw());
		}

		// Token: 0x06000486 RID: 1158
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_448(void* _ThisPtr);

		// Token: 0x06000487 RID: 1159 RVA: 0x00006AE7 File Offset: 0x00005AE7
		public void Enable()
		{
			StreamingMonitor._EASharpBinding_448(this.mSelf);
		}

		// Token: 0x06000488 RID: 1160
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_449(void* _ThisPtr);

		// Token: 0x06000489 RID: 1161 RVA: 0x00006AF4 File Offset: 0x00005AF4
		public void Disable()
		{
			StreamingMonitor._EASharpBinding_449(this.mSelf);
		}

		// Token: 0x0600048A RID: 1162
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_450(void* _ThisPtr);

		// Token: 0x0600048B RID: 1163 RVA: 0x00006B01 File Offset: 0x00005B01
		public void RefreshTokens()
		{
			StreamingMonitor._EASharpBinding_450(this.mSelf);
		}

		// Token: 0x0600048C RID: 1164
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_451(void* _ThisPtr, void* token);

		// Token: 0x0600048D RID: 1165 RVA: 0x00006B10 File Offset: 0x00005B10
		public bool RefreshToken(StreamingToken token)
		{
			return StreamingMonitor._EASharpBinding_451(this.mSelf, object.ReferenceEquals(token, null) ? null : token._GetRaw());
		}
	}
}
