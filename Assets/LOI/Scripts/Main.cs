using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;



public class Main : MonoBehaviour
{
    public static Main instance;
    public GameObject BaseItem;
    public const int nodeWidth = 44;
    public const int nodeHeight = 44;
    public GameObject RenderQuad;
    public GameObject InfoWindow;
    public Material RenderQuadMaterial;
    public GameObject ItemsContainer;
    public GameObject BuildMenu;
    public NoxTokenContractHandler noxTokenHandler;
    public ProfileHandler profile;
    private Dictionary<int, BaseItemScript> _itemInstances;
    public BaseLandScript baseland;
    private static int CAMP = 2728;
    public GameObject buildNew;
    private void Awake()
    {
        baseland = new BaseLandScript();
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        instance = this;
        Items.LoadItems();
        Sprites.LoadSprites();
    }
    private void Update()
    {
    }

    async public void LoadScene()
    {
        foreach (var comp in ItemsContainer.GetComponents<Component>())
        {
            if (!(comp is Transform))
            {
                Destroy(comp);
            }
        }
        var sceneData = await baseland.getBaseLandConfig();
        var cannons = await noxTokenHandler.GetLandItems();
        Debug.Log(JsonUtility.ToJson(cannons));
        sceneData.items.AddRange(cannons);
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
        instance.SetState(CommonHandler.State.IDLE);


    }
    private int _GetUnusedInstanceId()
    {
        var instanceId = Random.Range(10000, 99999);
        return instanceId;
    }
    async public void SetupContracts()
    {
        noxTokenHandler = new NoxTokenContractHandler();
        var value = await noxTokenHandler.Init();
        Debug.Log(value);
        var v = await noxTokenHandler.GetPowerupTokenBalance();
        Debug.Log(v);
        profile.UpdateBalance(v.ToString() + " NOX");
        LoadScene();

    }
    async public void BuildNewFn(int asset, int x, int y)
    {

        var build = await noxTokenHandler.Build(asset, x.ToString(), y.ToString());
        AddItem(CAMP, _GetUnusedInstanceId(), x, y, true, true);

    }
    public void openBuild()
    {
        BuildMenu.SetActive(true);
    }
    public void closeBuild()
    {
        BuildMenu.SetActive(false);
    }
    public void ReloadScene()
    {
        LoadScene();
    }
}
