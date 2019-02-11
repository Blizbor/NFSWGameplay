using System;
using System.Runtime.InteropServices;
using EASharp;
using UMath;

namespace GameCore
{
	// Token: 0x02000065 RID: 101
	[ExportOnlyCreate(false)]
	public class TrackLayoutData : ExposedCommonBase
	{
		// Token: 0x060004AA RID: 1194 RVA: 0x00006D1C File Offset: 0x00005D1C
		public unsafe static TrackLayoutData CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new TrackLayoutData(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00006D3F File Offset: 0x00005D3F
		public unsafe TrackLayoutData(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00006D49 File Offset: 0x00005D49
		protected internal TrackLayoutData(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00006D52 File Offset: 0x00005D52
		protected internal unsafe TrackLayoutData(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060004AE RID: 1198
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_462(void* self);

		// Token: 0x060004AF RID: 1199 RVA: 0x00006D5C File Offset: 0x00005D5C
		[DisableExceptionHandling]
		~TrackLayoutData()
		{
			TrackLayoutData._EASharpBinding_462(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060004B0 RID: 1200
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_463(uint checkpoints, uint alternateRoutes, int laps);

		// Token: 0x060004B1 RID: 1201 RVA: 0x00006D98 File Offset: 0x00005D98
		public TrackLayoutData(uint checkpoints, uint alternateRoutes, int laps) : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = TrackLayoutData._EASharpBinding_463(checkpoints, alternateRoutes, laps);
		}

		// Token: 0x060004B2 RID: 1202
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_464(void* _ThisPtr, uint index, void* position, void* direction);

		// Token: 0x060004B3 RID: 1203 RVA: 0x00006DC2 File Offset: 0x00005DC2
		public void AddPathPoint(uint index, Vector3 position, Vector3 direction)
		{
			TrackLayoutData._EASharpBinding_464(this.mSelf, index, object.ReferenceEquals(position, null) ? null : position._GetRaw(), object.ReferenceEquals(direction, null) ? null : direction._GetRaw());
		}

		// Token: 0x060004B4 RID: 1204
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_465(void* _ThisPtr, uint index, void* position, void* direction);

		// Token: 0x060004B5 RID: 1205 RVA: 0x00006DF6 File Offset: 0x00005DF6
		public void AddAlternatePoint(uint index, Vector3 position, Vector3 direction)
		{
			TrackLayoutData._EASharpBinding_465(this.mSelf, index, object.ReferenceEquals(position, null) ? null : position._GetRaw(), object.ReferenceEquals(direction, null) ? null : direction._GetRaw());
		}

		// Token: 0x060004B6 RID: 1206
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_466(void* _ThisPtr);

		// Token: 0x060004B7 RID: 1207 RVA: 0x00006E2C File Offset: 0x00005E2C
		public int GetNumLaps()
		{
			return TrackLayoutData._EASharpBinding_466(this.mSelf);
		}

		// Token: 0x060004B8 RID: 1208
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_467(void* _ThisPtr);

		// Token: 0x060004B9 RID: 1209 RVA: 0x00006E48 File Offset: 0x00005E48
		public bool IsLoopingLayout()
		{
			return TrackLayoutData._EASharpBinding_467(this.mSelf);
		}

		// Token: 0x060004BA RID: 1210
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_468(void* _ThisPtr);

		// Token: 0x060004BB RID: 1211 RVA: 0x00006E64 File Offset: 0x00005E64
		public uint GetNumPathPoints()
		{
			return TrackLayoutData._EASharpBinding_468(this.mSelf);
		}

		// Token: 0x060004BC RID: 1212
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_469(void* _ThisPtr);

		// Token: 0x060004BD RID: 1213 RVA: 0x00006E80 File Offset: 0x00005E80
		public uint GetNumCheckpoints()
		{
			return TrackLayoutData._EASharpBinding_469(this.mSelf);
		}

		// Token: 0x060004BE RID: 1214
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_470(void* _ThisPtr, uint index);

		// Token: 0x060004BF RID: 1215 RVA: 0x00006E9C File Offset: 0x00005E9C
		public Vector3 GetPathPointPosition(uint index)
		{
			return Vector3.CreateInitUnowned(TrackLayoutData._EASharpBinding_470(this.mSelf, index));
		}

		// Token: 0x060004C0 RID: 1216
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_471(void* _ThisPtr, uint index);

		// Token: 0x060004C1 RID: 1217 RVA: 0x00006EBC File Offset: 0x00005EBC
		public Vector3 GetPathPointDirection(uint index)
		{
			return Vector3.CreateInitUnowned(TrackLayoutData._EASharpBinding_471(this.mSelf, index));
		}

		// Token: 0x060004C2 RID: 1218
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_472(void* _ThisPtr);

		// Token: 0x060004C3 RID: 1219 RVA: 0x00006EDC File Offset: 0x00005EDC
		public uint GetNumAlternatePoints()
		{
			return TrackLayoutData._EASharpBinding_472(this.mSelf);
		}

		// Token: 0x060004C4 RID: 1220
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_473(void* _ThisPtr, uint index);

		// Token: 0x060004C5 RID: 1221 RVA: 0x00006EF8 File Offset: 0x00005EF8
		public Vector3 GetAlternatePointPosition(uint index)
		{
			return Vector3.CreateInitUnowned(TrackLayoutData._EASharpBinding_473(this.mSelf, index));
		}

		// Token: 0x060004C6 RID: 1222
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_474(void* _ThisPtr, uint index);

		// Token: 0x060004C7 RID: 1223 RVA: 0x00006F18 File Offset: 0x00005F18
		public Vector3 GetAlternatePointDirection(uint index)
		{
			return Vector3.CreateInitUnowned(TrackLayoutData._EASharpBinding_474(this.mSelf, index));
		}

		// Token: 0x02000066 RID: 102
		public enum Enum3
		{
			// Token: 0x040000DD RID: 221
			kMaxAlternatePoints = 64,
			// Token: 0x040000DE RID: 222
			kMaxCheckpoints = 16,
			// Token: 0x040000DF RID: 223
			kMaxPathPoints = 18
		}
	}
}
