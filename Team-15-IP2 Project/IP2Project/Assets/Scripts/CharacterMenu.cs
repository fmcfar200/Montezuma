using UnityEngine;
using System.Collections;

public class CharacterMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void LoadLevelSelect()
	{
		Application.LoadLevel ("LevelSelectScene");
	}
}
