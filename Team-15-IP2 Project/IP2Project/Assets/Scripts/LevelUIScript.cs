using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelUIScript : MonoBehaviour {

	public Image p1UI;
	public Image p2UI;
	public Image p3UI;
	public Image p4UI;


	public Sprite yellowUI;
	public Sprite redUI;
	public Sprite greenUI;
	public Sprite blueUI;

	// Use this for initialization
	void Start () {
		GameObject g1 = GameObject.Find ("Player1Data");
		if (g1 != null) 
		{
			DataScript d = g1.GetComponent<DataScript>();
			if(d.playerSpriteNumber == 1)
			{
				p1UI.sprite = blueUI;
			}
			if(d.playerSpriteNumber == 2)
			{
				p1UI.sprite = greenUI;
			}
			if(d.playerSpriteNumber == 3)
			{
				p1UI.sprite = yellowUI;
			}
			if(d.playerSpriteNumber == 4)
			{
				p1UI.sprite = redUI;
			}
		}
		GameObject g2 = GameObject.Find ("Player2Data");
		if (g2 != null) 
		{
			DataScript d = g2.GetComponent<DataScript>();
			if(d.playerSpriteNumber == 1)
			{
				p2UI.sprite = blueUI;
			}
			if(d.playerSpriteNumber == 2)
			{
				p2UI.sprite = greenUI;
			}
			if(d.playerSpriteNumber == 3)
			{
				p2UI.sprite = yellowUI;
			}
			if(d.playerSpriteNumber == 4)
			{
				p2UI.sprite = redUI;
			}
		}
		GameObject g3 = GameObject.Find ("Player3Data");
		if (g3 != null) 
		{
			DataScript d = g3.GetComponent<DataScript>();
			if(d.playerSpriteNumber == 1)
			{
				p3UI.sprite = blueUI;
			}
			if(d.playerSpriteNumber == 2)
			{
				p3UI.sprite = greenUI;
			}
			if(d.playerSpriteNumber == 3)
			{
				p3UI.sprite = yellowUI;
			}
			if(d.playerSpriteNumber == 4)
			{
				p3UI.sprite = redUI;
			}
		}
		GameObject g4 = GameObject.Find ("Player4Data");
		if (g4 != null) 
		{
			DataScript d = g4.GetComponent<DataScript>();
			if(d.playerSpriteNumber == 1)
			{
				p4UI.sprite = blueUI;
			}
			if(d.playerSpriteNumber == 2)
			{
				p4UI.sprite = greenUI;
			}
			if(d.playerSpriteNumber == 3)
			{
				p4UI.sprite = yellowUI;
			}
			if(d.playerSpriteNumber == 4)
			{
				p4UI.sprite = redUI;
			}
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
