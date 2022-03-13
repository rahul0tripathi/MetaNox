using UnityEngine;
using System.Collections;
using MoralisWeb3ApiSdk;
using UnityEngine.UI;

public class Build : MonoBehaviour
{
    // Use this for initialization
    public GameObject buildLogObject;
    public int posX;
    public int posY;
    public int itemSelectd;

    public GameObject cannonCount;
    public GameObject BarrackCount;
    public GameObject TowerCount;
    public GameObject GoldBoxCount;
    public GameObject isBuilderBusy;
    public GameObject selected;
    public GameObject BuildBtn;
    public Main main;
    async public void OnEnable()
    {
        Debug.Log("Called OnENbale");
        cannonCount.GetComponent<TMPro.TextMeshProUGUI>().text = "x" + (await main.noxTokenHandler.GetBalance(1)).ToString();
        BarrackCount.GetComponent<TMPro.TextMeshProUGUI>().text = "x" + (await main.noxTokenHandler.GetBalance(4)).ToString();
        TowerCount.GetComponent<TMPro.TextMeshProUGUI>().text = "x" + (await main.noxTokenHandler.GetBalance(6)).ToString();
        GoldBoxCount.GetComponent<TMPro.TextMeshProUGUI>().text = "x" + (await main.noxTokenHandler.GetBalance(7)).ToString();
        var isBuilderFree = await main.noxTokenHandler.isBuilderFree();
        if (!isBuilderFree)
        {
            isBuilderBusy.GetComponent<Toggle>().isOn = false;
            BuildBtn.SetActive(false);
        }
        else
        {
            isBuilderBusy.GetComponent<Toggle>().isOn = true;
            BuildBtn.SetActive(true);
        }

    }
    public void NewBuild() {
        itemSelectd = 6;
        main.BuildNewFn(itemSelectd, posX, posY);
        //return true;
    }
    public void addX(string x)
    {   
        posX = int.Parse(x);
    }
    public void addY(string y)
    {
        posY = int.Parse(y);
    }
    async public void SelectCannon() {
        var bal = await main.noxTokenHandler.GetBalance(1);
            if (bal > 0) {
            itemSelectd = 1;
            selected.GetComponent<TMPro.TextMeshProUGUI>().text = "SELECTED: CANNON";
        }
    }
    async public void SelectBarrack() {
        var bal = await main.noxTokenHandler.GetBalance(4);
        if (bal > 0)
        {
            itemSelectd = 4;
            selected.GetComponent<TMPro.TextMeshProUGUI>().text = "SELECTED: BARRACK";
        }

    }
    async public void SelectTower() {
        var bal = await main.noxTokenHandler.GetBalance(6);
        if (bal > 0)
        {
            itemSelectd = 6;
            selected.GetComponent<TMPro.TextMeshProUGUI>().text = "SELECTED: TOWER";
        }
    }
     public void SelectGoldBox() {
        //var bal = await main.noxTokenHandler.GetBalance(7);
        //Debug.Log(bal);
        //if (bal > 0)
        //{
        //    itemSelectd = 7;
        //    selected.GetComponent<TMPro.TextMeshProUGUI>().text = "SELECTED: GOLD BOX";
        //}
        Debug.Log("called");
    }

}
