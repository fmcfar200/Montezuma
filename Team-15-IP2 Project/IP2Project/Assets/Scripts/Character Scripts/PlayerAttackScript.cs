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

	public GameObject spearPrefab;
	public Transform spearSpawn;
	private bool usingSpecial = false;
	private float specialTimer = 0;
	private float specialDelay = 0.5f;

	public Sprite dictatorSprite;
	public Sprite normalSprite;

	public bool windPowerReady = false;
	public bool freezePowerReady = false;
	public bool shieldPowerReady = false;
	public bool speedPowerReady = false;
	public GameObject freezeObj;
	public GameObject runObj;
	public GameObject shieldObj;

	public Transform powerSpawn;

	private Animator animator;
	public AnimatorOverrideController normalCont;

	AudioSource audioSource;
	public AudioClip pickUpSound;
	public AudioClip attackSound;
	public AudioClip fireballSound;
	public AudioClip iceHitSound;
	public AudioClip iceBreakSound;
	public AudioClip windSound;
	public AudioClip shieldSound;
	public AudioClip speedSound;

	public Sprite yellow;
	public Sprite red;
	public Sprite blue;
	public Sprite green;

	public RuntimeAnimatorController redControl;
	public RuntimeAnimatorController greenControl;
	public RuntimeAnimatorController blueControl;
	public RuntimeAnimatorController yellowControl;

	private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () 
	{
		//initialisation
		spriteRenderer = GetComponent<SpriteRenderer> ();
		animator = GetComponent<Animator> ();
		//animator.runtimeAnimatorController = normalCont;
		animator.SetBool ("Moving", false);
		animator.SetBool("Climbing", false);
		animator.SetBool("Dictator", false);
		audioSource = GetComponent<AudioSource> ();
		attackTrigger.enabled = false;

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (animator.GetBool("Dictator") == true && animator.GetBool("Moving") == false)
		{
			spriteRenderer.sprite = dictatorSprite;
		}
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

			animator.SetBool("Dictator", true);
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = dictatorSprite;


			if (Input.GetButtonDown (specialString) && !usingSpecial) 
			{
				usingSpecial = true;
				specialTimer = specialDelay;
				Instantiate(spearPrefab,spearSpawn.transform.position,Quaternion.identity);
				PlayFireballSound();
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
			animator.SetBool("Dictator", false);
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

		if (windPowerReady) {
			if (Input.GetButtonDown (powerString)) {
				//do the power
				windPowerReady = false;
				StartCoroutine (WindPower ());
			}
		} else if (freezePowerReady) {
			if (Input.GetButtonDown (powerString)) {
				//do the power
				freezePowerReady = false;
				StartCoroutine (FreezePower ());
			}
		} else if (speedPowerReady) {
			if (Input.GetButtonDown (powerString)) {
				//do the power
				speedPowerReady = false;
				StartCoroutine (SpeedBoost ());
			}
		} else if (shieldPowerReady) {
			if (Input.GetButtonDown (powerString)) {
				//do the power
				shieldPowerReady = false;
				StartCoroutine (ShieldPower());
			}
		}

	}

	IEnumerator WindPower()
	{
		Debug.Log("Power used");
		audioSource.PlayOneShot (windSound);
		RaycastHit2D hit = Physics2D.Raycast (powerSpawn.transform.position ,(this.transform.localScale.x)*Vector2.right);
		if (hit.collider != null) {
			Debug.Log("Hit "+hit.collider.gameObject.name.ToString());
			if (hit.collider.gameObject.tag == "Player" && hit.collider.gameObject.name != this.gameObject.name) 
			{
				Rigidbody2D hitRb2D = hit.collider.gameObject.GetComponent<Rigidbody2D> ();
				PlayerMovementScript hitMovement = hit.collider.gameObject.GetComponent<PlayerMovementScript>();
				hitMovement.enabled = false;
				hitRb2D.isKinematic = true;
				hitRb2D.velocity = new Vector2((this.transform.localScale.x)*25f,0);
				yield return new WaitForSeconds (2.0f);
				hitMovement.enabled = true;
				hitRb2D.isKinematic = false;

				hitRb2D.velocity = new Vector2(0,0);
			}
		} else {
			Debug.Log("NO HIT");
		}

	}
	IEnumerator FreezePower()
	{
		RaycastHit2D hit = Physics2D.Raycast (powerSpawn.transform.position ,(this.transform.localScale.x)*Vector2.right);
		if (hit.collider != null) {
			Debug.Log("Hit "+hit.collider.gameObject.name.ToString());
			if (hit.collider.gameObject.tag == "Player" && hit.collider.gameObject.name != this.gameObject.name) 
			{
				Rigidbody2D hitRb2D = hit.collider.gameObject.GetComponent<Rigidbody2D> ();
				PlayerMovementScript hitMovement = hit.collider.gameObject.GetComponent<PlayerMovementScript>();
				PlayerAttackScript hitAttack = hit.collider.gameObject.GetComponent<PlayerAttackScript>();
				hitAttack.freezeObj.SetActive(true);
				hitRb2D.velocity = new Vector2(0,0);
				hitMovement.enabled = false;
				audioSource.PlayOneShot(iceHitSound);
				yield return new WaitForSeconds (5.0f);
				hitMovement.enabled = true;
				hitAttack.freezeObj.SetActive(false);
				audioSource.PlayOneShot(iceBreakSound);
			}
		} else {
			Debug.Log("NO HIT");
		}
	}

	IEnumerator SpeedBoost()
	{
		audioSource.PlayOneShot (speedSound);
		PlayerMovementScript playerMovement = this.gameObject.GetComponent<PlayerMovementScript> ();
		runObj.SetActive (true);
		playerMovement.playerSpeed = playerMovement.speedBoostSpeed;
		yield return new WaitForSeconds (5.0f);
		runObj.SetActive (false);
		playerMovement.playerSpeed = playerMovement.normalPlayerSpeed;

	}

	IEnumerator ShieldPower()
	{
		audioSource.PlayOneShot (shieldSound);
		PlayerHealthScript playerHealth = this.gameObject.GetComponent<PlayerHealthScript> ();
		shieldObj.SetActive (true);
		playerHealth.enabled = false;
		yield return new WaitForSeconds (5.0f);
		shieldObj.SetActive (false);
		playerHealth.enabled = true;
	}

	void PlayAttackSound()
	{
		audioSource.PlayOneShot (attackSound);
	}
	void PlayFireballSound()
	{
		audioSource.PlayOneShot (fireballSound);
	}

	
	void OnTriggerStay2D(Collider2D coll)
	{

		if (coll.gameObject.tag == "Player") {
			PlayAttackSound();
			StartCoroutine(coll.gameObject.GetComponent<PlayerHealthScript>().WaitAndRespawnPlayer());

		}
	}
}
