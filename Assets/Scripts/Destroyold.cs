using UnityEngine;
using System.Collections;

public class Destroyold: MonoBehaviour {

	private float lifettime;
	// Use this for initialization
	void Start () {
		lifettime = 20;
		Destroy(this.gameObject,lifettime);
	}

	// Update is called once per frame
	void Update () {

	}
}
