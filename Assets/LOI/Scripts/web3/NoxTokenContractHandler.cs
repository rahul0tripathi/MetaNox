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
            balancesFunction.Id = NOX_TOKEN;
            var balancesFunctionReturn = await NoxTokenContract.QueryAsync<BalanceOfFunction, BigInteger>(balancesFunction);
            return (float)System.Numerics.BigInteger.Divide(balancesFunctionReturn, 1000000000000000000);

        }
        else
        {
            return 0.0000F;
        }
    }
    public async Task<List<ItemData>> GetCannons()
    {
        var thisInstanceId = _GetUnusedInstanceId();
        var cannons = new List<ItemData>();
        Debug.Log("called");
        var getCannonFn = new GetAssetsFunction();
        getCannonFn.FromAddress = address;
        getCannonFn.Asset = await NoxTokenContract.QueryAsync<CANNONFunction, BigInteger>();
        var cannonList = await NoxTokenContract.QueryAsync<GetAssetsFunction, List<string>>(getCannonFn);
        Debug.Log("here");
        for (int i = 0; i < cannonList.Count; i++)
        {
            var newCannon = new ItemData();
            var parsed = cannonList[i].Split(":");
            newCannon.posX = int.Parse(parsed[0]);
            newCannon.posZ = int.Parse(parsed[1]);
            newCannon.instanceId = thisInstanceId;
            newCannon.itemId = CANNON_ID;
            Debug.Log(newCannon.posX);
            cannons.Add(newCannon);
        }

        return cannons;


    }
}

