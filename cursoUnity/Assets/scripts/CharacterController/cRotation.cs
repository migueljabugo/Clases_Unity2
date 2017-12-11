using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cRotation : MonoBehaviour {

	float mouseX;
	float mouseY;
	public GameObject camera;

	void Update () {
		//Rotation
		mouseX = Input.GetAxis ("mouseX");
		mouseY = Input.GetAxis ("mouseY");

		if (mouseX>0 || mouseX<0) {
			transform.Rotate (new Vector3(0, mouseX, 0));
		}

		if (mouseY>0 || mouseY<0) {
			camera.transform.Rotate (new Vector3(mouseY, 0, 0));
		}
	}
}


