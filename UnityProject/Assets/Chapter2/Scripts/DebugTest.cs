using UnityEngine;
using System.Collections;

public class DebugTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Transform[] Objs = Object.FindObjectsOfType<Transform>();

		for(int i = 0; i < Objs.Length; i++) {
			Objs[i].position = Vector3.zero;
		}

		Func01();
	}

	void Func01() {
		Func02();
	}

	void Func02() {
		Func03();
	}

	void Func03() {
		Debug.Log("Entered Function 3");
	}
}
