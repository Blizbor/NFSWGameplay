using System;
using System.Runtime.InteropServices;
using EASharp;
using Interop;

namespace GameCore
{
	// Token: 0x02000064 RID: 100
	[ExportOnlyCreate(false)]
	public class TrackerSystem : ExposedCommonBase
	{
		// Token: 0x0600049E RID: 1182 RVA: 0x00006C50 File Offset: 0x00005C50
		public unsafe static TrackerSystem CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new TrackerSystem(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00006C73 File Offset: 0x00005C73
		public unsafe TrackerSystem(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00006C7D File Offset: 0x00005C7D
		protected internal TrackerSystem(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00006C86 File Offset: 0x00005C86
		protected internal unsafe TrackerSystem(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060004A2 RID: 1186
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_458(void* self);

		// Token: 0x060004A3 RID: 1187 RVA: 0x00006C90 File Offset: 0x00005C90
		[DisableExceptionHandling]
		~TrackerSystem()
		{
			TrackerSystem._EASharpBinding_458(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060004A4 RID: 1188
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_459(void* entity);

		// Token: 0x060004A5 RID: 1189 RVA: 0x00006CCC File Offset: 0x00005CCC
		public static void AddEntity(TrackerEntity entity)
		{
			TrackerSystem._EASharpBinding_459(object.ReferenceEquals(entity, null) ? null : entity._GetRaw());
		}

		// Token: 0x060004A6 RID: 1190
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_460(void* entity);

		// Token: 0x060004A7 RID: 1191 RVA: 0x00006CE6 File Offset: 0x00005CE6
		public static void UpdateEntity(TrackerEntity entity)
		{
			TrackerSystem._EASharpBinding_460(object.ReferenceEquals(entity, null) ? null : entity._GetRaw());
		}

		// Token: 0x060004A8 RID: 1192
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_461(void* entity);

		// Token: 0x060004A9 RID: 1193 RVA: 0x00006D00 File Offset: 0x00005D00
		public static void RemoveEntity(TrackerEntity entity)
		{
			TrackerSystem._EASharpBinding_461(object.ReferenceEquals(entity, null) ? null : entity._GetRaw());
		}
	}
}
