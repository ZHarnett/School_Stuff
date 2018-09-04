using UnityEngine;
using System.Collections;

public class GetPellets : MonoBehaviour {

	Transform myTransform; //current transform data of this enemy
	
	private NavMeshAgent _navMeshAgent;

	// Use this for initialization
	void Start () {
		myTransform = transform;
		_navMeshAgent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	public Transform target;
	public float speed;

	void Update() {
		_navMeshAgent.speed = speed;
		target = FindClosestEnemy ().transform;
		_navMeshAgent.destination = target.position;
		Vector3 targetDir = target.position - transform.position;
		float step = speed * Time.deltaTime;
		Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0F);
		Debug.DrawRay(transform.position, newDir, Color.red);
		transform.rotation = Quaternion.LookRotation(newDir);

		transform.position = Vector3.MoveTowards(transform.position, target.position, step);

	}

	void OnTriggerEnter(Collider other) 
	{	

		if (other.gameObject.CompareTag ("Pellet")) {	

			Destroy (other.gameObject);
		}
	}
	GameObject FindClosestEnemy() {
		GameObject[] gos;
		gos = GameObject.FindGameObjectsWithTag("Pellet");
		GameObject closest = null;
		float distance = Mathf.Infinity;
		Vector3 position = transform.position;
		foreach (GameObject go in gos) {
			Vector3 diff = new Vector3();
				diff = go.transform.position - position;
			float curDistance = diff.sqrMagnitude;
			if (curDistance < distance) {
				closest = go;
				distance = curDistance;
			}
		}
		return closest;
	}
}
