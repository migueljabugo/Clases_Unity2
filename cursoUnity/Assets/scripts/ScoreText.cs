using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreText : MonoBehaviour {

	public TextMesh text;


	public void SetScore(int score){
		string scoreText = "Score: " + score;
		text.text = scoreText;
	}
}
