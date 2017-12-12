using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LolTest : MonoBehaviour {

	public GameObject bolitaPrefab;




	void Update () {
		if (Input.GetMouseButtonDown(0)) {

			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			Debug.DrawRay(ray.origin, ray.direction*1000, Color.blue);

			if (Physics.Raycast(ray, out hit, 1000, LayerMask.GetMask("floor"))) {
				//Debug.Log (hit.collider.gameObject.name);
				Vector3 pointHit = hit.point;
				GameObject.Instantiate (bolitaPrefab, pointHit, Quaternion.identity);

			}
		}



	}
}
