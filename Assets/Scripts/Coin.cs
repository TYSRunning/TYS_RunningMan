using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour{

	public int scoreValue = 100;
	public GameObject destroyFX;

	void OnCollisionEnter(Collision col){
		if(col.gameObject.name == "MainChar"){
			DestroySelf ();
		}
	}

	void DestroySelf(){		
		Instantiate (destroyFX, this.transform.position, Quaternion.identity);
		GUI_Scripts.Instance.AddScore(scoreValue);
		Destroy(this.gameObject);
	}

}
