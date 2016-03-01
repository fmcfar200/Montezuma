using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenuScript : MonoBehaviour {
	

	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {
	
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
