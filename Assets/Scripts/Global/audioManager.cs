using UnityEngine;
using System.Collections;
 
public class audioManager : MonoBehaviour {
 
    void Start() {

		DontDestroyOnLoad (GetComponent<AudioSource>());
    }


}