using UnityEngine;
using System.Collections;

public class PickupScript : MonoBehaviour {

	PlayerAttackScript playerAttack;
	string[] powerTypes = {"Freeze","Wind","Speed","Shield"};
	public string thisPower;

	void Start()
	{

	}
	void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.gameObject.tag == "Player") 
		{
			Destroy(this.gameObject);
			playerAttack = coll.GetComponent<PlayerAttackScript>();
			if (thisPower == "Freeze")
			{
				playerAttack.freezePowerReady = true;
			}
			else if (thisPower == "Wind")
			{
				playerAttack.windPowerReady = true;
			}
			else if (thisPower == "Speed")
			{
				playerAttack.speedPowerReady = true;
			}
			else if (thisPower == "Shield")
			{
				playerAttack.shieldPowerReady = true;
			}

		}
	}
}
