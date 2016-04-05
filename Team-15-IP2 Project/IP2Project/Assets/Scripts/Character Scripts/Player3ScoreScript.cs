using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player3ScoreScript: MonoBehaviour {

	public Text player3Text;
	public float player3Score;
	float timeStep;

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
				player3Score ++;
				timeStep = 1;
			}
		}
		player3Text.text = "Player 3 Score: " + player3Score;
	
	}
}
