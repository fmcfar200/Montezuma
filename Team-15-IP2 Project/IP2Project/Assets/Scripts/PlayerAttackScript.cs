using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerAttackScript : MonoBehaviour {

	public BoxCollider2D attackTrigger;
	public string attackString = "Attack_P1";
	public string specialString = "Special_P1";
	public string powerString = "Power_P1";
	private bool attacking = false;

	private float attackTimer = 0;
	private float attackDelay = 0.5f;

	public bool isDictator = false;

	public GameObject fireballPrefab;
	public Transform fireballSpawn;
	private bool usingSpecial = false;
	private float specialTimer = 0;
	private float specialDelay = 0.5f;

	public Sprite dictatorSprite;
	public Sprite normalSprite;

	public bool powerReady = false;

	Animator animator;


	// Use this for initialization
	void Start () 
	{
		//initialisation

		animator = GetComponent<Animator> ();

		attackTrigger.enabled = false;

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


			if (Input.GetButtonDown (specialString) && !usingSpecial) 
			{
				usingSpecial = true;
				specialTimer = specialDelay;
				Instantiate(fireballPrefab,fireballSpawn.transform.position,Quaternion.identity);
			}

			if (usingSpecial)
			{
				if(specialTimer > 0)
				{
					specialTimer -= Time.deltaTime;
				}
				else
				{
					usingSpecial = false;
				}
			}
		} 
		else 
		{
			this.gameObject.GetComponent<SpriteRenderer>().sprite = normalSprite;
			animator.enabled = true;
		}

		if (powerReady) 
		{
			if (Input.GetButtonDown(powerString))
			{
				//do the power
			}
		}


	}

	void WindPower()
	{
		//power code// may be coroutine...
	}
	
	void OnTriggerStay2D(Collider2D coll)
	{

		if (coll.gameObject.tag == "Player") {
			StartCoroutine(coll.gameObject.GetComponent<PlayerHealthScript>().WaitAndRespawnPlayer());

		}
	}
}
