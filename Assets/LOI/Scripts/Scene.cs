using System;
using System.Collections.Generic;

[Serializable]
public class ItemData
{
    public int instanceId;
    public int itemId;
    public int posX;
    public int posZ;
}


[Serializable]
public class SceneData
{
    public List<ItemData> items;

    public SceneData()
    {
        items = new List<ItemData>();
    }

    public void AddOrUpdateItem(int instanceId, int itemId, int posX, int posZ)
    {
        ItemData itemData = null;
        foreach (var item in items)
            if (item.instanceId == instanceId)
                itemData = item;

        if (itemData == null)
        {
            itemData = new ItemData();
            itemData.instanceId = instanceId;
            itemData.itemId = itemId;
            items.Add(itemData);
        }

        itemData.posX = posX;
        itemData.posZ = posZ;
    }

    public void RemoveItem(int instanceId)
    {
        var targetItem = GetItem(instanceId);

        if (targetItem != null) items.Remove(targetItem);
    }

    public ItemData GetItem(int instanceId)
    {
        ItemData targetItem = null;
        foreach (var itemData in items)
            if (itemData.instanceId == instanceId)
                targetItem = itemData;

        return targetItem;
    }
}