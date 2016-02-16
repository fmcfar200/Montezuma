using UnityEngine;
using System.Collections;

public class PlayerAttackScript : MonoBehaviour {

	public BoxCollider2D attackTrigger;
	public string attackString = "Attack_P1";
	public string specialString = "Special_P1";
	private bool attacking = false;

	private float attackTimer = 0;
	private float attackDelay = 0.5f;

	private bool isDictator = false;
	public GameObject fireballPrefab;
	public Transform fireballSpawn;

	public Sprite dictatorSprite;
	public Sprite normalSprite;

	PlayerMovementScript playerMovement;


	// Use this for initialization
	void Start () 
	{
		attackTrigger.enabled = false;
		playerMovement = GetComponent<PlayerMovementScript> ();

	}
	
	// Update is called once per frame
	void Update () 
	{
		//code for melee attack
		if (Input.GetButtonDown (attackString) && !attacking) 
		{
			attacking = true;
			attackTimer = attackDelay;
			attackTrigger.enabled = true;
		}

		if (attacking) 
		{
			if (attackTimer > 0)
			{
				attackTimer -= Time.deltaTime;
			}
			else
			{
				attacking = false;
				attackTrigger.enabled = false;
			}
		}
		//code for special attack on top platform
		if (playerMovement.onTopPlat == true) {
			isDictator = true;
		} else {
			isDictator = false;
		}

		if (isDictator) {
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = dictatorSprite;
			this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1,1,1,1);

			if (Input.GetButtonDown (specialString)) {
				Instantiate (fireballPrefab, fireballSpawn.transform.position, Quaternion.identity);
			}
		} else {
			this.gameObject.GetComponent<SpriteRenderer>().sprite = normalSprite;
			if (this.gameObject.name == "Player1")
			{
				this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1,1,0,1);

			}
			else if (this.gameObject.name == "Player2")
			{
				this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1,0,0,1);

			}
			else if (this.gameObject.name == "Player3")
			{
				this.gameObject.GetComponent<SpriteRenderer>().color = new Color(0,1,0,1);

			}
			else
			{
				this.gameObject.GetComponent<SpriteRenderer>().color = new Color(0,0,1,1);

			}
		}

	}
	
	void OnTriggerStay2D(Collider2D coll)
	{

		if (coll.gameObject.tag == "Player") {
			StartCoroutine(coll.gameObject.GetComponent<PlayerHealthScript>().WaitAndRespawnPlayer());

		}
	}
}
