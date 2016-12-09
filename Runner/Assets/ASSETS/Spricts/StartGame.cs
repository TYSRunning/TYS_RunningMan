using UnityEngine;
using System.Collections;


public class StartGame : MonoBehaviour {

	GameObject menu;
	public void Click(){
		Time.timeScale = 1;
		menu = GameObject.Find ("Canvas");
		menu.SetActive (false);
		//Debug.Log("123123");
	}
}
