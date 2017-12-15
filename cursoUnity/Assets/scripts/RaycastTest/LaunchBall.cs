﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBall : MonoBehaviour {

	public GameObject bolitaPrefab;
	public float pushForce = 10;
	public List<GameObject> bolitasPrefabs = new List<GameObject>();
	public bool infinitasBolas = false;
	public AudioSource audioSource;

	void Start(){
		audioSource = GetComponent<AudioSource> ();

	}


	void Update () {
		if (/*Input.GetMouseButtonDown (0) ||*/ infinitasBolas) {
			LanzarBolaRandomDireccionClic ();
		}
	}

	private void LanzarBolaRandomDireccionClic(){
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;
		//Debug.DrawRay (ray.origin, ray.direction * 1000, Color.blue);

		if (Physics.Raycast (ray, out hit, 1000, LayerMask.GetMask ("floor"))) {
			//Debug.Log (hit.collider.gameObject.name);
			int rand = Random.Range (0, bolitasPrefabs.Count);


			GameObject clone = GameObject.Instantiate (bolitasPrefabs [rand], transform.position, transform.rotation);
			clone.name = bolitasPrefabs [rand].name;
			Rigidbody rb = clone.GetComponent<Rigidbody> ();


			Vector3 dir = hit.point - transform.position;
			Vector3 force = dir.normalized * pushForce;

			rb.AddForce (force, ForceMode.Impulse);
		}
	}

	public void LanzarBolaRoja(){
		LanzarBolaForward (2);
	}
	public void LanzarBolaVerde(){
		LanzarBolaForward (1);
	}
	public void LanzarBolaAzul(){
		LanzarBolaForward (0);
	}
	public void LanzarBolaAmarillo(){
		LanzarBolaForward (3);
	}
	public void LanzarBolaRandom(){
		LanzarBolaForward (4);
	}

	private void LanzarBolaForward(int ball){
		audioSource.Play ();
		
		Debug.Log ("Lanza bola");
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;
		//Debug.DrawRay (ray.origin, ray.direction * 1000, Color.blue);

		if (Physics.Raycast (ray, out hit, 1000)) {
			//Debug.Log (hit.collider.gameObject.name);
			int rand = Random.Range (0, bolitasPrefabs.Count);

			rand = (ball >= bolitasPrefabs.Count) ? rand : ball;
			GameObject clone = GameObject.Instantiate (bolitasPrefabs [rand], transform.position, transform.rotation);
			clone.name = bolitasPrefabs [rand].name;
			Rigidbody rb = clone.GetComponent<Rigidbody> ();


			Vector3 dir = transform.forward;
			Vector3 force = dir.normalized * pushForce;

			rb.AddForce (force, ForceMode.Impulse);
		}
	}
}
