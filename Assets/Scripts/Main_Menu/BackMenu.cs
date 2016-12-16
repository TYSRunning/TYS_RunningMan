using UnityEngine;
using System.Collections;

public class BackMenu : MonoBehaviour {

	public void Click(){
		//AudioSource.PlayClipAtPoint (sfxButton, transform.position);
		Application.LoadLevel ("Main_Menu");//加载场景
	}

}
