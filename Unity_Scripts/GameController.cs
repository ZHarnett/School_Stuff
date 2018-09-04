using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
	public GUIText restartText;
	public GUIText gameOverText;
	
	private bool gameOver;
	private bool restart;

	
	void Start ()
	{
		gameOver = false;
		restart = false;
		restartText.text = "";
		gameOverText.text = "";
	}
	
	void Update ()
	{
		if (restart)
		{
			if (Input.GetKeyDown (KeyCode.R))
			{
				Application.LoadLevel (Application.loadedLevel);
			}
		}
	}

	public void GameOver ()
	{
		gameOverText.text = "Game Over!";
		gameOver = true;
	}
}