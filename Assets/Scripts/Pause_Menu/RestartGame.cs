using UnityEngine;
using System.Collections;

public class RestartGame : MonoBehaviour {

	GameObject menu;
	public string levelname;
	public void Click(){
		
		//menu = GameObject.Find ("Canvas");
		//menu.SetActive (false);
		//Application.LoadLevel (levelname);//加载场景
		Application.LoadLevel(Application.loadedLevel);
		Time.timeScale = 1;
	}
}