using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTest : MonoBehaviour {

	public GameObject bolitaPrefab;
	private Vector3 dir;
	private Vector3 pos;

	void Start () {

	}


	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			pos = transform.position;
			dir = transform.forward;

			Ray ray = new Ray (pos, dir);
			RaycastHit hit;
			Debug.DrawRay(ray.origin, ray.direction*10, Color.blue);

			if (Physics.Raycast(ray, out hit, 10000, LayerMask.GetMask("floor"))) {
				//Debug.Log (hit.collider.gameObject.name);
				Vector3 pointHit = hit.point;
				GameObject.Instantiate (bolitaPrefab, pointHit, Quaternion.identity);

			}
		}


		
	}
}
