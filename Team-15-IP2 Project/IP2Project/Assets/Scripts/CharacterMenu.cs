using UnityEngine;
using System.Collections;

public class CharacterMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {

		GameObject p1d = GameObject.Find ("Player1Data");
		if (p1d == null) 
		{
			p1d = new GameObject("Player1Data");
			p1d.AddComponent<DataScript>();
		}

		GameObject p2d = GameObject.Find ("Player2Data");
		if (p2d == null) 
		{
			p2d = new GameObject("Player2Data");
			p2d.AddComponent<DataScript>();
		}

		GameObject p3d = GameObject.Find ("Player3Data");
		if (p3d == null) 
		{
			p3d = new GameObject("Player3Data");
			p3d.AddComponent<DataScript>();
		}

		GameObject p4d = GameObject.Find ("Player4Data");
		if (p4d == null) 
		{
			p4d = new GameObject("Player4Data");
			p4d.AddComponent<DataScript>();
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void LoadLevelSelect()
	{
		Application.LoadLevel ("LevelSelectScene");
	}
}
