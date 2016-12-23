using UnityEngine;
using System.Collections;

public class Bgtrigger_cj : MonoBehaviour {


	GameObject cj;
	void Start () {
		cj = new GameObject();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider e)

	{

	if (e.CompareTag("Player"))

	{
	 if (gameObject.transform.parent.CompareTag("Anim1"))

	{

		cj = GameObject.FindGameObjectWithTag("Anim1");

		cj.transform.position = new Vector3(-4, 0, cj.transform.position.z + 120);

	}

	else if (gameObject.transform.parent.CompareTag("Anim2"))

	{
		//找到物体
		cj = GameObject.FindGameObjectWithTag("Anim2");
		//重新定义其位置
		cj.transform.position = new Vector3(-4, 0, cj.transform.position.z + 120);
			}
	}
}
}