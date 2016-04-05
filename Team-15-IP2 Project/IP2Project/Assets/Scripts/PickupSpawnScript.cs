using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PickupSpawnScript : MonoBehaviour {

	public List<GameObject> pickupPrefabs = new List<GameObject>();
	public List<Transform> pickupSpawns = new List<Transform>();
	private float spawnDelay;
	private float time;
	AudioSource audioSource;
	public AudioClip spawnSound;
	void Start()
	{
		audioSource = GetComponent<AudioSource> ();
		time = 0;
		SetRandomDelay ();
	}
	// Update is called once per frame
	void Update () 
	{
		time += Time.deltaTime;


		if (GameObject.FindGameObjectWithTag ("Power") == null) 
		{
			if (time >= spawnDelay)
			{
				SpawnPower();
				SetRandomDelay();
			}
		}

	}

	void SetRandomDelay()
	{
		spawnDelay = Random.Range (5.0f, 15.0f);
	}

	void SpawnPower()
	{
		audioSource.PlayOneShot (spawnSound);
		int iThePickup = Random.Range (0, pickupPrefabs.Count);
		int iTheSpawn = Random.Range (0, pickupSpawns.Count);
		time = 0;
		Instantiate (pickupPrefabs [iThePickup], pickupSpawns [iTheSpawn].transform.position, Quaternion.identity);
	}


}
