using UnityEngine;

public class CameraMove : MonoBehaviour
{
    //

    [SerializeField] private Rect _Bound;

    public Vector3 CameraClampTopLeftPosition;
    public Vector3 CameraClampBottomRightPosition;
    private Vector3 Difference;

    //


    private bool drag;
    private Vector3 Origin;
    private Vector3 ResetCamera;

    public Rect Bound
    {
        get => _Bound;

        set
        {
            _Bound = value;
            _UpdateBoundPositions();
        }
    }

    // Start is called before the first frame update
    private void Start()
    {
        ResetCamera = Camera.main.transform.position;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            Difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - Camera.main.transform.position;
            if (drag == false)
            {
                drag = true;
                Origin = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
        }

        else
        {
            drag = false;
        }

        if (drag)
            Camera.main.transform.position = Origin - Difference;
        //Camera.main.transform.position = new Vector3(
        //Mathf.Clamp(Camera.main.transform.position.x, -1, 4),
        //Mathf.Clamp(Camera.main.transform.position.y, 0, 0), transform.position.z);

        ClampCamera();
    }


    private void OnDrawGizmos()
    {
        //Gizmos.matrix = transform.localToWorldMatrix;
        Gizmos.color = Color.yellow;
        Gizmos.matrix = transform.localToWorldMatrix;
        Gizmos.DrawWireCube(Vector3.zero, new Vector3(Bound.width, Bound.height, 0));
    }

    private void _UpdateBoundPositions()
    {
        var delta = transform.TransformVector(new Vector3(-Bound.width, Bound.height, 0) / 2.0f);
        CameraClampTopLeftPosition = transform.position + delta;
        CameraClampBottomRightPosition = transform.position - delta;
    }

    public void ClampCamera()
    {
        //		return;
        var worldSizePerPixel = 2 * Camera.main.orthographicSize / Screen.height;

        //clamp camera left and top
        var leftClampScreenPos =
            Camera.main.WorldToScreenPoint(CameraBoundScript.instance.CameraClampTopLeftPosition);
        if (leftClampScreenPos.x > 0)
        {
            var deltaFactor = leftClampScreenPos.x * worldSizePerPixel;
            var delta = new Vector3(deltaFactor, 0, 0);
            delta = Camera.main.transform.TransformVector(delta);
            Camera.main.transform.localPosition += delta;
        }

        if (leftClampScreenPos.y < Screen.height)
        {
            var deltaFactor = (Screen.height - leftClampScreenPos.y) * worldSizePerPixel;
            var delta = new Vector3(-deltaFactor, 0, -deltaFactor);
            Camera.main.transform.localPosition += delta;
        }

        //clamp camera right and bottom
        var rightClampScreenPos =
            Camera.main.WorldToScreenPoint(CameraBoundScript.instance.CameraClampBottomRightPosition);

        if (rightClampScreenPos.x < Screen.width)
        {
            var deltaFactor = (rightClampScreenPos.x - Screen.width) * worldSizePerPixel;
            var delta = new Vector3(deltaFactor, 0, 0);
            delta = Camera.main.transform.TransformVector(delta);
            Camera.main.transform.localPosition += delta;
        }

        if (rightClampScreenPos.y > 0)
        {
            var deltaFactor = rightClampScreenPos.y * worldSizePerPixel;
            var delta = new Vector3(deltaFactor, 0, deltaFactor);
            Camera.main.transform.localPosition += delta;
        }
    }
}