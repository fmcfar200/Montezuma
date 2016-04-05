using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeLeftScript : MonoBehaviour {
	
	public Text timeLeftText;
	public float timeLeft;
	float timeStep = 1.0f;




	// Use this for initialization
	void Start () {

		GameObject scoreObject = GameObject.Find ("ScoreObject");
		if (scoreObject == null) 
		{
			scoreObject = new GameObject("ScoreObject");
			scoreObject.AddComponent<WinScript>();
		}

	}
	
	// Update is called once per frame
	void Update () {

		
		//Timer ticks down as time goes on, at 0, it moves to the end screen.
		//Will have to change this method of ending it at a later date, but this'll do for now.
		//timeLeft -= Time.deltaTime;
		
		timeLeftText.text = "Time Left : " + timeLeft;
		timeStep -= Time.deltaTime;
		if (timeStep <= 0) 
		{
			timeLeft --;
			timeStep = 1;
			if (timeLeft <= 0) 
			{
				Application.LoadLevel ("EndScene");
			}
		}
	}
}
