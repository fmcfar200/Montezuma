using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player1ScoreScript : MonoBehaviour {

	public Text player1Text;
	public float player1Score;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		PlayerAttackScript playerAttackScript = this.gameObject.GetComponent<PlayerAttackScript> ();

		if (playerAttackScript.isDictator) 
		{
			player1Score += Time.deltaTime;
		}
		player1Text.text = "Player 1 Score: " + player1Score;

	}
}
