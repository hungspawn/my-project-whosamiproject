using UnityEngine;
using System.Collections;

public class HandlerButton : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	public void OnClick ()
	{
		GameObject thePlayer = GameObject.Find("MainScript");

		thePlayer.GetComponent<MultipeScreen>().scoreGame +=1;
	
	}
	// Update is called once per frame
	void Update () {
			
	}
}
