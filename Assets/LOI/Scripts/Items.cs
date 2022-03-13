using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{

    public enum ItemType
    {
        Barrack,
        GoldMine,
        GoldStorage,
        Tower,
        Cannon,
        BuilderHut,
        ElixarCollector,
        Townhall,
        Camp,

    }
    public ItemType itemType;
    public int amount;
}
