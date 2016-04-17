using UnityEngine;
using System.Collections;

public class LevelSelectSceneScript : MonoBehaviour {

	IEnumerator WaitAndUnpause()
	{
		yield return new WaitForSeconds (10.0f);
		Time.timeScale = 1;
	}

	// Use this for initialization
	void Start () {

		Time.timeScale = 0;
		StartCoroutine (WaitAndUnpause());

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void LoadLevelOne()
	{

		Application.LoadLevel ("Level_1");
	}

	public void LoadLevelTwo()
	{
		Application.LoadLevel ("Level_2");
	}

	public void LoadLevelThree()
	{
		Application.LoadLevel ("Level_3");
	}
}
