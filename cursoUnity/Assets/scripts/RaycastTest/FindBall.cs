﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FindBall : MonoBehaviour {

	NavMeshAgent agent;
	public Marcador marcadorRed;
	public Marcador marcadorBlue;
	public Marcador marcadorYellow;
	public Marcador marcadorGreen;

	// Use this for initialization
	void Start () {

		agent = GetComponent<NavMeshAgent> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		Collider[] balls = Physics.OverlapSphere (transform.position, 50, LayerMask.GetMask ("balls"));
		//Debug.Log ( balls.Length);
		if (balls != null && balls.Length>0) {
			GameObject ball= GetNearetBall (balls);
			agent.SetDestination (ball.transform.position);
		}
	}



	private GameObject GetNearetBall(Collider[] balls){
		GameObject ball = null;
		float minDistance = float.MaxValue;

		foreach (Collider col  in balls) {
			GameObject b = col.gameObject;
			float dist = Vector3.Distance (transform.position, b.transform.position);
			if (dist< minDistance) {
				ball = b;
				minDistance = dist;
			}
		}
		return ball;	
	}


	private void OnTriggerEnter(Collider col){

		AudioSource audioSource = GetComponent<AudioSource> ();
		audioSource.Play();

		switch (col.gameObject.name) {
			case "BolitaRed":
				marcadorRed.AddScore ();
				break;
			case "BolitaBlue":
				marcadorBlue.AddScore ();
				break;
			case "BolitaYellow":
				marcadorYellow.AddScore ();
				break;
			case "BolitaGreen":
				marcadorGreen.AddScore ();
				break;
		}
		Destroy (col.gameObject);	
		Debug.Log ( "Destroy ball");
	}





}
