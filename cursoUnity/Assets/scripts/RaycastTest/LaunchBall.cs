using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBall : MonoBehaviour {

	public GameObject bolitaPrefab;
	public float pushForce = 10;
	public List<GameObject> bolitasPrefabs = new List<GameObject>();
	public bool infinitasBolas = false;


	void Update () {
		if (Input.GetMouseButtonDown (0) || infinitasBolas) {

			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			//Debug.DrawRay (ray.origin, ray.direction * 1000, Color.blue);

			if (Physics.Raycast (ray, out hit, 1000, LayerMask.GetMask ("floor"))) {
				//Debug.Log (hit.collider.gameObject.name);
				int rand = Random.Range(0, bolitasPrefabs.Count);


				GameObject clone = GameObject.Instantiate (bolitasPrefabs[rand], transform.position, transform.rotation);
				clone.name = bolitasPrefabs[rand].name;
				Rigidbody rb = clone.GetComponent<Rigidbody> ();


				Vector3 dir = hit.point - transform.position;
				Vector3 force = dir.normalized * pushForce;

				rb.AddForce (force, ForceMode.Impulse);


			}
		}
	}
}
