using System;
using System.Runtime.InteropServices;
using EASharp;
using GameCore.Collections;
using UMath;

namespace GameCore
{
	// Token: 0x0200002C RID: 44
	[ExportOnlyCreate(false)]
	public class Cops : ExposedCommonBase
	{
		// Token: 0x060000C0 RID: 192 RVA: 0x00002D1C File Offset: 0x00001D1C
		public unsafe static Cops CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new Cops(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002D3F File Offset: 0x00001D3F
		public unsafe Cops(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002D49 File Offset: 0x00001D49
		protected internal Cops(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002D52 File Offset: 0x00001D52
		protected internal unsafe Cops(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060000C4 RID: 196
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_37(void* self);

		// Token: 0x060000C5 RID: 197 RVA: 0x00002D5C File Offset: 0x00001D5C
		[DisableExceptionHandling]
		~Cops()
		{
			Cops._EASharpBinding_37(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060000C6 RID: 198
		[DllImport("<internal>")]
		private static extern bool _EASharpBinding_38();

		// Token: 0x060000C7 RID: 199 RVA: 0x00002D98 File Offset: 0x00001D98
		public static bool IsPursuitActive()
		{
			return Cops._EASharpBinding_38();
		}

		// Token: 0x060000C8 RID: 200
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_39(int heat, bool spawnpursuitcar);

		// Token: 0x060000C9 RID: 201 RVA: 0x00002DAC File Offset: 0x00001DAC
		public static void LaunchPursuit(int heat, bool spawnpursuitcar)
		{
			Cops._EASharpBinding_39(heat, spawnpursuitcar);
		}

		// Token: 0x060000CA RID: 202
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_40(bool spawnpursuitcar);

		// Token: 0x060000CB RID: 203 RVA: 0x00002DB5 File Offset: 0x00001DB5
		public static void ReinitiatePursuit(bool spawnpursuitcar)
		{
			Cops._EASharpBinding_40(spawnpursuitcar);
		}

		// Token: 0x060000CC RID: 204
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_41();

		// Token: 0x060000CD RID: 205 RVA: 0x00002DBD File Offset: 0x00001DBD
		public static void ResetPursuitStats()
		{
			Cops._EASharpBinding_41();
		}

		// Token: 0x060000CE RID: 206
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_42();

		// Token: 0x060000CF RID: 207 RVA: 0x00002DC4 File Offset: 0x00001DC4
		public static void KillPursuit()
		{
			Cops._EASharpBinding_42();
		}

		// Token: 0x060000D0 RID: 208
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_43();

		// Token: 0x060000D1 RID: 209 RVA: 0x00002DCB File Offset: 0x00001DCB
		public static void FlushCops()
		{
			Cops._EASharpBinding_43();
		}

		// Token: 0x060000D2 RID: 210
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_44(float heat);

		// Token: 0x060000D3 RID: 211 RVA: 0x00002DD2 File Offset: 0x00001DD2
		public static void SetPursuitHeat(float heat)
		{
			Cops._EASharpBinding_44(heat);
		}

		// Token: 0x060000D4 RID: 212
		[DllImport("<internal>")]
		private static extern float _EASharpBinding_45();

		// Token: 0x060000D5 RID: 213 RVA: 0x00002DDC File Offset: 0x00001DDC
		public static float GetPursuitHeat()
		{
			return Cops._EASharpBinding_45();
		}

		// Token: 0x060000D6 RID: 214
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_46(void* position, void* direction, void* list, bool withSpikes, float minLifetimeInSeconds);

		// Token: 0x060000D7 RID: 215 RVA: 0x00002DF0 File Offset: 0x00001DF0
		public static bool CreateRoadblock(Vector3 position, Vector3 direction, KeyList list, bool withSpikes, float minLifetimeInSeconds)
		{
			return Cops._EASharpBinding_46(object.ReferenceEquals(position, null) ? null : position._GetRaw(), object.ReferenceEquals(direction, null) ? null : direction._GetRaw(), object.ReferenceEquals(list, null) ? null : list._GetRaw(), withSpikes, minLifetimeInSeconds);
		}

		// Token: 0x060000D8 RID: 216
		[DllImport("<internal>")]
		private static extern bool _EASharpBinding_47(float distFromPlayer, ushort numRhinos);

		// Token: 0x060000D9 RID: 217 RVA: 0x00002E40 File Offset: 0x00001E40
		public static bool CreateRhinos(float distFromPlayer, ushort numRhinos)
		{
			return Cops._EASharpBinding_47(distFromPlayer, numRhinos);
		}

		// Token: 0x060000DA RID: 218
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_48(uint vehicleKey, int count);

		// Token: 0x060000DB RID: 219 RVA: 0x00002E56 File Offset: 0x00001E56
		public static void PrimeCopVehicleCache(uint vehicleKey, int count)
		{
			Cops._EASharpBinding_48(vehicleKey, count);
		}

		// Token: 0x060000DC RID: 220
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_49(bool enable);

		// Token: 0x060000DD RID: 221 RVA: 0x00002E5F File Offset: 0x00001E5F
		public static void EnablePursuitSynchronization(bool enable)
		{
			Cops._EASharpBinding_49(enable);
		}

		// Token: 0x060000DE RID: 222
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_50(int flags, void* position, float radius);

		// Token: 0x060000DF RID: 223 RVA: 0x00002E68 File Offset: 0x00001E68
		public static int GetNumCopsInRadius(eCopCountIncludeFlags flags, Vector3 position, float radius)
		{
			return Cops._EASharpBinding_50((int)flags, object.ReferenceEquals(position, null) ? null : position._GetRaw(), radius);
		}

		// Token: 0x060000E0 RID: 224
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_51(void* position, float searchDistance, void* outCopPosition);

		// Token: 0x060000E1 RID: 225 RVA: 0x00002E94 File Offset: 0x00001E94
		public static bool GetClosestCop(Vector3 position, float searchDistance, Vector3 outCopPosition)
		{
			return Cops._EASharpBinding_51(object.ReferenceEquals(position, null) ? null : position._GetRaw(), searchDistance, object.ReferenceEquals(outCopPosition, null) ? null : outCopPosition._GetRaw());
		}

		// Token: 0x060000E2 RID: 226
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_52(float* direction, float* distance);

		// Token: 0x060000E3 RID: 227 RVA: 0x00002ECF File Offset: 0x00001ECF
		public unsafe static void GetClosestCopDirectionAndDistance(float* direction, float* distance)
		{
			Cops._EASharpBinding_52(direction, distance);
		}

		// Token: 0x060000E4 RID: 228
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_53(uint vehicleKey, void* position, void* direction);

		// Token: 0x060000E5 RID: 229 RVA: 0x00002ED8 File Offset: 0x00001ED8
		public static void SpawnCop(uint vehicleKey, Vector3 position, Vector3 direction)
		{
			Cops._EASharpBinding_53(vehicleKey, object.ReferenceEquals(position, null) ? null : position._GetRaw(), object.ReferenceEquals(direction, null) ? null : direction._GetRaw());
		}
	}
}
