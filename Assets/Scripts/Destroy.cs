using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	public int scoreValue;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision col){
		if(col.gameObject.name == "MainChar"){
			Destroy(this.gameObject);
			GUI_Scripts.Instance.AddScore(100);
		}
		
	}

}
