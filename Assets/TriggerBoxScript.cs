using UnityEngine;
using System.Collections;

public class TriggerBoxScript : MonoBehaviour {
	private GameObject parent;

	// Use this for initialization
	void Start () {
		parent = transform.parent.gameObject;
	}
	
	void OnTriggerEnter(Collider co) {
		if (parent.GetComponent<unitScript>().isRed) {
			GameObject.Find("PlayerCube").GetComponent<cubeMove>().setColor (1);
		}
		if (parent.GetComponent<unitScript>().isBlue) {
			GameObject.Find("PlayerCube").GetComponent<cubeMove>().setColor (2);
		}
		if (parent.GetComponent<unitScript>().isGreen) {
			GameObject.Find("PlayerCube").GetComponent<cubeMove>().setColor (3);
		}
		parent.GetComponent<unitScript> ().clearColor ();
	}
}
