using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WalletConnectSharp.Core.Models;
using WalletConnectSharp.Unity;
using Moralis;
using Assets;
using MoralisWeb3ApiSdk;
using Moralis.WebGL.Hex.HexTypes;
using System.Numerics;
public class SignUpPanel : MonoBehaviour
{
    public static SignUpPanel instance;
    public WalletConnect walletConnect;
    public MoralisController moralisController;
    public GameObject qrMenu;
    public GameObject walletOverlay;
    public ProfileHandler profile;
    async public void Start()
    {
        if (moralisController != null && moralisController)
        {
            await moralisController.Initialize();
        }
        else
        {
            // Moralis values not set or initialized.
            Debug.LogError("The MoralisInterface has not been set up, please check you MoralisController in the scene.");
        }
    }
    public async void Play()
    {
        if (MoralisInterface.IsLoggedIn())
        {
            Debug.Log("User is already logged in to Moralis.");
        }
        // User is not logged in, depending on build target, begin wallect connection.
        else
        {
            Debug.Log("User is not logged in.");
        }
        qrMenu.SetActive(true);

    }
    public async void WalletConnectHandler(WCSessionData data)
    {
        MoralisInterface.SetupWeb3();
        Debug.Log("Wallet connection received");
        string address = data.accounts[0].ToLower();
        string appId = MoralisInterface.GetClient().ApplicationId;
        long serverTime = 0;
        Dictionary<string, object> serverTimeResponse = await MoralisInterface.GetClient().Cloud.RunAsync<Dictionary<string, object>>("getServerTime", new Dictionary<string, object>());

        if (serverTimeResponse == null || !serverTimeResponse.ContainsKey("dateTime") ||
            !long.TryParse(serverTimeResponse["dateTime"].ToString(), out serverTime))
        {
            Debug.Log("Failed to retrieve server time from Moralis Server!");
        }

        string signMessage = $"Welcome to MetaNox Signin to Continue. \n\nId: {appId}:{serverTime}";

        Debug.Log($"Sending sign request for {address} ...");

        string response = await walletConnect.Session.EthPersonalSign(address, signMessage);

        Debug.Log($"Signature {response} for {address} was returned.");

        // Create moralis auth data from message signing response.
        Dictionary<string, object> authData = new Dictionary<string, object> { { "id", address }, { "signature", response }, { "data", signMessage } };

        Debug.Log("Logging in user.");
        Debug.Log(authData["data"]);
        Debug.Log(authData["id"]);
        Debug.Log(authData["signature"]);

        // Attempt to login user.
        Moralis.Platform.Objects.MoralisUser user = await MoralisInterface.LogInAsync(authData);
        
        if (user != null)
        {
            Debug.Log($"User {user.username} logged in successfully. ");
            Main.instance.SetupContracts();
            Main.instance.LoadScene();
            walletOverlay.SetActive(true);
            profile.UpdateWalletAddress(user.ethAddress);
            qrMenu.SetActive(false);
        }
        else
        {
            Debug.Log("User login failed.");
        }
    }
    public void WalletConnectSessionEstablished(WalletConnectUnitySession session)
    {
        MoralisInterface.SetupWeb3();
    }

}
