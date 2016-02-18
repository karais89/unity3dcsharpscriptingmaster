using UnityEngine;
using System.Collections;

public class ErrorMaker : MonoBehaviour {

	int valee1 = 7;
	int value2 = 0;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
		int value3 = valee1 / value2;
	}
}
