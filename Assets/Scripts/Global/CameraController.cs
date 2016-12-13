using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;
	private float smoothSpeed = 1.5f;

	void Start () {
		offset = transform.position;
	}
	

	void Update () {
		//transform.position = player.transform.position + offset;
		transform.position = Vector3.Lerp(transform.position, player.transform.position + offset, Time.deltaTime * smoothSpeed);
	}
	void LaterUpdate(){
		//transform.position = player.transform.position + offset;
		//transform.position = Vector3.Lerp(transform.position, player.transform.position + offset, Time.deltaTime * smoothSpeed);
	}
}
