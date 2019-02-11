using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;
using GameCore.Math;

namespace GameCore
{
	// Token: 0x02000028 RID: 40
	[ExportOnlyCreate(false)]
	public class Cameras : ExposedCommonBase
	{
		// Token: 0x06000052 RID: 82 RVA: 0x000025C8 File Offset: 0x000015C8
		public unsafe static Cameras CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new Cameras(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000025EB File Offset: 0x000015EB
		public unsafe Cameras(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000025F5 File Offset: 0x000015F5
		protected internal Cameras(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000025FE File Offset: 0x000015FE
		protected internal unsafe Cameras(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000056 RID: 86
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_26(void* self);

		// Token: 0x06000057 RID: 87 RVA: 0x00002608 File Offset: 0x00001608
		[DisableExceptionHandling]
		~Cameras()
		{
			Cameras._EASharpBinding_26(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000058 RID: 88
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_27();

		// Token: 0x06000059 RID: 89 RVA: 0x00002644 File Offset: 0x00001644
		public static void ClearAllBounds()
		{
			Cameras._EASharpBinding_27();
		}

		// Token: 0x0600005A RID: 90
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_28(float posX, float posY, float posZ, float height, float radius);

		// Token: 0x0600005B RID: 91 RVA: 0x0000264B File Offset: 0x0000164B
		public static void AssignCylinderBounds(float posX, float posY, float posZ, float height, float radius)
		{
			Cameras._EASharpBinding_28(posX, posY, posZ, height, radius);
		}

		// Token: 0x0600005C RID: 92
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_29(void* world_position);

		// Token: 0x0600005D RID: 93 RVA: 0x00002658 File Offset: 0x00001658
		public static Vector2 WorldToScreenPosition(Vector3 world_position)
		{
			return new Vector2(default(ExposeTag_InitOwned), Cameras._EASharpBinding_29(object.ReferenceEquals(world_position, null) ? null : world_position._GetRaw()));
		}

		// Token: 0x0600005E RID: 94
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_30(void* world_position);

		// Token: 0x0600005F RID: 95 RVA: 0x00002690 File Offset: 0x00001690
		public static float TopDownAngleToCamera(Vector3 world_position)
		{
			return Cameras._EASharpBinding_30(object.ReferenceEquals(world_position, null) ? null : world_position._GetRaw());
		}

		// Token: 0x06000060 RID: 96
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_31(void* world_position);

		// Token: 0x06000061 RID: 97 RVA: 0x000026B8 File Offset: 0x000016B8
		public static Vector2 TopDownDirectionToCamera(Vector3 world_position)
		{
			return new Vector2(default(ExposeTag_InitOwned), Cameras._EASharpBinding_31(object.ReferenceEquals(world_position, null) ? null : world_position._GetRaw()));
		}

		// Token: 0x06000062 RID: 98
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_32(void* world_position);

		// Token: 0x06000063 RID: 99 RVA: 0x000026F0 File Offset: 0x000016F0
		public static float GetDistanceToCamera(Vector3 world_position)
		{
			return Cameras._EASharpBinding_32(object.ReferenceEquals(world_position, null) ? null : world_position._GetRaw());
		}

		// Token: 0x06000064 RID: 100
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_33(sbyte* cameraName);

		// Token: 0x06000065 RID: 101 RVA: 0x00002718 File Offset: 0x00001718
		public unsafe static void Set(string cameraName)
		{
			int byteCount = Encoding.ASCII.GetByteCount(cameraName);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(cameraName, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				Cameras._EASharpBinding_33((sbyte*)ptr);
			}
		}
	}
}
