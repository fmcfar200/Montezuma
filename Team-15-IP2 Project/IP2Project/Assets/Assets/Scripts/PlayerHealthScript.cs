using UnityEngine;
using System.Collections;

public class PlayerHealthScript : MonoBehaviour {

	public Transform playerSpawn;
	private float tempAlphaVal = 0.5f;
	private float normAlphaVal = 1.0f;

	public float respawnTimer = 5.0f;

	GameObject player;
	GameObject topPlatform;
	// Use this for initialization
	void Start () {
		player = this.gameObject;
		topPlatform = GameObject.Find("King_Platform");
		if (topPlatform == null) {
			Debug.LogError("NO TOP PLATFORM FOUND!!");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public IEnumerator WaitAndRespawnPlayer()
	{
		this.transform.position = playerSpawn.position;
		player.GetComponent<PlayerMovementScript> ().enabled = false;
		player.GetComponent<PlayerAttackScript> ().enabled = false;
		player.GetComponent<BoxCollider2D> ().enabled = false;
		player.GetComponent<Rigidbody2D> ().isKinematic = true;
		player.GetComponent<SpriteRenderer> ().color = new Color(1.0f,1.0f,1.0f,tempAlphaVal);
		topPlatform.GetComponent<TopPlatformScript> ().numOnTop -= 1;
		player.GetComponent<PlayerAttackScript> ().isDictator = false;

		yield return new WaitForSeconds (respawnTimer);
		player.GetComponent<PlayerMovementScript> ().enabled = true;
		player.GetComponent<PlayerAttackScript> ().enabled = true;
		player.GetComponent<BoxCollider2D> ().enabled = true;
		player.GetComponent<Rigidbody2D> ().isKinematic = false;
		player.GetComponent<SpriteRenderer> ().color = new Color(1.0f,1.0f,1.0f,normAlphaVal);

	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "OOB") {
			StartCoroutine (WaitAndRespawnPlayer ());
		} else if (coll.gameObject.tag == "Special") {
			Destroy(coll.gameObject);
			StartCoroutine(WaitAndRespawnPlayer());
		}

	}
}
