using System;
using System.Collections.Generic;
using System.IO;

namespace GameCore
{
	// Token: 0x0200022F RID: 559
	public static class Activator
	{
		// Token: 0x060016C2 RID: 5826 RVA: 0x00027D43 File Offset: 0x00026D43
		public static void Register<T>(Activator.ConstructHandler construct)
		{
			Activator.Register(typeof(T), construct);
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x00027D55 File Offset: 0x00026D55
		public static void Register(Type type, Activator.ConstructHandler construct)
		{
			Activator.Register(type.FullName, construct);
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x00027D63 File Offset: 0x00026D63
		public static void Register(string type, Activator.ConstructHandler construct)
		{
			Activator.Register(Hash.Hash32(type), construct);
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x00027D71 File Offset: 0x00026D71
		public static void Register(uint typeHash, Activator.ConstructHandler construct)
		{
			if (!Activator.ConstructInventory.ContainsKey(typeHash))
			{
				Activator.ConstructInventory.Add(typeHash, construct);
			}
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x00027D8C File Offset: 0x00026D8C
		public static T CreateInstance<T>(uint typeHash, BinaryReader source) where T : class
		{
			if (Activator.ConstructInventory.ContainsKey(typeHash))
			{
				Activator.ConstructHandler constructHandler = Activator.ConstructInventory[typeHash];
				return constructHandler(source) as T;
			}
			return default(T);
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x00027DCD File Offset: 0x00026DCD
		public static T CreateInstance<T>(string type, BinaryReader source) where T : class
		{
			return Activator.CreateInstance<T>(Hash.Hash32(type), source);
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x00027DDB File Offset: 0x00026DDB
		public static T CreateInstance<T>(string type) where T : class
		{
			return Activator.CreateInstance<T>(Hash.Hash32(type), null);
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x00027DE9 File Offset: 0x00026DE9
		public static T CreateInstance<T>(uint typeHash) where T : class
		{
			return Activator.CreateInstance<T>(typeHash, null);
		}

		// Token: 0x0400057E RID: 1406
		private static Dictionary<uint, Activator.ConstructHandler> ConstructInventory = new Dictionary<uint, Activator.ConstructHandler>();

		// Token: 0x02000230 RID: 560
		// (Invoke) Token: 0x060016CC RID: 5836
		public delegate object ConstructHandler(BinaryReader source);
	}
}
