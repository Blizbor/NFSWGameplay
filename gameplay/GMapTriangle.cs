using System;
using System.Runtime.InteropServices;
using EASharp;

// Token: 0x020000EE RID: 238
[ExportOnlyCreate(true)]
public class GMapTriangle : ExposedCommonBase
{
	// Token: 0x06000E24 RID: 3620 RVA: 0x00010E00 File Offset: 0x0000FE00
	public unsafe static GMapTriangle CreateInitUnowned(void* self)
	{
		if (self != null)
		{
			return new GMapTriangle(default(ExposeTag_InitUnowned), self);
		}
		return null;
	}

	// Token: 0x06000E25 RID: 3621 RVA: 0x00010E23 File Offset: 0x0000FE23
	public unsafe GMapTriangle(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
	{
	}

	// Token: 0x06000E26 RID: 3622 RVA: 0x00010E2D File Offset: 0x0000FE2D
	protected internal GMapTriangle(ExposeTag_NoInitOwned tag) : base(tag)
	{
	}

	// Token: 0x06000E27 RID: 3623 RVA: 0x00010E36 File Offset: 0x0000FE36
	protected internal unsafe GMapTriangle(ExposeTag_InitOwned tag, void* self) : base(tag, self)
	{
	}

	// Token: 0x06000E28 RID: 3624
	[DoesNotBlock]
	[DllImport("<internal>")]
	private unsafe static extern void _EASharpBinding_1435(void* self);

	// Token: 0x06000E29 RID: 3625 RVA: 0x00010E40 File Offset: 0x0000FE40
	[DisableExceptionHandling]
	~GMapTriangle()
	{
		GMapTriangle._EASharpBinding_1435(this.mSelf);
		this.mSelf = null;
	}

	// Token: 0x06000E2A RID: 3626
	[DllImport("<internal>")]
	private unsafe static extern void _EASharpBinding_1436(void* self, ushort val);

	// Token: 0x06000E2B RID: 3627
	[DllImport("<internal>")]
	private unsafe static extern ushort _EASharpBinding_1437(void* self);

	// Token: 0x17000101 RID: 257
	// (get) Token: 0x06000E2C RID: 3628 RVA: 0x00010E7C File Offset: 0x0000FE7C
	// (set) Token: 0x06000E2D RID: 3629 RVA: 0x00010E89 File Offset: 0x0000FE89
	public ushort mPoint0
	{
		get
		{
			return GMapTriangle._EASharpBinding_1437(this.mSelf);
		}
		set
		{
			GMapTriangle._EASharpBinding_1436(this.mSelf, value);
		}
	}

	// Token: 0x06000E2E RID: 3630
	[DllImport("<internal>")]
	private unsafe static extern void _EASharpBinding_1438(void* self, ushort val);

	// Token: 0x06000E2F RID: 3631
	[DllImport("<internal>")]
	private unsafe static extern ushort _EASharpBinding_1439(void* self);

	// Token: 0x17000102 RID: 258
	// (get) Token: 0x06000E30 RID: 3632 RVA: 0x00010E97 File Offset: 0x0000FE97
	// (set) Token: 0x06000E31 RID: 3633 RVA: 0x00010EA4 File Offset: 0x0000FEA4
	public ushort mPoint1
	{
		get
		{
			return GMapTriangle._EASharpBinding_1439(this.mSelf);
		}
		set
		{
			GMapTriangle._EASharpBinding_1438(this.mSelf, value);
		}
	}

	// Token: 0x06000E32 RID: 3634
	[DllImport("<internal>")]
	private unsafe static extern void _EASharpBinding_1440(void* self, ushort val);

	// Token: 0x06000E33 RID: 3635
	[DllImport("<internal>")]
	private unsafe static extern ushort _EASharpBinding_1441(void* self);

	// Token: 0x17000103 RID: 259
	// (get) Token: 0x06000E34 RID: 3636 RVA: 0x00010EB2 File Offset: 0x0000FEB2
	// (set) Token: 0x06000E35 RID: 3637 RVA: 0x00010EBF File Offset: 0x0000FEBF
	public ushort mPoint2
	{
		get
		{
			return GMapTriangle._EASharpBinding_1441(this.mSelf);
		}
		set
		{
			GMapTriangle._EASharpBinding_1440(this.mSelf, value);
		}
	}
}
