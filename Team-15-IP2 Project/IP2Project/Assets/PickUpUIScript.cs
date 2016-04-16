using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PickUpUIScript : MonoBehaviour {


	public Image spriteUI;
	public Sprite freeze;
	public Sprite wind;
	public Sprite shield;
	public Sprite speed;

	PlayerAttackScript playerAttackScript;
	// Use this for initialization
	void Start () 
	{
		playerAttackScript = GetComponent<PlayerAttackScript> ();
		spriteUI.gameObject.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (playerAttackScript.freezePowerReady == true) {
			spriteUI.gameObject.SetActive (true);
			spriteUI.sprite = freeze;
		} else if (playerAttackScript.windPowerReady == true) {
			spriteUI.gameObject.SetActive (true);
			spriteUI.sprite = wind;
		} else if (playerAttackScript.shieldPowerReady == true) {
			spriteUI.gameObject.SetActive (true);
			spriteUI.sprite = shield;
		} else if (playerAttackScript.speedPowerReady == true) {
			spriteUI.gameObject.SetActive (true);
			spriteUI.sprite = speed;
		} else {
			spriteUI.gameObject.SetActive (false);
		}
	}
}
