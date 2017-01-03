using UnityEngine;
using System.Collections;

public class unitScript : MonoBehaviour {
	private int randomAssign;
	public Material[] mats;
	Renderer rendA;

	public bool isRed = false;
	public bool isBlue = false;
	public bool isGreen = false;

	// Use this for initialization
	void Start () {

		rendA = transform.Find ("QuadA").GetComponent<Renderer> ();
		rendA.enabled = true;
		randomAssign = Random.Range (0, 20);

		if (randomAssign == 1) {
			rendA.sharedMaterial = mats[1];
			isRed = true;
		}
		if (randomAssign == 2) {
			rendA.sharedMaterial = mats[2];
			isBlue = true;
		}
		if (randomAssign == 3) {
			rendA.sharedMaterial = mats[3];
			isGreen = true;
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
	public void clearColor(){
		rendA.sharedMaterial = mats[0];
	}
}
