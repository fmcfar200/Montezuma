using UnityEngine;
using System.Collections;

public class PickupScript : MonoBehaviour {

	PlayerAttackScript playerAttack;

	void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.gameObject.tag == "Player") 
		{
			Destroy(this.gameObject);
			playerAttack = coll.GetComponent<PlayerAttackScript>();
			playerAttack.powerReady = true;
		}
	}
}
