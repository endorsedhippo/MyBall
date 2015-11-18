using UnityEngine;
using System.Collections;

public class AirConWriting : MonoBehaviour {

	bool triggered;
	public int time;

	// Use this for initialization
	void Start () 
	{
	}
	//Player is on trigger.
	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Player") 
		{
			triggered = true;
		}
	}

	//Display “This might not have been the best idea...” on screen.
	void OnGUI()
	{
		if (triggered == true) 
		{
			GUI.Label (new Rect (500, 600, 500, 200), "This might not have been the best idea...");
			StartCoroutine ("DisableText");
		}
	}

	//Remove the text after the set amount of time.
	IEnumerator DisableText() 
	{
		yield return new WaitForSeconds(time);
		triggered = false;
	}
}
