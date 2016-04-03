using UnityEngine;
using System.Collections;

public class PlayerMenuScript : MonoBehaviour {

	public bool isStartButtonActive = false;
	public bool isQuitButtonActive = false;



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
		}


		if (other.gameObject.tag == "QuitGame") 
		{
			isQuitButtonActive = true;
		}

	}

    void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.tag == "StartGame") 
		{
			isStartButtonActive = false;
		}
		if (other.gameObject.tag == "QuitGame") 
		{
			isQuitButtonActive = false;
		}
	}
}
