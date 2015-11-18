using UnityEngine;
using System.Collections;

public class LightSwitch : MonoBehaviour {

	public bool isLightOn;
	public GameObject light; 

	// Use this for initialization
	void Start () {
		isLightOn = false;
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider col) {
		if (col.tag == "Ball" && isLightOn == false) { // if the ball is tagged ball and (&&) isLightOn = false we turn light on
			light.SetActive(true);
			isLightOn = true;
		}
		else if (col.tag == "Ball" && isLightOn == true) { // if the ball is tagged ball and (&&) isLightOn = true we turn light off
			light.SetActive(false);
			isLightOn = false;
		}
	}
}
