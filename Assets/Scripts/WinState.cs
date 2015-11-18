using UnityEngine;
using System.Collections;

public class WinState : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter (Collider col) 
	{
		if (col.gameObject.tag == "Ball")
		{
			Application.LoadLevel ("QuitMenu");
		}
}
}