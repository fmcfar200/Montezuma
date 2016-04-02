using UnityEngine;
using System.Collections;

public class PickupScript : MonoBehaviour {

	PlayerAttackScript playerAttack;
	AudioSource playerAudioSource;

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
			playerAudioSource = coll.GetComponent<AudioSource>();
			playerAudioSource.PlayOneShot(playerAttack.pickUpSound);
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
