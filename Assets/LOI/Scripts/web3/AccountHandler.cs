using UnityEngine;
using System.Collections;

public class AccountHandler : MonoBehaviour
{
    private string accountAddress = "";
    public void SetUserAddress(string address)
    {
        this.accountAddress = address;
    }
    public string GetAccountAddress()
    {
        return accountAddress;
    }
    
}

