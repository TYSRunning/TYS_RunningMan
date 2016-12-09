using UnityEngine;
using System.Collections;

public class moving : MonoBehaviour {
	public float speed = 4.0f;

	void Start () {
	}

	void Update () {
		transform.position += transform.forward * speed * Time.deltaTime;
	}
	void FixedUpdate(){
		GetComponent<Rigidbody>().AddForce(Vector3.up*10);
	}
}
