using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private Vector3 Origin;
    private Vector3 ResetCamera;
    private Vector3 Difference;

    //

    [SerializeField]
    private Rect _Bound;
    public Rect Bound
    {
        get
        {
            return _Bound;
        }

        set
        {
            _Bound = value;
            _UpdateBoundPositions();
        }
    }

    public Vector3 CameraClampTopLeftPosition;
    public Vector3 CameraClampBottomRightPosition;

    //



    private bool drag = false;
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
            Difference = (Camera.main.ScreenToWorldPoint(Input.mousePosition)) - Camera.main.transform.position;
            if(drag == false)
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
        {
             Camera.main.transform.position = Origin - Difference;
             //Camera.main.transform.position = new Vector3(
             //Mathf.Clamp(Camera.main.transform.position.x, -1, 4),
             //Mathf.Clamp(Camera.main.transform.position.y, 0, 0), transform.position.z);
        }

        this.ClampCamera();
      
    }



    void OnDrawGizmos()
    {
        //Gizmos.matrix = transform.localToWorldMatrix;
        Gizmos.color = Color.yellow;
        Gizmos.matrix = transform.localToWorldMatrix;
        Gizmos.DrawWireCube(Vector3.zero, new Vector3(this.Bound.width, this.Bound.height, 0));
    }

    private void _UpdateBoundPositions()
    {
        Vector3 delta = transform.TransformVector(new Vector3(-this.Bound.width, this.Bound.height, 0) / 2.0f);
        this.CameraClampTopLeftPosition = transform.position + delta;
        this.CameraClampBottomRightPosition = transform.position - delta;
    }

    public void ClampCamera()
    {
        //		return;
        float worldSizePerPixel = 2 * Camera.main.orthographicSize / (float)Screen.height;

        //clamp camera left and top
        Vector3 leftClampScreenPos = Camera.main.WorldToScreenPoint(CameraBoundScript.instance.CameraClampTopLeftPosition);
        if (leftClampScreenPos.x > 0)
        {
            float deltaFactor = leftClampScreenPos.x * worldSizePerPixel;
            Vector3 delta = new Vector3(deltaFactor, 0, 0);
            delta = Camera.main.transform.TransformVector(delta);
            Camera.main.transform.localPosition += delta;
        }

        if (leftClampScreenPos.y < Screen.height)
        {
            float deltaFactor = (Screen.height - leftClampScreenPos.y) * worldSizePerPixel;
            Vector3 delta = new Vector3(-deltaFactor, 0, -deltaFactor);
            Camera.main.transform.localPosition += delta;
        }
        //clamp camera right and bottom
        Vector3 rightClampScreenPos = Camera.main.WorldToScreenPoint(CameraBoundScript.instance.CameraClampBottomRightPosition);

        if (rightClampScreenPos.x < Screen.width)
        {
            float deltaFactor = (rightClampScreenPos.x - Screen.width) * worldSizePerPixel;
            Vector3 delta = new Vector3(deltaFactor, 0, 0);
            delta = Camera.main.transform.TransformVector(delta);
            Camera.main.transform.localPosition += delta;
        }

        if (rightClampScreenPos.y > 0)
        {
            float deltaFactor = rightClampScreenPos.y * worldSizePerPixel;
            Vector3 delta = new Vector3(deltaFactor, 0, deltaFactor);
            Camera.main.transform.localPosition += delta;
        }
    }


}
