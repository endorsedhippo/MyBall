using UnityEngine;
using System.Collections;

public class FailState : MonoBehaviour {
	bool collided;
	
	IEnumerator OnTriggerEnter(Collider collider)
	{
		collided = true;
		yield return new WaitForSeconds(2);  
		if (collided) {
			Application.LoadLevel("Scene 002");
		}
	}
	
	void OnCollisionExit () {
		collided = false;
	}
}
