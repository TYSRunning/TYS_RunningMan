using UnityEngine;
using System.Collections;
public class Bgtrigger : MonoBehaviour
{
	GameObject bg;
	void Start()

	{

		bg = new GameObject();
	}

	void OnTriggerEnter(Collider e)

	{

		if (e.CompareTag("Player"))

		{

			if (gameObject.transform.parent.CompareTag("Plane2"))

			{

				bg = GameObject.FindGameObjectWithTag("Plane2");

				bg.transform.position = new Vector3(5, -1, bg.transform.position.z + 200);

			}

			else if (gameObject.transform.parent.CompareTag("Plane1"))

			{

				bg = GameObject.FindGameObjectWithTag("Plane1");

				bg.transform.position = new Vector3(5, -1, bg.transform.position.z + 200);

			}
		}

	}
}