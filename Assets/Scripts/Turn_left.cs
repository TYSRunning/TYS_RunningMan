using UnityEngine;
using System.Collections;

public class Turn_left : MonoBehaviour {

	 
	[SerializeField] private Vector3 direction;

	public float a1,a2;
	public float b;
	public float c;
	public Transform other;
	private GameObject target;
	private GameObject duizhao;
	void Start () {
		target = GameObject.FindWithTag("Player");
		duizhao = GameObject.FindWithTag("duizhao1");
		b = duizhao.transform.position.z;
		//transform.position.x = new Vector3(0, 0, 0);
		//print(target.transform.position.x);

	}


	void Update () {
		print("Distance to other: " + (a1-45));
		a1 = target.transform.position.z;
		a2 = target.transform.position.x;
		c = target.transform.position.x;
		if ((a1-b)>112&&(a1-b)<115&&c==90) {
			print("Distance to other: " + (a1-45));
			if(Input.GetKeyDown(KeyCode.A)){
			Turn();
			}

		}else if((a1-b)>112&&(a1-b)<115&&c>72&&c<75){
			print("Distance to other: " + (a1-45));
			if(Input.GetKeyDown(KeyCode.A)){
				Turn();
			}
		}	
	}
	
	// Update is called once per frame
	void Turn () {
		//mainChar.localEulerAngles += direction;
		transform.localEulerAngles += new Vector3(0,-90,0);
	}
}
