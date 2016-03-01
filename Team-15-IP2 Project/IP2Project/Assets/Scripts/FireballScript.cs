using UnityEngine;
using System.Collections;

public class FireballScript : MonoBehaviour {

	private float speed	= -5.0f;
	private Rigidbody2D fireballRb;
	private float destroyDelay = 3.0f;
	private float destroyTimer;

	// Use this for initialization
	void Start () {
		fireballRb = GetComponent<Rigidbody2D> ();
		destroyTimer = destroyDelay;

	}


	
	void FixedUpdate()
	{
		fireballRb.velocity = new Vector2(0,speed);

		if (destroyTimer > 0) {
			destroyTimer -= Time.deltaTime;
		} else {
			Destroy(this.gameObject);
		}

	}


}
