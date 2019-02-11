using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace Interop
{
	// Token: 0x020000DD RID: 221
	[ExportOnlyCreate(true)]
	public class TrackerEntity : ExposedCommonBase
	{
		// Token: 0x06000DA6 RID: 3494 RVA: 0x00010720 File Offset: 0x0000F720
		public unsafe static TrackerEntity CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new TrackerEntity(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00010743 File Offset: 0x0000F743
		public unsafe TrackerEntity(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x0001074D File Offset: 0x0000F74D
		protected internal TrackerEntity(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x00010756 File Offset: 0x0000F756
		protected internal unsafe TrackerEntity(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000DAA RID: 3498
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1388();

		// Token: 0x06000DAB RID: 3499 RVA: 0x00010760 File Offset: 0x0000F760
		public TrackerEntity() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = TrackerEntity._EASharpBinding_1388();
		}

		// Token: 0x06000DAC RID: 3500
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1389(void* _ThisPtr);

		// Token: 0x06000DAD RID: 3501 RVA: 0x00010788 File Offset: 0x0000F788
		~TrackerEntity()
		{
			TrackerEntity._EASharpBinding_1389(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000DAE RID: 3502
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1390(void* _ThisPtr, sbyte* value);

		// Token: 0x06000DAF RID: 3503 RVA: 0x000107C4 File Offset: 0x0000F7C4
		public unsafe void SetEntityName(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				TrackerEntity._EASharpBinding_1390(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000DB0 RID: 3504
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1391(void* _ThisPtr, sbyte* value);

		// Token: 0x06000DB1 RID: 3505 RVA: 0x00010824 File Offset: 0x0000F824
		public unsafe void SetClipName(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				TrackerEntity._EASharpBinding_1391(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000DB2 RID: 3506
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1392(void* self, int val);

		// Token: 0x06000DB3 RID: 3507
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1393(void* self);

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000DB4 RID: 3508 RVA: 0x00010881 File Offset: 0x0000F881
		// (set) Token: 0x06000DB5 RID: 3509 RVA: 0x0001088E File Offset: 0x0000F88E
		public int mId
		{
			get
			{
				return TrackerEntity._EASharpBinding_1393(this.mSelf);
			}
			set
			{
				TrackerEntity._EASharpBinding_1392(this.mSelf, value);
			}
		}

		// Token: 0x06000DB6 RID: 3510
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1394(void* self, float val);

		// Token: 0x06000DB7 RID: 3511
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_1395(void* self);

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x0001089C File Offset: 0x0000F89C
		// (set) Token: 0x06000DB9 RID: 3513 RVA: 0x000108A9 File Offset: 0x0000F8A9
		public float _x
		{
			get
			{
				return TrackerEntity._EASharpBinding_1395(this.mSelf);
			}
			set
			{
				TrackerEntity._EASharpBinding_1394(this.mSelf, value);
			}
		}

		// Token: 0x06000DBA RID: 3514
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1396(void* self, float val);

		// Token: 0x06000DBB RID: 3515
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_1397(void* self);

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000DBC RID: 3516 RVA: 0x000108B7 File Offset: 0x0000F8B7
		// (set) Token: 0x06000DBD RID: 3517 RVA: 0x000108C4 File Offset: 0x0000F8C4
		public float _y
		{
			get
			{
				return TrackerEntity._EASharpBinding_1397(this.mSelf);
			}
			set
			{
				TrackerEntity._EASharpBinding_1396(this.mSelf, value);
			}
		}

		// Token: 0x06000DBE RID: 3518
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1398(void* self, bool val);

		// Token: 0x06000DBF RID: 3519
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_1399(void* self);

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000DC0 RID: 3520 RVA: 0x000108D2 File Offset: 0x0000F8D2
		// (set) Token: 0x06000DC1 RID: 3521 RVA: 0x000108DF File Offset: 0x0000F8DF
		public bool _visible
		{
			get
			{
				return TrackerEntity._EASharpBinding_1399(this.mSelf);
			}
			set
			{
				TrackerEntity._EASharpBinding_1398(this.mSelf, value);
			}
		}

		// Token: 0x06000DC2 RID: 3522
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1400(void* self, float val);

		// Token: 0x06000DC3 RID: 3523
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_1401(void* self);

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000DC4 RID: 3524 RVA: 0x000108ED File Offset: 0x0000F8ED
		// (set) Token: 0x06000DC5 RID: 3525 RVA: 0x000108FA File Offset: 0x0000F8FA
		public float distance
		{
			get
			{
				return TrackerEntity._EASharpBinding_1401(this.mSelf);
			}
			set
			{
				TrackerEntity._EASharpBinding_1400(this.mSelf, value);
			}
		}

		// Token: 0x06000DC6 RID: 3526
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1402(void* self, float val);

		// Token: 0x06000DC7 RID: 3527
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_1403(void* self);

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000DC8 RID: 3528 RVA: 0x00010908 File Offset: 0x0000F908
		// (set) Token: 0x06000DC9 RID: 3529 RVA: 0x00010915 File Offset: 0x0000F915
		public float direction_x
		{
			get
			{
				return TrackerEntity._EASharpBinding_1403(this.mSelf);
			}
			set
			{
				TrackerEntity._EASharpBinding_1402(this.mSelf, value);
			}
		}

		// Token: 0x06000DCA RID: 3530
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1404(void* self, float val);

		// Token: 0x06000DCB RID: 3531
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_1405(void* self);

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000DCC RID: 3532 RVA: 0x00010923 File Offset: 0x0000F923
		// (set) Token: 0x06000DCD RID: 3533 RVA: 0x00010930 File Offset: 0x0000F930
		public float direction_y
		{
			get
			{
				return TrackerEntity._EASharpBinding_1405(this.mSelf);
			}
			set
			{
				TrackerEntity._EASharpBinding_1404(this.mSelf, value);
			}
		}

		// Token: 0x06000DCE RID: 3534
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1406(void* self, float val);

		// Token: 0x06000DCF RID: 3535
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_1407(void* self);

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000DD0 RID: 3536 RVA: 0x0001093E File Offset: 0x0000F93E
		// (set) Token: 0x06000DD1 RID: 3537 RVA: 0x0001094B File Offset: 0x0000F94B
		public float angle_to_camera
		{
			get
			{
				return TrackerEntity._EASharpBinding_1407(this.mSelf);
			}
			set
			{
				TrackerEntity._EASharpBinding_1406(this.mSelf, value);
			}
		}
	}
}
