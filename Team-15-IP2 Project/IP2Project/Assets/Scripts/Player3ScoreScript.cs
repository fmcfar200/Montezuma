using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player3ScoreScript: MonoBehaviour {

	public Text player3Text;
	public float player3Score;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		PlayerAttackScript playerAttackScript = this.gameObject.GetComponent<PlayerAttackScript> ();

		if (playerAttackScript.isDictator) 
		{
			player3Score += Time.deltaTime;
		}
		player3Text.text = "Player 3 Score: " + player3Score;
	
	}
}
