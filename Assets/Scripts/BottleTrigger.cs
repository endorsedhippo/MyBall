using UnityEngine;
using System.Collections;

public class BottleTrigger : MonoBehaviour {

	public GameObject[] bottles;
	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter (Collider col) {
		//bottles = GameObject.FindGameObjectsWithTag("Bottles");
	if (col.tag == "Ball" || col.tag == "Player") 
		{
			foreach (GameObject bottle in bottles) 
			{
			bottle.GetComponent<Rigidbody>().useGravity = true;
			}
		}
	}
}
