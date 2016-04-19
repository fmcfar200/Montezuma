using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerHealthScript : MonoBehaviour {

	public Transform playerSpawn;
	private float tempAlphaVal = 0.5f;
	private float normAlphaVal = 1.0f;

	public float respawnTimer = 5.0f;

	AudioSource audioSource;
	public List<AudioClip> deathSounds;

	GameObject player;
	GameObject topPlatform;
	Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		audioSource = this.gameObject.GetComponent<AudioSource> ();

		player = this.gameObject;
		topPlatform = GameObject.Find("King_Platform");
		if (topPlatform == null) {
			Debug.LogError("NO TOP PLATFORM FOUND!!");
		}

		animator.SetBool ("Dead", false);
		animator.SetBool ("Dictator", false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public IEnumerator WaitAndRespawnPlayer()
	{
		player.GetComponent<PlayerMovementScript> ().enabled = false;
		player.GetComponent<PlayerAttackScript> ().enabled = false;
		player.GetComponent<BoxCollider2D> ().enabled = false;
		player.GetComponent<Rigidbody2D> ().isKinematic = true;
		animator.enabled = true;
		animator.SetBool ("Dead", true);
		PlayRandomDeathSound ();
		yield return new WaitForSeconds (0.6f);
		player.GetComponent<SpriteRenderer> ().color = new Color(1.0f,1.0f,1.0f,tempAlphaVal);
		if (player.GetComponent<PlayerMovementScript> ().onTopPlat == true) {
			topPlatform.GetComponent<TopPlatformScript> ().numOnTop -= 1;
		}
		animator.SetBool ("Dead", false);
		animator.SetBool ("Moving", false);
		animator.SetBool ("Dictator", false);
		player.GetComponent<PlayerAttackScript> ().isDictator = false;
		this.transform.position = playerSpawn.position;
		yield return new WaitForSeconds (respawnTimer);
		player.GetComponent<PlayerMovementScript> ().enabled = true;
		player.GetComponent<PlayerAttackScript> ().enabled = true;
		player.GetComponent<BoxCollider2D> ().enabled = true;
		player.GetComponent<Rigidbody2D> ().isKinematic = false;
		player.GetComponent<PlayerAttackScript> ().isDictator = false;
		player.GetComponent<PlayerMovementScript> ().onLadder = false;

		player.GetComponent<SpriteRenderer> ().color = new Color(1.0f,1.0f,1.0f,normAlphaVal);


	}

	void PlayRandomDeathSound()
	{
		int randomIndex = Random.Range (0, deathSounds.Count);
		audioSource.PlayOneShot (deathSounds [randomIndex]);
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "OOB") {
			StartCoroutine (WaitAndRespawnPlayer ());
		} else if (coll.gameObject.tag == "Special") {
			Destroy (coll.gameObject);
			if (this.gameObject.GetComponent<PlayerAttackScript> ().usingShield == false) {
				StartCoroutine (WaitAndRespawnPlayer ());
			}
		}

	}
}
