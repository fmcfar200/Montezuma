using UnityEngine;
using System.Collections;

public class LevelSelectSceneScript : MonoBehaviour {

	GameObject eventSys;
//	IEnumerator WaitAndUnpause()
//	{
//		yield return new WaitForSeconds (10.0f);
//		Time.timeScale = 1;
//	}

	// Use this for initialization
	void Start () {
		eventSys = GameObject.Find("EventSystem");
//		Time.timeScale = 0;
//		StartCoroutine (WaitAndUnpause());
		StartCoroutine (wait ());
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	IEnumerator wait()
	{
		eventSys.SetActive (false);
		yield return new WaitForSeconds (1.25f);
		eventSys.SetActive (true);
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
