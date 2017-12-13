using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Marcador : MonoBehaviour {

	public Text texto;
	public int currentScore = 0;


	void Start () {
		texto = GetComponent<Text> ();
		texto.text = currentScore.ToString();
	}


	void Update () {
		texto.text = currentScore.ToString();
	}


	public void AddScore(){
		Debug.Log ("AddScore");
		currentScore++;
	}

}
