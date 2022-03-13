using UnityEngine;
using UnityEngine.Networking;
using System.Threading.Tasks;
using System;

public class BaseLandScript: MonoBehaviour
{
    SceneData data;
    [ContextMenu("test get")]
    public  async Task<SceneData> getBaseLandConfig() {
        using var www = UnityWebRequest.Get(BaseConstants.BASE_LAND_JSON);
        www.SetRequestHeader("Content-Type", "application/json");
        var operation = www.SendWebRequest();
        while(!operation.isDone)
        {
            await Task.Yield();
        }
        if (www.result == UnityWebRequest.Result.Success)
        {
            Debug.Log($"Success:{www.downloadHandler.text}");
            try
            {
                var result = www.downloadHandler.text;
                data = JsonUtility.FromJson<SceneData>(result);
            }
            catch(Exception e)
            {
                Debug.LogError(e);
            }
        }
        return data;

          
    }
}
