using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player2ScoreScript: MonoBehaviour {

	public Text player2Text;
	public float player2Score;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		PlayerAttackScript playerAttackScript = this.gameObject.GetComponent<PlayerAttackScript> ();

		if (playerAttackScript.isDictator) 
		{
			player2Score += Time.deltaTime;
		}
		player2Text.text = "Player 2 Score: " + player2Score;
	
	}
}
