using System;
using UMath;

namespace GameCore.Math
{
	// Token: 0x020001F6 RID: 502
	public class Math
	{
		// Token: 0x06001550 RID: 5456 RVA: 0x00025BA4 File Offset: 0x00024BA4
		public static float DistanceXZ2(Vector3 p1, Vector3 p2)
		{
			return (p1.x - p2.x) * (p1.x - p2.x) + (p1.z - p2.z) * (p1.z - p2.z);
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x00025BDD File Offset: 0x00024BDD
		public static float DistanceXZ2(Vector3 p1, Vector3 p2)
		{
			return (p1.x - p2.x) * (p1.x - p2.x) + (p1.z - p2.z) * (p1.z - p2.z);
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x00025C16 File Offset: 0x00024C16
		public static void Sub(ref Vector3 p1, Vector3 p2)
		{
			p1.x -= p2.x;
			p1.y -= p2.y;
			p1.z -= p2.z;
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x00025C54 File Offset: 0x00024C54
		public static double LengthSq(Vector3 p)
		{
			return (double)(p.x * p.x + p.y * p.y + p.z * p.z);
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x00025C80 File Offset: 0x00024C80
		public static double LengthSq(Vector2 p)
		{
			return (double)(p.x * p.x + p.y * p.y);
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x00025CA0 File Offset: 0x00024CA0
		public static void Normalize(ref Vector3 p)
		{
			float num = (float)Math.Sqrt(Math.LengthSq(p));
			p.x /= num;
			p.y /= num;
			p.z /= num;
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x00025CEC File Offset: 0x00024CEC
		public static void Normalize(ref Vector2 p)
		{
			float num = (float)Math.Sqrt(Math.LengthSq(p));
			p.x /= num;
			p.y /= num;
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x00025D27 File Offset: 0x00024D27
		public static float Dot(Vector3 p1, Vector3 p2)
		{
			return p1.x * p2.x + p1.y * p2.y + p1.z * p2.z;
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x00025D52 File Offset: 0x00024D52
		public static float Dot(Vector2 p1, Vector2 p2)
		{
			return p1.x * p2.x + p1.y * p2.y;
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x00025D6F File Offset: 0x00024D6F
		public static float Cross(Vector2 p1, Vector2 p2)
		{
			return p1.x * p2.y - p2.x * p1.y;
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x00025D8C File Offset: 0x00024D8C
		public static T Clamp<T>(T value, T min, T max) where T : IComparable<T>
		{
			T result = value;
			if (result.CompareTo(min) < 0)
			{
				result = min;
			}
			if (result.CompareTo(max) > 0)
			{
				result = max;
			}
			return result;
		}

		// Token: 0x04000503 RID: 1283
		public const float PI = 3.14159274f;

		// Token: 0x04000504 RID: 1284
		public const float OOPI = 0.318309873f;

		// Token: 0x04000505 RID: 1285
		public const float TWOPI = 6.28318548f;

		// Token: 0x04000506 RID: 1286
		public const float OOTWOPI = 0.159154937f;
	}
}
