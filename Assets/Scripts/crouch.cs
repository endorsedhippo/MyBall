using UnityEngine;
using System.Collections;

public class crouch : MonoBehaviour {

	public Transform player;
	public Transform crouchPlacement;
	public static bool crouching;
	
	// Update is called once per frame
	void Update () {

		float newPositionY = crouchPlacement.position.y;

		if (Input.GetButtonDown ("Crouch") && crouching == false) {
		
			player.localScale = new Vector3 (1.0f, 0.5f, 1.0f);
			player.position = new Vector3 (player.position.x, newPositionY - 0.4f, player.position.z);
			crouching = true;

		}

		if (Input.GetButtonUp ("Crouch") && crouching == true){
				crouching = false;
			}

		
		 

		if (crouching == false)  {
			player.localScale = new Vector3 (1f, 1f, 1f);

		}
	}
}
