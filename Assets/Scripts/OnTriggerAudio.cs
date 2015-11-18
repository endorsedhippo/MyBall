using UnityEngine;
using System.Collections;

public class OnTriggerAudio : MonoBehaviour {

	private AudioSource Source;
	public AudioClip squeaky;


	void Start()
	{
		Source = GetComponent<AudioSource> ();
	}
	void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.tag == "Player") 
		{
			Source.clip = squeaky;
			Source.Play();
		}
	}

}
