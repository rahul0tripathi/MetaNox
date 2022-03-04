using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CameraBoundScript : MonoBehaviour
{
	public static CameraBoundScript instance;

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

	private void Awake()
	{
		instance = this;
	}

	void OnDrawGizmos()
	{
		//Gizmos.matrix = transform.localToWorldMatrix;
		Gizmos.color = Color.yellow;
		Gizmos.matrix = transform.localToWorldMatrix;
		Gizmos.DrawWireCube(Vector3.zero, new Vector3(this.Bound.width, this.Bound.height, 0));
	}


	void LateUpdate()
	{
		if (transform.hasChanged)
		{
			_UpdateBoundPositions();
			transform.hasChanged = false;
		}
	}

	private void _UpdateBoundPositions()
	{
		Vector3 delta = transform.TransformVector(new Vector3(-this.Bound.width, this.Bound.height, 0) / 2.0f);
		this.CameraClampTopLeftPosition = transform.position + delta;
		this.CameraClampBottomRightPosition = transform.position - delta;
	}

	//for updating bounds when value change in inspector
	void OnValidate()
	{
		_UpdateBoundPositions();
	}
}
