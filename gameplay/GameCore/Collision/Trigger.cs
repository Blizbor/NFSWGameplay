using System;
using System.Collections.Generic;
using EASharp;
using GameCore.Data;
using GameCore.Math;

namespace GameCore.Collision
{
	// Token: 0x020001E6 RID: 486
	[Export]
	public class Trigger : IDisposable
	{
		// Token: 0x060014D7 RID: 5335 RVA: 0x00024F34 File Offset: 0x00023F34
		[NoExport]
		private Trigger(uint fingerPrint)
		{
			this.internalTrigger = new InternalTrigger(fingerPrint);
			this.handle = (Trigger.counter += 1u);
			Trigger.triggers.Add((long)((ulong)this.handle), this);
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x00024F84 File Offset: 0x00023F84
		[NoExport]
		public Trigger(uint fingerPrint, TriggerType type, Vector3 position, float radius, float rotation) : this(fingerPrint)
		{
			switch (type)
			{
			case TriggerType.Cylinder:
				this.internalTrigger.ConfigureCylinder(this.handle, position, radius, rotation);
				return;
			case TriggerType.Box:
				break;
			case TriggerType.Plane:
				this.internalTrigger.ConfigurePlane(this.handle, position, radius, rotation);
				break;
			default:
				return;
			}
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x00024FDC File Offset: 0x00023FDC
		[NoExport]
		public Trigger(uint fingerPrint, TriggerType type, Vector3 position, Vector3 dimensions, float rotation) : this(fingerPrint)
		{
			this.internalTrigger.ConfigureBox(this.handle, position, dimensions, rotation);
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x00024FFC File Offset: 0x00023FFC
		[NoExport]
		~Trigger()
		{
			this.Dispose(false);
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x0002502C File Offset: 0x0002402C
		public void Enable()
		{
			this.inside.Clear();
			this.internalTrigger.Enable();
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x00025044 File Offset: 0x00024044
		public void Disable()
		{
			this.inside.Clear();
			this.internalTrigger.Disable();
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x0002505C File Offset: 0x0002405C
		public static void NotifyCollision(uint trigger, long personaId, int triggerStimulus)
		{
			if (Trigger.triggers.ContainsKey((long)((ulong)trigger)))
			{
				Trigger trigger2 = Trigger.triggers[(long)((ulong)trigger)];
				if (trigger2 != null)
				{
					trigger2.NotifyCollision(personaId, (TriggerStimulus)triggerStimulus);
				}
			}
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x00025090 File Offset: 0x00024090
		private void NotifyCollision(long personaId, TriggerStimulus triggerStimulus)
		{
			bool flag = triggerStimulus == TriggerStimulus.kEntry;
			bool flag2 = triggerStimulus == TriggerStimulus.kExit;
			bool flag3 = this.IsInside(personaId);
			if (flag2)
			{
				this.MarkAsOutside(personaId);
				this.OnExited(new TriggerEventArgs(personaId));
			}
			if (flag)
			{
				this.OnInside(new TriggerEventArgs(personaId));
				if (!flag3)
				{
					this.MarkAsInside(personaId);
					this.OnEntered(new TriggerEventArgs(personaId));
				}
			}
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x000250EA File Offset: 0x000240EA
		private void MarkAsInside(long personaId)
		{
			if (!this.inside.Contains(personaId))
			{
				this.inside.Add(personaId);
			}
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x00025106 File Offset: 0x00024106
		private void MarkAsOutside(long personaId)
		{
			this.inside.Remove(personaId);
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x00025118 File Offset: 0x00024118
		private bool IsInside(long personaId)
		{
			return this.inside.Contains(personaId);
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x00025133 File Offset: 0x00024133
		protected virtual void OnEntered(TriggerEventArgs e)
		{
			if (this.Entered != null)
			{
				this.Entered(this, e);
			}
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x0002514A File Offset: 0x0002414A
		protected virtual void OnInside(TriggerEventArgs e)
		{
			if (this.Inside != null)
			{
				this.Inside(this, e);
			}
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x00025161 File Offset: 0x00024161
		protected virtual void OnExited(TriggerEventArgs e)
		{
			if (this.Exited != null)
			{
				this.Exited(this, e);
			}
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x00025178 File Offset: 0x00024178
		internal void CollectionChanged(Collection collection)
		{
			switch (collection.CollisionType())
			{
			case TriggerType.Cylinder:
				this.internalTrigger.ConfigureCylinder(this.handle, collection.Position(), collection.Radius(), collection.Rotation());
				return;
			case TriggerType.Box:
				this.internalTrigger.ConfigureBox(this.handle, collection.Position(), collection.Dimensions(), collection.Rotation());
				return;
			case TriggerType.Plane:
				this.internalTrigger.ConfigurePlane(this.handle, collection.Position(), collection.Radius(), collection.Rotation());
				return;
			default:
				return;
			}
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x0002520E File Offset: 0x0002420E
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x0002521D File Offset: 0x0002421D
		protected virtual void Dispose(bool disposing)
		{
			if (!this.isDisposed)
			{
				this.Entered = null;
				this.Exited = null;
				this.Inside = null;
				this.Disable();
				Trigger.triggers.Remove((long)((ulong)this.handle));
				this.isDisposed = true;
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060014E8 RID: 5352 RVA: 0x0002525B File Offset: 0x0002425B
		// (remove) Token: 0x060014E9 RID: 5353 RVA: 0x00025274 File Offset: 0x00024274
		public event EventHandler<TriggerEventArgs> Entered;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060014EA RID: 5354 RVA: 0x0002528D File Offset: 0x0002428D
		// (remove) Token: 0x060014EB RID: 5355 RVA: 0x000252A6 File Offset: 0x000242A6
		public event EventHandler<TriggerEventArgs> Inside;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060014EC RID: 5356 RVA: 0x000252BF File Offset: 0x000242BF
		// (remove) Token: 0x060014ED RID: 5357 RVA: 0x000252D8 File Offset: 0x000242D8
		public event EventHandler<TriggerEventArgs> Exited;

		// Token: 0x040004E8 RID: 1256
		private readonly InternalTrigger internalTrigger;

		// Token: 0x040004E9 RID: 1257
		private readonly uint handle;

		// Token: 0x040004EA RID: 1258
		private List<long> inside = new List<long>();

		// Token: 0x040004EB RID: 1259
		private static Dictionary<long, Trigger> triggers = new Dictionary<long, Trigger>();

		// Token: 0x040004EC RID: 1260
		private static uint counter = 0u;

		// Token: 0x040004ED RID: 1261
		private bool isDisposed;
	}
}
