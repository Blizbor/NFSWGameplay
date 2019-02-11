using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

// Token: 0x020000EF RID: 239
[ExportOnlyCreate(true)]
public class GMapRegionInfo : ExposedCommonBase
{
	// Token: 0x06000E36 RID: 3638 RVA: 0x00010ED0 File Offset: 0x0000FED0
	public unsafe static GMapRegionInfo CreateInitUnowned(void* self)
	{
		if (self != null)
		{
			return new GMapRegionInfo(default(ExposeTag_InitUnowned), self);
		}
		return null;
	}

	// Token: 0x06000E37 RID: 3639 RVA: 0x00010EF3 File Offset: 0x0000FEF3
	public unsafe GMapRegionInfo(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
	{
	}

	// Token: 0x06000E38 RID: 3640 RVA: 0x00010EFD File Offset: 0x0000FEFD
	protected internal GMapRegionInfo(ExposeTag_NoInitOwned tag) : base(tag)
	{
	}

	// Token: 0x06000E39 RID: 3641 RVA: 0x00010F06 File Offset: 0x0000FF06
	protected internal unsafe GMapRegionInfo(ExposeTag_InitOwned tag, void* self) : base(tag, self)
	{
	}

	// Token: 0x06000E3A RID: 3642
	[DoesNotBlock]
	[DllImport("<internal>")]
	private unsafe static extern void _EASharpBinding_1442(void* self);

	// Token: 0x06000E3B RID: 3643 RVA: 0x00010F10 File Offset: 0x0000FF10
	[DisableExceptionHandling]
	~GMapRegionInfo()
	{
		GMapRegionInfo._EASharpBinding_1442(this.mSelf);
		this.mSelf = null;
	}

	// Token: 0x06000E3C RID: 3644
	[DllImport("<internal>")]
	private unsafe static extern void _EASharpBinding_1443(void* self, sbyte* val);

	// Token: 0x06000E3D RID: 3645
	[DllImport("<internal>")]
	private unsafe static extern sbyte* _EASharpBinding_1444(void* self);

	// Token: 0x17000104 RID: 260
	// (get) Token: 0x06000E3E RID: 3646 RVA: 0x00010F4C File Offset: 0x0000FF4C
	// (set) Token: 0x06000E3F RID: 3647 RVA: 0x00010F60 File Offset: 0x0000FF60
	public unsafe string mName
	{
		get
		{
			return InternalUtil.ConvertFromCString(GMapRegionInfo._EASharpBinding_1444(this.mSelf));
		}
		set
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				GMapRegionInfo._EASharpBinding_1443(this.mSelf, (sbyte*)ptr);
			}
		}
	}

	// Token: 0x06000E40 RID: 3648
	[DllImport("<internal>")]
	private unsafe static extern void _EASharpBinding_1445(void* self, ushort val);

	// Token: 0x06000E41 RID: 3649
	[DllImport("<internal>")]
	private unsafe static extern ushort _EASharpBinding_1446(void* self);

	// Token: 0x17000105 RID: 261
	// (get) Token: 0x06000E42 RID: 3650 RVA: 0x00010FBD File Offset: 0x0000FFBD
	// (set) Token: 0x06000E43 RID: 3651 RVA: 0x00010FCA File Offset: 0x0000FFCA
	public ushort mCurveStart
	{
		get
		{
			return GMapRegionInfo._EASharpBinding_1446(this.mSelf);
		}
		set
		{
			GMapRegionInfo._EASharpBinding_1445(this.mSelf, value);
		}
	}

	// Token: 0x06000E44 RID: 3652
	[DllImport("<internal>")]
	private unsafe static extern void _EASharpBinding_1447(void* self, ushort val);

	// Token: 0x06000E45 RID: 3653
	[DllImport("<internal>")]
	private unsafe static extern ushort _EASharpBinding_1448(void* self);

	// Token: 0x17000106 RID: 262
	// (get) Token: 0x06000E46 RID: 3654 RVA: 0x00010FD8 File Offset: 0x0000FFD8
	// (set) Token: 0x06000E47 RID: 3655 RVA: 0x00010FE5 File Offset: 0x0000FFE5
	public ushort mCurveCount
	{
		get
		{
			return GMapRegionInfo._EASharpBinding_1448(this.mSelf);
		}
		set
		{
			GMapRegionInfo._EASharpBinding_1447(this.mSelf, value);
		}
	}

	// Token: 0x06000E48 RID: 3656
	[DllImport("<internal>")]
	private unsafe static extern void _EASharpBinding_1449(void* self, ushort val);

	// Token: 0x06000E49 RID: 3657
	[DllImport("<internal>")]
	private unsafe static extern ushort _EASharpBinding_1450(void* self);

	// Token: 0x17000107 RID: 263
	// (get) Token: 0x06000E4A RID: 3658 RVA: 0x00010FF3 File Offset: 0x0000FFF3
	// (set) Token: 0x06000E4B RID: 3659 RVA: 0x00011000 File Offset: 0x00010000
	public ushort mTriangleStart
	{
		get
		{
			return GMapRegionInfo._EASharpBinding_1450(this.mSelf);
		}
		set
		{
			GMapRegionInfo._EASharpBinding_1449(this.mSelf, value);
		}
	}

	// Token: 0x06000E4C RID: 3660
	[DllImport("<internal>")]
	private unsafe static extern void _EASharpBinding_1451(void* self, ushort val);

	// Token: 0x06000E4D RID: 3661
	[DllImport("<internal>")]
	private unsafe static extern ushort _EASharpBinding_1452(void* self);

	// Token: 0x17000108 RID: 264
	// (get) Token: 0x06000E4E RID: 3662 RVA: 0x0001100E File Offset: 0x0001000E
	// (set) Token: 0x06000E4F RID: 3663 RVA: 0x0001101B File Offset: 0x0001001B
	public ushort mTriangleCount
	{
		get
		{
			return GMapRegionInfo._EASharpBinding_1452(this.mSelf);
		}
		set
		{
			GMapRegionInfo._EASharpBinding_1451(this.mSelf, value);
		}
	}
}
