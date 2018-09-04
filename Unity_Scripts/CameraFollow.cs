using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public Transform targetTransform;
	public float distanceToTarget;
	public Transform target;
	void Update ()
	{
		transform.position = targetTransform.position -
			(Vector3.forward * distanceToTarget);
		
		transform.LookAt(targetTransform);


	}
}
