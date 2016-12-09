using UnityEngine;
using System.Collections;

public class Script_Menu : MonoBehaviour {
   
   public bool IsGamePaused;
  GameObject menu;
   void Start()
   {
		menu = GameObject.Find ("Canvas");
		menu.SetActive (false);
		//PauseGame();
   }
   
   void Update()
   {
       if (Input.GetKey(KeyCode.Escape))
       {
           PauseGame();
			menu.SetActive (true);
       }
   }
 
   
	public  void StartGame()
   {
       IsGamePaused = false;
       Time.timeScale = 1;
       //Debug.Log("Start Game" + Time.fixedTime);
   }
   
   void PauseGame()
   {
       IsGamePaused = true;
       Time.timeScale = 0;
       //Debug.Log("Pause Game");
   }
}