using UnityEngine;
using System.Collections;

public class WinScript : MonoBehaviour {

	public int winningPlayer;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		DontDestroyOnLoad (this.gameObject);

		GameObject g = GameObject.Find ("GameManager");
		if (g != null) 
		{

			GameObject g1 = GameObject.Find ("Player1");
			GameObject g2 = GameObject.Find ("Player2");
			GameObject g3 = GameObject.Find ("Player3");
			GameObject g4 = GameObject.Find ("Player4");

			Player1ScoreScript p1 = g1.GetComponent<Player1ScoreScript> ();
			Player2ScoreScript p2 = g2.GetComponent<Player2ScoreScript> ();
			Player3ScoreScript p3 = g3.GetComponent<Player3ScoreScript> ();
			Player4ScoreScript p4 = g4.GetComponent<Player4ScoreScript> ();

			if (p1.player1Score > p2.player2Score && p1.player1Score > p2.player2Score && p1.player1Score > p4.player4Score) 
			{
				winningPlayer = 1;
			} 
			else if (p2.player2Score > p1.player1Score && p2.player2Score > p3.player3Score && p2.player2Score > p4.player4Score) 
			{
				winningPlayer = 2;
			} 
			else if (p3.player3Score > p1.player1Score && p3.player3Score > p2.player2Score && p3.player3Score > p4.player4Score) 
			{
				winningPlayer = 3;
			}
			else if(p4.player4Score > p1.player1Score && p4.player4Score > p2.player2Score && p4.player4Score > p3.player3Score)
			{
				winningPlayer = 4;
			}
			else
			{
				winningPlayer = 5;
			}
		}
	}
}
