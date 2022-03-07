using UnityEngine;
using System.Collections;
using System.Threading.Tasks;
using MoralisWeb3ApiSdk;
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
    private static Nethereum.Contracts.ContractHandlers.ContractHandler NoxTokenContract;
    async public Task<bool> Init()
    {
        if (MoralisInterface.Initialized && MoralisInterface.IsLoggedIn())
        {

            MoralisUser user = await MoralisInterface.GetUserAsync();
            string address = user.authData["moralisEth"]["id"].ToString();
            Debug.Log(MoralisInterface.Web3Client);
            NoxTokenContract = MoralisInterface.Web3Client.Eth.GetContractHandler(NoxTokenConstants.NoxTokenContractAddress);
            return true;
        }
        else
        {
            return false;
        }

    }
    public async Task<BigInteger> GetTokenBalance()
    {
        if (initalized)
        {
            var balancesFunction = new BalancesFunction();
            balancesFunction.ReturnValue1 = address;
            var balancesFunctionReturn = await NoxTokenContract.QueryAsync<BalancesFunction, BigInteger>(balancesFunction);
            return balancesFunctionReturn;
        }
        else
        {
            return 0;
        }
    }
}

