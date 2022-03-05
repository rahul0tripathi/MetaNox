using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
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

public class Main : MonoBehaviour
{
    public static Main instance;
    public GameObject BaseItem;
    public const int nodeWidth = 44;
    public const int nodeHeight = 44;
    public GameObject RenderQuad;
    public Material RenderQuadMaterial;
    public GameObject ItemsContainer;
    private Dictionary<int, BaseItemScript> _itemInstances;

    private void Awake()
    {
        instance = this;
        Items.LoadItems();
        Sprites.LoadSprites();
        //Sprites.LoadScriptableFromJSON();
        LoadScene();
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public SceneData GetScene()
    {
        var _defaultSceneData =
            "{\"items\":[" +
            "{\"instanceId\":1,\"itemId\":3635,\"posX\":37,\"posZ\":19}," +
            "{\"instanceId\":2,\"itemId\":2496,\"posX\":22,\"posZ\":23}," +
            "{\"instanceId\":3,\"itemId\":2728,\"posX\":28,\"posZ\":15}," +
            "{\"instanceId\":4,\"itemId\":2728,\"posX\":18,\"posZ\":24}," +
            "{\"instanceId\":59892,\"itemId\":4764,\"posX\":32,\"posZ\":14}," +
            "{\"instanceId\":36894,\"itemId\":4764,\"posX\":28,\"posZ\":20}," +
            "{\"instanceId\":66286,\"itemId\":9074,\"posX\":20,\"posZ\":30}," +
            "{\"instanceId\":21809,\"itemId\":8833,\"posX\":23,\"posZ\":18}," +
            "{\"instanceId\":31911,\"itemId\":3265,\"posX\":18,\"posZ\":19}," +
            "{\"instanceId\":15113,\"itemId\":4856,\"posX\":15,\"posZ\":29}," +
            "{\"instanceId\":56078,\"itemId\":2949,\"posX\":41,\"posZ\":41}," +
            "{\"instanceId\":42821,\"itemId\":4764,\"posX\":30,\"posZ\":26}," +
            "{\"instanceId\":61823,\"itemId\":4764,\"posX\":14,\"posZ\":19}," +
            "{\"instanceId\":71678,\"itemId\":1712,\"posX\":22,\"posZ\":12}," +
            "{\"instanceId\":20344,\"itemId\":1712,\"posX\":11,\"posZ\":24}," +
            "{\"instanceId\":29249,\"itemId\":2728,\"posX\":33,\"posZ\":18}," +
            "{\"instanceId\":86916,\"itemId\":5341,\"posX\":42,\"posZ\":39}," +
            "{\"instanceId\":77332,\"itemId\":5341,\"posX\":31,\"posZ\":40}," +
            "{\"instanceId\":21622,\"itemId\":5341,\"posX\":33,\"posZ\":41}," +
            "{\"instanceId\":27640,\"itemId\":5341,\"posX\":35,\"posZ\":41}," +
            "{\"instanceId\":49978,\"itemId\":5341,\"posX\":40,\"posZ\":39}," +
            "{\"instanceId\":17499,\"itemId\":5341,\"posX\":43,\"posZ\":30}," +
            "{\"instanceId\":80451,\"itemId\":5341,\"posX\":40,\"posZ\":35}," +
            "{\"instanceId\":85859,\"itemId\":5341,\"posX\":32,\"posZ\":39}," +
            "{\"instanceId\":58342,\"itemId\":1251,\"posX\":30,\"posZ\":40}," +
            "{\"instanceId\":67801,\"itemId\":5341,\"posX\":30,\"posZ\":41}," +
            "{\"instanceId\":41858,\"itemId\":5341,\"posX\":34,\"posZ\":40}," +
            "{\"instanceId\":31873,\"itemId\":5341,\"posX\":33,\"posZ\":39}," +
            "{\"instanceId\":37453,\"itemId\":5341,\"posX\":36,\"posZ\":39}," +
            "{\"instanceId\":63226,\"itemId\":5341,\"posX\":35,\"posZ\":39}," +
            "{\"instanceId\":26527,\"itemId\":5341,\"posX\":37,\"posZ\":41}," +
            "{\"instanceId\":51181,\"itemId\":5341,\"posX\":38,\"posZ\":39}," +
            "{\"instanceId\":58088,\"itemId\":5341,\"posX\":39,\"posZ\":37}," +
            "{\"instanceId\":50036,\"itemId\":5341,\"posX\":42,\"posZ\":37}," +
            "{\"instanceId\":15387,\"itemId\":5341,\"posX\":42,\"posZ\":35}," +
            "{\"instanceId\":47032,\"itemId\":5341,\"posX\":41,\"posZ\":34}," +
            "{\"instanceId\":66832,\"itemId\":5341,\"posX\":43,\"posZ\":33}," +
            "{\"instanceId\":17459,\"itemId\":5341,\"posX\":39,\"posZ\":41}," +
            "{\"instanceId\":75306,\"itemId\":5341,\"posX\":43,\"posZ\":32}," +
            "{\"instanceId\":38803,\"itemId\":5341,\"posX\":43,\"posZ\":28}," +
            "{\"instanceId\":77374,\"itemId\":5341,\"posX\":29,\"posZ\":42}," +
            "{\"instanceId\":47941,\"itemId\":5341,\"posX\":28,\"posZ\":41}," +
            "{\"instanceId\":62227,\"itemId\":5341,\"posX\":28,\"posZ\":39}," +
            "{\"instanceId\":43477,\"itemId\":5341,\"posX\":38,\"posZ\":35}," +
            "{\"instanceId\":45500,\"itemId\":5341,\"posX\":42,\"posZ\":26}," +
            "{\"instanceId\":20055,\"itemId\":5341,\"posX\":38,\"posZ\":33}," +
            "{\"instanceId\":31352,\"itemId\":5341,\"posX\":30,\"posZ\":38}," +
            "{\"instanceId\":80700,\"itemId\":5341,\"posX\":32,\"posZ\":38}," +
            "{\"instanceId\":66682,\"itemId\":5341,\"posX\":31,\"posZ\":37}," +
            "{\"instanceId\":92946,\"itemId\":5341,\"posX\":27,\"posZ\":41},";
        //+
        for (int i = 0; i < 45; i++)
        {


            _defaultSceneData += "{\"instanceId\":11908,\"itemId\":7666,\"posX\":0,\"posZ\":" + (i).ToString() + "},";
        }
        for (int i = 0; i < 45; i++)
        {


            _defaultSceneData += "{\"instanceId\":11908,\"itemId\":7666,\"posX\":" + (i).ToString() + ",\"posZ\":0},";
        }
        for (int i = 0; i < 45; i++)
        {


            _defaultSceneData += "{\"instanceId\":11908,\"itemId\":7666,\"posX\":44,\"posZ\":" + (i).ToString() + "},";
        }
        for (int i = 0; i < 45; i++)
        {


            _defaultSceneData += "{\"instanceId\":11908,\"itemId\":7666,\"posX\":" + (i).ToString() + ",\"posZ\":44},";
        }
        _defaultSceneData += "{\"instanceId\":25391,\"itemId\":5341,\"posX\":24,\"posZ\":40}]}";

        return JsonUtility.FromJson<SceneData>(_defaultSceneData);
    }
    public void LoadScene()
    {
        var sceneData = GetScene();
        foreach (var itemData in sceneData.items)
        {
            Debug.Log(itemData.posX);
            AddItem(itemData.itemId, itemData.instanceId, itemData.posX, itemData.posZ, true, true);
        }
    }

    public void AddItem(int itemId, int instanceId, int posX, int posZ, bool immediate, bool ownedItem)
    {


        var instance = Utilities.CreateInstance(BaseItem, ItemsContainer, true)
            .GetComponent<BaseItemScript>();

        if (instanceId == -1) instanceId = _GetUnusedInstanceId();

        instance.instanceId = instanceId;

        instance.SetItemData(itemId, posX, posZ);
        instance.SetState(Common.State.IDLE);


    }
    private int _GetUnusedInstanceId()
    {
        var instanceId = Random.Range(10000, 99999);
        return instanceId;
    }
}