using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	void OnTriggerEnter (Collider col) {
		//books = GameObject.FindGameObjectsWithTag("Books");
		if (col.tag == "Player") {
			// destroy all game objects that enter this area
			//Destroy(col.gameObject);
			//col.transform.position = new Vector3(5.485F,3.295F,3.06F);
			Application.LoadLevel("Scene 002");
		}
	}
}