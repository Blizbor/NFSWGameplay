using System;
using System.Runtime.InteropServices;
using EASharp;

// Token: 0x020000EB RID: 235
[ExportOnlyCreate(true)]
public class GMapCurve : ExposedCommonBase
{
	// Token: 0x06000E08 RID: 3592 RVA: 0x00010C98 File Offset: 0x0000FC98
	public unsafe static GMapCurve CreateInitUnowned(void* self)
	{
		if (self != null)
		{
			return new GMapCurve(default(ExposeTag_InitUnowned), self);
		}
		return null;
	}

	// Token: 0x06000E09 RID: 3593 RVA: 0x00010CBB File Offset: 0x0000FCBB
	public unsafe GMapCurve(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
	{
	}

	// Token: 0x06000E0A RID: 3594 RVA: 0x00010CC5 File Offset: 0x0000FCC5
	protected internal GMapCurve(ExposeTag_NoInitOwned tag) : base(tag)
	{
	}

	// Token: 0x06000E0B RID: 3595 RVA: 0x00010CCE File Offset: 0x0000FCCE
	protected internal unsafe GMapCurve(ExposeTag_InitOwned tag, void* self) : base(tag, self)
	{
	}

	// Token: 0x06000E0C RID: 3596
	[DoesNotBlock]
	[DllImport("<internal>")]
	private unsafe static extern void _EASharpBinding_1425(void* self);

	// Token: 0x06000E0D RID: 3597 RVA: 0x00010CD8 File Offset: 0x0000FCD8
	[DisableExceptionHandling]
	~GMapCurve()
	{
		GMapCurve._EASharpBinding_1425(this.mSelf);
		this.mSelf = null;
	}

	// Token: 0x06000E0E RID: 3598
	[DllImport("<internal>")]
	private unsafe static extern void _EASharpBinding_1426(void* self, ushort val);

	// Token: 0x06000E0F RID: 3599
	[DllImport("<internal>")]
	private unsafe static extern ushort _EASharpBinding_1427(void* self);

	// Token: 0x170000FD RID: 253
	// (get) Token: 0x06000E10 RID: 3600 RVA: 0x00010D14 File Offset: 0x0000FD14
	// (set) Token: 0x06000E11 RID: 3601 RVA: 0x00010D21 File Offset: 0x0000FD21
	public ushort mPointStart
	{
		get
		{
			return GMapCurve._EASharpBinding_1427(this.mSelf);
		}
		set
		{
			GMapCurve._EASharpBinding_1426(this.mSelf, value);
		}
	}

	// Token: 0x06000E12 RID: 3602
	[DllImport("<internal>")]
	private unsafe static extern void _EASharpBinding_1428(void* self, ushort val);

	// Token: 0x06000E13 RID: 3603
	[DllImport("<internal>")]
	private unsafe static extern ushort _EASharpBinding_1429(void* self);

	// Token: 0x170000FE RID: 254
	// (get) Token: 0x06000E14 RID: 3604 RVA: 0x00010D2F File Offset: 0x0000FD2F
	// (set) Token: 0x06000E15 RID: 3605 RVA: 0x00010D3C File Offset: 0x0000FD3C
	public ushort mPointCount
	{
		get
		{
			return GMapCurve._EASharpBinding_1429(this.mSelf);
		}
		set
		{
			GMapCurve._EASharpBinding_1428(this.mSelf, value);
		}
	}
}
