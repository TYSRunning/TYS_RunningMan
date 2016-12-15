using UnityEngine;
using System.Collections;

public class ReturnMenu : MonoBehaviour {

	GameObject menu;
	public string levelname;
	public void Click(){
		
		//menu = GameObject.Find ("Canvas");
		//menu.SetActive (false);
		Application.LoadLevel (levelname);//加载场景
		Time.timeScale = 1;
	}
}
