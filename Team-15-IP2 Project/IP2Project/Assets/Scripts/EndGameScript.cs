using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndGameScript : MonoBehaviour {

	public Text winnerText;
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		GameObject g = GameObject.Find ("ScoreObject");
		if (g != null) 
		{
			WinScript win = g.GetComponent<WinScript> ();

			if (win.winningPlayer == 1)
			{
				winnerText.text = "Player 1 Wins!";
			}
			else if(win.winningPlayer == 2)
			{
				winnerText.text = "Player 2 Wins!";
			}
			else if(win.winningPlayer == 3)
			{
				winnerText.text = "Player 3 Wins!";
			}
			else if(win.winningPlayer == 4)
			{
				winnerText.text = "Player 4 Wins!";
			}
			else if(win.winningPlayer == 5)
			{
				winnerText.text = "What!? How did you manage to get this response? Did you all literally just sit there leaving the score at zero? Don't you have better things to do?";
			}
		}
	
		//if (Input.GetButtonDown ("Jump_P1") || Input.GetButtonDown ("Jump_P2")||Input.GetButtonDown ("Jump_P3")||Input.GetButtonDown ("Jump_P4")) {
		//	LoadMainLevel();
		//}
	}

	public void LoadMainLevel()
	{
		Application.LoadLevel ("LevelSelectScene");
	}
	
	public void QuitGame()
	{
		Application.Quit ();
	}

	public void LoadMainMenu()
	{
		Application.LoadLevel ("MainMenu");
	}
}
