using UnityEngine;
using System.Collections;


public class StartGame : MonoBehaviour {

	//public Texture2D normal;//普通

	//public Texture2D active;//高亮

	public string levelname;//要装载的场景

	public AudioSource sfxButton;//声音

	/*void OnMouseDown(){
		GetComponent<GUITexture>().texture = active;

	}
	void OnMouseUpAsButton(){
		GetComponent<GUITexture>().texture = normal;

		

	}*/

	public void Click(){
		StartCoroutine(PlaysfxButton ());
		//Application.LoadLevel (levelname);


	}
	IEnumerator PlaysfxButton (){
		sfxButton=(GetComponent<AudioSource>());
		sfxButton.Play();
		yield return new WaitForSeconds(0.5f);
		Application.LoadLevel (levelname);
	}



}
