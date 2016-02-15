using UnityEngine;
using System.Collections;

public class FireballScript : MonoBehaviour {

	private float speed	= -5.0f;
	private Rigidbody2D fireballRb;


	// Use this for initialization
	void Start () {
		fireballRb = GetComponent<Rigidbody2D> ();


	}


	
	void FixedUpdate()
	{
		fireballRb.velocity = new Vector2(0,speed);

	}
}
