using UnityEngine;
using System.Collections;

public class BookTrigger : MonoBehaviour {
	
	public GameObject[] books;
	// Use this for initialization
	void Start () {
		
	}
	
	void OnTriggerEnter (Collider col) {
		//books = GameObject.FindGameObjectsWithTag("Books");
		if (col.tag == "Ball" || col.tag == "Player") {
			foreach (GameObject book in books) {
				book.GetComponent<Rigidbody>().useGravity = true;
				book.GetComponent<Rigidbody>().isKinematic = false;
			}
		}
	}
}
