using UnityEngine;
using System.Collections;

public class MainCharSpawer : MonoBehaviour {

	public GameObject mainChar;
	private GameManager gm;
	void Start () {
		gm = GameManager.GetInstance();
		//gm.gameStartEvent.AddListener(OnGameStart);
	}

	void Update () {
		
	}
	void OnGameStart(){
		Instantiate(mainChar);
	}

	void OnGameOver(){
		
	}
}
