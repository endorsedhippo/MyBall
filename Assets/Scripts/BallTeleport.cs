using UnityEngine;
using System.Collections;

public class BallTeleport : MonoBehaviour {

	//All statments including static ones (can be used by other scripts)
	public GameObject ballTeleport;
	bool triggered;
	public int time;
	public static bool ballGravity;
	

	// Use this for initialization
	void Start ()
	{
		ballGravity = true;
	}
	void OnTriggerEnter (Collider collidedObject)
	{
		//Statment that tells the ball if it hits the trigger to be teleported.
		if (collidedObject.gameObject.tag == "Ball") 
		{
			collidedObject.transform.position = ballTeleport.transform.position;
			triggered = true;
			//Because of this if there is a situation where ballGravity needs to be false for something to happen, this situation would have needed to happen first.
			ballGravity = false;
		}

	}

	void OnGUI()
	{
		//Has text appear when ball hits trigger.
		if (triggered == true) 
		{
			GUI.Label (new Rect (500, 600, 500, 200), "Molly: Haha, I have your baaaall!");
			StartCoroutine ("DisableText");
		}
	}
	//Has text disapear after a set set of seconds/
	IEnumerator DisableText() 
	{
		yield return new WaitForSeconds(time);
		triggered = false;
	}

	// Update is called once per frame
	void Update () {
	
	}
}
