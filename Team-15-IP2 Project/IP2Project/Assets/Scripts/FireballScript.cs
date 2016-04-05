using UnityEngine;
using System.Collections;

public class FireballScript : MonoBehaviour {

	private float speed	= -5.0f;
	private Rigidbody2D spearRb;
	private float destroyDelay = 3.0f;
	private float destroyTimer;

	// Use this for initialization
	void Start () {
		spearRb = GetComponent<Rigidbody2D> ();
		destroyTimer = destroyDelay;

	}


	
	void FixedUpdate()
	{
		spearRb.velocity = new Vector2(0,speed);

		if (destroyTimer > 0) {
			destroyTimer -= Time.deltaTime;
		} else {
			Destroy(this.gameObject);
		}

	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "OOB") {

			Destroy(this.gameObject);
		}
		
	}


}
