using UnityEngine;
using System.Collections;

public class MyCustomComponent : MonoBehaviour {
	private Transform ThisTransform = null;
	// Use this for initialization
	void Start () {
		ThisTransform = GetComponent<Transform>();
	}

	// Update is called once per frame
	void Update () {
		if(ThisTransform != null) {
			ThisTransform.localPosition +=
				Time.deltaTime * 10.0f * ThisTransform.forward;
		}
	}
}
