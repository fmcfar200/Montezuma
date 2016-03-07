using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player4ScoreScript: MonoBehaviour {

	public Text player4Text;
	public float player4Score;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		PlayerAttackScript playerAttackScript = this.gameObject.GetComponent<PlayerAttackScript> ();

		if (playerAttackScript.isDictator) 
		{
			player4Score += Time.deltaTime;
		}
		player4Text.text = "Player 4 Score: " + player4Score;
	
	}
}
