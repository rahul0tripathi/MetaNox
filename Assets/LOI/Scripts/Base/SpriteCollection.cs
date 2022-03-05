using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

[Serializable]
public class SpriteCollection : ScriptableObject
{
    [SerializeField] public List<SpriteData> list = new List<SpriteData>();

    public void AddNewSprite()
    {
        var newSpriteData = new SpriteData();
        newSpriteData.id = _GetUnusedId();
        newSpriteData.name = "New Sprite";

        list.Add(newSpriteData);
    }

    private int _GetUnusedId()
    {
        var id = Random.Range(100, 999);
        for (var index = 0; index < list.Count; index++)
            if (id == list[index].id)
                return _GetUnusedId();

        return id;
    }

    public void RemoveSprite(int id)
    {
        list.RemoveAt(id - 1);
    }

    public SpriteData GetSprite(int id)
    {
        for (var index = 0; index < list.Count; index++)
            if (id == list[index].id)
                return list[index];

        return null;
    }

    [Serializable]
    public class TextureData
    {
        public SpriteData parent;
        public Texture2D texture;
        public float offsetX;
        public float offsetY;
        public float scale = 100.0f;

        public int numberOfColumns = 1;
        public int numberOfRows = 1;
        public int framesCount = 1;
        public int fps = 1;

        public TextureData(SpriteData parent)
        {
            this.parent = parent;
        }
    }

    [Serializable]
    public class SpriteData
    {
        public int id;
        public string name;

        public int gridSize = 4;
        public Common.RenderingLayer renderingLayer;
        public int renderingOrder;

        public TextureData bottomTexture;
        public TextureData bottomRightTexture;
        public TextureData rightTexture;
        public TextureData topRightTexture;
        public TextureData topTexture;

        public SpriteData()
        {
            bottomTexture = new TextureData(this);
            bottomRightTexture = new TextureData(this);
            rightTexture = new TextureData(this);
            topRightTexture = new TextureData(this);
            topTexture = new TextureData(this);
        }

        public TextureData GetTextureData(Common.Direction direction)
        {
            TextureData textureData = null;
            switch (direction)
            {
                case Common.Direction.BOTTOM:
                    textureData = bottomTexture;
                    break;
                case Common.Direction.BOTTOM_RIGHT:
                    textureData = bottomRightTexture;
                    break;
                case Common.Direction.RIGHT:
                    textureData = rightTexture;
                    break;
                case Common.Direction.TOP_RIGHT:
                    textureData = topRightTexture;
                    break;
                case Common.Direction.TOP:
                    textureData = topTexture;
                    break;

                case Common.Direction.TOP_LEFT:
                    textureData = topRightTexture;
                    break;
                case Common.Direction.LEFT:
                    textureData = rightTexture;
                    break;
                case Common.Direction.BOTTOM_LEFT:
                    textureData = bottomRightTexture;
                    break;
            }

            if (textureData.texture == null) textureData = bottomTexture;

            return textureData;
        }
    }
}