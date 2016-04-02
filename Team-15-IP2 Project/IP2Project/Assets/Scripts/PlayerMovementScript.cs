using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour {

	Rigidbody2D playerRb;		//players rigid body
	public float playerSpeed;	//speed of the player
	public float normalPlayerSpeed = 2.0f;
	public float speedBoostSpeed = 4.0f;
	float moveHor;				//holds the float variable for player movement
	public float jumpForce;		//force of the basic jump
	public float dblJumpForce;	//force of the second jump

	private bool grounded = false;		//variable for when the player is grounded
	public bool onTopPlat = false;
	private bool Jump = false;			//variable for when the player is jumping
	private Transform groundCheck;		//holds transform object for checking if the player is on the ground
	private bool onLadder = false;
	//private bool climb = false;

	public string horizontalString = "Horizontal_P1";
	public string jumpString = "Jump_P1";
	public string verticalString = "Vertical_P1";

	private Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		playerRb = GetComponent<Rigidbody2D> ();

		groundCheck = transform.Find("Ground_Check");
		if (groundCheck == null) {
			Debug.LogError("GROUND CHECK NOT FOUND");
		}

		playerSpeed = normalPlayerSpeed;
		animator.SetBool("Climbing", false);


	}
	
	// Update is called once per frame
	void Update () 
	{
		//logs if the player is on the ground
		if (grounded == true) 
		{
			//Debug.Log(this.gameObject.name + ": On the ground");
		}

		//sets the jump variable to true if the jump button is pressed and the player is on the ground.
		if (Input.GetButtonDown (jumpString) && (grounded)) 
		{
			Jump = true;
		}

		if (transform.position.x > 1.0f || transform.position.x < -50.0f || transform.position.y > 0.0f
			|| transform.position.y < -20.0f) {
			PlayerHealthScript playerHealth = this.gameObject.GetComponent<PlayerHealthScript>();
			StartCoroutine(playerHealth.WaitAndRespawnPlayer());
		}
	}
	void FixedUpdate()
	{
		//sets grounded to true ifthe line cast hits an object with layer name ground.
		grounded = Physics2D.Linecast(transform.position,groundCheck.position,
		                              1 << LayerMask.NameToLayer("Ground"));
		onTopPlat = Physics2D.Linecast(transform.position,groundCheck.position,
		                              1 << LayerMask.NameToLayer("Top Platform"));

		//Moving the players horizontally.
		moveHor = Input.GetAxis(horizontalString);

		if (moveHor < 0) {
			this.transform.localScale = new Vector3 (-1, 1, 1);
			animator.SetBool("Moving", true	);

		} else if (moveHor == 0) {
			animator.SetBool("Moving",false);
		}

		else {
			this.transform.localScale = new Vector3 (1, 1,1);
			animator.SetBool("Moving", true	);

		}
		playerRb.velocity = new Vector2 (moveHor * playerSpeed, playerRb.velocity.y);

		//jumping
		if (Jump== true) 
		{
			//Debug.Log(this.gameObject.name +" Jumped");
			playerRb.AddForce(new Vector2(playerRb.velocity.x,jumpForce));
			Jump = false;
		}
		if (onLadder == true) {

			moveHor = 0;
			float moveVer = Input.GetAxis(verticalString);
			playerRb.velocity = new Vector2(playerRb.velocity.x,moveVer*playerSpeed);
			if (moveVer == 1 || moveVer == -1)
			{
				animator.SetBool("Climbing",true);
			}
			else
			{
				animator.SetBool("Climbing", false);
			}

		}
	}

	void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.gameObject.tag == "Ladder") {
			onLadder = true;
		}
	}
	void OnTriggerExit2D(Collider2D coll)
	{
		if (coll.gameObject.tag == "Ladder") {
			onLadder = false;
			animator.SetBool("Climbing", false);

		}
	}
}
