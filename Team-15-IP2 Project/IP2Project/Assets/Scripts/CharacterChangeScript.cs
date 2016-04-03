using UnityEngine;
using System.Collections;

public class CharacterChangeScript : MonoBehaviour {

	public Sprite red;
	public Sprite blue;
	public Sprite green;
	public Sprite yellow;

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

	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.C)) {
			ChangeSprite();
		}
	
	}

	public void ChangeSprite()
	{

	
		if (spriteRenderer.sprite == red || animator.runtimeAnimatorController == redControl) 
		{
			spriteRenderer.sprite = blue;
			animator.runtimeAnimatorController = blueControl;
			Debug.Log("Changed to blue sprite");
		} 
		else if (spriteRenderer.sprite == blue || animator.runtimeAnimatorController == blueControl) 
		{
			spriteRenderer.sprite = green;
			animator.runtimeAnimatorController = greenControl;
			Debug.Log("Changed to green sprite");
		} 
		else if (spriteRenderer.sprite == green || animator.runtimeAnimatorController == greenControl) 
		{
			spriteRenderer.sprite = yellow;
			animator.runtimeAnimatorController = yellowControl;
			Debug.Log("Changed to yellow sprite");
		} 
		else if(spriteRenderer.sprite == yellow || animator.runtimeAnimatorController == yellowControl) 
		{
			spriteRenderer.sprite = red;
			animator.runtimeAnimatorController = redControl;
			Debug.Log("Changed to red sprite");
		}
	}
}
