using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseGameScript : MonoBehaviour {

	private bool gamePaused = false;
	public GameObject pauseScreen;
	

	void Start()
	{
		pauseScreen.SetActive (true);
		gamePaused = true;
	}
	void Update () {

		if (Input.GetButtonDown ("Start")) 
		{
			if (!gamePaused)
			{
				gamePaused = true;
			}
			else
			{
				gamePaused = false;
			}
		}
		if (gamePaused) 
		{
			Pause();
		} 
		else 
		{
			Unpause();
		}

	}

	void Pause()
	{
		Time.timeScale = 0;
		pauseScreen.SetActive(true);
	}
	void Unpause()
	{
		Time.timeScale = 1;
		pauseScreen.SetActive(false);
	}
	void Quit()
	{
		Application.LoadLevel("MainMenu");
	}
}
