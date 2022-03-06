using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BaseItemScript : MonoBehaviour
{
    public GameObject Container;
    public Collider BoxCollider;

    public BaseItemRendererScript Renderer;


    public int instanceId;
    public CommonHandler.State state;
    public CommonHandler.Direction direction;

    public ItemsCollection.ItemData itemData;
    public float healthPoints;

    public bool isDestroyed;
    public bool ownedItem;

    public List<BaseItemScript> connectedItems;


    private Dictionary<float, CommonHandler.Direction> _angleToDirectionMap;


    public UnityAction<BaseItemScript> OnItemDestroy;


    private void Awake()
    {
        _angleToDirectionMap = new Dictionary<float, CommonHandler.Direction>();
        _angleToDirectionMap.Add(0, CommonHandler.Direction.BOTTOM_RIGHT);
        _angleToDirectionMap.Add(51, CommonHandler.Direction.BOTTOM);
        _angleToDirectionMap.Add(110, CommonHandler.Direction.BOTTOM_LEFT);
        _angleToDirectionMap.Add(153, CommonHandler.Direction.LEFT);
        _angleToDirectionMap.Add(190, CommonHandler.Direction.TOP_LEFT);
        _angleToDirectionMap.Add(220, CommonHandler.Direction.TOP);
        _angleToDirectionMap.Add(290, CommonHandler.Direction.TOP_RIGHT);
        _angleToDirectionMap.Add(357, CommonHandler.Direction.RIGHT);
    }


    private void Update()
    {
        Renderer.Refresh();
    }

    private void OnDestroy()
    {

    }

    public void SetItemData(int itemId, int posX, int posZ)
    {
        itemData = Items.GetItem(itemId);
        gameObject.name = itemData.name + " [INSTANCE]";
        SetSize(Vector3.one * itemData.gridSize);

        healthPoints = itemData.configuration.healthPoints;

        Renderer.Init();


        connectedItems = new List<BaseItemScript>();


        BoxCollider.enabled = !itemData.configuration.isCharacter;

        SetPosition(new Vector3(posX, 0, posZ));

        Debug.Log("here");
    }

    /// <summary>
    ///     Sets the angle.
    /// </summary>
    /// <param name="angle">Angle.</param>
    public void SetAngle(float angle)
    {
        var direction = CommonHandler.Direction.BOTTOM_RIGHT;
        float minAnge = 999;
        foreach (var entry in _angleToDirectionMap)
        {
            var a = Mathf.Abs(angle - entry.Key);
            if (a < minAnge)
            {
                minAnge = a;
                direction = entry.Value;
            }
        }

        SetDirection(direction);
    }

    /// <summary>
    ///     Sets the direction.
    /// </summary>
    /// <param name="direction">Direction.</param>
    public void SetDirection(CommonHandler.Direction direction)
    {
        this.direction = direction;
        //this.UpdateConnectedItems();
    }

    /// <summary>
    ///     Sets the state.
    /// </summary>
    /// <param name="state">State.</param>
    public void SetState(CommonHandler.State state)
    {
        if (state != this.state)
            this.state = state;
        //	this.UpdateConnectedItems();
    }

    /// <summary>
    ///     Sets the position.
    /// </summary>
    /// <param name="position">Position.</param>
    public void SetPosition(Vector3 position)
    {
        transform.localPosition = position;
    }

    public int GetPositionX()
    {
        return (int)GetPosition().x;
    }

    public int GetPositionZ()
    {
        return (int)GetPosition().z;
    }

    /// <summary>
    ///     Gets the position.
    /// </summary>
    /// <returns>The position.</returns>
    public Vector3 GetPosition()
    {
        return transform.localPosition;
    }

    public Vector3 GetCenterPosition()
    {
        return GetPosition() + GetSize() / 2.0f;
    }

    /// <summary>
    ///     Gets the position.
    /// </summary>
    /// <returns>The position.</returns>
    public Vector3 GetSize()
    {
        return new Vector3(transform.localScale.x, 0, transform.localScale.z);
    }

    /// <summary>
    ///     Sets the size.
    /// </summary>
    /// <param name="size">Size.</param>
    public void SetSize(Vector3 size)
    {
        transform.localScale = size;
    }



    public Vector3[] GetOuterCells()
    {
        var sizeX = (int)GetSize().x;

        if (sizeX <= 1) return new Vector3[0];

        var cells = new List<Vector3>();
        for (var x = 0; x <= sizeX; x++)
            for (var z = 0; z <= sizeX; z++)
                if (x == sizeX || z == sizeX || x == 0 || z == 0)
                {
                    var cellPos = GetPosition() + new Vector3(x, 0, z);
                    if (!cells.Contains(cellPos)) cells.Add(cellPos);
                }

        return cells.ToArray();
    }



}