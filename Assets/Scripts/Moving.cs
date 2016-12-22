using UnityEngine;
using System.Collections;

public class Moving : MonoBehaviour {

	public float speed = 10.0f;
	public AudioClip jumpSound;
	[SerializeField] private Animator anim;
	private float tim;

	public float fireRate;

	private float nextFire;
	private Rigidbody rigidbody;

	private AudioSource source;

	void Awake(){
		source = GetComponent<AudioSource>();
		}
	void Start () {
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
			gameObject.GetComponentInChildren<ParticleSystem> ().Play ();
			source.PlayOneShot (jumpSound, 1F);	
			anim.SetTrigger("jump");
				rigidbody.AddForce(Vector3.up*100);
			}
		}


	}
