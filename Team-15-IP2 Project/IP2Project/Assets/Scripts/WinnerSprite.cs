using UnityEngine;
using System.Collections;

public class WinnerSprite : MonoBehaviour {

	public Sprite yellow;
	public Sprite red;
	public Sprite blue;
	public Sprite green;

	private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {

		spriteRenderer = GetComponent<SpriteRenderer> ();
	
	}
	
	// Update is called once per frame
	void Update () {

		GameObject g = GameObject.Find ("ScoreObject");
		if (g != null) 
		{
			WinScript win = g.GetComponent<WinScript> ();
			
			if (win.winningPlayer == 1)
			{
				spriteRenderer.sprite = yellow;
			}
			else if(win.winningPlayer == 2)
			{
				spriteRenderer.sprite = red;
			}
			else if(win.winningPlayer == 3)
			{
				spriteRenderer.sprite = green;
			}
			else if(win.winningPlayer == 4)
			{
				spriteRenderer.sprite = blue;
			}

		}
	
	}
}
