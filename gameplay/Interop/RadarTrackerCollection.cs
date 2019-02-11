using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x020000C3 RID: 195
	[ExportOnlyCreate(true)]
	public class RadarTrackerCollection : ISerializable
	{
		// Token: 0x06000BA4 RID: 2980 RVA: 0x0000E8A4 File Offset: 0x0000D8A4
		public new unsafe static RadarTrackerCollection CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new RadarTrackerCollection(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x0000E8C7 File Offset: 0x0000D8C7
		public unsafe RadarTrackerCollection(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x0000E8D1 File Offset: 0x0000D8D1
		protected internal RadarTrackerCollection(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x0000E8DA File Offset: 0x0000D8DA
		protected internal unsafe RadarTrackerCollection(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000BA8 RID: 2984
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1183();

		// Token: 0x06000BA9 RID: 2985 RVA: 0x0000E8E4 File Offset: 0x0000D8E4
		public RadarTrackerCollection() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = RadarTrackerCollection._EASharpBinding_1183();
		}

		// Token: 0x06000BAA RID: 2986
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1184(void* _ThisPtr);

		// Token: 0x06000BAB RID: 2987 RVA: 0x0000E90C File Offset: 0x0000D90C
		~RadarTrackerCollection()
		{
			RadarTrackerCollection._EASharpBinding_1184(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000BAC RID: 2988
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1185(void* _ThisPtr);

		// Token: 0x06000BAD RID: 2989 RVA: 0x0000E948 File Offset: 0x0000D948
		public virtual void Reset()
		{
			RadarTrackerCollection._EASharpBinding_1185(this.mSelf);
		}

		// Token: 0x06000BAE RID: 2990
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1186(void* _ThisPtr);

		// Token: 0x06000BAF RID: 2991 RVA: 0x0000E958 File Offset: 0x0000D958
		public RadarTracker CreateRadarTracker()
		{
			return RadarTracker.CreateInitUnowned(RadarTrackerCollection._EASharpBinding_1186(this.mSelf));
		}
	}
}
