using UnityEngine;
using System.Collections;

public class DoorTrigger : MonoBehaviour {
	
	public GameObject door;
	public GameObject doorTrig;
	// Update is called once per frame
	void OnTriggerEnter (Collider col) {
	if (col.gameObject.tag == "Player") {
			Debug.Log ("Open!");
			door.GetComponent<Animation> ().Play ("DoorClose");
			doorTrig.SetActive (false);
		}
	}


		}
	

