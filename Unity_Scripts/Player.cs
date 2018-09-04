using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float movementSpeed = 10;
	public float turningSpeed = 60;
	public GameObject explosion;

	private GameController gameController;
	
	void Start ()
	{
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null)
		{
			gameController = gameControllerObject.GetComponent <GameController>();
		}
		if (gameController == null)
		{
			Debug.Log ("Cannot find 'GameController' script");
		}
	}

	void Update() {
		float horizontal = Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime;
		transform.Rotate(0, horizontal, 0);
		
		float vertical = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
		transform.Translate(0, 0, vertical);
	}

	void OnTriggerEnter(Collider other) 
	{	
		if (other.gameObject.CompareTag ("PacMan"))
		{	
			Instantiate(explosion, transform.position, transform.rotation);
			Destroy (other.gameObject);
			gameController.GameOver ();
		}
	}
}