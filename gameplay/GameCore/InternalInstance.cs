using System;
using System.Runtime.InteropServices;
using EASharp;
using GameCore.Data;

namespace GameCore
{
	// Token: 0x0200002A RID: 42
	[ExportOnlyCreate(false)]
	public class InternalInstance : InternalCollection
	{
		// Token: 0x0600009C RID: 156 RVA: 0x00002AEC File Offset: 0x00001AEC
		public new unsafe static InternalInstance CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new InternalInstance(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002B0F File Offset: 0x00001B0F
		public unsafe InternalInstance(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002B19 File Offset: 0x00001B19
		protected internal InternalInstance(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002B22 File Offset: 0x00001B22
		protected internal unsafe InternalInstance(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060000A0 RID: 160
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_189(void* self);

		// Token: 0x060000A1 RID: 161 RVA: 0x00002B2C File Offset: 0x00001B2C
		[DisableExceptionHandling]
		~InternalInstance()
		{
			InternalInstance._EASharpBinding_189(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060000A2 RID: 162
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_190(void* _ThisPtr, object changed);

		// Token: 0x060000A3 RID: 163 RVA: 0x00002B68 File Offset: 0x00001B68
		public void Register(IAttributeChanged changed)
		{
			InternalInstance._EASharpBinding_190(this.mSelf, changed);
		}

		// Token: 0x060000A4 RID: 164
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_191(void* _ThisPtr);

		// Token: 0x060000A5 RID: 165 RVA: 0x00002B76 File Offset: 0x00001B76
		public void UnRegister()
		{
			InternalInstance._EASharpBinding_191(this.mSelf);
		}

		// Token: 0x060000A6 RID: 166
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_192(void* _ThisPtr);

		// Token: 0x060000A7 RID: 167 RVA: 0x00002B84 File Offset: 0x00001B84
		public override bool IsValid()
		{
			return InternalInstance._EASharpBinding_192(this.mSelf);
		}

		// Token: 0x060000A8 RID: 168
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_193(void* _ThisPtr);

		// Token: 0x060000A9 RID: 169 RVA: 0x00002B9E File Offset: 0x00001B9E
		public override void LoadSync()
		{
			InternalInstance._EASharpBinding_193(this.mSelf);
		}

		// Token: 0x060000AA RID: 170
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_194(void* _ThisPtr, int type);

		// Token: 0x060000AB RID: 171 RVA: 0x00002BAC File Offset: 0x00001BAC
		public bool IsTypeOf(ObjType type)
		{
			return InternalInstance._EASharpBinding_194(this.mSelf, (int)type);
		}

		// Token: 0x060000AC RID: 172
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_195(void* _ThisPtr, uint flag);

		// Token: 0x060000AD RID: 173 RVA: 0x00002BC8 File Offset: 0x00001BC8
		public bool IsFlagExplicit(uint flag)
		{
			return InternalInstance._EASharpBinding_195(this.mSelf, flag);
		}

		// Token: 0x060000AE RID: 174
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_196(void* _ThisPtr, uint flag);

		// Token: 0x060000AF RID: 175 RVA: 0x00002BE4 File Offset: 0x00001BE4
		public bool IsFlagSet(uint flag)
		{
			return InternalInstance._EASharpBinding_196(this.mSelf, flag);
		}

		// Token: 0x060000B0 RID: 176
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_197(void* _ThisPtr);

		// Token: 0x060000B1 RID: 177 RVA: 0x00002C00 File Offset: 0x00001C00
		public uint GetConnectionCount()
		{
			return InternalInstance._EASharpBinding_197(this.mSelf);
		}

		// Token: 0x060000B2 RID: 178
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_198(void* _ThisPtr, uint index);

		// Token: 0x060000B3 RID: 179 RVA: 0x00002C1C File Offset: 0x00001C1C
		public InternalInstance GetConnectionAt(uint index)
		{
			return InternalInstance.CreateInitUnowned(InternalInstance._EASharpBinding_198(this.mSelf, index));
		}

		// Token: 0x060000B4 RID: 180
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_199(void* _ThisPtr);

		// Token: 0x060000B5 RID: 181 RVA: 0x00002C3C File Offset: 0x00001C3C
		public virtual IInternalBehaviorOwner BehaviorOwner()
		{
			return IInternalBehaviorOwner.CreateInitUnowned(InternalInstance._EASharpBinding_199(this.mSelf));
		}

		// Token: 0x060000B6 RID: 182
		[DllImport("<internal>")]
		private static extern int _EASharpBinding_200(int type);

		// Token: 0x060000B7 RID: 183 RVA: 0x00002C5C File Offset: 0x00001C5C
		public static int GetInstanceCount(ObjType type)
		{
			return InternalInstance._EASharpBinding_200((int)type);
		}
	}
}
