using UnityEngine;

[ExecuteInEditMode]
public class CameraBoundScript : MonoBehaviour
{
    public static CameraBoundScript instance;

    [SerializeField] private Rect _Bound;

    public Vector3 CameraClampTopLeftPosition;
    public Vector3 CameraClampBottomRightPosition;

    public Rect Bound
    {
        get => _Bound;

        set
        {
            _Bound = value;
            _UpdateBoundPositions();
        }
    }

    private void Awake()
    {
        instance = this;
    }


    private void LateUpdate()
    {
        if (transform.hasChanged)
        {
            _UpdateBoundPositions();
            transform.hasChanged = false;
        }
    }

    private void OnDrawGizmos()
    {
        //Gizmos.matrix = transform.localToWorldMatrix;
        Gizmos.color = Color.yellow;
        Gizmos.matrix = transform.localToWorldMatrix;
        Gizmos.DrawWireCube(Vector3.zero, new Vector3(Bound.width, Bound.height, 0));
    }

    //for updating bounds when value change in inspector
    private void OnValidate()
    {
        _UpdateBoundPositions();
    }

    private void _UpdateBoundPositions()
    {
        var delta = transform.TransformVector(new Vector3(-Bound.width, Bound.height, 0) / 2.0f);
        CameraClampTopLeftPosition = transform.position + delta;
        CameraClampBottomRightPosition = transform.position - delta;
    }
}