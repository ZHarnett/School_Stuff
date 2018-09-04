using UnityEngine;
using System.Collections;

public class Teleport1 : MonoBehaviour {

	public GameObject teleportPoint;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter (Collider other){
		other.transform.position = teleportPoint.transform.position;
	}
}
