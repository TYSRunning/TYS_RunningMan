using UnityEngine;
using System.Collections;


public class ContinueGame : MonoBehaviour {

	GameObject menu;
	public void Click(){
		Time.timeScale = 1;
		menu = GameObject.Find ("PauseMenu");
		menu.SetActive (false);
		//Debug.Log("123123");
	}
}
