using UnityEngine;
using System.Collections;

public class CharacterChangeScript : MonoBehaviour {

	public Sprite red;
	public Sprite blue;
	public Sprite green;
	public Sprite yellow;


	//public GameObject DataObject;

	private SpriteRenderer spriteRenderer;
	private Animator animator;

	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer> ();



	
	}
	
	// Update is called once per frame
	void Update () {

		/*if (Input.GetKeyDown (KeyCode.C)) {
			ChangeSprite();
		}*/
	
	}

	public void ChangeSprite()
	{

		//DataScript data = DataObject.GetComponent<DataScript> ();


		if (this.gameObject.name == "Player1") 
		{
			GameObject g = GameObject.Find ("Player1Data");
			DataScript data = g.GetComponent<DataScript>();

			if (spriteRenderer.sprite == red ) 
			{
				data.playerSpriteNumber = 1;
				spriteRenderer.sprite = blue;
				Debug.Log("Changed to blue sprite");
			} 
			else if (spriteRenderer.sprite == blue ) 
			{
				data.playerSpriteNumber = 2;
				spriteRenderer.sprite = green;
				Debug.Log("Changed to green sprite");
			} 
			else if (spriteRenderer.sprite == green ) 
			{
				data.playerSpriteNumber = 3;
				spriteRenderer.sprite = yellow;
				Debug.Log("Changed to yellow sprite");
			} 
			else if(spriteRenderer.sprite == yellow ) 
			{
				data.playerSpriteNumber = 4;
				spriteRenderer.sprite = red;
				Debug.Log("Changed to red sprite");
			}
		}

		if (this.gameObject.name == "Player2") 
		{
			GameObject g = GameObject.Find ("Player2Data");
			DataScript data = g.GetComponent<DataScript>();
			
			if (spriteRenderer.sprite == red ) 
			{
				data.playerSpriteNumber = 1;
				spriteRenderer.sprite = blue;
				Debug.Log("Changed to blue sprite");
			} 
			else if (spriteRenderer.sprite == blue ) 
			{
				data.playerSpriteNumber = 2;
				spriteRenderer.sprite = green;
				Debug.Log("Changed to green sprite");
			} 
			else if (spriteRenderer.sprite == green ) 
			{
				data.playerSpriteNumber = 3;
				spriteRenderer.sprite = yellow;
				Debug.Log("Changed to yellow sprite");
			} 
			else if(spriteRenderer.sprite == yellow ) 
			{
				data.playerSpriteNumber = 4;
				spriteRenderer.sprite = red;
				Debug.Log("Changed to red sprite");
			}
		}

		if (this.gameObject.name == "Player3") 
		{
			GameObject g = GameObject.Find ("Player3Data");
			DataScript data = g.GetComponent<DataScript>();
			
			if (spriteRenderer.sprite == red ) 
			{
				data.playerSpriteNumber = 1;
				spriteRenderer.sprite = blue;
				Debug.Log("Changed to blue sprite");
			} 
			else if (spriteRenderer.sprite == blue ) 
			{
				data.playerSpriteNumber = 2;
				spriteRenderer.sprite = green;
				Debug.Log("Changed to green sprite");
			} 
			else if (spriteRenderer.sprite == green ) 
			{
				data.playerSpriteNumber = 3;
				spriteRenderer.sprite = yellow;
				Debug.Log("Changed to yellow sprite");
			} 
			else if(spriteRenderer.sprite == yellow ) 
			{
				data.playerSpriteNumber = 4;
				spriteRenderer.sprite = red;
				Debug.Log("Changed to red sprite");
			}
		}

		if (this.gameObject.name == "Player4") 
		{
			GameObject g = GameObject.Find ("Player4Data");
			DataScript data = g.GetComponent<DataScript>();
			
			if (spriteRenderer.sprite == red ) 
			{
				data.playerSpriteNumber = 1;
				spriteRenderer.sprite = blue;
				Debug.Log("Changed to blue sprite");
			} 
			else if (spriteRenderer.sprite == blue ) 
			{
				data.playerSpriteNumber = 2;
				spriteRenderer.sprite = green;
				Debug.Log("Changed to green sprite");
			} 
			else if (spriteRenderer.sprite == green ) 
			{
				data.playerSpriteNumber = 3;
				spriteRenderer.sprite = yellow;
				Debug.Log("Changed to yellow sprite");
			} 
			else if(spriteRenderer.sprite == yellow ) 
			{
				data.playerSpriteNumber = 4;
				spriteRenderer.sprite = red;
				Debug.Log("Changed to red sprite");
			}
		}
	}
}
