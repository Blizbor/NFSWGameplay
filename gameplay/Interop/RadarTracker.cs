using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;
using GameCore;

namespace Interop
{
	// Token: 0x020000C2 RID: 194
	[ExportOnlyCreate(true)]
	public class RadarTracker : ISerializable
	{
		// Token: 0x06000B8E RID: 2958 RVA: 0x0000E750 File Offset: 0x0000D750
		public new unsafe static RadarTracker CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new RadarTracker(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x0000E773 File Offset: 0x0000D773
		public unsafe RadarTracker(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x0000E77D File Offset: 0x0000D77D
		protected internal RadarTracker(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x0000E786 File Offset: 0x0000D786
		protected internal unsafe RadarTracker(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000B92 RID: 2962
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1174();

		// Token: 0x06000B93 RID: 2963 RVA: 0x0000E790 File Offset: 0x0000D790
		public RadarTracker() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = RadarTracker._EASharpBinding_1174();
		}

		// Token: 0x06000B94 RID: 2964
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1175(void* _ThisPtr);

		// Token: 0x06000B95 RID: 2965 RVA: 0x0000E7B8 File Offset: 0x0000D7B8
		~RadarTracker()
		{
			RadarTracker._EASharpBinding_1175(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000B96 RID: 2966
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1176(void* _ThisPtr, sbyte* value);

		// Token: 0x06000B97 RID: 2967 RVA: 0x0000E7F4 File Offset: 0x0000D7F4
		public unsafe void SetMovieClipName(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				RadarTracker._EASharpBinding_1176(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000B98 RID: 2968
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1177(void* self, float val);

		// Token: 0x06000B99 RID: 2969
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_1178(void* self);

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000B9A RID: 2970 RVA: 0x0000E851 File Offset: 0x0000D851
		// (set) Token: 0x06000B9B RID: 2971 RVA: 0x0000E85E File Offset: 0x0000D85E
		public float DirectionDeg
		{
			get
			{
				return RadarTracker._EASharpBinding_1178(this.mSelf);
			}
			set
			{
				RadarTracker._EASharpBinding_1177(this.mSelf, value);
			}
		}

		// Token: 0x06000B9C RID: 2972
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1179(void* self, int val);

		// Token: 0x06000B9D RID: 2973
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1180(void* self);

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000B9E RID: 2974 RVA: 0x0000E86C File Offset: 0x0000D86C
		// (set) Token: 0x06000B9F RID: 2975 RVA: 0x0000E879 File Offset: 0x0000D879
		public RadarDistance Distance
		{
			get
			{
				return (RadarDistance)RadarTracker._EASharpBinding_1180(this.mSelf);
			}
			set
			{
				RadarTracker._EASharpBinding_1179(this.mSelf, (int)value);
			}
		}

		// Token: 0x06000BA0 RID: 2976
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1181(void* self, bool val);

		// Token: 0x06000BA1 RID: 2977
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_1182(void* self);

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000BA2 RID: 2978 RVA: 0x0000E887 File Offset: 0x0000D887
		// (set) Token: 0x06000BA3 RID: 2979 RVA: 0x0000E894 File Offset: 0x0000D894
		public bool Enabled
		{
			get
			{
				return RadarTracker._EASharpBinding_1182(this.mSelf);
			}
			set
			{
				RadarTracker._EASharpBinding_1181(this.mSelf, value);
			}
		}
	}
}
