using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using MoralisWeb3ApiSdk;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;




    public class NoxToken
    {
        public static async Task Main()
        {
           // var web3 = MoralisInterface.Web3Client;

            /* Deployment 
           var tokenDeployment = new TokenDeployment();
               tokenDeployment.InitialSupply = initialSupply;
               tokenDeployment.Name = name;
               tokenDeployment.Symbol = symbol;
               tokenDeployment.Decimals = decimals;
           var transactionReceiptDeployment = await web3.Eth.GetContractDeploymentHandler<TokenDeployment>().SendRequestAndWaitForReceiptAsync(tokenDeployment);
           var contractAddress = transactionReceiptDeployment.ContractAddress;
            */
          //  var contractHandler = web3.Eth.GetContractHandler(NoxTokenConstants.NoxTokenContractAddress);

            /** Function: name**/
            /*
            var nameFunctionReturn = await contractHandler.QueryAsync<NameFunction, string>();
            */


            /** Function: deprecate**/
            /*
            var deprecateFunction = new DeprecateFunction();
            deprecateFunction.UpgradedAddress = upgradedAddress;
            var deprecateFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(deprecateFunction);
            */


            /** Function: approve**/
            /*
            var approveFunction = new ApproveFunction();
            approveFunction.Spender = spender;
            approveFunction.Value = value;
            var approveFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(approveFunction);
            */


            /** Function: deprecated**/
            /*
            var deprecatedFunctionReturn = await contractHandler.QueryAsync<DeprecatedFunction, bool>();
            */


            /** Function: addBlackList**/
            /*
            var addBlackListFunction = new AddBlackListFunction();
            addBlackListFunction.EvilUser = evilUser;
            var addBlackListFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(addBlackListFunction);
            */


            /** Function: totalSupply**/
            /*
            var totalSupplyFunctionReturn = await contractHandler.QueryAsync<TotalSupplyFunction, BigInteger>();
            */


            /** Function: transferFrom**/
            /*
            var transferFromFunction = new TransferFromFunction();
            transferFromFunction.From = from;
            transferFromFunction.To = to;
            transferFromFunction.Value = value;
            var transferFromFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(transferFromFunction);
            */


            /** Function: upgradedAddress**/
            /*
            var upgradedAddressFunctionReturn = await contractHandler.QueryAsync<UpgradedAddressFunction, string>();
            */


            /** Function: balances**/
            /*
            var balancesFunction = new BalancesFunction();
            balancesFunction.ReturnValue1 = returnValue1;
            var balancesFunctionReturn = await contractHandler.QueryAsync<BalancesFunction, BigInteger>(balancesFunction);
            */


            /** Function: decimals**/
            /*
            var decimalsFunctionReturn = await contractHandler.QueryAsync<DecimalsFunction, BigInteger>();
            */


            /** Function: maximumFee**/
            /*
            var maximumFeeFunctionReturn = await contractHandler.QueryAsync<MaximumFeeFunction, BigInteger>();
            */


            /** Function: _totalSupply**/
            /*
            var totalSupplyFunctionReturn = await contractHandler.QueryAsync<TotalSupplyFunction, BigInteger>();
            */


            /** Function: unpause**/
            /*
            var unpauseFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync<UnpauseFunction>();
            */


            /** Function: getBlackListStatus**/
            /*
            var getBlackListStatusFunction = new GetBlackListStatusFunction();
            getBlackListStatusFunction.Maker = maker;
            var getBlackListStatusFunctionReturn = await contractHandler.QueryAsync<GetBlackListStatusFunction, bool>(getBlackListStatusFunction);
            */


            /** Function: allowed**/
            /*
            var allowedFunction = new AllowedFunction();
            allowedFunction.ReturnValue1 = returnValue1;
            allowedFunction.ReturnValue2 = returnValue2;
            var allowedFunctionReturn = await contractHandler.QueryAsync<AllowedFunction, BigInteger>(allowedFunction);
            */


            /** Function: paused**/
            /*
            var pausedFunctionReturn = await contractHandler.QueryAsync<PausedFunction, bool>();
            */


            /** Function: balanceOf**/
            /*
            var balanceOfFunction = new BalanceOfFunction();
            balanceOfFunction.Who = who;
            var balanceOfFunctionReturn = await contractHandler.QueryAsync<BalanceOfFunction, BigInteger>(balanceOfFunction);
            */


            /** Function: pause**/
            /*
            var pauseFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync<PauseFunction>();
            */


            /** Function: getOwner**/
            /*
            var getOwnerFunctionReturn = await contractHandler.QueryAsync<GetOwnerFunction, string>();
            */


            /** Function: owner**/
            /*
            var ownerFunctionReturn = await contractHandler.QueryAsync<OwnerFunction, string>();
            */


            /** Function: symbol**/
            /*
            var symbolFunctionReturn = await contractHandler.QueryAsync<SymbolFunction, string>();
            */


            /** Function: transfer**/
            /*
            var transferFunction = new TransferFunction();
            transferFunction.To = to;
            transferFunction.Value = value;
            var transferFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(transferFunction);
            */


            /** Function: setParams**/
            /*
            var setParamsFunction = new SetParamsFunction();
            setParamsFunction.NewBasisPoints = newBasisPoints;
            setParamsFunction.NewMaxFee = newMaxFee;
            var setParamsFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(setParamsFunction);
            */


            /** Function: issue**/
            /*
            var issueFunction = new IssueFunction();
            issueFunction.Amount = amount;
            var issueFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(issueFunction);
            */


            /** Function: redeem**/
            /*
            var redeemFunction = new RedeemFunction();
            redeemFunction.Amount = amount;
            var redeemFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(redeemFunction);
            */


            /** Function: allowance**/
            /*
            var allowanceFunction = new AllowanceFunction();
            allowanceFunction.Owner = owner;
            allowanceFunction.Spender = spender;
            var allowanceFunctionReturn = await contractHandler.QueryAsync<AllowanceFunction, BigInteger>(allowanceFunction);
            */


            /** Function: basisPointsRate**/
            /*
            var basisPointsRateFunctionReturn = await contractHandler.QueryAsync<BasisPointsRateFunction, BigInteger>();
            */


            /** Function: isBlackListed**/
            /*
            var isBlackListedFunction = new IsBlackListedFunction();
            isBlackListedFunction.ReturnValue1 = returnValue1;
            var isBlackListedFunctionReturn = await contractHandler.QueryAsync<IsBlackListedFunction, bool>(isBlackListedFunction);
            */


            /** Function: removeBlackList**/
            /*
            var removeBlackListFunction = new RemoveBlackListFunction();
            removeBlackListFunction.ClearedUser = clearedUser;
            var removeBlackListFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(removeBlackListFunction);
            */


            /** Function: MAX_UINT**/
            /*
            var mAX_UINTFunctionReturn = await contractHandler.QueryAsync<MAX_UINTFunction, BigInteger>();
            */


            /** Function: transferOwnership**/
            /*
            var transferOwnershipFunction = new TransferOwnershipFunction();
            transferOwnershipFunction.NewOwner = newOwner;
            var transferOwnershipFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(transferOwnershipFunction);
            */


            /** Function: destroyBlackFunds**/
            /*
            var destroyBlackFundsFunction = new DestroyBlackFundsFunction();
            destroyBlackFundsFunction.BlackListedUser = blackListedUser;
            var destroyBlackFundsFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(destroyBlackFundsFunction);
            */
        }

    }

    public partial class TokenDeployment : TokenDeploymentBase
    {
        public TokenDeployment() : base(BYTECODE) { }
        public TokenDeployment(string byteCode) : base(byteCode) { }
    }

    public class TokenDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = " 9971:4917:0:-;;;;;;;;-1:-1:-1;;;9971:4917:0;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;10039:18;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;23:1:-1;8:100;33:3;30:1;27:2;8:100;;;99:1;94:3;90;84:5;71:3;;;64:6;52:2;45:3;8:100;;;12:14;3:109;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;12795:181:0;;;;;;;;;;-1:-1:-1;;;;;12795:181:0;;;;;;;12049:302;;;;;;;;;;-1:-1:-1;;;;;12049:302:0;;;;;;;10155:22;;;;;;;;;;;;;;;;;;;;;;;;;;;;;8714:145;;;;;;;;;;-1:-1:-1;;;;;8714:145:0;;;;;13042:218;;;;;;;;;;;;;;;;;;;;;;;;;;;11273:362;;;;;;;;;;-1:-1:-1;;;;;11273:362:0;;;;;;;;;;;;10118:30;;;;;;;;;;;;;;;-1:-1:-1;;;;;10118:30:0;;;;;;;;;;;;;;2951:40;;;;;;;;;;-1:-1:-1;;;;;2951:40:0;;;;;10091:20;;;;;;;;;;;;3117:26;;;;;;;;;;;;2053:24;;;;;;;;;;;;8160:90;;;;;;;;;;;;8428:124;;;;;;;;;;-1:-1:-1;;;;;8428:124:0;;;;;4741:61;;;;;;;;;;-1:-1:-1;;;;;4741:61:0;;;;;;;;;;7544:26;;;;;;;;;;;;11720:244;;;;;;;;;;-1:-1:-1;;;;;11720:244:0;;;;;7985:88;;;;;;;;;;;;8560:87;;;;;;;;;;;;1162:20;;;;;;;;;;;;10064;;;;;;;;;;;;10862:326;;;;;;;;;;-1:-1:-1;;;;;10862:326:0;;;;;;;14166:387;;;;;;;;;;;;;;;;13424:266;;;;;;;;;;;;;;13921:237;;;;;;;;;;;;;;12436:293;;;;;;;;;;-1:-1:-1;;;;;12436:293:0;;;;;;;;;;3079:31;;;;;;;;;;;;8655:46;;;;;;;;;;-1:-1:-1;;;;;8655:46:0;;;;;8867:160;;;;;;;;;;-1:-1:-1;;;;;8867:160:0;;;;;4811:42;;;;;;;;;;;;1734:151;;;;;;;;;;-1:-1:-1;;;;;1734:151:0;;;;;9035:324;;;;;;;;;;-1:-1:-1;;;;;9035:324:0;;;;;10039:18;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;:::o;12795:181::-;1534:5;;1520:10;-1:-1:-1;;;;;1520:19:0;;;1534:5;;1520:19;1512:28;;;;;;12868:10;:17;;-1:-1:-1;;;;;12868:17:0;;;;-1:-1:-1;;12896:34:0;-1:-1:-1;;;;;12896:34:0;;;;;12941:27;12896:34;12941:27;;-1:-1:-1;;;;;12941:27:0;;;;;;;;;;;;;;12795:181;:::o;12049:302::-;12120:6;3296:8;3278;:26;3276:29;3268:38;;;;;;12143:10;;-1:-1:-1;;;12143:10:0;;;;12139:205;;;12199:15;;-1:-1:-1;;;;;12199:15:0;12177:54;12232:10;12244:8;12254:6;12177:84;;-1:-1:-1;;;12177:84:0;;;;;;-1:-1:-1;;;;;12177:84:0;;;;;;;;;;;;;;;;;;;;;;;;-1:-1:-1;12177:84:0;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;12170:91;;12139:205;12301:31;12315:8;12325:6;12301:13;:31::i;:::-;12049:302;;;:::o;10155:22::-;;;-1:-1:-1;;;10155:22:0;;;;;:::o;8714:145::-;1534:5;;1520:10;-1:-1:-1;;;;;1520:19:0;;;1534:5;;1520:19;1512:28;;;;;;-1:-1:-1;;;;;8784:24:0;;;;;;:13;:24;;;;;;;:31;;-1:-1:-1;;8784:31:0;8811:4;8784:31;;;8826:25;;8798:9;;8826:25;-1:-1:-1;;;;;8826:25:0;;;;;;;;;;;;;;8714:145;:::o;13042:218::-;13111:10;;13090:4;;-1:-1:-1;;;13111:10:0;;;;13107:146;;;13159:15;;-1:-1:-1;;;;;13159:15:0;13145:42;13159:15;13145:44;;;;;;;;;;-1:-1:-1;;;13145:44:0;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;13138:51;;;;13107:146;-1:-1:-1;13229:12:0;;13107:146;13042:218;:::o;11273:362::-;7720:6;;-1:-1:-1;;;7720:6:0;;;;7719:7;7711:16;;;;;;-1:-1:-1;;;;;11377:20:0;;;;;;:13;:20;;;;;;;;11376:21;11368:30;;;;;;11413:10;;-1:-1:-1;;;11413:10:0;;;;11409:219;;;11469:15;;-1:-1:-1;;;;;11469:15:0;11447:59;11507:10;11519:5;11526:3;11531:6;11447:91;;-1:-1:-1;;;11447:91:0;;;;;;-1:-1:-1;;;;;11447:91:0;;;;;;;;;;;;;;;;;;;;;;;;;;;;;-1:-1:-1;11447:91:0;;;;;;;;;;;;;;;;;11409:219;11578:38;11597:5;11604:3;11609:6;11578:18;:38::i;10118:30::-;;;-1:-1:-1;;;;;10118:30:0;;:::o;2951:40::-;;;;;;;;;;;;;:::o;10091:20::-;;;;:::o;3117:26::-;;;;:::o;2053:24::-;;;;:::o;8160:90::-;1534:5;;1520:10;-1:-1:-1;;;;;1520:19:0;;;1534:5;;1520:19;1512:28;;;;;;7880:6;;-1:-1:-1;;;7880:6:0;;;;7872:15;;;;;;;;8223:5;8214:14;;-1:-1:-1;;8214:14:0;;;8235:9;;;;;;;;;;8160:90::o;8428:124::-;-1:-1:-1;;;;;8523:21:0;;8499:4;8523:21;;;:13;:21;;;;;;;;8428:124;;;;:::o;4741:61::-;;;;;;;;;;;;;;;;;;;;;;;;:::o;7544:26::-;;;-1:-1:-1;;;7544:26:0;;;;;:::o;11720:244::-;11798:10;;11777:4;;-1:-1:-1;;;11798:10:0;;;;11794:163;;;11854:15;;-1:-1:-1;;;;;11854:15:0;11832:48;11881:3;11854:15;11832:53;;;;;;;-1:-1:-1;;;11832:53:0;;;;;;-1:-1:-1;;;;;11832:53:0;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;11825:60;;;;11794:163;11925:20;11941:3;11925:15;:20::i;:::-;11918:27;;;;7985:88;1534:5;;1520:10;-1:-1:-1;;;;;1520:19:0;;;1534:5;;1520:19;1512:28;;;;;;7720:6;;-1:-1:-1;;;7720:6:0;;;;7719:7;7711:16;;;;;;8040:6;:13;;-1:-1:-1;;8040:13:0;-1:-1:-1;;;8040:13:0;;;8060:7;;;;;;;;;;7985:88::o;8560:87::-;8607:7;8634:5;-1:-1:-1;;;;;8634:5:0;8560:87;:::o;1162:20::-;;;-1:-1:-1;;;;;1162:20:0;;:::o;10064:::-;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;10862:326;7720:6;;-1:-1:-1;;;7720:6:0;;;;7719:7;7711:16;;;;;;-1:-1:-1;;;;;10961:10:0;10947:25;;;;;:13;:25;;;;;;;;10946:26;10938:35;;;;;;10988:10;;-1:-1:-1;;;10988:10:0;;;;10984:197;;;11044:15;;-1:-1:-1;;;;;11044:15:0;11022:55;11078:10;11090:3;11095:6;11022:80;;-1:-1:-1;;;11022:80:0;;;;;;-1:-1:-1;;;;;11022:80:0;;;;;;;;;;;;;;;;;;;;;;;;-1:-1:-1;11022:80:0;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;11015:87;;10984:197;11142:27;11157:3;11162:6;11142:14;:27::i;:::-;10862:326;;:::o;14166:387::-;1534:5;;1520:10;-1:-1:-1;;;;;1520:19:0;;;1534:5;;1520:19;1512:28;;;;;;14364:2;14347:19;;14339:28;;;;;;14398:2;14386:14;;14378:23;;;;;;14414:15;:32;;;14488:8;;14470:27;;:9;;14484:2;:12;14470:27;:13;:27;:::i;:::-;14457:10;:40;;;14517:15;;14510:35;;;;;;;;;;;;;;;;;;;;;;14166:387;;:::o;13424:266::-;1534:5;;1520:10;-1:-1:-1;;;;;1520:19:0;;;1534:5;;1520:19;1512:28;;;;;;13512:12;;13488:21;;;:36;13480:45;;;;;;13571:15;13580:5;;-1:-1:-1;;;;;13580:5:0;13571:15;;:8;:15;;;;;;13544:24;;;:42;13536:51;;;;;;13600:15;13609:5;;-1:-1:-1;;;;;13609:5:0;13600:15;;:8;:15;;;;;;;:25;;;;;;13609:5;13636:22;;;;;;13669:13;;13619:6;;13669:13;;;;;;;;;;;;;13424:266;:::o;13921:237::-;1534:5;;1520:10;-1:-1:-1;;;;;1520:19:0;;;1534:5;;1520:19;1512:28;;;;;;13986:12;;:22;;;;13978:31;;;;;;14028:15;14037:5;;-1:-1:-1;;;;;14037:5:0;14028:15;;:8;:15;;;;;;:25;;;;14020:34;;;;;;14067:12;:22;;;;;;;:12;14109:5;;-1:-1:-1;;;;;14109:5:0;14100:15;;:8;:15;;;;;;;:25;;;;;;;14136:14;;14083:6;;14136:14;;;;;;;;;;;;;13921:237;:::o;12436:293::-;12545:10;;12514:14;;-1:-1:-1;;;12545:10:0;;;;12541:181;;;12593:15;;-1:-1:-1;;;;;12593:15:0;12579:40;12620:6;12628:8;12593:15;12579:58;;;;;;;-1:-1:-1;;;12579:58:0;;;;;;-1:-1:-1;;;;;12579:58:0;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;12572:65;;;;12541:181;12677:33;12693:6;12701:8;12677:15;:33::i;:::-;12670:40;;12541:181;12436:293;;;;:::o;3079:31::-;;;;:::o;8655:46::-;;;;;;;;;;;;;;;:::o;8867:160::-;1534:5;;1520:10;-1:-1:-1;;;;;1520:19:0;;;1534:5;;1520:19;1512:28;;;;;;-1:-1:-1;;;;;8943:27:0;;8973:5;8943:27;;;:13;:27;;;;;;;:35;;-1:-1:-1;;8943:35:0;;;8989:30;;8957:12;;8989:30;-1:-1:-1;;;;;8989:30:0;;;;;;;;;;;;;;8867:160;:::o;4811:42::-;-1:-1:-1;;4811:42:0;:::o;1734:151::-;1534:5;;1520:10;-1:-1:-1;;;;;1520:19:0;;;1534:5;;1520:19;1512:28;;;;;;-1:-1:-1;;;;;1811:22:0;;;1807:71;;1850:5;:16;;-1:-1:-1;;1850:16:0;-1:-1:-1;;;;;1850:16:0;;;;;1807:71;1734:151;:::o;9035:324::-;9168:15;1534:5;;1520:10;-1:-1:-1;;;;;1520:19:0;;;1534:5;;1520:19;1512:28;;;;;;-1:-1:-1;;;;;9125:31:0;;;;;;:13;:31;;;;;;;;9117:40;;;;;;;;9186:27;9196:16;9186:9;:27::i;:::-;-1:-1:-1;;;;;9224:26:0;;9253:1;9224:26;;;:8;:26;;;;;;:30;;;;9265:12;:26;;;;;;;9168:45;;-1:-1:-1;9302:49:0;;9233:16;;9168:45;;9302:49;-1:-1:-1;;;;;9302:49:0;;;;;;;;;;;;;;;;;;;;9035:324;;:::o;6291:573::-;6362:6;3296:8;3278;:26;3276:29;3268:38;;;;;;6702:11;;;;;6701:53;;-1:-1:-1;;;;;;6727:10:0;6719:19;;;;;;:7;:19;;;;;;;;:29;;;;;;;;;;:34;;6701:53;6699:56;6691:65;;;;;;-1:-1:-1;;;;;6777:10:0;6769:19;;;;;;:7;:19;;;;;;;;:29;;;;;;;;;;;;;;:38;;;6818;;6801:6;;6818:38;;;;;;;;;;;;;6291:573;;;:::o;5143:901::-;5248:14;;;5229:6;3296:8;3278;:26;3276:29;3268:38;;;;;;-1:-1:-1;;;;;5265:14:0;;;;;;;:7;:14;;;;;;;;5280:10;5265:26;;;;;;;;;;5485:15;;5265:26;;-1:-1:-1;5473:40:0;;5507:5;;5474:27;;:6;;:27;:10;:27;:::i;:::-;5473:33;:40;:33;:40;:::i;:::-;5462:51;;5534:10;;5528:3;:16;5524:65;;;5567:10;;5561:16;;5524:65;-1:-1:-1;;5603:10:0;:21;5599:105;;;5670:22;:10;5685:6;5670:22;:14;:22;:::i;:::-;-1:-1:-1;;;;;5641:14:0;;;;;;;:7;:14;;;;;;;;5656:10;5641:26;;;;;;;;;:51;5599:105;5732:15;:6;5743:3;5732:15;:10;:15;:::i;:::-;-1:-1:-1;;;;;5776:15:0;;;;;;:8;:15;;;;;;5714:33;;-1:-1:-1;5776:27:0;;5796:6;5776:27;:19;:27;:::i;:::-;-1:-1:-1;;;;;5758:15:0;;;;;;;:8;:15;;;;;;:45;;;;5830:13;;;;;;;:29;;5848:10;5830:29;:17;:29;:::i;:::-;-1:-1:-1;;;;;5814:13:0;;;;;;:8;:13;;;;;:45;;;;5874:7;;5870:124;;;5916:15;5925:5;;-1:-1:-1;;;;;5925:5:0;5916:15;;:8;:15;;;;;;:24;;5936:3;5916:24;:19;:24;:::i;:::-;5898:15;5907:5;;-1:-1:-1;;;;;5907:5:0;;;5898:15;;:8;:15;;;;;;:42;;;;5971:5;;;;;5955:27;;;;-1:-1:-1;;;;;;;;;;;5955:27:0;5978:3;;5955:27;;;;;;;;;;;;;5870:124;6020:3;-1:-1:-1;;;;;6004:32:0;6013:5;-1:-1:-1;;;;;6004:32:0;-1:-1:-1;;;;;;;;;;;6025:10:0;6004:32;;;;;;;;;;;;;;5143:901;;;;;;;:::o;4290:116::-;-1:-1:-1;;;;;4382:16:0;4350:12;4382:16;;;:8;:16;;;;;;;4290:116::o;3499:573::-;3585:8;;3566:6;3296:8;3278;:26;3276:29;3268:38;;;;;;3596:40;3630:5;3597:27;3608:15;;3597:6;:10;;:27;;;;:::i;3596:40::-;3585:51;;3657:10;;3651:3;:16;3647:65;;;3690:10;;3684:16;;3647:65;3740:15;:6;3751:3;3740:15;:10;:15;:::i;:::-;-1:-1:-1;;;;;3798:10:0;3789:20;;;;;:8;:20;;;;;;3722:33;;-1:-1:-1;3789:32:0;;3814:6;3789:32;:24;:32;:::i;:::-;-1:-1:-1;;;;;3775:10:0;3766:20;;;;;;:8;:20;;;;;;:55;;;;3848:13;;;;;;;:29;;3866:10;3848:29;:17;:29;:::i;:::-;-1:-1:-1;;;;;3832:13:0;;;;;;:8;:13;;;;;:45;;;;3892:7;;3888:129;;;3934:15;3943:5;;-1:-1:-1;;;;;3943:5:0;3934:15;;:8;:15;;;;;;:24;;3954:3;3934:24;:19;:24;:::i;:::-;3916:15;3925:5;;-1:-1:-1;;;;;3925:5:0;;;3916:15;;:8;:15;;;;;;:42;;;;3994:5;;;;;3982:10;3973:32;;;;-1:-1:-1;;;;;;;;;;;3973:32:0;4001:3;;3973:32;;;;;;;;;;;;;3888:129;4048:3;-1:-1:-1;;;;;4027:37:0;4036:10;-1:-1:-1;;;;;4027:37:0;-1:-1:-1;;;;;;;;;;;4053:10:0;4027:37;;;;;;;;;;;;;;3499:573;;;;;:::o;146:208::-;204:7;;228:6;;224:47;;;258:1;251:8;;;;224:47;-1:-1:-1;293:5:0;;;297:1;293;:5;316;;;;;;;;:10;309:18;;;;345:1;338:8;;146:208;;;;;;:::o;7197:145::-;-1:-1:-1;;;;;7309:15:0;;;7275:14;7309:15;;;:7;:15;;;;;;;;:25;;;;;;;;;;;;;7197:145::o;362:288::-;420:7;519:9;535:1;531;:5;;;;;;;;;362:288;-1:-1:-1;;;;362:288:0:o;658:123::-;716:7;743:6;;;;736:14;;;;-1:-1:-1;768:5:0;;;658:123::o;789:147::-;847:7;879:5;;;902:6;;;;895:14;;";
        public TokenDeploymentBase() : base(BYTECODE) { }
        public TokenDeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("uint256", "_initialSupply", 1)]
        public virtual BigInteger InitialSupply { get; set; }
        [Parameter("string", "_name", 2)]
        public virtual string Name { get; set; }
        [Parameter("string", "_symbol", 3)]
        public virtual string Symbol { get; set; }
        [Parameter("uint256", "_decimals", 4)]
        public virtual BigInteger Decimals { get; set; }
    }

    public partial class NameFunction : NameFunctionBase { }

    [Function("name", "string")]
    public class NameFunctionBase : FunctionMessage
    {

    }

    public partial class DeprecateFunction : DeprecateFunctionBase { }

    [Function("deprecate")]
    public class DeprecateFunctionBase : FunctionMessage
    {
        [Parameter("address", "_upgradedAddress", 1)]
        public virtual string UpgradedAddress { get; set; }
    }

    public partial class ApproveFunction : ApproveFunctionBase { }

    [Function("approve")]
    public class ApproveFunctionBase : FunctionMessage
    {
        [Parameter("address", "_spender", 1)]
        public virtual string Spender { get; set; }
        [Parameter("uint256", "_value", 2)]
        public virtual BigInteger Value { get; set; }
    }

    public partial class DeprecatedFunction : DeprecatedFunctionBase { }

    [Function("deprecated", "bool")]
    public class DeprecatedFunctionBase : FunctionMessage
    {

    }

    public partial class AddBlackListFunction : AddBlackListFunctionBase { }

    [Function("addBlackList")]
    public class AddBlackListFunctionBase : FunctionMessage
    {
        [Parameter("address", "_evilUser", 1)]
        public virtual string EvilUser { get; set; }
    }

    public partial class TotalSupplyFunction : TotalSupplyFunctionBase { }

    [Function("totalSupply", "uint256")]
    public class TotalSupplyFunctionBase : FunctionMessage
    {

    }

    public partial class TransferFromFunction : TransferFromFunctionBase { }

    [Function("transferFrom")]
    public class TransferFromFunctionBase : FunctionMessage
    {
        [Parameter("address", "_from", 1)]
        public virtual string From { get; set; }
        [Parameter("address", "_to", 2)]
        public virtual string To { get; set; }
        [Parameter("uint256", "_value", 3)]
        public virtual BigInteger Value { get; set; }
    }

    public partial class UpgradedAddressFunction : UpgradedAddressFunctionBase { }

    [Function("upgradedAddress", "address")]
    public class UpgradedAddressFunctionBase : FunctionMessage
    {

    }

    public partial class BalancesFunction : BalancesFunctionBase { }

    [Function("balances", "uint256")]
    public class BalancesFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class DecimalsFunction : DecimalsFunctionBase { }

    [Function("decimals", "uint256")]
    public class DecimalsFunctionBase : FunctionMessage
    {

    }

    public partial class MaximumFeeFunction : MaximumFeeFunctionBase { }

    [Function("maximumFee", "uint256")]
    public class MaximumFeeFunctionBase : FunctionMessage
    {

    }

    public partial class TotalSupplyFunction : TotalSupplyFunctionBase { }


    public partial class UnpauseFunction : UnpauseFunctionBase { }

    [Function("unpause")]
    public class UnpauseFunctionBase : FunctionMessage
    {

    }

    public partial class GetBlackListStatusFunction : GetBlackListStatusFunctionBase { }

    [Function("getBlackListStatus", "bool")]
    public class GetBlackListStatusFunctionBase : FunctionMessage
    {
        [Parameter("address", "_maker", 1)]
        public virtual string Maker { get; set; }
    }

    public partial class AllowedFunction : AllowedFunctionBase { }

    [Function("allowed", "uint256")]
    public class AllowedFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
        [Parameter("address", "", 2)]
        public virtual string ReturnValue2 { get; set; }
    }

    public partial class PausedFunction : PausedFunctionBase { }

    [Function("paused", "bool")]
    public class PausedFunctionBase : FunctionMessage
    {

    }

    public partial class BalanceOfFunction : BalanceOfFunctionBase { }

    [Function("balanceOf", "uint256")]
    public class BalanceOfFunctionBase : FunctionMessage
    {
        [Parameter("address", "who", 1)]
        public virtual string Who { get; set; }
    }

    public partial class PauseFunction : PauseFunctionBase { }

    [Function("pause")]
    public class PauseFunctionBase : FunctionMessage
    {

    }

    public partial class GetOwnerFunction : GetOwnerFunctionBase { }

    [Function("getOwner", "address")]
    public class GetOwnerFunctionBase : FunctionMessage
    {

    }

    public partial class OwnerFunction : OwnerFunctionBase { }

    [Function("owner", "address")]
    public class OwnerFunctionBase : FunctionMessage
    {

    }

    public partial class SymbolFunction : SymbolFunctionBase { }

    [Function("symbol", "string")]
    public class SymbolFunctionBase : FunctionMessage
    {

    }

    public partial class TransferFunction : TransferFunctionBase { }

    [Function("transfer")]
    public class TransferFunctionBase : FunctionMessage
    {
        [Parameter("address", "_to", 1)]
        public virtual string To { get; set; }
        [Parameter("uint256", "_value", 2)]
        public virtual BigInteger Value { get; set; }
    }

    public partial class SetParamsFunction : SetParamsFunctionBase { }

    [Function("setParams")]
    public class SetParamsFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "newBasisPoints", 1)]
        public virtual BigInteger NewBasisPoints { get; set; }
        [Parameter("uint256", "newMaxFee", 2)]
        public virtual BigInteger NewMaxFee { get; set; }
    }

    public partial class IssueFunction : IssueFunctionBase { }

    [Function("issue")]
    public class IssueFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "amount", 1)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class RedeemFunction : RedeemFunctionBase { }

    [Function("redeem")]
    public class RedeemFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "amount", 1)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class AllowanceFunction : AllowanceFunctionBase { }

    [Function("allowance", "uint256")]
    public class AllowanceFunctionBase : FunctionMessage
    {
        [Parameter("address", "_owner", 1)]
        public virtual string Owner { get; set; }
        [Parameter("address", "_spender", 2)]
        public virtual string Spender { get; set; }
    }

    public partial class BasisPointsRateFunction : BasisPointsRateFunctionBase { }

    [Function("basisPointsRate", "uint256")]
    public class BasisPointsRateFunctionBase : FunctionMessage
    {

    }

    public partial class IsBlackListedFunction : IsBlackListedFunctionBase { }

    [Function("isBlackListed", "bool")]
    public class IsBlackListedFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class RemoveBlackListFunction : RemoveBlackListFunctionBase { }

    [Function("removeBlackList")]
    public class RemoveBlackListFunctionBase : FunctionMessage
    {
        [Parameter("address", "_clearedUser", 1)]
        public virtual string ClearedUser { get; set; }
    }

    public partial class MAX_UINTFunction : MAX_UINTFunctionBase { }

    [Function("MAX_UINT", "uint256")]
    public class MAX_UINTFunctionBase : FunctionMessage
    {

    }

    public partial class TransferOwnershipFunction : TransferOwnershipFunctionBase { }

    [Function("transferOwnership")]
    public class TransferOwnershipFunctionBase : FunctionMessage
    {
        [Parameter("address", "newOwner", 1)]
        public virtual string NewOwner { get; set; }
    }

    public partial class DestroyBlackFundsFunction : DestroyBlackFundsFunctionBase { }

    [Function("destroyBlackFunds")]
    public class DestroyBlackFundsFunctionBase : FunctionMessage
    {
        [Parameter("address", "_blackListedUser", 1)]
        public virtual string BlackListedUser { get; set; }
    }

    public partial class IssueEventDTO : IssueEventDTOBase { }

    [Event("Issue")]
    public class IssueEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "amount", 1, false)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class RedeemEventDTO : RedeemEventDTOBase { }

    [Event("Redeem")]
    public class RedeemEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "amount", 1, false)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class DeprecateEventDTO : DeprecateEventDTOBase { }

    [Event("Deprecate")]
    public class DeprecateEventDTOBase : IEventDTO
    {
        [Parameter("address", "newAddress", 1, false)]
        public virtual string NewAddress { get; set; }
    }

    public partial class ParamsEventDTO : ParamsEventDTOBase { }

    [Event("Params")]
    public class ParamsEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "feeBasisPoints", 1, false)]
        public virtual BigInteger FeeBasisPoints { get; set; }
        [Parameter("uint256", "maxFee", 2, false)]
        public virtual BigInteger MaxFee { get; set; }
    }

    public partial class DestroyedBlackFundsEventDTO : DestroyedBlackFundsEventDTOBase { }

    [Event("DestroyedBlackFunds")]
    public class DestroyedBlackFundsEventDTOBase : IEventDTO
    {
        [Parameter("address", "_blackListedUser", 1, false)]
        public virtual string BlackListedUser { get; set; }
        [Parameter("uint256", "_balance", 2, false)]
        public virtual BigInteger Balance { get; set; }
    }

    public partial class AddedBlackListEventDTO : AddedBlackListEventDTOBase { }

    [Event("AddedBlackList")]
    public class AddedBlackListEventDTOBase : IEventDTO
    {
        [Parameter("address", "_user", 1, false)]
        public virtual string User { get; set; }
    }

    public partial class RemovedBlackListEventDTO : RemovedBlackListEventDTOBase { }

    [Event("RemovedBlackList")]
    public class RemovedBlackListEventDTOBase : IEventDTO
    {
        [Parameter("address", "_user", 1, false)]
        public virtual string User { get; set; }
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





    public partial class NameOutputDTO : NameOutputDTOBase { }

    [FunctionOutput]
    public class NameOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }





    public partial class DeprecatedOutputDTO : DeprecatedOutputDTOBase { }

    [FunctionOutput]
    public class DeprecatedOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }



    public partial class TotalSupplyOutputDTO : TotalSupplyOutputDTOBase { }

    [FunctionOutput]
    public class TotalSupplyOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }



    public partial class UpgradedAddressOutputDTO : UpgradedAddressOutputDTOBase { }

    [FunctionOutput]
    public class UpgradedAddressOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class BalancesOutputDTO : BalancesOutputDTOBase { }

    [FunctionOutput]
    public class BalancesOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class DecimalsOutputDTO : DecimalsOutputDTOBase { }

    [FunctionOutput]
    public class DecimalsOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class MaximumFeeOutputDTO : MaximumFeeOutputDTOBase { }

    [FunctionOutput]
    public class MaximumFeeOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class TotalSupplyOutputDTO : TotalSupplyOutputDTOBase { }




    public partial class GetBlackListStatusOutputDTO : GetBlackListStatusOutputDTOBase { }

    [FunctionOutput]
    public class GetBlackListStatusOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class AllowedOutputDTO : AllowedOutputDTOBase { }

    [FunctionOutput]
    public class AllowedOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class PausedOutputDTO : PausedOutputDTOBase { }

    [FunctionOutput]
    public class PausedOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class BalanceOfOutputDTO : BalanceOfOutputDTOBase { }

    [FunctionOutput]
    public class BalanceOfOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }



    public partial class GetOwnerOutputDTO : GetOwnerOutputDTOBase { }

    [FunctionOutput]
    public class GetOwnerOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class OwnerOutputDTO : OwnerOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class SymbolOutputDTO : SymbolOutputDTOBase { }

    [FunctionOutput]
    public class SymbolOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }









    public partial class AllowanceOutputDTO : AllowanceOutputDTOBase { }

    [FunctionOutput]
    public class AllowanceOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "remaining", 1)]
        public virtual BigInteger Remaining { get; set; }
    }

    public partial class BasisPointsRateOutputDTO : BasisPointsRateOutputDTOBase { }

    [FunctionOutput]
    public class BasisPointsRateOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class IsBlackListedOutputDTO : IsBlackListedOutputDTOBase { }

    [FunctionOutput]
    public class IsBlackListedOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }



    public partial class MAX_UINTOutputDTO : MAX_UINTOutputDTOBase { }

    [FunctionOutput]
    public class MAX_UINTOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }





