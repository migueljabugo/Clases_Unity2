using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour {

	public AudioSource source;


	void Start () {
		source = GetComponent<AudioSource> ();
	}


	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			source.Play ();
		}
	}
}
