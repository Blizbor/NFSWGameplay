using System;
using System.Collections.Generic;

namespace GameCore.Workflow
{
	// Token: 0x0200022C RID: 556
	public static class WorkflowFactory
	{
		// Token: 0x060016A3 RID: 5795 RVA: 0x00027924 File Offset: 0x00026924
		public static void Register(string name, CreateWorkflowElementHandler handler)
		{
			uint key = Hash.Hash32(name);
			if (!WorkflowFactory.Inventory.ContainsKey(key))
			{
				WorkflowFactory.Inventory.Add(key, handler);
			}
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x00027954 File Offset: 0x00026954
		public static void UnRegister(string name)
		{
			uint key = Hash.Hash32(name);
			if (WorkflowFactory.Inventory.ContainsKey(key))
			{
				WorkflowFactory.Inventory.Remove(key);
			}
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x00027981 File Offset: 0x00026981
		public static WorkflowElement Create(string name)
		{
			return WorkflowFactory.Create(Hash.Hash32(name));
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x0002798E File Offset: 0x0002698E
		public static WorkflowElement Create(uint key)
		{
			if (WorkflowFactory.Inventory.ContainsKey(key))
			{
				return WorkflowFactory.Inventory[key]();
			}
			return null;
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x000279AF File Offset: 0x000269AF
		public static bool Contains(string name)
		{
			return WorkflowFactory.Contains(Hash.Hash32(name));
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x000279BC File Offset: 0x000269BC
		public static bool Contains(uint key)
		{
			return WorkflowFactory.Inventory.ContainsKey(key);
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060016A9 RID: 5801 RVA: 0x000279C9 File Offset: 0x000269C9
		public static int Count
		{
			get
			{
				return WorkflowFactory.Inventory.Count;
			}
		}

		// Token: 0x04000575 RID: 1397
		private static Dictionary<uint, CreateWorkflowElementHandler> Inventory = new Dictionary<uint, CreateWorkflowElementHandler>();
	}
}
