using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player2ScoreScript: MonoBehaviour {

	public Text player2Text;
	public float player2Score;
	float timeStep = 1.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		PlayerAttackScript playerAttackScript = this.gameObject.GetComponent<PlayerAttackScript> ();

		if (playerAttackScript.isDictator) 
		{
			timeStep -= Time.deltaTime;
			if (timeStep <= 0) 
			{
				player2Score ++;
				timeStep = 1;
			}
		}
		player2Text.text = "Player 2 Score: " + player2Score;
	
	}
}
