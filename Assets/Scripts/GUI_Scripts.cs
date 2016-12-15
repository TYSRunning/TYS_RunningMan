using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUI_Scripts : MonoBehaviour {

	private static GUI_Scripts m_instance; 
	public static GUI_Scripts Instance{//singleton
		get{
			if(m_instance)
				return m_instance;
			else
				return (GUI_Scripts)FindObjectOfType(typeof(GUI_Scripts));
		}
	}

	public Text scoretext;
	public int score;
	// Use this for initialization
	void Start () {
		score = 0;
		scoretext = GameObject.Find("Canvas/Text").GetComponent<Text>();
		UpdateScore();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AddScore(int  newScoreValue){
		score += newScoreValue;
		UpdateScore();
	}

	private void UpdateScore(){
		scoretext.text = "分数:" + score;
	}

}
