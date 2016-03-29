using UnityEngine;
using System.Collections;

public class PickupScript : MonoBehaviour {

	PlayerAttackScript playerAttack;
	PickupSpawnScript pickupSpawnScript;
	GameObject gameManager;

	public string thisPower;

	void Start()
	{
		gameManager = GameObject.Find("GameManager");
		if (gameManager != null) {
			pickupSpawnScript = gameManager.GetComponent<PickupSpawnScript> ();
		} else {
			Debug.LogError("GAME MANAGER NOT FOUND");
		}
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
