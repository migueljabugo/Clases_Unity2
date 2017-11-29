using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreObject : MonoBehaviour {

	public int scorePerHit = 10;
	public ScoreManager manager;


	void Start(){
		manager = GameObject.FindObjectOfType<ScoreManager> ();
	}


	void OnCollisionEnter(Collision col){
		Debug.Log (scorePerHit + " puntos");
		manager.AddScore (scorePerHit);

		Debug.Log ("Puntos Totales: " + manager.currentScore);

	}
}
