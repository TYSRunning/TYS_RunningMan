using UnityEngine;
using System.Collections;

public class CoinFX : MonoBehaviour{
	private AudioSource audioSource;
	void Awake(){
		audioSource = GetComponent<AudioSource> ();
		Destroy (this.gameObject, audioSource.clip.length);
	}
}
