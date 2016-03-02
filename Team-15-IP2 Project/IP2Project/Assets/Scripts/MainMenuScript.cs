using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenuScript : MonoBehaviour {
	

	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetButtonDown ("Jump_P1") || Input.GetButtonDown ("Jump_P2")||Input.GetButtonDown ("Jump_P3")||Input.GetButtonDown ("Jump_P4")) {
			LoadMainLevel();
		}
	}

	public void LoadMainLevel()
	{
		Application.LoadLevel ("Scene");
	}

	public void QuitGame()
	{
		Application.Quit ();
	}

}
