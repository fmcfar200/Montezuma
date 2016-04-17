using UnityEngine;
using System.Collections;

public class ChangeSpriteScript : MonoBehaviour {

	public Sprite red;
	public Sprite blue;
	public Sprite green;
	public Sprite yellow;

	public Sprite Dred;
	public Sprite Dblue;
	public Sprite Dgreen;
	public Sprite Dyellow;

	
	public RuntimeAnimatorController redControl;
	public RuntimeAnimatorController greenControl;
	public RuntimeAnimatorController blueControl;
	public RuntimeAnimatorController yellowControl;

	private SpriteRenderer spriteRenderer;
	private Animator animator;

	// Use this for initialization
	void Start () {

		spriteRenderer = GetComponent<SpriteRenderer> ();
		animator = GetComponent<Animator> ();

		if (this.gameObject.name == "Player1") 
		{
			GameObject g = GameObject.Find("Player1Data");

			if(g != null)
			{

				DataScript d = g.GetComponent<DataScript>();

				if(d.playerSpriteNumber == 1)
				{
					spriteRenderer.sprite = blue;
					animator.runtimeAnimatorController = blueControl;

				}
				else if(d.playerSpriteNumber == 2)
				{
					spriteRenderer.sprite = green;
					animator.runtimeAnimatorController = greenControl;

				}
				else if(d.playerSpriteNumber == 3)
				{
					spriteRenderer.sprite = yellow;
					animator.runtimeAnimatorController = yellowControl;
				}
				else if(d.playerSpriteNumber == 4)
				{
					spriteRenderer.sprite = red;
					animator.runtimeAnimatorController = redControl;
				}
			}
		}

		else if (this.gameObject.name == "Player2") 
		{
			GameObject g = GameObject.Find("Player2Data");

			if(g != null)
			{
			DataScript d = g.GetComponent<DataScript>();

				if(d.playerSpriteNumber == 1)
				{
					spriteRenderer.sprite = blue;
					animator.runtimeAnimatorController = blueControl;
				}
				else if(d.playerSpriteNumber == 2)
				{
					spriteRenderer.sprite = green;
					animator.runtimeAnimatorController = greenControl;
				}
				else if(d.playerSpriteNumber == 3)
				{
					spriteRenderer.sprite = yellow;
					animator.runtimeAnimatorController = yellowControl;
				}
				else if(d.playerSpriteNumber == 4)
				{
					spriteRenderer.sprite = red;
					animator.runtimeAnimatorController = redControl;
				}
			}
		}

		else if (this.gameObject.name == "Player3") 
		{
			GameObject g = GameObject.Find("Player3Data");

			if(g != null)
			{
			DataScript d = g.GetComponent<DataScript>();

				if(d.playerSpriteNumber == 1)
				{
					spriteRenderer.sprite = blue;
					animator.runtimeAnimatorController = blueControl;
				}
				else if(d.playerSpriteNumber == 2)
				{
					spriteRenderer.sprite = green;
					animator.runtimeAnimatorController = greenControl;
				}
				else if(d.playerSpriteNumber == 3)
				{
					spriteRenderer.sprite = yellow;
					animator.runtimeAnimatorController = yellowControl;
				}
				else if(d.playerSpriteNumber == 4)
				{
					spriteRenderer.sprite = red;
					animator.runtimeAnimatorController = redControl;
				}
			}
		}

		else if (this.gameObject.name == "Player4") 
		{
			GameObject g = GameObject.Find("Player4Data");

			if(g != null)
			{
			DataScript d = g.GetComponent<DataScript>();
			
				if(d.playerSpriteNumber == 1)
				{
					spriteRenderer.sprite = blue;
					animator.runtimeAnimatorController = blueControl;
				}
				else if(d.playerSpriteNumber == 2)
				{
					spriteRenderer.sprite = green;
					animator.runtimeAnimatorController = greenControl;
				}
				else if(d.playerSpriteNumber == 3)
				{
					spriteRenderer.sprite = yellow;
					animator.runtimeAnimatorController = yellowControl;
				}
				else if(d.playerSpriteNumber == 4)
				{
					spriteRenderer.sprite = red;
					animator.runtimeAnimatorController = redControl;
				}
			}
		}


	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
