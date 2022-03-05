using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Sprites
{
    public static Dictionary<int, SpriteCollection.SpriteData> sprites;
    public static Dictionary<Texture2D, Material> textureMaterialMap;

    public static void LoadSprites()
    {
        sprites = new Dictionary<int, SpriteCollection.SpriteData>();

        var spriteCollection =
            Resources.Load("SpriteCollection", typeof(SpriteCollection)) as SpriteCollection;
        if (spriteCollection != null)
            for (var index = 0; index < spriteCollection.list.Count; index++)
            {
                var spriteData = spriteCollection.list[index];
                sprites.Add(spriteData.id, spriteData);
            }
        else
            Debug.LogError("SpriteCollection is missing! please go to 'Windows/Item Editor'");
    }

    public static void LoadScriptableFromJSON()
    {
        sprites = new Dictionary<int, SpriteCollection.SpriteData>();
        // SpriteCollection spriteCollection = Resources.Load("PotionData.json", typeof(SpriteCollection)) as SpriteCollection;
        string data = File.ReadAllText(Application.dataPath + "/PotionData.json");
        var spriteCollection = ScriptableObject.CreateInstance<SpriteCollection>();
        JsonUtility.FromJsonOverwrite(data, spriteCollection);
        //   Debug.Log(JsonUtility.ToJson(spriteCollection));
        if (spriteCollection != null)
            for (var index = 0; index < spriteCollection.list.Count; index++)
            {
                //     Debug.Log(index);
                var spriteData = spriteCollection.list[index];
                //   Debug.Log(JsonUtility.ToJson(spriteData));
                sprites.Add(spriteData.id, spriteData);
            }
        else
            Debug.LogError("SpriteCollection is missing! please go to 'Windows/Item Editor'");
    }

    public static SpriteCollection.SpriteData GetSprite(int spriteId)
    {
        SpriteCollection.SpriteData sprite = null;
        sprites.TryGetValue(spriteId, out sprite);
        return sprite;
    }

    public static Material GetTextureMaterial(Texture2D texture, Common.RenderingLayer layer, int order)
    {
        if (textureMaterialMap == null) textureMaterialMap = new Dictionary<Texture2D, Material>();

        Material material = null;
        if (!textureMaterialMap.TryGetValue(texture, out material))
        {
            material = Object.Instantiate(Main.instance.RenderQuadMaterial);
            material.mainTexture = texture;
            textureMaterialMap.Add(texture, material);
        }

        material.renderQueue = 3000 + 100 * (int)layer + order;
        return material;
    }
}