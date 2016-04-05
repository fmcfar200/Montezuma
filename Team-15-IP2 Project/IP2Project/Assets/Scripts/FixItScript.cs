using UnityEngine;
using System.Collections;

public class FixItScript : MonoBehaviour {

	IEnumerator WaitAndDestroy()
	{
		yield return new WaitForSeconds(1.0f);
		Destroy (this.gameObject);
	}

	// Use this for initialization
	void Start () {

		StartCoroutine (WaitAndDestroy());
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
