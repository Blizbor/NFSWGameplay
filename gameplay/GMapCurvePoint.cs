using System;
using System.Runtime.InteropServices;
using EASharp;

// Token: 0x020000E8 RID: 232
[ExportOnlyCreate(true)]
public class GMapCurvePoint : ExposedCommonBase
{
	// Token: 0x06000DE6 RID: 3558 RVA: 0x00010AB4 File Offset: 0x0000FAB4
	public unsafe static GMapCurvePoint CreateInitUnowned(void* self)
	{
		if (self != null)
		{
			return new GMapCurvePoint(default(ExposeTag_InitUnowned), self);
		}
		return null;
	}

	// Token: 0x06000DE7 RID: 3559 RVA: 0x00010AD7 File Offset: 0x0000FAD7
	public unsafe GMapCurvePoint(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
	{
	}

	// Token: 0x06000DE8 RID: 3560 RVA: 0x00010AE1 File Offset: 0x0000FAE1
	protected internal GMapCurvePoint(ExposeTag_NoInitOwned tag) : base(tag)
	{
	}

	// Token: 0x06000DE9 RID: 3561 RVA: 0x00010AEA File Offset: 0x0000FAEA
	protected internal unsafe GMapCurvePoint(ExposeTag_InitOwned tag, void* self) : base(tag, self)
	{
	}

	// Token: 0x06000DEA RID: 3562
	[DoesNotBlock]
	[DllImport("<internal>")]
	private unsafe static extern void _EASharpBinding_1414(void* self);

	// Token: 0x06000DEB RID: 3563 RVA: 0x00010AF4 File Offset: 0x0000FAF4
	[DisableExceptionHandling]
	~GMapCurvePoint()
	{
		GMapCurvePoint._EASharpBinding_1414(this.mSelf);
		this.mSelf = null;
	}

	// Token: 0x06000DEC RID: 3564
	[DllImport("<internal>")]
	private unsafe static extern void _EASharpBinding_1415(void* self, float val);

	// Token: 0x06000DED RID: 3565
	[DllImport("<internal>")]
	private unsafe static extern float _EASharpBinding_1416(void* self);

	// Token: 0x170000F9 RID: 249
	// (get) Token: 0x06000DEE RID: 3566 RVA: 0x00010B30 File Offset: 0x0000FB30
	// (set) Token: 0x06000DEF RID: 3567 RVA: 0x00010B3D File Offset: 0x0000FB3D
	public float mX
	{
		get
		{
			return GMapCurvePoint._EASharpBinding_1416(this.mSelf);
		}
		set
		{
			GMapCurvePoint._EASharpBinding_1415(this.mSelf, value);
		}
	}

	// Token: 0x06000DF0 RID: 3568
	[DllImport("<internal>")]
	private unsafe static extern void _EASharpBinding_1417(void* self, float val);

	// Token: 0x06000DF1 RID: 3569
	[DllImport("<internal>")]
	private unsafe static extern float _EASharpBinding_1418(void* self);

	// Token: 0x170000FA RID: 250
	// (get) Token: 0x06000DF2 RID: 3570 RVA: 0x00010B4B File Offset: 0x0000FB4B
	// (set) Token: 0x06000DF3 RID: 3571 RVA: 0x00010B58 File Offset: 0x0000FB58
	public float mY
	{
		get
		{
			return GMapCurvePoint._EASharpBinding_1418(this.mSelf);
		}
		set
		{
			GMapCurvePoint._EASharpBinding_1417(this.mSelf, value);
		}
	}
}
