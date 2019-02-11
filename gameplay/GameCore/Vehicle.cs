using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;
using Interop;
using UMath;
using Victory.Data.Objects.Customization;
using Victory.DataLayer.Serialization;

namespace GameCore
{
	// Token: 0x0200006B RID: 107
	[ExportOnlyCreate(false)]
	public class Vehicle : ExposedCommonBase
	{
		// Token: 0x060004F8 RID: 1272 RVA: 0x00007238 File Offset: 0x00006238
		public unsafe static Vehicle CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new Vehicle(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0000725B File Offset: 0x0000625B
		public unsafe Vehicle(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00007265 File Offset: 0x00006265
		protected internal Vehicle(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x0000726E File Offset: 0x0000626E
		protected internal unsafe Vehicle(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060004FC RID: 1276
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_494(void* self);

		// Token: 0x060004FD RID: 1277 RVA: 0x00007278 File Offset: 0x00006278
		[DisableExceptionHandling]
		~Vehicle()
		{
			Vehicle._EASharpBinding_494(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060004FE RID: 1278
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_495(void* _ThisPtr, void* position, void* direction, float mps);

		// Token: 0x060004FF RID: 1279 RVA: 0x000072B4 File Offset: 0x000062B4
		public void WarpTo(UMath.Vector3 position, UMath.Vector3 direction, float mps)
		{
			Vehicle._EASharpBinding_495(this.mSelf, object.ReferenceEquals(position, null) ? null : position._GetRaw(), object.ReferenceEquals(direction, null) ? null : direction._GetRaw(), mps);
		}

		// Token: 0x06000500 RID: 1280
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_496(void* _ThisPtr, bool pin);

		// Token: 0x06000501 RID: 1281 RVA: 0x000072E8 File Offset: 0x000062E8
		public void PinInPlace(bool pin)
		{
			Vehicle._EASharpBinding_496(this.mSelf, pin);
		}

		// Token: 0x06000502 RID: 1282
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_497(void* _ThisPtr);

		// Token: 0x06000503 RID: 1283 RVA: 0x000072F8 File Offset: 0x000062F8
		public bool IsLoading()
		{
			return Vehicle._EASharpBinding_497(this.mSelf);
		}

		// Token: 0x06000504 RID: 1284
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_498(void* _ThisPtr);

		// Token: 0x06000505 RID: 1285 RVA: 0x00007314 File Offset: 0x00006314
		public bool IsStaging()
		{
			return Vehicle._EASharpBinding_498(this.mSelf);
		}

		// Token: 0x06000506 RID: 1286
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_499(void* _ThisPtr);

		// Token: 0x06000507 RID: 1287 RVA: 0x0000732E File Offset: 0x0000632E
		public void ForceCoast()
		{
			Vehicle._EASharpBinding_499(this.mSelf);
		}

		// Token: 0x06000508 RID: 1288
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_500(void* _ThisPtr);

		// Token: 0x06000509 RID: 1289 RVA: 0x0000733B File Offset: 0x0000633B
		public void ForceStop()
		{
			Vehicle._EASharpBinding_500(this.mSelf);
		}

		// Token: 0x0600050A RID: 1290
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_501(void* _ThisPtr);

		// Token: 0x0600050B RID: 1291 RVA: 0x00007348 File Offset: 0x00006348
		public void ReleaseControlOverride()
		{
			Vehicle._EASharpBinding_501(this.mSelf);
		}

		// Token: 0x0600050C RID: 1292
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_502(void* _ThisPtr);

		// Token: 0x0600050D RID: 1293 RVA: 0x00007355 File Offset: 0x00006355
		public void Deactivate()
		{
			Vehicle._EASharpBinding_502(this.mSelf);
		}

		// Token: 0x0600050E RID: 1294
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_503(void* _ThisPtr, bool set);

		// Token: 0x0600050F RID: 1295 RVA: 0x00007362 File Offset: 0x00006362
		public void SetReplicationEnable(bool set)
		{
			Vehicle._EASharpBinding_503(this.mSelf, set);
		}

		// Token: 0x06000510 RID: 1296
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_504(void* _ThisPtr);

		// Token: 0x06000511 RID: 1297 RVA: 0x00007370 File Offset: 0x00006370
		public float GetSpeed()
		{
			return Vehicle._EASharpBinding_504(this.mSelf);
		}

		// Token: 0x06000512 RID: 1298
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_505(void* _ThisPtr);

		// Token: 0x06000513 RID: 1299 RVA: 0x0000738C File Offset: 0x0000638C
		public float GetCurrentAirborneTime()
		{
			return Vehicle._EASharpBinding_505(this.mSelf);
		}

		// Token: 0x06000514 RID: 1300
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_506(void* _ThisPtr);

		// Token: 0x06000515 RID: 1301 RVA: 0x000073A8 File Offset: 0x000063A8
		public int GetNumWheelsOnGround()
		{
			return Vehicle._EASharpBinding_506(this.mSelf);
		}

		// Token: 0x06000516 RID: 1302
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_507(void* _ThisPtr);

		// Token: 0x06000517 RID: 1303 RVA: 0x000073C4 File Offset: 0x000063C4
		public bool IsFacingWrongWay()
		{
			return Vehicle._EASharpBinding_507(this.mSelf);
		}

		// Token: 0x06000518 RID: 1304
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_508(void* _ThisPtr, float* duration, bool* isLearned);

		// Token: 0x06000519 RID: 1305 RVA: 0x000073E0 File Offset: 0x000063E0
		public unsafe bool TryPerfectLaunch(float* duration, bool* isLearned)
		{
			return Vehicle._EASharpBinding_508(this.mSelf, duration, isLearned);
		}

		// Token: 0x0600051A RID: 1306
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_509(void* _ThisPtr, float duration, float torque);

		// Token: 0x0600051B RID: 1307 RVA: 0x000073FC File Offset: 0x000063FC
		public void PerfectLaunch(float duration, float torque)
		{
			Vehicle._EASharpBinding_509(this.mSelf, duration, torque);
		}

		// Token: 0x0600051C RID: 1308
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_510(void* _ThisPtr, float duration, float torque);

		// Token: 0x0600051D RID: 1309 RVA: 0x0000740B File Offset: 0x0000640B
		public void PerfectShift(float duration, float torque)
		{
			Vehicle._EASharpBinding_510(this.mSelf, duration, torque);
		}

		// Token: 0x0600051E RID: 1310
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_511(void* _ThisPtr);

		// Token: 0x0600051F RID: 1311 RVA: 0x0000741C File Offset: 0x0000641C
		public UMath.Vector3 GetDirection()
		{
			return new UMath.Vector3(default(ExposeTag_InitOwned), Vehicle._EASharpBinding_511(this.mSelf));
		}

		// Token: 0x06000520 RID: 1312
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_512(void* _ThisPtr);

		// Token: 0x06000521 RID: 1313 RVA: 0x00007444 File Offset: 0x00006444
		public UMath.Vector3 GetPosition()
		{
			return new UMath.Vector3(default(ExposeTag_InitOwned), Vehicle._EASharpBinding_512(this.mSelf));
		}

		// Token: 0x06000522 RID: 1314
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_513(void* _ThisPtr);

		// Token: 0x06000523 RID: 1315 RVA: 0x0000746C File Offset: 0x0000646C
		public uint GetWorldID()
		{
			return Vehicle._EASharpBinding_513(this.mSelf);
		}

		// Token: 0x06000524 RID: 1316
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_514(void* _ThisPtr);

		// Token: 0x06000525 RID: 1317 RVA: 0x00007488 File Offset: 0x00006488
		public bool IsValid()
		{
			return Vehicle._EASharpBinding_514(this.mSelf);
		}

		// Token: 0x06000526 RID: 1318
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_515(void* _ThisPtr);

		// Token: 0x06000527 RID: 1319 RVA: 0x000074A4 File Offset: 0x000064A4
		public uint GetVehicleKey()
		{
			return Vehicle._EASharpBinding_515(this.mSelf);
		}

		// Token: 0x06000528 RID: 1320
		[DllImport("<internal>")]
		private unsafe static extern sbyte* _EASharpBinding_516(void* _ThisPtr);

		// Token: 0x06000529 RID: 1321 RVA: 0x000074C0 File Offset: 0x000064C0
		public string GetManufacturer()
		{
			return InternalUtil.ConvertFromCString(Vehicle._EASharpBinding_516(this.mSelf));
		}

		// Token: 0x0600052A RID: 1322
		[DllImport("<internal>")]
		private unsafe static extern sbyte* _EASharpBinding_517(void* _ThisPtr);

		// Token: 0x0600052B RID: 1323 RVA: 0x000074E0 File Offset: 0x000064E0
		public string GetModel()
		{
			return InternalUtil.ConvertFromCString(Vehicle._EASharpBinding_517(this.mSelf));
		}

		// Token: 0x0600052C RID: 1324
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_518(void* _ThisPtr);

		// Token: 0x0600052D RID: 1325 RVA: 0x00007500 File Offset: 0x00006500
		public float GetPerformanceRating()
		{
			return Vehicle._EASharpBinding_518(this.mSelf);
		}

		// Token: 0x0600052E RID: 1326
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_519(void* _ThisPtr);

		// Token: 0x0600052F RID: 1327 RVA: 0x0000751C File Offset: 0x0000651C
		public int GetTopSpeed()
		{
			return Vehicle._EASharpBinding_519(this.mSelf);
		}

		// Token: 0x06000530 RID: 1328
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_520(void* _ThisPtr);

		// Token: 0x06000531 RID: 1329 RVA: 0x00007538 File Offset: 0x00006538
		public int GetAcceleration()
		{
			return Vehicle._EASharpBinding_520(this.mSelf);
		}

		// Token: 0x06000532 RID: 1330
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_521(void* _ThisPtr);

		// Token: 0x06000533 RID: 1331 RVA: 0x00007554 File Offset: 0x00006554
		public int GetHandling()
		{
			return Vehicle._EASharpBinding_521(this.mSelf);
		}

		// Token: 0x06000534 RID: 1332
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_522(void* _ThisPtr);

		// Token: 0x06000535 RID: 1333 RVA: 0x00007570 File Offset: 0x00006570
		public int GetDurability()
		{
			return Vehicle._EASharpBinding_522(this.mSelf);
		}

		// Token: 0x06000536 RID: 1334
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_523(void* _ThisPtr, void* carData);

		// Token: 0x06000537 RID: 1335 RVA: 0x0000758A File Offset: 0x0000658A
		public void Fill(FECarData carData)
		{
			Vehicle._EASharpBinding_523(this.mSelf, object.ReferenceEquals(carData, null) ? null : carData._GetRaw());
		}

		// Token: 0x06000538 RID: 1336
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_524(void* _ThisPtr, float invulnerableTime);

		// Token: 0x06000539 RID: 1337 RVA: 0x000075AA File Offset: 0x000065AA
		public void RepairTires(float invulnerableTime)
		{
			Vehicle._EASharpBinding_524(this.mSelf, invulnerableTime);
		}

		// Token: 0x0600053A RID: 1338
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_525(void* _ThisPtr, bool enable, float duration);

		// Token: 0x0600053B RID: 1339 RVA: 0x000075B8 File Offset: 0x000065B8
		public void EnableInvulnerability(bool enable, float duration)
		{
			Vehicle._EASharpBinding_525(this.mSelf, enable, duration);
		}

		// Token: 0x0600053C RID: 1340
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_526(void* _ThisPtr, uint partHash);

		// Token: 0x0600053D RID: 1341 RVA: 0x000075C8 File Offset: 0x000065C8
		public bool HasEnhancerPart(uint partHash)
		{
			return Vehicle._EASharpBinding_526(this.mSelf, partHash);
		}

		// Token: 0x0600053E RID: 1342
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_527(void* _ThisPtr, int effectType);

		// Token: 0x0600053F RID: 1343 RVA: 0x000075E4 File Offset: 0x000065E4
		public bool HasSkillModEffect(SkillModEffectType effectType)
		{
			return Vehicle._EASharpBinding_527(this.mSelf, (int)effectType);
		}

		// Token: 0x06000540 RID: 1344
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_528(void* _ThisPtr, int effectType, int powerUpType);

		// Token: 0x06000541 RID: 1345 RVA: 0x00007600 File Offset: 0x00006600
		public bool HasSkillModPowerUpEffect(SkillModEffectType effectType, enumPowerUpType powerUpType)
		{
			return Vehicle._EASharpBinding_528(this.mSelf, (int)effectType, (int)powerUpType);
		}

		// Token: 0x06000542 RID: 1346
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_529(void* _ThisPtr, int effectType, float* amount);

		// Token: 0x06000543 RID: 1347 RVA: 0x0000761C File Offset: 0x0000661C
		public unsafe bool GetSkillModEffectAmount(SkillModEffectType effectType, float* amount)
		{
			return Vehicle._EASharpBinding_529(this.mSelf, (int)effectType, amount);
		}

		// Token: 0x06000544 RID: 1348
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_530(void* _ThisPtr, int effectType, int* amount);

		// Token: 0x06000545 RID: 1349 RVA: 0x00007638 File Offset: 0x00006638
		public unsafe bool GetSkillModEffectAmount(SkillModEffectType effectType, int* amount)
		{
			return Vehicle._EASharpBinding_530(this.mSelf, (int)effectType, amount);
		}

		// Token: 0x06000546 RID: 1350
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_531(void* _ThisPtr, int effectType, int powerUpType, float* amount);

		// Token: 0x06000547 RID: 1351 RVA: 0x00007654 File Offset: 0x00006654
		public unsafe bool GetSkillModPowerUpEffectAmount(SkillModEffectType effectType, enumPowerUpType powerUpType, float* amount)
		{
			return Vehicle._EASharpBinding_531(this.mSelf, (int)effectType, (int)powerUpType, amount);
		}

		// Token: 0x06000548 RID: 1352
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_532(void* _ThisPtr, int effectType, int powerUpType, int* amount);

		// Token: 0x06000549 RID: 1353 RVA: 0x00007674 File Offset: 0x00006674
		public unsafe bool GetSkillModPowerUpEffectAmount(SkillModEffectType effectType, enumPowerUpType powerUpType, int* amount)
		{
			return Vehicle._EASharpBinding_532(this.mSelf, (int)effectType, (int)powerUpType, amount);
		}

		// Token: 0x0600054A RID: 1354
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_533(void* _ThisPtr, int effectType);

		// Token: 0x0600054B RID: 1355 RVA: 0x00007694 File Offset: 0x00006694
		public float GetSkillModEffectFractionOfMaxAmount(SkillModEffectType effectType)
		{
			return Vehicle._EASharpBinding_533(this.mSelf, (int)effectType);
		}

		// Token: 0x0600054C RID: 1356
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_534(void* _ThisPtr, int effectType, int powerUpType);

		// Token: 0x0600054D RID: 1357 RVA: 0x000076B0 File Offset: 0x000066B0
		public float GetSkillModPowerUpEffectFractionOfMaxAmount(SkillModEffectType effectType, enumPowerUpType powerUpType)
		{
			return Vehicle._EASharpBinding_534(this.mSelf, (int)effectType, (int)powerUpType);
		}

		// Token: 0x0600054E RID: 1358
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_535(void* _ThisPtr, int effectType, int maxLevel);

		// Token: 0x0600054F RID: 1359 RVA: 0x000076CC File Offset: 0x000066CC
		public int GetSkillModEffectLevel(SkillModEffectType effectType, int maxLevel)
		{
			return Vehicle._EASharpBinding_535(this.mSelf, (int)effectType, maxLevel);
		}

		// Token: 0x06000550 RID: 1360
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_536(void* _ThisPtr, int effectType, int powerUpType, int maxLevel);

		// Token: 0x06000551 RID: 1361 RVA: 0x000076E8 File Offset: 0x000066E8
		public int GetSkillModPowerUpEffectLevel(SkillModEffectType effectType, enumPowerUpType powerUpType, int maxLevel)
		{
			return Vehicle._EASharpBinding_536(this.mSelf, (int)effectType, (int)powerUpType, maxLevel);
		}

		// Token: 0x06000552 RID: 1362
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_537(void* _ThisPtr, int effectType);

		// Token: 0x06000553 RID: 1363 RVA: 0x00007708 File Offset: 0x00006708
		public int GetSkillModEffectTypeCollectionId(SkillModEffectType effectType)
		{
			return Vehicle._EASharpBinding_537(this.mSelf, (int)effectType);
		}

		// Token: 0x06000554 RID: 1364
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_538(void* _ThisPtr, int effectType, int powerUpType);

		// Token: 0x06000555 RID: 1365 RVA: 0x00007724 File Offset: 0x00006724
		public int GetSkillModPowerUpEffectTypeCollectionId(SkillModEffectType effectType, enumPowerUpType powerUpType)
		{
			return Vehicle._EASharpBinding_538(this.mSelf, (int)effectType, (int)powerUpType);
		}

		// Token: 0x06000556 RID: 1366
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_539(void* _ThisPtr);

		// Token: 0x06000557 RID: 1367 RVA: 0x00007740 File Offset: 0x00006740
		public void ResetVehicle()
		{
			Vehicle._EASharpBinding_539(this.mSelf);
		}

		// Token: 0x06000558 RID: 1368
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_540();

		// Token: 0x06000559 RID: 1369 RVA: 0x0000774D File Offset: 0x0000674D
		public static void CommitRenderingAssets()
		{
			Vehicle._EASharpBinding_540();
		}

		// Token: 0x0600055A RID: 1370
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_541(sbyte* presetName);

		// Token: 0x0600055B RID: 1371 RVA: 0x00007754 File Offset: 0x00006754
		public unsafe static float GetPerformanceRating(string presetName)
		{
			int byteCount = Encoding.ASCII.GetByteCount(presetName);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(presetName, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return Vehicle._EASharpBinding_541((sbyte*)ptr);
			}
		}
	}
}
