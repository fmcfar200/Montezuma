﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeLeftScript : MonoBehaviour {
	
	public Text timeLeftText;
	public float timeLeft;



	// Use this for initialization
	void Start () {



	}
	
	// Update is called once per frame
	void Update () {

		
		//Timer ticks down as time goes on, at 0, it moves to the end screen.
		//Will have to change this method of ending it at a later date, but this'll do for now.
		timeLeft -= Time.deltaTime;
		
		timeLeftText.text = "Time Left : " + timeLeft;
		
		if (timeLeft <= 0) {

			
			Application.LoadLevel ("EndScene");
		}


}
}
