using UnityEngine;
using System.Collections;

public class MoveSpawn : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float y = Random.Range (-5, 5);
		Vector3 curLoc = gameObject.transform.position;
		Vector3 location = curLoc;

		location.y = y;
		gameObject.transform.position = location;
	}
}
