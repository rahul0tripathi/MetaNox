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
    public async Task<float> GetTokenBalance()
    {
        if (initalized)
        {
            var balancesFunction = new BalanceOfFunction();

            balancesFunction.Account = address;
            var balancesFunctionReturn = await NoxTokenContract.QueryAsync<BalanceOfFunction, BigInteger>(balancesFunction);
            return (float)System.Numerics.BigInteger.Divide(balancesFunctionReturn, 1000000000000000000);
            
        }
        else
        {
            return 0.0000F;
        }
    }
    public async Task<bool> AddToken()
    {
        
            Debug.Log("called");
            var mintFn = new MintFunction();
            mintFn.FromAddress = address;
            var called = await NoxTokenContract.SendRequestAndWaitForReceiptAsync<MintFunction>(mintFn);
            Debug.Log("here");
            Debug.Log(called.TransactionHash);
        return true;
        
       
    }
}

