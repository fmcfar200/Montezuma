using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerAttackScript : MonoBehaviour {

	public BoxCollider2D attackTrigger;
	public string attackString = "Attack_P1";
	public string specialString = "Special_P1";
	private bool attacking = false;

	private float attackTimer = 0;
	private float attackDelay = 0.5f;

	public bool isDictator = false;

	public GameObject fireballPrefab;
	public Transform fireballSpawn;

	public Sprite dictatorSprite;
	public Sprite normalSprite;

	public Text playerScoreText;
	int playerNumber = 0;
	float playerScore = 0;


	Animator animator;


	// Use this for initialization
	void Start () 
	{
		//initialisation

		animator = GetComponent<Animator> ();

		attackTrigger.enabled = false;
	
		if (this.gameObject.name == "Player1") {
			playerNumber = 1;
		} else if (this.gameObject.name == "Player2") {
			playerNumber = 2;
		} else if (this.gameObject.name == "Player3") {
			playerNumber = 3;
		} else if (this.gameObject.name == "Player4") {
			playerNumber = 4;
		}

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

		// isDictator is set when the top platform script detects one person colliding with it.
		if (isDictator) {

			//TEMP START
			animator.enabled = false;
			//TEMP END
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = dictatorSprite;
			this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1,1,1,1);

			playerScore += Time.deltaTime;


			if (Input.GetButtonDown (specialString)) {
				Instantiate (fireballPrefab, fireballSpawn.transform.position, Quaternion.identity);
			}
		} else {
			this.gameObject.GetComponent<SpriteRenderer>().sprite = normalSprite;
			animator.enabled = true;
			if (this.gameObject.name == "Player3")
			{
				this.gameObject.GetComponent<SpriteRenderer>().color = new Color(0,1,0,1);

			}
			else if (this.gameObject.name == "Player4")
			{
				this.gameObject.GetComponent<SpriteRenderer>().color = new Color(0,0,1,1);

			}
		}


		//sets the score text.
		playerScoreText.text = "Player " + playerNumber + " Score : " + playerScore;

	}
	
	void OnTriggerStay2D(Collider2D coll)
	{

		if (coll.gameObject.tag == "Player") {
			StartCoroutine(coll.gameObject.GetComponent<PlayerHealthScript>().WaitAndRespawnPlayer());

		}
	}
}
