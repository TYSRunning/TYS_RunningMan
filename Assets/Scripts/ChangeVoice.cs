using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeVoice : MonoBehaviour {
	

	public void ChangeVolume(){
		Slider slider = GetComponent<Slider> ();
		AudioSource source = GetComponent<AudioSource>();
		source.volume = slider.value;
	}
}
