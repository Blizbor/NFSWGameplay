using System;
using System.Runtime.InteropServices;
using EASharp;
using UMath;

namespace GameCore
{
	// Token: 0x0200006A RID: 106
	[ExportOnlyCreate(false)]
	public class Traffic : ExposedCommonBase
	{
		// Token: 0x060004EA RID: 1258 RVA: 0x00007174 File Offset: 0x00006174
		public unsafe static Traffic CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new Traffic(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00007197 File Offset: 0x00006197
		public unsafe Traffic(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x000071A1 File Offset: 0x000061A1
		protected internal Traffic(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x000071AA File Offset: 0x000061AA
		protected internal unsafe Traffic(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060004EE RID: 1262
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_489(void* self);

		// Token: 0x060004EF RID: 1263 RVA: 0x000071B4 File Offset: 0x000061B4
		[DisableExceptionHandling]
		~Traffic()
		{
			Traffic._EASharpBinding_489(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060004F0 RID: 1264
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_490(int density);

		// Token: 0x060004F1 RID: 1265 RVA: 0x000071F0 File Offset: 0x000061F0
		public static void SetTrafficDensity(int density)
		{
			Traffic._EASharpBinding_490(density);
		}

		// Token: 0x060004F2 RID: 1266
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_491();

		// Token: 0x060004F3 RID: 1267 RVA: 0x000071F8 File Offset: 0x000061F8
		public static void FlushAllTraffic()
		{
			Traffic._EASharpBinding_491();
		}

		// Token: 0x060004F4 RID: 1268
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_492(uint vehicleKey, void* position, void* direction, float initialSpeed);

		// Token: 0x060004F5 RID: 1269 RVA: 0x000071FF File Offset: 0x000061FF
		public static void SpawnTraffic(uint vehicleKey, Vector3 position, Vector3 direction, float initialSpeed)
		{
			Traffic._EASharpBinding_492(vehicleKey, object.ReferenceEquals(position, null) ? null : position._GetRaw(), object.ReferenceEquals(direction, null) ? null : direction._GetRaw(), initialSpeed);
		}

		// Token: 0x060004F6 RID: 1270
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_493(uint vehicleKey, int numVehicles);

		// Token: 0x060004F7 RID: 1271 RVA: 0x0000722E File Offset: 0x0000622E
		public static void PrimeTrafficVehicleCache(uint vehicleKey, int numVehicles)
		{
			Traffic._EASharpBinding_493(vehicleKey, numVehicles);
		}
	}
}
