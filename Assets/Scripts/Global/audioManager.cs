using UnityEngine;
using System.Collections;
 
public class audioManager : MonoBehaviour {
 
	public AudioSource Audio;
	float BGMvolume;
	void Awake() {


		DontDestroyOnLoad (GetComponent<AudioSource>());
    }



}