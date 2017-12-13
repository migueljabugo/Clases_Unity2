using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour {

	public NavMeshAgent agent;



	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {

			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			Debug.DrawRay(ray.origin, ray.direction*1000, Color.blue);

			if (Physics.Raycast(ray, out hit, 1000, LayerMask.GetMask("floor"))) {
				//Debug.Log (hit.collider.gameObject.name);


				//MOver ajente al punto
				//agent.SetDestination (hit.point);
			}
		}



	}
}
