using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public static Dictionary<int, ItemsCollection.ItemData> items;


    public static void LoadItems()
    {
        items = new Dictionary<int, ItemsCollection.ItemData>();

        var itemsCollection = Resources.Load("ItemsCollection", typeof(ItemsCollection)) as ItemsCollection;
        if (itemsCollection != null)
            for (var index = 0; index < itemsCollection.list.Count; index++)
            {
                var itemData = itemsCollection.list[index];

                Debug.Log(JsonUtility.ToJson(itemData, true));
                items.Add(itemData.id, itemData);
            }
        else
            Debug.LogError("ItemsCollection is missing! please go to 'Windows/Item Editor'");
    }

    public static ItemsCollection.ItemData GetItem(int itemId)
    {
        ItemsCollection.ItemData item = null;
        items.TryGetValue(itemId, out item);
        return item;
    }
}