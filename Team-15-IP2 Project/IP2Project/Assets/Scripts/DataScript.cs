using UnityEngine;
using System.Collections;

public class DataScript : MonoBehaviour {

	public int playerSpriteNumber;

	// Use this for initialization
	void Start () {

		if(this.gameObject.name == "Player1Data")
		{
			playerSpriteNumber = 3;
		}
		if(this.gameObject.name == "Player2Data")
		{
			playerSpriteNumber = 4;
		}
		if(this.gameObject.name == "Player3Data")
		{
			playerSpriteNumber = 1;
		}
		if(this.gameObject.name == "Player4Data")
		{
			playerSpriteNumber = 2;
		}
	
	}
	
	// Update is called once per frame
	void Update () {

		DontDestroyOnLoad (this);
	
	}
}
