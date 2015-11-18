using UnityEngine;
using System.Collections;

public class PlayerLean : MonoBehaviour {
	
	public bool lean;
	public float leanAngleLeft;
	public float leanDistanceLeft;
	public float leanAngleRight;
	public float leanDistanceRight;
	public float speed;
	// Use this for initialization
	void Start () {
		lean = false;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		if(Input.GetKey("q")) {
			LeanLeft();

		}
		if(Input.GetKeyUp("q")) {
			LeanLeftBack();
		}
		if(Input.GetKey("r")) {
			LeanRight();
			
		}
		if(Input.GetKeyUp("r")) {
			LeanRightBack();
		}
	}

	void LeanLeft() {
		lean = true;
		if(lean == true) {
			transform.localRotation = Quaternion.Euler(0,0,leanAngleLeft);
			transform.localPosition = new Vector3(leanDistanceLeft, 0, 0);
		}
	}

	void LeanLeftBack() {
		lean = false;
		if(lean == false) {
		transform.localRotation = Quaternion.Euler(0,0,0);
		transform.localPosition = new Vector3(0, 0, 0);
		}
	}

	void LeanRight() {
		lean = true;
		if(lean == true) {
			transform.localRotation = Quaternion.Euler(0,0,leanAngleRight);
			transform.localPosition = new Vector3(leanDistanceRight, 0, 0);
		}
	}
	
	void LeanRightBack() {
		lean = false;
		if(lean == false) {
			transform.localRotation = Quaternion.Euler(0,0,0);
			transform.localPosition = new Vector3(0, 0, 0);
		}
	}
}
