using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

	public int currentScore;
	public ScoreText scoreText;

	void start(){
		ResetScore ();
	}

	public void AddScore(int score){
		this.currentScore += score;
		scoreText.SetScore (currentScore);
	}

	public void ResetScore(){
		currentScore = 0;
		scoreText.SetScore (currentScore);
	}




}
