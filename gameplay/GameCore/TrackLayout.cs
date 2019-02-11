using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x02000067 RID: 103
	[ExportOnlyCreate(false)]
	public class TrackLayout : ExposedCommonBase
	{
		// Token: 0x060004C8 RID: 1224 RVA: 0x00006F38 File Offset: 0x00005F38
		public unsafe static TrackLayout CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new TrackLayout(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00006F5B File Offset: 0x00005F5B
		public unsafe TrackLayout(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00006F65 File Offset: 0x00005F65
		protected internal TrackLayout(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00006F6E File Offset: 0x00005F6E
		protected internal unsafe TrackLayout(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060004CC RID: 1228
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_475(void* self);

		// Token: 0x060004CD RID: 1229 RVA: 0x00006F78 File Offset: 0x00005F78
		[DisableExceptionHandling]
		~TrackLayout()
		{
			TrackLayout._EASharpBinding_475(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060004CE RID: 1230
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_476();

		// Token: 0x060004CF RID: 1231 RVA: 0x00006FB4 File Offset: 0x00005FB4
		public TrackLayout() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = TrackLayout._EASharpBinding_476();
		}

		// Token: 0x060004D0 RID: 1232
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_477(void* _ThisPtr, void* data, bool ignoreShortcuts, int metersPastFinishOverride, bool stopOnDecisionSegment);

		// Token: 0x060004D1 RID: 1233 RVA: 0x00006FDC File Offset: 0x00005FDC
		public int Resolve(TrackLayoutData data, bool ignoreShortcuts, int metersPastFinishOverride, bool stopOnDecisionSegment)
		{
			return TrackLayout._EASharpBinding_477(this.mSelf, object.ReferenceEquals(data, null) ? null : data._GetRaw(), ignoreShortcuts, metersPastFinishOverride, stopOnDecisionSegment);
		}

		// Token: 0x060004D2 RID: 1234
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_478(void* _ThisPtr);

		// Token: 0x060004D3 RID: 1235 RVA: 0x0000700D File Offset: 0x0000600D
		public void Reset()
		{
			TrackLayout._EASharpBinding_478(this.mSelf);
		}

		// Token: 0x060004D4 RID: 1236
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_479(void* _ThisPtr, int segment);

		// Token: 0x060004D5 RID: 1237 RVA: 0x0000701C File Offset: 0x0000601C
		public float GetSegmentLength(int segment)
		{
			return TrackLayout._EASharpBinding_479(this.mSelf, segment);
		}

		// Token: 0x060004D6 RID: 1238
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_480(void* _ThisPtr, int lap);

		// Token: 0x060004D7 RID: 1239 RVA: 0x00007038 File Offset: 0x00006038
		public float GetLapLength(int lap)
		{
			return TrackLayout._EASharpBinding_480(this.mSelf, lap);
		}

		// Token: 0x060004D8 RID: 1240
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_481(void* _ThisPtr, int numLaps);

		// Token: 0x060004D9 RID: 1241 RVA: 0x00007054 File Offset: 0x00006054
		public float GetLength(int numLaps)
		{
			return TrackLayout._EASharpBinding_481(this.mSelf, numLaps);
		}

		// Token: 0x060004DA RID: 1242
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_482(void* _ThisPtr, void* vehicle);

		// Token: 0x060004DB RID: 1243 RVA: 0x00007070 File Offset: 0x00006070
		public float GetLapStartToVehicleDistance(Vehicle vehicle)
		{
			return TrackLayout._EASharpBinding_482(this.mSelf, object.ReferenceEquals(vehicle, null) ? null : vehicle._GetRaw());
		}

		// Token: 0x060004DC RID: 1244
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_483(void* _ThisPtr, int checkpointNumber);

		// Token: 0x060004DD RID: 1245 RVA: 0x000070A0 File Offset: 0x000060A0
		public float GetLapStartToCheckpointDistance(int checkpointNumber)
		{
			return TrackLayout._EASharpBinding_483(this.mSelf, checkpointNumber);
		}

		// Token: 0x060004DE RID: 1246
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_484();

		// Token: 0x060004DF RID: 1247 RVA: 0x000070BB File Offset: 0x000060BB
		public static void ResetBarriers()
		{
			TrackLayout._EASharpBinding_484();
		}

		// Token: 0x060004E0 RID: 1248
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_485();

		// Token: 0x060004E1 RID: 1249 RVA: 0x000070C2 File Offset: 0x000060C2
		public static void ResolveBarriers()
		{
			TrackLayout._EASharpBinding_485();
		}

		// Token: 0x02000068 RID: 104
		public enum Enum4
		{
			// Token: 0x040000E1 RID: 225
			kRouteFlags_OK,
			// Token: 0x040000E2 RID: 226
			kRouteFlags_NoRoute,
			// Token: 0x040000E3 RID: 227
			kRouteFlags_ShorcutInFirstLeg,
			// Token: 0x040000E4 RID: 228
			kRouteFlags_CantTakeShortcut = 8
		}
	}
}
