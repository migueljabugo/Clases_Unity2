using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fliper : MonoBehaviour {

	public string axis;
	public bool reversed;
	public float angle = 20;
	public HingeJoint hinge;

	JointSpring spring;


	void Start () {
		spring = hinge.spring;
	}


	void Update () {
		float reverse = (reversed) ? -1 : 1;
		if (Input.GetAxis (axis) != 0) {
			//Levantar el flipper
			spring.targetPosition = -angle * reverse;
			hinge.spring = spring;

		} else {
			//Bajar el flipper a la posicion inicial
			spring.targetPosition = angle * reverse;
			hinge.spring = spring;
		}
		
	}
}
