using UnityEngine;
using System.Collections;

public class turn : MonoBehaviour {

	public float du1 = 0;
	public float du2 = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.D)){
			Setlefttion();
		}else if (Input.GetKeyUp (KeyCode.A)){
			SetRotation();
		}
	}
	void OnTriggerStay(Collider collider) {
		//if(collider.CompareTag("TurnRight")){
			Debug.Log("触发中");
			du1=-90;
			du2=90;
		//}

	}

	void OnTriggerExit(Collider collider) {
		//if(collider.CompareTag("TurnRight")){
		du1=0;
		du2=0;
		Debug.Log("触发结束");
		//}
	}

	void SetRotation(){
		transform.localEulerAngles += new Vector3(0,du1,0);
	}
	void Setlefttion(){
		transform.localEulerAngles += new Vector3(0,du2,0);
	}

}

