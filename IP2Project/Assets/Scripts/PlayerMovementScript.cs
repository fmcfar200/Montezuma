using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour {

	Rigidbody2D playerRb;		//players rigid body
	float playerSpeed = 2.0f;	//speed of the player
	float moveHor;				//holds the float variable for player movement
	public float jumpForce;		//force of the basic jump
	public float dblJumpForce;	//force of the second jump

	private bool grounded = false;		//variable for when the player is grounded
	private bool Jump = false;			//variable for when the player is jumping
	private Transform groundCheck;		//holds transform object for checking if the player is on the ground
	private bool onLadder = false;
	//private bool climb = false;

	public string horizontalString = "Horizontal_P1";
	public string jumpString = "Jump_P1";
	public string verticalString = "Vertical_P1";

	// Use this for initialization
	void Start () {

		groundCheck = transform.Find("Ground_Check");
		playerRb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		//sets grounded to true ifthe line cast hits an object with layer name ground.
		grounded = Physics2D.Linecast(transform.position,groundCheck.position,
		                              1 << LayerMask.NameToLayer("Ground"));

		//logs if the player is on the ground
		if (grounded == true) 
		{
			Debug.Log(this.gameObject.name + ": On the ground");
		}
		//sets the jump variable to true if the jump button is pressed and the player is on the ground.
		if (Input.GetButtonDown (jumpString) && (grounded)) 
		{
			Jump = true;
		}
	}
	void FixedUpdate()
	{
		//Moving the players horizontally.
		moveHor = Input.GetAxis(horizontalString);

		if (moveHor < 0) {
			this.transform.localScale = new Vector3 (-1, 1, 1);

		} else {
			this.transform.localScale = new Vector3 (1, 1,1	);

		}
		playerRb.velocity = new Vector2 (moveHor * playerSpeed, playerRb.velocity.y);

		//jumping
		if (Jump) 
		{
			Debug.Log(this.gameObject.name +" Jumped");
			playerRb.AddForce(new Vector2(playerRb.velocity.x,jumpForce));
			Jump = false;
		}
		if (onLadder) {

			moveHor = 0;
			float moveVer = Input.GetAxis(verticalString);
			playerRb.velocity = new Vector2(playerRb.velocity.x,moveVer*playerSpeed);

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
		}
	}
}
