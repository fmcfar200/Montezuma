using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerMenuScript : MonoBehaviour {

	public bool isStartButtonActive = false;
	public bool isQuitButtonActive = false;

	public Button startButton;
	public Button quitButton;

	public Sprite startButtonActive;
	public Sprite quitButtonActive;

	public Sprite startButtonInactive;
	public Sprite quitButtonInactive;

	public string buttonString = "Submit";

	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown (buttonString) && (isStartButtonActive)) 
		{
			Application.LoadLevel("LevelSelectScene");
		}

		if (Input.GetButtonDown (buttonString) && (isQuitButtonActive)) 
		{
			Application.Quit();
		}
	

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "StartGame") 
		{
			isStartButtonActive = true;
			startButton.image.sprite = startButtonActive;
		}


		if (other.gameObject.tag == "QuitGame") 
		{
			isQuitButtonActive = true;
			quitButton.image.sprite = quitButtonActive;
		}

	}

    void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.tag == "StartGame") 
		{
			isStartButtonActive = false;
			startButton.image.sprite = startButtonInactive;
		}
		if (other.gameObject.tag == "QuitGame") 
		{
			isQuitButtonActive = false;
			quitButton.image.sprite = quitButtonInactive;
		}
	}
}
