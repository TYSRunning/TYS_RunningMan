using UnityEngine;
using System.Collections;


public class StartGame : MonoBehaviour {

	//public Texture2D normal;//普通

	//public Texture2D active;//高亮

	public string levelname;//要装载的场景

	//public AudioClip sfxButton;//声音

	/*void OnMouseDown(){
		GetComponent<GUITexture>().texture = active;

	}
	void OnMouseUpAsButton(){
		GetComponent<GUITexture>().texture = normal;

		

	}*/

	public void Click(){
		//AudioSource.PlayClipAtPoint (sfxButton, transform.position);
		Application.LoadLevel (levelname);//加载场景
	}


}
