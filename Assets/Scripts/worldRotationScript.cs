using UnityEngine;
using System.Collections;

public class worldRotationScript : MonoBehaviour {
	public GameObject cube;
	public Camera camera;
	Vector3 currentCubePos;
	bool rotateIsQueued ;

	public int worldRotationState;

	// Use this for initialization
	void Start () {
		rotateIsQueued = false;
		worldRotationState = 1;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKeyDown (KeyCode.R)) {
			rotateIsQueued = true;
		}
		if (rotateIsQueued && cube.GetComponent<cubeMove>().isRotate == false) {
			if (worldRotationState == 1) {
				currentCubePos = cube.transform.localPosition;
				transform.position = currentCubePos;
				Time.timeScale = 0.0F;
				cube.transform.localPosition = new Vector3 (0,0,0);
				Time.timeScale = 1.0F;
				transform.eulerAngles = new Vector3 (0, 90, -90);

		//		camera.transform.eulerAngles = new Vector3 (45, 45, 240);
				camera.GetComponent<Animation>().Play();

				worldRotationState = 2;
			}
		}

	
	}
}
