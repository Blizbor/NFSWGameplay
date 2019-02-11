using System;
using System.IO;
using GameCore.Data;
using GameCore.Math;
using GameCore.Opponents;
using Interop;
using UMath;

namespace GameCore.Radar
{
	// Token: 0x02000272 RID: 626
	public class CoinRadarMethod : IRadarMethod
	{
		// Token: 0x06001894 RID: 6292 RVA: 0x0002B7B7 File Offset: 0x0002A7B7
		public static object Construct(BinaryReader source)
		{
			return new CoinRadarMethod();
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x0002B7C0 File Offset: 0x0002A7C0
		public CoinRadarMethod()
		{
			Collection collection = new Collection(3991467266u);
			this.radarNearMin = collection.RadarDistanceNearRangeMin();
			this.radarMediumMin = collection.RadarDistanceMediumRangeMin();
			this.radarFarMin = collection.RadarDistanceFarRangeMin();
			this.radarFarMax = collection.RadarDistanceFarRangeMax();
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x0002B828 File Offset: 0x0002A828
		public void Fill(RadarTracker tracker, Event evnt)
		{
			LocalHumanOpponent localHumanOpponent = Engine.Get().OpponentManager().FindLocalOpponent();
			double num = double.MaxValue;
			Collection collection = null;
			for (uint num2 = 0u; num2 < evnt.EventDef.Num_Coins(); num2 += 1u)
			{
				Collection collection2 = new Collection(evnt.EventDef.Coins(num2).GetCollectionKey());
				uint collectionKey = collection2.GetCollection();
				PointOfInterest pointOfInterest = evnt.PointsOfInterest.Find((PointOfInterest x) => x.Key == collectionKey);
				if (pointOfInterest != null && pointOfInterest.IsEnabled())
				{
					double num3 = (double)GameCore.Math.Math.DistanceXZ2(localHumanOpponent.Vehicle.GetPosition(), CoordSys.RenderToSim(collection2.Position()));
					if (num3 < num)
					{
						num = num3;
						collection = collection2;
					}
				}
			}
			tracker.Enabled = false;
			tracker.SetMovieClipName("Treasure");
			if (collection != null)
			{
				GameCore.Math.Vector3 vector = CoordSys.RenderToSim(collection.Position());
				GameCore.Math.Vector3 p = new GameCore.Math.Vector3(localHumanOpponent.Vehicle.GetPosition());
				GameCore.Math.Math.Sub(ref vector, p);
				double num4 = System.Math.Sqrt(GameCore.Math.Math.LengthSq(vector));
				if (num4 > (double)this.radarFarMax || num4 < (double)this.radarNearMin)
				{
					tracker.Enabled = false;
					tracker.Distance = RadarDistance.kRadarDistance_OutOfRange;
					return;
				}
				tracker.Enabled = true;
				tracker.Distance = RadarDistance.kRadarDistance_Far;
				if (num4 < (double)this.radarMediumMin)
				{
					tracker.Distance = RadarDistance.kRadarDistance_Near;
				}
				else if (num4 < (double)this.radarFarMin)
				{
					tracker.Distance = RadarDistance.kRadarDistance_Medium;
				}
				UMath.Vector3 direction = localHumanOpponent.Vehicle.GetDirection();
				GameCore.Math.Vector2 p2 = new GameCore.Math.Vector2(direction.x, direction.z);
				GameCore.Math.Vector2 p3 = new GameCore.Math.Vector2(vector.x, vector.z);
				GameCore.Math.Math.Normalize(ref p3);
				float num5 = (float)System.Math.Acos((double)GameCore.Math.Math.Clamp<float>(GameCore.Math.Math.Dot(p2, p3), -1f, 1f));
				if (GameCore.Math.Math.Cross(p2, p3) < 0f)
				{
					num5 = -num5;
				}
				tracker.DirectionDeg = Conversions.RAD2DEG(num5);
			}
		}

		// Token: 0x0400061D RID: 1565
		private float radarNearMin;

		// Token: 0x0400061E RID: 1566
		private float radarMediumMin;

		// Token: 0x0400061F RID: 1567
		private float radarFarMin;

		// Token: 0x04000620 RID: 1568
		private float radarFarMax;
	}
}
