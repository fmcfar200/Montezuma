using UnityEngine;
using System.Collections;

public class CharacterMarkerScript : MonoBehaviour {

	public GameObject marker;

	public Sprite red;
	public Sprite yellow;
	public Sprite green;
	public Sprite blue;

	// Use this for initialization
	void Start () {
		SpriteRenderer spriteRenderer = marker.GetComponent<SpriteRenderer> ();

		if (this.gameObject.name == "Player1") 
		{
			GameObject g = GameObject.Find("Player1Data");
			
			if(g != null)
			{
				
				DataScript d = g.GetComponent<DataScript>();
				
				if(d.playerSpriteNumber == 1)
				{
					spriteRenderer.sprite = blue;

					
				}
				else if(d.playerSpriteNumber == 2)
				{
					spriteRenderer.sprite = green;
				
					
				}
				else if(d.playerSpriteNumber == 3)
				{
					spriteRenderer.sprite = yellow;

				}
				else if(d.playerSpriteNumber == 4)
				{
					spriteRenderer.sprite = red;

				}
			}
		}
		if (this.gameObject.name == "Player2") 
		{
			GameObject g = GameObject.Find("Player2Data");
			
			if(g != null)
			{
				
				DataScript d = g.GetComponent<DataScript>();
				
				if(d.playerSpriteNumber == 1)
				{
					spriteRenderer.sprite = blue;
					
					
				}
				else if(d.playerSpriteNumber == 2)
				{
					spriteRenderer.sprite = green;
					
					
				}
				else if(d.playerSpriteNumber == 3)
				{
					spriteRenderer.sprite = yellow;
					
				}
				else if(d.playerSpriteNumber == 4)
				{
					spriteRenderer.sprite = red;
					
				}
			}
		}
		if (this.gameObject.name == "Player3") 
		{
			GameObject g = GameObject.Find("Player3Data");
			
			if(g != null)
			{
				
				DataScript d = g.GetComponent<DataScript>();
				
				if(d.playerSpriteNumber == 1)
				{
					spriteRenderer.sprite = blue;
					
					
				}
				else if(d.playerSpriteNumber == 2)
				{
					spriteRenderer.sprite = green;
					
					
				}
				else if(d.playerSpriteNumber == 3)
				{
					spriteRenderer.sprite = yellow;
					
				}
				else if(d.playerSpriteNumber == 4)
				{
					spriteRenderer.sprite = red;
					
				}
			}
		}
		if (this.gameObject.name == "Player4") 
		{
			GameObject g = GameObject.Find("Player4Data");
			
			if(g != null)
			{
				
				DataScript d = g.GetComponent<DataScript>();
				
				if(d.playerSpriteNumber == 1)
				{
					spriteRenderer.sprite = blue;
					
					
				}
				else if(d.playerSpriteNumber == 2)
				{
					spriteRenderer.sprite = green;
					
					
				}
				else if(d.playerSpriteNumber == 3)
				{
					spriteRenderer.sprite = yellow;
					
				}
				else if(d.playerSpriteNumber == 4)
				{
					spriteRenderer.sprite = red;
					
				}
			}
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
