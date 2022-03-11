using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;




    public class NoxPowerupsConsole
    {
        public static async Task Main()
        {
            
            /* Deployment 
           var noxPowerupsDeployment = new NoxPowerupsDeployment();

           var transactionReceiptDeployment = await web3.Eth.GetContractDeploymentHandler<NoxPowerupsDeployment>().SendRequestAndWaitForReceiptAsync(noxPowerupsDeployment);
           var contractAddress = transactionReceiptDeployment.ContractAddress;
            */
           

            /** Function: allowance**/
            /*
            var allowanceFunction = new AllowanceFunction();
            allowanceFunction.Owner = owner;
            allowanceFunction.Spender = spender;
            var allowanceFunctionReturn = await contractHandler.QueryAsync<AllowanceFunction, BigInteger>(allowanceFunction);
            */


            /** Function: approve**/
            /*
            var approveFunction = new ApproveFunction();
            approveFunction.Spender = spender;
            approveFunction.Amount = amount;
            var approveFunctionTxnReceipt = await contractHandler.






        (approveFunction);
            */


            /** Function: balanceOf**/
            /*
            var balanceOfFunction = new BalanceOfFunction();
            balanceOfFunction.Account = account;
            var balanceOfFunctionReturn = await contractHandler.QueryAsync<BalanceOfFunction, BigInteger>(balanceOfFunction);
            */


            /** Function: decimals**/
            /*
            var decimalsFunctionReturn = await contractHandler.QueryAsync<DecimalsFunction, byte>();
            */


            /** Function: decreaseAllowance**/
            /*
            var decreaseAllowanceFunction = new DecreaseAllowanceFunction();
            decreaseAllowanceFunction.Spender = spender;
            decreaseAllowanceFunction.SubtractedValue = subtractedValue;
            var decreaseAllowanceFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(decreaseAllowanceFunction);
            */


            /** Function: increaseAllowance**/
            /*
            var increaseAllowanceFunction = new IncreaseAllowanceFunction();
            increaseAllowanceFunction.Spender = spender;
            increaseAllowanceFunction.AddedValue = addedValue;
            var increaseAllowanceFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(increaseAllowanceFunction);
            */


            /** Function: initialize**/
            /*
            var initializeFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync<InitializeFunction>();
            */


            /** Function: mint**/
            /*
            var mintFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync<MintFunction>();
            */


            /** Function: name**/
            /*
            var nameFunctionReturn = await contractHandler.QueryAsync<NameFunction, string>();
            */


            /** Function: symbol**/
            /*
            var symbolFunctionReturn = await contractHandler.QueryAsync<SymbolFunction, string>();
            */


            /** Function: totalSupply**/
            /*
            var totalSupplyFunctionReturn = await contractHandler.QueryAsync<TotalSupplyFunction, BigInteger>();
            */


            /** Function: transfer**/
            /*
            var transferFunction = new TransferFunction();
            transferFunction.To = to;
            transferFunction.Amount = amount;
            var transferFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(transferFunction);
            */


            /** Function: transferFrom**/
            /*
            var transferFromFunction = new TransferFromFunction();
            transferFromFunction.From = from;
            transferFromFunction.To = to;
            transferFromFunction.Amount = amount;
            var transferFromFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(transferFromFunction);
            */
        }

    }

    public partial class NoxPowerupsDeployment : NoxPowerupsDeploymentBase
    {
        public NoxPowerupsDeployment() : base(BYTECODE) { }
        public NoxPowerupsDeployment(string byteCode) : base(byteCode) { }
    }

    public class NoxPowerupsDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b50600436106100cf5760003560e01c8063395093511161008c57806395d89b411161006657806395d89b4114610202578063a457c2d714610220578063a9059cbb14610250578063dd62ed3e14610280576100cf565b8063395093511461019857806370a08231146101c85780638129fc1c146101f8576100cf565b806306fdde03146100d4578063095ea7b3146100f25780631249c58b1461012257806318160ddd1461012c57806323b872dd1461014a578063313ce5671461017a575b600080fd5b6100dc6102b0565b6040516100e99190611322565b60405180910390f35b61010c60048036038101906101079190611107565b610342565b6040516101199190611307565b60405180910390f35b61012a610365565b005b610134610373565b6040516101419190611484565b60405180910390f35b610164600480360381019061015f91906110b8565b61037d565b6040516101719190611307565b60405180910390f35b6101826103ac565b60405161018f919061149f565b60405180910390f35b6101b260048036038101906101ad9190611107565b6103b5565b6040516101bf9190611307565b60405180910390f35b6101e260048036038101906101dd9190611053565b61045f565b6040516101ef9190611484565b60405180910390f35b6102006104a8565b005b61020a610600565b6040516102179190611322565b60405180910390f35b61023a60048036038101906102359190611107565b610692565b6040516102479190611307565b60405180910390f35b61026a60048036038101906102659190611107565b61077c565b6040516102779190611307565b60405180910390f35b61029a6004803603810190610295919061107c565b61079f565b6040516102a79190611484565b60405180910390f35b6060603680546102bf906115b4565b80601f01602080910402602001604051908101604052809291908181526020018280546102eb906115b4565b80156103385780601f1061030d57610100808354040283529160200191610338565b820191906000526020600020905b81548152906001019060200180831161031b57829003601f168201915b5050505050905090565b60008061034d610826565b905061035a81858561082e565b600191505092915050565b610371336113886109f9565b565b6000603554905090565b600080610388610826565b9050610395858285610b5a565b6103a0858585610be6565b60019150509392505050565b60006012905090565b6000806103c0610826565b9050610454818585603460008673ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060008973ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020019081526020016000205461044f91906114d6565b61082e565b600191505092915050565b6000603360008373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001908152602001600020549050919050565b600060019054906101000a900460ff166104d05760008054906101000a900460ff16156104d9565b6104d8610e6a565b5b610518576040517f08c379a000000000000000000000000000000000000000000000000000000000815260040161050f906113c4565b60405180910390fd5b60008060019054906101000a900460ff161590508015610568576001600060016101000a81548160ff02191690831515021790555060016000806101000a81548160ff0219169083151502179055505b6105dc6040518060400160405280600a81526020017f4e4f58506f7765727570000000000000000000000000000000000000000000008152506040518060400160405280600381526020017f4e4f580000000000000000000000000000000000000000000000000000000000815250610e7b565b80156105fd5760008060016101000a81548160ff0219169083151502179055505b50565b60606037805461060f906115b4565b80601f016020809104026020016040519081016040528092919081815260200182805461063b906115b4565b80156106885780601f1061065d57610100808354040283529160200191610688565b820191906000526020600020905b81548152906001019060200180831161066b57829003601f168201915b5050505050905090565b60008061069d610826565b90506000603460008373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060008673ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002054905083811015610763576040517f08c379a000000000000000000000000000000000000000000000000000000000815260040161075a90611444565b60405180910390fd5b610770828686840361082e565b60019250505092915050565b600080610787610826565b9050610794818585610be6565b600191505092915050565b6000603460008473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060008373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002054905092915050565b600033905090565b600073ffffffffffffffffffffffffffffffffffffffff168373ffffffffffffffffffffffffffffffffffffffff16141561089e576040517f08c379a000000000000000000000000000000000000000000000000000000000815260040161089590611404565b60405180910390fd5b600073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff16141561090e576040517f08c379a000000000000000000000000000000000000000000000000000000000815260040161090590611364565b60405180910390fd5b80603460008573ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060008473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001908152602001600020819055508173ffffffffffffffffffffffffffffffffffffffff168373ffffffffffffffffffffffffffffffffffffffff167f8c5be1e5ebec7d5bd14f71427d1e84f3dd0314c0f7b2291e5b200ac8c7c3b925836040516109ec9190611484565b60405180910390a3505050565b600073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff161415610a69576040517f08c379a0000000000000000000000000000000000000000000000000000000008152600401610a6090611464565b60405180910390fd5b610a7560008383610ed8565b8060356000828254610a8791906114d6565b9250508190555080603360008473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020019081526020016000206000828254610add91906114d6565b925050819055508173ffffffffffffffffffffffffffffffffffffffff16600073ffffffffffffffffffffffffffffffffffffffff167fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef83604051610b429190611484565b60405180910390a3610b5660008383610edd565b5050565b6000610b66848461079f565b90507fffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff8114610be05781811015610bd2576040517f08c379a0000000000000000000000000000000000000000000000000000000008152600401610bc990611384565b60405180910390fd5b610bdf848484840361082e565b5b50505050565b600073ffffffffffffffffffffffffffffffffffffffff168373ffffffffffffffffffffffffffffffffffffffff161415610c56576040517f08c379a0000000000000000000000000000000000000000000000000000000008152600401610c4d906113e4565b60405180910390fd5b600073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff161415610cc6576040517f08c379a0000000000000000000000000000000000000000000000000000000008152600401610cbd90611344565b60405180910390fd5b610cd1838383610ed8565b6000603360008573ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002054905081811015610d58576040517f08c379a0000000000000000000000000000000000000000000000000000000008152600401610d4f906113a4565b60405180910390fd5b818103603360008673ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020019081526020016000208190555081603360008573ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020019081526020016000206000828254610ded91906114d6565b925050819055508273ffffffffffffffffffffffffffffffffffffffff168473ffffffffffffffffffffffffffffffffffffffff167fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef84604051610e519190611484565b60405180910390a3610e64848484610edd565b50505050565b6000610e7530610ee2565b15905090565b600060019054906101000a900460ff16610eca576040517f08c379a0000000000000000000000000000000000000000000000000000000008152600401610ec190611424565b60405180910390fd5b610ed48282610f05565b5050565b505050565b505050565b6000808273ffffffffffffffffffffffffffffffffffffffff163b119050919050565b600060019054906101000a900460ff16610f54576040517f08c379a0000000000000000000000000000000000000000000000000000000008152600401610f4b90611424565b60405180910390fd5b8160369080519060200190610f6a929190610f86565b508060379080519060200190610f81929190610f86565b505050565b828054610f92906115b4565b90600052602060002090601f016020900481019282610fb45760008555610ffb565b82601f10610fcd57805160ff1916838001178555610ffb565b82800160010185558215610ffb579182015b82811115610ffa578251825591602001919060010190610fdf565b5b509050611008919061100c565b5090565b5b8082111561102557600081600090555060010161100d565b5090565b6000813590506110388161191f565b92915050565b60008135905061104d81611936565b92915050565b60006020828403121561106557600080fd5b600061107384828501611029565b91505092915050565b6000806040838503121561108f57600080fd5b600061109d85828601611029565b92505060206110ae85828601611029565b9150509250929050565b6000806000606084860312156110cd57600080fd5b60006110db86828701611029565b93505060206110ec86828701611029565b92505060406110fd8682870161103e565b9150509250925092565b6000806040838503121561111a57600080fd5b600061112885828601611029565b92505060206111398582860161103e565b9150509250929050565b61114c8161153e565b82525050565b600061115d826114ba565b61116781856114c5565b9350611177818560208601611581565b61118081611644565b840191505092915050565b60006111986023836114c5565b91506111a382611655565b604082019050919050565b60006111bb6022836114c5565b91506111c6826116a4565b604082019050919050565b60006111de601d836114c5565b91506111e9826116f3565b602082019050919050565b60006112016026836114c5565b915061120c8261171c565b604082019050919050565b6000611224602e836114c5565b915061122f8261176b565b604082019050919050565b60006112476025836114c5565b9150611252826117ba565b604082019050919050565b600061126a6024836114c5565b915061127582611809565b604082019050919050565b600061128d602b836114c5565b915061129882611858565b604082019050919050565b60006112b06025836114c5565b91506112bb826118a7565b604082019050919050565b60006112d3601f836114c5565b91506112de826118f6565b602082019050919050565b6112f28161156a565b82525050565b61130181611574565b82525050565b600060208201905061131c6000830184611143565b92915050565b6000602082019050818103600083015261133c8184611152565b905092915050565b6000602082019050818103600083015261135d8161118b565b9050919050565b6000602082019050818103600083015261137d816111ae565b9050919050565b6000602082019050818103600083015261139d816111d1565b9050919050565b600060208201905081810360008301526113bd816111f4565b9050919050565b600060208201905081810360008301526113dd81611217565b9050919050565b600060208201905081810360008301526113fd8161123a565b9050919050565b6000602082019050818103600083015261141d8161125d565b9050919050565b6000602082019050818103600083015261143d81611280565b9050919050565b6000602082019050818103600083015261145d816112a3565b9050919050565b6000602082019050818103600083015261147d816112c6565b9050919050565b600060208201905061149960008301846112e9565b92915050565b60006020820190506114b460008301846112f8565b92915050565b600081519050919050565b600082825260208201905092915050565b60006114e18261156a565b91506114ec8361156a565b9250827fffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff03821115611521576115206115e6565b5b828201905092915050565b60006115378261154a565b9050919050565b60008115159050919050565b600073ffffffffffffffffffffffffffffffffffffffff82169050919050565b6000819050919050565b600060ff82169050919050565b60005b8381101561159f578082015181840152602081019050611584565b838111156115ae576000848401525b50505050565b600060028204905060018216806115cc57607f821691505b602082108114156115e0576115df611615565b5b50919050565b7f4e487b7100000000000000000000000000000000000000000000000000000000600052601160045260246000fd5b7f4e487b7100000000000000000000000000000000000000000000000000000000600052602260045260246000fd5b6000601f19601f8301169050919050565b7f45524332303a207472616e7366657220746f20746865207a65726f206164647260008201527f6573730000000000000000000000000000000000000000000000000000000000602082015250565b7f45524332303a20617070726f766520746f20746865207a65726f20616464726560008201527f7373000000000000000000000000000000000000000000000000000000000000602082015250565b7f45524332303a20696e73756666696369656e7420616c6c6f77616e6365000000600082015250565b7f45524332303a207472616e7366657220616d6f756e742065786365656473206260008201527f616c616e63650000000000000000000000000000000000000000000000000000602082015250565b7f496e697469616c697a61626c653a20636f6e747261637420697320616c72656160008201527f647920696e697469616c697a6564000000000000000000000000000000000000602082015250565b7f45524332303a207472616e736665722066726f6d20746865207a65726f20616460008201527f6472657373000000000000000000000000000000000000000000000000000000602082015250565b7f45524332303a20617070726f76652066726f6d20746865207a65726f2061646460008201527f7265737300000000000000000000000000000000000000000000000000000000602082015250565b7f496e697469616c697a61626c653a20636f6e7472616374206973206e6f74206960008201527f6e697469616c697a696e67000000000000000000000000000000000000000000602082015250565b7f45524332303a2064656372656173656420616c6c6f77616e63652062656c6f7760008201527f207a65726f000000000000000000000000000000000000000000000000000000602082015250565b7f45524332303a206d696e7420746f20746865207a65726f206164647265737300600082015250565b6119288161152c565b811461193357600080fd5b50565b61193f8161156a565b811461194a57600080fd5b5056fea26469706673582212200dde3b7a2032cd41166841b78ced95308de9cdd89fa6f8a0cd12e74345a122df64736f6c63430008040033";
        public NoxPowerupsDeploymentBase() : base(BYTECODE) { }
        public NoxPowerupsDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class AllowanceFunction : AllowanceFunctionBase { }

    [Function("allowance", "uint256")]
    public class AllowanceFunctionBase : FunctionMessage
    {
        [Parameter("address", "owner", 1)]
        public virtual string Owner { get; set; }
        [Parameter("address", "spender", 2)]
        public virtual string Spender { get; set; }
    }

    public partial class ApproveFunction : ApproveFunctionBase { }

    [Function("approve", "bool")]
    public class ApproveFunctionBase : FunctionMessage
    {
        [Parameter("address", "spender", 1)]
        public virtual string Spender { get; set; }
        [Parameter("uint256", "amount", 2)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class BalanceOfFunction : BalanceOfFunctionBase { }

    [Function("balanceOf", "uint256")]
    public class BalanceOfFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
    }

    public partial class DecimalsFunction : DecimalsFunctionBase { }

    [Function("decimals", "uint8")]
    public class DecimalsFunctionBase : FunctionMessage
    {

    }

    public partial class DecreaseAllowanceFunction : DecreaseAllowanceFunctionBase { }

    [Function("decreaseAllowance", "bool")]
    public class DecreaseAllowanceFunctionBase : FunctionMessage
    {
        [Parameter("address", "spender", 1)]
        public virtual string Spender { get; set; }
        [Parameter("uint256", "subtractedValue", 2)]
        public virtual BigInteger SubtractedValue { get; set; }
    }

    public partial class IncreaseAllowanceFunction : IncreaseAllowanceFunctionBase { }

    [Function("increaseAllowance", "bool")]
    public class IncreaseAllowanceFunctionBase : FunctionMessage
    {
        [Parameter("address", "spender", 1)]
        public virtual string Spender { get; set; }
        [Parameter("uint256", "addedValue", 2)]
        public virtual BigInteger AddedValue { get; set; }
    }

    public partial class InitializeFunction : InitializeFunctionBase { }

    [Function("initialize")]
    public class InitializeFunctionBase : FunctionMessage
    {

    }

    public partial class MintFunction : MintFunctionBase { }

    [Function("mint")]
    public class MintFunctionBase : FunctionMessage
    {

    }

    public partial class NameFunction : NameFunctionBase { }

    [Function("name", "string")]
    public class NameFunctionBase : FunctionMessage
    {

    }

    public partial class SymbolFunction : SymbolFunctionBase { }

    [Function("symbol", "string")]
    public class SymbolFunctionBase : FunctionMessage
    {

    }

    public partial class TotalSupplyFunction : TotalSupplyFunctionBase { }

    [Function("totalSupply", "uint256")]
    public class TotalSupplyFunctionBase : FunctionMessage
    {

    }

    public partial class TransferFunction : TransferFunctionBase { }

    [Function("transfer", "bool")]
    public class TransferFunctionBase : FunctionMessage
    {
        [Parameter("address", "to", 1)]
        public virtual string To { get; set; }
        [Parameter("uint256", "amount", 2)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class TransferFromFunction : TransferFromFunctionBase { }

    [Function("transferFrom", "bool")]
    public class TransferFromFunctionBase : FunctionMessage
    {
        [Parameter("address", "from", 1)]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2)]
        public virtual string To { get; set; }
        [Parameter("uint256", "amount", 3)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class ApprovalEventDTO : ApprovalEventDTOBase { }

    [Event("Approval")]
    public class ApprovalEventDTOBase : IEventDTO
    {
        [Parameter("address", "owner", 1, true)]
        public virtual string Owner { get; set; }
        [Parameter("address", "spender", 2, true)]
        public virtual string Spender { get; set; }
        [Parameter("uint256", "value", 3, false)]
        public virtual BigInteger Value { get; set; }
    }

    public partial class TransferEventDTO : TransferEventDTOBase { }

    [Event("Transfer")]
    public class TransferEventDTOBase : IEventDTO
    {
        [Parameter("address", "from", 1, true)]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2, true)]
        public virtual string To { get; set; }
        [Parameter("uint256", "value", 3, false)]
        public virtual BigInteger Value { get; set; }
    }

    public partial class AllowanceOutputDTO : AllowanceOutputDTOBase { }

    [FunctionOutput]
    public class AllowanceOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }



    public partial class BalanceOfOutputDTO : BalanceOfOutputDTOBase { }

    [FunctionOutput]
    public class BalanceOfOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class DecimalsOutputDTO : DecimalsOutputDTOBase { }

    [FunctionOutput]
    public class DecimalsOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint8", "", 1)]
        public virtual byte ReturnValue1 { get; set; }
    }









    public partial class NameOutputDTO : NameOutputDTOBase { }

    [FunctionOutput]
    public class NameOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class SymbolOutputDTO : SymbolOutputDTOBase { }

    [FunctionOutput]
    public class SymbolOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class TotalSupplyOutputDTO : TotalSupplyOutputDTOBase { }

    [FunctionOutput]
    public class TotalSupplyOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }





