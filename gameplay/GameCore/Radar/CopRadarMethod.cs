using System;
using System.IO;
using GameCore.Data;
using GameCore.Math;
using GameCore.Opponents;
using Interop;
using Victory.Data.Objects.Customization;

namespace GameCore.Radar
{
	// Token: 0x02000273 RID: 627
	public class CopRadarMethod : IRadarMethod
	{
		// Token: 0x06001897 RID: 6295 RVA: 0x0002BA13 File Offset: 0x0002AA13
		public static object Construct(BinaryReader source)
		{
			return new CopRadarMethod();
		}

		// Token: 0x06001898 RID: 6296 RVA: 0x0002BA1C File Offset: 0x0002AA1C
		public CopRadarMethod()
		{
			Collection collection = new Collection(3737842652u);
			this.radarNearMin = collection.RadarDistanceNearRangeMin();
			this.radarMediumMin = collection.RadarDistanceMediumRangeMin();
			this.radarFarMin = collection.RadarDistanceFarRangeMin();
			this.radarFarMax = collection.RadarDistanceFarRangeMax();
		}

		// Token: 0x06001899 RID: 6297 RVA: 0x0002BA6C File Offset: 0x0002AA6C
		public unsafe void Fill(RadarTracker tracker, Event evnt)
		{
			LocalHumanOpponent localHumanOpponent = Engine.Get().OpponentManager().FindLocalOpponent();
			tracker.Enabled = false;
			tracker.SetMovieClipName("Cop");
			float num = 0f;
			localHumanOpponent.Vehicle.GetSkillModEffectAmount(SkillModEffectType.Radar, &num);
			float rad_ = 0f;
			float num2 = 0f;
			Cops.GetClosestCopDirectionAndDistance(&rad_, &num2);
			if ((double)num2 <= 0.0 || num2 > this.radarFarMax || num2 < this.radarNearMin || num2 < num)
			{
				tracker.Enabled = false;
				tracker.Distance = RadarDistance.kRadarDistance_OutOfRange;
				return;
			}
			tracker.Enabled = true;
			tracker.Distance = RadarDistance.kRadarDistance_Far;
			if (num2 < this.radarMediumMin)
			{
				tracker.Distance = RadarDistance.kRadarDistance_Near;
			}
			else if (num2 < this.radarFarMin)
			{
				tracker.Distance = RadarDistance.kRadarDistance_Medium;
			}
			tracker.DirectionDeg = Conversions.RAD2DEG(rad_);
		}

		// Token: 0x04000621 RID: 1569
		private float radarNearMin;

		// Token: 0x04000622 RID: 1570
		private float radarMediumMin;

		// Token: 0x04000623 RID: 1571
		private float radarFarMin;

		// Token: 0x04000624 RID: 1572
		private float radarFarMax;
	}
}
