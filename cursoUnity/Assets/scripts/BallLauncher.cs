using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour {

	public Rigidbody myRigidbody;
	public float pushForce;
	private Vector3 direction;
	private bool fired;

	void Start(){
		fired = false;
		direction = transform.forward;
	}

	void Update () {
		if (!fired && Input.GetKeyDown(KeyCode.Space)) {
			fired = true;
			Vector3 force = direction * pushForce;
			myRigidbody.AddForce(force, ForceMode.VelocityChange);
		}
	}
}
