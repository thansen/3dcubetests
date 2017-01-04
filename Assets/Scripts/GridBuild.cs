using UnityEngine;
using System.Collections;

public class GridBuild : MonoBehaviour {

	public int gridSize;


	// Use this for initialization
	void Start () {

		Vector3 startPos = gameObject.transform.position;

		for (int i = 0; i < gridSize; i++) {

			for (int n = 0; n < gridSize; n++) {
				
				GameObject unit =
					Instantiate(Resources.Load("Unit"),
						new Vector3(n+(-i),-i,n*-1) + startPos,
						Quaternion.identity) as GameObject;
			}

		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
