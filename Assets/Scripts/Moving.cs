using UnityEngine;
using System.Collections;

public class Moving : MonoBehaviour {
	public float speed = 10.0f;
	[SerializeField] private Animator anim;
	private float tim;

	public float fireRate;

	private float nextFire;
	private Rigidbody rigidbody;

	void Start () {
		//fireRate = 2.0f;
		//nextFire = 0.0f;
		Init();
	}
	void Init(){
		rigidbody = GetComponent<Rigidbody>();

	}
	void Update () {
		transform.position += transform.forward * speed * Time.deltaTime;
	}
	void FixedUpdate(){
		if(Input.GetKeyDown (KeyCode.Space) ){
				//if(fireRate > nextFire){
					//nextFire += Time.deltaTime ;}
				//else if(fireRate < nextFire){
					//fireRate = nextFire;}
				anim.SetTrigger("jump");
				rigidbody.AddForce(Vector3.up*100);
					//nextFire = 0.0f;
			}
		}
	}
