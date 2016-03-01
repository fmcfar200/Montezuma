using UnityEngine;
using System.Collections;

public class TopPlatformScript : MonoBehaviour {

	public int numOnTop = 0;



	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "Player") {
			numOnTop++;
		}
	}
	void OnCollisionStay2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "Player") {
			if (numOnTop == 1)
			{
				coll.gameObject.GetComponent<PlayerAttackScript>().isDictator = true;
			}

		}
	}
	void OnCollisionExit2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "Player") {
			numOnTop --;
			coll.gameObject.GetComponent<PlayerAttackScript>().isDictator = false;
		}
	}

}
