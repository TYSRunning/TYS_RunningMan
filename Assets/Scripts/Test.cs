using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {
	public Vector3 tagPos;
	private bool once;
	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
		if(!once){
			once = true;
			StartCoroutine(Group ());
		}
	}


	IEnumerator Group(){
		yield return StartCoroutine(DoSomething());
		StartCoroutine(DoSomething2());
	}

	IEnumerator DoSomething(){
		StartDoSth ();
		float timer = 0;
		while(timer < 1){
			timer += Time.deltaTime;
			transform.position = Vector3.Lerp (transform.position, tagPos, timer);
			yield return null;
		}
		StopDoSth ();
	}

	void StartDoSth(){
		print ("StartDoSth");
	}

	void StopDoSth(){
		print ("StopDoSth");
	}

	IEnumerator DoSomething2(){
		yield return new WaitForSeconds(1);
		print ("DoSomething2");
	}
}
