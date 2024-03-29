using System;
using System.Collections.Generic;
using UnityEngine;

namespace Stardew.InventorySystem
{
    public class StardewInventory : MonoBehaviour
    {
        public ItemData[] Items => itemList.ToArray();
        [SerializeField] List<ItemData> itemList = new List<ItemData>();

        public ItemData[] GetItemsByType(ItemType targetType)
        {
            var resultList = new List<ItemData>();
            foreach (var itemData in itemList)
            {
                if (itemData.type == targetType)
                    resultList.Add(itemData);
            }

            return resultList.ToArray();
        }

    }

    [Serializable]
    public class ItemData
    {
        public string displayName;
        public string description;
        public Sprite icon;
        public ItemType type;
        public int count;
    }

    public enum ItemType
    {
        Seeds,
        Fertilizer,
        Decoration
    }
}
