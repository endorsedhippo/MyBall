using UnityEngine;
using System.Collections;

public class Pickupable : MonoBehaviour {
	public int time;
	public GameObject ball;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		//States if the ballGravity Static bool from the BallTeleport code is false then IEnumerator happens.
		if (BallTeleport.ballGravity == false) 
		{
			StartCoroutine ("GravityOff");
		}
	}
	//At first the gravity and kinematic will be off. However after a set amount of seconds they will turn back on and ball will act as normal.
	IEnumerator GravityOff()
	{
		if (ball.tag == "Ball") {
			gameObject.GetComponent<Rigidbody> ().useGravity = false;
			gameObject.GetComponent<Rigidbody> ().isKinematic = true;
			yield return new WaitForSeconds (time);
			BallTeleport.ballGravity = true;
			gameObject.GetComponent<Rigidbody> ().useGravity = true;
			gameObject.GetComponent<Rigidbody> ().isKinematic = false;
			BallTeleport.ballGravity = true;
		}
	}
}
