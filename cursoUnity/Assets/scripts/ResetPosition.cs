using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour {

	public float ylimit = -5;
	Vector3 originalPosition;
	Rigidbody myRigidbody;

	public bool resetVelocity=true;


	void Start () {
		myRigidbody = GetComponent<Rigidbody> ();
		originalPosition = transform.position;
	}


	void Update () {
		
		if (transform.position.y <= ylimit) {
			transform.position = originalPosition;
			if (resetVelocity) {
				myRigidbody.velocity = Vector3.zero;
				myRigidbody.angularVelocity = Vector3.zero;
			}
		}
	}
}
