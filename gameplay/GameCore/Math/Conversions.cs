using System;

namespace GameCore.Math
{
	// Token: 0x020001F5 RID: 501
	internal class Conversions
	{
		// Token: 0x06001522 RID: 5410 RVA: 0x000259CD File Offset: 0x000249CD
		public static float MPH2MPS(float _mph_)
		{
			return _mph_ * 0.44703f;
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x000259D6 File Offset: 0x000249D6
		public static float KPH2MPS(float _kph_)
		{
			return _kph_ * 0.27778f;
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x000259DF File Offset: 0x000249DF
		public static float MPS2MPH(float _mps_)
		{
			return _mps_ * 2.23699f;
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x000259E8 File Offset: 0x000249E8
		public static float MPS2KPH(float _mps_)
		{
			return _mps_ * 3.6f;
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x000259F1 File Offset: 0x000249F1
		public static float MPH2KPH(float _mph_)
		{
			return _mph_ * 1.60931f;
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x000259FA File Offset: 0x000249FA
		public static float METERS2FT(float _meters_)
		{
			return _meters_ * 3.2808f;
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x00025A03 File Offset: 0x00024A03
		public static float FT2METERS(float _feet_)
		{
			return _feet_ * 0.3048f;
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x00025A0C File Offset: 0x00024A0C
		public static float INCH2METERS(float _inches_)
		{
			return _inches_ * 0.0254f;
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x00025A15 File Offset: 0x00024A15
		public static float INCH2MILLIMETERS(float _inches_)
		{
			return _inches_ * 25.4f;
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x00025A1E File Offset: 0x00024A1E
		public static float METERS2INCH(float _meters_)
		{
			return _meters_ * 39.3701f;
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x00025A27 File Offset: 0x00024A27
		public static float MILE2METERS(float _mi_)
		{
			return _mi_ * 1609.34f;
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x00025A30 File Offset: 0x00024A30
		public static float KM2MILE(float _km_)
		{
			return _km_ * 0.621371f;
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x00025A39 File Offset: 0x00024A39
		public static float CUBICIN2CUBICCM(float _cubicinches_)
		{
			return _cubicinches_ * 16.387f;
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x00025A42 File Offset: 0x00024A42
		public static float CUBICIN2CUBICFEET(float _cubicinches_)
		{
			return _cubicinches_ * 0.0005787f;
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x00025A4B File Offset: 0x00024A4B
		public static float CUBICCM2CUBICIN(float _cubiccm_)
		{
			return _cubiccm_ * 0.061024f;
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x00025A54 File Offset: 0x00024A54
		public static float CUBICIN2LITER(float _cubicinches_)
		{
			return _cubicinches_ * 0.016387f;
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x00025A5D File Offset: 0x00024A5D
		public static float LITER2CUBICIN(float _liters_)
		{
			return _liters_ * 61.024f;
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x00025A66 File Offset: 0x00024A66
		public static float LITER2QUART(float _liters_)
		{
			return _liters_ * 1.0567f;
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x00025A6F File Offset: 0x00024A6F
		public static float QUART2LITER(float _quart_)
		{
			return _quart_ * 0.94635f;
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x00025A78 File Offset: 0x00024A78
		public static float KG2LB(float _kg_)
		{
			return _kg_ * 2.2046f;
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x00025A81 File Offset: 0x00024A81
		public static float LB2KG(float _lb_)
		{
			return _lb_ * 0.45359f;
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x00025A8A File Offset: 0x00024A8A
		public static float OUNCES2KG(float _ounces_)
		{
			return _ounces_ * 0.028349f;
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x00025A93 File Offset: 0x00024A93
		public static float KG2OUNCES(float _kg_)
		{
			return _kg_ * 35.274f;
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x00025A9C File Offset: 0x00024A9C
		public static float NM2FTLB(float _nm_)
		{
			return _nm_ * 0.7376f;
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x00025AA5 File Offset: 0x00024AA5
		public static float FTLB2NM(float _ftlb_)
		{
			return _ftlb_ * 1.3558f;
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x00025AAE File Offset: 0x00024AAE
		public static float FTLB2HP(float _ftlb, float _rpm)
		{
			return _ftlb * _rpm / 5252f;
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x00025AB9 File Offset: 0x00024AB9
		public static float NM2HP(float _nm_, float _rpm)
		{
			return _nm_ * 0.7376f * _rpm / 5252f;
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x00025ACA File Offset: 0x00024ACA
		public static float PA2PSI(float _pa_)
		{
			return _pa_ / 6894.8f;
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x00025AD3 File Offset: 0x00024AD3
		public static float PSI2PA(float _psi_)
		{
			return _psi_ * 6894.8f;
		}

		// Token: 0x0600153F RID: 5439 RVA: 0x00025ADC File Offset: 0x00024ADC
		public static float KW2HP(float _kw_)
		{
			return _kw_ * 1.341f;
		}

		// Token: 0x06001540 RID: 5440 RVA: 0x00025AE5 File Offset: 0x00024AE5
		public static float HP2KW(float _hp_)
		{
			return _hp_ * 0.7457f;
		}

		// Token: 0x06001541 RID: 5441 RVA: 0x00025AEE File Offset: 0x00024AEE
		public static float LBIN2NM(float _lbin_)
		{
			return _lbin_ * 12f * 14.5939f;
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x00025AFD File Offset: 0x00024AFD
		public static float NM2LBIN(float _nm_)
		{
			return _nm_ * 0.08333f * 0.06852f;
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x00025B0C File Offset: 0x00024B0C
		public static float CFM2CMS(float _cfm_)
		{
			return _cfm_ * 0.028317f * 0.01667f;
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x00025B1B File Offset: 0x00024B1B
		public static float CMS2CFM(float _cms_)
		{
			return _cms_ * 35.315f * 60f;
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x00025B2A File Offset: 0x00024B2A
		public static float FAHR2CELSIUS(float _fahr_)
		{
			return _fahr_ * -32f * 0.5555556f;
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x00025B39 File Offset: 0x00024B39
		public static float CELSIUS2FAHR(float _celsius_)
		{
			return _celsius_ * 1.8f + 32f;
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x00025B48 File Offset: 0x00024B48
		public static float DEG2RAD(float _deg_)
		{
			return _deg_ * 0.017453f;
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x00025B51 File Offset: 0x00024B51
		public static float RAD2DEG(float _rad_)
		{
			return _rad_ * 57.29578f;
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x00025B5A File Offset: 0x00024B5A
		public static float DEG2ANGLE(float _deg_)
		{
			return _deg_ * 0.00277778f;
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x00025B63 File Offset: 0x00024B63
		public static float ANGLE2DEG(float _arc_)
		{
			return _arc_ * 360f;
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x00025B6C File Offset: 0x00024B6C
		public static float RAD2ANGLE(float _rad_)
		{
			return _rad_ * 0.159154937f;
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x00025B75 File Offset: 0x00024B75
		public static float ANGLE2RAD(float _arc_)
		{
			return _arc_ * 6.28318548f;
		}

		// Token: 0x0600154D RID: 5453 RVA: 0x00025B7E File Offset: 0x00024B7E
		public static float RPS2RPM(float _rps_)
		{
			return _rps_ * 60f * 0.159154937f;
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x00025B8D File Offset: 0x00024B8D
		public static float RPM2RPS(float _rpm_)
		{
			return _rpm_ * 6.28318548f / 60f;
		}
	}
}
