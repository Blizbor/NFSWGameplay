using System;
using System.Runtime.InteropServices;
using EASharp;

// Token: 0x020000E0 RID: 224
[ExportOnlyCreate(true)]
public class GCollectionKey : ExposedCommonBase
{
	// Token: 0x06000DD2 RID: 3538 RVA: 0x0001095C File Offset: 0x0000F95C
	public unsafe static GCollectionKey CreateInitUnowned(void* self)
	{
		if (self != null)
		{
			return new GCollectionKey(default(ExposeTag_InitUnowned), self);
		}
		return null;
	}

	// Token: 0x06000DD3 RID: 3539 RVA: 0x0001097F File Offset: 0x0000F97F
	public unsafe GCollectionKey(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
	{
	}

	// Token: 0x06000DD4 RID: 3540 RVA: 0x00010989 File Offset: 0x0000F989
	protected internal GCollectionKey(ExposeTag_NoInitOwned tag) : base(tag)
	{
	}

	// Token: 0x06000DD5 RID: 3541 RVA: 0x00010992 File Offset: 0x0000F992
	protected internal unsafe GCollectionKey(ExposeTag_InitOwned tag, void* self) : base(tag, self)
	{
	}

	// Token: 0x06000DD6 RID: 3542
	[DoesNotBlock]
	[DllImport("<internal>")]
	private unsafe static extern void _EASharpBinding_1408(void* self);

	// Token: 0x06000DD7 RID: 3543 RVA: 0x0001099C File Offset: 0x0000F99C
	[DisableExceptionHandling]
	~GCollectionKey()
	{
		GCollectionKey._EASharpBinding_1408(this.mSelf);
		this.mSelf = null;
	}

	// Token: 0x06000DD8 RID: 3544
	[DllImport("<internal>")]
	private unsafe static extern void* _EASharpBinding_1409(uint key);

	// Token: 0x06000DD9 RID: 3545 RVA: 0x000109D8 File Offset: 0x0000F9D8
	public GCollectionKey(uint key) : base(default(ExposeTag_NoInitOwned))
	{
		this.mSelf = GCollectionKey._EASharpBinding_1409(key);
	}

	// Token: 0x06000DDA RID: 3546
	[DllImport("<internal>")]
	private unsafe static extern uint _EASharpBinding_1410(void* _ThisPtr);

	// Token: 0x06000DDB RID: 3547 RVA: 0x00010A00 File Offset: 0x0000FA00
	public uint GetCollectionKey()
	{
		return GCollectionKey._EASharpBinding_1410(this.mSelf);
	}
}
