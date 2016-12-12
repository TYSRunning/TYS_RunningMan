using UnityEngine;
using System.Collections;
[CreateAssetMenu(menuName = "Destructible")]
public class Destructible : ScriptableObject {

	public float health;

	public GameObject deadFX;


	void OnDestruction(){
	}
}
