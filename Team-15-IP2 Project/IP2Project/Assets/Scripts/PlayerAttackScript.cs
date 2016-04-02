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

	public bool windPowerReady = false;
	public bool freezePowerReady = false;
	public bool shieldPowerReady = false;
	public bool speedPowerReady = false;
	public GameObject freezeObj;
	public GameObject runObj;
	public GameObject shieldObj;

	public Transform powerSpawn;

	Animator animator;

	public AudioClip pickUpSound;



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
				yield return new WaitForSeconds (5.0f);
				hitMovement.enabled = true;
				hitAttack.freezeObj.SetActive(false);
			}
		} else {
			Debug.Log("NO HIT");
		}
	}

	IEnumerator SpeedBoost()
	{
		PlayerMovementScript playerMovement = this.gameObject.GetComponent<PlayerMovementScript> ();
		runObj.SetActive (true);
		playerMovement.playerSpeed = playerMovement.speedBoostSpeed;
		yield return new WaitForSeconds (5.0f);
		runObj.SetActive (false);
		playerMovement.playerSpeed = playerMovement.normalPlayerSpeed;

	}

	IEnumerator ShieldPower()
	{
		PlayerHealthScript playerHealth = this.gameObject.GetComponent<PlayerHealthScript> ();
		shieldObj.SetActive (true);
		playerHealth.enabled = false;
		yield return new WaitForSeconds (5.0f);
		shieldObj.SetActive (false);
		playerHealth.enabled = true;
	}

	
	void OnTriggerStay2D(Collider2D coll)
	{

		if (coll.gameObject.tag == "Player") {
			StartCoroutine(coll.gameObject.GetComponent<PlayerHealthScript>().WaitAndRespawnPlayer());

		}
	}
}
