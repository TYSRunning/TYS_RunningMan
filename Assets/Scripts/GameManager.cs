using UnityEngine;
using System.Collections;
using UnityEngine.Events;
public class GameManager : MonoBehaviour {

	private static GameManager instance;
	public static GameManager GetInstance(){
		return instance;
	}

	public UnityEvent gameStartEvent;

	void Start(){
		OnGameStart();
	}
	void OnGameStart(){
		gameStartEvent.Invoke();
	}

	void OnGameOver(){

	}
}
