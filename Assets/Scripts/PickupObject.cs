﻿using UnityEngine;
using System.Collections;

public class PickupObject : MonoBehaviour {

	GameObject mainCamera;
	bool carrying;
	GameObject carriedObject;
	public float throwForce;
	public float distance;
	public float smooth;
	public float speed;
	public float height;
	public float regrabDelay=0.5f;
	public float grabDistance=5f;
	public AudioSource oneTimeSoundSource;
	public AudioSource soundSource;
	float grabDelay=0f;
	Quaternion rot;


	// Use this for initialization
	void Start () {
		mainCamera = GameObject.FindWithTag ("MainCamera");
	}
	
	// Update is called once per frame
	void Update () {
			if (Input.GetKeyDown (KeyCode.F)) {
			carrying = false;
			carriedObject.GetComponent<Rigidbody>().useGravity = true;
			carriedObject.GetComponent<Rigidbody>().velocity = transform.TransformDirection(new Vector3(0,height,speed)); 
		}

		if (carrying) {
			Carry (carriedObject);
			CheckDrop();
		} else {
			Pickup ();
		}
		if (grabDelay > 0) {
			grabDelay-=Time.deltaTime;
		}



	}
	void RotateObject() {
		carriedObject.transform.Rotate (5, 10, 5);
	}

	void Carry(GameObject obj) {
		obj.GetComponent<Rigidbody>().velocity=Vector3.zero;
		//obj.transform.position = Vector3.Lerp(obj.transform.position, mainCamera.transform.position + mainCamera.transform.forward * distance, Time.deltaTime * smooth);

		Vector3 direct = (mainCamera.transform.position + mainCamera.transform.forward * distance) - obj.transform.position;
		direct.Normalize ();
		obj.GetComponent<Rigidbody>().velocity=direct * smooth*Vector3.Distance(mainCamera.transform.position + mainCamera.transform.forward * distance
		                                                                        ,obj.transform.position);
		                                                    
		// stop picked up object rotating
		obj.transform.rotation = Quaternion.identity;

	}

	void Pickup() {
		if (Input.GetKey (KeyCode.E)&& grabDelay <= 0) {
			int x = Screen.width / 2;
			int y = Screen.height / 2;

			Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3(x,y));
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit, grabDistance)) {
				Pickupable p = hit.collider.GetComponent<Pickupable>();
				if( p != null) {
					/*if (p.oneTimeSound!=null&&p.pickedUp==false){
						oneTimeSoundSource.clip=p.oneTimeSound;
						oneTimeSoundSource.Play();
						hit.collider.GetComponent<Pickupable>().pickedUp=true;
					}
					if (p.pickUpSound!=null){
						soundSource.clip=p.pickUpSound;
						soundSource.Play();

					}*/
					carrying = true;
					carriedObject = p.gameObject;
					p.gameObject.GetComponent<Rigidbody>().useGravity = false;
					p.gameObject.GetComponent<Rigidbody>().velocity=Vector3.zero;
					rot = p.gameObject.transform.rotation;
				}
			}

		}
	}

	void CheckDrop() {
		if (Input.GetKeyDown (KeyCode.E)) {
			DropObject();
		}
	}

	void DropObject() {
		carrying = false;
		carriedObject.GetComponent<Rigidbody>().useGravity = true;
		carriedObject = null;
		grabDelay = regrabDelay;
	}
}
