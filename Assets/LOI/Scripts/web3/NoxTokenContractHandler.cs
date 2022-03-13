using UnityEngine;
using System.Collections;
using System.Threading.Tasks;
using MoralisWeb3ApiSdk;
using System.Collections.Generic;
using Nethereum.Contracts;
using Nethereum.Hex.HexTypes;
using System.Numerics;
using Nethereum.Web3;
using Moralis.Platform.Objects;
using Moralis.Web3Api.Models;
public class NoxTokenContractHandler : MonoBehaviour
{
    private bool initalized = false;
    private string address = "";
    private static int NOX_TOKEN = 0;
    private static int CANNON_ID = 1712;
    private static int GOLDBOX_ID = 9074;
    private static int TOWER_ID = 4764;
    private static int BARRACK_ID = 8833;
    private static int CAMP = 2728;
    private static Nethereum.Contracts.ContractHandlers.ContractHandler NoxTokenContract;
    async public Task<bool> Init()
    {
        if (MoralisInterface.Initialized && MoralisInterface.IsLoggedIn())
        {

            MoralisUser user = await MoralisInterface.GetUserAsync();
            address = user.authData["moralisEth"]["id"].ToString();
            Debug.Log(MoralisInterface.Web3Client);
            NoxTokenContract = MoralisInterface.Web3Client.Eth.GetContractHandler(NoxTokenConstants.NoxTokenContractAddress);
            initalized = true;
            return true;
        }
        else
        {
            return false;
        }

    }
    private int _GetUnusedInstanceId()
    {
        var instanceId = Random.Range(10000, 99999);
        return instanceId;
    }
    public async Task<float> GetPowerupTokenBalance()
    {
        if (initalized)
        {
            var balancesFunction = new BalanceOfFunction();
            balancesFunction.Account = address;
            balancesFunction.Id = 0;
            var balancesFunctionReturn = await NoxTokenContract.QueryAsync<BalanceOfFunction, BigInteger>(balancesFunction);
            Debug.Log(balancesFunctionReturn);
            return (float)System.Numerics.BigInteger.Divide(balancesFunctionReturn, 1000000000000000000);

        }
        else
        {
            return 0.0000F;
        }
    }
    public async Task<bool> isBuilderFree()
    {
        return await NoxTokenContract.QueryAsync<IsBuilderFreeFunction, bool>();
    }
    public async Task<BigInteger> GetBalance(int asset)
    {

        var balancesFunction = new BalanceOfFunction();
        balancesFunction.Account = address;
        balancesFunction.Id = asset;
        var balancesFunctionReturn = await NoxTokenContract.QueryAsync<BalanceOfFunction, BigInteger>(balancesFunction);
        Debug.Log(balancesFunctionReturn);
        return balancesFunctionReturn;

    }
    private List<ItemData> BuildAssetMap(List<string> items, int itemId, int instanceId)
    {
        var itemList = new List<ItemData>();
        for (int i = 0; i < items.Count; i++)
        {
            var newItem = new ItemData();
            var parsed = items[i].Split(":");
            newItem.posX = int.Parse(parsed[0]);
            newItem.posZ = int.Parse(parsed[1]);
            newItem.instanceId = instanceId;
            newItem.itemId = itemId;
            itemList.Add(newItem);
        }
        return itemList;
    }
    private ItemData InProgressAsset(int instance, int x, int y)
    {
        var newItem = new ItemData();
        newItem.posX = x;
        newItem.posZ = y;
        newItem.instanceId = instance;
        newItem.itemId = CAMP;
        return newItem;
    }

    public async Task<List<ItemData>> GetLandItems()
    {
        //get currently building assets
        var isBuilderFreeFunctionReturn = await NoxTokenContract.QueryAsync<IsBuilderFreeFunction, bool>();
        var getCurrentlyBuildingAssetFunctionReturn = await NoxTokenContract.QueryAsync<GetCurrentlyBuildingAssetFunction, BigInteger>();
        BigInteger currentlyBuilding = 0;
        if (!isBuilderFreeFunctionReturn)
        {
            currentlyBuilding = getCurrentlyBuildingAssetFunctionReturn;
        }
        var itemList = new List<ItemData>();
        var getAssetFn = new GetAssetsFunction();
        getAssetFn.FromAddress = address;
        //get Cannons
        getAssetFn.Asset = await NoxTokenContract.QueryAsync<CANNONFunction, BigInteger>();
        var cannonList = await NoxTokenContract.QueryAsync<GetAssetsFunction, List<string>>(getAssetFn);
        itemList.AddRange(BuildAssetMap(cannonList, CANNON_ID, _GetUnusedInstanceId()));
        if (currentlyBuilding == getAssetFn.Asset)
        {
            var lastAsset = itemList[itemList.Count - 1];
            itemList.RemoveAt(itemList.Count - 1);
            itemList.Add(InProgressAsset(lastAsset.instanceId, lastAsset.posX, lastAsset.posZ));
        }
        Debug.Log(JsonUtility.ToJson(itemList));
        //get GoldBoxes
        getAssetFn.Asset = await NoxTokenContract.QueryAsync<GOLD_BOXFunction, BigInteger>();
        var goldBoxesList = await NoxTokenContract.QueryAsync<GetAssetsFunction, List<string>>(getAssetFn);
        itemList.AddRange(BuildAssetMap(goldBoxesList, GOLDBOX_ID, _GetUnusedInstanceId()));
        if (currentlyBuilding == getAssetFn.Asset)
        {
            var lastAsset = itemList[itemList.Count - 1];
            itemList.RemoveAt(itemList.Count - 1);
            itemList.Add(InProgressAsset(lastAsset.instanceId, lastAsset.posX, lastAsset.posZ));
        }
        Debug.Log(JsonUtility.ToJson(itemList));
        //get Towers
        getAssetFn.Asset = await NoxTokenContract.QueryAsync<TOWERFunction, BigInteger>();
        var towerList = await NoxTokenContract.QueryAsync<GetAssetsFunction, List<string>>(getAssetFn);
        itemList.AddRange(BuildAssetMap(towerList, TOWER_ID, _GetUnusedInstanceId()));
        if (currentlyBuilding == getAssetFn.Asset)
        {
            var lastAsset = itemList[itemList.Count - 1];
            itemList.RemoveAt(itemList.Count - 1);
            itemList.Add(InProgressAsset(lastAsset.instanceId, lastAsset.posX, lastAsset.posZ));
        }

        Debug.Log(JsonUtility.ToJson(itemList));
        //get Barrack
        getAssetFn.Asset = await NoxTokenContract.QueryAsync<BARRACKFunction, BigInteger>();
        var barrackList = await NoxTokenContract.QueryAsync<GetAssetsFunction, List<string>>(getAssetFn);
        itemList.AddRange(BuildAssetMap(barrackList, BARRACK_ID, _GetUnusedInstanceId()));
        if (currentlyBuilding == getAssetFn.Asset)
        {
            var lastAsset = itemList[itemList.Count - 1];
            itemList.RemoveAt(itemList.Count - 1);
            itemList.Add(InProgressAsset(lastAsset.instanceId, lastAsset.posX, lastAsset.posZ));
        }
        Debug.Log(JsonUtility.ToJson(itemList));
        return itemList;
    }
    public async Task<string> Build(int asset, string x, string y)
    {
        var buildNewAssetFunction = new BuildNewAssetFunction();
        buildNewAssetFunction.FromAddress = address;
        buildNewAssetFunction.Asset = asset;
        buildNewAssetFunction.X = x.ToString();
        buildNewAssetFunction.Y = y.ToString();
        var buildNewAssetFunctionTxnReceipt = await NoxTokenContract.SendRequestAndWaitForReceiptAsync(buildNewAssetFunction);
        return buildNewAssetFunctionTxnReceipt.TransactionHash;
    }
}

