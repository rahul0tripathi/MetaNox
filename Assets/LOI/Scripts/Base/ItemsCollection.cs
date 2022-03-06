using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ItemsCollection : ScriptableObject
{
    public List<ItemData> list = new List<ItemData>();

    public void AddNewItem()
    {
        var newItemData = new ItemData();
        newItemData.id = _GetUnusedId();
        newItemData.name = "New Item";

        list.Add(newItemData);
    }

    public void RemoveItem(int index)
    {
        list.RemoveAt(index - 1);
    }

    private int _GetUnusedId()
    {
        var id = Random.Range(1000, 9999);
        for (var index = 0; index < list.Count; index++)
            if (id == list[index].id)
                return _GetUnusedId();

        return id;
    }

    [Serializable]
    public class Configuration
    {
        public float buildTime;
        public bool isCharacter;
        public float speed;
        public float attackRange;
        public float defenceRange;
        public float healthPoints;
        public float hitPoints;
        public float productionRate;
        public string product;
    }

    [Serializable]
    public class ItemData
    {
        public int id;
        public string name;
        public Texture2D thumb;

        public int gridSize = 4;
        public Configuration configuration = new Configuration();

        public List<int> idleSprites;
        public List<int> walkSprites;
        public List<int> attackSprites;
        public List<int> destroyedSprites;


        public ItemData()
        {
            idleSprites = new List<int>();
            walkSprites = new List<int>();
            attackSprites = new List<int>();
            destroyedSprites = new List<int>();
        }

        public void AddSprite(SpriteCollection.SpriteData sprite, CommonHandler.State state)
        {
            var sprites = idleSprites;
            switch (state)
            {
                case CommonHandler.State.IDLE:
                    sprites = idleSprites;
                    break;
                case CommonHandler.State.WALK:
                    sprites = walkSprites;
                    break;
                case CommonHandler.State.ATTACK:
                    sprites = attackSprites;
                    break;
                case CommonHandler.State.DESTROYED:
                    sprites = destroyedSprites;
                    break;
            }

            if (!sprites.Contains(sprite.id)) sprites.Add(sprite.id);
        }

        public void RemoveSprite(SpriteCollection.SpriteData sprite, CommonHandler.State state)
        {
            var sprites = idleSprites;
            switch (state)
            {
                case CommonHandler.State.IDLE:
                    sprites = idleSprites;
                    break;
                case CommonHandler.State.WALK:
                    sprites = walkSprites;
                    break;
                case CommonHandler.State.ATTACK:
                    sprites = attackSprites;
                    break;
                case CommonHandler.State.DESTROYED:
                    sprites = destroyedSprites;
                    break;
            }

            if (sprites.Contains(sprite.id)) sprites.Remove(sprite.id);
        }

        public List<int> GetSprites(CommonHandler.State state)
        {
            switch (state)
            {
                case CommonHandler.State.IDLE:
                    return idleSprites;
                case CommonHandler.State.WALK:
                    return walkSprites;
                case CommonHandler.State.ATTACK:
                    return attackSprites;
                case CommonHandler.State.DESTROYED:
                    return destroyedSprites;
            }

            return idleSprites;
        }
    }
}