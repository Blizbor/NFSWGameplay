using System;
using System.Collections.Generic;
using EASharp;
using GameCore.Math;

namespace GameCore
{
	// Token: 0x0200024A RID: 586
	[Export]
	public class PoiManager
	{
		// Token: 0x060017BD RID: 6077 RVA: 0x0002A5AD File Offset: 0x000295AD
		internal PoiManager(Manager manager)
		{
			this.manager = manager;
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x0002A5C7 File Offset: 0x000295C7
		internal void Ready()
		{
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x0002A5CC File Offset: 0x000295CC
		internal void Cleanup()
		{
			foreach (PointOfInterest pointOfInterest in this.pointsOfInterest)
			{
				pointOfInterest.Dispose();
			}
			this.pointsOfInterest.Clear();
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x0002A62C File Offset: 0x0002962C
		public PointOfInterest Create(uint key, uint poiType, Vector3 position, float rotation)
		{
			InternalInstance internalInstance = InstanceCatalog.Get().Find(poiType);
			if (null != internalInstance)
			{
				PointOfInterest pointOfInterest = new PointOfInterest(this.manager, key, internalInstance, position, rotation);
				this.pointsOfInterest.Add(pointOfInterest);
				return pointOfInterest;
			}
			return null;
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x0002A66E File Offset: 0x0002966E
		public void Dispose(PointOfInterest poi)
		{
			this.pointsOfInterest.Remove(poi);
			poi.Dispose();
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x0002A684 File Offset: 0x00029684
		public void DisposeAll(uint type)
		{
			PointOfInterest[] array = new PointOfInterest[this.pointsOfInterest.Count];
			this.pointsOfInterest.CopyTo(array);
			foreach (PointOfInterest pointOfInterest in array)
			{
				if (pointOfInterest.IsTypeOf(type))
				{
					this.Dispose(pointOfInterest);
				}
			}
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x0002A6D4 File Offset: 0x000296D4
		public void EnableAll(uint type)
		{
			foreach (PointOfInterest pointOfInterest in this.pointsOfInterest)
			{
				if (pointOfInterest.IsTypeOf(type))
				{
					pointOfInterest.Enable();
				}
			}
		}

		// Token: 0x060017C4 RID: 6084 RVA: 0x0002A730 File Offset: 0x00029730
		public void DisableAll(uint type)
		{
			foreach (PointOfInterest pointOfInterest in this.pointsOfInterest)
			{
				if (pointOfInterest.IsTypeOf(type))
				{
					pointOfInterest.Disable();
				}
			}
		}

		// Token: 0x060017C5 RID: 6085 RVA: 0x0002A78C File Offset: 0x0002978C
		public void ShowAllOnSection(uint type, int sectionId)
		{
			foreach (PointOfInterest pointOfInterest in this.pointsOfInterest)
			{
				if (pointOfInterest.IsTypeOf(type) && (-1 == sectionId || pointOfInterest.Token.IsOnSection(sectionId)))
				{
					pointOfInterest.Show();
				}
			}
		}

		// Token: 0x060017C6 RID: 6086 RVA: 0x0002A7FC File Offset: 0x000297FC
		public void HideAllNearPoint(uint type, Vector3 position, float radius)
		{
			foreach (PointOfInterest pointOfInterest in this.pointsOfInterest)
			{
				if (pointOfInterest.IsTypeOf(type) && pointOfInterest.Token.IsNear(position, radius))
				{
					pointOfInterest.Hide();
				}
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060017C7 RID: 6087 RVA: 0x0002A868 File Offset: 0x00029868
		internal Manager Manager
		{
			get
			{
				return this.manager;
			}
		}

		// Token: 0x040005C8 RID: 1480
		private List<PointOfInterest> pointsOfInterest = new List<PointOfInterest>();

		// Token: 0x040005C9 RID: 1481
		private readonly Manager manager;
	}
}
