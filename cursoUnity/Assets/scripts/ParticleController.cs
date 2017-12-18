using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour {

	public ParticleSystem particle;

	void Start () {
		particle = GetComponent<ParticleSystem> ();
		//particle.Play ();
	}


	void Update () {
		if (Input.GetKeyDown(KeyCode.A)) {
			particle.Play ();
		}else if(Input.GetKeyDown(KeyCode.B)){
			particle.Stop ();
		}
	}
}
