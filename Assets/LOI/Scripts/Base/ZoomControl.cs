using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomControl : MonoBehaviour
{
    public float ZoomChange;
    public float SmoothChange;
    public float MinSize, MaxSize;
    public float speed;

    private Camera cam;
//#if UNITY_ANDROID || UNITY_IOS

//    public void Awake()
//    {
//        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
//        {
//            Vector2 TouchDeltaPosition = Input.GetTouch(0).deltaPosition;

//            transform.Translate(-TouchDeltaPosition.x * speed, -TouchDeltaPosition.y * speed, 0);

//            transform.position = new Vector3(
//                Mathf.Clamp(transform.position.x, -40f, 40f),
//                Mathf.Clamp(transform.position.y, -0f, 0f),
//                Mathf.Clamp(transform.position.z, -25f, 50f));
//        }
//    }

//#elif UNITY_2017_2_OR_NEWER


    private void Start()
    {
        cam = GetComponent<Camera>();
    }

    private void Update()
    {
        if (Input.mouseScrollDelta.y > 0)
            cam.orthographicSize -= ZoomChange * Time.deltaTime * SmoothChange;
        if (Input.mouseScrollDelta.y < 0)
            cam.orthographicSize += ZoomChange * Time.deltaTime * SmoothChange;

        cam.orthographicSize = Mathf.Clamp(cam.orthographicSize, MinSize, MaxSize);
    }

//#endif

}
