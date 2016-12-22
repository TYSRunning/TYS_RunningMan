using UnityEngine;
using System.Collections;

public class BackMenu : MonoBehaviour {

	public void Click(){
		//AudioSource.PlayClipAtPoint (sfxButton, transform.position);
		Application.LoadLevel ("MainMenu");//加载场景
	}

}
