using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {
   
   public bool IsGamePaused;
   GameObject menu;
	void Awake(){
		menu = GameObject.Find ("PauseMenu");
	}
	void Start()
   {
		menu.SetActive (false);
		//PauseGame();
   }
   
   void Update()
   {
		
		if (Input.GetKey(KeyCode.Escape))
       {
           PauseGame();

       }
   }
 
   
	public  void StartGame()
   {
       IsGamePaused = false;
       Time.timeScale = 1;
       //Debug.Log("Start Game" + Time.fixedTime);
   }
   
	public  void PauseGame()
   {
       IsGamePaused = true;
       Time.timeScale = 0;
       //Debug.Log("Pause Game");
		menu.SetActive (true);
   }
}