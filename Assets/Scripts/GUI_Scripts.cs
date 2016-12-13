using UnityEngine;
using System.Collections;

public class GUI_Scripts : MonoBehaviour {

	public GUIText scoreText;
	public int score;
	// Use this for initialization
	void Start () {
		score = 0;
		UpdateScore();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void UpdateScore(){
		scoreText.text = "score"+score;
	}

	public void AddScore(int  newScoreValue){
		score += newScoreValue;
		UpdateScore();
	}
}
