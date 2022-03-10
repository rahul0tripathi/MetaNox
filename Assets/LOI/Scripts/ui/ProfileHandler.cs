using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfileHandler : MonoBehaviour
{
    const string imageUrl = "https://icotar.com/avatar/";
    public GameObject walletLabel;
    public GameObject profileImage;
    public void UpdateWalletAddress(string address)
    {

        walletLabel.GetComponent<UnityEngine.UI.Text>().text = address;
        LoadProfile(address);
    }
    // Start is called before the first frame update
    void Start()
    {

    }
    public void LoadProfile(string address)
    {
        IEnumerator coroutine = LoadProfileImage(imageUrl + address + ".png");
        StartCoroutine(coroutine);
    }

    IEnumerator LoadProfileImage(string url)
    {
        Debug.Log(url);
        Texture2D tex;
        tex = new Texture2D(4, 4, TextureFormat.DXT1, false);
        WWW www = new WWW(url);
        yield return www;
        www.LoadImageIntoTexture(tex);
        Sprite sprite = Sprite.Create(tex, new Rect(0, 0, 8, 8), new Vector2(0.5f, 0.5f), 100);
        profileImage.GetComponent<UnityEngine.UI.Image>().sprite = sprite;
    }
    void Update()
    {

    }
}
