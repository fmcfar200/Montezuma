using UnityEngine;
using System.Collections;

public class PlayerRespawnScript : MonoBehaviour {

	public Transform playerSpawn;
	private string playerName;

	// Use this for initialization
	void Start () {
		playerName = this.gameObject.name;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void RespawnPlayer()
	{
		this.transform.position = playerSpawn.position;
	}
}
