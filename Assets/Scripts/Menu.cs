using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
   
   public bool IsGamePaused;
   
   void Start()
   {
      // PauseGame();
   }
   
   void Update()
   {
       if (Input.GetKey(KeyCode.Escape))
       {
           PauseGame();
       }
   }
   void OnGUI()
   {
       if (!IsGamePaused)
           return;
       ///�Զ����֣���������
       GUILayout.BeginArea(new  Rect((Screen.width - 100)/2, (Screen.height - 200)/2, 100, 200));
       ///����
       GUILayout.BeginVertical();
       if (IsGamePaused)
       {
           if(GUILayout.Button("Start", GUILayout.Height(50)))
           {
               StartGame();
               //enabled = false;
           }
       }      
       if(GUILayout.Button("exit", GUILayout.Height(50)))
       {
           //��Android�Ͽ��ԣ�IOS��û��
           //Debug.Log("Exit");
           Application.Quit();
       }
       GUILayout.Button("111", GUILayout.Height(50));
       GUILayout.EndVertical();
       GUILayout.EndArea();
   }
   
   void StartGame()
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