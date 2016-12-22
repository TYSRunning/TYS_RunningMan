using UnityEngine;
using System.Collections;
using UnityEngine.Audio;
public class audioManager : MonoBehaviour {
 
	public AudioMixer mixer;

	float BGMvolume;
	void Awake() {
		DontDestroyOnLoad (gameObject);
    }



}