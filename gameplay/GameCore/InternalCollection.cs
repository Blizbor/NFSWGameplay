using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace GameCore
{
	// Token: 0x02000029 RID: 41
	[ExportOnlyCreate(false)]
	public class InternalCollection : ExposedCommonBase
	{
		// Token: 0x06000066 RID: 102 RVA: 0x00002770 File Offset: 0x00001770
		public unsafe static InternalCollection CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new InternalCollection(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002793 File Offset: 0x00001793
		public unsafe InternalCollection(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000279D File Offset: 0x0000179D
		protected internal InternalCollection(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000027A6 File Offset: 0x000017A6
		protected internal unsafe InternalCollection(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600006A RID: 106
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_132(uint classKey, uint collectionKey);

		// Token: 0x0600006B RID: 107 RVA: 0x000027B0 File Offset: 0x000017B0
		public InternalCollection(uint classKey, uint collectionKey) : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = InternalCollection._EASharpBinding_132(classKey, collectionKey);
		}

		// Token: 0x0600006C RID: 108
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_133(void* _ThisPtr);

		// Token: 0x0600006D RID: 109 RVA: 0x000027DC File Offset: 0x000017DC
		~InternalCollection()
		{
			InternalCollection._EASharpBinding_133(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x0600006E RID: 110
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_134(void* _ThisPtr);

		// Token: 0x0600006F RID: 111 RVA: 0x00002818 File Offset: 0x00001818
		public virtual void LoadSync()
		{
			InternalCollection._EASharpBinding_134(this.mSelf);
		}

		// Token: 0x06000070 RID: 112
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_135(void* _ThisPtr);

		// Token: 0x06000071 RID: 113 RVA: 0x00002828 File Offset: 0x00001828
		public virtual bool IsValid()
		{
			return InternalCollection._EASharpBinding_135(this.mSelf);
		}

		// Token: 0x06000072 RID: 114
		[DllImport("<internal>")]
		private unsafe static extern sbyte* _EASharpBinding_136(void* _ThisPtr);

		// Token: 0x06000073 RID: 115 RVA: 0x00002844 File Offset: 0x00001844
		public string GetName()
		{
			return InternalUtil.ConvertFromCString(InternalCollection._EASharpBinding_136(this.mSelf));
		}

		// Token: 0x06000074 RID: 116
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_137(void* _ThisPtr);

		// Token: 0x06000075 RID: 117 RVA: 0x00002864 File Offset: 0x00001864
		public uint GetCollection()
		{
			return InternalCollection._EASharpBinding_137(this.mSelf);
		}

		// Token: 0x06000076 RID: 118
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_138(void* _ThisPtr);

		// Token: 0x06000077 RID: 119 RVA: 0x00002880 File Offset: 0x00001880
		public uint GetClass()
		{
			return InternalCollection._EASharpBinding_138(this.mSelf);
		}

		// Token: 0x06000078 RID: 120
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_139(void* _ThisPtr);

		// Token: 0x06000079 RID: 121 RVA: 0x0000289C File Offset: 0x0000189C
		public uint GetParent()
		{
			return InternalCollection._EASharpBinding_139(this.mSelf);
		}

		// Token: 0x0600007A RID: 122
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_140(void* _ThisPtr, uint parent);

		// Token: 0x0600007B RID: 123 RVA: 0x000028B6 File Offset: 0x000018B6
		public void SetParent(uint parent)
		{
			InternalCollection._EASharpBinding_140(this.mSelf, parent);
		}

		// Token: 0x0600007C RID: 124
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_141(void* _ThisPtr);

		// Token: 0x0600007D RID: 125 RVA: 0x000028C4 File Offset: 0x000018C4
		public bool IsDynamic()
		{
			return InternalCollection._EASharpBinding_141(this.mSelf);
		}

		// Token: 0x0600007E RID: 126
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_142(void* _ThisPtr, uint attributeKey);

		// Token: 0x0600007F RID: 127 RVA: 0x000028E0 File Offset: 0x000018E0
		public Attribute Get(uint attributeKey)
		{
			return new Attribute(default(ExposeTag_InitOwned), InternalCollection._EASharpBinding_142(this.mSelf, attributeKey));
		}

		// Token: 0x06000080 RID: 128
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_143(void* _ThisPtr, uint attributeKey);

		// Token: 0x06000081 RID: 129 RVA: 0x0000290C File Offset: 0x0000190C
		public Attribute GetOrClone(uint attributeKey)
		{
			return new Attribute(default(ExposeTag_InitOwned), InternalCollection._EASharpBinding_143(this.mSelf, attributeKey));
		}

		// Token: 0x06000082 RID: 130
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_144(void* _ThisPtr, uint attributeKey);

		// Token: 0x06000083 RID: 131 RVA: 0x00002938 File Offset: 0x00001938
		public bool Contains(uint attributeKey)
		{
			return InternalCollection._EASharpBinding_144(this.mSelf, attributeKey);
		}

		// Token: 0x06000084 RID: 132
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_145(void* _ThisPtr);

		// Token: 0x06000085 RID: 133 RVA: 0x00002954 File Offset: 0x00001954
		public uint LocalAttribCount()
		{
			return InternalCollection._EASharpBinding_145(this.mSelf);
		}

		// Token: 0x06000086 RID: 134
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_146(void* _ThisPtr, uint attributeKey, uint count);

		// Token: 0x06000087 RID: 135 RVA: 0x00002970 File Offset: 0x00001970
		public bool Add(uint attributeKey, uint count)
		{
			return InternalCollection._EASharpBinding_146(this.mSelf, attributeKey, count);
		}

		// Token: 0x06000088 RID: 136
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_147(void* _ThisPtr, uint attributeKey);

		// Token: 0x06000089 RID: 137 RVA: 0x0000298C File Offset: 0x0000198C
		public bool Remove(uint attributeKey)
		{
			return InternalCollection._EASharpBinding_147(this.mSelf, attributeKey);
		}

		// Token: 0x0600008A RID: 138
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_148(void* _ThisPtr, uint dynamicCollectionKey, uint spaceForAdditionalAttributes);

		// Token: 0x0600008B RID: 139 RVA: 0x000029A7 File Offset: 0x000019A7
		public void Modify(uint dynamicCollectionKey, uint spaceForAdditionalAttributes)
		{
			InternalCollection._EASharpBinding_148(this.mSelf, dynamicCollectionKey, spaceForAdditionalAttributes);
		}

		// Token: 0x0600008C RID: 140
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_149(void* _ThisPtr);

		// Token: 0x0600008D RID: 141 RVA: 0x000029B6 File Offset: 0x000019B6
		public void Unmodify()
		{
			InternalCollection._EASharpBinding_149(this.mSelf);
		}

		// Token: 0x0600008E RID: 142
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_150(void* _ThisPtr, sbyte* name);

		// Token: 0x0600008F RID: 143 RVA: 0x000029C4 File Offset: 0x000019C4
		public unsafe uint GenerateUniqueKey(string name)
		{
			int byteCount = Encoding.ASCII.GetByteCount(name);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(name, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return InternalCollection._EASharpBinding_150(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000090 RID: 144
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_151(void* _ThisPtr, uint spaceForAdditionalAttributes);

		// Token: 0x06000091 RID: 145 RVA: 0x00002A29 File Offset: 0x00001A29
		public void Reserve(uint spaceForAdditionalAttributes)
		{
			InternalCollection._EASharpBinding_151(this.mSelf, spaceForAdditionalAttributes);
		}

		// Token: 0x06000092 RID: 146
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_152(void* _ThisPtr, uint attribkey, uint index);

		// Token: 0x06000093 RID: 147 RVA: 0x00002A38 File Offset: 0x00001A38
		public unsafe void* GetAttributePointer(uint attribkey, uint index)
		{
			return InternalCollection._EASharpBinding_152(this.mSelf, attribkey, index);
		}

		// Token: 0x06000094 RID: 148
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_153(void* _ThisPtr, uint key);

		// Token: 0x06000095 RID: 149 RVA: 0x00002A54 File Offset: 0x00001A54
		public bool IsDerivedFrom(uint key)
		{
			return InternalCollection._EASharpBinding_153(this.mSelf, key);
		}

		// Token: 0x06000096 RID: 150
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_154(void* _ThisPtr);

		// Token: 0x06000097 RID: 151 RVA: 0x00002A6F File Offset: 0x00001A6F
		public virtual void Load()
		{
			InternalCollection._EASharpBinding_154(this.mSelf);
		}

		// Token: 0x06000098 RID: 152
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_155(void* _ThisPtr);

		// Token: 0x06000099 RID: 153 RVA: 0x00002A7C File Offset: 0x00001A7C
		public virtual void Unload()
		{
			InternalCollection._EASharpBinding_155(this.mSelf);
		}

		// Token: 0x0600009A RID: 154
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_156(sbyte* str);

		// Token: 0x0600009B RID: 155 RVA: 0x00002A8C File Offset: 0x00001A8C
		public unsafe static uint Hash(string str)
		{
			int byteCount = Encoding.ASCII.GetByteCount(str);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(str, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return InternalCollection._EASharpBinding_156((sbyte*)ptr);
			}
		}
	}
}
