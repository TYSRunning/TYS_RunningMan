using UnityEngine;
using System.Collections;


public class StartGame : MonoBehaviour {

	//public Texture2D normal;//普通

	//public Texture2D active;//高亮

	public string levelname;//要装载的场景

	public AudioSource audio;//声音

	/*void OnMouseDown(){
		GetComponent<GUITexture>().texture = active;

	}
	void OnMouseUpAsButton(){
		GetComponent<GUITexture>().texture = normal;

		

	}*/

	void Awake(){
		audio = GetComponent<AudioSource> ();
	}

	public void Click(){
		StartCoroutine(PlaysfxButton ());
		//Application.LoadLevel (levelname);


	}
	IEnumerator PlaysfxButton (){
		audio.Play();
		yield return new WaitForSeconds(audio.clip.length);
		Application.LoadLevel (levelname);
	}



}
