using UnityEngine;
using System.Collections;


public class Spawner : MonoBehaviour {

	public Transform dot;
	public int i;
	// Use this for initialization

	void Start () {
		i = 0;
	}
	
	// Update is called once per frame
	void Update () {
		while (i == 0) 
		{
			Instantiate (dot, gameObject.transform.position, Quaternion.identity);
			i++;
		}
	}
}
