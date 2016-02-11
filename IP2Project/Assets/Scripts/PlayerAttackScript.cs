using UnityEngine;
using System.Collections;

public class PlayerAttackScript : MonoBehaviour {

	public BoxCollider2D attackTrigger;
	public string attackString = "Attack_P1";
	private bool attacking = false;

	private float attackTimer = 0;
	private float attackDelay = 0.5f;



	// Use this for initialization
	void Start () 
	{
		attackTrigger.enabled = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
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
	}
	void OnTriggerStay2D(Collider2D coll)
	{

		if (coll.gameObject.tag == "Player") {
			coll.GetComponent<PlayerRespawnScript>().RespawnPlayer();
		}
	}
}
